import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({ templateUrl: 'register.component.html' })
export class registerComponent {
  constructor(private router: Router) {
  }

  goToLogin() {
    this.router.navigate(['/login']);
  }

  goToHome() {
    this.router.navigate(['/home']);
  }

}
