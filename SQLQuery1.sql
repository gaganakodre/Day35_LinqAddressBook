create database AddressBook_linq;
DROP TABLE AddressBookLinq;
create table AddressBookLinq(
  ID int, 
          FirstName varchar(200), 
         LastName varchar(200),
         Address varchar(200),
        City varchar(200),
        State varchar(200),
        Zip varchar(200),
        PhoneNumber varchar(200),
        Email varchar(200),
        AddressBookName varchar(200),
        AddressBookType varchar(200));
		select * from AddressBookLinq;


insert into AddressBookLinq values(  1, 'Shree', 'Gowri', 'Rtc Layout', 'Bengaluru', 'Karnataka', '4232', '12345', 'TVfc@gmail.com', 'AddressBook1', 'Family' ),
(  2, 'Lokesh', 'gowda', 'Rtc Layout', 'Bengaluru', 'Karnataka', '4232', '12343', 'TVfc@gmail.com', 'AddressBook1', 'Friends' ),
(  3, 'jaganatha', 'reddy', 'HSR Layout', 'Hydrabad', 'Telangana', '4232', '12345', 'TVok@gmail.com', 'AddressBook2', 'Professional' ),
(  4, 'jadadeesha', 'luhur', 'RCB Layout', 'Hydrabad', 'Telangana', '4232', '12345', 'TVc@gmail.com', 'AddressBook1', 'Professional' ),
(  5, 'kalavathi', 'jaga', 'HSDG Layout', 'VijayaWada', 'AndraPradesh', '4232', '12345', 'TVtffc@gmail.com', 'AddressBook2', 'Friends' ),
(  6, 'Swati', 'koduru', 'DDJDJ Layout', 'VijayaWada', 'AndraPradesh', '4232', '12345', 'TVfefffc@gmail.com', 'AddressBoo3', 'Family' ),
(  7, 'sheshank', 'yk', 'ayanagara', 'Bengaluru', 'Karnataka', '4232', '12345', 'TVfqwec@gmail.com', 'AddressBook1', 'Friends' );
                