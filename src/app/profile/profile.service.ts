import { Injectable } from '@angular/core';
import { ProfileOption } from './profile-option.model';

@Injectable({
  providedIn: 'root'
})
export class ProfileService {
  getProfileOptions(): ProfileOption[] {
    return [
      {
        title: 'Your Orders',
        description: 'Track, return, cancel order, view order history',
        icon: 'assets/FF YourOrders.webp',
        link: '/orders' // Routing to order page
      },
      {
        title: 'Security',
        description: 'Edit login, authentication, and personal information',
        icon: 'assets/FF Security.webp',
        link: '/security' // Routing to security page
      },
      {
        title: 'Preferences',
        description: 'View and modify your site and product preferences',
        icon: 'assets/FF Preferences.png',
        link: '/preferences' // Routing to preferences page
      },
      {
        title: 'Grocery Lists',
        description: 'Create, edit, and view your grocery lists',
        icon: 'assets/FF GroceryLists.webp',
        link: '/grocerylists' //Routing to grocerylists page
      },
      {
        title: 'Memberships',
        description: 'Manage your FumbleFoods memberships and subscriptions',
        icon: 'assets/FF Memberships.webp',
        link: '/memberships' //Routing to memberships/subscriptions page
      },
      {
        title: 'Customer Support',
        description: 'Contact customer service, view FAQ, browse self-help options',
        icon: 'assets/FF Support.webp',
        link: '/support' //Routing to memberships/subscriptions page
      }
    ];
  }
}
