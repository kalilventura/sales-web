import { Seller } from './../../models/seller';
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from '../../../../environments/environment';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class SellersService {

  constructor(private http: HttpClient) { }

  private apiSeller = `${environment.apiBaseUrl}/api/Sellers`;

  getAllSellers(): Observable<Seller[]> {
    return this.http.get<Seller[]>(this.apiSeller);
  }

  getSellerById(id: string): Observable<Seller> {
    return this.http.get<Seller>(this.apiSeller);
  }
}
