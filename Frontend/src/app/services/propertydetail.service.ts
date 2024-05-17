import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment.development';
import { propertydetail } from '../models/propertydetail.response';

@Injectable({
  providedIn: 'root'
})
export class PropertydetailService {

  constructor(private http:HttpClient) { }

  getPropertyById(id:number):Observable<propertydetail>{
    return this.http.get<propertydetail>(`${environment.apiBaseUrl}/api/Property/${id}`)
  }
}
