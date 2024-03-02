using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ComPeters;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;

namespace U2Drawx64
{
	// Token: 0x0200000D RID: 13
	[DesignerGenerated]
	internal partial class frmDrawing : Form
	{
		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000161 RID: 353 RVA: 0x000B046C File Offset: 0x000AF46C
		// (set) Token: 0x06000162 RID: 354 RVA: 0x000B0480 File Offset: 0x000AF480
		internal virtual GLControl GlControl1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GlControl1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				if (this._GlControl1 != null)
				{
					this._GlControl1.MouseUp -= this.GlControl1_MouseUp;
					this._GlControl1.MouseMove -= this.GlControl1_MouseMove;
					this._GlControl1.MouseDown -= this.GlControl1_MouseDown;
					this._GlControl1.MouseDoubleClick -= this.GlControl1_MouseDoubleClick;
					this._GlControl1.Paint -= this.GlControl1_Paint;
				}
				this._GlControl1 = value;
				if (this._GlControl1 != null)
				{
					this._GlControl1.MouseUp += this.GlControl1_MouseUp;
					this._GlControl1.MouseMove += this.GlControl1_MouseMove;
					this._GlControl1.MouseDown += this.GlControl1_MouseDown;
					this._GlControl1.MouseDoubleClick += this.GlControl1_MouseDoubleClick;
					this._GlControl1.Paint += this.GlControl1_Paint;
				}
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000163 RID: 355 RVA: 0x000B0594 File Offset: 0x000AF594
		// (set) Token: 0x06000164 RID: 356 RVA: 0x000B05A8 File Offset: 0x000AF5A8
		public virtual Button btnStraightLine
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnStraightLine;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				if (this._btnStraightLine != null)
				{
					this._btnStraightLine.Click -= this.cmdStraightLine_Click;
				}
				this._btnStraightLine = value;
				if (this._btnStraightLine != null)
				{
					this._btnStraightLine.Click += this.cmdStraightLine_Click;
				}
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06000165 RID: 357 RVA: 0x000B05FC File Offset: 0x000AF5FC
		// (set) Token: 0x06000166 RID: 358 RVA: 0x000B0610 File Offset: 0x000AF610
		public virtual Button btnFreeDrawing
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnFreeDrawing;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				if (this._btnFreeDrawing != null)
				{
					this._btnFreeDrawing.Click -= this.cmdFreeDrawing_Click;
				}
				this._btnFreeDrawing = value;
				if (this._btnFreeDrawing != null)
				{
					this._btnFreeDrawing.Click += this.cmdFreeDrawing_Click;
				}
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06000167 RID: 359 RVA: 0x000B0664 File Offset: 0x000AF664
		// (set) Token: 0x06000168 RID: 360 RVA: 0x000B0678 File Offset: 0x000AF678
		public virtual Button btnAngledLines
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnAngledLines;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				if (this._btnAngledLines != null)
				{
					this._btnAngledLines.Click -= this.cmdAngledLines_Click;
				}
				this._btnAngledLines = value;
				if (this._btnAngledLines != null)
				{
					this._btnAngledLines.Click += this.cmdAngledLines_Click;
				}
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x06000169 RID: 361 RVA: 0x000B06CC File Offset: 0x000AF6CC
		// (set) Token: 0x0600016A RID: 362 RVA: 0x000B06E0 File Offset: 0x000AF6E0
		public virtual Button btnMeasuringLines
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnMeasuringLines;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				if (this._btnMeasuringLines != null)
				{
					this._btnMeasuringLines.Click -= this.cmdMeasuringLines_Click;
				}
				this._btnMeasuringLines = value;
				if (this._btnMeasuringLines != null)
				{
					this._btnMeasuringLines.Click += this.cmdMeasuringLines_Click;
				}
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x0600016B RID: 363 RVA: 0x000B0734 File Offset: 0x000AF734
		// (set) Token: 0x0600016C RID: 364 RVA: 0x000B0748 File Offset: 0x000AF748
		public virtual Button btnArrows
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnArrows;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				if (this._btnArrows != null)
				{
					this._btnArrows.Click -= this.cmdArrows_Click;
				}
				this._btnArrows = value;
				if (this._btnArrows != null)
				{
					this._btnArrows.Click += this.cmdArrows_Click;
				}
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x0600016D RID: 365 RVA: 0x000B079C File Offset: 0x000AF79C
		// (set) Token: 0x0600016E RID: 366 RVA: 0x000B07B0 File Offset: 0x000AF7B0
		public virtual Button btnRectangle
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnRectangle;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				if (this._btnRectangle != null)
				{
					this._btnRectangle.Click -= this.cmdRectangle_Click;
				}
				this._btnRectangle = value;
				if (this._btnRectangle != null)
				{
					this._btnRectangle.Click += this.cmdRectangle_Click;
				}
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x0600016F RID: 367 RVA: 0x000B0804 File Offset: 0x000AF804
		// (set) Token: 0x06000170 RID: 368 RVA: 0x000B0818 File Offset: 0x000AF818
		public virtual Button btnEllipse
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnEllipse;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				if (this._btnEllipse != null)
				{
					this._btnEllipse.Click -= this.cmdCircle_Click;
				}
				this._btnEllipse = value;
				if (this._btnEllipse != null)
				{
					this._btnEllipse.Click += this.cmdCircle_Click;
				}
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x06000171 RID: 369 RVA: 0x000B086C File Offset: 0x000AF86C
		// (set) Token: 0x06000172 RID: 370 RVA: 0x000B0880 File Offset: 0x000AF880
		public virtual Button btnArc
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnArc;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				if (this._btnArc != null)
				{
					this._btnArc.Click -= this.cmdArc_Click;
				}
				this._btnArc = value;
				if (this._btnArc != null)
				{
					this._btnArc.Click += this.cmdArc_Click;
				}
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x06000173 RID: 371 RVA: 0x000B08D4 File Offset: 0x000AF8D4
		// (set) Token: 0x06000174 RID: 372 RVA: 0x000B08E8 File Offset: 0x000AF8E8
		public virtual Button btnext
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnext;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				if (this._btnext != null)
				{
					this._btnext.Click -= this.cmdText_Click;
				}
				this._btnext = value;
				if (this._btnext != null)
				{
					this._btnext.Click += this.cmdText_Click;
				}
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x06000175 RID: 373 RVA: 0x000B093C File Offset: 0x000AF93C
		// (set) Token: 0x06000176 RID: 374 RVA: 0x000B0950 File Offset: 0x000AF950
		internal virtual TextBox txtDrawText
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtDrawText;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				if (this._txtDrawText != null)
				{
					this._txtDrawText.MouseUp -= this.txtDrawText_MouseUp;
					this._txtDrawText.Leave -= this.txtDrawText_Leave;
					this._txtDrawText.KeyDown -= this.txtDrawText_KeyDown;
				}
				this._txtDrawText = value;
				if (this._txtDrawText != null)
				{
					this._txtDrawText.MouseUp += this.txtDrawText_MouseUp;
					this._txtDrawText.Leave += this.txtDrawText_Leave;
					this._txtDrawText.KeyDown += this.txtDrawText_KeyDown;
				}
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x06000177 RID: 375 RVA: 0x000B0A04 File Offset: 0x000AFA04
		// (set) Token: 0x06000178 RID: 376 RVA: 0x000B0A18 File Offset: 0x000AFA18
		public virtual Button btnStamps
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnStamps;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				if (this._btnStamps != null)
				{
					this._btnStamps.Click -= this.cmdStamps_Click;
				}
				this._btnStamps = value;
				if (this._btnStamps != null)
				{
					this._btnStamps.Click += this.cmdStamps_Click;
				}
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x06000179 RID: 377 RVA: 0x000B0A6C File Offset: 0x000AFA6C
		// (set) Token: 0x0600017A RID: 378 RVA: 0x000B0A80 File Offset: 0x000AFA80
		public virtual Button btnSelect
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnSelect;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				if (this._btnSelect != null)
				{
					this._btnSelect.Click -= this.cmdSelect_Click;
				}
				this._btnSelect = value;
				if (this._btnSelect != null)
				{
					this._btnSelect.Click += this.cmdSelect_Click;
				}
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x0600017B RID: 379 RVA: 0x000B0AD4 File Offset: 0x000AFAD4
		// (set) Token: 0x0600017C RID: 380 RVA: 0x000B0AE8 File Offset: 0x000AFAE8
		public virtual Button btnDelete
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnDelete;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				if (this._btnDelete != null)
				{
					this._btnDelete.Click -= this.btnDelete_Click;
				}
				this._btnDelete = value;
				if (this._btnDelete != null)
				{
					this._btnDelete.Click += this.btnDelete_Click;
				}
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x0600017D RID: 381 RVA: 0x000B0B3C File Offset: 0x000AFB3C
		// (set) Token: 0x0600017E RID: 382 RVA: 0x000B0B50 File Offset: 0x000AFB50
		public virtual Button btnMove
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnMove;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				if (this._btnMove != null)
				{
					this._btnMove.Click -= this.btnMove_Click;
				}
				this._btnMove = value;
				if (this._btnMove != null)
				{
					this._btnMove.Click += this.btnMove_Click;
				}
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x0600017F RID: 383 RVA: 0x000B0BA4 File Offset: 0x000AFBA4
		// (set) Token: 0x06000180 RID: 384 RVA: 0x000B0BB8 File Offset: 0x000AFBB8
		public virtual Button btnRotate
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnRotate;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				if (this._btnRotate != null)
				{
					this._btnRotate.Click -= this.btnRotate_Click;
				}
				this._btnRotate = value;
				if (this._btnRotate != null)
				{
					this._btnRotate.Click += this.btnRotate_Click;
				}
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x06000181 RID: 385 RVA: 0x000B0C0C File Offset: 0x000AFC0C
		// (set) Token: 0x06000182 RID: 386 RVA: 0x000B0C20 File Offset: 0x000AFC20
		public virtual Button btnEraseScreen
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnEraseScreen;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				if (this._btnEraseScreen != null)
				{
					this._btnEraseScreen.Click -= this.btnEraseScreen_Click;
				}
				this._btnEraseScreen = value;
				if (this._btnEraseScreen != null)
				{
					this._btnEraseScreen.Click += this.btnEraseScreen_Click;
				}
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x06000183 RID: 387 RVA: 0x000B0C74 File Offset: 0x000AFC74
		// (set) Token: 0x06000184 RID: 388 RVA: 0x000B0C88 File Offset: 0x000AFC88
		public virtual Button btnSymbol
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnSymbol;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				if (this._btnSymbol != null)
				{
					this._btnSymbol.Click -= this.btnSymbol_Click;
				}
				this._btnSymbol = value;
				if (this._btnSymbol != null)
				{
					this._btnSymbol.Click += this.btnSymbol_Click;
				}
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x06000185 RID: 389 RVA: 0x000B0CDC File Offset: 0x000AFCDC
		// (set) Token: 0x06000186 RID: 390 RVA: 0x000B0CF0 File Offset: 0x000AFCF0
		public virtual Button btnNorthSymbol
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnNorthSymbol;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				if (this._btnNorthSymbol != null)
				{
					this._btnNorthSymbol.Click -= this.btnNorthSymbol_Click;
				}
				this._btnNorthSymbol = value;
				if (this._btnNorthSymbol != null)
				{
					this._btnNorthSymbol.Click += this.btnNorthSymbol_Click;
				}
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x06000187 RID: 391 RVA: 0x000B0D44 File Offset: 0x000AFD44
		// (set) Token: 0x06000188 RID: 392 RVA: 0x000B0D58 File Offset: 0x000AFD58
		public virtual Button btnGrid
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnGrid;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				if (this._btnGrid != null)
				{
					this._btnGrid.Click -= this.btnGrid_Click;
				}
				this._btnGrid = value;
				if (this._btnGrid != null)
				{
					this._btnGrid.Click += this.btnGrid_Click;
				}
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x06000189 RID: 393 RVA: 0x000B0DAC File Offset: 0x000AFDAC
		// (set) Token: 0x0600018A RID: 394 RVA: 0x000B0DC0 File Offset: 0x000AFDC0
		public virtual Button btnCopy
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnCopy;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btnCopy = value;
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x0600018B RID: 395 RVA: 0x000B0DCC File Offset: 0x000AFDCC
		// (set) Token: 0x0600018C RID: 396 RVA: 0x000B0DE0 File Offset: 0x000AFDE0
		public virtual Button btnPaste
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnPaste;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				if (this._btnPaste != null)
				{
					this._btnPaste.Click -= this.btnPaste_Click;
				}
				this._btnPaste = value;
				if (this._btnPaste != null)
				{
					this._btnPaste.Click += this.btnPaste_Click;
				}
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x0600018D RID: 397 RVA: 0x000B0E34 File Offset: 0x000AFE34
		// (set) Token: 0x0600018E RID: 398 RVA: 0x000B0E48 File Offset: 0x000AFE48
		public virtual Button btnUndo
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnUndo;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				if (this._btnUndo != null)
				{
					this._btnUndo.Click -= this.btnUndo_Click;
				}
				this._btnUndo = value;
				if (this._btnUndo != null)
				{
					this._btnUndo.Click += this.btnUndo_Click;
				}
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x0600018F RID: 399 RVA: 0x000B0E9C File Offset: 0x000AFE9C
		// (set) Token: 0x06000190 RID: 400 RVA: 0x000B0EB0 File Offset: 0x000AFEB0
		public virtual Button cmdInsertImage
		{
			[DebuggerNonUserCode]
			get
			{
				return this._cmdInsertImage;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				if (this._cmdInsertImage != null)
				{
					this._cmdInsertImage.Click -= this.cmdInsertImage_Click;
				}
				this._cmdInsertImage = value;
				if (this._cmdInsertImage != null)
				{
					this._cmdInsertImage.Click += this.cmdInsertImage_Click;
				}
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x06000191 RID: 401 RVA: 0x000B0F04 File Offset: 0x000AFF04
		// (set) Token: 0x06000192 RID: 402 RVA: 0x000B0F18 File Offset: 0x000AFF18
		public virtual GroupBox frSize
		{
			[DebuggerNonUserCode]
			get
			{
				return this._frSize;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._frSize = value;
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x06000193 RID: 403 RVA: 0x000B0F24 File Offset: 0x000AFF24
		// (set) Token: 0x06000194 RID: 404 RVA: 0x000B0F38 File Offset: 0x000AFF38
		public virtual Button btnSize2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnSize2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				if (this._btnSize2 != null)
				{
					this._btnSize2.Click -= this.btnSize2_Click;
				}
				this._btnSize2 = value;
				if (this._btnSize2 != null)
				{
					this._btnSize2.Click += this.btnSize2_Click;
				}
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x06000195 RID: 405 RVA: 0x000B0F8C File Offset: 0x000AFF8C
		// (set) Token: 0x06000196 RID: 406 RVA: 0x000B0FA0 File Offset: 0x000AFFA0
		public virtual Button btnSize4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnSize4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				if (this._btnSize4 != null)
				{
					this._btnSize4.Click -= this.btnSize4_Click;
				}
				this._btnSize4 = value;
				if (this._btnSize4 != null)
				{
					this._btnSize4.Click += this.btnSize4_Click;
				}
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x06000197 RID: 407 RVA: 0x000B0FF4 File Offset: 0x000AFFF4
		// (set) Token: 0x06000198 RID: 408 RVA: 0x000B1008 File Offset: 0x000B0008
		public virtual Button btnSize3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnSize3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				if (this._btnSize3 != null)
				{
					this._btnSize3.Click -= this.btnSize3_Click;
				}
				this._btnSize3 = value;
				if (this._btnSize3 != null)
				{
					this._btnSize3.Click += this.btnSize3_Click;
				}
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x06000199 RID: 409 RVA: 0x000B105C File Offset: 0x000B005C
		// (set) Token: 0x0600019A RID: 410 RVA: 0x000B1070 File Offset: 0x000B0070
		public virtual Button btnSize1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnSize1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				if (this._btnSize1 != null)
				{
					this._btnSize1.Click -= this.btnSize1_Click;
				}
				this._btnSize1 = value;
				if (this._btnSize1 != null)
				{
					this._btnSize1.Click += this.btnSize1_Click;
				}
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x0600019B RID: 411 RVA: 0x000B10C4 File Offset: 0x000B00C4
		// (set) Token: 0x0600019C RID: 412 RVA: 0x000B10D8 File Offset: 0x000B00D8
		public virtual GroupBox fraLineStyle
		{
			[DebuggerNonUserCode]
			get
			{
				return this._fraLineStyle;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._fraLineStyle = value;
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x0600019D RID: 413 RVA: 0x000B10E4 File Offset: 0x000B00E4
		// (set) Token: 0x0600019E RID: 414 RVA: 0x000B10F8 File Offset: 0x000B00F8
		public virtual Button btnSolid
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnSolid;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				if (this._btnSolid != null)
				{
					this._btnSolid.Click -= this.btnSolid_Click;
				}
				this._btnSolid = value;
				if (this._btnSolid != null)
				{
					this._btnSolid.Click += this.btnSolid_Click;
				}
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x0600019F RID: 415 RVA: 0x000B114C File Offset: 0x000B014C
		// (set) Token: 0x060001A0 RID: 416 RVA: 0x000B1160 File Offset: 0x000B0160
		public virtual Button btnDash
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnDash;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				if (this._btnDash != null)
				{
					this._btnDash.Click -= this.btnDash_Click;
				}
				this._btnDash = value;
				if (this._btnDash != null)
				{
					this._btnDash.Click += this.btnDash_Click;
				}
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x060001A1 RID: 417 RVA: 0x000B11B4 File Offset: 0x000B01B4
		// (set) Token: 0x060001A2 RID: 418 RVA: 0x000B11C8 File Offset: 0x000B01C8
		public virtual GroupBox frDirection
		{
			[DebuggerNonUserCode]
			get
			{
				return this._frDirection;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._frDirection = value;
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x060001A3 RID: 419 RVA: 0x000B11D4 File Offset: 0x000B01D4
		// (set) Token: 0x060001A4 RID: 420 RVA: 0x000B11E8 File Offset: 0x000B01E8
		public virtual Button btnDirectionNone
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnDirectionNone;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				if (this._btnDirectionNone != null)
				{
					this._btnDirectionNone.Click -= this.btnDirectionNone_Click;
				}
				this._btnDirectionNone = value;
				if (this._btnDirectionNone != null)
				{
					this._btnDirectionNone.Click += this.btnDirectionNone_Click;
				}
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x060001A5 RID: 421 RVA: 0x000B123C File Offset: 0x000B023C
		// (set) Token: 0x060001A6 RID: 422 RVA: 0x000B1250 File Offset: 0x000B0250
		public virtual Button btnDirectionNorth
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnDirectionNorth;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				if (this._btnDirectionNorth != null)
				{
					this._btnDirectionNorth.Click -= this.btnDirectionNorth_Click;
				}
				this._btnDirectionNorth = value;
				if (this._btnDirectionNorth != null)
				{
					this._btnDirectionNorth.Click += this.btnDirectionNorth_Click;
				}
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x060001A7 RID: 423 RVA: 0x000B12A4 File Offset: 0x000B02A4
		// (set) Token: 0x060001A8 RID: 424 RVA: 0x000B12B8 File Offset: 0x000B02B8
		public virtual Button btnDirectionEast
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnDirectionEast;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				if (this._btnDirectionEast != null)
				{
					this._btnDirectionEast.Click -= this.btnDirectionEast_Click;
				}
				this._btnDirectionEast = value;
				if (this._btnDirectionEast != null)
				{
					this._btnDirectionEast.Click += this.btnDirectionEast_Click;
				}
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x060001A9 RID: 425 RVA: 0x000B130C File Offset: 0x000B030C
		// (set) Token: 0x060001AA RID: 426 RVA: 0x000B1320 File Offset: 0x000B0320
		public virtual Button btnDirectionSouth
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnDirectionSouth;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				if (this._btnDirectionSouth != null)
				{
					this._btnDirectionSouth.Click -= this.btnDirectionSouth_Click;
				}
				this._btnDirectionSouth = value;
				if (this._btnDirectionSouth != null)
				{
					this._btnDirectionSouth.Click += this.btnDirectionSouth_Click;
				}
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x060001AB RID: 427 RVA: 0x000B1374 File Offset: 0x000B0374
		// (set) Token: 0x060001AC RID: 428 RVA: 0x000B1388 File Offset: 0x000B0388
		public virtual Button btnDirectionWest
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnDirectionWest;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				if (this._btnDirectionWest != null)
				{
					this._btnDirectionWest.Click -= this.btnDirectionWest_Click;
				}
				this._btnDirectionWest = value;
				if (this._btnDirectionWest != null)
				{
					this._btnDirectionWest.Click += this.btnDirectionWest_Click;
				}
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x060001AD RID: 429 RVA: 0x000B13DC File Offset: 0x000B03DC
		// (set) Token: 0x060001AE RID: 430 RVA: 0x000B13F0 File Offset: 0x000B03F0
		public virtual GroupBox frInsertableTextPhrases
		{
			[DebuggerNonUserCode]
			get
			{
				return this._frInsertableTextPhrases;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._frInsertableTextPhrases = value;
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x060001AF RID: 431 RVA: 0x000B13FC File Offset: 0x000B03FC
		// (set) Token: 0x060001B0 RID: 432 RVA: 0x000B1410 File Offset: 0x000B0410
		public virtual Button btnTextRE
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnTextRE;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				if (this._btnTextRE != null)
				{
					this._btnTextRE.Click -= this.btnTextRE_Click;
				}
				this._btnTextRE = value;
				if (this._btnTextRE != null)
				{
					this._btnTextRE.Click += this.btnTextRE_Click;
				}
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x060001B1 RID: 433 RVA: 0x000B1464 File Offset: 0x000B0464
		// (set) Token: 0x060001B2 RID: 434 RVA: 0x000B1478 File Offset: 0x000B0478
		public virtual Button btnTextDW
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnTextDW;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				if (this._btnTextDW != null)
				{
					this._btnTextDW.Click -= this.btnTextDW_Click;
				}
				this._btnTextDW = value;
				if (this._btnTextDW != null)
				{
					this._btnTextDW.Click += this.btnTextDW_Click;
				}
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x060001B3 RID: 435 RVA: 0x000B14CC File Offset: 0x000B04CC
		// (set) Token: 0x060001B4 RID: 436 RVA: 0x000B14E0 File Offset: 0x000B04E0
		public virtual Button btnTextBL
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnTextBL;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				if (this._btnTextBL != null)
				{
					this._btnTextBL.Click -= this.btnTextBL_Click;
				}
				this._btnTextBL = value;
				if (this._btnTextBL != null)
				{
					this._btnTextBL.Click += this.btnTextBL_Click;
				}
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x060001B5 RID: 437 RVA: 0x000B1534 File Offset: 0x000B0534
		// (set) Token: 0x060001B6 RID: 438 RVA: 0x000B1548 File Offset: 0x000B0548
		public virtual Button btnTextFL
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnTextFL;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				if (this._btnTextFL != null)
				{
					this._btnTextFL.Click -= this.btnTextFL_Click;
				}
				this._btnTextFL = value;
				if (this._btnTextFL != null)
				{
					this._btnTextFL.Click += this.btnTextFL_Click;
				}
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x060001B7 RID: 439 RVA: 0x000B159C File Offset: 0x000B059C
		// (set) Token: 0x060001B8 RID: 440 RVA: 0x000B15B0 File Offset: 0x000B05B0
		public virtual Button btnTextPL
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnTextPL;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				if (this._btnTextPL != null)
				{
					this._btnTextPL.Click -= this.btnTextPL_Click;
				}
				this._btnTextPL = value;
				if (this._btnTextPL != null)
				{
					this._btnTextPL.Click += this.btnTextPL_Click;
				}
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x060001B9 RID: 441 RVA: 0x000B1604 File Offset: 0x000B0604
		// (set) Token: 0x060001BA RID: 442 RVA: 0x000B1618 File Offset: 0x000B0618
		public virtual Button btnTextSW
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnTextSW;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				if (this._btnTextSW != null)
				{
					this._btnTextSW.Click -= this.btnTextSW_Click;
				}
				this._btnTextSW = value;
				if (this._btnTextSW != null)
				{
					this._btnTextSW.Click += this.btnTextSW_Click;
				}
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x060001BB RID: 443 RVA: 0x000B166C File Offset: 0x000B066C
		// (set) Token: 0x060001BC RID: 444 RVA: 0x000B1680 File Offset: 0x000B0680
		public virtual Button btnTextCL
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnTextCL;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				if (this._btnTextCL != null)
				{
					this._btnTextCL.Click -= this.btnTextCL_Click;
				}
				this._btnTextCL = value;
				if (this._btnTextCL != null)
				{
					this._btnTextCL.Click += this.btnTextCL_Click;
				}
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x060001BD RID: 445 RVA: 0x000B16D4 File Offset: 0x000B06D4
		// (set) Token: 0x060001BE RID: 446 RVA: 0x000B16E8 File Offset: 0x000B06E8
		public virtual Button btnTextLA
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnTextLA;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				if (this._btnTextLA != null)
				{
					this._btnTextLA.Click -= this.btnTextLA_Click;
				}
				this._btnTextLA = value;
				if (this._btnTextLA != null)
				{
					this._btnTextLA.Click += this.btnTextLA_Click;
				}
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x060001BF RID: 447 RVA: 0x000B173C File Offset: 0x000B073C
		// (set) Token: 0x060001C0 RID: 448 RVA: 0x000B1750 File Offset: 0x000B0750
		public virtual Button btnTextNone
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnTextNone;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				if (this._btnTextNone != null)
				{
					this._btnTextNone.Click -= this.btnTextNone_Click;
				}
				this._btnTextNone = value;
				if (this._btnTextNone != null)
				{
					this._btnTextNone.Click += this.btnTextNone_Click;
				}
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x060001C1 RID: 449 RVA: 0x000B17A4 File Offset: 0x000B07A4
		// (set) Token: 0x060001C2 RID: 450 RVA: 0x000B17B8 File Offset: 0x000B07B8
		public virtual GroupBox frListOfInsertableSymbols
		{
			[DebuggerNonUserCode]
			get
			{
				return this._frListOfInsertableSymbols;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._frListOfInsertableSymbols = value;
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x060001C3 RID: 451 RVA: 0x000B17C4 File Offset: 0x000B07C4
		// (set) Token: 0x060001C4 RID: 452 RVA: 0x000B17D8 File Offset: 0x000B07D8
		internal virtual ListBox LineTypes
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LineTypes;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				if (this._LineTypes != null)
				{
					this._LineTypes.SelectedIndexChanged -= this.LineTypes_SelectedIndexChanged;
				}
				this._LineTypes = value;
				if (this._LineTypes != null)
				{
					this._LineTypes.SelectedIndexChanged += this.LineTypes_SelectedIndexChanged;
				}
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x060001C5 RID: 453 RVA: 0x000B182C File Offset: 0x000B082C
		// (set) Token: 0x060001C6 RID: 454 RVA: 0x000B1840 File Offset: 0x000B0840
		internal virtual ToolTip ToolTip1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ToolTip1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolTip1 = value;
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x060001C7 RID: 455 RVA: 0x000B184C File Offset: 0x000B084C
		// (set) Token: 0x060001C8 RID: 456 RVA: 0x000B1860 File Offset: 0x000B0860
		public virtual Button btnResize
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnResize;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				if (this._btnResize != null)
				{
					this._btnResize.Click -= this.btnResize_Click;
				}
				this._btnResize = value;
				if (this._btnResize != null)
				{
					this._btnResize.Click += this.btnResize_Click;
				}
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x060001C9 RID: 457 RVA: 0x000B18B4 File Offset: 0x000B08B4
		// (set) Token: 0x060001CA RID: 458 RVA: 0x000B18C8 File Offset: 0x000B08C8
		internal virtual OpenFileDialog OpenFileDialog1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._OpenFileDialog1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._OpenFileDialog1 = value;
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x060001CB RID: 459 RVA: 0x000B18D4 File Offset: 0x000B08D4
		// (set) Token: 0x060001CC RID: 460 RVA: 0x000B18E8 File Offset: 0x000B08E8
		internal virtual GroupBox Tools
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Tools;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Tools = value;
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x060001CD RID: 461 RVA: 0x000B18F4 File Offset: 0x000B08F4
		// (set) Token: 0x060001CE RID: 462 RVA: 0x000B1908 File Offset: 0x000B0908
		internal virtual ToolStrip ToolStrip1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ToolStrip1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolStrip1 = value;
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x060001CF RID: 463 RVA: 0x000B1914 File Offset: 0x000B0914
		// (set) Token: 0x060001D0 RID: 464 RVA: 0x000B1928 File Offset: 0x000B0928
		internal virtual ToolStripDropDownButton ToolStripDropDownButton1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ToolStripDropDownButton1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolStripDropDownButton1 = value;
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x060001D1 RID: 465 RVA: 0x000B1934 File Offset: 0x000B0934
		// (set) Token: 0x060001D2 RID: 466 RVA: 0x000B1948 File Offset: 0x000B0948
		internal virtual ToolStripMenuItem btnFileOpen
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnFileOpen;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				if (this._btnFileOpen != null)
				{
					this._btnFileOpen.Click -= this.btnFileOpen_Click;
				}
				this._btnFileOpen = value;
				if (this._btnFileOpen != null)
				{
					this._btnFileOpen.Click += this.btnFileOpen_Click;
				}
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x060001D3 RID: 467 RVA: 0x000B199C File Offset: 0x000B099C
		// (set) Token: 0x060001D4 RID: 468 RVA: 0x000B19B0 File Offset: 0x000B09B0
		internal virtual ToolStripMenuItem btnFileSave
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnFileSave;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				if (this._btnFileSave != null)
				{
					this._btnFileSave.Click -= this.btnFileSave_Click;
				}
				this._btnFileSave = value;
				if (this._btnFileSave != null)
				{
					this._btnFileSave.Click += this.btnFileSave_Click;
				}
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x060001D5 RID: 469 RVA: 0x000B1A04 File Offset: 0x000B0A04
		// (set) Token: 0x060001D6 RID: 470 RVA: 0x000B1A18 File Offset: 0x000B0A18
		internal virtual ToolStripMenuItem btnFileSaveAs
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnFileSaveAs;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				if (this._btnFileSaveAs != null)
				{
					this._btnFileSaveAs.Click -= this.btnFileSaveAs_Click;
				}
				this._btnFileSaveAs = value;
				if (this._btnFileSaveAs != null)
				{
					this._btnFileSaveAs.Click += this.btnFileSaveAs_Click;
				}
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x060001D7 RID: 471 RVA: 0x000B1A6C File Offset: 0x000B0A6C
		// (set) Token: 0x060001D8 RID: 472 RVA: 0x000B1A80 File Offset: 0x000B0A80
		internal virtual ToolStripMenuItem CloseToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._CloseToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				if (this._CloseToolStripMenuItem != null)
				{
					this._CloseToolStripMenuItem.Click -= this.CloseToolStripMenuItem_Click_1;
				}
				this._CloseToolStripMenuItem = value;
				if (this._CloseToolStripMenuItem != null)
				{
					this._CloseToolStripMenuItem.Click += this.CloseToolStripMenuItem_Click_1;
				}
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x060001D9 RID: 473 RVA: 0x000B1AD4 File Offset: 0x000B0AD4
		// (set) Token: 0x060001DA RID: 474 RVA: 0x000B1AE8 File Offset: 0x000B0AE8
		internal virtual ToolStripLabel ToolStripLabel1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ToolStripLabel1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolStripLabel1 = value;
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x060001DB RID: 475 RVA: 0x000B1AF4 File Offset: 0x000B0AF4
		// (set) Token: 0x060001DC RID: 476 RVA: 0x000B1B08 File Offset: 0x000B0B08
		internal virtual ToolStripComboBox cbTemplates
		{
			[DebuggerNonUserCode]
			get
			{
				return this._cbTemplates;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._cbTemplates = value;
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x060001DD RID: 477 RVA: 0x000B1B14 File Offset: 0x000B0B14
		// (set) Token: 0x060001DE RID: 478 RVA: 0x000B1B28 File Offset: 0x000B0B28
		internal virtual ToolStripSeparator ToolStripSeparator1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ToolStripSeparator1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolStripSeparator1 = value;
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x060001DF RID: 479 RVA: 0x000B1B34 File Offset: 0x000B0B34
		// (set) Token: 0x060001E0 RID: 480 RVA: 0x000B1B48 File Offset: 0x000B0B48
		internal virtual ToolStripLabel ToolStripLabel2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ToolStripLabel2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolStripLabel2 = value;
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x060001E1 RID: 481 RVA: 0x000B1B54 File Offset: 0x000B0B54
		// (set) Token: 0x060001E2 RID: 482 RVA: 0x000B1B68 File Offset: 0x000B0B68
		internal virtual ToolStripTextBox txtTemplateName
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtTemplateName;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				if (this._txtTemplateName != null)
				{
					this._txtTemplateName.Enter -= this.txtTemplateName_Enter;
				}
				this._txtTemplateName = value;
				if (this._txtTemplateName != null)
				{
					this._txtTemplateName.Enter += this.txtTemplateName_Enter;
				}
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x060001E3 RID: 483 RVA: 0x000B1BBC File Offset: 0x000B0BBC
		// (set) Token: 0x060001E4 RID: 484 RVA: 0x000B1BD0 File Offset: 0x000B0BD0
		internal virtual ToolStripButton btnInsertTemplate
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnInsertTemplate;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				if (this._btnInsertTemplate != null)
				{
					this._btnInsertTemplate.Click -= this.btnInsertTemplate_Click;
				}
				this._btnInsertTemplate = value;
				if (this._btnInsertTemplate != null)
				{
					this._btnInsertTemplate.Click += this.btnInsertTemplate_Click;
				}
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x060001E5 RID: 485 RVA: 0x000B1C24 File Offset: 0x000B0C24
		// (set) Token: 0x060001E6 RID: 486 RVA: 0x000B1C38 File Offset: 0x000B0C38
		internal virtual ToolStripButton btnDeleteTemplate
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnDeleteTemplate;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				if (this._btnDeleteTemplate != null)
				{
					this._btnDeleteTemplate.Click -= this.btnDeleteTemplate_Click;
				}
				this._btnDeleteTemplate = value;
				if (this._btnDeleteTemplate != null)
				{
					this._btnDeleteTemplate.Click += this.btnDeleteTemplate_Click;
				}
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x060001E7 RID: 487 RVA: 0x000B1C8C File Offset: 0x000B0C8C
		// (set) Token: 0x060001E8 RID: 488 RVA: 0x000B1CA0 File Offset: 0x000B0CA0
		internal virtual ToolStripButton btnSaveTemplate
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnSaveTemplate;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				if (this._btnSaveTemplate != null)
				{
					this._btnSaveTemplate.Click -= this.btnSaveTemplate_Click;
				}
				this._btnSaveTemplate = value;
				if (this._btnSaveTemplate != null)
				{
					this._btnSaveTemplate.Click += this.btnSaveTemplate_Click;
				}
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x060001E9 RID: 489 RVA: 0x000B1CF4 File Offset: 0x000B0CF4
		// (set) Token: 0x060001EA RID: 490 RVA: 0x000B1D08 File Offset: 0x000B0D08
		internal virtual SaveFileDialog SaveFileDialog1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._SaveFileDialog1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._SaveFileDialog1 = value;
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x060001EB RID: 491 RVA: 0x000B1D14 File Offset: 0x000B0D14
		// (set) Token: 0x060001EC RID: 492 RVA: 0x000B1D28 File Offset: 0x000B0D28
		internal virtual ToolStripSeparator ToolStripSeparator2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ToolStripSeparator2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolStripSeparator2 = value;
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x060001ED RID: 493 RVA: 0x000B1D34 File Offset: 0x000B0D34
		// (set) Token: 0x060001EE RID: 494 RVA: 0x000B1D48 File Offset: 0x000B0D48
		internal virtual ToolStripSeparator ToolStripSeparator3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ToolStripSeparator3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolStripSeparator3 = value;
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x060001EF RID: 495 RVA: 0x000B1D54 File Offset: 0x000B0D54
		// (set) Token: 0x060001F0 RID: 496 RVA: 0x000B1D68 File Offset: 0x000B0D68
		internal virtual ToolStripSeparator ToolStripSeparator4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ToolStripSeparator4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolStripSeparator4 = value;
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x060001F1 RID: 497 RVA: 0x000B1D74 File Offset: 0x000B0D74
		// (set) Token: 0x060001F2 RID: 498 RVA: 0x000B1D88 File Offset: 0x000B0D88
		internal virtual ToolStripMenuItem ExitToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ExitToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				if (this._ExitToolStripMenuItem != null)
				{
					this._ExitToolStripMenuItem.Click -= this.ExitToolStripMenuItem_Click;
				}
				this._ExitToolStripMenuItem = value;
				if (this._ExitToolStripMenuItem != null)
				{
					this._ExitToolStripMenuItem.Click += this.ExitToolStripMenuItem_Click;
				}
			}
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x060001F3 RID: 499 RVA: 0x000B1DDC File Offset: 0x000B0DDC
		// (set) Token: 0x060001F4 RID: 500 RVA: 0x000B1DF0 File Offset: 0x000B0DF0
		internal virtual ToolStripSeparator ToolStripSeparator5
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ToolStripSeparator5;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolStripSeparator5 = value;
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x060001F5 RID: 501 RVA: 0x000B1DFC File Offset: 0x000B0DFC
		// (set) Token: 0x060001F6 RID: 502 RVA: 0x000B1E10 File Offset: 0x000B0E10
		internal virtual ToolStripMenuItem btnPrint
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnPrint;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				if (this._btnPrint != null)
				{
					this._btnPrint.Click -= this.btnPrint_Click;
				}
				this._btnPrint = value;
				if (this._btnPrint != null)
				{
					this._btnPrint.Click += this.btnPrint_Click;
				}
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x060001F7 RID: 503 RVA: 0x000B1E64 File Offset: 0x000B0E64
		// (set) Token: 0x060001F8 RID: 504 RVA: 0x000B1E78 File Offset: 0x000B0E78
		internal virtual PrintDialog PrintDialog1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PrintDialog1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PrintDialog1 = value;
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x060001F9 RID: 505 RVA: 0x000B1E84 File Offset: 0x000B0E84
		// (set) Token: 0x060001FA RID: 506 RVA: 0x000B1E98 File Offset: 0x000B0E98
		internal virtual PrintDocument PrintDocument1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PrintDocument1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				if (this._PrintDocument1 != null)
				{
					this._PrintDocument1.PrintPage -= this.PrintDocument1_PrintPage;
				}
				this._PrintDocument1 = value;
				if (this._PrintDocument1 != null)
				{
					this._PrintDocument1.PrintPage += this.PrintDocument1_PrintPage;
				}
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x060001FB RID: 507 RVA: 0x000B1EEC File Offset: 0x000B0EEC
		// (set) Token: 0x060001FC RID: 508 RVA: 0x000B1F00 File Offset: 0x000B0F00
		internal virtual ToolStripMenuItem ToolStripMenuItem1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ToolStripMenuItem1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				if (this._ToolStripMenuItem1 != null)
				{
					this._ToolStripMenuItem1.Click -= this.ToolStripMenuItem1_Click;
				}
				this._ToolStripMenuItem1 = value;
				if (this._ToolStripMenuItem1 != null)
				{
					this._ToolStripMenuItem1.Click += this.ToolStripMenuItem1_Click;
				}
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x060001FD RID: 509 RVA: 0x000B1F54 File Offset: 0x000B0F54
		// (set) Token: 0x060001FE RID: 510 RVA: 0x000B1F68 File Offset: 0x000B0F68
		internal virtual OpenFileDialog OpenFileDialog3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._OpenFileDialog3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._OpenFileDialog3 = value;
			}
		}

		// Token: 0x060001FF RID: 511 RVA: 0x000B1F74 File Offset: 0x000B0F74
		public static frmDrawing GetInstance()
		{
			if (frmDrawing.myInstance == null)
			{
				frmDrawing.myInstance = new frmDrawing();
			}
			return frmDrawing.myInstance;
		}

		// Token: 0x170000DB RID: 219
		// (set) Token: 0x06000200 RID: 512 RVA: 0x000B1F98 File Offset: 0x000B0F98
		public int SetDrawingType
		{
			set
			{
				this.drawingType = value;
			}
		}

		// Token: 0x170000DC RID: 220
		// (set) Token: 0x06000201 RID: 513 RVA: 0x000B1FA4 File Offset: 0x000B0FA4
		public double DrawingWidth
		{
			set
			{
				this.dDrawScreenWidth = checked((int)Math.Round(value));
			}
		}

		// Token: 0x170000DD RID: 221
		// (set) Token: 0x06000202 RID: 514 RVA: 0x000B1FB4 File Offset: 0x000B0FB4
		public double DrawingHeight
		{
			set
			{
				this.dDrawScreenHeight = checked((int)Math.Round(value));
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x06000203 RID: 515 RVA: 0x000B1FC4 File Offset: 0x000B0FC4
		public bool DrawingFinished
		{
			get
			{
				return this.bDrawingFinished;
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x06000204 RID: 516 RVA: 0x000B1FDC File Offset: 0x000B0FDC
		public bool DrawingStarted
		{
			get
			{
				return this.bDrawingStarted;
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x06000205 RID: 517 RVA: 0x000B1FF4 File Offset: 0x000B0FF4
		public bool DrawingDeleted
		{
			get
			{
				return this.bDrawingDeleted;
			}
		}

		// Token: 0x06000206 RID: 518 RVA: 0x000B200C File Offset: 0x000B100C
		public void Init()
		{
			try
			{
				GlobalVariables.UndoStack = new Stack();
				this.SetCanvasDimensions();
				GL.ClearColor(Color.White);
				this.SetupViewPort();
				GlobalVariables.Canvas = new DrawingSurface(this.GlControl1);
				GlobalVariables.Canvas.Grid = new Grid();
				GlobalVariables.Canvas.Grid.Visible = GlobalVariables.Canvas.GridOn;
				GlobalVariables.Canvas.Add(GlobalVariables.Canvas.Grid);
				this.btnEraseScreen_Click(this, null);
				this.PenWidth = 2;
				this.ShapeColour = Color.Black;
				this.SelectedLineStyle = GlobalVariables.LineStyle.Solid;
				this.LoadSymbolList();
				this.LoadTemplates();
				this.LineText = "NONE";
				this.SelectedText = string.Empty;
				this.DirectionText = string.Empty;
				this.SelectedLineStyle = GlobalVariables.LineStyle.Solid;
				this.PenWidth = 2;
				this.SelectedSymbol = "Hydrant";
				this.isActivelyDrawing = false;
				this.DisplayNoOptions();
				this.isMoving = false;
				this.DisplayDrawStraightLineOptions();
				GlobalVariables.userMode = GlobalVariables.DrawMode.DrawLines;
				this.Cursor = Cursors.Cross;
				this.Refresh();
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
			finally
			{
			}
		}

		// Token: 0x06000207 RID: 519 RVA: 0x000B2168 File Offset: 0x000B1168
		private void SetupViewPort()
		{
			try
			{
				int width = this.GlControl1.Width;
				int height = this.GlControl1.Height;
				GL.MatrixMode(MatrixMode.Projection);
				GL.LoadIdentity();
				GL.Ortho(0.0, (double)width, (double)height, 0.0, -100.0, 100.0);
				GL.Viewport(0, 0, width, height);
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x06000208 RID: 520 RVA: 0x000B21F8 File Offset: 0x000B11F8
		private Bitmap GrabScreenshot()
		{
			Bitmap result;
			try
			{
				if (!Information.IsNothing(GraphicsContext.CurrentContext))
				{
					Bitmap bitmap = new Bitmap(this.GlControl1.Width, this.GlControl1.Height);
					BitmapData bitmapData = bitmap.LockBits(this.GlControl1.ClientRectangle, ImageLockMode.WriteOnly, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
					GL.ReadPixels(0, 0, this.GlControl1.Width, this.GlControl1.Height, OpenTK.Graphics.OpenGL.PixelFormat.Bgr, PixelType.UnsignedByte, bitmapData.Scan0);
					bitmap.UnlockBits(bitmapData);
					bitmap.RotateFlip(RotateFlipType.Rotate180FlipX);
					result = bitmap;
				}
				else
				{
					result = null;
				}
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
				result = null;
			}
			return result;
		}

		// Token: 0x06000209 RID: 521 RVA: 0x000B22B0 File Offset: 0x000B12B0
		private void GlControl1_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			try
			{
				if (GlobalVariables.Canvas.SelectedShapes.Length != 1 | GlobalVariables.userMode != GlobalVariables.DrawMode.SelectTool)
				{
					this.InitDrawings((double)e.X, (double)e.Y);
				}
				else if (GlobalVariables.Canvas.SelectedShapes[0].ShapeType == GlobalVariables.ShapeType.Text)
				{
					this.pgfText = (Text)GlobalVariables.Canvas.SelectedShapes[0];
					string text = Interaction.InputBox("Please enter the replacement text:", "INPUT NEW TEXT", this.pgfText.Text, -1, -1);
					if (Operators.CompareString(text, string.Empty, false) != 0)
					{
						this.pgfText.Text = text;
					}
				}
				else if (GlobalVariables.Canvas.SelectedShapes[0].ShapeType == GlobalVariables.ShapeType.Rectangle)
				{
					GlobalVariables.userMode = GlobalVariables.DrawMode.Resize;
				}
				else if (GlobalVariables.Canvas.SelectedShapes[0].ShapeType == GlobalVariables.ShapeType.Stamp)
				{
					GlobalVariables.userMode = GlobalVariables.DrawMode.Resize;
				}
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x0600020A RID: 522 RVA: 0x000B23BC File Offset: 0x000B13BC
		private void GlControl1_MouseDown(object sender, MouseEventArgs e)
		{
			this.InitDrawings((double)e.X, (double)e.Y);
		}

		// Token: 0x0600020B RID: 523 RVA: 0x000B23D4 File Offset: 0x000B13D4
		private void GlControl1_MouseMove(object sender, MouseEventArgs e)
		{
			try
			{
				if (this.isActivelyDrawing)
				{
					if (GlobalVariables.userMode == GlobalVariables.DrawMode.DrawLines)
					{
						double num = (double)e.X;
						double num2 = (double)e.Y;
						this.DrawLine(ref num, ref num2);
					}
					else if (GlobalVariables.userMode == GlobalVariables.DrawMode.DrawRectangle)
					{
						double num2 = (double)e.X;
						double num = (double)e.Y;
						this.DrawRectangle(ref num2, ref num);
					}
					else if (GlobalVariables.userMode == GlobalVariables.DrawMode.DrawPencil)
					{
						double num2 = (double)e.X;
						double num = (double)e.Y;
						this.DrawPencil(ref num2, ref num);
					}
					else if (GlobalVariables.userMode == GlobalVariables.DrawMode.DrawAngledLines)
					{
						double num2 = (double)e.X;
						double num = (double)e.Y;
						this.DrawAngledLines(ref num2, ref num);
					}
					else if (GlobalVariables.userMode == GlobalVariables.DrawMode.DrawMeasureLines)
					{
						double num2 = (double)e.X;
						double num = (double)e.Y;
						this.DrawMeasureLine(ref num2, ref num);
					}
					else if (GlobalVariables.userMode == GlobalVariables.DrawMode.DrawArrow)
					{
						double num2 = (double)e.X;
						double num = (double)e.Y;
						this.DrawArrow(ref num2, ref num);
					}
					else if (GlobalVariables.userMode == GlobalVariables.DrawMode.DrawEllipse)
					{
						double num2 = (double)e.X;
						double num = (double)e.Y;
						this.DrawEllipse(ref num2, ref num);
					}
					else if (GlobalVariables.userMode == GlobalVariables.DrawMode.DrawArc)
					{
						double num2 = (double)e.X;
						double num = (double)e.Y;
						this.DrawArc(ref num2, ref num);
					}
					else if (GlobalVariables.userMode == GlobalVariables.DrawMode.DrawText)
					{
						this.DrawTextBox((double)e.X, (double)e.Y);
					}
					else if (GlobalVariables.userMode != GlobalVariables.DrawMode.InsertStamp)
					{
						if (GlobalVariables.userMode == GlobalVariables.DrawMode.SelectTool)
						{
							if (this.isMoving)
							{
								object obj = e.X;
								object obj2 = e.Y;
								this.DrawMove(ref obj, ref obj2);
							}
							else
							{
								double num2 = (double)e.X;
								double num = (double)e.Y;
								this.DrawSelect(ref num2, ref num);
							}
						}
						else if (GlobalVariables.userMode == GlobalVariables.DrawMode.Move)
						{
							object obj2 = e.X;
							object obj = e.Y;
							this.DrawMove(ref obj2, ref obj);
						}
						else if (GlobalVariables.userMode == GlobalVariables.DrawMode.DrawNorthSign)
						{
							double num2 = (double)e.X;
							double num = (double)e.Y;
							this.DrawNorthSign(ref num2, ref num);
						}
						else if (GlobalVariables.userMode == GlobalVariables.DrawMode.InsertSymbol)
						{
							double num2 = (double)e.X;
							double num = (double)e.Y;
							this.PositionInsertedSymbol(ref num2, ref num);
						}
						else if (GlobalVariables.userMode == GlobalVariables.DrawMode.Rotate)
						{
							double num2 = (double)e.X;
							double num = (double)e.Y;
							this.DrawRotate(ref num2, ref num);
						}
						else if (GlobalVariables.userMode == GlobalVariables.DrawMode.Resize)
						{
							object obj2 = e.X;
							object obj = e.Y;
							this.DrawResize(ref obj2, ref obj);
						}
					}
					GlobalVariables.Canvas.Draw((double)e.X, (double)e.Y);
				}
				else
				{
					GlobalVariables.Canvas.Draw((double)e.X, (double)e.Y);
				}
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x0600020C RID: 524 RVA: 0x000B26DC File Offset: 0x000B16DC
		private void GlControl1_MouseUp(object sender, MouseEventArgs e)
		{
			try
			{
				this.isActivelyDrawing = false;
				if (GlobalVariables.userMode == GlobalVariables.DrawMode.DrawLines)
				{
					double num = (double)e.X;
					double num2 = (double)e.Y;
					this.EndDrawLines(ref num, ref num2);
				}
				else if (GlobalVariables.userMode == GlobalVariables.DrawMode.DrawRectangle)
				{
					double num2 = (double)e.X;
					double num = (double)e.Y;
					this.EndDrawRectangle(ref num2, ref num);
				}
				else if (GlobalVariables.userMode == GlobalVariables.DrawMode.DrawPencil)
				{
					double num2 = (double)e.X;
					double num = (double)e.Y;
					this.EndDrawPencil(ref num2, ref num);
				}
				else if (GlobalVariables.userMode == GlobalVariables.DrawMode.DrawAngledLines)
				{
					double num2 = (double)e.X;
					double num = (double)e.Y;
					this.EndDrawAngledLines(ref num2, ref num);
				}
				else if (GlobalVariables.userMode == GlobalVariables.DrawMode.DrawMeasureLines)
				{
					double num2 = (double)e.X;
					double num = (double)e.Y;
					this.EndDrawMeasureLines(ref num2, ref num);
				}
				else if (GlobalVariables.userMode == GlobalVariables.DrawMode.DrawArrow)
				{
					double num2 = (double)e.X;
					double num = (double)e.Y;
					this.EndDrawArrow(ref num2, ref num);
				}
				else if (GlobalVariables.userMode == GlobalVariables.DrawMode.DrawEllipse)
				{
					double num2 = (double)e.X;
					double num = (double)e.Y;
					this.EndDrawEllipse(ref num2, ref num);
				}
				else if (GlobalVariables.userMode == GlobalVariables.DrawMode.DrawArc)
				{
					double num2 = (double)e.X;
					double num = (double)e.Y;
					this.EndDrawArc(ref num2, ref num);
				}
				else if (GlobalVariables.userMode == GlobalVariables.DrawMode.DrawText)
				{
					GlobalVariables.userMode = GlobalVariables.DrawMode.SelectTool;
					this.pgfText.SelectThis();
					this.txtDrawText.Focus();
				}
				else if (GlobalVariables.userMode == GlobalVariables.DrawMode.SelectTool)
				{
					if (this.isMoving)
					{
						double num2 = (double)e.X;
						double num = (double)e.Y;
						this.EndMove(ref num2, ref num);
					}
					else
					{
						double num2 = (double)e.X;
						double num = (double)e.Y;
						this.EndDrawSelected(ref num2, ref num);
					}
				}
				else if (GlobalVariables.userMode == GlobalVariables.DrawMode.Move)
				{
					double num2 = (double)e.X;
					double num = (double)e.Y;
					this.EndMove(ref num2, ref num);
				}
				else if (GlobalVariables.userMode == GlobalVariables.DrawMode.DrawNorthSign)
				{
					double num2 = (double)e.X;
					double num = (double)e.Y;
					this.EndDrawNorthSign(ref num2, ref num);
				}
				else if (GlobalVariables.userMode == GlobalVariables.DrawMode.DrawSymbol | GlobalVariables.userMode == GlobalVariables.DrawMode.InsertSymbol)
				{
					this.EndSymbol();
				}
				else if (GlobalVariables.userMode == GlobalVariables.DrawMode.Rotate)
				{
					double num2 = (double)e.X;
					double num = (double)e.Y;
					this.EndRotate(ref num2, ref num);
				}
				else if (GlobalVariables.userMode == GlobalVariables.DrawMode.InsertStamp)
				{
					double num2 = (double)e.X;
					double num = (double)e.Y;
					this.EndInsertedStamp(ref num2, ref num);
				}
				else if (GlobalVariables.userMode == GlobalVariables.DrawMode.Resize)
				{
					double num2 = (double)e.X;
					double num = (double)e.Y;
					this.EndResize(ref num2, ref num);
				}
				if (this.isResizing)
				{
					GlobalVariables.userMode = GlobalVariables.DrawMode.SelectTool;
					this.btnMove_Click(this.btnMove, new EventArgs());
					this.isResizing = false;
				}
				GlobalVariables.SavableChanges = true;
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x0600020D RID: 525 RVA: 0x000B29DC File Offset: 0x000B19DC
		private bool InitDrawings(double X, double Y)
		{
			bool result;
			try
			{
				if (this.isActivelyDrawing)
				{
					result = true;
				}
				else
				{
					this.isResizing = false;
					this.isActivelyDrawing = true;
					this.isMoving = false;
					if (GlobalVariables.userMode == GlobalVariables.DrawMode.DrawLines | GlobalVariables.userMode == GlobalVariables.DrawMode.DrawPencil | GlobalVariables.userMode == GlobalVariables.DrawMode.DrawAngledLines)
					{
						this.InitDrawAnyLineType(ref X, ref Y);
					}
					else if (GlobalVariables.userMode == GlobalVariables.DrawMode.SelectTool)
					{
						this.InitSelect(ref X, ref Y);
					}
					else if (GlobalVariables.userMode == GlobalVariables.DrawMode.DrawRectangle)
					{
						this.InitDrawRectangle(ref X, ref Y);
					}
					else if (GlobalVariables.userMode == GlobalVariables.DrawMode.DrawMeasureLines)
					{
						this.InitDrawMeasureLine(ref X, ref Y);
					}
					else if (GlobalVariables.userMode == GlobalVariables.DrawMode.DrawArrow)
					{
						this.InitDrawArrow(ref X, ref Y);
					}
					else if (GlobalVariables.userMode == GlobalVariables.DrawMode.DrawEllipse)
					{
						this.InitDrawCircle(ref X, ref Y);
					}
					else if (GlobalVariables.userMode == GlobalVariables.DrawMode.DrawArc)
					{
						this.InitDrawArc(ref X, ref Y);
					}
					else if (GlobalVariables.userMode == GlobalVariables.DrawMode.DrawText)
					{
						this.InitDrawText(ref X, ref Y);
					}
					else if (GlobalVariables.userMode == GlobalVariables.DrawMode.InsertStamp)
					{
						this.InitInsertStamp(ref X, ref Y);
					}
					else if (GlobalVariables.userMode == GlobalVariables.DrawMode.Move)
					{
						this.InitMove(ref X, ref Y);
					}
					else if (GlobalVariables.userMode == GlobalVariables.DrawMode.Rotate)
					{
						if (GlobalVariables.Canvas.SelectedShapes.Length > 0)
						{
							this.InitRotate(ref X, ref Y);
						}
						else
						{
							Interaction.MsgBox("The rotate function rotates selected objects on the drawing, but there are currently no selected objects.  Please select what you would like to rotate and try again. ", MsgBoxStyle.Information, "NO SELECTED OBJECTS");
							this.isActivelyDrawing = false;
						}
					}
					else if (GlobalVariables.userMode == GlobalVariables.DrawMode.DrawNorthSign)
					{
						this.InitDrawNorthSign(ref X, ref Y);
					}
					else if (GlobalVariables.userMode == GlobalVariables.DrawMode.InsertSymbol)
					{
						this.InitDrawSymbol(ref X, ref Y);
					}
					else if (GlobalVariables.userMode == GlobalVariables.DrawMode.Resize)
					{
						this.InitResize(ref X, ref Y);
					}
				}
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
			return result;
		}

		// Token: 0x0600020E RID: 526 RVA: 0x000B2BBC File Offset: 0x000B1BBC
		private void InitDrawArrow(ref double X, ref double Y)
		{
			checked
			{
				try
				{
					GlobalVariables.Canvas.DeselectAll();
					this.pgfGroup = new ShapeGroup();
					this.pgfTriangle = new Triangle();
					Triangle triangle = this.pgfTriangle;
					Point p = new Point(Conversions.ToInteger(Operators.SubtractObject(X, Operators.DivideObject(GlobalVariables.TriangleSize, 2))), (int)Math.Round(unchecked(Y + Math.Sqrt(75.0))));
					triangle.AddVertices(p);
					Triangle triangle2 = this.pgfTriangle;
					p = new Point((int)Math.Round(X), (int)Math.Round(Y));
					triangle2.AddVertices(p);
					Triangle triangle3 = this.pgfTriangle;
					p = new Point(Conversions.ToInteger(Operators.AddObject(X, Operators.DivideObject(GlobalVariables.TriangleSize, 2))), (int)Math.Round(unchecked(Y + Math.Sqrt(75.0))));
					triangle3.AddVertices(p);
					this.pgfLine = new Line();
					this.pgfGroup.Add(this.pgfTriangle);
					this.pgfGroup.Add(this.pgfLine);
					Line line = this.pgfLine;
					p = new Point((int)Math.Round(X), (int)Math.Round(unchecked(Y + Math.Sqrt(Conversions.ToDouble(Operators.SubtractObject(Operators.MultiplyObject(GlobalVariables.TriangleSize, GlobalVariables.TriangleSize), Operators.DivideObject(Operators.MultiplyObject(Operators.DivideObject(GlobalVariables.TriangleSize, 2), GlobalVariables.TriangleSize), 2)))))));
					line.AddVertices(p);
					Line line2 = this.pgfLine;
					p = new Point((int)Math.Round(X), (int)Math.Round(unchecked(Y + Math.Sqrt(Conversions.ToDouble(Operators.SubtractObject(Operators.MultiplyObject(GlobalVariables.TriangleSize, GlobalVariables.TriangleSize), Operators.DivideObject(Operators.MultiplyObject(Operators.DivideObject(GlobalVariables.TriangleSize, 2), GlobalVariables.TriangleSize), 2)))))));
					line2.AddVertices(p);
					if (Operators.CompareString(this.SelectedText, string.Empty, false) != 0)
					{
						this.pgfText = new Text();
						Text text = this.pgfText;
						p = new Point((int)Math.Round(X), (int)Math.Round(Y));
						text.Location = p;
						this.pgfText.Text = this.DirectionText + this.SelectedText;
						GlobalVariables.Canvas.Add(this.pgfText);
					}
					this.pgfGroup.Thickness = this.PenWidth;
					this.pgfGroup.Colour = this.ShapeColour;
					GlobalVariables.Canvas.Add(this.pgfGroup);
				}
				catch (Exception ex)
				{
					ComPetersError.DisplayError(ex);
				}
			}
		}

		// Token: 0x0600020F RID: 527 RVA: 0x000B2E90 File Offset: 0x000B1E90
		private void InitDrawRectangle(ref double X, ref double Y)
		{
			checked
			{
				try
				{
					GlobalVariables.Canvas.DeselectAll();
					this.pgfRect = new Rectangle();
					Rectangle rectangle = this.pgfRect;
					Point p = new Point((int)Math.Round(X), (int)Math.Round(Y));
					rectangle.AddVertices(p);
					Rectangle rectangle2 = this.pgfRect;
					p = new Point((int)Math.Round(X), (int)Math.Round(Y));
					rectangle2.AddVertices(p);
					Rectangle rectangle3 = this.pgfRect;
					p = new Point((int)Math.Round(X), (int)Math.Round(Y));
					rectangle3.AddVertices(p);
					Rectangle rectangle4 = this.pgfRect;
					p = new Point((int)Math.Round(X), (int)Math.Round(Y));
					rectangle4.AddVertices(p);
					this.pgfRect.Thickness = this.PenWidth;
					this.pgfRect.Colour = this.ShapeColour;
					this.pgfRect.LineStyle = this.SelectedLineStyle;
					GlobalVariables.Canvas.Add(this.pgfRect);
				}
				catch (Exception ex)
				{
					ComPetersError.DisplayError(ex);
				}
			}
		}

		// Token: 0x06000210 RID: 528 RVA: 0x000B2FBC File Offset: 0x000B1FBC
		private void InitDrawAnyLineType(ref double X, ref double Y)
		{
			checked
			{
				try
				{
					GlobalVariables.Canvas.DeselectAll();
					this.pgfLine = new Line();
					this.pgfLine.Thickness = this.PenWidth;
					this.pgfLine.Colour = this.ShapeColour;
					this.pgfLine.LineStyle = this.SelectedLineStyle;
					GlobalVariables.Canvas.Add(this.pgfLine);
					Line line = this.pgfLine;
					Point p = new Point((int)Math.Round(X), (int)Math.Round(Y));
					line.AddVertices(p);
					Line line2 = this.pgfLine;
					p = new Point((int)Math.Round(X), (int)Math.Round(Y));
					line2.AddVertices(p);
				}
				catch (Exception ex)
				{
					ComPetersError.DisplayError(ex);
				}
			}
		}

		// Token: 0x06000211 RID: 529 RVA: 0x000B3098 File Offset: 0x000B2098
		private void InitDrawMeasureLine(ref double X, ref double Y)
		{
			checked
			{
				try
				{
					GlobalVariables.Canvas.DeselectAll();
					this.pgfGroup = new ShapeGroup();
					this.pgfGroup2 = new ShapeGroup();
					this.pgfTriangle1 = new Triangle();
					this.pgftriangle2 = new Triangle();
					this.pgfGroup.Add(this.pgfTriangle1);
					this.pgfGroup2.Add(this.pgftriangle2);
					Triangle triangle = this.pgfTriangle1;
					Point p = new Point(Conversions.ToInteger(Operators.SubtractObject(X, Operators.DivideObject(GlobalVariables.TriangleSize, 2))), (int)Math.Round(unchecked(Y - Math.Sqrt(Conversions.ToDouble(Operators.SubtractObject(Operators.MultiplyObject(GlobalVariables.TriangleSize, GlobalVariables.TriangleSize), Operators.DivideObject(Operators.MultiplyObject(Operators.DivideObject(GlobalVariables.TriangleSize, 2), GlobalVariables.TriangleSize), 2)))))));
					triangle.AddVertices(p);
					Triangle triangle2 = this.pgfTriangle1;
					p = new Point((int)Math.Round(X), (int)Math.Round(Y));
					triangle2.AddVertices(p);
					Triangle triangle3 = this.pgfTriangle1;
					p = new Point(Conversions.ToInteger(Operators.AddObject(X, Operators.DivideObject(GlobalVariables.TriangleSize, 2))), (int)Math.Round(unchecked(Y - Math.Sqrt(Conversions.ToDouble(Operators.SubtractObject(Operators.MultiplyObject(GlobalVariables.TriangleSize, GlobalVariables.TriangleSize), Operators.DivideObject(Operators.MultiplyObject(Operators.DivideObject(GlobalVariables.TriangleSize, 2), GlobalVariables.TriangleSize), 2)))))));
					triangle3.AddVertices(p);
					Triangle triangle4 = this.pgftriangle2;
					p = new Point(Conversions.ToInteger(Operators.SubtractObject(X, Operators.DivideObject(GlobalVariables.TriangleSize, 2))), (int)Math.Round(unchecked(Y + Math.Sqrt(Conversions.ToDouble(Operators.SubtractObject(Operators.MultiplyObject(GlobalVariables.TriangleSize, GlobalVariables.TriangleSize), Operators.DivideObject(Operators.MultiplyObject(Operators.DivideObject(GlobalVariables.TriangleSize, 2), GlobalVariables.TriangleSize), 2)))))));
					triangle4.AddVertices(p);
					Triangle triangle5 = this.pgftriangle2;
					p = new Point((int)Math.Round(X), (int)Math.Round(Y));
					triangle5.AddVertices(p);
					Triangle triangle6 = this.pgftriangle2;
					p = new Point(Conversions.ToInteger(Operators.AddObject(X, Operators.DivideObject(GlobalVariables.TriangleSize, 2))), (int)Math.Round(unchecked(Y + Math.Sqrt(Conversions.ToDouble(Operators.SubtractObject(Operators.MultiplyObject(GlobalVariables.TriangleSize, GlobalVariables.TriangleSize), Operators.DivideObject(Operators.MultiplyObject(Operators.DivideObject(GlobalVariables.TriangleSize, 2), GlobalVariables.TriangleSize), 2)))))));
					triangle6.AddVertices(p);
					this.pgfMeasureLine1 = new Line();
					this.pgfMeasureLine2 = new Line();
					this.pgfGroup.Add(this.pgfMeasureLine1);
					this.pgfGroup2.Add(this.pgfMeasureLine2);
					Line line = this.pgfMeasureLine1;
					p = new Point((int)Math.Round(X), (int)Math.Round(unchecked(Y - Math.Sqrt(Conversions.ToDouble(Operators.SubtractObject(Operators.MultiplyObject(GlobalVariables.TriangleSize, GlobalVariables.TriangleSize), Operators.DivideObject(Operators.MultiplyObject(Operators.DivideObject(GlobalVariables.TriangleSize, 2), GlobalVariables.TriangleSize), 2)))))));
					line.AddVertices(p);
					Line line2 = this.pgfMeasureLine1;
					p = new Point((int)Math.Round(X), (int)Math.Round(unchecked(Y - 50.0)));
					line2.AddVertices(p);
					Line line3 = this.pgfMeasureLine2;
					p = new Point((int)Math.Round(X), (int)Math.Round(unchecked(Y + Math.Sqrt(Conversions.ToDouble(Operators.SubtractObject(Operators.MultiplyObject(GlobalVariables.TriangleSize, GlobalVariables.TriangleSize), Operators.DivideObject(Operators.MultiplyObject(Operators.DivideObject(GlobalVariables.TriangleSize, 2), GlobalVariables.TriangleSize), 2)))))));
					line3.AddVertices(p);
					Line line4 = this.pgfMeasureLine2;
					p = new Point((int)Math.Round(X), (int)Math.Round(unchecked(Y + 50.0)));
					line4.AddVertices(p);
					this.pgfGroup.Thickness = this.PenWidth;
					this.pgfGroup.Colour = this.ShapeColour;
					this.pgfGroup2.Thickness = this.PenWidth;
					this.pgfGroup2.Colour = this.ShapeColour;
					GlobalVariables.Canvas.Add(this.pgfGroup);
					GlobalVariables.Canvas.Add(this.pgfGroup2);
				}
				catch (Exception ex)
				{
					ComPetersError.DisplayError(ex);
				}
			}
		}

		// Token: 0x06000212 RID: 530 RVA: 0x000B356C File Offset: 0x000B256C
		private void InitDrawCircle(ref double X, ref double Y)
		{
			try
			{
				GlobalVariables.Canvas.DeselectAll();
				this.pgfEllipse = new Ellipse();
				GlobalVariables.Canvas.Add(this.pgfEllipse);
				Ellipse ellipse = this.pgfEllipse;
				Point p = checked(new Point((int)Math.Round(X), (int)Math.Round(Y)));
				ellipse.Center = p;
				this.pgfEllipse.Thickness = this.PenWidth;
				this.pgfEllipse.Colour = this.ShapeColour;
				this.pgfEllipse.LineStyle = this.SelectedLineStyle;
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x06000213 RID: 531 RVA: 0x000B3620 File Offset: 0x000B2620
		private void InitDrawArc(ref double X, ref double Y)
		{
			checked
			{
				try
				{
					GlobalVariables.Canvas.DeselectAll();
					this.pgfRect = new Rectangle();
					Rectangle rectangle = this.pgfRect;
					Point p = new Point((int)Math.Round(X), (int)Math.Round(Y));
					rectangle.AddVertices(p);
					Rectangle rectangle2 = this.pgfRect;
					p = new Point((int)Math.Round(X), (int)Math.Round(Y));
					rectangle2.AddVertices(p);
					Rectangle rectangle3 = this.pgfRect;
					p = new Point((int)Math.Round(X), (int)Math.Round(Y));
					rectangle3.AddVertices(p);
					Rectangle rectangle4 = this.pgfRect;
					p = new Point((int)Math.Round(X), (int)Math.Round(Y));
					rectangle4.AddVertices(p);
					GlobalVariables.Canvas.Add(this.pgfRect);
					this.pgfArc = new Arc();
					this.pgfArc.Thickness = this.PenWidth;
					this.pgfArc.Colour = this.ShapeColour;
					this.pgfArc.LineStyle = this.SelectedLineStyle;
					GlobalVariables.Canvas.Add(this.pgfArc);
				}
				catch (Exception ex)
				{
					ComPetersError.DisplayError(ex);
				}
			}
		}

		// Token: 0x06000214 RID: 532 RVA: 0x000B3774 File Offset: 0x000B2774
		private void InitDrawText(ref double X, ref double Y)
		{
			try
			{
				GlobalVariables.Canvas.DeselectAll();
				this.pgfText = new Text();
				Text text = this.pgfText;
				Point p = checked(new Point((int)Math.Round(X), (int)Math.Round(Y)));
				text.Location = p;
				this.pgfText.Thickness = this.PenWidth;
				this.pgfText.Colour = this.ShapeColour;
				PointF location = this.pgfText.Location;
				Size size = new Size(100, 100);
				this.DrawTextBox(location, size);
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x06000215 RID: 533 RVA: 0x000B3824 File Offset: 0x000B2824
		private void InitInsertStamp(ref double X, ref double Y)
		{
			try
			{
				GlobalVariables.Canvas.DeselectAll();
				this.pgfStamp = new Stamp();
				Stamp stamp = this.pgfStamp;
				Point p = checked(new Point((int)Math.Round(X), (int)Math.Round(Y)));
				stamp.Location = p;
				this.pgfStamp.ImageFile = this.OpenFileDialog1.FileName;
				GlobalVariables.Canvas.Add(this.pgfStamp);
				GlobalVariables.Canvas.Draw(X, Y);
				Undo undo = new Undo();
				undo.AddShape(this.pgfStamp);
				undo.operationType = GlobalVariables.DrawMode.DrawLines;
				GlobalVariables.UndoStack.Push(undo);
				this.pgfStamp.SelectThis();
				this.pgfStamp = null;
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x06000216 RID: 534 RVA: 0x000B3900 File Offset: 0x000B2900
		private void InitSelect(ref double X, ref double Y)
		{
			checked
			{
				try
				{
					this.pgfRect = new Rectangle();
					Rectangle rectangle = this.pgfRect;
					Point p = new Point((int)Math.Round(X), (int)Math.Round(Y));
					rectangle.AddVertices(p);
					Rectangle rectangle2 = this.pgfRect;
					p = new Point((int)Math.Round(X), (int)Math.Round(Y));
					rectangle2.AddVertices(p);
					Rectangle rectangle3 = this.pgfRect;
					p = new Point((int)Math.Round(X), (int)Math.Round(Y));
					rectangle3.AddVertices(p);
					Rectangle rectangle4 = this.pgfRect;
					p = new Point((int)Math.Round(X), (int)Math.Round(Y));
					rectangle4.AddVertices(p);
					this.pgfRect.canSelect = false;
					GlobalVariables.Canvas.Add(this.pgfRect);
					DrawingSurface canvas = GlobalVariables.Canvas;
					PointF pixel = new PointF((float)X, (float)Y);
					this.pgfShape = canvas.SelectShapeWithPixel(pixel);
					if (this.pgfShape != null)
					{
						if (!Information.IsNothing(this.pgfRect))
						{
							GlobalVariables.Canvas.Remove(this.pgfRect);
						}
						if (!this.pgfShape.isSelected)
						{
							this.pgfShape.SelectThis();
						}
						this.isMoving = true;
						this.InitMove(ref X, ref Y);
					}
					else
					{
						GlobalVariables.Canvas.DeselectAll();
					}
				}
				catch (Exception ex)
				{
					ComPetersError.DisplayError(ex);
				}
			}
		}

		// Token: 0x06000217 RID: 535 RVA: 0x000B3A7C File Offset: 0x000B2A7C
		private void InitMove(ref double X, ref double Y)
		{
			try
			{
				Point p = checked(new Point((int)Math.Round(X), (int)Math.Round(Y)));
				this.BeginMove = p;
				Undo undo = new Undo();
				undo.operationType = GlobalVariables.DrawMode.Move;
				undo.oldX = X;
				undo.oldY = Y;
				GlobalVariables.UndoStack.Push(undo);
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x06000218 RID: 536 RVA: 0x000B3AFC File Offset: 0x000B2AFC
		private void InitRotate(ref double X, ref double Y)
		{
			try
			{
				double num = (double)GlobalVariables.Canvas.Width;
				double num2 = (double)GlobalVariables.Canvas.Height;
				this.pgfGroup = new ShapeGroup();
				foreach (IShape shape in GlobalVariables.Canvas.SelectedShapes)
				{
					this.pgfGroup.Add(shape);
				}
				this.pgfRotatePositionLine = new Line();
				this.pgfRotatePositionLine.LineStyle = GlobalVariables.LineStyle.Dashed;
				this.pgfRotatePositionLine.Thickness = 1;
				this.pgfRotatePositionLine.Colour = Color.Gray;
				this.pgfRotatePositionLine.canSelect = false;
				double num3 = (double)((this.pgfGroup.BoundingRectangle.Vertices[0].X + this.pgfGroup.BoundingRectangle.Vertices[2].X) / 2f);
				double num4 = (double)((this.pgfGroup.BoundingRectangle.Vertices[0].Y + this.pgfGroup.BoundingRectangle.Vertices[2].Y) / 2f);
				Line line = this.pgfRotatePositionLine;
				checked
				{
					Point p = new Point((int)Math.Round(num3), (int)Math.Round(num4));
					line.AddVertices(p);
					Line line2 = this.pgfRotatePositionLine;
					p = new Point((int)Math.Round(X), (int)Math.Round(Y));
					line2.AddVertices(p);
					this.InitialRotateAngle = this.CalcLineAngleFromHorizon(ref this.pgfRotatePositionLine);
					Undo undo = new Undo();
					foreach (IShape shape2 in GlobalVariables.Canvas.SelectedShapes)
					{
						undo.AddShape(shape2);
					}
					GlobalVariables.Canvas.Add(this.pgfRotatePositionLine);
					undo.oldAngle = this.InitialRotateAngle;
					undo.RotateCentreX = num3;
					undo.RotateCentreY = num4;
					undo.operationType = GlobalVariables.DrawMode.Rotate;
					GlobalVariables.UndoStack.Push(undo);
				}
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x06000219 RID: 537 RVA: 0x000B3D48 File Offset: 0x000B2D48
		private void InitDrawNorthSign(ref double X, ref double Y)
		{
			checked
			{
				try
				{
					GlobalVariables.Canvas.DeselectAll();
					this.pgfGroup = new ShapeGroup();
					this.pgfLine = new Line();
					this.pgfLine2 = new Line();
					this.pgfLine3 = new Line();
					Line line = this.pgfLine;
					Point p = new Point((int)Math.Round(X), (int)Math.Round(Y));
					line.AddVertices(p);
					Line line2 = this.pgfLine;
					p = new Point((int)Math.Round(X), (int)Math.Round(Y));
					line2.AddVertices(p);
					Line line3 = this.pgfLine2;
					p = new Point((int)Math.Round(X), (int)Math.Round(Y));
					line3.AddVertices(p);
					Line line4 = this.pgfLine2;
					p = new Point((int)Math.Round(X), (int)Math.Round(Y));
					line4.AddVertices(p);
					Line line5 = this.pgfLine3;
					p = new Point((int)Math.Round(X), (int)Math.Round(Y));
					line5.AddVertices(p);
					Line line6 = this.pgfLine3;
					p = new Point((int)Math.Round(X), (int)Math.Round(Y));
					line6.AddVertices(p);
					this.pgfText = new Text();
					this.pgfText.Text = "N";
					Text text = this.pgfText;
					p = new Point((int)Math.Round(X), (int)Math.Round(Y));
					text.Location = p;
					this.pgfGroup.Add(this.pgfText);
					this.pgfGroup.Add(this.pgfLine);
					this.pgfGroup.Add(this.pgfLine2);
					this.pgfGroup.Add(this.pgfLine3);
					this.pgfGroup.Thickness = 2;
					this.pgfGroup.Colour = Color.Black;
					GlobalVariables.Canvas.Add(this.pgfGroup);
				}
				catch (Exception ex)
				{
					ComPetersError.DisplayError(ex);
				}
			}
		}

		// Token: 0x0600021A RID: 538 RVA: 0x000B3F60 File Offset: 0x000B2F60
		private void InitDrawSymbol(ref double X, ref double Y)
		{
			try
			{
				GlobalVariables.Canvas.DeselectAll();
				if (Operators.CompareString(this.SelectedSymbol, "Pedestal", false) == 0)
				{
					this.DrawSymbol_Pedestal(ref X, ref Y);
				}
				else if (Operators.CompareString(this.SelectedSymbol, "CatchBasin", false) == 0)
				{
					this.DrawSymbol_CatchBasin(ref X, ref Y);
				}
				else if (Operators.CompareString(this.SelectedSymbol, "CentreLine", false) == 0)
				{
					this.DrawSymbol_CentreLine(ref X, ref Y);
				}
				else if (Operators.CompareString(this.SelectedSymbol, "Manhole", false) == 0)
				{
					this.DrawSymbol_ManHole(ref X, ref Y);
				}
				else if (Operators.CompareString(this.SelectedSymbol, "Hydrant", false) == 0)
				{
					this.DrawSymbol_Hydrant(ref X, ref Y);
				}
				else if (Operators.CompareString(this.SelectedSymbol, "GasValve", false) == 0)
				{
					this.DrawSymbol_GasValve(ref X, ref Y);
				}
				else if (Operators.CompareString(this.SelectedSymbol, "Transformer", false) == 0)
				{
					this.DrawSymbol_Transformer(ref X, ref Y);
				}
				else if (Operators.CompareString(this.SelectedSymbol, "Pole", false) == 0)
				{
					this.DrawSymbol_Pole(ref X, ref Y);
				}
				else if (Operators.CompareString(this.SelectedSymbol, "WaterValve", false) == 0)
				{
					this.DrawSymbol_WaterValve(ref X, ref Y);
				}
				else if (Operators.CompareString(this.SelectedSymbol, "HandWell", false) == 0)
				{
					this.DrawSymbol_HandWell(ref X, ref Y);
				}
				else if (Operators.CompareString(this.SelectedSymbol, "WaterChamber", false) == 0)
				{
					this.DrawSymbol_WaterChamber(ref X, ref Y);
				}
				else if (Operators.CompareString(this.SelectedSymbol, "Demarcation", false) == 0)
				{
					this.DrawSymbol_Demarcation(ref X, ref Y);
				}
				this.BeginMove.X = (float)X;
				this.BeginMove.Y = (float)Y;
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x0600021B RID: 539 RVA: 0x000B4144 File Offset: 0x000B3144
		private void InitResize(ref double X, ref double Y)
		{
			try
			{
				Point p = checked(new Point((int)Math.Round(X), (int)Math.Round(Y)));
				this.BeginMove = p;
				Undo undo = new Undo();
				undo.operationType = GlobalVariables.DrawMode.Move;
				undo.oldX = X;
				undo.oldY = Y;
				GlobalVariables.UndoStack.Push(undo);
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x0600021C RID: 540 RVA: 0x000B41C4 File Offset: 0x000B31C4
		private double CalcLineAngleFromHorizon(ref Line line)
		{
			double result;
			try
			{
				float num = line.Vertices[1].X - line.Vertices[0].X;
				float num2 = line.Vertices[1].Y - line.Vertices[0].Y;
				double num3;
				if (num != 0f)
				{
					if (num > 0f & num2 <= 0f)
					{
						num3 = -Math.Atan((double)(num2 / num));
					}
					else if (num < 0f & num2 <= 0f)
					{
						num3 = 3.141592653589793 - Math.Atan((double)(num2 / num));
					}
					else if (num < 0f & num2 > 0f)
					{
						num3 = 3.141592653589793 - Math.Atan((double)(num2 / num));
					}
					else if (num > 0f & num2 > 0f)
					{
						num3 = 6.283185307179586 - Math.Atan((double)(num2 / num));
					}
				}
				else if (num2 <= 0f)
				{
					num3 = 1.5707963267948966;
				}
				else
				{
					num3 = 4.71238898038469;
				}
				result = num3;
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
				result = 0.0;
			}
			return result;
		}

		// Token: 0x0600021D RID: 541 RVA: 0x000B432C File Offset: 0x000B332C
		private void DrawTextBox(PointF Location, Size Size)
		{
			try
			{
				Point location = checked(new Point((int)Math.Round((double)Location.X), (int)Math.Round((double)Location.Y)));
				this.txtDrawText.Location = location;
				this.txtDrawText.Size = Size;
				this.txtDrawText.Visible = true;
				this.GlControl1.Controls.Add(this.txtDrawText);
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x0600021E RID: 542 RVA: 0x000B43BC File Offset: 0x000B33BC
		private void DrawTextBox(double x, double y)
		{
			try
			{
				Control txtDrawText = this.txtDrawText;
				Size size = checked(new Size((int)Math.Round(unchecked(x - (double)this.txtDrawText.Location.X)), (int)Math.Round(unchecked(y - (double)this.txtDrawText.Location.Y))));
				txtDrawText.Size = size;
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x0600021F RID: 543 RVA: 0x000B443C File Offset: 0x000B343C
		private void PositionInsertedSymbol(ref double X, ref double Y)
		{
			object value = X;
			object value2 = Y;
			this.DrawMove(ref value, ref value2);
			Y = Conversions.ToDouble(value2);
			X = Conversions.ToDouble(value);
		}

		// Token: 0x06000220 RID: 544 RVA: 0x000B4474 File Offset: 0x000B3474
		private void DrawLine(ref double X, ref double Y)
		{
			try
			{
				this.pgfLine.Vertices[1].X = (float)X;
				this.pgfLine.Vertices[1].Y = (float)Y;
				GlobalVariables.Canvas.Draw(X, Y);
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x06000221 RID: 545 RVA: 0x000B44E8 File Offset: 0x000B34E8
		private void DrawAngledLines(ref double X, ref double Y)
		{
			try
			{
				double num = (double)this.pgfLine.Vertices[0].X;
				double num2 = (double)this.pgfLine.Vertices[0].Y;
				double num3 = (double)this.pgfLine.Vertices[0].X;
				double num4 = (double)this.pgfLine.Vertices[0].Y;
				if (Math.Abs(num - X) > Math.Abs(num2 - Y))
				{
					num3 = X;
				}
				else
				{
					num4 = Y;
				}
				this.pgfLine.Vertices[1].X = (float)num3;
				this.pgfLine.Vertices[1].Y = (float)num4;
				GlobalVariables.Canvas.Draw(X, Y);
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x06000222 RID: 546 RVA: 0x000B45D8 File Offset: 0x000B35D8
		private void DrawPencil(ref double X, ref double Y)
		{
			try
			{
				Line line = this.pgfLine;
				Point p = checked(new Point((int)Math.Round(X), (int)Math.Round(Y)));
				line.AddVertices(p);
				GlobalVariables.Canvas.Draw(X, Y);
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x06000223 RID: 547 RVA: 0x000B4644 File Offset: 0x000B3644
		private void DrawRectangle(ref double X, ref double Y)
		{
			checked
			{
				try
				{
					PointF[] vertices = this.pgfRect.Vertices;
					int num = 2;
					Point p = new Point((int)Math.Round(X), (int)Math.Round(Y));
					vertices[num] = p;
					PointF[] vertices2 = this.pgfRect.Vertices;
					int num2 = 1;
					p = new Point((int)Math.Round(X), (int)Math.Round((double)this.pgfRect.Vertices[0].Y));
					vertices2[num2] = p;
					PointF[] vertices3 = this.pgfRect.Vertices;
					int num3 = 3;
					p = new Point((int)Math.Round((double)this.pgfRect.Vertices[0].X), (int)Math.Round(Y));
					vertices3[num3] = p;
					GlobalVariables.Canvas.Draw(X, Y);
				}
				catch (Exception ex)
				{
					ComPetersError.DisplayError(ex);
				}
			}
		}

		// Token: 0x06000224 RID: 548 RVA: 0x000B4748 File Offset: 0x000B3748
		private void DrawArrow(ref double X, ref double Y)
		{
			try
			{
				float num = (float)(X - (double)this.pgfLine.Vertices[0].X);
				float num2 = (float)(Y - (double)this.pgfLine.Vertices[0].Y);
				float num3 = (float)Math.Sqrt((double)(num * num + num2 * num2));
				if (num3 != 0f)
				{
					double num4;
					if (num2 != 0f)
					{
						object obj = Math.Asin((double)(num / num3));
						if (num2 < 0f & num > 0f)
						{
							num4 = Conversions.ToDouble(Operators.SubtractObject(3.141592653589793, obj));
						}
						else if (num2 < 0f & num <= 0f)
						{
							num4 = Conversions.ToDouble(Operators.SubtractObject(6.283185307179586, Operators.AddObject(3.141592653589793, obj)));
						}
						else if (num2 > 0f & num < 0f)
						{
							num4 = Conversions.ToDouble(Operators.AddObject(6.283185307179586, obj));
						}
						else if (num2 > 0f & num > 0f)
						{
							num4 = Conversions.ToDouble(obj);
						}
					}
					else if (num >= 0f)
					{
						num4 = 1.5707963267948966;
					}
					else
					{
						num4 = 4.71238898038469;
					}
					this.pgfLine.Vertices[0].X = (float)((double)this.pgfTriangle.Vertices[1].X + (double)(num / num3) * Math.Sqrt(Conversions.ToDouble(Operators.SubtractObject(Operators.MultiplyObject(GlobalVariables.TriangleSize, GlobalVariables.TriangleSize), Operators.DivideObject(Operators.MultiplyObject(Operators.DivideObject(GlobalVariables.TriangleSize, 2), GlobalVariables.TriangleSize), 2)))));
					this.pgfLine.Vertices[0].Y = (float)((double)this.pgfTriangle.Vertices[1].Y + (double)(num2 / num3) * Math.Sqrt(Conversions.ToDouble(Operators.SubtractObject(Operators.MultiplyObject(GlobalVariables.TriangleSize, GlobalVariables.TriangleSize), Operators.DivideObject(Operators.MultiplyObject(Operators.DivideObject(GlobalVariables.TriangleSize, 2), GlobalVariables.TriangleSize), 2)))));
					this.pgfLine.Vertices[1].X = (float)X;
					this.pgfLine.Vertices[1].Y = (float)Y;
					this.pgfTriangle.Move(this.pgfTriangle.Vertices[1]);
					this.pgfTriangle.Rotate(-num4 + 3.141592653589793);
					GlobalVariables.Canvas.Draw(X, Y);
					checked
					{
						if (Operators.CompareString(this.SelectedText, string.Empty, false) != 0 & num3 != 0f)
						{
							int x;
							if (unchecked(X + (double)(num / num3) * this.pgfText.Width) > 0.0)
							{
								if (Math.Sign(num) < 0)
								{
									x = (int)Math.Round(unchecked(X + (double)(num / num3) * (this.pgfText.Width + 5.0)));
								}
								else
								{
									x = (int)Math.Round(X);
								}
							}
							else
							{
								x = (int)Math.Round(X);
							}
							int y;
							if (unchecked(Y + (double)(num2 / num3) * this.pgfText.Width) > 0.0)
							{
								if (Math.Sign(num2) < 0)
								{
									y = (int)Math.Round(unchecked(Y + (double)(num2 / num3) * (this.pgfText.Height + 5.0)));
								}
								else
								{
									y = (int)Math.Round(Y);
								}
							}
							else
							{
								y = (int)Math.Round(Y);
							}
							this.pgfText.Thickness = this.PenWidth;
							Text text = this.pgfText;
							Point p = new Point(x, y);
							text.Location = p;
						}
					}
				}
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x06000225 RID: 549 RVA: 0x000B4B6C File Offset: 0x000B3B6C
		private void DrawMeasureLine(ref double X, ref double Y)
		{
			try
			{
				float num = (float)(X - (double)this.pgfMeasureLine1.Vertices[0].X);
				float num2 = (float)(Y - (double)this.pgfMeasureLine1.Vertices[0].Y);
				float num3 = (float)Math.Sqrt((double)(num * num + num2 * num2));
				if (num3 != 0f)
				{
					double num4;
					if (num2 != 0f)
					{
						object obj = Math.Asin((double)(num / num3));
						if (num2 < 0f & num > 0f)
						{
							num4 = Conversions.ToDouble(Operators.SubtractObject(3.141592653589793, obj));
						}
						else if (num2 < 0f & num <= 0f)
						{
							num4 = Conversions.ToDouble(Operators.SubtractObject(6.283185307179586, Operators.AddObject(3.141592653589793, obj)));
						}
						else if (num2 > 0f & num < 0f)
						{
							num4 = Conversions.ToDouble(Operators.AddObject(6.283185307179586, obj));
						}
						else if (num2 > 0f & num > 0f)
						{
							num4 = Conversions.ToDouble(obj);
						}
					}
					else if (num >= 0f)
					{
						num4 = 1.5707963267948966;
					}
					else
					{
						num4 = 4.71238898038469;
					}
					this.pgfTriangle1.Move(this.pgfTriangle1.Vertices[1]);
					Triangle triangle = this.pgftriangle2;
					Point p = checked(new Point((int)Math.Round(X), (int)Math.Round(Y)));
					triangle.Move(p);
					this.pgfTriangle1.Rotate(-num4);
					this.pgftriangle2.Rotate(-num4 + 3.141592653589793);
					this.pgfMeasureLine1.Vertices[0].X = (float)((double)this.pgfTriangle1.Vertices[1].X - (double)(num / num3) * Math.Sqrt(Conversions.ToDouble(Operators.SubtractObject(Operators.MultiplyObject(GlobalVariables.TriangleSize, GlobalVariables.TriangleSize), Operators.DivideObject(Operators.MultiplyObject(Operators.DivideObject(GlobalVariables.TriangleSize, 2), GlobalVariables.TriangleSize), 2)))));
					this.pgfMeasureLine1.Vertices[0].Y = (float)((double)this.pgfTriangle1.Vertices[1].Y - (double)(num2 / num3) * Math.Sqrt(Conversions.ToDouble(Operators.SubtractObject(Operators.MultiplyObject(GlobalVariables.TriangleSize, GlobalVariables.TriangleSize), Operators.DivideObject(Operators.MultiplyObject(Operators.DivideObject(GlobalVariables.TriangleSize, 2), GlobalVariables.TriangleSize), 2)))));
					this.pgfMeasureLine1.Vertices[1].X = (float)((double)this.pgfMeasureLine1.Vertices[0].X - (double)(num / num3) * 50.0);
					this.pgfMeasureLine1.Vertices[1].Y = (float)((double)this.pgfMeasureLine1.Vertices[0].Y - (double)(num2 / num3) * 50.0);
					this.pgfMeasureLine2.Vertices[0].X = (float)(X + (double)(num / num3) * Math.Sqrt(Conversions.ToDouble(Operators.SubtractObject(Operators.MultiplyObject(GlobalVariables.TriangleSize, GlobalVariables.TriangleSize), Operators.DivideObject(Operators.MultiplyObject(Operators.DivideObject(GlobalVariables.TriangleSize, 2), GlobalVariables.TriangleSize), 2)))));
					this.pgfMeasureLine2.Vertices[0].Y = (float)(Y + (double)(num2 / num3) * Math.Sqrt(Conversions.ToDouble(Operators.SubtractObject(Operators.MultiplyObject(GlobalVariables.TriangleSize, GlobalVariables.TriangleSize), Operators.DivideObject(Operators.MultiplyObject(Operators.DivideObject(GlobalVariables.TriangleSize, 2), GlobalVariables.TriangleSize), 2)))));
					this.pgfMeasureLine2.Vertices[1].X = (float)(X + (double)(num / num3) * 50.0);
					this.pgfMeasureLine2.Vertices[1].Y = (float)(Y + (double)(num2 / num3) * 50.0);
					GlobalVariables.Canvas.Draw(X, Y);
				}
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x06000226 RID: 550 RVA: 0x000B4FF8 File Offset: 0x000B3FF8
		private void DrawEllipse(ref double X, ref double Y)
		{
			checked
			{
				try
				{
					this.pgfEllipse.Width = (int)Math.Round(unchecked(X - (double)this.pgfEllipse.Center.X));
					this.pgfEllipse.Height = (int)Math.Round(unchecked(Y - (double)this.pgfEllipse.Center.Y));
					GlobalVariables.Canvas.Draw(X, Y);
				}
				catch (Exception ex)
				{
					ComPetersError.DisplayError(ex);
				}
			}
		}

		// Token: 0x06000227 RID: 551 RVA: 0x000B508C File Offset: 0x000B408C
		private void DrawArc(ref double X, ref double Y)
		{
			try
			{
				this.DrawRectangle(ref X, ref Y);
				double width = this.pgfRect.width;
				double height = this.pgfRect.height;
				this.pgfArc.CreateArc(this.pgfRect);
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x06000228 RID: 552 RVA: 0x000B50F0 File Offset: 0x000B40F0
		private void DrawText(ref string sText)
		{
			try
			{
				if (Operators.CompareString(sText, string.Empty, false) != 0)
				{
					this.pgfText.Text = sText;
					this.pgfText.Thickness = this.PenWidth;
					GlobalVariables.Canvas.Add(this.pgfText);
					this.pgfText.SelectThis();
					GlobalVariables.Canvas.Draw();
					this.isActivelyDrawing = false;
					Undo undo = new Undo();
					undo.AddShape(this.pgfText);
					undo.operationType = GlobalVariables.DrawMode.DrawText;
					GlobalVariables.UndoStack.Push(undo);
				}
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x06000229 RID: 553 RVA: 0x000B51A8 File Offset: 0x000B41A8
		private void DrawSelect(ref double X, ref double Y)
		{
			checked
			{
				try
				{
					PointF[] vertices = this.pgfRect.Vertices;
					int num = 2;
					Point p = new Point((int)Math.Round(X), (int)Math.Round(Y));
					vertices[num] = p;
					PointF[] vertices2 = this.pgfRect.Vertices;
					int num2 = 1;
					p = new Point((int)Math.Round(X), (int)Math.Round((double)this.pgfRect.Vertices[0].Y));
					vertices2[num2] = p;
					PointF[] vertices3 = this.pgfRect.Vertices;
					int num3 = 3;
					p = new Point((int)Math.Round((double)this.pgfRect.Vertices[0].X), (int)Math.Round(Y));
					vertices3[num3] = p;
					GlobalVariables.Canvas.Draw(X, Y);
				}
				catch (Exception ex)
				{
					ComPetersError.DisplayError(ex);
				}
			}
		}

		// Token: 0x0600022A RID: 554 RVA: 0x000B52AC File Offset: 0x000B42AC
		private void DrawMove(ref object X, ref object Y)
		{
			try
			{
				GlobalVariables.Canvas.MoveSelected(Conversions.ToInteger(Operators.SubtractObject(X, this.BeginMove.X)), Conversions.ToInteger(Operators.SubtractObject(Y, this.BeginMove.Y)));
				GlobalVariables.Canvas.Draw(Conversions.ToDouble(X), Conversions.ToDouble(Y));
				this.BeginMove.X = Conversions.ToSingle(X);
				this.BeginMove.Y = Conversions.ToSingle(Y);
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x0600022B RID: 555 RVA: 0x000B5360 File Offset: 0x000B4360
		private void DrawRotate(ref double X, ref double Y)
		{
			try
			{
				this.pgfRotatePositionLine.Vertices[1].X = (float)X;
				this.pgfRotatePositionLine.Vertices[1].Y = (float)Y;
				double num = this.CalcLineAngleFromHorizon(ref this.pgfRotatePositionLine);
				foreach (IShape shape in GlobalVariables.Canvas.SelectedShapes)
				{
					IShape shape2 = shape;
					double radians = this.InitialRotateAngle - num;
					PointF pivot = new PointF(this.pgfRotatePositionLine.Vertices[0].X, this.pgfRotatePositionLine.Vertices[0].Y);
					shape2.Rotate(radians, pivot);
				}
				this.InitialRotateAngle = num;
				Undo undo = (Undo)GlobalVariables.UndoStack.Pop();
				undo.newAngle = this.InitialRotateAngle;
				GlobalVariables.UndoStack.Push(undo);
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x0600022C RID: 556 RVA: 0x000B5468 File Offset: 0x000B4468
		private void DrawNorthSign(ref double X, ref double Y)
		{
			try
			{
				double num = 0.5;
				this.DrawLine(ref X, ref Y);
				float num2 = this.pgfLine.Vertices[1].X - this.pgfLine.Vertices[0].X;
				float num3 = this.pgfLine.Vertices[1].Y - this.pgfLine.Vertices[0].Y;
				float num4 = (float)Math.Sqrt((double)(num2 * num2 + num3 * num3));
				this.pgfLine2.Vertices[1].X = (float)X;
				this.pgfLine2.Vertices[1].Y = (float)Y;
				this.pgfLine3.Vertices[1].X = (float)X;
				this.pgfLine3.Vertices[1].Y = (float)Y;
				this.pgfLine2.Vertices[0].X = (float)(X - (double)num2 * num);
				this.pgfLine2.Vertices[0].Y = (float)(Y - (double)num3 * num);
				if (num4 != 0f)
				{
					if (num2 != 0f)
					{
						double num5 = Math.Atan((double)(num3 / num2));
						float num6;
						float num7;
						if (num2 > 0f)
						{
							num6 = (float)((double)this.pgfLine2.Vertices[0].Y + (double)num4 * Math.Cos(num5) * num * Math.Sin(0.2617993877991494));
							num7 = (float)((double)this.pgfLine2.Vertices[0].X - (double)num4 * Math.Sin(num5) * num * Math.Sin(0.2617993877991494));
						}
						else if (num2 < 0f)
						{
							num6 = (float)((double)this.pgfLine2.Vertices[0].Y - (double)num4 * Math.Cos(num5) * num * Math.Sin(0.2617993877991494));
							num7 = (float)((double)this.pgfLine2.Vertices[0].X + (double)num4 * Math.Sin(num5) * num * Math.Sin(0.2617993877991494));
						}
						PointF[] vertices = this.pgfLine3.Vertices;
						int num8 = 0;
						checked
						{
							Point p = new Point((int)Math.Round((double)num7), (int)Math.Round((double)num6));
							vertices[num8] = p;
							PointF[] vertices2 = this.pgfLine2.Vertices;
							int num9 = 1;
							p = new Point((int)Math.Round((double)num7), (int)Math.Round((double)num6));
							vertices2[num9] = p;
						}
					}
					else
					{
						float num6;
						float num7;
						if (num3 < 0f)
						{
							num6 = (float)((double)this.pgfLine2.Vertices[1].Y + (double)num4 * num);
							num7 = (float)((double)this.pgfLine2.Vertices[1].X + Math.Sin(0.2617993877991494) * (double)num4 * num);
						}
						else
						{
							num6 = (float)((double)this.pgfLine2.Vertices[1].Y - (double)num4 * num);
							num7 = (float)((double)this.pgfLine2.Vertices[1].X - Math.Sin(0.2617993877991494) * (double)num4 * num);
						}
						PointF[] vertices3 = this.pgfLine3.Vertices;
						int num10 = 0;
						checked
						{
							Point p = new Point((int)Math.Round((double)num7), (int)Math.Round((double)num6));
							vertices3[num10] = p;
							PointF[] vertices4 = this.pgfLine2.Vertices;
							int num11 = 1;
							p = new Point((int)Math.Round((double)num7), (int)Math.Round((double)num6));
							vertices4[num11] = p;
						}
					}
				}
				checked
				{
					if (num4 != 0f)
					{
						Point p2 = default(Point);
						if (Math.Sign(num2) < 0)
						{
							p2.X = (int)Math.Round(unchecked(X + (double)(num2 / num4 * 30f)));
						}
						else
						{
							p2.X = (int)Math.Round(X);
						}
						if (Math.Sign(num3) < 0)
						{
							p2.Y = (int)Math.Round(unchecked(Y + (double)(num3 / num4 * 30f)));
						}
						else
						{
							p2.Y = (int)Math.Round(Y);
						}
						this.pgfText.Location = p2;
					}
					GlobalVariables.Canvas.Draw(X, Y);
				}
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x0600022D RID: 557 RVA: 0x000B58F8 File Offset: 0x000B48F8
		private void DrawResize(ref object X, ref object Y)
		{
			try
			{
				GlobalVariables.Canvas.ResizeSelected(Conversions.ToInteger(Operators.SubtractObject(X, this.BeginMove.X)), Conversions.ToInteger(Operators.SubtractObject(Y, this.BeginMove.Y)));
				GlobalVariables.Canvas.Draw(Conversions.ToDouble(X), Conversions.ToDouble(Y));
				this.BeginMove.X = Conversions.ToSingle(X);
				this.BeginMove.Y = Conversions.ToSingle(Y);
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x0600022E RID: 558 RVA: 0x000B59AC File Offset: 0x000B49AC
		private void DrawSymbol_CatchBasin(ref double X, ref double Y)
		{
			double num = 20.0;
			double num2 = 10.0;
			this.pgfRect = new Rectangle();
			Rectangle rectangle = this.pgfRect;
			PointF pointF = new PointF((float)X, (float)Y);
			rectangle.AddVertices(pointF);
			Rectangle rectangle2 = this.pgfRect;
			pointF = new PointF((float)(X + num), (float)Y);
			rectangle2.AddVertices(pointF);
			Rectangle rectangle3 = this.pgfRect;
			pointF = new PointF((float)(X + num), (float)(Y + num2));
			rectangle3.AddVertices(pointF);
			Rectangle rectangle4 = this.pgfRect;
			pointF = new PointF((float)X, (float)(Y + num2));
			rectangle4.AddVertices(pointF);
			this.pgfRect.Thickness = 2;
			this.pgfRect.FinishCreation();
			this.pgfLine = new Line();
			Line line = this.pgfLine;
			pointF = new PointF((float)X, (float)(Y + num2 / 2.0));
			line.AddVertices(pointF);
			Line line2 = this.pgfLine;
			pointF = new PointF((float)(X + num), (float)(Y + num2 / 2.0));
			line2.AddVertices(pointF);
			this.pgfText = new Text();
			Text text = this.pgfText;
			pointF = new PointF((float)(X + 1.1 * num), (float)Y);
			text.Location = pointF;
			this.pgfText.Text = "CB";
			this.pgfGroup = new ShapeGroup();
			this.pgfGroup.Add(this.pgfText);
			this.pgfGroup.Add(this.pgfLine);
			this.pgfGroup.Add(this.pgfRect);
			this.pgfGroup.Thickness = 2;
			GlobalVariables.Canvas.Add(this.pgfGroup);
			GlobalVariables.Canvas.Draw(X, Y);
			this.pgfGroup.SelectThis();
		}

		// Token: 0x0600022F RID: 559 RVA: 0x000B5B68 File Offset: 0x000B4B68
		private void DrawSymbol_CentreLine(ref double X, ref double Y)
		{
			this.pgfText = new Text();
			Text text = this.pgfText;
			PointF pointF = new PointF((float)X, (float)Y);
			text.Location = pointF;
			this.pgfText.Text = "C";
			this.pgfText.Thickness = 2;
			this.pgfLine = new Line();
			this.pgfLine.LineStyle = GlobalVariables.LineStyle.Solid;
			this.pgfLine.Thickness = 2;
			this.pgfLine.Colour = Color.Black;
			Line line = this.pgfLine;
			pointF = new PointF((float)(X + this.pgfText.Width / 2.0), (float)Y);
			line.AddVertices(pointF);
			Line line2 = this.pgfLine;
			pointF = new PointF((float)(X + this.pgfText.Width / 2.0), (float)(Y + this.pgfText.Height));
			line2.AddVertices(pointF);
			Line line3 = this.pgfLine;
			pointF = new PointF((float)(X + this.pgfText.Width), (float)(Y + this.pgfText.Height));
			line3.AddVertices(pointF);
			this.pgfGroup = new ShapeGroup();
			this.pgfGroup.Add(this.pgfText);
			this.pgfGroup.Add(this.pgfLine);
			GlobalVariables.Canvas.Add(this.pgfGroup);
			GlobalVariables.Canvas.Draw(X, Y);
			this.pgfGroup.SelectThis();
		}

		// Token: 0x06000230 RID: 560 RVA: 0x000B5CDC File Offset: 0x000B4CDC
		private void DrawSymbol_Pedestal(ref double X, ref double Y)
		{
			this.pgfGroup = new ShapeGroup();
			double num = 15.0;
			double num2 = 15.0;
			this.pgfRect = new Rectangle();
			Rectangle rectangle = this.pgfRect;
			PointF vertex = new PointF((float)X, (float)Y);
			rectangle.AddVertices(vertex);
			Rectangle rectangle2 = this.pgfRect;
			vertex = new PointF((float)(X + num), (float)Y);
			rectangle2.AddVertices(vertex);
			Rectangle rectangle3 = this.pgfRect;
			vertex = new PointF((float)(X + num), (float)(Y + num2));
			rectangle3.AddVertices(vertex);
			Rectangle rectangle4 = this.pgfRect;
			vertex = new PointF((float)X, (float)(Y + num2));
			rectangle4.AddVertices(vertex);
			this.pgfRect.LineStyle = GlobalVariables.LineStyle.Solid;
			this.pgfRect.Thickness = 2;
			this.pgfRect.Colour = Color.Black;
			this.pgfRect.FinishCreation();
			this.pgfGroup.Add(this.pgfRect);
			this.pgfLine = new Line();
			Line line = this.pgfLine;
			vertex = new PointF((float)X, (float)Y);
			line.AddVertices(vertex);
			Line line2 = this.pgfLine;
			vertex = new PointF((float)(X + num), (float)(Y + num2));
			line2.AddVertices(vertex);
			this.pgfLine.LineStyle = GlobalVariables.LineStyle.Solid;
			this.pgfLine.Thickness = 2;
			this.pgfLine.Colour = Color.Black;
			this.pgfGroup.Add(this.pgfLine);
			this.pgfLine = new Line();
			Line line3 = this.pgfLine;
			vertex = new PointF((float)(X + num), (float)Y);
			line3.AddVertices(vertex);
			Line line4 = this.pgfLine;
			vertex = new PointF((float)X, (float)(Y + num2));
			line4.AddVertices(vertex);
			this.pgfLine.LineStyle = GlobalVariables.LineStyle.Solid;
			this.pgfLine.Thickness = 2;
			this.pgfLine.Colour = Color.Black;
			this.pgfGroup.Add(this.pgfLine);
			GlobalVariables.Canvas.Add(this.pgfGroup);
			GlobalVariables.Canvas.Draw(X, Y);
			this.pgfGroup.SelectThis();
		}

		// Token: 0x06000231 RID: 561 RVA: 0x000B5EE0 File Offset: 0x000B4EE0
		private void DrawSymbol_ManHole(ref double X, ref double Y)
		{
			this.pgfText = new Text();
			Text text = this.pgfText;
			PointF location = new PointF((float)(X + 5.0), (float)(Y - 2.0));
			text.Location = location;
			this.pgfText.Text = "M/H";
			this.pgfText.Colour = Color.Black;
			this.pgfGroup = new ShapeGroup();
			this.pgfGroup.Add(this.pgfText);
			this.pgfRect = (Rectangle)this.pgfText.BoundingRectangle.Clone();
			this.pgfRect.FinishCreation();
			this.pgfGroup.Add(this.pgfRect);
			this.pgfText.BoundingRectangle.FinishCreation();
			this.pgfGroup.Thickness = 2;
			GlobalVariables.Canvas.Add(this.pgfGroup);
			GlobalVariables.Canvas.Draw();
			this.pgfGroup.SelectThis();
		}

		// Token: 0x06000232 RID: 562 RVA: 0x000B5FDC File Offset: 0x000B4FDC
		private void DrawSymbol_Hydrant(ref double X, ref double Y)
		{
			Line[] array = new Line[5];
			double a = 4.0;
			this.pgfEllipse = new Ellipse();
			Ellipse ellipse = this.pgfEllipse;
			PointF pointF = new PointF((float)X, (float)Y);
			ellipse.Center = pointF;
			short num;
			checked
			{
				this.pgfEllipse.Width = (int)Math.Round(a);
				this.pgfEllipse.Height = (int)Math.Round(a);
				this.pgfEllipse.LineStyle = GlobalVariables.LineStyle.Solid;
				this.pgfEllipse.Thickness = 1;
				this.pgfEllipse.Colour = Color.Black;
				this.pgfEllipse.FinishCreation();
				num = 0;
			}
			do
			{
				array[(int)num] = new Line();
				array[(int)num].LineStyle = GlobalVariables.LineStyle.Solid;
				array[(int)num].Thickness = 2;
				num += 1;
			}
			while (num <= 3);
			double num2 = Math.Sin(0.78525) * (double)this.pgfEllipse.Width;
			Line line = array[0];
			pointF = new PointF((float)(X - num2), (float)(Y - num2));
			line.AddVertices(pointF);
			Line line2 = array[0];
			pointF = new PointF((float)(X - 2.0 * num2 - (double)this.pgfEllipse.Width / 2.0), (float)(Y - 2.0 * num2 - (double)this.pgfEllipse.Width / 2.0));
			line2.AddVertices(pointF);
			Line line3 = array[1];
			pointF = new PointF((float)(X - num2), (float)(Y + num2));
			line3.AddVertices(pointF);
			Line line4 = array[1];
			pointF = new PointF((float)(X - 2.0 * num2 - (double)this.pgfEllipse.Width / 2.0), (float)(Y + 2.0 * num2 + (double)this.pgfEllipse.Width / 2.0));
			line4.AddVertices(pointF);
			Line line5 = array[2];
			pointF = new PointF((float)(X + num2), (float)(Y - num2));
			line5.AddVertices(pointF);
			Line line6 = array[2];
			pointF = new PointF((float)(X + 2.0 * num2 + (double)this.pgfEllipse.Width / 2.0), (float)(Y - 2.0 * num2 - (double)this.pgfEllipse.Width / 2.0));
			line6.AddVertices(pointF);
			Line line7 = array[3];
			pointF = new PointF((float)(X + num2), (float)(Y + num2));
			line7.AddVertices(pointF);
			Line line8 = array[3];
			pointF = new PointF((float)(X + 2.0 * num2 + (double)this.pgfEllipse.Width / 2.0), (float)(Y + 2.0 * num2 + (double)this.pgfEllipse.Width / 2.0));
			line8.AddVertices(pointF);
			this.pgfGroup = new ShapeGroup();
			num = 0;
			do
			{
				this.pgfGroup.Add(array[(int)num]);
				num += 1;
			}
			while (num <= 3);
			this.pgfGroup.Add(this.pgfEllipse);
			GlobalVariables.Canvas.Add(this.pgfGroup);
			GlobalVariables.Canvas.Draw(X, Y);
			this.pgfGroup.SelectThis();
		}

		// Token: 0x06000233 RID: 563 RVA: 0x000B62F8 File Offset: 0x000B52F8
		private void DrawSymbol_GasValve(ref double X, ref double Y)
		{
			Triangle[] array = new Triangle[3];
			double num = 10.0;
			this.pgfLine = new Line();
			this.pgfLine.LineStyle = GlobalVariables.LineStyle.Solid;
			this.pgfLine.Thickness = 2;
			this.pgfLine.Colour = Color.Black;
			Line line = this.pgfLine;
			PointF vertex = new PointF((float)X, (float)Y);
			line.AddVertices(vertex);
			Line line2 = this.pgfLine;
			vertex = new PointF((float)X, (float)(Y + num));
			line2.AddVertices(vertex);
			Line line3 = this.pgfLine;
			vertex = new PointF((float)(X + num * 2.0), (float)Y);
			line3.AddVertices(vertex);
			Line line4 = this.pgfLine;
			vertex = new PointF((float)(X + num * 2.0), (float)(Y + num));
			line4.AddVertices(vertex);
			Line line5 = this.pgfLine;
			vertex = new PointF((float)X, (float)Y);
			line5.AddVertices(vertex);
			GlobalVariables.Canvas.Add(this.pgfLine);
			this.pgfLine.SelectThis();
			GlobalVariables.Canvas.Draw(X, Y);
		}

		// Token: 0x06000234 RID: 564 RVA: 0x000B640C File Offset: 0x000B540C
		private void DrawSymbol_Transformer(ref double X, ref double Y)
		{
			double num = 15.0;
			double num2 = 9.0;
			this.pgfRect = new Rectangle();
			Rectangle rectangle = this.pgfRect;
			PointF vertex = new PointF((float)X, (float)Y);
			rectangle.AddVertices(vertex);
			Rectangle rectangle2 = this.pgfRect;
			vertex = new PointF((float)(X + num), (float)Y);
			rectangle2.AddVertices(vertex);
			Rectangle rectangle3 = this.pgfRect;
			vertex = new PointF((float)(X + num), (float)(Y + num));
			rectangle3.AddVertices(vertex);
			Rectangle rectangle4 = this.pgfRect;
			vertex = new PointF((float)X, (float)(Y + num));
			rectangle4.AddVertices(vertex);
			this.pgfRect.LineStyle = GlobalVariables.LineStyle.Solid;
			this.pgfRect.Thickness = 2;
			this.pgfRect.Colour = Color.Black;
			this.pgfRect.FinishCreation();
			this.pgfLine = new Line();
			this.pgfLine.LineStyle = GlobalVariables.LineStyle.Solid;
			this.pgfLine.Thickness = 2;
			this.pgfLine.Colour = Color.Black;
			Line line = this.pgfLine;
			vertex = new PointF((float)(X + (num - num2) / 2.0), (float)(Y - (num - num2) / 2.0 + num));
			line.AddVertices(vertex);
			Line line2 = this.pgfLine;
			vertex = new PointF((float)(X + (num - num2) / 2.0 + num2), (float)(Y - (num - num2) / 2.0 + num));
			line2.AddVertices(vertex);
			Line line3 = this.pgfLine;
			vertex = new PointF((float)(X + num / 2.0), (float)(Y - Math.Sqrt(3.0) / 2.0 * num2 - (num - num2) / 2.0 + num));
			line3.AddVertices(vertex);
			Line line4 = this.pgfLine;
			vertex = new PointF((float)(X + (num - num2) / 2.0), (float)(Y - (num - num2) / 2.0 + num));
			line4.AddVertices(vertex);
			this.pgfGroup = new ShapeGroup();
			this.pgfGroup.Add(this.pgfLine);
			this.pgfGroup.Add(this.pgfRect);
			GlobalVariables.Canvas.Add(this.pgfGroup);
			GlobalVariables.Canvas.Draw();
			this.pgfGroup.SelectThis();
		}

		// Token: 0x06000235 RID: 565 RVA: 0x000B6654 File Offset: 0x000B5654
		private void DrawSymbol_Pole(ref double X, ref double Y)
		{
			double a = 8.0;
			this.pgfEllipse = new Ellipse();
			Ellipse ellipse = this.pgfEllipse;
			PointF center = new PointF((float)X, (float)Y);
			ellipse.Center = center;
			checked
			{
				this.pgfEllipse.Width = (int)Math.Round(a);
				this.pgfEllipse.Height = (int)Math.Round(a);
				this.pgfEllipse.LineStyle = GlobalVariables.LineStyle.Solid;
				this.pgfEllipse.Thickness = 1;
				this.pgfEllipse.Colour = Color.Black;
				this.pgfEllipse.FinishCreation();
				GlobalVariables.Canvas.Add(this.pgfEllipse);
				GlobalVariables.Canvas.Draw(X, Y);
				this.pgfEllipse.SelectThis();
			}
		}

		// Token: 0x06000236 RID: 566 RVA: 0x000B6710 File Offset: 0x000B5710
		private bool DrawSymbol_WaterValve(ref double X, ref double Y)
		{
			this.pgfGroup = new ShapeGroup();
			this.pgfText = new Text();
			this.pgfText.Text = "WV";
			Text text = this.pgfText;
			PointF pointF = new PointF((float)(X - this.pgfText.Width / 2.0), (float)(Y - this.pgfText.Height / 2.0));
			text.Location = pointF;
			this.pgfText.Thickness = 1;
			double a = this.pgfText.Width / 2.0;
			this.pgfEllipse = new Ellipse();
			Ellipse ellipse = this.pgfEllipse;
			pointF = new PointF((float)X, (float)Y);
			ellipse.Center = pointF;
			checked
			{
				this.pgfEllipse.Width = (int)Math.Round(a);
				this.pgfEllipse.Height = (int)Math.Round(a);
				this.pgfEllipse.LineStyle = GlobalVariables.LineStyle.Solid;
				this.pgfEllipse.Thickness = 1;
				this.pgfEllipse.Colour = Color.Black;
				this.pgfEllipse.FinishCreation();
				this.pgfGroup.Add(this.pgfText);
				this.pgfGroup.Add(this.pgfEllipse);
				this.pgfGroup.SelectThis();
				GlobalVariables.Canvas.Add(this.pgfGroup);
				GlobalVariables.Canvas.Draw(X, Y);
				return true;
			}
		}

		// Token: 0x06000237 RID: 567 RVA: 0x000B6874 File Offset: 0x000B5874
		private bool DrawSymbol_HandWell(ref double X, ref double Y)
		{
			this.pgfGroup = new ShapeGroup();
			this.pgfText = new Text();
			this.pgfText.Text = "HW";
			Text text = this.pgfText;
			PointF pointF = new PointF((float)(X - this.pgfText.Width / 2.0), (float)(Y - this.pgfText.Height / 2.0));
			text.Location = pointF;
			this.pgfText.Thickness = 1;
			double num = this.pgfText.Width / 2.0;
			this.pgfEllipse = new Ellipse();
			Ellipse ellipse = this.pgfEllipse;
			pointF = new PointF((float)X, (float)Y);
			ellipse.Center = pointF;
			Rectangle rectangle;
			checked
			{
				this.pgfEllipse.Width = (int)Math.Round(num);
				this.pgfEllipse.Height = (int)Math.Round(num);
				this.pgfEllipse.LineStyle = GlobalVariables.LineStyle.Solid;
				this.pgfEllipse.Thickness = 1;
				this.pgfEllipse.Colour = Color.Black;
				this.pgfEllipse.FinishCreation();
				this.pgfGroup.Add(this.pgfText);
				this.pgfGroup.Add(this.pgfEllipse);
				this.pgfRect = new Rectangle();
				rectangle = this.pgfRect;
			}
			pointF = new PointF((float)(X - num), (float)(Y - num));
			rectangle.AddVertices(pointF);
			Rectangle rectangle2 = this.pgfRect;
			pointF = new PointF((float)(X + num), (float)(Y - num));
			rectangle2.AddVertices(pointF);
			Rectangle rectangle3 = this.pgfRect;
			pointF = new PointF((float)(X + num), (float)(Y + num));
			rectangle3.AddVertices(pointF);
			Rectangle rectangle4 = this.pgfRect;
			pointF = new PointF((float)(X - num), (float)(Y + num));
			rectangle4.AddVertices(pointF);
			this.pgfRect.LineStyle = GlobalVariables.LineStyle.Solid;
			this.pgfRect.Thickness = 2;
			this.pgfRect.Colour = Color.Black;
			this.pgfRect.FinishCreation();
			this.pgfGroup.Add(this.pgfRect);
			this.pgfGroup.SelectThis();
			GlobalVariables.Canvas.Add(this.pgfGroup);
			GlobalVariables.Canvas.Draw(X, Y);
			return true;
		}

		// Token: 0x06000238 RID: 568 RVA: 0x000B6A98 File Offset: 0x000B5A98
		private bool DrawSymbol_Demarcation(ref double X, ref double Y)
		{
			this.pgfGroup = new ShapeGroup();
			this.pgfText = new Text();
			this.pgfText.Text = "DM";
			Text text = this.pgfText;
			PointF pointF = new PointF((float)(X - this.pgfText.Width / 2.0), (float)(Y - this.pgfText.Height / 2.0));
			text.Location = pointF;
			this.pgfText.Thickness = 1;
			double a = this.pgfText.Width / 2.0;
			this.pgfEllipse = new Ellipse();
			Ellipse ellipse = this.pgfEllipse;
			pointF = new PointF((float)X, (float)Y);
			ellipse.Center = pointF;
			checked
			{
				this.pgfEllipse.Width = (int)Math.Round(a);
				this.pgfEllipse.Height = (int)Math.Round(a);
				this.pgfEllipse.LineStyle = GlobalVariables.LineStyle.Solid;
				this.pgfEllipse.Thickness = 1;
				this.pgfEllipse.Colour = Color.Black;
				this.pgfEllipse.FinishCreation();
				this.pgfGroup.Add(this.pgfText);
				this.pgfGroup.Add(this.pgfEllipse);
				this.pgfGroup.SelectThis();
				GlobalVariables.Canvas.Add(this.pgfGroup);
				GlobalVariables.Canvas.Draw(X, Y);
				return true;
			}
		}

		// Token: 0x06000239 RID: 569 RVA: 0x000B6BFC File Offset: 0x000B5BFC
		private bool DrawSymbol_WaterChamber(ref double X, ref double Y)
		{
			this.pgfGroup = new ShapeGroup();
			this.pgfText = new Text();
			this.pgfText.Text = "WC";
			Text text = this.pgfText;
			PointF pointF = new PointF((float)(X - this.pgfText.Width / 2.0), (float)(Y - this.pgfText.Height / 2.0));
			text.Location = pointF;
			this.pgfText.Thickness = 1;
			double num = this.pgfText.Width / 2.0;
			this.pgfEllipse = new Ellipse();
			Ellipse ellipse = this.pgfEllipse;
			pointF = new PointF((float)X, (float)Y);
			ellipse.Center = pointF;
			Rectangle rectangle;
			checked
			{
				this.pgfEllipse.Width = (int)Math.Round(num);
				this.pgfEllipse.Height = (int)Math.Round(num);
				this.pgfEllipse.LineStyle = GlobalVariables.LineStyle.Solid;
				this.pgfEllipse.Thickness = 1;
				this.pgfEllipse.Colour = Color.Black;
				this.pgfEllipse.FinishCreation();
				this.pgfGroup.Add(this.pgfText);
				this.pgfGroup.Add(this.pgfEllipse);
				this.pgfRect = new Rectangle();
				rectangle = this.pgfRect;
			}
			pointF = new PointF((float)(X - num), (float)(Y - num));
			rectangle.AddVertices(pointF);
			Rectangle rectangle2 = this.pgfRect;
			pointF = new PointF((float)(X + num), (float)(Y - num));
			rectangle2.AddVertices(pointF);
			Rectangle rectangle3 = this.pgfRect;
			pointF = new PointF((float)(X + num), (float)(Y + num));
			rectangle3.AddVertices(pointF);
			Rectangle rectangle4 = this.pgfRect;
			pointF = new PointF((float)(X - num), (float)(Y + num));
			rectangle4.AddVertices(pointF);
			this.pgfRect.LineStyle = GlobalVariables.LineStyle.Solid;
			this.pgfRect.Thickness = 2;
			this.pgfRect.Colour = Color.Black;
			this.pgfRect.FinishCreation();
			this.pgfGroup.Add(this.pgfRect);
			this.pgfGroup.SelectThis();
			GlobalVariables.Canvas.Add(this.pgfGroup);
			GlobalVariables.Canvas.Draw(X, Y);
			return true;
		}

		// Token: 0x0600023A RID: 570 RVA: 0x000B6E20 File Offset: 0x000B5E20
		private void EndDrawPencil(ref double X, ref double Y)
		{
			try
			{
				this.DrawPencil(ref X, ref Y);
				this.pgfLine.Colour = this.ShapeColour;
				this.pgfLine.SelectThis();
				Undo undo = new Undo();
				undo.AddShape(this.pgfLine);
				undo.operationType = GlobalVariables.DrawMode.DrawPencil;
				GlobalVariables.UndoStack.Push(undo);
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x0600023B RID: 571 RVA: 0x000B6E9C File Offset: 0x000B5E9C
		private void EndDrawAngledLines(ref double X, ref double Y)
		{
			this.EndDrawLines(ref X, ref Y);
		}

		// Token: 0x0600023C RID: 572 RVA: 0x000B6EA8 File Offset: 0x000B5EA8
		private void EndDrawLines(ref double X, ref double Y)
		{
			try
			{
				Undo undo = new Undo();
				float num = this.pgfLine.Vertices[1].X - this.pgfLine.Vertices[0].X;
				float num2 = this.pgfLine.Vertices[1].Y - this.pgfLine.Vertices[0].Y;
				float num3 = (float)Math.Sqrt((double)(num * num + num2 * num2));
				if (num3 != 0f)
				{
					double num4;
					double num5;
					if (this.pgfLine.Vertices[0].X != this.pgfLine.Vertices[1].X)
					{
						num4 = (double)Math.Min(this.pgfLine.Vertices[0].X, this.pgfLine.Vertices[1].X);
						if (num4 == (double)this.pgfLine.Vertices[0].X)
						{
							num5 = (double)this.pgfLine.Vertices[0].Y;
						}
						else
						{
							num5 = (double)this.pgfLine.Vertices[1].Y;
							num = -1f * num;
							num2 = -1f * num2;
						}
					}
					else if (this.pgfLine.Vertices[0].Y < this.pgfLine.Vertices[1].Y)
					{
						num5 = (double)this.pgfLine.Vertices[0].Y;
						num4 = (double)this.pgfLine.Vertices[0].X;
					}
					else
					{
						num5 = (double)this.pgfLine.Vertices[1].Y;
						num4 = (double)this.pgfLine.Vertices[1].X;
						num2 = -1f * num2;
					}
					double width;
					double height;
					double num7;
					double num8;
					if (Operators.CompareString(this.LineText, string.Empty, false) != 0)
					{
						this.pgfText = new Text();
						this.pgfText.Text = this.LineText;
						this.pgfText.Thickness = this.PenWidth;
						this.pgfText.Colour = this.ShapeColour;
						double num6 = this.pgfText.Width / (double)this.LineText.Length;
						width = this.pgfText.Width;
						height = this.pgfText.Height;
						num7 = width + num6;
						num8 = 1.5 * num6;
					}
					double num9 = (double)num3;
					this.pgfGroup = new ShapeGroup();
					if (Operators.CompareString(this.LineText, "NONE", false) == 0)
					{
						this.pgfLine.SelectThis();
						undo.AddShape(this.pgfLine);
						undo.operationType = GlobalVariables.DrawMode.DrawLines;
						GlobalVariables.UndoStack.Push(undo);
					}
					else
					{
						GlobalVariables.Canvas.Remove(this.pgfLine);
						while (num9 > 0.0)
						{
							this.pgfLine = new Line();
							this.pgfLine.Thickness = this.PenWidth;
							this.pgfLine.Colour = this.ShapeColour;
							this.pgfLine.LineStyle = this.SelectedLineStyle;
							Line line = this.pgfLine;
							Point p = checked(new Point((int)Math.Round(num4), (int)Math.Round(num5)));
							line.AddVertices(p);
							if (num9 > num7 + num8)
							{
								num4 += (double)(num / num3) * num8;
								num5 += (double)(num2 / num3) * num8;
								Line line2 = this.pgfLine;
								checked
								{
									p = new Point((int)Math.Round(num4), (int)Math.Round(num5));
									line2.AddVertices(p);
									short num10;
									if (num10 == 0)
									{
										double a;
										double a2;
										Text text;
										unchecked
										{
											a = num4 + (double)(num / num3) * num7 / 2.0 - width / 2.0;
											a2 = num5 + (double)(num2 / num3) * num7 / 2.0 - height / 2.0;
											this.pgfText = new Text();
											this.pgfText.Thickness = this.PenWidth;
											this.pgfText.Colour = this.ShapeColour;
											this.pgfText.Text = this.LineText;
											text = this.pgfText;
										}
										p = new Point((int)Math.Round(a), (int)Math.Round(a2));
										text.Location = p;
										this.pgfGroup.Add(this.pgfText);
									}
									else if (num10 == 1)
									{
										Line line3 = this.pgfLine;
										p = new Point((int)Math.Round(num4), (int)Math.Round(num5));
										line3.AddVertices(p);
										unchecked
										{
											num4 += (double)(num / num3) * num7;
											num5 += (double)(num2 / num3) * num7;
											Line line4 = this.pgfLine;
											p = checked(new Point((int)Math.Round(num4), (int)Math.Round(num5)));
											line4.AddVertices(p);
											num4 -= (double)(num / num3) * num7;
											num5 -= (double)(num2 / num3) * num7;
											num10 = -1;
										}
									}
									num10 += 1;
								}
								num4 += (double)(num / num3) * num7;
								num5 += (double)(num2 / num3) * num7;
							}
							else
							{
								num4 += (double)(num / num3) * num9;
								num5 += (double)(num2 / num3) * num9;
								Line line5 = this.pgfLine;
								p = checked(new Point((int)Math.Round(num4), (int)Math.Round(num5)));
								line5.AddVertices(p);
							}
							this.pgfGroup.Add(this.pgfLine);
							num9 = num9 - num7 - num8;
						}
						GlobalVariables.Canvas.Add(this.pgfGroup);
						undo.AddShape(this.pgfGroup);
						undo.operationType = GlobalVariables.DrawMode.DrawLines;
						GlobalVariables.UndoStack.Push(undo);
					}
					this.pgfGroup.SelectThis();
				}
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x0600023D RID: 573 RVA: 0x000B74C4 File Offset: 0x000B64C4
		private void EndDrawRectangle(ref double X, ref double Y)
		{
			try
			{
				this.DrawRectangle(ref X, ref Y);
				this.pgfRect.Colour = this.ShapeColour;
				this.pgfRect.FinishCreation();
				this.pgfRect.SelectThis();
				Undo undo = new Undo();
				undo.AddShape(this.pgfRect);
				undo.operationType = GlobalVariables.DrawMode.DrawRectangle;
				GlobalVariables.UndoStack.Push(undo);
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x0600023E RID: 574 RVA: 0x000B754C File Offset: 0x000B654C
		private void EndDrawArrow(ref double X, ref double Y)
		{
			checked
			{
				try
				{
					Undo undo = new Undo();
					this.DrawArrow(ref X, ref Y);
					this.pgfGroup.Colour = this.ShapeColour;
					this.pgfGroup.SelectThis();
					undo.AddShape(this.pgfGroup);
					undo.operationType = GlobalVariables.DrawMode.DrawArrow;
					if (Operators.CompareString(this.SelectedText, string.Empty, false) != 0)
					{
						this.pgfText.SelectThis();
						undo.AddShape(this.pgfText);
						GlobalVariables.UndoStack.Push(undo);
					}
					else
					{
						GlobalVariables.UndoStack.Push(undo);
						this.pgfText = new Text();
						Text text = this.pgfText;
						Point p = new Point((int)Math.Round(X), (int)Math.Round(Y));
						text.Location = p;
						this.pgfText.Thickness = this.PenWidth;
						this.pgfText.Colour = this.ShapeColour;
						p = new Point((int)Math.Round(X), (int)Math.Round(Y));
						PointF location = p;
						Size size = new Size(100, 100);
						this.DrawTextBox(location, size);
						this.pgfText.SelectThis();
						this.pgfGroup.CalculateBoundingRectangle();
						this.txtDrawText.Focus();
					}
				}
				catch (Exception ex)
				{
					ComPetersError.DisplayError(ex);
				}
			}
		}

		// Token: 0x0600023F RID: 575 RVA: 0x000B76B8 File Offset: 0x000B66B8
		private void EndDrawMeasureLines(ref double X, ref double Y)
		{
			checked
			{
				try
				{
					this.DrawMeasureLine(ref X, ref Y);
					this.pgfGroup.SelectThis();
					this.pgfGroup2.SelectThis();
					Undo undo = new Undo();
					undo.AddShape(this.pgfGroup);
					undo.AddShape(this.pgfGroup2);
					this.pgfText = new Text();
					this.pgfText.Thickness = this.PenWidth;
					this.pgfText.Colour = this.ShapeColour;
					Text text = this.pgfText;
					Point p = new Point((int)Math.Round((double)this.pgfMeasureLine2.Vertices[1].X), (int)Math.Round((double)this.pgfMeasureLine2.Vertices[1].Y));
					text.Location = p;
					p = new Point((int)Math.Round((double)this.pgfMeasureLine2.Vertices[1].X), (int)Math.Round((double)this.pgfMeasureLine2.Vertices[1].Y));
					PointF location = p;
					Size size = new Size(100, 100);
					this.DrawTextBox(location, size);
					this.txtDrawText.Focus();
					this.pgfGroup.CalculateBoundingRectangle();
					this.pgfGroup2.CalculateBoundingRectangle();
					undo.operationType = GlobalVariables.DrawMode.DrawMeasureLines;
					GlobalVariables.UndoStack.Push(undo);
				}
				catch (Exception ex)
				{
					ComPetersError.DisplayError(ex);
				}
			}
		}

		// Token: 0x06000240 RID: 576 RVA: 0x000B7844 File Offset: 0x000B6844
		private void EndDrawEllipse(ref double X, ref double Y)
		{
			try
			{
				this.DrawEllipse(ref X, ref Y);
				this.pgfEllipse.Colour = this.ShapeColour;
				this.pgfEllipse.SelectThis();
				this.pgfEllipse.FinishCreation();
				Undo undo = new Undo();
				undo.AddShape(this.pgfEllipse);
				undo.operationType = GlobalVariables.DrawMode.DrawEllipse;
				GlobalVariables.UndoStack.Push(undo);
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x06000241 RID: 577 RVA: 0x000B78CC File Offset: 0x000B68CC
		private void EndDrawArc(ref double X, ref double Y)
		{
			try
			{
				this.DrawArc(ref X, ref Y);
				GlobalVariables.Canvas.Remove(this.pgfRect);
				this.pgfArc.Colour = this.ShapeColour;
				this.pgfArc.FinishCreation();
				this.pgfArc.SelectThis();
				Undo undo = new Undo();
				undo.AddShape(this.pgfArc);
				undo.operationType = GlobalVariables.DrawMode.DrawArc;
				GlobalVariables.UndoStack.Push(undo);
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x06000242 RID: 578 RVA: 0x000B7964 File Offset: 0x000B6964
		private void EndDrawSelected(ref double X, ref double Y)
		{
			try
			{
				if (!Information.IsNothing(this.pgfRect))
				{
					GlobalVariables.Canvas.Remove(this.pgfRect);
					GlobalVariables.Canvas.SelectShapesWithBox(this.pgfRect.Vertices[0], this.pgfRect.Vertices[2]);
				}
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x06000243 RID: 579 RVA: 0x000B79EC File Offset: 0x000B69EC
		private void EndMove(ref double X, ref double Y)
		{
			try
			{
				object value = X;
				object value2 = Y;
				this.DrawMove(ref value, ref value2);
				Y = Conversions.ToDouble(value2);
				X = Conversions.ToDouble(value);
				this.isMoving = false;
				Undo undo = (Undo)GlobalVariables.UndoStack.Pop();
				undo.operationType = GlobalVariables.DrawMode.Move;
				undo.newX = X;
				undo.newY = Y;
				foreach (IShape shape in GlobalVariables.Canvas.SelectedShapes)
				{
					undo.AddShape(shape);
				}
				GlobalVariables.UndoStack.Push(undo);
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x06000244 RID: 580 RVA: 0x000B7AB4 File Offset: 0x000B6AB4
		private void EndRotate(ref double X, ref double Y)
		{
			try
			{
				GlobalVariables.Canvas.Remove(this.pgfRotatePositionLine);
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x06000245 RID: 581 RVA: 0x000B7AF8 File Offset: 0x000B6AF8
		private void EndDrawNorthSign(ref double X, ref double Y)
		{
			try
			{
				this.DrawNorthSign(ref X, ref Y);
				this.pgfGroup.Colour = this.ShapeColour;
				this.pgfGroup.SelectThis();
				Undo undo = new Undo();
				undo.AddShape(this.pgfGroup);
				undo.operationType = GlobalVariables.DrawMode.DrawNorthSign;
				GlobalVariables.UndoStack.Push(undo);
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x06000246 RID: 582 RVA: 0x000B7B78 File Offset: 0x000B6B78
		private void EndInsertedStamp(ref double X, ref double Y)
		{
			try
			{
				if (!Information.IsNothing(this.pgfStamp))
				{
					GlobalVariables.userMode = GlobalVariables.DrawMode.Move;
					this.DisplayNoOptions();
				}
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x06000247 RID: 583 RVA: 0x000B7BC8 File Offset: 0x000B6BC8
		private void EndSymbol()
		{
			try
			{
				Undo undo = new Undo();
				undo.AddShape(this.pgfGroup);
				undo.operationType = GlobalVariables.DrawMode.DrawSymbol;
				GlobalVariables.UndoStack.Push(undo);
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x06000248 RID: 584 RVA: 0x000B7C24 File Offset: 0x000B6C24
		private void EndResize(ref double X, ref double Y)
		{
			try
			{
				object value = X;
				object value2 = Y;
				this.DrawResize(ref value, ref value2);
				Y = Conversions.ToDouble(value2);
				X = Conversions.ToDouble(value);
				this.isResizing = false;
				Undo undo = (Undo)GlobalVariables.UndoStack.Pop();
				undo.operationType = GlobalVariables.DrawMode.Move;
				undo.newX = X;
				undo.newY = Y;
				foreach (IShape shape in GlobalVariables.Canvas.SelectedShapes)
				{
					undo.AddShape(shape);
				}
				GlobalVariables.UndoStack.Push(undo);
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x06000249 RID: 585 RVA: 0x000B7CEC File Offset: 0x000B6CEC
		private void Save(string FileNameandPath)
		{
			try
			{
				Bitmap bitmap = this.GrabScreenshot();
				ImageCodecInfo encoderInfo = this.GetEncoderInfo(ImageFormat.Jpeg);
				Encoder quality = Encoder.Quality;
				EncoderParameters encoderParameters = new EncoderParameters(1);
				EncoderParameter encoderParameter = new EncoderParameter(quality, 100L);
				encoderParameters.Param[0] = encoderParameter;
				bitmap.Save(FileNameandPath, encoderInfo, encoderParameters);
				bitmap.Dispose();
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x0600024A RID: 586 RVA: 0x000B7D68 File Offset: 0x000B6D68
		private ImageCodecInfo GetEncoderInfo(ImageFormat format)
		{
			checked
			{
				ImageCodecInfo result;
				try
				{
					ImageCodecInfo[] imageEncoders = ImageCodecInfo.GetImageEncoders();
					for (int i = 0; i < imageEncoders.Length; i++)
					{
						if (imageEncoders[i].FormatID == format.Guid)
						{
							return imageEncoders[i];
						}
					}
					result = null;
				}
				catch (Exception ex)
				{
					ComPetersError.DisplayError(ex);
					result = null;
				}
				return result;
			}
		}

		// Token: 0x0600024B RID: 587 RVA: 0x000B7DD0 File Offset: 0x000B6DD0
		private void HighlightToolButtons(Button Sender)
		{
			try
			{
				if (!Information.IsNothing(this.PreviousToolButton))
				{
					Icon icon = new Icon(Application.StartupPath + "\\images\\Tools\\" + this.PreviousToolButton.Tag.ToString() + "Off.ico");
					this.PreviousToolButton.Image = icon.ToBitmap();
				}
				this.PreviousToolButton = Sender;
				Icon icon2 = new Icon(Application.StartupPath + "\\images\\Tools\\" + Sender.Tag.ToString() + "On.ico");
				Sender.Image = icon2.ToBitmap();
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x0600024C RID: 588 RVA: 0x000B7E84 File Offset: 0x000B6E84
		private void cmdMeasuringLines_Click(object sender, EventArgs e)
		{
			try
			{
				GlobalVariables.userMode = GlobalVariables.DrawMode.DrawMeasureLines;
				this.Cursor = Cursors.Cross;
				this.HighlightToolButtons((Button)sender);
				this.DisplayMeasureLineOptions();
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x0600024D RID: 589 RVA: 0x000B7EDC File Offset: 0x000B6EDC
		private void cmdStraightLine_Click(object sender, EventArgs e)
		{
			try
			{
				GlobalVariables.userMode = GlobalVariables.DrawMode.DrawLines;
				this.Cursor = Cursors.Cross;
				this.HighlightToolButtons((Button)sender);
				this.DisplayDrawStraightLineOptions();
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x0600024E RID: 590 RVA: 0x000B7F34 File Offset: 0x000B6F34
		private void cmdFreeDrawing_Click(object sender, EventArgs e)
		{
			try
			{
				GlobalVariables.userMode = GlobalVariables.DrawMode.DrawPencil;
				this.Cursor = Cursors.Cross;
				this.HighlightToolButtons((Button)sender);
				this.DisplayDrawPenLineOptions();
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x0600024F RID: 591 RVA: 0x000B7F8C File Offset: 0x000B6F8C
		private void cmdAngledLines_Click(object sender, EventArgs e)
		{
			try
			{
				GlobalVariables.userMode = GlobalVariables.DrawMode.DrawAngledLines;
				this.Cursor = Cursors.Cross;
				this.HighlightToolButtons((Button)sender);
				this.DisplayDrawStraightLineOptions();
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x06000250 RID: 592 RVA: 0x000B7FE4 File Offset: 0x000B6FE4
		private void cmdRectangle_Click(object sender, EventArgs e)
		{
			try
			{
				GlobalVariables.userMode = GlobalVariables.DrawMode.DrawRectangle;
				this.Cursor = Cursors.Cross;
				this.HighlightToolButtons((Button)sender);
				this.DisplayShapeOptions();
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x06000251 RID: 593 RVA: 0x000B803C File Offset: 0x000B703C
		private void cmdArrows_Click(object sender, EventArgs e)
		{
			try
			{
				GlobalVariables.userMode = GlobalVariables.DrawMode.DrawArrow;
				this.Cursor = Cursors.Cross;
				this.HighlightToolButtons((Button)sender);
				this.DisplayArrowOptions();
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x06000252 RID: 594 RVA: 0x000B8094 File Offset: 0x000B7094
		private void cmdCircle_Click(object sender, EventArgs e)
		{
			try
			{
				GlobalVariables.userMode = GlobalVariables.DrawMode.DrawEllipse;
				this.Cursor = Cursors.Cross;
				this.HighlightToolButtons((Button)sender);
				this.DisplayShapeOptions();
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x06000253 RID: 595 RVA: 0x000B80EC File Offset: 0x000B70EC
		private void cmdArc_Click(object sender, EventArgs e)
		{
			try
			{
				GlobalVariables.userMode = GlobalVariables.DrawMode.DrawArc;
				this.Cursor = Cursors.Cross;
				this.HighlightToolButtons((Button)sender);
				this.DisplayArcOptions();
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x06000254 RID: 596 RVA: 0x000B8144 File Offset: 0x000B7144
		private void cmdText_Click(object sender, EventArgs e)
		{
			try
			{
				this.Cursor = Cursors.Arrow;
				GlobalVariables.userMode = GlobalVariables.DrawMode.DrawText;
				this.HighlightToolButtons((Button)sender);
				this.DisplayTextOptions();
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x06000255 RID: 597 RVA: 0x000B819C File Offset: 0x000B719C
		private void cmdStamps_Click(object sender, EventArgs e)
		{
			try
			{
				this.DisplayNoOptions();
				this.OpenFileDialog1.InitialDirectory = Application.StartupPath + "\\images\\Stamps";
				DialogResult dialogResult = this.OpenFileDialog1.ShowDialog();
				if (dialogResult != DialogResult.Cancel)
				{
					this.Cursor = Cursors.Arrow;
					GlobalVariables.userMode = GlobalVariables.DrawMode.InsertStamp;
					this.HighlightToolButtons((Button)sender);
				}
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x06000256 RID: 598 RVA: 0x000B8220 File Offset: 0x000B7220
		private void cmdSelect_Click(object sender, EventArgs e)
		{
			try
			{
				GlobalVariables.userMode = GlobalVariables.DrawMode.SelectTool;
				this.Cursor = Cursors.Arrow;
				this.HighlightToolButtons((Button)sender);
				this.DisplayNoOptions();
				GlobalVariables.Canvas.DeselectAll();
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x06000257 RID: 599 RVA: 0x000B8280 File Offset: 0x000B7280
		private void btnDelete_Click(object sender, EventArgs e)
		{
			try
			{
				GlobalVariables.Canvas.DeleteSelected();
				this.HighlightToolButtons((Button)sender);
				GlobalVariables.Canvas.Draw();
				Undo undo = new Undo();
				undo.operationType = GlobalVariables.DrawMode.Delete;
				GlobalVariables.UndoStack.Push(undo);
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x06000258 RID: 600 RVA: 0x000B82EC File Offset: 0x000B72EC
		private void btnMove_Click(object sender, EventArgs e)
		{
			try
			{
				GlobalVariables.userMode = GlobalVariables.DrawMode.Move;
				this.Cursor = Cursors.Hand;
				this.HighlightToolButtons((Button)sender);
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x06000259 RID: 601 RVA: 0x000B8340 File Offset: 0x000B7340
		private void btnRotate_Click(object sender, EventArgs e)
		{
			try
			{
				this.Cursor = Cursors.SizeNWSE;
				GlobalVariables.userMode = GlobalVariables.DrawMode.Rotate;
				this.HighlightToolButtons((Button)sender);
				this.DisplayRotateOptions();
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x0600025A RID: 602 RVA: 0x000B8398 File Offset: 0x000B7398
		private void btnSymbol_Click(object sender, EventArgs e)
		{
			try
			{
				GlobalVariables.userMode = GlobalVariables.DrawMode.InsertSymbol;
				this.HighlightToolButtons((Button)sender);
				this.Cursor = Cursors.Hand;
				this.DisplayInsertSymbolsOptions();
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x0600025B RID: 603 RVA: 0x000B83F0 File Offset: 0x000B73F0
		private void btnNorthSymbol_Click(object sender, EventArgs e)
		{
			try
			{
				this.Cursor = Cursors.Cross;
				this.HighlightToolButtons((Button)sender);
				GlobalVariables.userMode = GlobalVariables.DrawMode.DrawNorthSign;
				this.DisplayNorthSignOptions();
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x0600025C RID: 604 RVA: 0x000B8448 File Offset: 0x000B7448
		private void btnEraseScreen_Click(object sender, EventArgs e)
		{
			try
			{
				GlobalVariables.Canvas.Clear();
				GlobalVariables.Canvas.Draw();
				GlobalVariables.UndoStack.Clear();
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x0600025D RID: 605 RVA: 0x000B849C File Offset: 0x000B749C
		private void btnResize_Click(object sender, EventArgs e)
		{
			try
			{
				GlobalVariables.userMode = GlobalVariables.DrawMode.Resize;
				this.Cursor = Cursors.SizeAll;
				this.HighlightToolButtons((Button)sender);
				this.DisplayNoOptions();
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x0600025E RID: 606 RVA: 0x000B84F4 File Offset: 0x000B74F4
		private void txtDrawText_KeyDown(object sender, KeyEventArgs e)
		{
			try
			{
				if (this.SelectedTextMode == GlobalVariables.TextMode.SingleRow)
				{
					if (e.KeyCode == Keys.Return)
					{
						this.txtDrawText.Visible = false;
					}
					this.SelectedTextMode = GlobalVariables.TextMode.MultiRow;
				}
				if (e.KeyCode == Keys.Escape)
				{
					this.txtDrawText_Leave(null, null);
					this.txtDrawText.Visible = false;
				}
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x0600025F RID: 607 RVA: 0x000B856C File Offset: 0x000B756C
		private void txtDrawText_Leave(object sender, EventArgs e)
		{
			try
			{
				if (this.txtDrawText.Visible)
				{
					this.txtDrawText.Visible = false;
					TextBox txtDrawText = this.txtDrawText;
					string text = txtDrawText.Text;
					this.DrawText(ref text);
					txtDrawText.Text = text;
					this.txtDrawText.Text = "";
				}
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x06000260 RID: 608 RVA: 0x000B85E8 File Offset: 0x000B75E8
		private void txtDrawText_MouseUp(object sender, MouseEventArgs e)
		{
			try
			{
				GlobalVariables.userMode = GlobalVariables.DrawMode.SelectTool;
				this.txtDrawText.Focus();
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x06000261 RID: 609 RVA: 0x000B8630 File Offset: 0x000B7630
		private void HightligthSizeButtons(Button Button)
		{
			try
			{
				this.btnSize1.BackColor = SystemColors.Control;
				this.btnSize2.BackColor = SystemColors.Control;
				this.btnSize3.BackColor = SystemColors.Control;
				this.btnSize4.BackColor = SystemColors.Control;
				Button.BackColor = SystemColors.Highlight;
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x06000262 RID: 610 RVA: 0x000B86B0 File Offset: 0x000B76B0
		private void btnSize1_Click(object sender, EventArgs e)
		{
			try
			{
				this.PenWidth = 2;
				this.HightligthSizeButtons((Button)sender);
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x06000263 RID: 611 RVA: 0x000B86F8 File Offset: 0x000B76F8
		private void btnSize2_Click(object sender, EventArgs e)
		{
			try
			{
				this.PenWidth = 4;
				this.HightligthSizeButtons((Button)sender);
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x06000264 RID: 612 RVA: 0x000B8740 File Offset: 0x000B7740
		private void btnSize3_Click(object sender, EventArgs e)
		{
			try
			{
				this.PenWidth = 6;
				this.HightligthSizeButtons((Button)sender);
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x06000265 RID: 613 RVA: 0x000B8788 File Offset: 0x000B7788
		private void btnSize4_Click(object sender, EventArgs e)
		{
			try
			{
				this.PenWidth = 8;
				this.HightligthSizeButtons((Button)sender);
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x06000266 RID: 614 RVA: 0x000B87D0 File Offset: 0x000B77D0
		private void btnUndo_Click(object sender, EventArgs e)
		{
			try
			{
				if (GlobalVariables.UndoStack.Count >= 1)
				{
					Undo undo = (Undo)GlobalVariables.UndoStack.Pop();
					undo.Undo();
					GlobalVariables.Canvas.Draw();
				}
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x06000267 RID: 615 RVA: 0x000B8834 File Offset: 0x000B7834
		private void btnPaste_Click(object sender, EventArgs e)
		{
			try
			{
				ShapeGroup shapeGroup = new ShapeGroup();
				foreach (IShape shape in GlobalVariables.Canvas.SelectedShapes)
				{
					shapeGroup.Add(shape);
				}
				foreach (IShape shape2 in shapeGroup.Shapes)
				{
					IShape shape3 = shape2.Clone();
					shape3.Move(10, 10);
					shape2.Unselect();
					GlobalVariables.Canvas.RemoveShapeFromSelection(shape2);
					GlobalVariables.Canvas.Add(shape3);
					shape3.SelectThis();
				}
				GlobalVariables.Canvas.Draw();
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x06000268 RID: 616 RVA: 0x000B88FC File Offset: 0x000B78FC
		private void GlControl1_Paint(object sender, PaintEventArgs e)
		{
			GlobalVariables.Canvas.Draw();
		}

		// Token: 0x06000269 RID: 617 RVA: 0x000B8908 File Offset: 0x000B7908
		private void btnDash_Click(object sender, EventArgs e)
		{
			try
			{
				this.SelectedLineStyle = GlobalVariables.LineStyle.Dashed;
				this.btnDash.BackColor = SystemColors.Highlight;
				this.btnSolid.BackColor = SystemColors.Control;
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x0600026A RID: 618 RVA: 0x000B8964 File Offset: 0x000B7964
		private void btnSolid_Click(object sender, EventArgs e)
		{
			try
			{
				this.SelectedLineStyle = GlobalVariables.LineStyle.Solid;
				this.btnDash.BackColor = SystemColors.Control;
				this.btnSolid.BackColor = SystemColors.Highlight;
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x0600026B RID: 619 RVA: 0x000B89C0 File Offset: 0x000B79C0
		private void HightligthDirectionButtons(Button Button)
		{
			try
			{
				this.btnDirectionNone.BackColor = SystemColors.Control;
				this.btnDirectionNorth.BackColor = SystemColors.Control;
				this.btnDirectionSouth.BackColor = SystemColors.Control;
				this.btnDirectionWest.BackColor = SystemColors.Control;
				this.btnDirectionEast.BackColor = SystemColors.Control;
				Button.BackColor = SystemColors.Highlight;
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x0600026C RID: 620 RVA: 0x000B8A50 File Offset: 0x000B7A50
		private void btnDirectionNone_Click(object sender, EventArgs e)
		{
			this.HightligthDirectionButtons((Button)sender);
			this.DirectionText = string.Empty;
		}

		// Token: 0x0600026D RID: 621 RVA: 0x000B8A6C File Offset: 0x000B7A6C
		private void btnDirectionNorth_Click(object sender, EventArgs e)
		{
			this.HightligthDirectionButtons((Button)sender);
			this.DirectionText = "N";
		}

		// Token: 0x0600026E RID: 622 RVA: 0x000B8A88 File Offset: 0x000B7A88
		private void btnDirectionEast_Click(object sender, EventArgs e)
		{
			this.HightligthDirectionButtons((Button)sender);
			this.DirectionText = "E";
		}

		// Token: 0x0600026F RID: 623 RVA: 0x000B8AA4 File Offset: 0x000B7AA4
		private void btnDirectionSouth_Click(object sender, EventArgs e)
		{
			this.HightligthDirectionButtons((Button)sender);
			this.DirectionText = "S";
		}

		// Token: 0x06000270 RID: 624 RVA: 0x000B8AC0 File Offset: 0x000B7AC0
		private void btnDirectionWest_Click(object sender, EventArgs e)
		{
			this.HightligthDirectionButtons((Button)sender);
			this.DirectionText = "W";
		}

		// Token: 0x06000271 RID: 625 RVA: 0x000B8ADC File Offset: 0x000B7ADC
		private void btnGrid_Click(object sender, EventArgs e)
		{
			try
			{
				if (!GlobalVariables.Canvas.GridOn)
				{
					GlobalVariables.Canvas.GridOn = true;
					GlobalVariables.Canvas.Grid.Visible = true;
					this.btnGrid.Text = "Grid Off";
				}
				else
				{
					GlobalVariables.Canvas.GridOn = false;
					GlobalVariables.Canvas.Grid.Visible = false;
					this.btnGrid.Text = "Grid On";
				}
				GlobalVariables.Canvas.Draw();
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x06000272 RID: 626 RVA: 0x000B8B80 File Offset: 0x000B7B80
		private void DisplayInsertSymbolsOptions()
		{
			this.DisplayNoOptions();
			this.frListOfInsertableSymbols.Visible = true;
		}

		// Token: 0x06000273 RID: 627 RVA: 0x000B8B94 File Offset: 0x000B7B94
		private void DisplayMeasureLineOptions()
		{
			this.DisplayNoOptions();
			this.frSize.Visible = true;
		}

		// Token: 0x06000274 RID: 628 RVA: 0x000B8BA8 File Offset: 0x000B7BA8
		private void DisplayDrawStraightLineOptions()
		{
			this.DisplayNoOptions();
			this.LineTypes.Visible = true;
			this.frSize.Visible = true;
			this.fraLineStyle.Visible = true;
		}

		// Token: 0x06000275 RID: 629 RVA: 0x000B8BD4 File Offset: 0x000B7BD4
		private void DisplayDrawPenLineOptions()
		{
			this.DisplayNoOptions();
			this.frSize.Visible = true;
			this.fraLineStyle.Visible = true;
		}

		// Token: 0x06000276 RID: 630 RVA: 0x000B8BF4 File Offset: 0x000B7BF4
		private void DisplayShapeOptions()
		{
			this.DisplayNoOptions();
			this.frSize.Visible = true;
			this.fraLineStyle.Visible = true;
		}

		// Token: 0x06000277 RID: 631 RVA: 0x000B8C14 File Offset: 0x000B7C14
		private void DisplayTextOptions()
		{
			this.DisplayNoOptions();
			this.frSize.Visible = true;
		}

		// Token: 0x06000278 RID: 632 RVA: 0x000B8C28 File Offset: 0x000B7C28
		private void DisplayNoOptions()
		{
			try
			{
				this.frSize.Visible = false;
				this.fraLineStyle.Visible = false;
				this.frListOfInsertableSymbols.Visible = false;
				this.frInsertableTextPhrases.Visible = false;
				this.LineTypes.Visible = false;
				this.LineTypes.Visible = false;
				this.frDirection.Visible = false;
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x06000279 RID: 633 RVA: 0x000B8CB0 File Offset: 0x000B7CB0
		private void DisplayArrowOptions()
		{
			this.DisplayNoOptions();
			this.frSize.Visible = true;
			this.frDirection.Visible = true;
			this.frInsertableTextPhrases.Visible = true;
		}

		// Token: 0x0600027A RID: 634 RVA: 0x000B8CDC File Offset: 0x000B7CDC
		private void DisplayInsertTextOptions()
		{
			this.DisplayNoOptions();
			this.frInsertableTextPhrases.Visible = true;
		}

		// Token: 0x0600027B RID: 635 RVA: 0x000B8CF0 File Offset: 0x000B7CF0
		private void DisplayNorthSignOptions()
		{
			this.DisplayNoOptions();
		}

		// Token: 0x0600027C RID: 636 RVA: 0x000B8CF8 File Offset: 0x000B7CF8
		private void DisplayArcOptions()
		{
			this.DisplayNoOptions();
			this.frSize.Visible = true;
			this.fraLineStyle.Visible = true;
		}

		// Token: 0x0600027D RID: 637 RVA: 0x000B8D18 File Offset: 0x000B7D18
		private void DisplayRotateOptions()
		{
			this.DisplayNoOptions();
		}

		// Token: 0x0600027E RID: 638 RVA: 0x000B8D20 File Offset: 0x000B7D20
		private void HightlightTextButton(Button HightlightThis)
		{
			try
			{
				this.btnTextBL.BackColor = SystemColors.Control;
				this.btnTextCL.BackColor = SystemColors.Control;
				this.btnTextDW.BackColor = SystemColors.Control;
				this.btnTextFL.BackColor = SystemColors.Control;
				this.btnTextLA.BackColor = SystemColors.Control;
				this.btnTextNone.BackColor = SystemColors.Control;
				this.btnTextPL.BackColor = SystemColors.Control;
				this.btnTextRE.BackColor = SystemColors.Control;
				this.btnTextSW.BackColor = SystemColors.Control;
				HightlightThis.BackColor = SystemColors.Highlight;
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x0600027F RID: 639 RVA: 0x000B8DF0 File Offset: 0x000B7DF0
		private void btnTextNone_Click(object sender, EventArgs e)
		{
			this.HightlightTextButton((Button)sender);
			this.SelectedText = string.Empty;
		}

		// Token: 0x06000280 RID: 640 RVA: 0x000B8E0C File Offset: 0x000B7E0C
		private void btnTextLA_Click(object sender, EventArgs e)
		{
			this.HightlightTextButton((Button)sender);
			this.SelectedText = "Located Area";
		}

		// Token: 0x06000281 RID: 641 RVA: 0x000B8E28 File Offset: 0x000B7E28
		private void btnTextCL_Click(object sender, EventArgs e)
		{
			this.HightlightTextButton((Button)sender);
			this.SelectedText = "CL";
		}

		// Token: 0x06000282 RID: 642 RVA: 0x000B8E44 File Offset: 0x000B7E44
		private void btnTextSW_Click(object sender, EventArgs e)
		{
			this.HightlightTextButton((Button)sender);
			this.SelectedText = "SW";
		}

		// Token: 0x06000283 RID: 643 RVA: 0x000B8E60 File Offset: 0x000B7E60
		private void btnTextPL_Click(object sender, EventArgs e)
		{
			this.HightlightTextButton((Button)sender);
			this.SelectedText = "PL";
		}

		// Token: 0x06000284 RID: 644 RVA: 0x000B8E7C File Offset: 0x000B7E7C
		private void btnTextFL_Click(object sender, EventArgs e)
		{
			this.HightlightTextButton((Button)sender);
			this.SelectedText = "FL";
		}

		// Token: 0x06000285 RID: 645 RVA: 0x000B8E98 File Offset: 0x000B7E98
		private void btnTextBL_Click(object sender, EventArgs e)
		{
			this.HightlightTextButton((Button)sender);
			this.SelectedText = "BL";
		}

		// Token: 0x06000286 RID: 646 RVA: 0x000B8EB4 File Offset: 0x000B7EB4
		private void btnTextDW_Click(object sender, EventArgs e)
		{
			this.HightlightTextButton((Button)sender);
			this.SelectedText = "DW";
		}

		// Token: 0x06000287 RID: 647 RVA: 0x000B8ED0 File Offset: 0x000B7ED0
		private void btnTextRE_Click(object sender, EventArgs e)
		{
			this.HightlightTextButton((Button)sender);
			this.SelectedText = "RE";
		}

		// Token: 0x06000288 RID: 648 RVA: 0x000B8EEC File Offset: 0x000B7EEC
		private void LoadLineTypeListBox()
		{
			SQLiteConnection sqliteConnection = new SQLiteConnection(this.ConnectionString);
			try
			{
				sqliteConnection.Open();
				SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM tbDrawing_LineTypes where visible = " + Conversions.ToString(1) + " order by LineOrder", sqliteConnection);
				SQLiteDataAdapter sqliteDataAdapter = new SQLiteDataAdapter(cmd);
				DataTable dataTable = new DataTable();
				sqliteDataAdapter.Fill(dataTable);
				try
				{
					foreach (object obj in dataTable.Rows)
					{
						DataRow dataRow = (DataRow)obj;
						LineTypeItem item = new LineTypeItem(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("(", dataRow["LineText"]), ") "), dataRow["LineType"])), Conversions.ToString(dataRow["LineText"]));
						this.LineTypes.Items.Add(item);
					}
				}
				finally
				{
					IEnumerator enumerator;
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
			finally
			{
				sqliteConnection.Close();
			}
		}

		// Token: 0x06000289 RID: 649 RVA: 0x000B9024 File Offset: 0x000B8024
		public frmDrawing()
		{
			base.Load += this.frmDrawing_Load;
			this.PathandFileName = string.Empty;
			this.ConnectionString = "Data Source=" + Application.StartupPath + "\\databases\\draw.db;Version=3;";
			this.ShapeColour = Color.Black;
			this.LineText = "NONE";
			this.SelectedText = string.Empty;
			this.DirectionText = string.Empty;
			this.SelectedLineStyle = GlobalVariables.LineStyle.Solid;
			this.PenWidth = 2;
			this.SelectedSymbol = "WaterChamber";
			this.isMoving = false;
			this.isActivelyDrawing = false;
			this.isResizing = false;
			this.PreviousToolButton = null;
			this.texture = new int[1];
			this.texturecount = 0;
			try
			{
				this.InitializeComponent();
				Config.Initialize(Application.StartupPath + "\\settings.dat");
				this.LoadLineTypeListBox();
				this.LoadSymbolList();
				this.LoadTemplates();
				this.DisplayNoOptions();
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x0600028A RID: 650 RVA: 0x000B913C File Offset: 0x000B813C
		private void LineTypes_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				LineTypeItem lineTypeItem = (LineTypeItem)this.LineTypes.SelectedItem;
				this.LineText = lineTypeItem.LineText;
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x0600028B RID: 651 RVA: 0x000B918C File Offset: 0x000B818C
		private void btnSaveTemplate_Click(object sender, EventArgs e)
		{
			try
			{
				if (Operators.CompareString(this.txtTemplateName.Text, string.Empty, false) != 0)
				{
					GlobalVariables.Canvas.DeselectAll();
					DrawingSurface canvas = GlobalVariables.Canvas;
					ToolStripTextBox txtTemplateName = this.txtTemplateName;
					string text = txtTemplateName.Text;
					canvas.SaveTemplateToDatabase(ref text);
					txtTemplateName.Text = text;
					this.txtTemplateName.Text = string.Empty;
					this.LoadTemplates();
				}
				else
				{
					Interaction.MsgBox("Please Enter a name for this Template", MsgBoxStyle.OkOnly, null);
				}
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x0600028C RID: 652 RVA: 0x000B9228 File Offset: 0x000B8228
		private void btnDeleteTemplate_Click(object sender, EventArgs e)
		{
			SQLiteConnection sqliteConnection = new SQLiteConnection(this.ConnectionString);
			try
			{
				if (Operators.CompareString(this.cbTemplates.Text, "", false) == 0)
				{
					Interaction.MsgBox("There is no template currently selected in the template selection  box, so no template can be deleted at this time.  Please select a template and try again.", MsgBoxStyle.Information, "CANNOT DELETE TEMPLATE");
				}
				else
				{
					short num = checked((short)Interaction.MsgBox("Please confirm that you would like to delete the template " + this.cbTemplates.Text + " from the database.  Once deleted templates are permanently removed.", MsgBoxStyle.OkCancel, "CONFIRM DELETION"));
					if (num != 2)
					{
						sqliteConnection.Open();
						SQLiteCommand sqliteCommand = new SQLiteCommand("Select ID from tbDrawing_Templates where name = '" + this.cbTemplates.Text + "'", sqliteConnection);
						long value = Conversions.ToLong(sqliteCommand.ExecuteScalar());
						SQLiteDataAdapter sqliteDataAdapter = new SQLiteDataAdapter("SELECT * FROM tbDrawing_TemplateShapes where ParentTemplate = " + Conversions.ToString(value), sqliteConnection);
						DataTable dataTable = new DataTable();
						sqliteDataAdapter.Fill(dataTable);
						try
						{
							foreach (object obj in dataTable.Rows)
							{
								DataRow dataRow = (DataRow)obj;
								SQLiteCommand sqliteCommand2 = new SQLiteCommand(Conversions.ToString(Operators.ConcatenateObject("Delete from tbDrawing_TemplateShapeCoords where ShapeIndex = ", dataRow["ShapeIndex"])), sqliteConnection);
								sqliteCommand2.ExecuteNonQuery();
								SQLiteCommand sqliteCommand3 = new SQLiteCommand(Conversions.ToString(Operators.ConcatenateObject("Delete from tbDrawing_TemplateShapes where ShapeIndex= ", dataRow["ShapeIndex"])), sqliteConnection);
								sqliteCommand3.ExecuteNonQuery();
							}
						}
						finally
						{
							IEnumerator enumerator;
							if (enumerator is IDisposable)
							{
								(enumerator as IDisposable).Dispose();
							}
						}
						SQLiteCommand sqliteCommand4 = new SQLiteCommand("Delete from tbDrawing_Templates were TemplateID=" + Conversions.ToString(value), sqliteConnection);
						sqliteCommand4.ExecuteNonQuery();
						this.LoadTemplates();
					}
				}
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
			finally
			{
				sqliteConnection.Close();
			}
		}

		// Token: 0x0600028D RID: 653 RVA: 0x000B9424 File Offset: 0x000B8424
		private void btnInsertTemplate_Click(object sender, EventArgs e)
		{
			try
			{
				if (!Information.IsNothing(RuntimeHelpers.GetObjectValue(this.cbTemplates.SelectedItem)))
				{
					GlobalVariables.Canvas.LoadTemplatefromDatabase(Conversions.ToLong(NewLateBinding.LateGet(this.cbTemplates.SelectedItem, null, "ID", new object[0], null, null, null)));
					GlobalVariables.Canvas.Draw();
				}
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x0600028E RID: 654 RVA: 0x000B94A8 File Offset: 0x000B84A8
		private void LoadTemplates()
		{
			SQLiteConnection sqliteConnection = new SQLiteConnection(this.ConnectionString);
			try
			{
				sqliteConnection.Open();
				SQLiteCommand cmd = new SQLiteCommand("SELECT DISTINCT tbDrawing_Templates.ID, tbDrawing_Templates.Name FROM tbDrawing_Templates ORDER BY tbDrawing_Templates.ID ASC", sqliteConnection);
				SQLiteDataAdapter sqliteDataAdapter = new SQLiteDataAdapter(cmd);
				DataTable dataTable = new DataTable();
				sqliteDataAdapter.Fill(dataTable);
				this.cbTemplates.Items.Clear();
				try
				{
					foreach (object obj in dataTable.Rows)
					{
						DataRow dataRow = (DataRow)obj;
						ComboItem comboItem = new ComboItem();
						comboItem.ID = Conversions.ToString(dataRow["ID"]);
						comboItem.name = Conversions.ToString(dataRow["Name"]);
						this.cbTemplates.Items.Add(comboItem);
					}
				}
				finally
				{
					IEnumerator enumerator;
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				this.cbTemplates.Text = "";
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
			finally
			{
				sqliteConnection.Close();
			}
		}

		// Token: 0x0600028F RID: 655 RVA: 0x000B95D8 File Offset: 0x000B85D8
		private void txtTemplateName_Enter(object sender, EventArgs e)
		{
			this.txtTemplateName.Text = string.Empty;
		}

		// Token: 0x06000290 RID: 656 RVA: 0x000B95EC File Offset: 0x000B85EC
		private void LoadSymbolList()
		{
			SQLiteConnection sqliteConnection = new SQLiteConnection(this.ConnectionString);
			checked
			{
				try
				{
					int num = 20;
					sqliteConnection.Open();
					SQLiteDataAdapter sqliteDataAdapter = new SQLiteDataAdapter("SELECT * FROM tbDrawing_Symbols where visible = " + Conversions.ToString(1) + " order by SymbolOrder", sqliteConnection);
					DataTable dataTable = new DataTable();
					sqliteDataAdapter.Fill(dataTable);
					Size size;
					try
					{
						foreach (object obj in dataTable.Rows)
						{
							DataRow dataRow = (DataRow)obj;
							Button button = new Button();
							string text = Conversions.ToString(Operators.ConcatenateObject(Application.StartupPath, dataRow["OffImageFilename"]));
							button.Name = Conversions.ToString(dataRow["Name"]);
							if (text.IndexOf(".ico") == -1)
							{
								button.Image = Image.FromFile(text);
							}
							else
							{
								Icon icon = new Icon(text);
								button.Image = icon.ToBitmap();
							}
							this.ToolTip1.SetToolTip(button, Conversions.ToString(dataRow["ToolTip"]));
							button.Tag = RuntimeHelpers.GetObjectValue(dataRow["Name"]);
							Control control = button;
							size = new Size(54, 29);
							control.Size = size;
							Control control2 = button;
							Point location = new Point(6, num);
							control2.Location = location;
							num += 32;
							this.frListOfInsertableSymbols.Controls.Add(button);
							button.Click += this.HandleSymbolButtonClickEvents;
						}
					}
					finally
					{
						IEnumerator enumerator;
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
					}
					Control frListOfInsertableSymbols = this.frListOfInsertableSymbols;
					size = new Size(72, num + 3);
					frListOfInsertableSymbols.Size = size;
				}
				catch (Exception ex)
				{
					ComPetersError.DisplayError(ex);
				}
				finally
				{
					sqliteConnection.Close();
				}
			}
		}

		// Token: 0x06000291 RID: 657 RVA: 0x000B97FC File Offset: 0x000B87FC
		private void HandleSymbolButtonClickEvents(object eventSender, EventArgs eventArgs)
		{
			SQLiteConnection sqliteConnection = new SQLiteConnection(this.ConnectionString);
			try
			{
				Button button = (Button)eventSender;
				button.BackColor = ColorTranslator.FromOle(-2147483635);
				string text = string.Empty;
				sqliteConnection.Open();
				try
				{
					foreach (object obj in this.frListOfInsertableSymbols.Controls)
					{
						Button button2 = (Button)obj;
						SQLiteCommand sqliteCommand = new SQLiteCommand("SELECT OffImageFilename FROM tbDrawing_Symbols where Name = '" + button2.Name + "'", sqliteConnection);
						text = Conversions.ToString(Operators.ConcatenateObject(Application.StartupPath, sqliteCommand.ExecuteScalar()));
						if (text.IndexOf(".ico") == -1)
						{
							button2.Image = Image.FromFile(text);
						}
						else
						{
							Icon icon = new Icon(text);
							button2.Image = icon.ToBitmap();
						}
						button2.BackColor = ColorTranslator.FromOle(-2147483633);
					}
				}
				finally
				{
					IEnumerator enumerator;
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				SQLiteCommand sqliteCommand2 = new SQLiteCommand("SELECT OnImageFilename FROM tbDrawing_Symbols where Name = '" + button.Name + "'", sqliteConnection);
				text = Conversions.ToString(Operators.ConcatenateObject(Application.StartupPath, sqliteCommand2.ExecuteScalar()));
				if (text.IndexOf(".ico") == -1)
				{
					button.Image = Image.FromFile(text);
				}
				else
				{
					Icon icon2 = new Icon(text);
					button.Image = icon2.ToBitmap();
				}
				this.SelectedSymbol = Conversions.ToString(button.Tag);
				this.Cursor = Cursors.Default;
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
			finally
			{
				sqliteConnection.Close();
			}
		}

		// Token: 0x06000292 RID: 658 RVA: 0x000B99E4 File Offset: 0x000B89E4
		private void cmdInsertImage_Click(object sender, EventArgs e)
		{
			try
			{
				frmImageCrop frmImageCrop = new frmImageCrop();
				frmImageCrop.ShowDialog();
				if (frmImageCrop.GetStatus == frmImageCrop.StatusType.imageCropped)
				{
					Image getCroppedImage = frmImageCrop.GetCroppedImage;
					ImageCodecInfo encoderInfo = this.GetEncoderInfo(ImageFormat.Jpeg);
					Encoder quality = Encoder.Quality;
					EncoderParameters encoderParameters = new EncoderParameters(1);
					EncoderParameter encoderParameter = new EncoderParameter(quality, 100L);
					encoderParameters.Param[0] = encoderParameter;
					getCroppedImage.Save(Application.StartupPath + "\\tmpCroppedImageFile.bmp", encoderInfo, encoderParameters);
					this.pgfStamp = new Stamp();
					Stamp stamp = this.pgfStamp;
					Point p = new Point(10, 10);
					stamp.Location = p;
					this.pgfStamp.ImageFile = Application.StartupPath + "\\tmpCroppedImageFile.bmp";
					GlobalVariables.Canvas.Add(this.pgfStamp);
					GlobalVariables.Canvas.Draw();
					this.pgfStamp.SelectThis();
					double num = 10.0;
					double num2 = 10.0;
					this.EndInsertedStamp(ref num, ref num2);
				}
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x06000293 RID: 659 RVA: 0x000B9B0C File Offset: 0x000B8B0C
		private void LoadDrawing(string sFilePath)
		{
			try
			{
				GlobalVariables.Canvas.LoadNativeFile(sFilePath);
				GlobalVariables.Canvas.Draw();
			}
			catch (Exception ex)
			{
				Interaction.MsgBox("Error in attempting to reload an existing drawing.  If the drawing existed, it was not loaded. Saving the document now will overright any previous drawing and erase any previous work\r\n" + Information.Err().Description, MsgBoxStyle.Critical, "ERROR LOADING DOCUMENT");
			}
		}

		// Token: 0x06000294 RID: 660 RVA: 0x000B9B70 File Offset: 0x000B8B70
		private void SaveDrawing(string sFilepath)
		{
			GlobalVariables.Canvas.drawingissaving = true;
			try
			{
				GlobalVariables.Canvas.DeselectAll();
				GlobalVariables.Canvas.Draw(0.0, 0.0);
				GlobalVariables.Canvas.Draw(0.0, 0.0);
				this.Cursor = Cursors.WaitCursor;
				try
				{
					foreach (object obj in GlobalVariables.UndoStack)
					{
						Undo undo = (Undo)obj;
						if (undo.operationType == GlobalVariables.DrawMode.Delete)
						{
							undo.DeleteShapes();
						}
					}
				}
				finally
				{
					IEnumerator enumerator;
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				GlobalVariables.Canvas.SaveNativeFile(sFilepath.Substring(0, sFilepath.LastIndexOf(".")) + ".u2");
				if (sFilepath.Contains(".jpg"))
				{
					this.Save(sFilepath);
				}
				else
				{
					this.Save(sFilepath + ".jpg");
				}
				this.bDrawingStarted = true;
				GlobalVariables.Canvas.drawingissaving = false;
				this.Cursor = Cursors.Cross;
			}
			catch (Exception ex)
			{
				Interaction.MsgBox("Error in attempting to save a drawing.  Save was not successful, existing now will result in the loss of any work completed on this drawing.\r\n" + Information.Err().Description, MsgBoxStyle.Critical, "ERROR LOADING DOCUMENT");
			}
			finally
			{
			}
		}

		// Token: 0x06000295 RID: 661 RVA: 0x000B9D08 File Offset: 0x000B8D08
		private void SetCanvasDimensions()
		{
			checked
			{
				try
				{
					int num = 667;
					int num2 = 648;
					if (this.dDrawScreenWidth > this.dDrawScreenHeight)
					{
						num2 = (int)Math.Round((double)(num * this.dDrawScreenHeight) / (double)this.dDrawScreenWidth);
					}
					else if (this.dDrawScreenWidth < this.dDrawScreenHeight)
					{
						num = (int)Math.Round((double)(num2 * this.dDrawScreenWidth) / (double)this.dDrawScreenHeight);
					}
					else
					{
						num2 = 628;
					}
					this.GlControl1.SetBounds(this.GlControl1.Location.X, this.GlControl1.Location.Y, num, num2);
				}
				catch (Exception ex)
				{
					ComPetersError.DisplayError(ex);
				}
			}
		}

		// Token: 0x06000296 RID: 662 RVA: 0x000B9DD4 File Offset: 0x000B8DD4
		private void frmDrawing_Load(object sender, EventArgs e)
		{
			SQLiteConnection sqliteConnection = new SQLiteConnection(this.ConnectionString);
			try
			{
				Config.Initialize(Application.StartupPath + "\\settings.dat");
				sqliteConnection.Open();
				SQLiteCommand sqliteCommand = new SQLiteCommand("Select count(InstallDate) from Trial", sqliteConnection);
				bool flag = Conversions.ToBoolean(sqliteCommand.ExecuteScalar());
				if (-(flag > false) > false)
				{
					SQLiteCommand sqliteCommand2 = new SQLiteCommand("Select 30+julianday(InstallDate) - julianday('now') as Days from Trial", sqliteConnection);
					int num = Conversions.ToInteger(sqliteCommand2.ExecuteScalar());
					if (num < 0)
					{
						Interaction.MsgBox("Trial Period has ended, Contact ComPeters Inc. 1-877-395-1122 to purchase", MsgBoxStyle.OkOnly, null);
						Application.Exit();
					}
					else
					{
						this.Text = this.Text + " -Trial " + Conversions.ToString(num) + " days remaining.  Call ComPeters Inc. to purchase 1-877-395-1122";
					}
				}
				else
				{
					SQLiteCommand sqliteCommand3 = new SQLiteCommand("Insert into Trial (InstallDate) values (date('now'))", sqliteConnection);
					sqliteCommand3.ExecuteNonQuery();
					this.Text += " -Trial 30 days remaining.  Call ComPeters Inc. to purchase 1-877-395-1122";
				}
				this.Init();
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
			finally
			{
				sqliteConnection.Close();
			}
		}

		// Token: 0x06000297 RID: 663 RVA: 0x000B9EE8 File Offset: 0x000B8EE8
		private void btnFileSaveAs_Click(object sender, EventArgs e)
		{
			try
			{
				if (this.SaveFileDialog1.ShowDialog() == DialogResult.OK)
				{
					this.PathandFileName = this.SaveFileDialog1.FileName;
					this.SaveDrawing(this.PathandFileName);
					this.bDrawingFinished = true;
				}
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x06000298 RID: 664 RVA: 0x000B9F50 File Offset: 0x000B8F50
		private void btnPrint_Click(object sender, EventArgs e)
		{
			try
			{
				if (this.PrintDialog1.ShowDialog() == DialogResult.OK)
				{
					PrintDocument printDocument = new PrintDocument();
					this.PrintDocument1.Print();
				}
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x06000299 RID: 665 RVA: 0x000B9FA4 File Offset: 0x000B8FA4
		private void PrintDocument1_PrintPage(object sender, PrintPageEventArgs e)
		{
			try
			{
				e.Graphics.DrawImage(this.GrabScreenshot(), 0, 0);
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x0600029A RID: 666 RVA: 0x000B9FEC File Offset: 0x000B8FEC
		private void btnFileSave_Click(object sender, EventArgs e)
		{
			try
			{
				if (Operators.CompareString(this.PathandFileName, string.Empty, false) == 0)
				{
					this.btnFileSaveAs_Click(RuntimeHelpers.GetObjectValue(sender), e);
				}
				else
				{
					this.SaveDrawing(this.PathandFileName);
				}
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x0600029B RID: 667 RVA: 0x000BA050 File Offset: 0x000B9050
		private void ToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			try
			{
				this.PathandFileName = string.Empty;
				GlobalVariables.Canvas.Clear();
				GlobalVariables.Canvas.Draw();
				GlobalVariables.UndoStack.Clear();
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x0600029C RID: 668 RVA: 0x000BA0AC File Offset: 0x000B90AC
		private void CloseToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			try
			{
				if (GlobalVariables.SavableChanges)
				{
					MsgBoxResult msgBoxResult = Interaction.MsgBox("There are unsaved changes, save file", MsgBoxStyle.YesNoCancel, "Unsaved Changes");
					if (msgBoxResult == MsgBoxResult.Yes)
					{
						this.btnFileSave_Click(RuntimeHelpers.GetObjectValue(sender), e);
					}
					else if (msgBoxResult == MsgBoxResult.No)
					{
						this.PathandFileName = string.Empty;
						GlobalVariables.Canvas.Clear();
						GlobalVariables.Canvas.Draw();
						GlobalVariables.UndoStack.Clear();
					}
				}
				else
				{
					this.PathandFileName = string.Empty;
					GlobalVariables.Canvas.Clear();
					GlobalVariables.Canvas.Draw();
					GlobalVariables.UndoStack.Clear();
				}
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x0600029D RID: 669 RVA: 0x000BA164 File Offset: 0x000B9164
		private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				if (GlobalVariables.SavableChanges)
				{
					MsgBoxResult msgBoxResult = Interaction.MsgBox("There are unsaved changes, save file", MsgBoxStyle.YesNoCancel, "Unsaved Changes");
					if (msgBoxResult == MsgBoxResult.Yes)
					{
						this.btnFileSave_Click(RuntimeHelpers.GetObjectValue(sender), e);
					}
					else if (msgBoxResult == MsgBoxResult.No)
					{
						Application.Exit();
					}
				}
				else
				{
					Application.Exit();
				}
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x0600029E RID: 670 RVA: 0x000BA1D4 File Offset: 0x000B91D4
		private void btnFileOpen_Click(object sender, EventArgs e)
		{
			try
			{
				if (this.OpenFileDialog3.ShowDialog() == DialogResult.OK && File.Exists(this.OpenFileDialog3.FileName.Substring(0, this.OpenFileDialog3.FileName.LastIndexOf(".")) + ".u2"))
				{
					this.PathandFileName = this.OpenFileDialog3.FileName;
					GlobalVariables.Canvas.Clear();
					GlobalVariables.Canvas.Draw();
					GlobalVariables.UndoStack.Clear();
					this.LoadDrawing(this.OpenFileDialog3.FileName.Substring(0, this.OpenFileDialog3.FileName.LastIndexOf(".")) + ".u2");
				}
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x040000A1 RID: 161
		[AccessedThroughProperty("GlControl1")]
		private GLControl _GlControl1;

		// Token: 0x040000A2 RID: 162
		[AccessedThroughProperty("btnStraightLine")]
		private Button _btnStraightLine;

		// Token: 0x040000A3 RID: 163
		[AccessedThroughProperty("btnFreeDrawing")]
		private Button _btnFreeDrawing;

		// Token: 0x040000A4 RID: 164
		[AccessedThroughProperty("btnAngledLines")]
		private Button _btnAngledLines;

		// Token: 0x040000A5 RID: 165
		[AccessedThroughProperty("btnMeasuringLines")]
		private Button _btnMeasuringLines;

		// Token: 0x040000A6 RID: 166
		[AccessedThroughProperty("btnArrows")]
		private Button _btnArrows;

		// Token: 0x040000A7 RID: 167
		[AccessedThroughProperty("btnRectangle")]
		private Button _btnRectangle;

		// Token: 0x040000A8 RID: 168
		[AccessedThroughProperty("btnEllipse")]
		private Button _btnEllipse;

		// Token: 0x040000A9 RID: 169
		[AccessedThroughProperty("btnArc")]
		private Button _btnArc;

		// Token: 0x040000AA RID: 170
		[AccessedThroughProperty("btnext")]
		private Button _btnext;

		// Token: 0x040000AB RID: 171
		[AccessedThroughProperty("txtDrawText")]
		private TextBox _txtDrawText;

		// Token: 0x040000AC RID: 172
		[AccessedThroughProperty("btnStamps")]
		private Button _btnStamps;

		// Token: 0x040000AD RID: 173
		[AccessedThroughProperty("btnSelect")]
		private Button _btnSelect;

		// Token: 0x040000AE RID: 174
		[AccessedThroughProperty("btnDelete")]
		private Button _btnDelete;

		// Token: 0x040000AF RID: 175
		[AccessedThroughProperty("btnMove")]
		private Button _btnMove;

		// Token: 0x040000B0 RID: 176
		[AccessedThroughProperty("btnRotate")]
		private Button _btnRotate;

		// Token: 0x040000B1 RID: 177
		[AccessedThroughProperty("btnEraseScreen")]
		private Button _btnEraseScreen;

		// Token: 0x040000B2 RID: 178
		[AccessedThroughProperty("btnSymbol")]
		private Button _btnSymbol;

		// Token: 0x040000B3 RID: 179
		[AccessedThroughProperty("btnNorthSymbol")]
		private Button _btnNorthSymbol;

		// Token: 0x040000B4 RID: 180
		[AccessedThroughProperty("btnGrid")]
		private Button _btnGrid;

		// Token: 0x040000B5 RID: 181
		[AccessedThroughProperty("btnCopy")]
		private Button _btnCopy;

		// Token: 0x040000B6 RID: 182
		[AccessedThroughProperty("btnPaste")]
		private Button _btnPaste;

		// Token: 0x040000B7 RID: 183
		[AccessedThroughProperty("btnUndo")]
		private Button _btnUndo;

		// Token: 0x040000B8 RID: 184
		[AccessedThroughProperty("cmdInsertImage")]
		private Button _cmdInsertImage;

		// Token: 0x040000B9 RID: 185
		[AccessedThroughProperty("frSize")]
		private GroupBox _frSize;

		// Token: 0x040000BA RID: 186
		[AccessedThroughProperty("btnSize2")]
		private Button _btnSize2;

		// Token: 0x040000BB RID: 187
		[AccessedThroughProperty("btnSize4")]
		private Button _btnSize4;

		// Token: 0x040000BC RID: 188
		[AccessedThroughProperty("btnSize3")]
		private Button _btnSize3;

		// Token: 0x040000BD RID: 189
		[AccessedThroughProperty("btnSize1")]
		private Button _btnSize1;

		// Token: 0x040000BE RID: 190
		[AccessedThroughProperty("fraLineStyle")]
		private GroupBox _fraLineStyle;

		// Token: 0x040000BF RID: 191
		[AccessedThroughProperty("btnSolid")]
		private Button _btnSolid;

		// Token: 0x040000C0 RID: 192
		[AccessedThroughProperty("btnDash")]
		private Button _btnDash;

		// Token: 0x040000C1 RID: 193
		[AccessedThroughProperty("frDirection")]
		private GroupBox _frDirection;

		// Token: 0x040000C2 RID: 194
		[AccessedThroughProperty("btnDirectionNone")]
		private Button _btnDirectionNone;

		// Token: 0x040000C3 RID: 195
		[AccessedThroughProperty("btnDirectionNorth")]
		private Button _btnDirectionNorth;

		// Token: 0x040000C4 RID: 196
		[AccessedThroughProperty("btnDirectionEast")]
		private Button _btnDirectionEast;

		// Token: 0x040000C5 RID: 197
		[AccessedThroughProperty("btnDirectionSouth")]
		private Button _btnDirectionSouth;

		// Token: 0x040000C6 RID: 198
		[AccessedThroughProperty("btnDirectionWest")]
		private Button _btnDirectionWest;

		// Token: 0x040000C7 RID: 199
		[AccessedThroughProperty("frInsertableTextPhrases")]
		private GroupBox _frInsertableTextPhrases;

		// Token: 0x040000C8 RID: 200
		[AccessedThroughProperty("btnTextRE")]
		private Button _btnTextRE;

		// Token: 0x040000C9 RID: 201
		[AccessedThroughProperty("btnTextDW")]
		private Button _btnTextDW;

		// Token: 0x040000CA RID: 202
		[AccessedThroughProperty("btnTextBL")]
		private Button _btnTextBL;

		// Token: 0x040000CB RID: 203
		[AccessedThroughProperty("btnTextFL")]
		private Button _btnTextFL;

		// Token: 0x040000CC RID: 204
		[AccessedThroughProperty("btnTextPL")]
		private Button _btnTextPL;

		// Token: 0x040000CD RID: 205
		[AccessedThroughProperty("btnTextSW")]
		private Button _btnTextSW;

		// Token: 0x040000CE RID: 206
		[AccessedThroughProperty("btnTextCL")]
		private Button _btnTextCL;

		// Token: 0x040000CF RID: 207
		[AccessedThroughProperty("btnTextLA")]
		private Button _btnTextLA;

		// Token: 0x040000D0 RID: 208
		[AccessedThroughProperty("btnTextNone")]
		private Button _btnTextNone;

		// Token: 0x040000D1 RID: 209
		[AccessedThroughProperty("frListOfInsertableSymbols")]
		private GroupBox _frListOfInsertableSymbols;

		// Token: 0x040000D2 RID: 210
		[AccessedThroughProperty("LineTypes")]
		private ListBox _LineTypes;

		// Token: 0x040000D3 RID: 211
		[AccessedThroughProperty("ToolTip1")]
		private ToolTip _ToolTip1;

		// Token: 0x040000D4 RID: 212
		[AccessedThroughProperty("btnResize")]
		private Button _btnResize;

		// Token: 0x040000D5 RID: 213
		[AccessedThroughProperty("OpenFileDialog1")]
		private OpenFileDialog _OpenFileDialog1;

		// Token: 0x040000D6 RID: 214
		[AccessedThroughProperty("Tools")]
		private GroupBox _Tools;

		// Token: 0x040000D7 RID: 215
		[AccessedThroughProperty("ToolStrip1")]
		private ToolStrip _ToolStrip1;

		// Token: 0x040000D8 RID: 216
		[AccessedThroughProperty("ToolStripDropDownButton1")]
		private ToolStripDropDownButton _ToolStripDropDownButton1;

		// Token: 0x040000D9 RID: 217
		[AccessedThroughProperty("btnFileOpen")]
		private ToolStripMenuItem _btnFileOpen;

		// Token: 0x040000DA RID: 218
		[AccessedThroughProperty("btnFileSave")]
		private ToolStripMenuItem _btnFileSave;

		// Token: 0x040000DB RID: 219
		[AccessedThroughProperty("btnFileSaveAs")]
		private ToolStripMenuItem _btnFileSaveAs;

		// Token: 0x040000DC RID: 220
		[AccessedThroughProperty("CloseToolStripMenuItem")]
		private ToolStripMenuItem _CloseToolStripMenuItem;

		// Token: 0x040000DD RID: 221
		[AccessedThroughProperty("ToolStripLabel1")]
		private ToolStripLabel _ToolStripLabel1;

		// Token: 0x040000DE RID: 222
		[AccessedThroughProperty("cbTemplates")]
		private ToolStripComboBox _cbTemplates;

		// Token: 0x040000DF RID: 223
		[AccessedThroughProperty("ToolStripSeparator1")]
		private ToolStripSeparator _ToolStripSeparator1;

		// Token: 0x040000E0 RID: 224
		[AccessedThroughProperty("ToolStripLabel2")]
		private ToolStripLabel _ToolStripLabel2;

		// Token: 0x040000E1 RID: 225
		[AccessedThroughProperty("txtTemplateName")]
		private ToolStripTextBox _txtTemplateName;

		// Token: 0x040000E2 RID: 226
		[AccessedThroughProperty("btnInsertTemplate")]
		private ToolStripButton _btnInsertTemplate;

		// Token: 0x040000E3 RID: 227
		[AccessedThroughProperty("btnDeleteTemplate")]
		private ToolStripButton _btnDeleteTemplate;

		// Token: 0x040000E4 RID: 228
		[AccessedThroughProperty("btnSaveTemplate")]
		private ToolStripButton _btnSaveTemplate;

		// Token: 0x040000E5 RID: 229
		[AccessedThroughProperty("SaveFileDialog1")]
		private SaveFileDialog _SaveFileDialog1;

		// Token: 0x040000E6 RID: 230
		[AccessedThroughProperty("ToolStripSeparator2")]
		private ToolStripSeparator _ToolStripSeparator2;

		// Token: 0x040000E7 RID: 231
		[AccessedThroughProperty("ToolStripSeparator3")]
		private ToolStripSeparator _ToolStripSeparator3;

		// Token: 0x040000E8 RID: 232
		[AccessedThroughProperty("ToolStripSeparator4")]
		private ToolStripSeparator _ToolStripSeparator4;

		// Token: 0x040000E9 RID: 233
		[AccessedThroughProperty("ExitToolStripMenuItem")]
		private ToolStripMenuItem _ExitToolStripMenuItem;

		// Token: 0x040000EA RID: 234
		[AccessedThroughProperty("ToolStripSeparator5")]
		private ToolStripSeparator _ToolStripSeparator5;

		// Token: 0x040000EB RID: 235
		[AccessedThroughProperty("btnPrint")]
		private ToolStripMenuItem _btnPrint;

		// Token: 0x040000EC RID: 236
		[AccessedThroughProperty("PrintDialog1")]
		private PrintDialog _PrintDialog1;

		// Token: 0x040000ED RID: 237
		[AccessedThroughProperty("PrintDocument1")]
		private PrintDocument _PrintDocument1;

		// Token: 0x040000EE RID: 238
		[AccessedThroughProperty("ToolStripMenuItem1")]
		private ToolStripMenuItem _ToolStripMenuItem1;

		// Token: 0x040000EF RID: 239
		[AccessedThroughProperty("OpenFileDialog3")]
		private OpenFileDialog _OpenFileDialog3;

		// Token: 0x040000F0 RID: 240
		private static frmDrawing myInstance;

		// Token: 0x040000F1 RID: 241
		private const double MEASURELINELENGTH = 50.0;

		// Token: 0x040000F2 RID: 242
		private const int MINTEXTBOXSIZE = 100;

		// Token: 0x040000F3 RID: 243
		private const double NORTHRADIANSANGLE = 0.2617993877991494;

		// Token: 0x040000F4 RID: 244
		private const int HIGHLIGHTEDBUTTONCOLOUR = -2147483635;

		// Token: 0x040000F5 RID: 245
		private const int SYMBOLLINETHICKNESS = 2;

		// Token: 0x040000F6 RID: 246
		private const int DEFAULTBUTTONCOLOUR = -2147483633;

		// Token: 0x040000F7 RID: 247
		private string PathandFileName;

		// Token: 0x040000F8 RID: 248
		public string ConnectionString;

		// Token: 0x040000F9 RID: 249
		private Line pgfLine;

		// Token: 0x040000FA RID: 250
		private Rectangle pgfRect;

		// Token: 0x040000FB RID: 251
		private Line pgfMeasureLine1;

		// Token: 0x040000FC RID: 252
		private Line pgfMeasureLine2;

		// Token: 0x040000FD RID: 253
		private Triangle pgfTriangle1;

		// Token: 0x040000FE RID: 254
		private Triangle pgftriangle2;

		// Token: 0x040000FF RID: 255
		private Triangle pgfTriangle;

		// Token: 0x04000100 RID: 256
		private Ellipse pgfEllipse;

		// Token: 0x04000101 RID: 257
		private Arc pgfArc;

		// Token: 0x04000102 RID: 258
		private Text pgfText;

		// Token: 0x04000103 RID: 259
		private Stamp pgfStamp;

		// Token: 0x04000104 RID: 260
		private ShapeGroup pgfGroup;

		// Token: 0x04000105 RID: 261
		private ShapeGroup pgfGroup2;

		// Token: 0x04000106 RID: 262
		private Line pgfLine2;

		// Token: 0x04000107 RID: 263
		private Line pgfLine3;

		// Token: 0x04000108 RID: 264
		private Line pgfRotatePositionLine;

		// Token: 0x04000109 RID: 265
		private IShape pgfShape;

		// Token: 0x0400010A RID: 266
		private PointF BeginMove;

		// Token: 0x0400010B RID: 267
		private Color ShapeColour;

		// Token: 0x0400010C RID: 268
		private string LineText;

		// Token: 0x0400010D RID: 269
		private GlobalVariables.TextMode SelectedTextMode;

		// Token: 0x0400010E RID: 270
		private string SelectedText;

		// Token: 0x0400010F RID: 271
		private string DirectionText;

		// Token: 0x04000110 RID: 272
		private GlobalVariables.LineStyle SelectedLineStyle;

		// Token: 0x04000111 RID: 273
		private int PenWidth;

		// Token: 0x04000112 RID: 274
		private double InitialRotateAngle;

		// Token: 0x04000113 RID: 275
		private string SelectedSymbol;

		// Token: 0x04000114 RID: 276
		private bool isMoving;

		// Token: 0x04000115 RID: 277
		private bool isActivelyDrawing;

		// Token: 0x04000116 RID: 278
		private bool isResizing;

		// Token: 0x04000117 RID: 279
		private Button PreviousToolButton;

		// Token: 0x04000118 RID: 280
		private int drawingType;

		// Token: 0x04000119 RID: 281
		private int dDrawScreenWidth;

		// Token: 0x0400011A RID: 282
		private int dDrawScreenHeight;

		// Token: 0x0400011B RID: 283
		private double dDrawingAspectRatio;

		// Token: 0x0400011C RID: 284
		private bool bDrawingStarted;

		// Token: 0x0400011D RID: 285
		private bool bDrawingFinished;

		// Token: 0x0400011E RID: 286
		private bool bDrawingDeleted;

		// Token: 0x0400011F RID: 287
		private int[] texture;

		// Token: 0x04000120 RID: 288
		private int texturecount;
	}
}
