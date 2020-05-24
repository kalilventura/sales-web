import { SellerModule } from './components/sellers/seller.module';
import { DepartmentModule } from './components/department/department.module';
import { HomeModule } from './components/home/home.module';
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { MenuModule } from './template/menu/menu.module';
import { FooterComponent } from './template/footer/footer.component';
import { NavComponent } from './template/nav/nav.component';

import { HttpClientModule } from '@angular/common/http';
import { NotFoundComponent } from './components/error/not-found/not-found.component';
import { ErrorModule } from './components/error/error.module';

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
    SellerModule,
    HttpClientModule,
    ErrorModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
