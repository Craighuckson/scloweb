using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ComPeters;
using Microsoft.VisualBasic;
using U2Drawx64.My;

namespace U2Drawx64
{
	// Token: 0x0200000E RID: 14
	public partial class frmImageCrop : Form
	{
		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x0600029F RID: 671 RVA: 0x000A1C20 File Offset: 0x000A0C20
		// (set) Token: 0x060002A0 RID: 672 RVA: 0x000A1C34 File Offset: 0x000A0C34
		internal virtual Button cmdTransferFromClipboard
		{
			[DebuggerNonUserCode]
			get
			{
				return this._cmdTransferFromClipboard;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				if (this._cmdTransferFromClipboard != null)
				{
					this._cmdTransferFromClipboard.Click -= this.cmdTransferFromClipboard_Click;
				}
				this._cmdTransferFromClipboard = value;
				if (this._cmdTransferFromClipboard != null)
				{
					this._cmdTransferFromClipboard.Click += this.cmdTransferFromClipboard_Click;
				}
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x060002A1 RID: 673 RVA: 0x000A1C88 File Offset: 0x000A0C88
		// (set) Token: 0x060002A2 RID: 674 RVA: 0x000A1C9C File Offset: 0x000A0C9C
		public virtual Button cmdTransferToDrawing
		{
			[DebuggerNonUserCode]
			get
			{
				return this._cmdTransferToDrawing;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				if (this._cmdTransferToDrawing != null)
				{
					this._cmdTransferToDrawing.Click -= this.cmdTransferToDrawing_Click;
				}
				this._cmdTransferToDrawing = value;
				if (this._cmdTransferToDrawing != null)
				{
					this._cmdTransferToDrawing.Click += this.cmdTransferToDrawing_Click;
				}
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x060002A3 RID: 675 RVA: 0x000A1CF0 File Offset: 0x000A0CF0
		// (set) Token: 0x060002A4 RID: 676 RVA: 0x000A1D04 File Offset: 0x000A0D04
		internal virtual Button cmdCancel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._cmdCancel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				if (this._cmdCancel != null)
				{
					this._cmdCancel.Click -= this.cmdCancel_Click;
				}
				this._cmdCancel = value;
				if (this._cmdCancel != null)
				{
					this._cmdCancel.Click += this.cmdCancel_Click;
				}
			}
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x000A1D58 File Offset: 0x000A0D58
		public frmImageCrop()
		{
			this.cropPenSize = 2;
			this.cropDashStyle = DashStyle.Solid;
			this.cropPenColor = Color.Aquamarine;
			this.InitializeComponent();
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x060002A7 RID: 679 RVA: 0x000A1DA0 File Offset: 0x000A0DA0
		// (set) Token: 0x060002A8 RID: 680 RVA: 0x000A1DB4 File Offset: 0x000A0DB4
		internal virtual PictureBox p
		{
			[DebuggerNonUserCode]
			get
			{
				return this._p;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				if (this._p != null)
				{
					this._p.MouseMove -= this.p_MouseMove;
					this._p.MouseUp -= this.p_MouseUp;
					this._p.MouseDown -= this.p_MouseDown;
				}
				this._p = value;
				if (this._p != null)
				{
					this._p.MouseMove += this.p_MouseMove;
					this._p.MouseUp += this.p_MouseUp;
					this._p.MouseDown += this.p_MouseDown;
				}
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x060002A9 RID: 681 RVA: 0x000A1E68 File Offset: 0x000A0E68
		// (set) Token: 0x060002AA RID: 682 RVA: 0x000A1E7C File Offset: 0x000A0E7C
		internal virtual Button btnOpen
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnOpen;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				if (this._btnOpen != null)
				{
					this._btnOpen.Click -= this.btnOpen_Click;
				}
				this._btnOpen = value;
				if (this._btnOpen != null)
				{
					this._btnOpen.Click += this.btnOpen_Click;
				}
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x060002AB RID: 683 RVA: 0x000A1ED0 File Offset: 0x000A0ED0
		// (set) Token: 0x060002AC RID: 684 RVA: 0x000A1EE4 File Offset: 0x000A0EE4
		internal virtual Button btnCrop
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnCrop;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				if (this._btnCrop != null)
				{
					this._btnCrop.Click -= this.btnCrop_Click;
				}
				this._btnCrop = value;
				if (this._btnCrop != null)
				{
					this._btnCrop.Click += this.btnCrop_Click;
				}
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x060002AD RID: 685 RVA: 0x000A1F38 File Offset: 0x000A0F38
		// (set) Token: 0x060002AE RID: 686 RVA: 0x000A1F4C File Offset: 0x000A0F4C
		internal virtual PictureBox pbCrop
		{
			[DebuggerNonUserCode]
			get
			{
				return this._pbCrop;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._pbCrop = value;
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x060002B0 RID: 688 RVA: 0x000A224C File Offset: 0x000A124C
		public frmImageCrop.StatusType GetStatus
		{
			get
			{
				return this.status;
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x060002B1 RID: 689 RVA: 0x000A2260 File Offset: 0x000A1260
		public Image GetCroppedImage
		{
			get
			{
				if (this.status == frmImageCrop.StatusType.imageCropped)
				{
					return this.pbCrop.Image;
				}
				return null;
			}
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x000A2284 File Offset: 0x000A1284
		private bool CollectScreenImageFromClipBoard()
		{
			bool result;
			try
			{
				if (MyProject.Computer.Clipboard.ContainsImage())
				{
					this.p.Width = MyProject.Computer.Clipboard.GetImage().Width;
					this.p.Height = MyProject.Computer.Clipboard.GetImage().Height;
					this.p.Image = MyProject.Computer.Clipboard.GetImage();
					result = true;
				}
				else
				{
					Interaction.MsgBox("There is currently no image on the clipboard, so \r\nnone can be tranferred.  Please transfer one there \r\nand try again.", MsgBoxStyle.Information, "ERROR: NO AVAILABLE IMAGE");
					result = false;
				}
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
				result = false;
			}
			return result;
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x000A2340 File Offset: 0x000A1340
		private void btnOpen_Click(object sender, EventArgs e)
		{
			try
			{
				OpenFileDialog openFileDialog = new OpenFileDialog();
				openFileDialog.Filter = "Image Files (*.bmp, *.gif, *.jpg)|*.bmp;*.gif;*.jpg";
				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					Image image = Image.FromFile(openFileDialog.FileName, true);
					this.p.Width = image.Width;
					this.p.Height = image.Height;
					this.p.Image = image;
				}
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x000A23C8 File Offset: 0x000A13C8
		private void btnCrop_Click(object sender, EventArgs e)
		{
			try
			{
				if (this.cropWidth < 1)
				{
					MessageBox.Show("You need to first select what portion of the image to crop.", " No cropping Cordinates!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
				else
				{
					Rectangle srcRect = new Rectangle(this.cropX, this.cropY, this.cropWidth, this.cropHeight);
					Bitmap image = new Bitmap(this.p.Image, this.p.Width, this.p.Height);
					this.cropBitmap = new Bitmap(this.cropWidth, this.cropHeight);
					Graphics graphics = Graphics.FromImage(this.cropBitmap);
					graphics.DrawImage(image, 0, 0, srcRect, GraphicsUnit.Pixel);
					this.pbCrop.Image = this.cropBitmap;
					this.p.Height = this.cropBitmap.Height;
					this.p.Width = this.cropBitmap.Width;
					this.p.Image = this.cropBitmap;
				}
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x000A24E0 File Offset: 0x000A14E0
		private void btnSave_Click(object sender, EventArgs e)
		{
			try
			{
				if (this.pbCrop.Image == null)
				{
					MessageBox.Show("You have not edited the original image. There is no new image to save.", " Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
				else
				{
					SaveFileDialog saveFileDialog = new SaveFileDialog();
					saveFileDialog.Filter = "Image Files (*.bmp, *.gif, *.jpg)|*.bmp;*.gif;*.jpg";
					if (saveFileDialog.ShowDialog() == DialogResult.OK)
					{
						if (saveFileDialog.FileName.EndsWith("bmp"))
						{
							this.pbCrop.Image.Save(saveFileDialog.FileName, ImageFormat.Bmp);
						}
						else if (saveFileDialog.FileName.EndsWith("gif"))
						{
							this.pbCrop.Image.Save(saveFileDialog.FileName, ImageFormat.Gif);
						}
						else
						{
							this.pbCrop.Image.Save(saveFileDialog.FileName, ImageFormat.Jpeg);
						}
						saveFileDialog.Dispose();
					}
				}
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x000A25D4 File Offset: 0x000A15D4
		private void p_MouseDown(object sender, MouseEventArgs e)
		{
			try
			{
				if (e.Button == MouseButtons.Left)
				{
					this.cropX = e.X;
					this.cropY = e.Y;
					this.cropPen = new Pen(this.cropPenColor, (float)this.cropPenSize);
					this.cropPen.DashStyle = this.cropDashStyle;
					this.Cursor = Cursors.Cross;
				}
				this.p.Refresh();
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x000A266C File Offset: 0x000A166C
		private void p_MouseUp(object sender, MouseEventArgs e)
		{
			try
			{
				this.Cursor = Cursors.Default;
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x000A26AC File Offset: 0x000A16AC
		private void p_MouseMove(object sender, MouseEventArgs e)
		{
			checked
			{
				try
				{
					if (this.p.Image != null)
					{
						if (e.Button == MouseButtons.Left)
						{
							this.p.Refresh();
							this.cropWidth = e.X - this.cropX;
							this.cropHeight = e.Y - this.cropY;
							this.p.CreateGraphics().DrawRectangle(this.cropPen, this.cropX, this.cropY, this.cropWidth, this.cropHeight);
						}
						GC.Collect();
					}
				}
				catch (Exception ex)
				{
					if (Information.Err().Number != 5)
					{
						MessageBox.Show(ex.Message, " Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					}
				}
			}
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x000A2784 File Offset: 0x000A1784
		private void cmdTransferFromClipboard_Click(object sender, EventArgs e)
		{
			this.CollectScreenImageFromClipBoard();
		}

		// Token: 0x060002BA RID: 698 RVA: 0x000A2790 File Offset: 0x000A1790
		private void cmdCancel_Click(object sender, EventArgs e)
		{
			this.status = frmImageCrop.StatusType.cancelled;
			this.Hide();
		}

		// Token: 0x060002BB RID: 699 RVA: 0x000A27A0 File Offset: 0x000A17A0
		private void cmdTransferToDrawing_Click(object sender, EventArgs e)
		{
			if (this.pbCrop.Image == null)
			{
				Interaction.MsgBox("You current have no image cropped, so none can \r\ntransferred back at this time.  Please crop one \r\nand try again.", MsgBoxStyle.Exclamation, "ERROR: NO CROPPED IMAGE AVAILABLE");
			}
			else
			{
				this.status = frmImageCrop.StatusType.imageCropped;
				this.Hide();
			}
		}

		// Token: 0x04000121 RID: 289
		private Bitmap cropBitmap;

		// Token: 0x04000122 RID: 290
		private int cropX;

		// Token: 0x04000123 RID: 291
		private int cropY;

		// Token: 0x04000124 RID: 292
		private int cropWidth;

		// Token: 0x04000125 RID: 293
		private int cropHeight;

		// Token: 0x04000126 RID: 294
		public Pen cropPen;

		// Token: 0x04000127 RID: 295
		public int cropPenSize;

		// Token: 0x04000128 RID: 296
		public DashStyle cropDashStyle;

		// Token: 0x04000129 RID: 297
		public Color cropPenColor;

		// Token: 0x0400012A RID: 298
		[AccessedThroughProperty("cmdTransferFromClipboard")]
		private Button _cmdTransferFromClipboard;

		// Token: 0x0400012B RID: 299
		[AccessedThroughProperty("cmdTransferToDrawing")]
		private Button _cmdTransferToDrawing;

		// Token: 0x0400012C RID: 300
		[AccessedThroughProperty("cmdCancel")]
		private Button _cmdCancel;

		// Token: 0x0400012D RID: 301
		public Cursors c;

		// Token: 0x0400012E RID: 302
		private frmImageCrop.StatusType status;

		// Token: 0x04000130 RID: 304
		[AccessedThroughProperty("p")]
		private PictureBox _p;

		// Token: 0x04000131 RID: 305
		[AccessedThroughProperty("btnOpen")]
		private Button _btnOpen;

		// Token: 0x04000132 RID: 306
		[AccessedThroughProperty("btnCrop")]
		private Button _btnCrop;

		// Token: 0x04000133 RID: 307
		[AccessedThroughProperty("pbCrop")]
		private PictureBox _pbCrop;

		// Token: 0x0200000F RID: 15
		public enum StatusType
		{
			// Token: 0x04000135 RID: 309
			imageCropped = 1,
			// Token: 0x04000136 RID: 310
			cancelled
		}
	}
}
