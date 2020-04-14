import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CreateDepartmentModule } from './create/create-department.module';
import { ListDepartmentModule } from './list/list-department.module';

@NgModule({
  imports: [
    CommonModule,
    ListDepartmentModule,
    CreateDepartmentModule
  ],
})
export class DepartmentModule { }
