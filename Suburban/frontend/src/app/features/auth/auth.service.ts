import { Injectable } from "@angular/core";
import { LoginRequest, RegisterRequest } from "./auth.models";
import { environment } from "../../../environments/environments";
import { HttpClient } from "@angular/common/http";

@Injectable({
    providedIn: 'root'
})
export class AuthService {
    constructor(private http: HttpClient) { }

    login(loginRequest: LoginRequest): void {
        // Implement login logic here
        // Call the backend API using environment.apiUrl and handle the response

        this.http.post(`${environment.apiUrl}/auth/login`, loginRequest, { withCredentials: true }).subscribe({
            next: (response) => {
                console.log('Login successful:', response);

            },
            error: (error) => {
                console.error('Login failed:', error);
            }
        });


        console.log('Logging in with email:', loginRequest.email);
        console.log('Password:', loginRequest.password);
    }

    logout(): void {
        // Implement logout logic here
        console.log('Logging out');
    }

    register(registerRequest: RegisterRequest): void {
        // Implement registration logic here
        // Call the backend API using environment.apiUrl and handle the response

        this.http.post(`${environment.apiUrl}/auth/register`, registerRequest, { withCredentials: true }).subscribe({
            next: (response) => {
                console.log('Registration successful:', response);
            },
            error: (error) => {
                console.error('Registration failed:', error);
            }
        });

        console.log('Registering with email:', registerRequest.email);
        console.log('name:', registerRequest.name);
        console.log('Password:', registerRequest.password);
    }
}