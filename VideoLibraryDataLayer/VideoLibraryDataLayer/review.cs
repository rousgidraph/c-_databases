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
    public partial class review : Form
    {
        using_ADO ado = new using_ADO();
        public review()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string review;
            int  video;
            Guid user;

            review = txt_review.Text;
            user = Guid.Parse(userId.Text);
            video = Int32.Parse(videoId.Text);
            
            ado.AddReview(video, user, review);
        }
    }
}
