import { Component, OnInit } from '@angular/core';
import { Department } from 'src/app/core/models/department';
import { Router, ActivatedRoute } from '@angular/router';
import { DepartmentService } from 'src/app/core/services/department/department.service';

@Component({
  selector: 'app-edit-department',
  templateUrl: './edit-department.component.html',
  styleUrls: ['./edit-department.component.css']
})
export class EditDepartmentComponent implements OnInit {
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

}
