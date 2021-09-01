

/*
if exists (select * from Roles, Users where users.UserId = '95311E31-AEF6-4B42-A86E-5E7AE16A770F' and Roles.ApplicationId = Users.ApplicationId)
begin 
insert into Videos (Title, Year, Director, FormatCode, TotalCopies) values ('sample ',9999,'Directa','DVD',56);
end 
else
begin;
	print('SOmething is up');
	throw 51000, 'That user doesnt exists or isnt an admin', 1;
end;
*/

select * from Users, Roles where Users.ApplicationId = Roles.ApplicationId;

--select * from Videos;

