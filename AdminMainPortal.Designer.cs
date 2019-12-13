namespace PSM
{
    partial class AdminMainPortal
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btndeleteprisoner = new System.Windows.Forms.Button();
            this.btnupdateprisoner = new System.Windows.Forms.Button();
            this.btninsertprisoner = new System.Windows.Forms.Button();
            this.btnshow = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(805, 117);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(239, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome To Admin Panel";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnshow);
            this.groupBox1.Controls.Add(this.btndeleteprisoner);
            this.groupBox1.Controls.Add(this.btnupdateprisoner);
            this.groupBox1.Controls.Add(this.btninsertprisoner);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Brown;
            this.groupBox1.Location = new System.Drawing.Point(220, 171);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(549, 270);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "What Would You Like To Do";
            // 
            // btndeleteprisoner
            // 
            this.btndeleteprisoner.Location = new System.Drawing.Point(316, 179);
            this.btndeleteprisoner.Name = "btndeleteprisoner";
            this.btndeleteprisoner.Size = new System.Drawing.Size(203, 58);
            this.btndeleteprisoner.TabIndex = 2;
            this.btndeleteprisoner.Text = "Delete Prisoner";
            this.btndeleteprisoner.UseVisualStyleBackColor = true;
            this.btndeleteprisoner.Click += new System.EventHandler(this.btndeleteprisoner_Click);
            // 
            // btnupdateprisoner
            // 
            this.btnupdateprisoner.Location = new System.Drawing.Point(27, 179);
            this.btnupdateprisoner.Name = "btnupdateprisoner";
            this.btnupdateprisoner.Size = new System.Drawing.Size(203, 58);
            this.btnupdateprisoner.TabIndex = 1;
            this.btnupdateprisoner.Text = "Update Prisoner";
            this.btnupdateprisoner.UseVisualStyleBackColor = true;
            this.btnupdateprisoner.Click += new System.EventHandler(this.btnupdateprisoner_Click);
            // 
            // btninsertprisoner
            // 
            this.btninsertprisoner.Location = new System.Drawing.Point(316, 62);
            this.btninsertprisoner.Name = "btninsertprisoner";
            this.btninsertprisoner.Size = new System.Drawing.Size(203, 58);
            this.btninsertprisoner.TabIndex = 0;
            this.btninsertprisoner.Text = "Insert Prisoner";
            this.btninsertprisoner.UseVisualStyleBackColor = true;
            this.btninsertprisoner.Click += new System.EventHandler(this.btninsertprisoner_Click);
            // 
            // btnshow
            // 
            this.btnshow.Location = new System.Drawing.Point(27, 62);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(203, 58);
            this.btnshow.TabIndex = 3;
            this.btnshow.Text = "Show Prisoner";
            this.btnshow.UseVisualStyleBackColor = true;
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click);
            // 
            // AdminMainPortal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 453);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "AdminMainPortal";
            this.Text = "AdminMainPortal";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btndeleteprisoner;
        private System.Windows.Forms.Button btnupdateprisoner;
        private System.Windows.Forms.Button btninsertprisoner;
        private System.Windows.Forms.Button btnshow;
    }
}