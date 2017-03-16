namespace _3TCRAPP
{
    partial class RecherchActe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecherchActe));
            this.RBnum = new System.Windows.Forms.RadioButton();
            this.RBname = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.Tname = new System.Windows.Forms.TextBox();
            this.Tyear = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // RBnum
            // 
            this.RBnum.AutoSize = true;
            this.RBnum.Location = new System.Drawing.Point(69, 59);
            this.RBnum.Name = "RBnum";
            this.RBnum.Size = new System.Drawing.Size(116, 17);
            this.RBnum.TabIndex = 0;
            this.RBnum.TabStop = true;
            this.RBnum.Text = "البحث بالرقم و السنة";
            this.RBnum.UseVisualStyleBackColor = true;
            this.RBnum.CheckedChanged += new System.EventHandler(this.RBnum_CheckedChanged);
            // 
            // RBname
            // 
            this.RBname.AutoSize = true;
            this.RBname.Location = new System.Drawing.Point(70, 85);
            this.RBname.Name = "RBname";
            this.RBname.Size = new System.Drawing.Size(85, 17);
            this.RBname.TabIndex = 1;
            this.RBname.TabStop = true;
            this.RBname.Text = "البحث بالنسب";
            this.RBname.UseVisualStyleBackColor = true;
            this.RBname.CheckedChanged += new System.EventHandler(this.RBname_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "نوع البحث";
            // 
            // Tname
            // 
            this.Tname.Location = new System.Drawing.Point(191, 85);
            this.Tname.Name = "Tname";
            this.Tname.Size = new System.Drawing.Size(175, 20);
            this.Tname.TabIndex = 2;
            // 
            // Tyear
            // 
            this.Tyear.Location = new System.Drawing.Point(191, 56);
            this.Tyear.Name = "Tyear";
            this.Tyear.Size = new System.Drawing.Size(88, 20);
            this.Tyear.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 135);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(757, 192);
            this.dataGridView1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(582, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "ابحث";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(285, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(81, 20);
            this.textBox1.TabIndex = 1;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // RecherchActe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 345);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Tyear);
            this.Controls.Add(this.Tname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RBname);
            this.Controls.Add(this.RBnum);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RecherchActe";
            this.Text = "نافذة البحث";
            this.Load += new System.EventHandler(this.RecherchActe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton RBnum;
        private System.Windows.Forms.RadioButton RBname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Tname;
        private System.Windows.Forms.TextBox Tyear;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}