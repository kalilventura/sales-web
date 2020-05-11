import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ListSellerModule } from './list-seller/list-seller.module';
import { CreateSellerModule } from './create-seller/create-seller.module';

@NgModule({
  imports: [
    CommonModule,
    ListSellerModule,
    CreateSellerModule
  ],
})
export class SellerModule { }
