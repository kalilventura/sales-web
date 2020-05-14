import { SellersService } from './../../../core/services/sellers/sellers.service';
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Department } from 'src/app/core/models/department';
import { DepartmentService } from 'src/app/core/services/department/department.service';
import { of } from 'rxjs';

@Component({
  selector: 'app-create-seller',
  templateUrl: './create-seller.component.html',
  styleUrls: ['./create-seller.component.css']
})
export class CreateSellerComponent implements OnInit {

  createSellerForm: FormGroup;
  departments: Department[] = [];
  constructor(private fb: FormBuilder, private departmentService: DepartmentService, private service: SellersService) { }

  ngOnInit(): void {
    this.createForm();
    this.listAllDepartments();
  }

  createForm() {
    this.createSellerForm = this.fb.group({
      name: ['', [Validators.required]],
      email: ['', [Validators.required]],
      birthDate: ['', [Validators.required]],
      baseSalary: ['', [Validators.required]],
      departments: ['']
    });
  }

  createSeller() {
    console.log(this.createSellerForm.value);
  }

  listAllDepartments() {
    of(this.departmentService.allDepartments()).subscribe(response => {
      response.subscribe(r => {
        this.departments = r.data;
        this.createSellerForm.controls.departments.patchValue(this.departments[0].id);
      })
    });
  }

}
