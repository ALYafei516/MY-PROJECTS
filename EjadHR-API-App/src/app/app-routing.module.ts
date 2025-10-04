import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Route, RouterModule, Routes } from '@angular/router';
import { EmpDetailsComponent } from './emp-details/emp-details.component';
import { EmpDetailsFormComponent } from './emp-details/emp-details-form/emp-details-form.component';


const routes: Routes = [
{path: 'admin', component: EmpDetailsComponent },
{path: 'user', component: EmpDetailsFormComponent }


];

@NgModule({
  declarations: [],
  imports: [
    CommonModule,RouterModule.forRoot(routes) ],
    exports:[RouterModule] 
})
export class AppRoutingModule { }
