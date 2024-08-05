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
    

    /**
     *  var bytes = new byte[0];
        var file = files.FirstOrDefault();
        if (file != null)
        {
            status = "Uploading...";
            var fileStreamContent = new StreamContent(file.Data);
            bytes = await fileStreamContent.ReadAsByteArrayAsync();
            using (var formData = new MultipartFormDataContent())
            {
                // Add the HttpContent objects to the form data
                formData.Add(fileStreamContent, "file", file.Name);

                var response = await apiService.UploadFotoAsync(formData);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    status = string.Empty;
                    using var stream = await response.Content.ReadAsStreamAsync();
                    var jsonReader = new StreamReader(stream).ReadToEnd();
                    foto = JsonConvert.DeserializeObject<byte[]>(jsonReader);
                }
                else
                {
                    status = await response.Content.ReadAsStringAsync();
                }
            }
        }
     */
  }
}
