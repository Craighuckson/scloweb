using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace U2Drawx64
{
	// Token: 0x0200000A RID: 10
	[DesignerGenerated]
	public partial class frmInput : Form
	{
		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600003F RID: 63 RVA: 0x000AC4C8 File Offset: 0x000AB4C8
		// (set) Token: 0x06000040 RID: 64 RVA: 0x000AC4DC File Offset: 0x000AB4DC
		internal virtual TextBox TextBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TextBox1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TextBox1 = value;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000041 RID: 65 RVA: 0x000AC4E8 File Offset: 0x000AB4E8
		// (set) Token: 0x06000042 RID: 66 RVA: 0x000AC4FC File Offset: 0x000AB4FC
		internal virtual Button btnOk
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnOk;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				if (this._btnOk != null)
				{
					this._btnOk.Click -= this.btnOk_Click;
				}
				this._btnOk = value;
				if (this._btnOk != null)
				{
					this._btnOk.Click += this.btnOk_Click;
				}
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000043 RID: 67 RVA: 0x000AC550 File Offset: 0x000AB550
		// (set) Token: 0x06000044 RID: 68 RVA: 0x000AC564 File Offset: 0x000AB564
		internal virtual Button btnCancel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnCancel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				if (this._btnCancel != null)
				{
					this._btnCancel.Click -= this.btnCancel_Click;
				}
				this._btnCancel = value;
				if (this._btnCancel != null)
				{
					this._btnCancel.Click += this.btnCancel_Click;
				}
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000045 RID: 69 RVA: 0x000AC5B8 File Offset: 0x000AB5B8
		// (set) Token: 0x06000046 RID: 70 RVA: 0x000AC5CC File Offset: 0x000AB5CC
		internal virtual Label Label1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label1 = value;
			}
		}

		// Token: 0x06000047 RID: 71 RVA: 0x000AC5D8 File Offset: 0x000AB5D8
		public string GetResult()
		{
			return this.TextBox1.Text;
		}

		// Token: 0x06000048 RID: 72 RVA: 0x000AC5F0 File Offset: 0x000AB5F0
		public frmInput(string Message, string WindowTitle)
		{
			base.FormClosed += this.frmInput_FormClosed;
			this.Cancelled = false;
			this.InitializeComponent();
			this.Label1.Text = Message;
			this.Text = WindowTitle;
		}

		// Token: 0x06000049 RID: 73 RVA: 0x000AC62C File Offset: 0x000AB62C
		private void btnOk_Click(object sender, EventArgs e)
		{
			if (Operators.CompareString(this.TextBox1.Text, string.Empty, false) == 0)
			{
				Interaction.MsgBox("Please type in a an explanation.", MsgBoxStyle.OkOnly, null);
			}
			else
			{
				this.Hide();
			}
		}

		// Token: 0x0600004A RID: 74 RVA: 0x000AC65C File Offset: 0x000AB65C
		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Cancelled = true;
			this.Hide();
		}

		// Token: 0x0600004B RID: 75 RVA: 0x000AC66C File Offset: 0x000AB66C
		private void frmInput_FormClosed(object sender, FormClosedEventArgs e)
		{
			this.Cancelled = true;
		}

		// Token: 0x04000017 RID: 23
		[AccessedThroughProperty("TextBox1")]
		private TextBox _TextBox1;

		// Token: 0x04000018 RID: 24
		[AccessedThroughProperty("btnOk")]
		private Button _btnOk;

		// Token: 0x04000019 RID: 25
		[AccessedThroughProperty("btnCancel")]
		private Button _btnCancel;

		// Token: 0x0400001A RID: 26
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x0400001B RID: 27
		public bool Cancelled;
	}
}
