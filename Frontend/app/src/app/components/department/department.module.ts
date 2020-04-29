import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CreateDepartmentModule } from './create-department/create-department.module';
import { ListDepartmentModule } from './list-department/list-department.module';

@NgModule({
  imports: [
    CommonModule,
    ListDepartmentModule,
    CreateDepartmentModule
  ],
})
export class DepartmentModule { }
