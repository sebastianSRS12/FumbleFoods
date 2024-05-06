import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Feature } from '../models/feature.model';
import { FeatureService } from '../services/feature.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  features: Feature[] = [];

  constructor(
    private featureService: FeatureService,
    private router: Router
  ) { }

  ngOnInit(): void {
    this.features = this.featureService.getFeatures();
  }

  navigate(link: string): void {
    this.router.navigate([link]);
  }
}
