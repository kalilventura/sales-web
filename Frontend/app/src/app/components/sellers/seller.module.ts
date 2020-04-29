import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CreateDepartmentModule } from '../department/create-department/create-department.module';
import { ListSellerModule } from './list-seller/list-seller.module';

@NgModule({
  imports: [
    CommonModule,
    CreateDepartmentModule,
    ListSellerModule
  ],
})
export class SellerModule { }
