import { SellersService } from './../../../core/services/sellers/sellers.service';
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Department } from 'src/app/core/models/department';
import { DepartmentService } from 'src/app/core/services/department/department.service';
import { of } from 'rxjs';
import { Router } from '@angular/router';

@Component({
  selector: 'app-create-seller',
  templateUrl: './create-seller.component.html',
  styleUrls: ['./create-seller.component.css']
})
export class CreateSellerComponent implements OnInit {

  createSellerForm: FormGroup;
  departments: Department[] = [];
  constructor(private router: Router, private fb: FormBuilder,
    private departmentService: DepartmentService, private service: SellersService) { }

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
      department: ['']
    });
  }

  createSeller() {
    this.service.createSeller(this.createSellerForm.value)
      .subscribe(result => {
        this.router.navigate(['/seller'])
      });
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
