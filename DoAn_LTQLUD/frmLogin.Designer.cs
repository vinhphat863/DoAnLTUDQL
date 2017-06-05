namespace DoAn_LTQLUD
{
    partial class frmLogin
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txb_username = new System.Windows.Forms.TextBox();
            this.txb_password = new System.Windows.Forms.TextBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(34, 63);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Username";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(34, 107);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(46, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Password";
            // 
            // txb_username
            // 
            this.txb_username.Location = new System.Drawing.Point(118, 63);
            this.txb_username.Name = "txb_username";
            this.txb_username.Size = new System.Drawing.Size(100, 21);
            this.txb_username.TabIndex = 2;
            // 
            // txb_password
            // 
            this.txb_password.Location = new System.Drawing.Point(118, 107);
            this.txb_password.Name = "txb_password";
            this.txb_password.Size = new System.Drawing.Size(100, 21);
            this.txb_password.TabIndex = 3;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(118, 22);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(31, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "LOGIN";
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(34, 168);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(75, 23);
            this.btn_Submit.TabIndex = 5;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(143, 168);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(75, 23);
            this.btn_Close.TabIndex = 6;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txb_password);
            this.Controls.Add(this.txb_username);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "frmLogin";
            this.Text = "frmLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.TextBox txb_username;
        private System.Windows.Forms.TextBox txb_password;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Button btn_Close;
    }
}