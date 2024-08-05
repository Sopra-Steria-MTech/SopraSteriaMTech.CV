import { Component, Input } from '@angular/core';
import { Opleiding } from '../../../models/opleiding.model';
import { DateToShort } from '../../../shared-functions/date.functions';

@Component({
  selector: 'app-opleidingen',
  templateUrl: './opleidingen.component.html',
  styleUrl: './opleidingen.component.css'
})
export class OpleidingenComponent {
  @Input()
  opleidingen: Opleiding[] = []

  DateToShort(date: string) {
    return DateToShort(date);
  }
}
