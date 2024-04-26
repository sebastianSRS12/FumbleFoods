import { Component, Input } from '@angular/core';
import { ProfileOption } from '../profile-option.model';

@Component({
  selector: 'app-profile-option',
  templateUrl: './profile-option.component.html',
  styleUrls: ['./profile-option.component.css']
})
export class ProfileOptionComponent {
  @Input() option: ProfileOption | undefined;

  constructor() { }
}
