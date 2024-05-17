import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { propertytype } from '../models/propertyType.response';

@Injectable({
  providedIn: 'root'
})
export class PropertytypeService {

  constructor(private http:HttpClient) { }

  getPropertyTypes(): Observable<propertytype[]> {
    return this.http.get<propertytype[]>(`${environment.apiBaseUrl}/api/PropertyType`);
  }
}
