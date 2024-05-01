import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ProfilePageComponent } from '../profile-page/profile-page.component';
import { ProfileOptionComponent } from './profile-option/profile-option.component';

@NgModule({
  declarations: [ProfilePageComponent, ProfileOptionComponent],
  imports: [
    CommonModule
  ],
  exports: [ProfilePageComponent, ProfileOptionComponent]
})
export class ProfileModule { }
