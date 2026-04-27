import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { ChangeDetectorRef } from '@angular/core';
import { DatePipe } from '@angular/common';
import { Game } from '../games.models';
import { GamesService } from '../games.service';
import { Observable, of } from 'rxjs';
import { AsyncPipe } from '@angular/common';

@Component({
    selector: 'app-selected-game',
    standalone: true,
    imports: [DatePipe, AsyncPipe],
    templateUrl: './selected-game.component.html',
    styleUrls: ['./selected-game.component.css']
})
export class SelectedGameComponent {
    game$: Observable<Game> = of({
        id: 0,
        title: '',
        genre: '',
        releaseDate: '',
        rating: 0,
        description: '',
        coverImageUrl: ''
    });

    constructor(private router: Router, private gamesService: GamesService, private cdRef: ChangeDetectorRef) { }

    ngOnInit(): void {
        const urlSegments = this.router.url.split('/');
        const gameId = urlSegments[2]; // Assuming the URL is in the format /games/:id/:slug

        this.game$ = this.gamesService.getGameById(gameId);
    }
}