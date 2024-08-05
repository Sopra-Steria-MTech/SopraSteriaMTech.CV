import { Component, Input } from '@angular/core';
import { Ervaring } from '../../../models/ervaring.model';

@Component({
  selector: 'app-werkervaring',
  templateUrl: './werkervaring.component.html',
  styleUrl: './werkervaring.component.css'
})
export class WerkervaringComponent {
  @Input()
  werkErvaring : Ervaring[] = [];
}
