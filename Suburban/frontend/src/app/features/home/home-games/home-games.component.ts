import { Component } from '@angular/core';
import { ChangeDetectorRef } from '@angular/core';
import { Router } from '@angular/router';
import { Game, GetGamesRequest, GetGamesResponse } from '../../games/games.models';
import { GamesService } from '../../games/games.service';
import { Observable, of, startWith, Subject, scan, switchMap, BehaviorSubject } from 'rxjs';
import { AsyncPipe } from '@angular/common';
import { SearchComponent } from '../../games/search/search.component';
import { HostListener } from '@angular/core';

@Component({
    selector: 'app-home-games',
    standalone: true,
    imports: [AsyncPipe, SearchComponent],
    templateUrl: './home-games.component.html',
    styleUrls: ['./home-games.component.css']
})
export class HomeGamesComponent {

    private gamesSubject = new BehaviorSubject<Game[]>([]);
    games$ = this.gamesSubject.asObservable();
    isNew: boolean = true;

    activeGames = new Set<number>();

    private isLoading = false;

    getGamesRequest: GetGamesRequest = {
        page: 1,
        pageSize: 18,
        query: ''
    };

    constructor(private gamesService: GamesService,
        private changeDetectorRef: ChangeDetectorRef, private router: Router) { }

    ngOnInit(): void {
        this.loadMoreGames();
        this.getGamesRequest.page = 18 / 6;
        this.getGamesRequest.pageSize = 6;
    }

    onGameClick(game: Game): void {
        const slug = game.title.toLowerCase()
            .trim()
            .replace(/[^\w\s-]/g, '')
            .replace(/\s+/g, '-');

        this.router.navigate(['/games', game.id, slug]);

        console.log(`Navigating to game: ${game.title} with ID: ${game.id}`);
    }

    gamesChanged(games$: Observable<Game[]>): void {
        this.games$ = games$;
    }

    @HostListener('window:scroll', [])
    onWindowScroll() {
        const scrollTop = window.scrollY;
        const viewportHeight = window.innerHeight;
        const fullHeight = document.documentElement.scrollHeight;

        console.log(`Scroll Top: ${scrollTop}, Viewport Height: ${viewportHeight}, Full Height: ${fullHeight}`);

        if (scrollTop + viewportHeight >= (fullHeight - 50)) {
            console.log('Reached bottom of page');
            this.loadMoreGames();
        }
    }

    loadMoreGames(): void {
        if (this.isLoading) return;
        this.isLoading = true;

        this.gamesService.getGames(this.getGamesRequest).subscribe({
            next: (response) => {
                const current = this.gamesSubject.getValue();
                this.gamesSubject.next([...current, ...response]);

                response.forEach(game => this.markGame(game.id));

                this.getGamesRequest.page++;
                this.isLoading = false;
            },
            error: () => {
                this.isLoading = false;
            }
        });
    }

    markGame(gameId: number): void {
        this.activeGames.add(gameId);

        setTimeout(() => {
            this.activeGames.delete(gameId);
            this.changeDetectorRef.markForCheck();
        }, 300);
    }

}