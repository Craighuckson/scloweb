namespace U2Drawx64
{
	// Token: 0x0200000E RID: 14
	public partial class frmImageCrop : global::System.Windows.Forms.Form
	{
		// Token: 0x060002A6 RID: 678 RVA: 0x000A1D80 File Offset: 0x000A0D80
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060002AF RID: 687 RVA: 0x000A1F58 File Offset: 0x000A0F58
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::U2Drawx64.frmImageCrop));
			this.btnOpen = new global::System.Windows.Forms.Button();
			this.btnCrop = new global::System.Windows.Forms.Button();
			this.cmdTransferFromClipboard = new global::System.Windows.Forms.Button();
			this.cmdTransferToDrawing = new global::System.Windows.Forms.Button();
			this.cmdCancel = new global::System.Windows.Forms.Button();
			this.p = new global::System.Windows.Forms.PictureBox();
			this.pbCrop = new global::System.Windows.Forms.PictureBox();
			((global::System.ComponentModel.ISupportInitialize)this.p).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pbCrop).BeginInit();
			this.SuspendLayout();
			this.btnOpen.BackColor = global::System.Drawing.Color.Gainsboro;
			componentResourceManager.ApplyResources(this.btnOpen, "btnOpen");
			this.btnOpen.Name = "btnOpen";
			this.btnOpen.UseVisualStyleBackColor = false;
			this.btnCrop.BackColor = global::System.Drawing.Color.Gainsboro;
			componentResourceManager.ApplyResources(this.btnCrop, "btnCrop");
			this.btnCrop.Name = "btnCrop";
			this.btnCrop.UseVisualStyleBackColor = false;
			this.cmdTransferFromClipboard.BackColor = global::System.Drawing.Color.Gainsboro;
			componentResourceManager.ApplyResources(this.cmdTransferFromClipboard, "cmdTransferFromClipboard");
			this.cmdTransferFromClipboard.Name = "cmdTransferFromClipboard";
			this.cmdTransferFromClipboard.UseVisualStyleBackColor = false;
			this.cmdTransferToDrawing.BackColor = global::System.Drawing.Color.Gainsboro;
			componentResourceManager.ApplyResources(this.cmdTransferToDrawing, "cmdTransferToDrawing");
			this.cmdTransferToDrawing.Name = "cmdTransferToDrawing";
			this.cmdTransferToDrawing.UseVisualStyleBackColor = false;
			this.cmdCancel.BackColor = global::System.Drawing.Color.Gainsboro;
			componentResourceManager.ApplyResources(this.cmdCancel, "cmdCancel");
			this.cmdCancel.Name = "cmdCancel";
			this.cmdCancel.UseVisualStyleBackColor = false;
			this.p.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			componentResourceManager.ApplyResources(this.p, "p");
			this.p.Name = "p";
			this.p.TabStop = false;
			this.pbCrop.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			componentResourceManager.ApplyResources(this.pbCrop, "pbCrop");
			this.pbCrop.Name = "pbCrop";
			this.pbCrop.TabStop = false;
			componentResourceManager.ApplyResources(this, "$this");
			this.BackColor = global::System.Drawing.Color.FromArgb(224, 224, 224);
			this.Controls.Add(this.cmdCancel);
			this.Controls.Add(this.cmdTransferToDrawing);
			this.Controls.Add(this.cmdTransferFromClipboard);
			this.Controls.Add(this.btnCrop);
			this.Controls.Add(this.btnOpen);
			this.Controls.Add(this.p);
			this.Controls.Add(this.pbCrop);
			this.Name = "frmImageCrop";
			((global::System.ComponentModel.ISupportInitialize)this.p).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pbCrop).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		// Token: 0x0400012F RID: 303
		private global::System.ComponentModel.IContainer components;
	}
}
