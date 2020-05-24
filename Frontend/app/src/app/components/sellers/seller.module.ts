import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ListSellerModule } from './list-seller/list-seller.module';
import { CreateSellerModule } from './create-seller/create-seller.module';
import { DeleteSellerModule } from './delete-seller/delete-seller.module';
import { DetailSellerModule } from './detail-seller/detail-seller.module';
import { EditSellerModule } from './edit-seller/edit-seller.module';

@NgModule({
  imports: [
    CommonModule,
    ListSellerModule,
    CreateSellerModule,
    DeleteSellerModule,
    DetailSellerModule,
    EditSellerModule
  ],
})
export class SellerModule { }
