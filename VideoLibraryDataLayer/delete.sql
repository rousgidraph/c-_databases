--select * from INFORMATION_SCHEMA.TABLES;
/*
if exists(select * from Roles, Users where users.UserId='218498B0-55B2-4EF4-A296-D2E48496457B' and Roles.ApplicationId = Users.ApplicationId)
Begin
	if exists(select * from Checkouts where VideoId = 3 and ReturnDate is not null)
	begin
	update Videos set IsDeleted = 1 where VideoId = 3;
	end

	if not exists(select * from Checkouts where VideoId = 3)
	begin
	update Videos set IsDeleted = 1 where VideoId = 3;
	end
End;

select * from Videos;

select * from Checkouts;

*/

select * from Roles, Users where  Roles.ApplicationId = Users.ApplicationId

--select * from Videos;

--insert into Reviews(VideoId, UserId, Review) values(42, '218498B0-55B2-4EF4-A296-D2E48496457B', 'Very interresting and engaging. Would recommend')

select * from Reviews;