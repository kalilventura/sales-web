import { DepartmentModule } from './components/department/department.module';
import { HomeModule } from './components/home/home.module';
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { MenuModule } from './components/template/menu/menu.module';
import { FooterComponent } from './components/template/footer/footer.component';
import { NavComponent } from './components/template/nav/nav.component';

@NgModule({
  declarations: [
    AppComponent,
    FooterComponent,
    NavComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HomeModule,
    DepartmentModule,
    MenuModule,
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
