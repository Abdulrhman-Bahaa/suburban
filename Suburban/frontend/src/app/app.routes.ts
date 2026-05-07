import { Routes } from '@angular/router';

export const routes: Routes = [
    {
        path: '',
        redirectTo: 'home',
        pathMatch: 'full'
    },

    {
        path: 'login',
        redirectTo: 'auth/login',
        pathMatch: 'full'
    },

    {
        path: 'register',
        redirectTo: 'auth/register',
        pathMatch: 'full'
    },

    {
        path: 'auth',
        loadChildren: () =>
            import('./features/auth/auth.routes')
                .then(m => m.authRoutes)
    },
    {
        path: 'home' + '',
        loadChildren: () =>
            import('./features/home/home.routes')
                .then(m => m.homeRoutes)
    },
    {
        path: 'games',
        loadChildren: () =>
            import('./features/games/games.routes')
                .then(m => m.gamesRoutes)
    }
];