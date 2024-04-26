import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({ templateUrl: 'home.component.html' })
export class homeComponent {
  constructor(private router: Router) {
  }

  goToProductDetail() {
    this.router.navigate(['/productDetail']);
  }

}
