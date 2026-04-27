import { Routes } from '@angular/router';
import { HomeGamesComponent } from './home-games/home-games.component';

export const authRoutes: Routes = [
    {
        path: '',
        component: HomeGamesComponent
    }
];