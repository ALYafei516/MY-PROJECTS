import { Injectable } from '@angular/core';
import { HttpClient } from "@angular/common/http";
import { environment } from 'src/environments/environment';
import { EmpDetails } from './emp-details.model';
import { NgForm } from '@angular/forms';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class EmpDetailsService {

  url:string = environment.apiBaseUrl + '/EmpDetails'
  list: EmpDetails[]= []
  formData : EmpDetails = new EmpDetails()
  formSubmitted: boolean = false;
  constructor(private http: HttpClient) { }


  refreshList(){
    this.http.get(this.url)
    .subscribe({
      next: res => {
        this.list = res as EmpDetails[]
      },
      error: err => { console.log(err) }
    })
  }

  postEmpDetails(){

   return this.http.post(this.url,this.formData)
  }

  restForm(form:NgForm){
    form.form.reset()
    this.formData = new EmpDetails()
  }


  deleteEmpDetails(employeeId: number) {
    return this.http.delete(`${this.url}/${employeeId}`);
  }

}
 





