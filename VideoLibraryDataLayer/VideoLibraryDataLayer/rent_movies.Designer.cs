
namespace UCSD.VideoLibrary
{
    partial class rent_movies
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
            this.checkoutId = new System.Windows.Forms.TextBox();
            this.userId = new System.Windows.Forms.TextBox();
            this.movieId = new System.Windows.Forms.TextBox();
            this.checkoutdate = new System.Windows.Forms.DateTimePicker();
            this.checkindate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkoutId
            // 
            this.checkoutId.Location = new System.Drawing.Point(85, 113);
            this.checkoutId.Name = "checkoutId";
            this.checkoutId.Size = new System.Drawing.Size(185, 22);
            this.checkoutId.TabIndex = 0;
            // 
            // userId
            // 
            this.userId.Location = new System.Drawing.Point(85, 157);
            this.userId.Name = "userId";
            this.userId.Size = new System.Drawing.Size(185, 22);
            this.userId.TabIndex = 0;
            // 
            // movieId
            // 
            this.movieId.Location = new System.Drawing.Point(85, 199);
            this.movieId.Name = "movieId";
            this.movieId.Size = new System.Drawing.Size(185, 22);
            this.movieId.TabIndex = 0;
            // 
            // checkoutdate
            // 
            this.checkoutdate.Location = new System.Drawing.Point(402, 113);
            this.checkoutdate.Name = "checkoutdate";
            this.checkoutdate.Size = new System.Drawing.Size(200, 22);
            this.checkoutdate.TabIndex = 1;
            // 
            // checkindate
            // 
            this.checkindate.Location = new System.Drawing.Point(402, 182);
            this.checkindate.Name = "checkindate";
            this.checkindate.Size = new System.Drawing.Size(200, 22);
            this.checkindate.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "CheckoutId";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "userId";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "MovieId";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(399, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Check out date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(399, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Check in date";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(326, 333);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 3;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(421, 333);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 23);
            this.btnupdate.TabIndex = 3;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.button1_Click);
            // 
            // rent_movies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkindate);
            this.Controls.Add(this.checkoutdate);
            this.Controls.Add(this.movieId);
            this.Controls.Add(this.userId);
            this.Controls.Add(this.checkoutId);
            this.Name = "rent_movies";
            this.Text = "rent_movies";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox checkoutId;
        private System.Windows.Forms.TextBox userId;
        private System.Windows.Forms.TextBox movieId;
        private System.Windows.Forms.DateTimePicker checkoutdate;
        private System.Windows.Forms.DateTimePicker checkindate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btnupdate;
    }
}