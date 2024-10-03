-- Healthcare System Schema

CREATE TABLE Patients (
    PatientID INT PRIMARY KEY,
    PatientName VARCHAR(100),
    DateOfBirth DATE,
    Gender VARCHAR(10)
);

CREATE TABLE Doctors (
    DoctorID INT PRIMARY KEY,
    DoctorName VARCHAR(100),
    Specialty VARCHAR(100)
);

CREATE TABLE Appointments (
    AppointmentID INT PRIMARY KEY,
    PatientID INT,
    DoctorID INT,
    AppointmentDate DATE,
    FOREIGN KEY (PatientID) REFERENCES Patients(PatientID),
    FOREIGN KEY (DoctorID) REFERENCES Doctors(DoctorID)
);

CREATE TABLE Medications (
    MedicationID INT PRIMARY KEY,
    MedicationName VARCHAR(200),
    DosageForm VARCHAR(50)
);

CREATE TABLE Prescriptions (
    PrescriptionID INT PRIMARY KEY,
    PatientID INT,
    MedicationID INT,
    PrescriptionDate DATE,
    FOREIGN KEY (PatientID) REFERENCES Patients(PatientID),
    FOREIGN KEY (MedicationID) REFERENCES Medications(MedicationID)
);

-- Questions

-- 1. List all patients and their appointments, including patients who have never had an appointment.
select * from patients left join appointments on patients.Patientid=appointments.patientid ;

-- 2. Display all doctors and their scheduled appointments, including doctors without any appointments.
select * from doctors left join appointments on doctors.doctorid=appointments.doctorid ;

-- 3. Show all medications and the patients they've been prescribed to, including medications that haven't been prescribed.
select * from medications left join prescriptions on medications.medicationid=prescriptions.medicationid;

-- 4. List all possible patient-doctor combinations, regardless of whether an appointment has occurred.
select * from doctors cross join patients;

-- 5. Display all prescriptions with patient and medication information, including prescriptions where either the patient or medication information is missing.
select * from prescriptions pr left join patients p  on p.patientid=pr.patientid left join medications m on pr.medicationid=m.medicationid;

-- 6. Show all patients who have never been prescribed any medication, along with their appointment history.
select * from patients p left join prescriptions pr on p.patientid=pr.patientid left join medications m on m.medicationid=pr.medicationid left join appointments a on a.patientid=p.patientid where a.patientid is null;

-- 7. List all doctors who have appointments in the next week, along with the patients they're scheduled to see.
select * from doctors d left join appointments a on d.doctorid=a.doctorid left join patients p on p.patientid=a.patientid where datename(week,a.appointmentdate)=datename(week,getdate())+1;

-- 8. Display all medications prescribed to patients over 60 years old, including medications not prescribed to this age group.
select * from patients p left join prescriptions pr on p.patientid=pr.patientid where  pr.medicationid IS NOT NULL;

-- 9. Show all appointments from last year and any associated prescription information.
select * from appointments a left join prescriptions pr on a.patientid=pr.patientid where year(a.appointmentdate)=year(getdate())-1 ;

-- 10. List all possible specialty-medication combinations, regardless of whether a doctor of that specialty has prescribed that medication.
select * from doctors cross join medications ;
