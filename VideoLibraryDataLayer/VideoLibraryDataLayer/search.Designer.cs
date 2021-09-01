
namespace UCSD.VideoLibrary
{
    partial class search
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.search_bar = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.results = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.CheckBox();
            this.director = new System.Windows.Forms.CheckBox();
            this.year = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // search_bar
            // 
            this.search_bar.Location = new System.Drawing.Point(76, 72);
            this.search_bar.Name = "search_bar";
            this.search_bar.Size = new System.Drawing.Size(474, 22);
            this.search_bar.TabIndex = 0;
            this.search_bar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(631, 70);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 1;
            this.btn_search.Text = "search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // results
            // 
            this.results.Location = new System.Drawing.Point(76, 161);
            this.results.Multiline = true;
            this.results.Name = "results";
            this.results.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.results.Size = new System.Drawing.Size(586, 253);
            this.results.TabIndex = 2;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Location = new System.Drawing.Point(76, 116);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(52, 21);
            this.title.TabIndex = 3;
            this.title.Text = "title";
            this.title.UseVisualStyleBackColor = true;
            // 
            // director
            // 
            this.director.AutoSize = true;
            this.director.Location = new System.Drawing.Point(189, 116);
            this.director.Name = "director";
            this.director.Size = new System.Drawing.Size(80, 21);
            this.director.TabIndex = 3;
            this.director.Text = "Director";
            this.director.UseVisualStyleBackColor = true;
            // 
            // year
            // 
            this.year.AutoSize = true;
            this.year.Location = new System.Drawing.Point(318, 116);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(58, 21);
            this.year.TabIndex = 3;
            this.year.Text = "year";
            this.year.UseVisualStyleBackColor = true;
            // 
            // search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.year);
            this.Controls.Add(this.director);
            this.Controls.Add(this.title);
            this.Controls.Add(this.results);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.search_bar);
            this.Name = "search";
            this.Text = "search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox search_bar;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox results;
        private System.Windows.Forms.CheckBox title;
        private System.Windows.Forms.CheckBox director;
        private System.Windows.Forms.CheckBox year;
    }
}