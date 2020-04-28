import { CreateDepartmentComponent } from './components/department/create/create-department.component';
import { ListDepartmentComponent } from './components/department/list/list-department.component';
import { HomeComponent } from './components/home/home.component';
import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';


const routes: Routes = [
  { path: '', component: HomeComponent },
  { path: 'department', component: ListDepartmentComponent },
  { path: 'department/create', component: CreateDepartmentComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
