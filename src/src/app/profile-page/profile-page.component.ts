import { Component,OnInit } from "@angular/core";
import { ProfileService } from '../profile/profile.service';
import { ProfileOption } from '../profile/profile-option.model';

@Component({
  selector: 'app-profile-page',
  templateUrl: './profile-page.component.html',
  styleUrls: ['./profile-page.component.css']
})
export class ProfilePageComponent implements OnInit {
  profileOptions: ProfileOption[] = [];

  constructor(private profileService: ProfileService) { }

  ngOnInit(): void {
    this.profileOptions = this.profileService.getProfileOptions();
  }
}

