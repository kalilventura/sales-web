import { CommonModule } from '@angular/common';
import { DeleteDepartmentComponent } from './delete-department.component';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';

@NgModule({
  declarations: [
    DeleteDepartmentComponent
  ],
  imports: [
    FormsModule,
    CommonModule
  ],
  exports: []
})
export class DeleteDepartmentModule { }
