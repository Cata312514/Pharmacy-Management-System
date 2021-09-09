
namespace PharmacyManagementSystem
{
    partial class Pharmacist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pharmacist));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.btnSellMed = new Guna.UI2.WinForms.Guna2Button();
            this.btnMedVal = new Guna.UI2.WinForms.Guna2Button();
            this.btnModMed = new Guna.UI2.WinForms.Guna2Button();
            this.btnViewMed = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddMed = new Guna.UI2.WinForms.Guna2Button();
            this.btnDashbrd = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uC_Pharma_ValMed2 = new PharmacyManagementSystem.PharmacistUserControl.UC_Pharma_ValMed();
            this.uC_Pharma_AddMed1 = new PharmacyManagementSystem.PharmacistUserControl.UC_Pharma_AddMed();
            this.uC_Pharma_DashBrd1 = new PharmacyManagementSystem.PharmacistUserControl.UC_Pharma_DashBrd();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse5 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse6 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.uC_Pharma_UpdateMed1 = new PharmacyManagementSystem.PharmacistUserControl.UC_Pharma_UpdateMed();
            this.uC_Pharma_SellMed1 = new PharmacyManagementSystem.PharmacistUserControl.UC_Pharma_SellMed();
            this.uC_Pharma_ViewMed1 = new PharmacyManagementSystem.PharmacistUserControl.UC_Pharma_ViewMed();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnSellMed);
            this.panel1.Controls.Add(this.btnMedVal);
            this.panel1.Controls.Add(this.btnModMed);
            this.panel1.Controls.Add(this.btnViewMed);
            this.panel1.Controls.Add(this.btnAddMed);
            this.panel1.Controls.Add(this.btnDashbrd);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(268, 1811);
            this.panel1.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnLogout.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnLogout.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnLogout.CheckedState.Parent = this.btnLogout;
            this.btnLogout.CustomImages.Parent = this.btnLogout;
            this.btnLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogout.DisabledState.Parent = this.btnLogout;
            this.btnLogout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.HoverState.Parent = this.btnLogout;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageSize = new System.Drawing.Size(25, 25);
            this.btnLogout.Location = new System.Drawing.Point(26, 522);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.ShadowDecoration.Parent = this.btnLogout;
            this.btnLogout.Size = new System.Drawing.Size(249, 35);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "Logout";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnSellMed
            // 
            this.btnSellMed.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnSellMed.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnSellMed.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnSellMed.CheckedState.Parent = this.btnSellMed;
            this.btnSellMed.CustomImages.Parent = this.btnSellMed;
            this.btnSellMed.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSellMed.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSellMed.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSellMed.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSellMed.DisabledState.Parent = this.btnSellMed;
            this.btnSellMed.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnSellMed.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSellMed.ForeColor = System.Drawing.Color.White;
            this.btnSellMed.HoverState.Parent = this.btnSellMed;
            this.btnSellMed.Image = ((System.Drawing.Image)(resources.GetObject("btnSellMed.Image")));
            this.btnSellMed.ImageSize = new System.Drawing.Size(25, 25);
            this.btnSellMed.Location = new System.Drawing.Point(24, 477);
            this.btnSellMed.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSellMed.Name = "btnSellMed";
            this.btnSellMed.ShadowDecoration.Parent = this.btnSellMed;
            this.btnSellMed.Size = new System.Drawing.Size(249, 35);
            this.btnSellMed.TabIndex = 7;
            this.btnSellMed.Text = "Sell Medicine";
            this.btnSellMed.Click += new System.EventHandler(this.btnSellMed_Click);
            // 
            // btnMedVal
            // 
            this.btnMedVal.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnMedVal.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnMedVal.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnMedVal.CheckedState.Parent = this.btnMedVal;
            this.btnMedVal.CustomImages.Parent = this.btnMedVal;
            this.btnMedVal.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMedVal.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMedVal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMedVal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMedVal.DisabledState.Parent = this.btnMedVal;
            this.btnMedVal.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnMedVal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedVal.ForeColor = System.Drawing.Color.White;
            this.btnMedVal.HoverState.Parent = this.btnMedVal;
            this.btnMedVal.Image = ((System.Drawing.Image)(resources.GetObject("btnMedVal.Image")));
            this.btnMedVal.ImageSize = new System.Drawing.Size(25, 25);
            this.btnMedVal.Location = new System.Drawing.Point(26, 430);
            this.btnMedVal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMedVal.Name = "btnMedVal";
            this.btnMedVal.ShadowDecoration.Parent = this.btnMedVal;
            this.btnMedVal.Size = new System.Drawing.Size(249, 35);
            this.btnMedVal.TabIndex = 6;
            this.btnMedVal.Text = "Medicine Validation";
            this.btnMedVal.Click += new System.EventHandler(this.btnMedVal_Click);
            // 
            // btnModMed
            // 
            this.btnModMed.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnModMed.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnModMed.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnModMed.CheckedState.Parent = this.btnModMed;
            this.btnModMed.CustomImages.Parent = this.btnModMed;
            this.btnModMed.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnModMed.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnModMed.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnModMed.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnModMed.DisabledState.Parent = this.btnModMed;
            this.btnModMed.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnModMed.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModMed.ForeColor = System.Drawing.Color.White;
            this.btnModMed.HoverState.Parent = this.btnModMed;
            this.btnModMed.Image = ((System.Drawing.Image)(resources.GetObject("btnModMed.Image")));
            this.btnModMed.ImageSize = new System.Drawing.Size(25, 25);
            this.btnModMed.Location = new System.Drawing.Point(26, 379);
            this.btnModMed.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnModMed.Name = "btnModMed";
            this.btnModMed.ShadowDecoration.Parent = this.btnModMed;
            this.btnModMed.Size = new System.Drawing.Size(249, 35);
            this.btnModMed.TabIndex = 5;
            this.btnModMed.Text = "Modify Medicine";
            this.btnModMed.Click += new System.EventHandler(this.btnModMed_Click);
            // 
            // btnViewMed
            // 
            this.btnViewMed.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnViewMed.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnViewMed.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnViewMed.CheckedState.Parent = this.btnViewMed;
            this.btnViewMed.CustomImages.Parent = this.btnViewMed;
            this.btnViewMed.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnViewMed.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnViewMed.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnViewMed.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnViewMed.DisabledState.Parent = this.btnViewMed;
            this.btnViewMed.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnViewMed.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewMed.ForeColor = System.Drawing.Color.White;
            this.btnViewMed.HoverState.Parent = this.btnViewMed;
            this.btnViewMed.Image = ((System.Drawing.Image)(resources.GetObject("btnViewMed.Image")));
            this.btnViewMed.ImageSize = new System.Drawing.Size(25, 25);
            this.btnViewMed.Location = new System.Drawing.Point(28, 333);
            this.btnViewMed.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnViewMed.Name = "btnViewMed";
            this.btnViewMed.ShadowDecoration.Parent = this.btnViewMed;
            this.btnViewMed.Size = new System.Drawing.Size(249, 35);
            this.btnViewMed.TabIndex = 4;
            this.btnViewMed.Text = "View Medicine";
            this.btnViewMed.Click += new System.EventHandler(this.btnViewMed_Click);
            // 
            // btnAddMed
            // 
            this.btnAddMed.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnAddMed.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnAddMed.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnAddMed.CheckedState.Parent = this.btnAddMed;
            this.btnAddMed.CustomImages.Parent = this.btnAddMed;
            this.btnAddMed.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddMed.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddMed.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddMed.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddMed.DisabledState.Parent = this.btnAddMed;
            this.btnAddMed.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnAddMed.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMed.ForeColor = System.Drawing.Color.White;
            this.btnAddMed.HoverState.Parent = this.btnAddMed;
            this.btnAddMed.Image = ((System.Drawing.Image)(resources.GetObject("btnAddMed.Image")));
            this.btnAddMed.ImageSize = new System.Drawing.Size(25, 25);
            this.btnAddMed.Location = new System.Drawing.Point(26, 284);
            this.btnAddMed.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddMed.Name = "btnAddMed";
            this.btnAddMed.ShadowDecoration.Parent = this.btnAddMed;
            this.btnAddMed.Size = new System.Drawing.Size(249, 35);
            this.btnAddMed.TabIndex = 3;
            this.btnAddMed.Text = "Add Medicine";
            this.btnAddMed.Click += new System.EventHandler(this.btnAddMed_Click);
            // 
            // btnDashbrd
            // 
            this.btnDashbrd.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnDashbrd.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnDashbrd.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnDashbrd.CheckedState.Parent = this.btnDashbrd;
            this.btnDashbrd.CustomImages.Parent = this.btnDashbrd;
            this.btnDashbrd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDashbrd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDashbrd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDashbrd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDashbrd.DisabledState.Parent = this.btnDashbrd;
            this.btnDashbrd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnDashbrd.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnDashbrd.ForeColor = System.Drawing.Color.White;
            this.btnDashbrd.HoverState.Parent = this.btnDashbrd;
            this.btnDashbrd.Image = ((System.Drawing.Image)(resources.GetObject("btnDashbrd.Image")));
            this.btnDashbrd.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDashbrd.Location = new System.Drawing.Point(24, 241);
            this.btnDashbrd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDashbrd.Name = "btnDashbrd";
            this.btnDashbrd.ShadowDecoration.Parent = this.btnDashbrd;
            this.btnDashbrd.Size = new System.Drawing.Size(249, 35);
            this.btnDashbrd.TabIndex = 2;
            this.btnDashbrd.Text = "Dashboard";
            this.btnDashbrd.Click += new System.EventHandler(this.btnDashbrd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(70, 192);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pharmacist";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(75, 48);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.uC_Pharma_ViewMed1);
            this.panel2.Controls.Add(this.uC_Pharma_SellMed1);
            this.panel2.Controls.Add(this.uC_Pharma_UpdateMed1);
            this.panel2.Controls.Add(this.uC_Pharma_ValMed2);
            this.panel2.Controls.Add(this.uC_Pharma_AddMed1);
            this.panel2.Location = new System.Drawing.Point(267, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(876, 947);
            this.panel2.TabIndex = 1;
            // 
            // uC_Pharma_ValMed2
            // 
            this.uC_Pharma_ValMed2.BackColor = System.Drawing.Color.White;
            this.uC_Pharma_ValMed2.Location = new System.Drawing.Point(0, 0);
            this.uC_Pharma_ValMed2.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.uC_Pharma_ValMed2.Name = "uC_Pharma_ValMed2";
            this.uC_Pharma_ValMed2.Size = new System.Drawing.Size(875, 600);
            this.uC_Pharma_ValMed2.TabIndex = 5;
            // 
            // uC_Pharma_AddMed1
            // 
            this.uC_Pharma_AddMed1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uC_Pharma_AddMed1.BackColor = System.Drawing.Color.White;
            this.uC_Pharma_AddMed1.Location = new System.Drawing.Point(0, 0);
            this.uC_Pharma_AddMed1.Name = "uC_Pharma_AddMed1";
            this.uC_Pharma_AddMed1.Size = new System.Drawing.Size(878, 598);
            this.uC_Pharma_AddMed1.TabIndex = 0;
            // 
            // uC_Pharma_DashBrd1
            // 
            this.uC_Pharma_DashBrd1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uC_Pharma_DashBrd1.BackColor = System.Drawing.Color.White;
            this.uC_Pharma_DashBrd1.Location = new System.Drawing.Point(267, 0);
            this.uC_Pharma_DashBrd1.Name = "uC_Pharma_DashBrd1";
            this.uC_Pharma_DashBrd1.Size = new System.Drawing.Size(878, 761);
            this.uC_Pharma_DashBrd1.TabIndex = 0;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this.panel2;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.TargetControl = this.panel2;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.TargetControl = this.panel2;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.TargetControl = this.panel2;
            // 
            // guna2Elipse5
            // 
            this.guna2Elipse5.TargetControl = this.panel2;
            // 
            // guna2Elipse6
            // 
            this.guna2Elipse6.TargetControl = this.panel2;
            // 
            // uC_Pharma_UpdateMed1
            // 
            this.uC_Pharma_UpdateMed1.BackColor = System.Drawing.Color.White;
            this.uC_Pharma_UpdateMed1.Location = new System.Drawing.Point(0, 0);
            this.uC_Pharma_UpdateMed1.Margin = new System.Windows.Forms.Padding(2);
            this.uC_Pharma_UpdateMed1.Name = "uC_Pharma_UpdateMed1";
            this.uC_Pharma_UpdateMed1.Size = new System.Drawing.Size(887, 618);
            this.uC_Pharma_UpdateMed1.TabIndex = 6;
            // 
            // uC_Pharma_SellMed1
            // 
            this.uC_Pharma_SellMed1.BackColor = System.Drawing.Color.White;
            this.uC_Pharma_SellMed1.Location = new System.Drawing.Point(0, -9);
            this.uC_Pharma_SellMed1.Margin = new System.Windows.Forms.Padding(2);
            this.uC_Pharma_SellMed1.Name = "uC_Pharma_SellMed1";
            this.uC_Pharma_SellMed1.Size = new System.Drawing.Size(878, 642);
            this.uC_Pharma_SellMed1.TabIndex = 7;
            // 
            // uC_Pharma_ViewMed1
            // 
            this.uC_Pharma_ViewMed1.BackColor = System.Drawing.Color.White;
            this.uC_Pharma_ViewMed1.Location = new System.Drawing.Point(0, -9);
            this.uC_Pharma_ViewMed1.Margin = new System.Windows.Forms.Padding(2);
            this.uC_Pharma_ViewMed1.Name = "uC_Pharma_ViewMed1";
            this.uC_Pharma_ViewMed1.Size = new System.Drawing.Size(878, 661);
            this.uC_Pharma_ViewMed1.TabIndex = 8;
            // 
            // Pharmacist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1145, 629);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.uC_Pharma_DashBrd1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Pharmacist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pharmacist";
            this.Load += new System.EventHandler(this.Pharmacist_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnDashbrd;
        private Guna.UI2.WinForms.Guna2Button btnViewMed;
        private Guna.UI2.WinForms.Guna2Button btnAddMed;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
        private Guna.UI2.WinForms.Guna2Button btnSellMed;
        private Guna.UI2.WinForms.Guna2Button btnMedVal;
        private Guna.UI2.WinForms.Guna2Button btnModMed;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private PharmacistUserControl.UC_Pharma_DashBrd uC_Pharma_DashBrd1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private PharmacistUserControl.UC_Pharma_AddMed uC_Pharma_AddMed1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse5;
        private PharmacistUserControl.UC_Pharma_ValMed uC_Pharma_ValMed2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse6;
        private PharmacistUserControl.UC_Pharma_UpdateMed uC_Pharma_UpdateMed1;
        private PharmacistUserControl.UC_Pharma_SellMed uC_Pharma_SellMed1;
        private PharmacistUserControl.UC_Pharma_ViewMed uC_Pharma_ViewMed1;
    }
}