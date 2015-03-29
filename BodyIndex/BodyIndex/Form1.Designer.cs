namespace BodyIndex
{
    partial class frmBodyIndex
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
            this.grbPerson = new System.Windows.Forms.GroupBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.pbResult = new System.Windows.Forms.PictureBox();
            this.pbHelp = new System.Windows.Forms.PictureBox();
            this.grbPerson.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHelp)).BeginInit();
            this.SuspendLayout();
            // 
            // grbPerson
            // 
            this.grbPerson.Controls.Add(this.txtWeight);
            this.grbPerson.Controls.Add(this.txtHeight);
            this.grbPerson.Controls.Add(this.lblResult);
            this.grbPerson.Controls.Add(this.label3);
            this.grbPerson.Controls.Add(this.label2);
            this.grbPerson.Location = new System.Drawing.Point(12, 12);
            this.grbPerson.Name = "grbPerson";
            this.grbPerson.Size = new System.Drawing.Size(180, 88);
            this.grbPerson.TabIndex = 0;
            this.grbPerson.TabStop = false;
            this.grbPerson.Text = "Specials";
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(60, 43);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(100, 20);
            this.txtWeight.TabIndex = 1;
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(60, 17);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(100, 20);
            this.txtHeight.TabIndex = 1;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(57, 69);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(52, 13);
            this.lblResult.TabIndex = 0;
            this.lblResult.Text = "Waiting ..";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Weight :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Height :";
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(12, 106);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(56, 23);
            this.btnRun.TabIndex = 2;
            this.btnRun.Text = "&Result";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(136, 106);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(56, 23);
            this.btnDel.TabIndex = 2;
            this.btnDel.Text = "&Clear";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // pbResult
            // 
            this.pbResult.Location = new System.Drawing.Point(199, 20);
            this.pbResult.Name = "pbResult";
            this.pbResult.Size = new System.Drawing.Size(90, 109);
            this.pbResult.TabIndex = 3;
            this.pbResult.TabStop = false;
            // 
            // pbHelp
            // 
            this.pbHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbHelp.Image = global::BodyIndex.Properties.Resources.help;
            this.pbHelp.Location = new System.Drawing.Point(74, 106);
            this.pbHelp.Name = "pbHelp";
            this.pbHelp.Size = new System.Drawing.Size(23, 22);
            this.pbHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHelp.TabIndex = 4;
            this.pbHelp.TabStop = false;
            this.pbHelp.Click += new System.EventHandler(this.pbHelp_Click);
            // 
            // frmBodyIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 140);
            this.Controls.Add(this.pbHelp);
            this.Controls.Add(this.pbResult);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.grbPerson);
            this.Name = "frmBodyIndex";
            this.Text = "BodyIndex Calculator";
            this.grbPerson.ResumeLayout(false);
            this.grbPerson.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHelp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbPerson;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.PictureBox pbResult;
        private System.Windows.Forms.PictureBox pbHelp;
        private System.Windows.Forms.Label lblResult;
    }
}

