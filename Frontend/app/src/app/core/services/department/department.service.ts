import { HttpClient, HttpParams } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Department } from './../../models/department';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class DepartmentService {

  private urlApi = '';
  constructor(private http: HttpClient) { }

  createDepartment(department: Department): Observable<Department> {
    return this.http.post<Department>(this.urlApi, department);
  }

  getAllDepartments(): Observable<Department[]> {
    return this.http.get<Department[]>(this.urlApi);
  }

  getDepartmentById(id: string): Observable<Department> {
    let params = new HttpParams();
    params = params.append('id', id);
    return this.http.get<Department>(this.urlApi, { params });
  }

}
