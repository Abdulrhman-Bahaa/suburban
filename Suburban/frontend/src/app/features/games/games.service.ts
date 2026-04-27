import { Injectable } from "@angular/core";
import { HttpClient } from "@angular/common/http";

import { GetGamesResponse, GetGamesRequest, Game } from "./games.models";
import { environment } from "../../../environments/environments";

@Injectable({
    providedIn: 'root'
})
export class GamesService {
    constructor(private http: HttpClient) { }


    getGames(request: GetGamesRequest) {
        return this.http.get<GetGamesResponse>(`${environment.apiUrl}/games`, {
            params: {
                page: request.page.toString(),
                pageSize: request.pageSize.toString(),
                query: request.query || ''
            }
        });
    }

    getGameById(gameId: string) {
        return this.http.get<Game>(`${environment.apiUrl}/games/${gameId}`);
    }
}