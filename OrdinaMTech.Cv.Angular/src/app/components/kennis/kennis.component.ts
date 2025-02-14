import { Component, Input } from '@angular/core';
import { Ervaring } from '../../../models/ervaring.model';
import { Kennis } from '../../../models/kennis.model';

@Component({
  selector: 'app-kennis',
  templateUrl: './kennis.component.html',
  styleUrl: './kennis.component.css'
})
export class KennisComponent {
  @Input()
  kennis: Kennis[] = []
}
