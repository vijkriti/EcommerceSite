import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';

export interface ProductOrder {
  Id: number;          
  ProductId: number;
  TotalAmount: number;
  Quantity: number;
  UserId: string;
  OrderDate: string;
}

@Injectable({
  providedIn: 'root'
})
export class ProductordersService {
  private baseUrl = 'https://localhost:7244/api/ProductOrders';

  constructor(private http: HttpClient) { }

  postProductOrder(order: ProductOrder): Observable<any> {
    return this.http.post<ProductOrder>(this.baseUrl, order, {
      headers: new HttpHeaders({
        'Content-Type': 'application/json'
      })
    });
  }
}
