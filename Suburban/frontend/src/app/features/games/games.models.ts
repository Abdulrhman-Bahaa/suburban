export interface GetGamesRequest {
    page: number;
    pageSize: number;
    query?: string;
}

export interface Game {
    id: number;
    title: string;
    genre: string;
    releaseDate: string;
    rating: number;
    description: string;
    coverImageUrl: string;
}

export type GetGamesResponse = Game[];
