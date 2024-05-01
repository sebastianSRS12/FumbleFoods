import { Component } from '@angular/core';
import { RouterOutlet, RouterModule, Router } from '@angular/router';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [
    CommonModule,
    RouterModule,
    RouterOutlet
  ],
  templateUrl: './cart.component.html',
  styleUrls: ['./cart.component.css']
})
export class cartComponent {
  title = 'cartPage';
  items = [
    { id: 1, quantity: 1, name: '...', description: '...', price: 10, picture: 'https://github.com/TysonVeik/FumbleFoods/blob/3137bdf3e4c260c843bfcd417191d83237461182/FumbleFoods.webp?raw=ture', },
    { id: 2, quantity: 1, name: '...', description: '...', price: 20, picture: 'https://github.com/TysonVeik/FumbleFoods/blob/3137bdf3e4c260c843bfcd417191d83237461182/FumbleFoods.webp?raw=ture', },
  ];

  constructor(private router: Router) {
  }

  goToCheckout() {
    this.router.navigate(['/checkout']);
  }

  increaseQuantity(item: any): void {
    item.quantity++;
  }

  decreaseQuantity(item: any): void {
    if (item.quantity > 1) {
      item.quantity--;
    }
  }

  deleteItem(itemId: number): void {
    this.items = this.items.filter(item => item.id !== itemId);
  }

  getTotalPrice(): number {
    return this.items
      .reduce((total, item) => total + (item.price * item.quantity), 0);
  }
}
