import { Component, Input } from '@angular/core';
import { Ervaring } from '../../../models/ervaring.model';
import { DateToShort } from '../../../shared-functions/date.functions';

@Component({
  selector: 'app-werkervaring',
  templateUrl: './werkervaring.component.html',
  styleUrl: './werkervaring.component.css'
})
export class WerkervaringComponent {
  @Input()
  werkErvaring : Ervaring[] = [];

  DateToShort(date:string){
    return DateToShort(date);
  }
}
