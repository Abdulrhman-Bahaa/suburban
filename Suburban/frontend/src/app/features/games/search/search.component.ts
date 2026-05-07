import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { ChangeDetectorRef } from '@angular/core';
import { DatePipe } from '@angular/common';
import { Observable, of } from 'rxjs';
import { AsyncPipe } from '@angular/common';
import { Output, EventEmitter } from '@angular/core';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';

import { Game } from '../games.models';
import { GamesService } from '../games.service';

@Component({
  selector: 'app-search',
  standalone: true,
  imports: [DatePipe, AsyncPipe, MatFormFieldModule, MatInputModule],
  templateUrl: './search.component.html',
  styleUrls: ['./search.component.css'],
})
export class SearchComponent {
  games$: Observable<Game[]> = of([]);

  @Output() gamesChanged = new EventEmitter<Observable<Game[]>>();

  constructor(
    private router: Router,
    private gamesService: GamesService,
    private cdRef: ChangeDetectorRef,
  ) {}

  onSearch(query: string): void {
    this.gamesService.getGames({ page: 1, pageSize: 20, query: query }).subscribe((games) => {
      this.games$ = of(games);
      console.log(games, query);
      this.gamesChanged.emit(this.games$);
    });
  }
}
