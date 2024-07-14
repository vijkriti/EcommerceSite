import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class BrandService {

  private baseUrl = 'https://localhost:7244/api/Brands';

  constructor(private http: HttpClient) { }

  getAllBrands(): Observable<any[]> {
    return this.http.get<any[]>(this.baseUrl);
  }
}
