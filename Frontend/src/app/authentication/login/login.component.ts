import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { FormGroup, FormControl, Validators, ReactiveFormsModule } from '@angular/forms';
import loginData from '../../core/data.json';
import { CommonModule } from '@angular/common';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { MatIconModule } from '@angular/material/icon';

@Component({
  selector: 'app-login',
  standalone: true,
  imports: [CommonModule, ReactiveFormsModule, MatFormFieldModule, MatInputModule, MatIconModule],
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  email: string = '';
  password: string = '';

  loginForm!: FormGroup;

  constructor(private router: Router) {}

  ngOnInit() {
    this.loginForm = new FormGroup({
      email: new FormControl('', [Validators.required, Validators.email]),
      password: new FormControl('', [Validators.required])
    });

    const isLoggedIn = localStorage.getItem('isLoggedIn') === 'true';
    if (isLoggedIn) {
      this.router.navigate(['/commercial/dashboard']);
    }
  }

  onSubmit() {
    const credentials = loginData.login_credentials;
    const user = credentials.find((cred: any) =>
      cred.email === this.loginForm.get('email')?.value && cred.password === this.loginForm.get('password')?.value
    );

    if (user) {
      localStorage.setItem('isLoggedIn', 'true');
      localStorage.setItem('username', user.email);
      this.router.navigate(['/commercial/dashboard']);
    } else {
      alert("Invalid email or password");
    }
  }
}
