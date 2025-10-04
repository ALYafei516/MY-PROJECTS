import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from "@angular/common/http";
import { AppComponent } from './app.component';
import { EmpDetailsComponent } from './emp-details/emp-details.component';
import { EmpDetailsFormComponent } from './emp-details/emp-details-form/emp-details-form.component';
import { FormsModule } from '@angular/forms';
import { SiteHeaderComponent } from './site-header/site-header.component';
import { AppRoutingModule } from './app-routing.module';




@NgModule({
  declarations: [
    AppComponent,
    EmpDetailsComponent,
    EmpDetailsFormComponent,
    SiteHeaderComponent,
   
   
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    FormsModule,
    AppRoutingModule
  
   
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
