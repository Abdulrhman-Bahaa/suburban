import { Routes } from '@angular/router';

export const routes: Routes = [
    {
        path: 'auth',
        loadChildren: () =>
            import('./features/auth/auth.routes')
                .then(m => m.authRoutes)
    },
    {
        path: 'home',
        loadChildren: () =>
            import('./features/home/home.routes')
                .then(m => m.authRoutes)
    },
    {
        path: 'games',
        loadChildren: () =>
            import('./features/games/games.routes')
                .then(m => m.authRoutes)
    }
];