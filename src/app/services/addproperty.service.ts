import { HttpClient} from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { addproperty } from '../models/addproperty.request';
import { propertylistcard } from '../models/propertylistcard.response';

@Injectable({
  providedIn: 'root'
})
export class AddpropertyService {

  constructor(private http:HttpClient) { }


  createAddProperty(data:addproperty):Observable<propertylistcard>
  {
  return this.http.post<propertylistcard>(`${environment.apiBaseUrl}/api/Property`,data);

  }



}
