-- Customers table
CREATE TABLE dbo.Customers
(
	CustomerID  INT IDENTITY (1,1) NOT NULL,
	FirstName	NVARCHAR(64) NOT NULL,
	LastName	NVARCHAR(64) NOT NULL,
	MiddleName  NVARCHAR(64) NOT NULL,
	DOB			DateTime NOT NULL,
	CAddress    NVARCHAR(256) NOT NULL,
	MailingAddress NVARCHAR(256),
	MailingCity NVARCHAR(64),
	City        NVARCHAR(64) NOT NULL,
	CState      NVARCHAR(64) NOT NULL,
	Zipcode     INT NOT NULL,
	MailingZip  INT,
	MailingState NVARCHAR(64),
	CONSTRAINT [PK_dbo.Customers] PRIMARY KEY CLUSTERED (CustomerID ASC)
);

INSERT INTO dbo.Customers (LastName, FirstName, MiddleName, DOB, CAddress, City, CState, Zipcode, MailingAddress, MailingCity, MailingState, MailingZip) VALUES 
	('Smith', 'John', 'Jacob', '1940-4-21', '1642 Columbus Way', 'Columbus', 'Ohio', 97442, '', '', '', 0),
	('Bot', 'Hax', 'The','2942-12-12', '2001 Binary Rd.', 'Colony X', 'Mars', 101010, 'PO Box 16', 'Mars City', 'Mars', 101010);

GO