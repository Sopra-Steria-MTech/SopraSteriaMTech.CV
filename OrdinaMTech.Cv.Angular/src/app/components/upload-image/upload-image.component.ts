import { Component, Input } from '@angular/core';
import { CvService } from '../../services/cv.service';

@Component({
  selector: 'app-upload-image',
  templateUrl: './upload-image.component.html',
  styleUrl: './upload-image.component.css'
})
export class UploadImageComponent {
  @Input()
  foto: string | null = null;
  status: string | null = null;

  constructor(private cvService : CvService){

  }


  uploadFile(event: Event) {
    const element = event.currentTarget as HTMLInputElement;
    if (element.files == null || element.files.length == 0) {
      return;
    }

    this.status = "Uploading..."

    this.cvService.UploadFile(element.files[0]).subscribe(result =>{
      this.foto = result;
    })
  }
}
