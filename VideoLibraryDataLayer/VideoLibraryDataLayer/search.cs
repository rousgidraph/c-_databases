using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UCSD.VideoLibrary
{
    public partial class search : Form
    {
        using_ADO ado = new using_ADO();
        public search()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            Collection<VideoSearchResult> res = new Collection<VideoSearchResult>();
            VideoSearchCriteria search = new VideoSearchCriteria();
            string term = search_bar.Text;

            if (term.Length == 0) {

                res = ado.return_all();

                results.Text = "";
                foreach (var ress in res)
                {
                    results.AppendText ( ress.VideoId+" : "+ress.Year+" : "+ress.Director+"  "+ress.Title + "\n");
                }

                return;
            }


            if (title.Checked) {
                search.Title = term;
            }

            if (director.Checked) {
                search.Director = term;
            }

            if (year.Checked) {
                search.Year = Int16.Parse(term) ;
            }

            res = ado.SearchVideoLibrary(search);

            if (res == null) { return; }
            results.Text = "";
            foreach (var ress in res) {
                results.AppendText(ress.VideoId + " : " + ress.Year + " : " + ress.Director + "  " + ress.Title + "\n");
            }
        }
    }
}
