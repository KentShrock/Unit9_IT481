/*Make sure we use the right database*/
Use Northwind;

/*we have three roles to create*/
CREATE ROLE SalesRole;
CREATE ROLE HRRole;
CREATE ROLE CEORole;

/*next, we add permissions to these three roles*/
GRANT SELECT ON dbo.Employees TO HRRole;
GRANT SELECT ON dbo.Orders TO SalesRole;
GRANT SELECT ON dbo.Customers TO SalesRole;
GRANT SELECT ON dbo.Employees TO CEORole;
GRANT SELECT ON dbo.Orders TO CEORole;
GRANT SELECT ON dbo.Customers TO CEORole;

/*next, make users and logins*/ 
CREATE USER User_Sales;
CREATE LOGIN User_Sales WITH PASSWORD ='123';
CREATE USER User_HR;
CREATE LOGIN User_HR WITH PASSWORD ='1234';
CREATE USER User_CEO;
CREATE LOGIN User_CEO WITH PASSWORD ='12345';

/*Lastly, assign roles to the users*/
EXEC sp_addrolemember 'SalesRole' , 'User_Sales';
EXEC sp_addrolemember 'HRRole' , 'User_HR';
EXEC sp_addrolemember 'CEORole' , 'User_CEO';