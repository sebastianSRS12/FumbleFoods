import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({ templateUrl: 'login.component.html' })
export class loginComponent {
  constructor(private router: Router) {
  }

  goToRegister() {
    this.router.navigate(['/register']);
  }

  goToHome() {
    this.router.navigate(['/home']);
  }
}
