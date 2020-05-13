import { HttpClient, HttpParams } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Department } from './../../models/department';
import { Injectable } from '@angular/core';
import { GenericResult } from '../../models/generic-result';

@Injectable({
  providedIn: 'root'
})
export class DepartmentService {

  private urlApi = 'https://localhost:5001/api/Departments';
  constructor(private http: HttpClient) { }

  createDepartment(department: Department): Observable<Department> {
    return this.http.post<Department>(this.urlApi, department);
  }

  getAllDepartments(currentPage: number, pageSize: number): Observable<GenericResult> {
    return this.http.get<GenericResult>(`${this.urlApi}?currentPage=${currentPage}&pageSize=${pageSize}`);
  }

  getDepartmentById(id: string): Observable<GenericResult> {
    let params = new HttpParams();
    params = params.append('id', id);
    return this.http.get<GenericResult>(this.urlApi, { params });
  }

}
