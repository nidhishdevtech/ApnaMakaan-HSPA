import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { city } from '../models/city.response';

@Injectable({
  providedIn: 'root'
})
export class CityService {

  constructor(private http:HttpClient) { }

  getCity(): Observable<city[]> {
    return this.http.get<city[]>(`${environment.apiBaseUrl}/api/City`);
  }
}
