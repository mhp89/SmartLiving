using SmartControls;

namespace LivingSmartForms
{
    partial class EstateAgentLine
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
			this.tlpEmployee = new System.Windows.Forms.TableLayoutPanel();
			this.btnEditEstateAgent = new SmartControls.SmartButton();
			this.slbName = new SmartControls.SmartLabel();
			this.slbHireDate = new SmartControls.SmartLabel();
			this.slbPhone = new SmartControls.SmartLabel();
			this.slbEmail = new SmartControls.SmartLabel();
			this.slbEmployeeNo = new SmartControls.SmartLabel();
			this.tlpEmployee.SuspendLayout();
			this.SuspendLayout();
			// 
			// tlpEmployee
			// 
			this.tlpEmployee.ColumnCount = 5;
			this.tlpEmployee.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.80028F));
			this.tlpEmployee.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.16034F));
			this.tlpEmployee.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.67651F));
			this.tlpEmployee.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.36287F));
			this.tlpEmployee.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tlpEmployee.Controls.Add(this.btnEditEstateAgent, 4, 0);
			this.tlpEmployee.Controls.Add(this.slbName, 1, 0);
			this.tlpEmployee.Controls.Add(this.slbHireDate, 1, 1);
			this.tlpEmployee.Controls.Add(this.slbPhone, 3, 0);
			this.tlpEmployee.Controls.Add(this.slbEmail, 3, 1);
			this.tlpEmployee.Controls.Add(this.slbEmployeeNo, 0, 0);
			this.tlpEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tlpEmployee.Location = new System.Drawing.Point(0, 0);
			this.tlpEmployee.Margin = new System.Windows.Forms.Padding(2);
			this.tlpEmployee.Name = "tlpEmployee";
			this.tlpEmployee.RowCount = 2;
			this.tlpEmployee.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlpEmployee.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlpEmployee.Size = new System.Drawing.Size(600, 49);
			this.tlpEmployee.TabIndex = 0;
			// 
			// btnEditEstateAgent
			// 
			this.btnEditEstateAgent.AutoSize = true;
			this.btnEditEstateAgent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.btnEditEstateAgent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.btnEditEstateAgent.Color = SmartControls.SmartColor.ColorStyle.Light;
			this.btnEditEstateAgent.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnEditEstateAgent.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnEditEstateAgent.FlatAppearance.BorderSize = 0;
			this.btnEditEstateAgent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.btnEditEstateAgent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.btnEditEstateAgent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEditEstateAgent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.btnEditEstateAgent.Location = new System.Drawing.Point(494, 10);
			this.btnEditEstateAgent.Margin = new System.Windows.Forms.Padding(10);
			this.btnEditEstateAgent.Name = "btnEditEstateAgent";
			this.tlpEmployee.SetRowSpan(this.btnEditEstateAgent, 2);
			this.btnEditEstateAgent.Size = new System.Drawing.Size(96, 29);
			this.btnEditEstateAgent.TabIndex = 10;
			this.btnEditEstateAgent.Text = "Redigér";
			this.btnEditEstateAgent.UseVisualStyleBackColor = false;
			// 
			// slbName
			// 
			this.slbName.AutoSize = true;
			this.tlpEmployee.SetColumnSpan(this.slbName, 2);
			this.slbName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.slbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.slbName.Location = new System.Drawing.Point(105, 0);
			this.slbName.Name = "slbName";
			this.slbName.Size = new System.Drawing.Size(271, 24);
			this.slbName.TabIndex = 2;
			this.slbName.Text = "Medarbejders navn";
			this.slbName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.slbName.Title = "Navn:";
			this.slbName.TitleFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			// 
			// slbHireDate
			// 
			this.slbHireDate.AutoSize = true;
			this.tlpEmployee.SetColumnSpan(this.slbHireDate, 2);
			this.slbHireDate.Dock = System.Windows.Forms.DockStyle.Fill;
			this.slbHireDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.slbHireDate.Location = new System.Drawing.Point(105, 24);
			this.slbHireDate.Name = "slbHireDate";
			this.slbHireDate.Size = new System.Drawing.Size(271, 25);
			this.slbHireDate.TabIndex = 5;
			this.slbHireDate.Text = "xx yyy zzzz";
			this.slbHireDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.slbHireDate.Title = "Ansættelsesdato:";
			this.slbHireDate.TitleFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			// 
			// slbPhone
			// 
			this.slbPhone.AutoSize = true;
			this.slbPhone.Dock = System.Windows.Forms.DockStyle.Fill;
			this.slbPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.slbPhone.Location = new System.Drawing.Point(376, 0);
			this.slbPhone.Name = "slbPhone";
			this.slbPhone.Size = new System.Drawing.Size(108, 24);
			this.slbPhone.TabIndex = 6;
			this.slbPhone.Text = "xxxx xxxx";
			this.slbPhone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.slbPhone.Title = "Telefonnummer:";
			this.slbPhone.TitleFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			// 
			// slbEmail
			// 
			this.slbEmail.AutoSize = true;
			this.slbEmail.Dock = System.Windows.Forms.DockStyle.Fill;
			this.slbEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.slbEmail.Location = new System.Drawing.Point(376, 24);
			this.slbEmail.Name = "slbEmail";
			this.slbEmail.Size = new System.Drawing.Size(108, 25);
			this.slbEmail.TabIndex = 7;
			this.slbEmail.Text = "employee@smartliving.dk";
			this.slbEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.slbEmail.Title = "Email:";
			this.slbEmail.TitleFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			// 
			// slbEmployeeNo
			// 
			this.slbEmployeeNo.AutoSize = true;
			this.slbEmployeeNo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.slbEmployeeNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.slbEmployeeNo.Location = new System.Drawing.Point(0, 0);
			this.slbEmployeeNo.Name = "slbEmployeeNo";
			this.tlpEmployee.SetRowSpan(this.slbEmployeeNo, 2);
			this.slbEmployeeNo.Size = new System.Drawing.Size(105, 49);
			this.slbEmployeeNo.TabIndex = 8;
			this.slbEmployeeNo.Text = "xxx";
			this.slbEmployeeNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.slbEmployeeNo.Title = "Medarbejdernr:";
			this.slbEmployeeNo.TitleFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			// 
			// EstateAgentLine
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.Controls.Add(this.tlpEmployee);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "EstateAgentLine";
			this.Size = new System.Drawing.Size(600, 49);
			this.tlpEmployee.ResumeLayout(false);
			this.tlpEmployee.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

		private System.Windows.Forms.TableLayoutPanel tlpEmployee;
		private SmartControls.SmartLabel slbName;
        private SmartControls.SmartLabel slbHireDate;
        private SmartControls.SmartLabel slbPhone;
        private SmartControls.SmartLabel slbEmail;
        private SmartControls.SmartLabel slbEmployeeNo;
		private SmartControls.SmartButton btnEditEstateAgent;
    }
}
