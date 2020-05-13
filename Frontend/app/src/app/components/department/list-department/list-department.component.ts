import { Department } from './../../../core/models/department';
import { DepartmentService } from './../../../core/services/department/department.service';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-list-department',
  templateUrl: './list-department.component.html',
  styleUrls: ['./list-department.component.css']
})
export class ListDepartmentComponent implements OnInit {

  departments: Department[];
  constructor(private router: Router, private service: DepartmentService) { }

  ngOnInit(): void {
    this.listDepartments(1, 5);
  }

  listDepartments(currentPage: number, pageSize: number): any {
    this.service.getAllDepartments(currentPage, pageSize)
      .subscribe(response => {
        this.departments = response.data.results;
      });
  }

  editDepartment(department: Department) {
    console.log('edit');
    console.log(department);
  }

  deleteDepartment(department: Department) {
    console.log('delete');
    console.log(department);
  }

  createDepartment() {
    this.router.navigate(['/department/create']);
  }

}
