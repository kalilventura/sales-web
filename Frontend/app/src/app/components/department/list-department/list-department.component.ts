import { Department } from './../../../core/models/department';
import { DepartmentService } from './../../../core/services/department/department.service';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { faTrash, faEdit, faBars } from '@fortawesome/free-solid-svg-icons';

@Component({
  selector: 'app-list-department',
  templateUrl: './list-department.component.html',
  styleUrls: ['./list-department.component.css']
})
export class ListDepartmentComponent implements OnInit {

  departments: Department[];
  trashIcon = faTrash;
  editIcon = faEdit;
  infoIcon = faBars;
  constructor(private router: Router, private service: DepartmentService) { }

  ngOnInit(): void {
    this.listDepartments(1, 5000);
  }

  listDepartments(currentPage: number, pageSize: number): any {
    this.service.getAllDepartments(currentPage, pageSize)
      .subscribe(response => {
        this.departments = response.data.results;
      });
  }

  editDepartment(department: Department) {
    console.log(department);
    this.router.navigate([`/department/edit/${department.id}`]);
  }

  deleteDepartment(department: Department) {
    console.log(department);
    this.router.navigate([`/department/delete/${department.id}`]);
  }

  detailDepartment(department: Department) {
    console.log(department);
    this.router.navigate([`/department/detail/${department.id}`]);
  }

  createDepartment() {
    this.router.navigate(['/department/create']);
  }

}
