/*
BEGIN TRY  
    select * from Users where UserId = 'random';
  
END TRY  
BEGIN CATCH  
  
    PRINT 'In catch block.';  
    THROW 51000, 'That user doesnt exist', 1 ;  
    return 
END CATCH;  
  
if not exists (select * from Videos where VideoId = 899 )
begin;
    print('That video doesnt exists ');
    THROW 51000, 'That vide ohas been deleted ',1;
    return ;
end;

if exists (select * from Videos where VideoId = 899 and IsDeleted = 1 )
begin;
    print('That video is deleted ');
    THROW 51000, 'That vide ohas been deleted ',1;
    return;
end;


insert into Reviews (VideoId,UserId,Review) values(899,6565,'Some text');
 */


 select * from Users;
 select * from Videos;
