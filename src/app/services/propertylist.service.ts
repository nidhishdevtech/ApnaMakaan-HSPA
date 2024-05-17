import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { propertylistcard } from '../models/propertylistcard.response';
import {propertybyuser} from '../models/propertybyuser.response';
import { environment } from 'src/environments/environment.development';

@Injectable({
  providedIn: 'root'
})
export class PropertylistService {

  constructor(private http:HttpClient) { }

  getAllProperties():Observable<propertylistcard[]>{
    return this.http.get<propertylistcard[]>(`${environment.apiBaseUrl}/api/Property`);
  }

  getAllPropertiesforRent():Observable<propertylistcard[]>{
    return this.http.get<propertylistcard[]>(`${environment.apiBaseUrl}/PropertyForRent`);
  }

  getAllPropertiesforSale():Observable<propertylistcard[]>{
    return this.http.get<propertylistcard[]>(`${environment.apiBaseUrl}/PropertyForSale`);
  }

  getPropertiesbyUser(id:number):Observable<propertybyuser>{
    return this.http.get<propertybyuser>(`${environment.apiBaseUrl}/api/User/UserWithProperty/${id}`)
  }


}
