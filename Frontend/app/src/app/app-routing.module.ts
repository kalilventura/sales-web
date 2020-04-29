import { CreateSellerComponent } from './components/sellers/create-seller/create-seller.component';
import { ListSellerComponent } from './components/sellers/list-seller/list-seller.component';
import { CreateDepartmentComponent } from './components/department/create-department/create-department.component';
import { ListDepartmentComponent } from './components/department/list-department/list-department.component';
import { HomeComponent } from './components/home/home.component';
import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';


const routes: Routes = [
  { path: '', component: HomeComponent },
  { path: 'department', component: ListDepartmentComponent },
  { path: 'department/create', component: CreateDepartmentComponent },
  { path: 'seller', component: ListSellerComponent },
  { path: 'seller/create', component: CreateSellerComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
