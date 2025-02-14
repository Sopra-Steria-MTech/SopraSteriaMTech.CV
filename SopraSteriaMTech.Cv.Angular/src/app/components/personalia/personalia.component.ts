import { Component, Input } from '@angular/core';
import { Personalia } from '../../../models/personalia.model';
import { DateToLong } from '../../../shared-functions/date.functions';

@Component({
  selector: 'app-personalia',
  templateUrl: './personalia.component.html',
  styleUrl: './personalia.component.css'
})
export class PersonaliaComponent {
  @Input()
  personalia: Personalia | null = null;

  DateToLong(date:string){
    return DateToLong(date);
  }
}
