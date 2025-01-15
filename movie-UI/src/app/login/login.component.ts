import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login',
  imports: [],
  templateUrl: './login.component.html',
  styleUrl: './login.component.scss',
  standalone: true
})
export class LoginComponent {

  constructor(private router: Router) {

  }
  onSubmit() {

  }
  onRegister() {
    this.router.navigate(['/register'])
  }
}
