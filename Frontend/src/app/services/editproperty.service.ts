import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { editproperty } from '../models/editproperty.request';
import { propertydetail } from '../models/propertydetail.response';
import { updateproperty } from '../models/updateproperty.model';

@Injectable({
  providedIn: 'root'
})
export class EditpropertyService {

  constructor(private http: HttpClient) { }

  getPropertyById(id:number):Observable<editproperty>{
   return this.http.get<editproperty>(`${environment.apiBaseUrl}/api/Property/${id}`)
  }

  updateproperty(id:number,updateproperty:updateproperty):Observable<editproperty>{
    return this.http.put<editproperty>(`${environment.apiBaseUrl}/api/Property/${id}`,
    updateproperty);
  }

 



}
