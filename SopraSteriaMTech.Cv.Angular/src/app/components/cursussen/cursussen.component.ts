import { Component, Input } from '@angular/core';
import { Cursus } from '../../../models/cursus.model';
import { DateToShort } from '../../../shared-functions/date.functions'

@Component({
  selector: 'app-cursussen',
  templateUrl: './cursussen.component.html',
  styleUrl: './cursussen.component.css'
})
export class CursussenComponent {
  @Input()
  cursussen: Cursus[] = []

  DateToShort(date: string) {
    return DateToShort(date);
  }
}
