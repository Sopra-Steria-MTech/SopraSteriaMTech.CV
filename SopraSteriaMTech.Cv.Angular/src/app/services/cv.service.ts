import { HttpClient } from '@angular/common/http';
import { Inject, inject, Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Cv } from '../../models/cv.model';
import { environment } from '../../environments/environment';

@Injectable({
  providedIn: 'root'
})
export class CvService {

  constructor(private httpClient:HttpClient) { }

  public GetCv() : Observable<Cv>{
    return this.httpClient.get<Cv>(`${environment.url}/cv`);
  }

  public UploadFile(file:File) : Observable<string>{
    const formData = new FormData();

    formData.append("file", file);

    return this.httpClient.post<string>(`${environment.url}/cv/personalia/foto/upload`, formData);
  }
}
