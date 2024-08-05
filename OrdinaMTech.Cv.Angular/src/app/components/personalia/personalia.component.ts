import { Component, Input } from '@angular/core';
import { Personalia } from '../../../models/personalia.model';

@Component({
  selector: 'app-personalia',
  templateUrl: './personalia.component.html',
  styleUrl: './personalia.component.css'
})
export class PersonaliaComponent {
  @Input()
  personalia: Personalia | null = null;
}
