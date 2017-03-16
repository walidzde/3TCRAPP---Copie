namespace _3TCRAPP
{
    partial class PrintForm
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
            this.components = new System.ComponentModel.Container();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.Bsearch = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.YEAR = new MetroFramework.Controls.MetroTextBox();
            this.NUMACT = new MetroFramework.Controls.MetroTextBox();
            this.ActeView = new System.Windows.Forms.WebBrowser();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(686, 14);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(144, 23);
            this.metroButton1.TabIndex = 3;
            this.metroButton1.Text = "طباعة العقد";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // Bsearch
            // 
            this.Bsearch.Location = new System.Drawing.Point(536, 14);
            this.Bsearch.Name = "Bsearch";
            this.Bsearch.Size = new System.Drawing.Size(144, 23);
            this.Bsearch.TabIndex = 2;
            this.Bsearch.Text = "البحث";
            this.Bsearch.UseSelectable = true;
            this.Bsearch.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(836, 14);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(144, 23);
            this.metroButton3.TabIndex = 4;
            this.metroButton3.Text = "العودة الى الرئيسية";
            this.metroButton3.UseSelectable = true;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // YEAR
            // 
            // 
            // 
            // 
            this.YEAR.CustomButton.Image = null;
            this.YEAR.CustomButton.Location = new System.Drawing.Point(107, 2);
            this.YEAR.CustomButton.Name = "";
            this.YEAR.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.YEAR.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.YEAR.CustomButton.TabIndex = 1;
            this.YEAR.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.YEAR.CustomButton.UseSelectable = true;
            this.YEAR.CustomButton.Visible = false;
            this.YEAR.Lines = new string[0];
            this.YEAR.Location = new System.Drawing.Point(389, 14);
            this.YEAR.MaxLength = 32767;
            this.YEAR.Name = "YEAR";
            this.YEAR.PasswordChar = '\0';
            this.YEAR.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.YEAR.SelectedText = "";
            this.YEAR.SelectionLength = 0;
            this.YEAR.SelectionStart = 0;
            this.YEAR.ShortcutsEnabled = true;
            this.YEAR.Size = new System.Drawing.Size(141, 36);
            this.YEAR.TabIndex = 1;
            this.YEAR.UseSelectable = true;
            this.YEAR.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.YEAR.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // NUMACT
            // 
            // 
            // 
            // 
            this.NUMACT.CustomButton.Image = null;
            this.NUMACT.CustomButton.Location = new System.Drawing.Point(107, 2);
            this.NUMACT.CustomButton.Name = "";
            this.NUMACT.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.NUMACT.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.NUMACT.CustomButton.TabIndex = 1;
            this.NUMACT.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.NUMACT.CustomButton.UseSelectable = true;
            this.NUMACT.CustomButton.Visible = false;
            this.NUMACT.Lines = new string[0];
            this.NUMACT.Location = new System.Drawing.Point(242, 14);
            this.NUMACT.MaxLength = 32767;
            this.NUMACT.Name = "NUMACT";
            this.NUMACT.PasswordChar = '\0';
            this.NUMACT.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.NUMACT.SelectedText = "";
            this.NUMACT.SelectionLength = 0;
            this.NUMACT.SelectionStart = 0;
            this.NUMACT.ShortcutsEnabled = true;
            this.NUMACT.Size = new System.Drawing.Size(141, 36);
            this.NUMACT.TabIndex = 0;
            this.NUMACT.UseSelectable = true;
            this.NUMACT.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.NUMACT.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ActeView
            // 
            this.ActeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ActeView.Location = new System.Drawing.Point(20, 60);
            this.ActeView.MinimumSize = new System.Drawing.Size(20, 20);
            this.ActeView.Name = "ActeView";
            this.ActeView.Size = new System.Drawing.Size(1260, 620);
            this.ActeView.TabIndex = 6;
            this.ActeView.Url = new System.Uri("", System.UriKind.Relative);
            this.ActeView.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(242, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(36, 19);
            this.metroLabel1.TabIndex = 9;
            this.metroLabel1.Text = "Year";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(389, 60);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(61, 19);
            this.metroLabel2.TabIndex = 10;
            this.metroLabel2.Text = "Num Act";
            // 
            // PrintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.NUMACT);
            this.Controls.Add(this.YEAR);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.Bsearch);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.ActeView);
            this.Name = "PrintForm";
            this.Text = "نافذة طبع العقود";
            this.Load += new System.EventHandler(this.PrintForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton Bsearch;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroTextBox YEAR;
        private MetroFramework.Controls.MetroTextBox NUMACT;
        private System.Windows.Forms.WebBrowser ActeView;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}