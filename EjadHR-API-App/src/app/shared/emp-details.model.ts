export class EmpDetails {
    employeeId: number = 0;
    name: string = "";
    email: string = "";
    phone: string = "";
    linkedin: string = "";

    // Job-related fields
    jobTitle: string = "";
    companyName: string = "";
    companyFrom: Date | null = null;
    companyTo: Date | null = null;
    salary: number = 0;

    // Course-related fields
    courseName: string = "";
    courseCenter: string = "";
    courseFrom: Date | null = null;
    courseTo: Date | null = null;

    // CV file
    fileCV: Uint8Array | null = null;

    expanded?: boolean;
}

