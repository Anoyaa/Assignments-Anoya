const students= [ {
    "FirstName": "John",
    "LastName": "Doe",
    "Age": 20,
    "Department": "Computer Science"
  },
  {
    "FirstName": "Jane",
    "LastName": "Smith",
    "Age": 22,
    "Department": "Physics"
  },
  {
    "FirstName": "Michael",
    "LastName": "Johnson",
    "Age": 21, 
    "Department": "Mathematics"
  },
  {
    "FirstName": "Sarah",
    "LastName": "Williams",
    "Age": 19,
    "Department": "Computer Science"
  },
  {
    "FirstName": "Robert",
    "LastName": "Brown",
    "Age": 23,
    "Department": "Mathematics"
  },
  {
    "FirstName": "Emily",
    "LastName": "Davis",
    "Age": 20,
    "Department": "Computer Science"
  }
];

const student=students.filter(student=>student.Department==='Computer Science');
console.log(student);

const stname=students.filter(student=>student.Age>21).map(student=>student.FirstName);
console.log(stname);

const strobsci=students.some(student=>student.FirstName==='Robert' && student.Department==='computer science');
console.log(strobsci);

const elder23=students.some(student=>student.Age>23 && student.Department==='Maths');
console.log(elder23);

const above18=students.every(student=>student.Age>18);
console.log("the condition that all are above 18yrs of age is"+above18);

const johnFirst=students.filter(student=>student.FirstName==='John').map(student=>student.Department);
console.log(johnFirst);

