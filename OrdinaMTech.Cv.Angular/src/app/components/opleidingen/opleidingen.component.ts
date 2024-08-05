import { Component, Input } from '@angular/core';
import { Opleiding } from '../../../models/opleiding.model';

@Component({
  selector: 'app-opleidingen',
  templateUrl: './opleidingen.component.html',
  styleUrl: './opleidingen.component.css'
})
export class OpleidingenComponent {
  @Input()
  opleidingen: Opleiding[] = []
}
