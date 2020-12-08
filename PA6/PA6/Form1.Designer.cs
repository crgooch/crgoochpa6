namespace PA6
{
    partial class frmCWID
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
            this.lblCWID = new System.Windows.Forms.Label();
            this.txtCWID = new System.Windows.Forms.TextBox();
            this.btnok = new System.Windows.Forms.Button();
            this.btnClsoe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCWID
            // 
            this.lblCWID.AutoSize = true;
            this.lblCWID.Location = new System.Drawing.Point(37, 84);
            this.lblCWID.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCWID.Name = "lblCWID";
            this.lblCWID.Size = new System.Drawing.Size(238, 32);
            this.lblCWID.TabIndex = 0;
            this.lblCWID.Text = "Enter Your CWID:";
            // 
            // txtCWID
            // 
            this.txtCWID.Location = new System.Drawing.Point(283, 77);
            this.txtCWID.Name = "txtCWID";
            this.txtCWID.Size = new System.Drawing.Size(363, 39);
            this.txtCWID.TabIndex = 1;
            this.txtCWID.TextChanged += new System.EventHandler(this.ddd);
            // 
            // btnok
            // 
            this.btnok.Location = new System.Drawing.Point(356, 181);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(116, 54);
            this.btnok.TabIndex = 2;
            this.btnok.Text = "OK";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // btnClsoe
            // 
            this.btnClsoe.Location = new System.Drawing.Point(501, 181);
            this.btnClsoe.Name = "btnClsoe";
            this.btnClsoe.Size = new System.Drawing.Size(145, 54);
            this.btnClsoe.TabIndex = 3;
            this.btnClsoe.Text = "Close";
            this.btnClsoe.UseVisualStyleBackColor = true;
            this.btnClsoe.Click += new System.EventHandler(this.btnClsoe_Click);
            // 
            // frmCWID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 387);
            this.Controls.Add(this.btnClsoe);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.txtCWID);
            this.Controls.Add(this.lblCWID);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "frmCWID";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmCWID_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCWID;
        private System.Windows.Forms.TextBox txtCWID;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.Button btnClsoe;
    }
}

