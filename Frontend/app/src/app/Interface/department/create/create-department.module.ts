import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { CreateDepartmentComponent } from './create-department.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

@NgModule({
  declarations: [
    CreateDepartmentComponent
  ],
  imports: [
    CommonModule,
    FormsModule,
    ReactiveFormsModule
  ]
})
export class CreateDepartmentModule { }
