import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-list-department',
  templateUrl: './list-department.component.html',
  styleUrls: ['./list-department.component.css']
})
export class ListDepartmentComponent implements OnInit {

  constructor(private router: Router) { }

  ngOnInit(): void {
  }

  createDepartment() {
    this.router.navigate(['/department/create']);
  }

}
