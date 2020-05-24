import { DepartmentService } from './../../../core/services/department/department.service';
import { Department } from './../../../core/models/department';
import { Router, ActivatedRoute } from '@angular/router';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-delete-department',
  templateUrl: './delete-department.component.html',
  styleUrls: ['./delete-department.component.css']
})
export class DeleteDepartmentComponent implements OnInit {
  department: Department;
  constructor(private route: Router, private activatedRoute: ActivatedRoute, private service: DepartmentService) { }

  ngOnInit(): void {
    const id = this.activatedRoute.snapshot.paramMap.get('id');
    this.getDepartment(id);
  }

  getDepartment(id: string) {
    this.service.getDepartmentById(id).subscribe(result => this.department = result.data);
  }

  return() {
    this.route.navigate(['/department']);
  }

  delete(id: string) {
    console.log('Delete');
  }

}
