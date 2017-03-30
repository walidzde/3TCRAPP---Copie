namespace _3TCRAPP
{
    partial class printformCI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(printformCI));
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.mbsearch = new MetroFramework.Controls.MetroButton();
            this.tnumact = new System.Windows.Forms.TextBox();
            this.tyear = new System.Windows.Forms.TextBox();
            this.namewewanttosee = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(483, 81);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(49, 19);
            this.metroLabel2.TabIndex = 9;
            this.metroLabel2.Text = "رقم العقد";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(678, 80);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(31, 19);
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "السنة";
            // 
            // mbsearch
            // 
            this.mbsearch.Location = new System.Drawing.Point(250, 76);
            this.mbsearch.Name = "mbsearch";
            this.mbsearch.Size = new System.Drawing.Size(112, 23);
            this.mbsearch.TabIndex = 7;
            this.mbsearch.Text = "إختيار صاحب العقد";
            this.mbsearch.UseSelectable = true;
            this.mbsearch.Click += new System.EventHandler(this.mbsearch_Click);
            // 
            // tnumact
            // 
            this.tnumact.Location = new System.Drawing.Point(377, 79);
            this.tnumact.Name = "tnumact";
            this.tnumact.Size = new System.Drawing.Size(100, 20);
            this.tnumact.TabIndex = 6;
            // 
            // tyear
            // 
            this.tyear.Location = new System.Drawing.Point(572, 79);
            this.tyear.Name = "tyear";
            this.tyear.Size = new System.Drawing.Size(100, 20);
            this.tyear.TabIndex = 5;
            // 
            // namewewanttosee
            // 
            this.namewewanttosee.AutoSize = true;
            this.namewewanttosee.Location = new System.Drawing.Point(46, 60);
            this.namewewanttosee.Name = "namewewanttosee";
            this.namewewanttosee.Size = new System.Drawing.Size(0, 0);
            this.namewewanttosee.TabIndex = 10;
            // 
            // printformCI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 188);
            this.Controls.Add(this.namewewanttosee);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.mbsearch);
            this.Controls.Add(this.tnumact);
            this.Controls.Add(this.tyear);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "printformCI";
            this.Text = "نافدة طباعة النسخة الكاملة";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.printformCI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton mbsearch;
        private System.Windows.Forms.TextBox tnumact;
        private System.Windows.Forms.TextBox tyear;
        private MetroFramework.Controls.MetroLabel namewewanttosee;
    }
}