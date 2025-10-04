import { Component, OnInit } from '@angular/core';
import { EmpDetailsService } from 'src/app/shared/emp-details.service';
import { NgForm } from "@angular/forms";
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-emp-details-form',
  templateUrl: './emp-details-form.component.html',
  styles: []
})
export class EmpDetailsFormComponent implements OnInit {

  formSubmitted: boolean = false;
  submissionSuccess: boolean | null = null; // Define submissionSuccess property

  workExperiences = [
    { title: '', company: '', from: '', to: '', salary: '' }
  ];

  courses = [
    { name: '', center: '', from: '', to: '' }
  ];

  constructor(public service: EmpDetailsService) {}

  ngOnInit(): void {}

  addJob() {
    this.workExperiences.push({ title: '', company: '', from: '', to: '', salary: '' });
  }

  removeJob(index: number) {
    this.workExperiences.splice(index, 1);
  }

  addCourse() {
    this.courses.push({ name: '', center: '', from: '', to: '' });
  }

  removeCourse(index: number) {
    this.courses.splice(index, 1);
  }

  onSubmit(form: NgForm) {
    this.formSubmitted = true;

    if (form.valid) {
      this.service.postEmpDetails()
        .subscribe({
          next: res => {
            this.service.restForm(form);
            this.formSubmitted = false;
            this.submissionSuccess = true;  // Indicate successful submission
          },
          error: err => { 
            console.log(err);
            this.submissionSuccess = false; // Indicate submission failure
          }
        });
    } else {
      this.submissionSuccess = false; // Set to false if form is invalid
    }
  }
}
