import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppComponent } from './app.component';
import { homeComponent } from './home';
import { loginComponent } from './login';
import { registerComponent } from './register';
import { ProfileModule } from './profile/profile.module';
import { checkoutComponent } from './checkout';
import { cartComponent } from './cart';
import { productDetailComponent } from './productDetail';
import { AppRoutingModule } from './app-routing.module';
import { Router } from '@angular/router';


@NgModule({
  declarations: [
    AppComponent,
    homeComponent,
    loginComponent,
    registerComponent,
    checkoutComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    ProfileModule,
    cartComponent,
    productDetailComponent
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule {
  constructor(private router: Router) {
  }

  goToHome() {
    this.router.navigate(['/home']);
  }
}



