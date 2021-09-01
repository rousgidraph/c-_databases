
namespace UCSD.VideoLibrary
{
    partial class video_details
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
            this.txt_videoId = new System.Windows.Forms.TextBox();
            this.txt_title = new System.Windows.Forms.TextBox();
            this.txt_year = new System.Windows.Forms.TextBox();
            this.txt_director = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_copies = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.txt_format = new System.Windows.Forms.ComboBox();
            this.txt_user_id = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_videoId
            // 
            this.txt_videoId.Location = new System.Drawing.Point(336, 59);
            this.txt_videoId.Name = "txt_videoId";
            this.txt_videoId.Size = new System.Drawing.Size(179, 22);
            this.txt_videoId.TabIndex = 0;
            // 
            // txt_title
            // 
            this.txt_title.Location = new System.Drawing.Point(336, 101);
            this.txt_title.Name = "txt_title";
            this.txt_title.Size = new System.Drawing.Size(179, 22);
            this.txt_title.TabIndex = 1;
            // 
            // txt_year
            // 
            this.txt_year.Location = new System.Drawing.Point(336, 146);
            this.txt_year.Name = "txt_year";
            this.txt_year.Size = new System.Drawing.Size(179, 22);
            this.txt_year.TabIndex = 0;
            // 
            // txt_director
            // 
            this.txt_director.Location = new System.Drawing.Point(336, 190);
            this.txt_director.Name = "txt_director";
            this.txt_director.Size = new System.Drawing.Size(179, 22);
            this.txt_director.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(221, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(218, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "MovieId";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(218, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Year";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(218, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Director";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(218, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Format";
            // 
            // txt_copies
            // 
            this.txt_copies.Location = new System.Drawing.Point(336, 278);
            this.txt_copies.Name = "txt_copies";
            this.txt_copies.Size = new System.Drawing.Size(179, 22);
            this.txt_copies.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(218, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Total Copies ";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(384, 366);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 2;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_format
            // 
            this.txt_format.FormattingEnabled = true;
            this.txt_format.Items.AddRange(new object[] {
            "DVD",
            "VHS",
            "BluRay"});
            this.txt_format.Location = new System.Drawing.Point(338, 231);
            this.txt_format.Name = "txt_format";
            this.txt_format.Size = new System.Drawing.Size(177, 24);
            this.txt_format.TabIndex = 4;
            // 
            // txt_user_id
            // 
            this.txt_user_id.Location = new System.Drawing.Point(336, 24);
            this.txt_user_id.Name = "txt_user_id";
            this.txt_user_id.Size = new System.Drawing.Size(179, 22);
            this.txt_user_id.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(218, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "User Id";
            // 
            // video_details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_format);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_copies);
            this.Controls.Add(this.txt_director);
            this.Controls.Add(this.txt_year);
            this.Controls.Add(this.txt_title);
            this.Controls.Add(this.txt_user_id);
            this.Controls.Add(this.txt_videoId);
            this.Name = "video_details";
            this.Text = "video_details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_videoId;
        private System.Windows.Forms.TextBox txt_title;
        private System.Windows.Forms.TextBox txt_year;
        private System.Windows.Forms.TextBox txt_director;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_copies;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.ComboBox txt_format;
        private System.Windows.Forms.TextBox txt_user_id;
        private System.Windows.Forms.Label label7;
    }
}