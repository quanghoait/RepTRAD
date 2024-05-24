CREATE DATABASE TRVC_Data;
use TRVC_Data;
create table codegroup (
    IDCodeGroup int not null primary key AUTO_INCREMENT,
	CodeGroupName nvarchar(50) not null 
);
create  table Code(
   IDCode int primary key AUTO_INCREMENT,
	S_code char(50),
    F nvarchar(100),
    ITEM_NAME nvarchar(100),
    Account_No nvarchar(100),
    Bank nvarchar(100),
    Type nvarchar(100),
    CodeGroup nvarchar(100)
);
create  table CashVND(
   IDCash int primary key AUTO_INCREMENT,
	DayCash date,
    Decscription nvarchar(100),
    Income decimal,
	Payment decimal,
    Balance decimal,
	IDCode int,
    CONSTRAINT KN1 FOREIGN KEY (IDCode)  REFERENCES Code(IDCode)
);
create  table CashVCB(
   IDCashVCB int primary key AUTO_INCREMENT,
	DayCash date,
    Decscription nvarchar(100),
    Income double,
	Payment double,
    Balance double,
	IDCode int,
    CONSTRAINT KN2 FOREIGN KEY (IDCode)  REFERENCES Code(IDCode)
);

create  table CashMIZUHO(
   IDCashMIZUHO int primary key AUTO_INCREMENT,
	DayCash date,
    Decscription nvarchar(100),
    Income double,
	Payment double,
    Balance double,
	IDCode int,
    CONSTRAINT KN3 FOREIGN KEY (IDCode)  REFERENCES Code(IDCode)
);
create  table TotalCashVND(
   IDCashTotal int primary key AUTO_INCREMENT,
	DayCash date,
    Income double,
	Payment double,
    Balance double,
    IDCash int,
    IDCashVCB int,
    IDCashMIZUHO int,
	CONSTRAINT KN4 FOREIGN KEY (IDCash)  REFERENCES CashVND(IDCash),
    CONSTRAINT KN5 FOREIGN KEY (IDCashVCB)  REFERENCES CashVCB(IDCashVCB),
    CONSTRAINT KN6 FOREIGN KEY (IDCashMIZUHO)  REFERENCES CashMIZUHO(IDCashMIZUHO)
);

