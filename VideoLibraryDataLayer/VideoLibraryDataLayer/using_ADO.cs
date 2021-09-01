using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace UCSD.VideoLibrary
{
    class using_ADO : IVideoLibraryDAL
    {
        private string connectionString = @"Data Source=BOG-WATER\SQLEXPRESS;Initial Catalog=VideoLibraryDB;Persist Security Info=True;User ID=sa;Password=strongpassword";
        private SqlConnection cnn;

        private  void open_connection() {
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            //MessageBox.Show("Connection Open  !");
        }

        private  void close_connection() {
            cnn.Close();
        }

        public Collection<VideoSearchResult> return_all() {
            Collection<VideoSearchResult> result = new Collection<VideoSearchResult>();

            open_connection();
            SqlCommand command;
            SqlDataReader datareader;
            string sql;
            sql = "select * from Videos ;";
            command = new SqlCommand(sql, cnn);
            datareader = command.ExecuteReader();
            while (datareader.Read()) {
                VideoSearchResult res = new VideoSearchResult();
                res.VideoId = datareader.GetInt32(0);
                res.Title = datareader.GetString(1);
                res.Year = datareader.GetInt32(2);
                res.Director = datareader.GetString(3);
                result.Add(res);
            }

            close_connection();

            return result;
        }

        public int AddReview(int videoId, Guid userId, string reviewText)
        {
            if (reviewText.Length < 0)
            {
                throw new NullReferenceException ("You need to suppluy a review ");
                return -1;
            }
            int result = -1;
            open_connection();
            SqlCommand command;
            string sql;
            SqlDataAdapter dataAdapter = new SqlDataAdapter();

            sql = "BEGIN TRY " +
                "select* from Users where UserId = '"+userId+"';" +

                "END TRY; " +
                "BEGIN CATCH ; " +
                "PRINT 'In catch block.';" +
                "THROW 51000, 'That user doesnt exist', 1;" +
                "return; " +
                    "END CATCH ; " +
                    "if not exists(select * from Videos where VideoId = '"+videoId+"' )" +
                "begin;" +
           " print('That video doesnt exists ');" +
            "THROW 51000, 'That video doesnt exist',1;" +
            "return;" +
            "end;" +

            "if exists(select * from Videos where VideoId = '" + videoId + "'  and IsDeleted = 1)" +
            "begin;" +
            "print('That video is deleted ');" +
            "THROW 51000, 'That video has been deleted ',1;" +
            "return; " +
            "end;" +
            "insert into Reviews(VideoId, UserId, Review) values('" + videoId + "' , '"+userId+"', '"+reviewText+"');";

            command = new SqlCommand(sql, cnn);
            dataAdapter.InsertCommand = new SqlCommand(sql, cnn);
            dataAdapter.InsertCommand.ExecuteNonQuery();

            command.Dispose();

            close_connection();
            return result;
        }

        public void AddUpdateRating(int videoId, Guid userId, int rating)
        {
            throw new NotImplementedException();
        }

        public int AddUpdateVideo(VideoInfo video, Guid userId)
        {
            int result = -1;
            open_connection();
            SqlCommand command;
            String sql = "";
            SqlDataAdapter adapter = new SqlDataAdapter();
            //data confirmation 
            if ((video.Director == null) || (video.Year ==null) ||(video.Title ==null) ||(video.TotalCopies < 0)) {
                throw new NullReferenceException("THe video data is missing important information");
                return -1;
            
            }
            

            if (video.VideoId == 0) {
                //insert new record 
                sql = "if exists (select * from Roles, Users where users.UserId = '"+userId+"' and Roles.ApplicationId = Users.ApplicationId)"+
                "begin" +
                "insert into Videos(Title, Year, Director, FormatCode, TotalCopies) values('" + video.Title + "', '" + video.Year + "', '" + video.Director + "', '" + video.Format + "', '" + video.TotalCopies + "');" +
                "end" +
                "else" +
                "    begin;" +
                "print('SOmething is up');" +
                "throw 51000, 'That user doesnt exists or isnt an admin', 1;" +
                "end;";
                command = new SqlCommand(sql, cnn);
                adapter.InsertCommand = new SqlCommand(sql, cnn);
                adapter.InsertCommand.ExecuteNonQuery();
                command.Dispose();

            } else if(video.VideoId > 0){
                //update video 
                sql = "if exists (select * from Roles, Users where users.UserId = '" + userId + "'' and Roles.ApplicationId = Users.ApplicationId)" +
                "begin" +
                "update  Videos set Title = '"+video.Title+"', Year = '"+video.Year+"', Director= '"+video.Director+"', FormatCode = '"+video.Format+"', TotalCopies = '"+video.TotalCopies+"';" +
                "end" +
                "else" +
                "    begin;" +
                "print('SOmething is up');" +
                "throw 51000, 'That user doesnt exists or isnt an admin', 1;" +
                "end;";

                command = new SqlCommand(sql, cnn);
                adapter.UpdateCommand = new SqlCommand(sql, cnn);
                adapter.UpdateCommand.ExecuteNonQuery();
                command.Dispose();


            }


            close_connection();

            return result;
        }

        public void CheckInVideo(int videoId, Guid userId)
        {
            throw new NotImplementedException();
        }

        public void CheckOutVideo(int videoId, Guid userId)
        {
            throw new NotImplementedException();
        }

        public void DeleteVideo(int videoId, Guid userId)
        {
            open_connection();
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            string sql = "";

            sql = "if exists(select * from Roles, Users where users.UserId='"+userId+"' and Roles.ApplicationId = Users.ApplicationId)" +
                "Begin"+"if exists(select * from Checkouts where VideoId = '"+videoId+"' and ReturnDate is not null)"+
                         "begin"+
                            "update Videos set IsDeleted = 1 where VideoId = '" + videoId + "';" +
                         "end " +
                         "if not exists(select * from Checkouts where VideoId = '" + videoId + "')" +
                    "begin"+
                     "update Videos set IsDeleted = 1 where VideoId = '" + videoId + "';" +
                       "end"+
                    "End; ";

            command = new SqlCommand(sql, cnn);
            adapter.UpdateCommand = new SqlCommand(sql, cnn);
            adapter.UpdateCommand.ExecuteNonQuery();

            command.Dispose();


            close_connection();
            
        }

        public Collection<VideoSearchResult> SearchVideoLibrary(VideoSearchCriteria criteria)
        {
            Collection<VideoSearchResult> results = new Collection<VideoSearchResult>();
            open_connection();
            SqlCommand command;
            SqlDataReader datareader;
            string sql;

            sql = "select * from Videos ";
            //Title like '"+criteria.Title+"' or Director like '"+criteria.Director+"' or Year like '"+criteria.Year+"' ";
            if (criteria.Title != null && criteria.Title.Length > 0) {
                sql = "select * from Videos where Title like '%"+criteria.Title+"%' ; ";
            }else 
            if (criteria.Director != null && criteria.Director.Length > 0) { 
                sql = "select * from Videos where Director like '%"+criteria.Director+"%' ; ";

            }else
            if (criteria.Year != null &&  criteria.Year.ToString().Length > 0) { 
                sql = "select * from Videos where Year = '"+criteria.Year+"' ; ";

            }

            command = new SqlCommand(sql, cnn);
            datareader = command.ExecuteReader();
            while (datareader.Read())
            {
                VideoSearchResult res = new VideoSearchResult();
                res.VideoId = datareader.GetInt32(0);
                res.Title = datareader.GetString(1);
                res.Year = datareader.GetInt32(2);
                res.Director = datareader.GetString(3);
                results.Add(res);
            }
            close_connection();
            return results;
        }

        public void UpdateReview(int reviewId, string reviewText)
        {
            throw new NotImplementedException();
        }
    }
}
