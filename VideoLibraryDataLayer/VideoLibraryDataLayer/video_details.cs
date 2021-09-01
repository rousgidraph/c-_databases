using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UCSD.VideoLibrary
{
    public partial class video_details : Form
    {
        using_ADO ado = new using_ADO();
        public video_details()
        {
            InitializeComponent();
            txt_format.DataSource = Enum.GetValues(typeof(VideoFormat));
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            string directa, title;
            int year, copies;
            Guid user;
            
            

            directa = txt_director.Text;
            title = txt_title.Text;
            
            user = Guid.Parse(txt_user_id.Text);
            
            
            year = Int32.Parse(txt_year.Text);
            copies = Int32.Parse(txt_copies.Text);

            VideoInfo info = new VideoInfo();
            info.Director = directa;
            info.Format = (VideoFormat) txt_format.SelectedItem;
            info.TotalCopies = copies;
            info.Year = year;
            info.Title = title;

            ado.AddUpdateVideo(info,user);



        }
    }
}
