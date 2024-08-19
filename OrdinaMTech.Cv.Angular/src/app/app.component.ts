import { Component, OnInit } from '@angular/core';
import { Cv as Cv } from '../models/cv.model';
import { CvService } from './services/cv.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent implements OnInit {
  
  cv:Cv = new Cv();  

  constructor(private cvService: CvService){}

  ngOnInit(): void {
    this.cvService.GetCv().subscribe(result =>{
      this.cv = result;
    })
  }
}
