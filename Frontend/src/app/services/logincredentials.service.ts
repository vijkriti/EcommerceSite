import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class LogincredentialService {

  private baseUrl = 'https://localhost:7244/api/LoginCredentials';

  constructor(private http: HttpClient) { }

  getAllCredentials(): Observable<any[]> {
    return this.http.get<any[]>(this.baseUrl);
  }
}
