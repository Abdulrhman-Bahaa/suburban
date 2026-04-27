import { Routes } from '@angular/router';
import { SelectedGameComponent } from './selected-game/selected-game.component';
import { SearchComponent } from './search/search.component';

export const authRoutes: Routes = [
    {
        path: ':id/:slug',
        component: SelectedGameComponent
    },
    {
        path: 'search',
        component: SearchComponent
    }

];