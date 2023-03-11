use AddressBookService;

--view table 
select * from AddressBook;

--update person city by person firstName
create PROCEDURE spUpdateContacts
@firstName nvarchar(200),
@City varchar(200)
AS
update AddressBook set city=@City where firstName=@firstName ;

--Add new Contacts
create PROCEDURE spAddNewPerson
@firstName nvarchar(200),
@lastName varchar(200),
@address varchar(200),
@city varchar(200),
@state varchar(100),
@zipcode bigint,
@phoneNumber bigint,
@email varchar(200)
AS
insert into AddressBook(firstName,lastName,address,city,state, zipcode, phoneNumber, email)values (@firstName,@lastName,@address,@city,@state,@zipcode,@phoneNumber,@email);
