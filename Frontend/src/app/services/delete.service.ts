import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class DeleteService {

  constructor(private http: HttpClient) { }

  deleteUser(id : number):Observable<boolean>{
    return this.http.delete<boolean>(`${environment.apiBaseUrl}/api/User/${id}`);
  }

  deleteProperty(id : number):Observable<boolean>{
    return this.http.delete<boolean>(`${environment.apiBaseUrl}/api/Property/${id}`);
}



}
