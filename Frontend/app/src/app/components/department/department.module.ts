import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CreateDepartmentModule } from './create-department/create-department.module';
import { ListDepartmentModule } from './list-department/list-department.module';
import { DeleteDepartmentModule } from './delete-department/delete-department.module';
import { DetailDepartmentModule } from './detail-department/detail-department.module';
import { EditDepartmentModule } from './edit-department/edit-department.module';

@NgModule({
  imports: [
    CommonModule,
    ListDepartmentModule,
    CreateDepartmentModule,
    DeleteDepartmentModule,
    DetailDepartmentModule,
    EditDepartmentModule
  ]
})
export class DepartmentModule { }
