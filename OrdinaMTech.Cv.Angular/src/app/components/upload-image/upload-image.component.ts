import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-upload-image',
  templateUrl: './upload-image.component.html',
  styleUrl: './upload-image.component.css'
})
export class UploadImageComponent {
  @Input()
  foto:string | null = null;
  
  status:string | null = null;
}
