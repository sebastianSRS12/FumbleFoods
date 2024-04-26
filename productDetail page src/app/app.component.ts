import { Component } from '@angular/core';
import { RouterOutlet, RouterModule } from '@angular/router';
import { CommonModule } from '@angular/common';


export class ProductItem {
  name: string;
  brand: string;
  shippingFrom: string;
  description: string;
  dimension: string;
  price: number;
  weight: number;
  productRating: number;
  picture: string;

  constructor(
    name: string,
    brand: string,
    shippingFrom: string,
    description: string,
    dimension: string,
    price: number,
    weight: number,
    productRating: number,
    picture: string
  ) {
    this.name = name;
    this.brand = brand;
    this.shippingFrom = shippingFrom;
    this.description = description;
    this.dimension = dimension;
    this.price = price;
    this.weight = weight;
    this.productRating = productRating;
    this.picture = picture;
  }
}

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [
    CommonModule,
    RouterModule
  ],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})


export class AppComponent {
  title = 'productDetailPage';

  item = new ProductItem(
    'Product A',
    'Brand A',
    'USA',
    'Description for Product A',
    '10cm',
    10,
    1,
    4.5,
    'https://github.com/TysonVeik/FumbleFoods/blob/3137bdf3e4c260c843bfcd417191d83237461182/FumbleFoods.webp?raw=ture'
  );

  items = [
    { picture: 'https://github.com/TysonVeik/FumbleFoods/blob/3137bdf3e4c260c843bfcd417191d83237461182/FumbleFoods.webp?raw=ture'},
    { picture: 'https://github.com/TysonVeik/FumbleFoods/blob/3137bdf3e4c260c843bfcd417191d83237461182/FumbleFoods.webp?raw=ture' },
    { picture: 'https://github.com/TysonVeik/FumbleFoods/blob/3137bdf3e4c260c843bfcd417191d83237461182/FumbleFoods.webp?raw=ture' },
    { picture: 'https://github.com/TysonVeik/FumbleFoods/blob/3137bdf3e4c260c843bfcd417191d83237461182/FumbleFoods.webp?raw=ture' },
  ];
}
