import { Component } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { CommonModule } from '@angular/common';
import { Router } from '@angular/router';
import { AuthService } from '../auth/auth.service';
import { environment } from '../../../environments/environments';

interface UserProfile {
  id: number;
  name: string;
  email: string;
}

@Component({
  selector: 'app-profile',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './profile.component.html',
  styleUrls: ['./profile.component.css'],
})
export class ProfileComponent {
  user$: Observable<UserProfile>;
  isLoggingOut = false;

  constructor(
    private http: HttpClient,
    private authService: AuthService,
    private router: Router,
  ) {
    this.user$ = this.http.get<UserProfile>(`${environment.apiUrl}/users/me`, {
      withCredentials: true,
    });
  }

  onLogout(): void {
    this.isLoggingOut = true;
    this.authService.logout().subscribe({
      next: () => this.router.navigate(['/auth/login']),
      error: () => {
        this.isLoggingOut = false;
      },
    });
  }
}
