import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { furnishingtype } from '../models/furnishingtype.response';

@Injectable({
  providedIn: 'root'
})
export class FurnishingtypeService {

  constructor(private http:HttpClient) { }

  getFurnishingTypes(): Observable<furnishingtype[]> {
    return this.http.get<furnishingtype[]>(`${environment.apiBaseUrl}/api/FurnishingType`);
  }
}
