import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { CreateSellerComponent } from './create-seller.component';
import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';

@NgModule({
  declarations: [
    CreateSellerComponent
  ],
  imports: [
    CommonModule,
    FormsModule,
    ReactiveFormsModule
  ]
})
export class CreateSellerModule { }
