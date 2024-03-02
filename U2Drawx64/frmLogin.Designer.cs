namespace U2Drawx64
{
	// Token: 0x0200000B RID: 11
	internal partial class frmLogin : global::System.Windows.Forms.Form
	{
		// Token: 0x0600004D RID: 77 RVA: 0x0009C798 File Offset: 0x0009B798
		protected override void Dispose(bool Disposing)
		{
			if (Disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(Disposing);
		}

		// Token: 0x06000066 RID: 102 RVA: 0x0009CA10 File Offset: 0x0009BA10
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::U2Drawx64.frmLogin));
			this.ToolTip1 = new global::System.Windows.Forms.ToolTip(this.components);
			this.cmdCancel = new global::System.Windows.Forms.Button();
			this.cmdOK = new global::System.Windows.Forms.Button();
			this.txtPassword = new global::System.Windows.Forms.TextBox();
			this.lblUtiLocateLogin_EnterLogin = new global::System.Windows.Forms.Label();
			this.lblUtiLocateEmployee = new global::System.Windows.Forms.Label();
			this.lblUtiLocateLogin_Password = new global::System.Windows.Forms.Label();
			this.lstEmployee = new global::System.Windows.Forms.ComboBox();
			this.lblLabels = new global::Microsoft.VisualBasic.Compatibility.VB6.LabelArray(this.components);
			this.PictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.lblCopyright = new global::System.Windows.Forms.Label();
			this.lblCompany = new global::System.Windows.Forms.Label();
			this.lblVersion = new global::System.Windows.Forms.Label();
			((global::System.ComponentModel.ISupportInitialize)this.lblLabels).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
			this.SuspendLayout();
			this.cmdCancel.BackColor = global::System.Drawing.SystemColors.Control;
			this.cmdCancel.Cursor = global::System.Windows.Forms.Cursors.Default;
			this.cmdCancel.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			componentResourceManager.ApplyResources(this.cmdCancel, "cmdCancel");
			this.cmdCancel.ForeColor = global::System.Drawing.SystemColors.ControlText;
			this.cmdCancel.Image = global::U2Drawx64.My.Resources.Resources.cancel;
			this.cmdCancel.Name = "cmdCancel";
			this.ToolTip1.SetToolTip(this.cmdCancel, componentResourceManager.GetString("cmdCancel.ToolTip"));
			this.cmdCancel.UseVisualStyleBackColor = false;
			this.cmdOK.BackColor = global::System.Drawing.SystemColors.Control;
			this.cmdOK.Cursor = global::System.Windows.Forms.Cursors.Default;
			componentResourceManager.ApplyResources(this.cmdOK, "cmdOK");
			this.cmdOK.ForeColor = global::System.Drawing.SystemColors.ControlText;
			this.cmdOK.Image = global::U2Drawx64.My.Resources.Resources.tick;
			this.cmdOK.Name = "cmdOK";
			this.cmdOK.UseVisualStyleBackColor = false;
			this.txtPassword.AcceptsReturn = true;
			this.txtPassword.BackColor = global::System.Drawing.SystemColors.Window;
			this.txtPassword.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			componentResourceManager.ApplyResources(this.txtPassword, "txtPassword");
			this.txtPassword.ForeColor = global::System.Drawing.SystemColors.WindowText;
			this.txtPassword.Name = "txtPassword";
			this.lblUtiLocateLogin_EnterLogin.BackColor = global::System.Drawing.Color.WhiteSmoke;
			this.lblUtiLocateLogin_EnterLogin.Cursor = global::System.Windows.Forms.Cursors.Default;
			componentResourceManager.ApplyResources(this.lblUtiLocateLogin_EnterLogin, "lblUtiLocateLogin_EnterLogin");
			this.lblUtiLocateLogin_EnterLogin.ForeColor = global::System.Drawing.SystemColors.ControlText;
			this.lblUtiLocateLogin_EnterLogin.Name = "lblUtiLocateLogin_EnterLogin";
			this.lblUtiLocateEmployee.BackColor = global::System.Drawing.Color.WhiteSmoke;
			this.lblUtiLocateEmployee.Cursor = global::System.Windows.Forms.Cursors.Default;
			componentResourceManager.ApplyResources(this.lblUtiLocateEmployee, "lblUtiLocateEmployee");
			this.lblUtiLocateEmployee.ForeColor = global::System.Drawing.Color.FromArgb(0, 101, 179);
			this.lblLabels.SetIndex(this.lblUtiLocateEmployee, 0);
			this.lblUtiLocateEmployee.Name = "lblUtiLocateEmployee";
			this.lblUtiLocateLogin_Password.BackColor = global::System.Drawing.Color.WhiteSmoke;
			this.lblUtiLocateLogin_Password.Cursor = global::System.Windows.Forms.Cursors.Default;
			componentResourceManager.ApplyResources(this.lblUtiLocateLogin_Password, "lblUtiLocateLogin_Password");
			this.lblUtiLocateLogin_Password.ForeColor = global::System.Drawing.Color.FromArgb(0, 101, 179);
			this.lblLabels.SetIndex(this.lblUtiLocateLogin_Password, 1);
			this.lblUtiLocateLogin_Password.Name = "lblUtiLocateLogin_Password";
			this.lstEmployee.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			componentResourceManager.ApplyResources(this.lstEmployee, "lstEmployee");
			this.lstEmployee.Name = "lstEmployee";
			this.PictureBox1.BackColor = global::System.Drawing.Color.White;
			componentResourceManager.ApplyResources(this.PictureBox1, "PictureBox1");
			this.PictureBox1.ErrorImage = null;
			this.PictureBox1.Name = "PictureBox1";
			this.PictureBox1.TabStop = false;
			this.lblCopyright.BackColor = global::System.Drawing.Color.FromArgb(224, 224, 224);
			this.lblCopyright.Cursor = global::System.Windows.Forms.Cursors.Default;
			componentResourceManager.ApplyResources(this.lblCopyright, "lblCopyright");
			this.lblCopyright.ForeColor = global::System.Drawing.SystemColors.ControlText;
			this.lblCopyright.Name = "lblCopyright";
			this.lblCompany.BackColor = global::System.Drawing.Color.FromArgb(224, 224, 224);
			this.lblCompany.Cursor = global::System.Windows.Forms.Cursors.Default;
			componentResourceManager.ApplyResources(this.lblCompany, "lblCompany");
			this.lblCompany.ForeColor = global::System.Drawing.SystemColors.ControlText;
			this.lblCompany.Name = "lblCompany";
			componentResourceManager.ApplyResources(this.lblVersion, "lblVersion");
			this.lblVersion.BackColor = global::System.Drawing.Color.FromArgb(224, 224, 224);
			this.lblVersion.Cursor = global::System.Windows.Forms.Cursors.Default;
			this.lblVersion.ForeColor = global::System.Drawing.SystemColors.ControlText;
			this.lblVersion.Name = "lblVersion";
			this.AcceptButton = this.cmdOK;
			componentResourceManager.ApplyResources(this, "$this");
			this.BackColor = global::System.Drawing.Color.WhiteSmoke;
			this.CancelButton = this.cmdCancel;
			this.Controls.Add(this.PictureBox1);
			this.Controls.Add(this.lblCopyright);
			this.Controls.Add(this.lblCompany);
			this.Controls.Add(this.lblVersion);
			this.Controls.Add(this.lstEmployee);
			this.Controls.Add(this.cmdOK);
			this.Controls.Add(this.cmdCancel);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.lblUtiLocateLogin_EnterLogin);
			this.Controls.Add(this.lblUtiLocateEmployee);
			this.Controls.Add(this.lblUtiLocateLogin_Password);
			this.Cursor = global::System.Windows.Forms.Cursors.Default;
			this.ForeColor = global::System.Drawing.Color.FromArgb(0, 101, 179);
			this.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmLogin";
			((global::System.ComponentModel.ISupportInitialize)this.lblLabels).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		// Token: 0x0400001C RID: 28
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400001D RID: 29
		public global::System.Windows.Forms.ToolTip ToolTip1;
	}
}
