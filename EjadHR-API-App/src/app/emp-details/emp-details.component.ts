import { Component, OnInit } from '@angular/core';
import { EmpDetailsService } from '../shared/emp-details.service';
import { DomSanitizer, SafeUrl } from '@angular/platform-browser';
import { EmpDetails } from '../shared/emp-details.model';

@Component({
  selector: 'app-emp-details',
  templateUrl: './emp-details.component.html',
  styles: []
})
export class EmpDetailsComponent implements OnInit {
  constructor(
    public service: EmpDetailsService,
    private sanitizer: DomSanitizer
  ) {}

  ngOnInit(): void {
    this.service.refreshList();
  }

  // Method to toggle the expansion of details for a specific employee
  toggleExpand(employee: EmpDetails): void {
    employee.expanded = !employee.expanded;
  }

  // Method to get a safe URL for downloading the CV
  getCVDownloadUrl(cvFile: Uint8Array): SafeUrl {
    const blob = new Blob([cvFile], { type: 'application/pdf' });
    const url = window.URL.createObjectURL(blob);
    return this.sanitizer.bypassSecurityTrustUrl(url);
  }

  // Method to confirm deletion and delete the application if confirmed
  confirmDelete(employee: EmpDetails): void {
    const confirmed = confirm(`Are you sure you want to delete ${employee.name}?`);
    if (confirmed) {
      this.deleteApplication(employee.employeeId);
    }
  }

  // Method to delete the application from the database
  private deleteApplication(employeeId: number): void {
    this.service.deleteEmpDetails(employeeId).subscribe({
      next: () => {
        this.service.refreshList(); // Refresh the list after deletion
        alert('Application deleted successfully');
      },
      error: err => {
        console.error('Error deleting application:', err);
        alert('Failed to delete the application');
      }
    });
  }
}
