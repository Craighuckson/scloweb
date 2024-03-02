namespace U2Drawx64
{
	// Token: 0x0200000A RID: 10
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class frmInput : global::System.Windows.Forms.Form
	{
		// Token: 0x0600003D RID: 61 RVA: 0x000AC240 File Offset: 0x000AB240
		[global::System.Diagnostics.DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600003E RID: 62 RVA: 0x000AC260 File Offset: 0x000AB260
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.TextBox1 = new global::System.Windows.Forms.TextBox();
			this.btnOk = new global::System.Windows.Forms.Button();
			this.btnCancel = new global::System.Windows.Forms.Button();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.SuspendLayout();
			global::System.Windows.Forms.Control textBox = this.TextBox1;
			global::System.Drawing.Point location = new global::System.Drawing.Point(12, 119);
			textBox.Location = location;
			this.TextBox1.Name = "TextBox1";
			global::System.Windows.Forms.Control textBox2 = this.TextBox1;
			global::System.Drawing.Size size = new global::System.Drawing.Size(512, 20);
			textBox2.Size = size;
			this.TextBox1.TabIndex = 0;
			global::System.Windows.Forms.Control btnOk = this.btnOk;
			location = new global::System.Drawing.Point(356, 145);
			btnOk.Location = location;
			this.btnOk.Name = "btnOk";
			global::System.Windows.Forms.Control btnOk2 = this.btnOk;
			size = new global::System.Drawing.Size(75, 23);
			btnOk2.Size = size;
			this.btnOk.TabIndex = 1;
			this.btnOk.Text = "OK";
			this.btnOk.UseVisualStyleBackColor = true;
			global::System.Windows.Forms.Control btnCancel = this.btnCancel;
			location = new global::System.Drawing.Point(449, 145);
			btnCancel.Location = location;
			this.btnCancel.Name = "btnCancel";
			global::System.Windows.Forms.Control btnCancel2 = this.btnCancel;
			size = new global::System.Drawing.Size(75, 23);
			btnCancel2.Size = size;
			this.btnCancel.TabIndex = 2;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.Label1.AutoSize = true;
			global::System.Windows.Forms.Control label = this.Label1;
			location = new global::System.Drawing.Point(12, 23);
			label.Location = location;
			this.Label1.Name = "Label1";
			global::System.Windows.Forms.Control label2 = this.Label1;
			size = new global::System.Drawing.Size(98, 13);
			label2.Size = size;
			this.Label1.TabIndex = 3;
			this.Label1.Text = "Blank text to be filll ";
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			size = new global::System.Drawing.Size(536, 184);
			this.ClientSize = size;
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOk);
			this.Controls.Add(this.TextBox1);
			this.Name = "frmInput";
			this.Text = "frmInput";
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		// Token: 0x04000016 RID: 22
		private global::System.ComponentModel.IContainer components;
	}
}
