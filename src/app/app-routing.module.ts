import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './home';
import { loginComponent } from './login';
import { registerComponent } from './register';
import { checkoutComponent } from './checkout';
import { ProfilePageComponent } from './profile-page/profile-page.component';
import { cartComponent } from './cart';
import { productDetailComponent } from './productDetail';

const routes: Routes = [
  { path: '', component: HomeComponent },
  { path: 'login', component: loginComponent },
  { path: 'register', component: registerComponent },
  { path: 'profile', component: ProfilePageComponent },
  { path: 'checkout', component: checkoutComponent },
  { path: 'cart', component: cartComponent },
  { path: 'productDetail', component: productDetailComponent },
  { path: '**', redirectTo: '' }
];

@NgModule({
  declarations: [

  ],
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
