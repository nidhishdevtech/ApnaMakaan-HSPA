import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { User } from '../models/userdetail.response';

@Injectable({
  providedIn: 'root'
})
export class UserdetailService {


  constructor(private http:HttpClient) { }

  getAllUser():Observable<User[]>{
    return this.http.get<User[]>(`${environment.apiBaseUrl}/api/User`);
  }



}
