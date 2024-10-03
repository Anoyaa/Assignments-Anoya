-- Library Management Schema

CREATE TABLE Authors (
    AuthorID INT PRIMARY KEY,
    AuthorName VARCHAR(100),
    BirthYear INT
);

CREATE TABLE Books (
    BookID INT PRIMARY KEY,
    Title VARCHAR(200),
    AuthorID INT,
    PublicationYear INT,
    FOREIGN KEY (AuthorID) REFERENCES Authors(AuthorID)
);

CREATE TABLE Patrons (
    PatronID INT PRIMARY KEY,
    PatronName VARCHAR(100),
    MembershipDate DATE
);

CREATE TABLE Loans (
    LoanID INT PRIMARY KEY,
    BookID INT,
    PatronID INT,
    LoanDate DATE,
    ReturnDate DATE,
    FOREIGN KEY (BookID) REFERENCES Books(BookID),
    FOREIGN KEY (PatronID) REFERENCES Patrons(PatronID)
);

-- Questions

-- 1. List all books along with their authors, including books without assigned authors.
select * from books left join authors on books.authorid=authors.authorid;

-- 2. Display all patrons and their loan history, including patrons who have never borrowed a book.
select * from patrons left join loans on patrons.patronid=loans.patronid;

-- 3. Show all authors and the books they've written, including authors who haven't written any books in our collection.
select * from authors left join books on books.authorid=authors.authorid;

-- 4. List all possible book-patron combinations, regardless of whether a loan has occurred.
select * from books cross join patrons;

-- 5. Display all loans with book and patron information, including loans where either the book or patron information is missing.
select * from loans left join patrons on loans.patronid=patrons.patronid left join books on loans.bookid=books.bookid;

-- 6. Show all books that have never been loaned, along with their author information.
select * from books left join loans on books.bookid=loans.bookid where loans.bookid is null;

-- 7. List all patrons who have borrowed books in the last month, along with the books they've borrowed.
select patrons.patronname,books.title from patrons left join loans on loans.patronid=patrons.patronid left join books on loans.bookid=books.bookid where datediff(month,loans.loandate,getdate())=1;

-- 8. Display all authors born after 1970 and their books, including those without any books in our collection.
select * from authors left join books on books.authorid=authors.authorid where authors.birthyear>1970 ;

-- 9. Show all books published before 2000 and any associated loan information.
select * from books left join loans on loans.bookid=books.bookid where books.publicationyear<2000;

-- 10. List all possible author-patron combinations, regardless of whether the patron has borrowed a book by that author.
select * from authors cross join patrons; 
