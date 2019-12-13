namespace PSM
{
    partial class InsertPrisoner
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcrimname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnfemale = new System.Windows.Forms.RadioButton();
            this.rbtnmale = new System.Windows.Forms.RadioButton();
            this.txtcrimadd = new System.Windows.Forms.TextBox();
            this.txtpanishdue = new System.Windows.Forms.TextBox();
            this.cmbcrimnation = new System.Windows.Forms.ComboBox();
            this.dtpuninshstart = new System.Windows.Forms.DateTimePicker();
            this.btninsert = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtcrimid = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.BlueViolet;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(795, 60);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(188, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(394, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fill The Form To Insert The Prisoner";
            // 
            // txtcrimname
            // 
            this.txtcrimname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcrimname.Location = new System.Drawing.Point(219, 102);
            this.txtcrimname.Name = "txtcrimname";
            this.txtcrimname.Size = new System.Drawing.Size(217, 27);
            this.txtcrimname.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Criminal\'s Address:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 337);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Punishment Duration :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(366, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(195, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Criminal\'s Nationality:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(381, 281);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(180, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Punishment Started:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnfemale);
            this.groupBox1.Controls.Add(this.rbtnmale);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(76, 210);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 91);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gender";
            // 
            // rbtnfemale
            // 
            this.rbtnfemale.AutoSize = true;
            this.rbtnfemale.Location = new System.Drawing.Point(35, 57);
            this.rbtnfemale.Name = "rbtnfemale";
            this.rbtnfemale.Size = new System.Drawing.Size(91, 24);
            this.rbtnfemale.TabIndex = 1;
            this.rbtnfemale.TabStop = true;
            this.rbtnfemale.Text = "Female";
            this.rbtnfemale.UseVisualStyleBackColor = true;
            // 
            // rbtnmale
            // 
            this.rbtnmale.AutoSize = true;
            this.rbtnmale.Location = new System.Drawing.Point(35, 27);
            this.rbtnmale.Name = "rbtnmale";
            this.rbtnmale.Size = new System.Drawing.Size(70, 24);
            this.rbtnmale.TabIndex = 0;
            this.rbtnmale.TabStop = true;
            this.rbtnmale.Text = "Male";
            this.rbtnmale.UseVisualStyleBackColor = true;
            // 
            // txtcrimadd
            // 
            this.txtcrimadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcrimadd.Location = new System.Drawing.Point(219, 161);
            this.txtcrimadd.Name = "txtcrimadd";
            this.txtcrimadd.Size = new System.Drawing.Size(217, 27);
            this.txtcrimadd.TabIndex = 17;
            // 
            // txtpanishdue
            // 
            this.txtpanishdue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpanishdue.Location = new System.Drawing.Point(219, 334);
            this.txtpanishdue.Name = "txtpanishdue";
            this.txtpanishdue.Size = new System.Drawing.Size(90, 27);
            this.txtpanishdue.TabIndex = 18;
            // 
            // cmbcrimnation
            // 
            this.cmbcrimnation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbcrimnation.FormattingEnabled = true;
            this.cmbcrimnation.Items.AddRange(new object[] {
            "Choose the Region:",
            "Dhaka",
            "Barishal",
            "Noakhali",
            "Jossor",
            "Chittagong",
            "Faridpur"});
            this.cmbcrimnation.Location = new System.Drawing.Point(587, 223);
            this.cmbcrimnation.Name = "cmbcrimnation";
            this.cmbcrimnation.Size = new System.Drawing.Size(121, 28);
            this.cmbcrimnation.TabIndex = 19;
            this.cmbcrimnation.SelectedIndexChanged += new System.EventHandler(this.cmbcrimnation_SelectedIndexChanged);
            // 
            // dtpuninshstart
            // 
            this.dtpuninshstart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpuninshstart.Location = new System.Drawing.Point(568, 278);
            this.dtpuninshstart.Name = "dtpuninshstart";
            this.dtpuninshstart.Size = new System.Drawing.Size(220, 27);
            this.dtpuninshstart.TabIndex = 20;
            // 
            // btninsert
            // 
            this.btninsert.BackColor = System.Drawing.Color.DimGray;
            this.btninsert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btninsert.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninsert.ForeColor = System.Drawing.Color.Cornsilk;
            this.btninsert.Location = new System.Drawing.Point(388, 355);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(193, 67);
            this.btninsert.TabIndex = 21;
            this.btninsert.Text = "Insert";
            this.btninsert.UseVisualStyleBackColor = false;
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(325, 337);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "days";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Criminal\'s Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(456, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "Criminal\'s ID:";
            // 
            // txtcrimid
            // 
            this.txtcrimid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcrimid.Location = new System.Drawing.Point(587, 102);
            this.txtcrimid.Name = "txtcrimid";
            this.txtcrimid.Size = new System.Drawing.Size(121, 27);
            this.txtcrimid.TabIndex = 24;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DimGray;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnBack.Location = new System.Drawing.Point(587, 355);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(193, 67);
            this.btnBack.TabIndex = 25;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // InsertPrisoner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtcrimid);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btninsert);
            this.Controls.Add(this.dtpuninshstart);
            this.Controls.Add(this.cmbcrimnation);
            this.Controls.Add(this.txtpanishdue);
            this.Controls.Add(this.txtcrimadd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtcrimname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "InsertPrisoner";
            this.Text = "InsertPrisoner";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcrimname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnfemale;
        private System.Windows.Forms.RadioButton rbtnmale;
        private System.Windows.Forms.TextBox txtcrimadd;
        private System.Windows.Forms.TextBox txtpanishdue;
        private System.Windows.Forms.ComboBox cmbcrimnation;
        private System.Windows.Forms.DateTimePicker dtpuninshstart;
        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtcrimid;
        private System.Windows.Forms.Button btnBack;
    }
}