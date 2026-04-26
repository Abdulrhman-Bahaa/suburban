import { Component } from '@angular/core';
import { FormBuilder, FormGroup, Validators, ReactiveFormsModule } from '@angular/forms';
import { AuthService } from '../auth.service';
import { LoginRequest } from '../auth.models';

@Component({
    selector: 'app-auth-login',
    standalone: true,
    imports: [ReactiveFormsModule],
    templateUrl: './login.component.html',
    styleUrls: ['./login.component.css']
})
export class LoginComponent {
    loginForm: FormGroup;

    constructor(private fb: FormBuilder, private authService: AuthService) {
        this.loginForm = this.fb.group({
            email: ['', [Validators.required, Validators.email]],
            password: ['', [Validators.required, Validators.minLength(6)]]
        });
    }

    onSubmit(): void {
        if (this.loginForm.valid) {
            const email = this.loginForm.get('email')?.value;
            const password = this.loginForm.get('password')?.value;

            const loginRequest: LoginRequest = { email, password };

            this.authService.login(loginRequest);
        } else {
            console.log('Form is invalid');
        }
    }
}