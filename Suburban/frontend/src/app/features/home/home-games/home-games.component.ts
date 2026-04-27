import { Component } from '@angular/core';
import { ChangeDetectorRef } from '@angular/core';
import { Router } from '@angular/router';
import { Game, GetGamesRequest, GetGamesResponse } from '../../games/games.models';
import { GamesService } from '../../games/games.service';
import { Observable, of } from 'rxjs';
import { AsyncPipe } from '@angular/common';
import { SearchComponent } from '../../games/search/search.component';

@Component({
    selector: 'app-home-games',
    standalone: true,
    imports: [AsyncPipe, SearchComponent],
    templateUrl: './home-games.component.html',
    styleUrls: ['./home-games.component.css']
})
export class HomeGamesComponent {

    games$: Observable<Game[]> = of([]);

    getGamesRequest: GetGamesRequest = {
        page: 1,
        pageSize: 10,
        query: ''
    };

    constructor(private gamesService: GamesService,
        private changeDetectorRef: ChangeDetectorRef, private router: Router) { }

    ngOnInit(): void {
        this.games$ = this.gamesService.getGames(this.getGamesRequest);
    }

    onGameClick(game: Game): void {
        // Handle game click event

        const slug = game.title.toLowerCase()
            .trim()
            .replace(/[^\w\s-]/g, '')
            .replace(/\s+/g, '-');

        this.router.navigate(['/games', game.id, slug]);

        console.log(`Navigating to game: ${game.title} with ID: ${game.id}`);
    }

    gamesChanged(games$: Observable<Game[]>): void {
        this.games$ = games$;
        // this.changeDetectorRef.detectChanges();
    }

}