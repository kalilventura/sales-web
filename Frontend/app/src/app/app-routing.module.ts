import { CreateDepartmentComponent } from './Interface/department/create/create-department.component';
import { ListDepartmentComponent } from './Interface/department/list/list-department.component';
import { HomeComponent } from './Interface/home/home.component';
import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';


const routes: Routes = [
  { path: '', component: HomeComponent },
  { path: 'department', component: ListDepartmentComponent },
  { path: 'department/create', component: CreateDepartmentComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
