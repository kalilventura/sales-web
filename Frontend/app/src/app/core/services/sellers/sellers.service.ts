import { Seller } from './../../models/seller';
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from '../../../../environments/environment';
import { Observable } from 'rxjs';
import { GenericResult } from '../../models/generic-result';

@Injectable({
  providedIn: 'root'
})
export class SellersService {

  private urlApi = 'https://localhost:5001/api/Sellers';
  constructor(private http: HttpClient) { }

  private apiSeller = `${environment.apiBaseUrl}/api/Sellers`;

  getAllSellers(currentPage: number, pageSize: number): Observable<GenericResult> {
    return this.http.get<GenericResult>(`${this.urlApi}?currentPage=${currentPage}&pageSize=${pageSize}`);
  }

  getSellerById(id: string): Observable<Seller> {
    return this.http.get<Seller>(this.apiSeller);
  }

  createSeller(seller: Seller): Observable<Seller> {
    seller.baseSalary = +seller.baseSalary;
    return this.http.post<Seller>(this.urlApi, seller);
  }
}
