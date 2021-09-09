
namespace PharmacyManagementSystem.AdminUserControl
{
    partial class UC_Dashboard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Dashboard));
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panAdmin = new System.Windows.Forms.Panel();
            this.AdminLbl = new System.Windows.Forms.Label();
            this.labAdmin = new System.Windows.Forms.Label();
            this.panPharm = new System.Windows.Forms.Panel();
            this.Rxlabel = new System.Windows.Forms.Label();
            this.labPharmacist = new System.Windows.Forms.Label();
            this.panCust = new System.Windows.Forms.Panel();
            this.Custlabel = new System.Windows.Forms.Label();
            this.labCustomer = new System.Windows.Forms.Label();
            this.panSysUsr = new System.Windows.Forms.Panel();
            this.SysUserlabel = new System.Windows.Forms.Label();
            this.labSystemUser = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnsync = new Guna.UI2.WinForms.Guna2Button();
            this.panAdmin.SuspendLayout();
            this.panPharm.SuspendLayout();
            this.panCust.SuspendLayout();
            this.panSysUsr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dashboard";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // panAdmin
            // 
            this.panAdmin.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panAdmin.Controls.Add(this.AdminLbl);
            this.panAdmin.Controls.Add(this.labAdmin);
            this.panAdmin.Location = new System.Drawing.Point(62, 178);
            this.panAdmin.Name = "panAdmin";
            this.panAdmin.Size = new System.Drawing.Size(280, 730);
            this.panAdmin.TabIndex = 1;
            // 
            // AdminLbl
            // 
            this.AdminLbl.AutoSize = true;
            this.AdminLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminLbl.Location = new System.Drawing.Point(43, 19);
            this.AdminLbl.Name = "AdminLbl";
            this.AdminLbl.Size = new System.Drawing.Size(208, 37);
            this.AdminLbl.TabIndex = 1;
            this.AdminLbl.Text = "Administrator";
            // 
            // labAdmin
            // 
            this.labAdmin.AutoSize = true;
            this.labAdmin.BackColor = System.Drawing.Color.White;
            this.labAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labAdmin.Location = new System.Drawing.Point(126, 70);
            this.labAdmin.Name = "labAdmin";
            this.labAdmin.Size = new System.Drawing.Size(35, 37);
            this.labAdmin.TabIndex = 0;
            this.labAdmin.Text = "0";
            this.labAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panPharm
            // 
            this.panPharm.BackColor = System.Drawing.Color.SteelBlue;
            this.panPharm.Controls.Add(this.Rxlabel);
            this.panPharm.Controls.Add(this.labPharmacist);
            this.panPharm.Location = new System.Drawing.Point(377, 178);
            this.panPharm.Name = "panPharm";
            this.panPharm.Size = new System.Drawing.Size(280, 730);
            this.panPharm.TabIndex = 2;
            // 
            // Rxlabel
            // 
            this.Rxlabel.AutoSize = true;
            this.Rxlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rxlabel.Location = new System.Drawing.Point(56, 19);
            this.Rxlabel.Name = "Rxlabel";
            this.Rxlabel.Size = new System.Drawing.Size(178, 37);
            this.Rxlabel.TabIndex = 2;
            this.Rxlabel.Text = "Pharmacist";
            // 
            // labPharmacist
            // 
            this.labPharmacist.AutoSize = true;
            this.labPharmacist.BackColor = System.Drawing.Color.White;
            this.labPharmacist.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPharmacist.Location = new System.Drawing.Point(127, 70);
            this.labPharmacist.Name = "labPharmacist";
            this.labPharmacist.Size = new System.Drawing.Size(35, 37);
            this.labPharmacist.TabIndex = 1;
            this.labPharmacist.Text = "0";
            // 
            // panCust
            // 
            this.panCust.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panCust.Controls.Add(this.Custlabel);
            this.panCust.Controls.Add(this.labCustomer);
            this.panCust.Location = new System.Drawing.Point(691, 178);
            this.panCust.Name = "panCust";
            this.panCust.Size = new System.Drawing.Size(282, 730);
            this.panCust.TabIndex = 3;
            // 
            // Custlabel
            // 
            this.Custlabel.AutoSize = true;
            this.Custlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Custlabel.Location = new System.Drawing.Point(74, 19);
            this.Custlabel.Name = "Custlabel";
            this.Custlabel.Size = new System.Drawing.Size(156, 37);
            this.Custlabel.TabIndex = 2;
            this.Custlabel.Text = "Customer";
            // 
            // labCustomer
            // 
            this.labCustomer.AutoSize = true;
            this.labCustomer.BackColor = System.Drawing.Color.White;
            this.labCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCustomer.Location = new System.Drawing.Point(127, 70);
            this.labCustomer.Name = "labCustomer";
            this.labCustomer.Size = new System.Drawing.Size(35, 37);
            this.labCustomer.TabIndex = 1;
            this.labCustomer.Text = "0";
            // 
            // panSysUsr
            // 
            this.panSysUsr.BackColor = System.Drawing.Color.SteelBlue;
            this.panSysUsr.Controls.Add(this.SysUserlabel);
            this.panSysUsr.Controls.Add(this.labSystemUser);
            this.panSysUsr.Location = new System.Drawing.Point(1007, 178);
            this.panSysUsr.Name = "panSysUsr";
            this.panSysUsr.Size = new System.Drawing.Size(282, 730);
            this.panSysUsr.TabIndex = 4;
            // 
            // SysUserlabel
            // 
            this.SysUserlabel.AutoSize = true;
            this.SysUserlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SysUserlabel.Location = new System.Drawing.Point(47, 19);
            this.SysUserlabel.Name = "SysUserlabel";
            this.SysUserlabel.Size = new System.Drawing.Size(189, 37);
            this.SysUserlabel.TabIndex = 2;
            this.SysUserlabel.Text = "SystemUser";
            // 
            // labSystemUser
            // 
            this.labSystemUser.AutoSize = true;
            this.labSystemUser.BackColor = System.Drawing.Color.White;
            this.labSystemUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSystemUser.Location = new System.Drawing.Point(122, 70);
            this.labSystemUser.Name = "labSystemUser";
            this.labSystemUser.Size = new System.Drawing.Size(35, 37);
            this.labSystemUser.TabIndex = 1;
            this.labSystemUser.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(304, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnsync
            // 
            this.btnsync.BorderColor = System.Drawing.Color.Transparent;
            this.btnsync.CheckedState.Parent = this.btnsync;
            this.btnsync.CustomImages.Parent = this.btnsync;
            this.btnsync.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnsync.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnsync.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnsync.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnsync.DisabledState.Parent = this.btnsync;
            this.btnsync.FillColor = System.Drawing.Color.White;
            this.btnsync.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsync.ForeColor = System.Drawing.Color.White;
            this.btnsync.HoverState.FillColor = System.Drawing.Color.White;
            this.btnsync.HoverState.Parent = this.btnsync;
            this.btnsync.Image = ((System.Drawing.Image)(resources.GetObject("btnsync.Image")));
            this.btnsync.ImageSize = new System.Drawing.Size(35, 35);
            this.btnsync.Location = new System.Drawing.Point(326, 89);
            this.btnsync.Name = "btnsync";
            this.btnsync.PressedColor = System.Drawing.Color.White;
            this.btnsync.ShadowDecoration.Parent = this.btnsync;
            this.btnsync.Size = new System.Drawing.Size(35, 34);
            this.btnsync.TabIndex = 6;
            this.btnsync.Click += new System.EventHandler(this.btnsync_Click);
            // 
            // UC_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnsync);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panSysUsr);
            this.Controls.Add(this.panCust);
            this.Controls.Add(this.panPharm);
            this.Controls.Add(this.panAdmin);
            this.Controls.Add(this.label1);
            this.Name = "UC_Dashboard";
            this.Size = new System.Drawing.Size(1349, 946);
            this.Load += new System.EventHandler(this.UC_Dashboard_Load);
            this.panAdmin.ResumeLayout(false);
            this.panAdmin.PerformLayout();
            this.panPharm.ResumeLayout(false);
            this.panPharm.PerformLayout();
            this.panCust.ResumeLayout(false);
            this.panCust.PerformLayout();
            this.panSysUsr.ResumeLayout(false);
            this.panSysUsr.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Panel panAdmin;
        private System.Windows.Forms.Panel panPharm;
        private System.Windows.Forms.Panel panCust;
        private System.Windows.Forms.Label labAdmin;
        private System.Windows.Forms.Label labCustomer;
        private System.Windows.Forms.Label labPharmacist;
        private System.Windows.Forms.Panel panSysUsr;
        private System.Windows.Forms.Label labSystemUser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnsync;
        private System.Windows.Forms.Label Rxlabel;
        private System.Windows.Forms.Label AdminLbl;
        private System.Windows.Forms.Label SysUserlabel;
        private System.Windows.Forms.Label Custlabel;
    }
}
