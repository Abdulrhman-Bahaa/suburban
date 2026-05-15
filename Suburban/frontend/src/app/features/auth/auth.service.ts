import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { LoginRequest, LoginResponse, RegisterRequest } from './auth.models';
import { environment } from '../../../environments/environments';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root',
})
export class AuthService {
  constructor(private http: HttpClient) {}

  login(loginRequest: LoginRequest): Observable<LoginResponse> {
    return this.http.post<LoginResponse>(`${environment.apiUrl}/auth/login`, loginRequest, {
      withCredentials: true,
    });
  }

  logout(): Observable<void> {
    return this.http.post<void>(`${environment.apiUrl}/auth/logout`, null, {
      withCredentials: true,
    });
  }

  register(registerRequest: RegisterRequest): void {
    this.http
      .post(`${environment.apiUrl}/auth/register`, registerRequest, { withCredentials: true })
      .subscribe({
        next: (response) => {
          console.log('Registration successful:', response);
        },
        error: (error) => {
          console.error('Registration failed:', error);
        },
      });

    console.log('Registering with email:', registerRequest.email);
    console.log('name:', registerRequest.name);
    console.log('Password:', registerRequest.password);
  }
}
