import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { ChangeDetectorRef } from '@angular/core';
import { DatePipe } from '@angular/common';
import { Observable, of } from 'rxjs';
import { AsyncPipe } from '@angular/common';
import { Output, EventEmitter } from '@angular/core';

import { Game } from '../games.models';
import { GamesService } from '../games.service';

@Component({
    selector: 'app-search',
    standalone: true,
    imports: [DatePipe, AsyncPipe],
    templateUrl: './search.component.html',
    styleUrls: ['./search.component.css']
})
export class SearchComponent {
    games$: Observable<Game[]> = of([]);

    @Output() gamesChanged = new EventEmitter<Observable<Game[]>>();

    constructor(private router: Router, private gamesService: GamesService, private cdRef: ChangeDetectorRef) { }

    onSearch(query: string): void {
        // Implement search logic here, for example:
        // this.games$ = this.gamesService.getGames({ page: 1, pageSize: 1, query: query });
        // console.log(`Searching for games with query: ${query}`);
        // this.cdRef.detectChanges();

        this.gamesService.getGames({ page: 1, pageSize: 20, query: query }).subscribe(games => {
            this.games$ = of(games);
            console.log(games, query);
            this.gamesChanged.emit(this.games$);
        });
    }
}