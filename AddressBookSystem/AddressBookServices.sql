--UC1 Create Address Book Service Database
create database AddressBookService;
use AddressBookService;
-- delete table
drop table AddressBook;
--UC2 create a Address Book table
create Table AddressBook
(firstName varchar(100), lastName varchar(100), address varchar(300), city varchar(50), state varchar(300), zipcode int, phoneNumber bigint, email varchar(500), StartDate date);

--UC3 Ability to insert new Contacts to Address Book
insert into AddressBook values
('Anmol', 'Roy', 'MurariNagar', 'Khurja', 'UP', 203131, 7805982523, 'anmol122@gmail.com', '2018-10-12'),
('Riya', 'Sharma', 'PreetViharColony', 'Agra','UP', 784512, 9823659825, 'riya25@gmail.com','2020-05-21'),
('Piyush', 'Rao', 'VijayNagar', 'Noida', 'UP', 789456, 7502982523, 'piyus2504@gmail.com', '2019-11-13'),
('Amit', 'Singh', 'ShastriNagar', 'Meerut', 'UP', 258963, 9639026598, 'amit25@gmail.com', '2018-01-03'),
('Monika', 'Sharma', 'NewTehisl', 'Ghaziabad', 'UP', 898963, 8839026598, 'monika25@gmail.com', '2018-01-03'),
('Manisha', 'Gupta', 'KalindiKunj', 'Aligarh', 'UP', 357895, 7836152489, 'mahi258@gmail.com', '2016-12-03');

--View contacts in address book
select * from AddressBook;

--UC4 Ability to edit existing contact person using their name
update AddressBook set City='Ghaziabad' where firstName='Anmol';
update AddressBook set City='Ghaziabad' where firstName='Manisha';

--UC9 Ability to identify each Address Book with name and Type.
Update AddressBook set StartDate='2020-11-13' where firstName='Anmol';

--UC10 Ability to understand the size of address book by City and State
select Count(*) as Size_Of_Address_Book_By_City from AddressBook  where City='Ghaziabad';
select Count(*) as Size_Of_Address_Book_By_State from AddressBook  where State='UP';

--Retrieve Contacts from the Database that were added in a particular period
select * from AddressBook where StartDate between cast('2018-01-01' as date ) AND GETDATE();

--Retrieve Contacts from the Database by city or state
select * from AddressBook  where City='Ghaziabad' 
select * from AddressBook  where state='UP' 

--delete contact details by firstName
delete  AddressBook where firstName='Aakansha';