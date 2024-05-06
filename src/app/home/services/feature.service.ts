import { Injectable } from '@angular/core';
import { Feature } from '../models/feature.model';

@Injectable({
  providedIn: 'root'
})
export class FeatureService {
  constructor() { }

  getFeatures(): Feature[] {
    return [
      { id: '1', label: 'Temp Product Detail', imagePath: 'assets/images/temp-product.jpg', link: '/productDetail' },
      { id: '2', label: 'Meat', imagePath: 'assets/images/meat.jpg', link: '/meat' },
      { id: '3', label: 'Fruit', imagePath: 'assets/images/fruit.jpg', link: '/fruit' },
      { id: '4', label: 'Vegetables', imagePath: 'assets/images/vegetables.jpg', link: '/vegetables' },
      { id: '5', label: 'Dairy', imagePath: 'assets/images/dairy.jpg', link: '/dairy' },
      { id: '6', label: 'Featured Products', imagePath: 'assets/images/featured.jpg', link: '/featured' },
      { id: '7', label: 'Deals', imagePath: 'assets/images/deals.jpg', link: '/deals' }
    ];
  }
}
