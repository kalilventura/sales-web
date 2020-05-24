import { HttpClient, HttpParams } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Department } from './../../models/department';
import { Injectable } from '@angular/core';
import { GenericResult } from '../../models/generic-result';
import { environment as env } from '../../../../environments/environment';
@Injectable({
  providedIn: 'root'
})
export class DepartmentService {

  private urlApi = `${env.apiBaseUrl}/api/Departments`;
  constructor(private http: HttpClient) { }

  createDepartment(department: Department): Observable<Department> {
    return this.http.post<Department>(this.urlApi, department);
  }

  getAllDepartments(currentPage: number, pageSize: number): Observable<GenericResult> {
    return this.http.get<GenericResult>(`${this.urlApi}?currentPage=${currentPage}&pageSize=${pageSize}`);
  }

  allDepartments(): Observable<GenericResult> {
    return this.http.get<GenericResult>(`${this.urlApi}/AllDepartments`);
  }

  getDepartmentById(id: string): Observable<GenericResult> {
    return this.http.get<GenericResult>(`${this.urlApi}/${id}`);
  }

  deleteDepartment(id: string): Observable<GenericResult> {
    return this.http.delete<GenericResult>(`${this.urlApi}/${id}`);
  }

}
