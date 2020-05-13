import { DepartmentService } from './../../../core/services/department/department.service';
import { Component, OnInit } from '@angular/core';
import { FormGroup, Validators, FormBuilder } from '@angular/forms';
import { Router } from '@angular/router';

@Component({
  selector: 'app-create-department',
  templateUrl: './create-department.component.html',
  styleUrls: ['./create-department.component.css']
})
export class CreateDepartmentComponent implements OnInit {
  createDepartmentForm: FormGroup;
  constructor(private fb: FormBuilder, private service: DepartmentService, private router: Router) { }

  ngOnInit(): void {
    this.createForm();
  }

  createForm() {
    this.createDepartmentForm = this.fb.group({
      name: ['', [Validators.required]]
    });
  }

  saveDepartment() {
    console.log(this.createDepartmentForm.value);
    this.service
      .createDepartment(this.createDepartmentForm.value)
      .subscribe(result => {
        this.router.navigate(['/department'])
      });
  }
}
