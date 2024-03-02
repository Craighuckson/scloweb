using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ComPeters;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.Compatibility.VB6;
using Microsoft.VisualBasic.CompilerServices;
using U2Drawx64.My.Resources;

namespace U2Drawx64
{
	// Token: 0x0200000C RID: 12
	internal partial class frmOptions : Form
	{
		// Token: 0x06000070 RID: 112 RVA: 0x0009D308 File Offset: 0x0009C308
		public frmOptions()
		{
			base.Load += this.frmOptions_Load;
			if (frmOptions.m_vb6FormDefInstance == null)
			{
				if (frmOptions.m_InitializingDefInstance)
				{
					frmOptions.m_vb6FormDefInstance = this;
				}
				else
				{
					try
					{
						if (Assembly.GetExecutingAssembly().EntryPoint.DeclaringType == this.GetType())
						{
							frmOptions.m_vb6FormDefInstance = this;
						}
					}
					catch (Exception ex)
					{
					}
				}
			}
			this.InitializeComponent();
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000072 RID: 114 RVA: 0x0009D3A8 File Offset: 0x0009C3A8
		// (set) Token: 0x06000073 RID: 115 RVA: 0x0009D3BC File Offset: 0x0009C3BC
		public virtual Label lblUtiLocateOptions_DBLocation
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblUtiLocateOptions_DBLocation;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblUtiLocateOptions_DBLocation = value;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000074 RID: 116 RVA: 0x0009D3C8 File Offset: 0x0009C3C8
		// (set) Token: 0x06000075 RID: 117 RVA: 0x0009D3DC File Offset: 0x0009C3DC
		public virtual GroupBox fraDBLocations_1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._fraDBLocations_1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._fraDBLocations_1 = value;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000076 RID: 118 RVA: 0x0009D3E8 File Offset: 0x0009C3E8
		// (set) Token: 0x06000077 RID: 119 RVA: 0x0009D3FC File Offset: 0x0009C3FC
		public virtual Button _cmdSelectFile_0
		{
			[DebuggerNonUserCode]
			get
			{
				return this.__cmdSelectFile_0;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.__cmdSelectFile_0 = value;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000078 RID: 120 RVA: 0x0009D408 File Offset: 0x0009C408
		// (set) Token: 0x06000079 RID: 121 RVA: 0x0009D41C File Offset: 0x0009C41C
		public virtual Label lblUtiLocateOptions_Filename
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblUtiLocateOptions_Filename;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblUtiLocateOptions_Filename = value;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600007A RID: 122 RVA: 0x0009D428 File Offset: 0x0009C428
		// (set) Token: 0x0600007B RID: 123 RVA: 0x0009D43C File Offset: 0x0009C43C
		public virtual GroupBox fraDBLocations_0
		{
			[DebuggerNonUserCode]
			get
			{
				return this._fraDBLocations_0;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._fraDBLocations_0 = value;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600007C RID: 124 RVA: 0x0009D448 File Offset: 0x0009C448
		// (set) Token: 0x0600007D RID: 125 RVA: 0x0009D45C File Offset: 0x0009C45C
		public virtual TabPage _SSTab1_TabPage0
		{
			[DebuggerNonUserCode]
			get
			{
				return this.__SSTab1_TabPage0;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.__SSTab1_TabPage0 = value;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x0600007E RID: 126 RVA: 0x0009D468 File Offset: 0x0009C468
		// (set) Token: 0x0600007F RID: 127 RVA: 0x0009D47C File Offset: 0x0009C47C
		public virtual Label lblReportOptions_ColourPrinting_Allow
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblReportOptions_ColourPrinting_Allow;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblReportOptions_ColourPrinting_Allow = value;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000080 RID: 128 RVA: 0x0009D488 File Offset: 0x0009C488
		// (set) Token: 0x06000081 RID: 129 RVA: 0x0009D49C File Offset: 0x0009C49C
		public virtual RadioButton _obAllowColourPrinting_1
		{
			[DebuggerNonUserCode]
			get
			{
				return this.__obAllowColourPrinting_1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.__obAllowColourPrinting_1 = value;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000082 RID: 130 RVA: 0x0009D4A8 File Offset: 0x0009C4A8
		// (set) Token: 0x06000083 RID: 131 RVA: 0x0009D4BC File Offset: 0x0009C4BC
		public virtual RadioButton _obAllowColourPrinting_0
		{
			[DebuggerNonUserCode]
			get
			{
				return this.__obAllowColourPrinting_0;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.__obAllowColourPrinting_0 = value;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000084 RID: 132 RVA: 0x0009D4C8 File Offset: 0x0009C4C8
		// (set) Token: 0x06000085 RID: 133 RVA: 0x0009D4DC File Offset: 0x0009C4DC
		public virtual GroupBox lblReportOptions_ColourPrinting
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblReportOptions_ColourPrinting;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblReportOptions_ColourPrinting = value;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000086 RID: 134 RVA: 0x0009D4E8 File Offset: 0x0009C4E8
		// (set) Token: 0x06000087 RID: 135 RVA: 0x0009D4FC File Offset: 0x0009C4FC
		public virtual TextBox txtPrimaryReportImageHeight
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtPrimaryReportImageHeight;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				if (this._txtPrimaryReportImageHeight != null)
				{
					this._txtPrimaryReportImageHeight.KeyPress -= this.txtPrimaryReportImageHeight_KeyPress;
				}
				this._txtPrimaryReportImageHeight = value;
				if (this._txtPrimaryReportImageHeight != null)
				{
					this._txtPrimaryReportImageHeight.KeyPress += this.txtPrimaryReportImageHeight_KeyPress;
				}
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000088 RID: 136 RVA: 0x0009D550 File Offset: 0x0009C550
		// (set) Token: 0x06000089 RID: 137 RVA: 0x0009D564 File Offset: 0x0009C564
		public virtual TextBox txtPrimaryReportImageWidth
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtPrimaryReportImageWidth;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				if (this._txtPrimaryReportImageWidth != null)
				{
					this._txtPrimaryReportImageWidth.KeyPress -= this.txtPrimaryReportImageWidth_KeyPress;
				}
				this._txtPrimaryReportImageWidth = value;
				if (this._txtPrimaryReportImageWidth != null)
				{
					this._txtPrimaryReportImageWidth.KeyPress += this.txtPrimaryReportImageWidth_KeyPress;
				}
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x0600008A RID: 138 RVA: 0x0009D5B8 File Offset: 0x0009C5B8
		// (set) Token: 0x0600008B RID: 139 RVA: 0x0009D5CC File Offset: 0x0009C5CC
		public virtual Label lblReportOptions_ValuesInMM
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblReportOptions_ValuesInMM;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblReportOptions_ValuesInMM = value;
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x0600008C RID: 140 RVA: 0x0009D5D8 File Offset: 0x0009C5D8
		// (set) Token: 0x0600008D RID: 141 RVA: 0x0009D5EC File Offset: 0x0009C5EC
		public virtual Label lblReportOptions_ImageHeight
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblReportOptions_ImageHeight;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblReportOptions_ImageHeight = value;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x0600008E RID: 142 RVA: 0x0009D5F8 File Offset: 0x0009C5F8
		// (set) Token: 0x0600008F RID: 143 RVA: 0x0009D60C File Offset: 0x0009C60C
		public virtual Label lblReportOptions_ImageWidth
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblReportOptions_ImageWidth;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblReportOptions_ImageWidth = value;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000090 RID: 144 RVA: 0x0009D618 File Offset: 0x0009C618
		// (set) Token: 0x06000091 RID: 145 RVA: 0x0009D62C File Offset: 0x0009C62C
		public virtual Label lblReportOptions_ImageSize
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblReportOptions_ImageSize;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblReportOptions_ImageSize = value;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000092 RID: 146 RVA: 0x0009D638 File Offset: 0x0009C638
		// (set) Token: 0x06000093 RID: 147 RVA: 0x0009D64C File Offset: 0x0009C64C
		public virtual Label lblReportOptions_PrimaryReport
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblReportOptions_PrimaryReport;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblReportOptions_PrimaryReport = value;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000094 RID: 148 RVA: 0x0009D658 File Offset: 0x0009C658
		// (set) Token: 0x06000095 RID: 149 RVA: 0x0009D66C File Offset: 0x0009C66C
		public virtual GroupBox lblReportOptions_PrimaryReportOptions
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblReportOptions_PrimaryReportOptions;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblReportOptions_PrimaryReportOptions = value;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000096 RID: 150 RVA: 0x0009D678 File Offset: 0x0009C678
		// (set) Token: 0x06000097 RID: 151 RVA: 0x0009D68C File Offset: 0x0009C68C
		public virtual TextBox txtAuxilaryReportImageHeight
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtAuxilaryReportImageHeight;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				if (this._txtAuxilaryReportImageHeight != null)
				{
					this._txtAuxilaryReportImageHeight.KeyPress -= this.txtAuxilaryReportImageHeight_KeyPress;
				}
				this._txtAuxilaryReportImageHeight = value;
				if (this._txtAuxilaryReportImageHeight != null)
				{
					this._txtAuxilaryReportImageHeight.KeyPress += this.txtAuxilaryReportImageHeight_KeyPress;
				}
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000098 RID: 152 RVA: 0x0009D6E0 File Offset: 0x0009C6E0
		// (set) Token: 0x06000099 RID: 153 RVA: 0x0009D6F4 File Offset: 0x0009C6F4
		public virtual TextBox txtAuxilaryReportImageWidth
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtAuxilaryReportImageWidth;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				if (this._txtAuxilaryReportImageWidth != null)
				{
					this._txtAuxilaryReportImageWidth.KeyPress -= this.txtAuxilaryReportImageWidth_KeyPress;
				}
				this._txtAuxilaryReportImageWidth = value;
				if (this._txtAuxilaryReportImageWidth != null)
				{
					this._txtAuxilaryReportImageWidth.KeyPress += this.txtAuxilaryReportImageWidth_KeyPress;
				}
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x0600009A RID: 154 RVA: 0x0009D748 File Offset: 0x0009C748
		// (set) Token: 0x0600009B RID: 155 RVA: 0x0009D75C File Offset: 0x0009C75C
		public virtual Label lblReportOptions_ValuesInMM1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblReportOptions_ValuesInMM1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblReportOptions_ValuesInMM1 = value;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x0600009C RID: 156 RVA: 0x0009D768 File Offset: 0x0009C768
		// (set) Token: 0x0600009D RID: 157 RVA: 0x0009D77C File Offset: 0x0009C77C
		public virtual Label lblReportOptions_Height1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblReportOptions_Height1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblReportOptions_Height1 = value;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x0600009E RID: 158 RVA: 0x0009D788 File Offset: 0x0009C788
		// (set) Token: 0x0600009F RID: 159 RVA: 0x0009D79C File Offset: 0x0009C79C
		public virtual Label lblReportOptions_Width1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblReportOptions_Width1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblReportOptions_Width1 = value;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x0009D7A8 File Offset: 0x0009C7A8
		// (set) Token: 0x060000A1 RID: 161 RVA: 0x0009D7BC File Offset: 0x0009C7BC
		public virtual Label lblReportOptions_ImageSize1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblReportOptions_ImageSize1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblReportOptions_ImageSize1 = value;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000A2 RID: 162 RVA: 0x0009D7C8 File Offset: 0x0009C7C8
		// (set) Token: 0x060000A3 RID: 163 RVA: 0x0009D7DC File Offset: 0x0009C7DC
		public virtual Label lblReportOptions_Report
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblReportOptions_Report;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblReportOptions_Report = value;
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000A4 RID: 164 RVA: 0x0009D7E8 File Offset: 0x0009C7E8
		// (set) Token: 0x060000A5 RID: 165 RVA: 0x0009D7FC File Offset: 0x0009C7FC
		public virtual GroupBox lblReportOptions_AuxReportOption
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblReportOptions_AuxReportOption;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblReportOptions_AuxReportOption = value;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000A6 RID: 166 RVA: 0x0009D808 File Offset: 0x0009C808
		// (set) Token: 0x060000A7 RID: 167 RVA: 0x0009D81C File Offset: 0x0009C81C
		public virtual TabPage _SSTab1_TabPage1
		{
			[DebuggerNonUserCode]
			get
			{
				return this.__SSTab1_TabPage1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.__SSTab1_TabPage1 = value;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000A8 RID: 168 RVA: 0x0009D828 File Offset: 0x0009C828
		// (set) Token: 0x060000A9 RID: 169 RVA: 0x0009D83C File Offset: 0x0009C83C
		public virtual TabControl lblUtiLocateOptions
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblUtiLocateOptions;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblUtiLocateOptions = value;
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000AA RID: 170 RVA: 0x0009D848 File Offset: 0x0009C848
		// (set) Token: 0x060000AB RID: 171 RVA: 0x0009D85C File Offset: 0x0009C85C
		public virtual GroupBox fraSample4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._fraSample4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._fraSample4 = value;
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000AC RID: 172 RVA: 0x0009D868 File Offset: 0x0009C868
		// (set) Token: 0x060000AD RID: 173 RVA: 0x0009D87C File Offset: 0x0009C87C
		public virtual Panel _picOptions_3
		{
			[DebuggerNonUserCode]
			get
			{
				return this.__picOptions_3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.__picOptions_3 = value;
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000AE RID: 174 RVA: 0x0009D888 File Offset: 0x0009C888
		// (set) Token: 0x060000AF RID: 175 RVA: 0x0009D89C File Offset: 0x0009C89C
		public virtual GroupBox fraSample3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._fraSample3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._fraSample3 = value;
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000B0 RID: 176 RVA: 0x0009D8A8 File Offset: 0x0009C8A8
		// (set) Token: 0x060000B1 RID: 177 RVA: 0x0009D8BC File Offset: 0x0009C8BC
		public virtual Panel _picOptions_2
		{
			[DebuggerNonUserCode]
			get
			{
				return this.__picOptions_2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.__picOptions_2 = value;
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000B2 RID: 178 RVA: 0x0009D8C8 File Offset: 0x0009C8C8
		// (set) Token: 0x060000B3 RID: 179 RVA: 0x0009D8DC File Offset: 0x0009C8DC
		public virtual GroupBox fraSample2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._fraSample2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._fraSample2 = value;
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000B4 RID: 180 RVA: 0x0009D8E8 File Offset: 0x0009C8E8
		// (set) Token: 0x060000B5 RID: 181 RVA: 0x0009D8FC File Offset: 0x0009C8FC
		public virtual Panel _picOptions_1
		{
			[DebuggerNonUserCode]
			get
			{
				return this.__picOptions_1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.__picOptions_1 = value;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000B6 RID: 182 RVA: 0x0009D908 File Offset: 0x0009C908
		// (set) Token: 0x060000B7 RID: 183 RVA: 0x0009D91C File Offset: 0x0009C91C
		public virtual Button cmdApply
		{
			[DebuggerNonUserCode]
			get
			{
				return this._cmdApply;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				if (this._cmdApply != null)
				{
					this._cmdApply.Click -= this.cmdApply_Click;
				}
				this._cmdApply = value;
				if (this._cmdApply != null)
				{
					this._cmdApply.Click += this.cmdApply_Click;
				}
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000B8 RID: 184 RVA: 0x0009D970 File Offset: 0x0009C970
		// (set) Token: 0x060000B9 RID: 185 RVA: 0x0009D984 File Offset: 0x0009C984
		public virtual Button cmdCancel
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

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000BA RID: 186 RVA: 0x0009D9D8 File Offset: 0x0009C9D8
		// (set) Token: 0x060000BB RID: 187 RVA: 0x0009D9EC File Offset: 0x0009C9EC
		public virtual Button cmdOK
		{
			[DebuggerNonUserCode]
			get
			{
				return this._cmdOK;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				if (this._cmdOK != null)
				{
					this._cmdOK.Click -= this.cmdOK_Click;
				}
				this._cmdOK = value;
				if (this._cmdOK != null)
				{
					this._cmdOK.Click += this.cmdOK_Click;
				}
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000BC RID: 188 RVA: 0x0009DA40 File Offset: 0x0009CA40
		// (set) Token: 0x060000BD RID: 189 RVA: 0x0009DA54 File Offset: 0x0009CA54
		public virtual ButtonArray cmdSelectFile
		{
			[DebuggerNonUserCode]
			get
			{
				return this._cmdSelectFile;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				if (this._cmdSelectFile != null)
				{
					this._cmdSelectFile.Click -= this.cmdSelectFile_Click;
				}
				this._cmdSelectFile = value;
				if (this._cmdSelectFile != null)
				{
					this._cmdSelectFile.Click += this.cmdSelectFile_Click;
				}
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000BE RID: 190 RVA: 0x0009DAA8 File Offset: 0x0009CAA8
		// (set) Token: 0x060000BF RID: 191 RVA: 0x0009DABC File Offset: 0x0009CABC
		public virtual GroupBoxArray fraDBLocations
		{
			[DebuggerNonUserCode]
			get
			{
				return this._fraDBLocations;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._fraDBLocations = value;
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060000C0 RID: 192 RVA: 0x0009DAC8 File Offset: 0x0009CAC8
		// (set) Token: 0x060000C1 RID: 193 RVA: 0x0009DADC File Offset: 0x0009CADC
		public virtual RadioButtonArray obAllowColourPrinting
		{
			[DebuggerNonUserCode]
			get
			{
				return this._obAllowColourPrinting;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._obAllowColourPrinting = value;
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060000C2 RID: 194 RVA: 0x0009DAE8 File Offset: 0x0009CAE8
		// (set) Token: 0x060000C3 RID: 195 RVA: 0x0009DAFC File Offset: 0x0009CAFC
		public virtual PanelArray picOptions
		{
			[DebuggerNonUserCode]
			get
			{
				return this._picOptions;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._picOptions = value;
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060000C4 RID: 196 RVA: 0x0009DB08 File Offset: 0x0009CB08
		// (set) Token: 0x060000C5 RID: 197 RVA: 0x0009DB1C File Offset: 0x0009CB1C
		public virtual TextBoxArray txtField
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtField;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtField = value;
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060000C6 RID: 198 RVA: 0x0009DB28 File Offset: 0x0009CB28
		// (set) Token: 0x060000C7 RID: 199 RVA: 0x0009DB3C File Offset: 0x0009CB3C
		public virtual TextBox ServerDatabaseUsername
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ServerDatabaseUsername;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ServerDatabaseUsername = value;
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060000C8 RID: 200 RVA: 0x0009DB48 File Offset: 0x0009CB48
		// (set) Token: 0x060000C9 RID: 201 RVA: 0x0009DB5C File Offset: 0x0009CB5C
		public virtual Label lblUtiLocateOptions_DBUserName
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblUtiLocateOptions_DBUserName;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblUtiLocateOptions_DBUserName = value;
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060000CA RID: 202 RVA: 0x0009DB68 File Offset: 0x0009CB68
		// (set) Token: 0x060000CB RID: 203 RVA: 0x0009DB7C File Offset: 0x0009CB7C
		public virtual TextBox ServerDatabasePassword
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ServerDatabasePassword;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ServerDatabasePassword = value;
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060000CC RID: 204 RVA: 0x0009DB88 File Offset: 0x0009CB88
		// (set) Token: 0x060000CD RID: 205 RVA: 0x0009DB9C File Offset: 0x0009CB9C
		public virtual Label lblUtiLocateOptions_DBPassword
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblUtiLocateOptions_DBPassword;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblUtiLocateOptions_DBPassword = value;
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060000CE RID: 206 RVA: 0x0009DBA8 File Offset: 0x0009CBA8
		// (set) Token: 0x060000CF RID: 207 RVA: 0x0009DBBC File Offset: 0x0009CBBC
		public virtual TextBox ServerDatabasePort
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ServerDatabasePort;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ServerDatabasePort = value;
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060000D0 RID: 208 RVA: 0x0009DBC8 File Offset: 0x0009CBC8
		// (set) Token: 0x060000D1 RID: 209 RVA: 0x0009DBDC File Offset: 0x0009CBDC
		public virtual Label lblUtiLocateOptions_DBPort
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblUtiLocateOptions_DBPort;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblUtiLocateOptions_DBPort = value;
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060000D2 RID: 210 RVA: 0x0009DBE8 File Offset: 0x0009CBE8
		// (set) Token: 0x060000D3 RID: 211 RVA: 0x0009DBFC File Offset: 0x0009CBFC
		public virtual TextBox ServerDatabaseName
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ServerDatabaseName;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ServerDatabaseName = value;
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060000D4 RID: 212 RVA: 0x0009DC08 File Offset: 0x0009CC08
		// (set) Token: 0x060000D5 RID: 213 RVA: 0x0009DC1C File Offset: 0x0009CC1C
		public virtual Label lblUtiLocateOptions_DBName
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblUtiLocateOptions_DBName;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblUtiLocateOptions_DBName = value;
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060000D6 RID: 214 RVA: 0x0009DC28 File Offset: 0x0009CC28
		// (set) Token: 0x060000D7 RID: 215 RVA: 0x0009DC3C File Offset: 0x0009CC3C
		internal virtual TextBox txtPrimaryReport
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtPrimaryReport;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtPrimaryReport = value;
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060000D8 RID: 216 RVA: 0x0009DC48 File Offset: 0x0009CC48
		// (set) Token: 0x060000D9 RID: 217 RVA: 0x0009DC5C File Offset: 0x0009CC5C
		internal virtual OpenFileDialog getFile
		{
			[DebuggerNonUserCode]
			get
			{
				return this._getFile;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._getFile = value;
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060000DA RID: 218 RVA: 0x0009DC68 File Offset: 0x0009CC68
		// (set) Token: 0x060000DB RID: 219 RVA: 0x0009DC7C File Offset: 0x0009CC7C
		internal virtual Button btnSelectPrimaryReport
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnSelectPrimaryReport;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				if (this._btnSelectPrimaryReport != null)
				{
					this._btnSelectPrimaryReport.Click -= this.btnSelectPrimaryReport_Click;
				}
				this._btnSelectPrimaryReport = value;
				if (this._btnSelectPrimaryReport != null)
				{
					this._btnSelectPrimaryReport.Click += this.btnSelectPrimaryReport_Click;
				}
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060000DC RID: 220 RVA: 0x0009DCD0 File Offset: 0x0009CCD0
		// (set) Token: 0x060000DD RID: 221 RVA: 0x0009DCE4 File Offset: 0x0009CCE4
		internal virtual Button btnSelectAuxiliaryReport
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnSelectAuxiliaryReport;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				if (this._btnSelectAuxiliaryReport != null)
				{
					this._btnSelectAuxiliaryReport.Click -= this.btnSelectAuxiliaryReport_Click;
				}
				this._btnSelectAuxiliaryReport = value;
				if (this._btnSelectAuxiliaryReport != null)
				{
					this._btnSelectAuxiliaryReport.Click += this.btnSelectAuxiliaryReport_Click;
				}
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060000DE RID: 222 RVA: 0x0009DD38 File Offset: 0x0009CD38
		// (set) Token: 0x060000DF RID: 223 RVA: 0x0009DD4C File Offset: 0x0009CD4C
		internal virtual TextBox txtAuxiliaryReport
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtAuxiliaryReport;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtAuxiliaryReport = value;
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060000E0 RID: 224 RVA: 0x0009DD58 File Offset: 0x0009CD58
		// (set) Token: 0x060000E1 RID: 225 RVA: 0x0009DD6C File Offset: 0x0009CD6C
		public virtual TextBox DataSourceServer
		{
			[DebuggerNonUserCode]
			get
			{
				return this._DataSourceServer;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._DataSourceServer = value;
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060000E2 RID: 226 RVA: 0x0009DD78 File Offset: 0x0009CD78
		// (set) Token: 0x060000E3 RID: 227 RVA: 0x0009DD8C File Offset: 0x0009CD8C
		public virtual TextBox DataSourceLocal
		{
			[DebuggerNonUserCode]
			get
			{
				return this._DataSourceLocal;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._DataSourceLocal = value;
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060000E4 RID: 228 RVA: 0x0009DD98 File Offset: 0x0009CD98
		// (set) Token: 0x060000E5 RID: 229 RVA: 0x0009DDAC File Offset: 0x0009CDAC
		public virtual GroupBox GroupBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GroupBox1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GroupBox1 = value;
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060000E6 RID: 230 RVA: 0x0009DDB8 File Offset: 0x0009CDB8
		// (set) Token: 0x060000E7 RID: 231 RVA: 0x0009DDCC File Offset: 0x0009CDCC
		public virtual TextBox txtDrawingDatabase
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtDrawingDatabase;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtDrawingDatabase = value;
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060000E8 RID: 232 RVA: 0x0009DDD8 File Offset: 0x0009CDD8
		// (set) Token: 0x060000E9 RID: 233 RVA: 0x0009DDEC File Offset: 0x0009CDEC
		public virtual Button cmdChooseDrawingDatabase
		{
			[DebuggerNonUserCode]
			get
			{
				return this._cmdChooseDrawingDatabase;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				if (this._cmdChooseDrawingDatabase != null)
				{
					this._cmdChooseDrawingDatabase.Click -= this.cmdChooseDrawingDatabase_Click;
				}
				this._cmdChooseDrawingDatabase = value;
				if (this._cmdChooseDrawingDatabase != null)
				{
					this._cmdChooseDrawingDatabase.Click += this.cmdChooseDrawingDatabase_Click;
				}
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060000EA RID: 234 RVA: 0x0009DE40 File Offset: 0x0009CE40
		// (set) Token: 0x060000EB RID: 235 RVA: 0x0009DE54 File Offset: 0x0009CE54
		public virtual Label lbDrawingDatabase
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbDrawingDatabase;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbDrawingDatabase = value;
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060000EC RID: 236 RVA: 0x0009DE60 File Offset: 0x0009CE60
		// (set) Token: 0x060000ED RID: 237 RVA: 0x0009DE74 File Offset: 0x0009CE74
		internal virtual TabPage TabPage1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TabPage1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TabPage1 = value;
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060000EE RID: 238 RVA: 0x0009DE80 File Offset: 0x0009CE80
		// (set) Token: 0x060000EF RID: 239 RVA: 0x0009DE94 File Offset: 0x0009CE94
		public virtual Button cmdForcePatch
		{
			[DebuggerNonUserCode]
			get
			{
				return this._cmdForcePatch;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._cmdForcePatch = value;
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060000F0 RID: 240 RVA: 0x0009DEA0 File Offset: 0x0009CEA0
		// (set) Token: 0x060000F1 RID: 241 RVA: 0x0009DEB4 File Offset: 0x0009CEB4
		public virtual Button cmdDatabaseRepair
		{
			[DebuggerNonUserCode]
			get
			{
				return this._cmdDatabaseRepair;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._cmdDatabaseRepair = value;
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060000F2 RID: 242 RVA: 0x0009DEC0 File Offset: 0x0009CEC0
		// (set) Token: 0x060000F3 RID: 243 RVA: 0x0009DED4 File Offset: 0x0009CED4
		public virtual Button cmdLaunchLanguageSupport
		{
			[DebuggerNonUserCode]
			get
			{
				return this._cmdLaunchLanguageSupport;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._cmdLaunchLanguageSupport = value;
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060000F4 RID: 244 RVA: 0x0009DEE0 File Offset: 0x0009CEE0
		// (set) Token: 0x060000F5 RID: 245 RVA: 0x0009DEF4 File Offset: 0x0009CEF4
		internal virtual TabPage TabPage2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TabPage2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TabPage2 = value;
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060000F6 RID: 246 RVA: 0x0009DF00 File Offset: 0x0009CF00
		// (set) Token: 0x060000F7 RID: 247 RVA: 0x0009DF14 File Offset: 0x0009CF14
		internal virtual GroupBox GroupBox2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GroupBox2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GroupBox2 = value;
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060000F8 RID: 248 RVA: 0x0009DF20 File Offset: 0x0009CF20
		// (set) Token: 0x060000F9 RID: 249 RVA: 0x0009DF34 File Offset: 0x0009CF34
		public virtual Label lbCompletionsForm
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbCompletionsForm;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbCompletionsForm = value;
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060000FA RID: 250 RVA: 0x0009DF40 File Offset: 0x0009CF40
		// (set) Token: 0x060000FB RID: 251 RVA: 0x0009DF54 File Offset: 0x0009CF54
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

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x060000FC RID: 252 RVA: 0x0009DF60 File Offset: 0x0009CF60
		// (set) Token: 0x060000FD RID: 253 RVA: 0x0009DF74 File Offset: 0x0009CF74
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

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060000FE RID: 254 RVA: 0x0009DF80 File Offset: 0x0009CF80
		// (set) Token: 0x060000FF RID: 255 RVA: 0x0009DF94 File Offset: 0x0009CF94
		public virtual TextBox TextBox2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TextBox2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TextBox2 = value;
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06000100 RID: 256 RVA: 0x0009DFA0 File Offset: 0x0009CFA0
		// (set) Token: 0x06000101 RID: 257 RVA: 0x0009DFB4 File Offset: 0x0009CFB4
		public virtual Label Label2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label2 = value;
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000102 RID: 258 RVA: 0x0009DFC0 File Offset: 0x0009CFC0
		// (set) Token: 0x06000103 RID: 259 RVA: 0x0009DFD4 File Offset: 0x0009CFD4
		public virtual TextBox TextBox3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TextBox3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TextBox3 = value;
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000104 RID: 260 RVA: 0x0009DFE0 File Offset: 0x0009CFE0
		// (set) Token: 0x06000105 RID: 261 RVA: 0x0009DFF4 File Offset: 0x0009CFF4
		public virtual Label Label3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label3 = value;
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000106 RID: 262 RVA: 0x0009E000 File Offset: 0x0009D000
		// (set) Token: 0x06000107 RID: 263 RVA: 0x0009E014 File Offset: 0x0009D014
		public virtual TextBox TextBox4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TextBox4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TextBox4 = value;
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000108 RID: 264 RVA: 0x0009E020 File Offset: 0x0009D020
		// (set) Token: 0x06000109 RID: 265 RVA: 0x0009E034 File Offset: 0x0009D034
		public virtual Label Label4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label4 = value;
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x0600010A RID: 266 RVA: 0x0009E040 File Offset: 0x0009D040
		// (set) Token: 0x0600010B RID: 267 RVA: 0x0009E054 File Offset: 0x0009D054
		public virtual TextBox TextBox5
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TextBox5;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TextBox5 = value;
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x0600010C RID: 268 RVA: 0x0009E060 File Offset: 0x0009D060
		// (set) Token: 0x0600010D RID: 269 RVA: 0x0009E074 File Offset: 0x0009D074
		public virtual Label Label5
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label5;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label5 = value;
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x0600010E RID: 270 RVA: 0x0009E080 File Offset: 0x0009D080
		// (set) Token: 0x0600010F RID: 271 RVA: 0x0009E094 File Offset: 0x0009D094
		internal virtual ListBox listbox_CompletionsForm
		{
			[DebuggerNonUserCode]
			get
			{
				return this._listbox_CompletionsForm;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				if (this._listbox_CompletionsForm != null)
				{
					this._listbox_CompletionsForm.SelectedIndexChanged -= this.listbox_CompletionsForm_SelectedIndexChanged;
				}
				this._listbox_CompletionsForm = value;
				if (this._listbox_CompletionsForm != null)
				{
					this._listbox_CompletionsForm.SelectedIndexChanged += this.listbox_CompletionsForm_SelectedIndexChanged;
				}
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06000110 RID: 272 RVA: 0x0009E0E8 File Offset: 0x0009D0E8
		// (set) Token: 0x06000111 RID: 273 RVA: 0x0009E0FC File Offset: 0x0009D0FC
		public virtual TextBox txtCompany
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtCompany;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtCompany = value;
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000112 RID: 274 RVA: 0x0009E108 File Offset: 0x0009D108
		// (set) Token: 0x06000113 RID: 275 RVA: 0x0009E11C File Offset: 0x0009D11C
		public virtual Label lbSelectedCompletionsForm
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbSelectedCompletionsForm;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbSelectedCompletionsForm = value;
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000114 RID: 276 RVA: 0x0009E128 File Offset: 0x0009D128
		// (set) Token: 0x06000115 RID: 277 RVA: 0x0009E13C File Offset: 0x0009D13C
		public virtual TextBox txtCompletionsForm
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtCompletionsForm;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtCompletionsForm = value;
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000116 RID: 278 RVA: 0x0009E148 File Offset: 0x0009D148
		// (set) Token: 0x06000117 RID: 279 RVA: 0x0009E15C File Offset: 0x0009D15C
		public virtual PictureBox imgDiv
		{
			[DebuggerNonUserCode]
			get
			{
				return this._imgDiv;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._imgDiv = value;
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000118 RID: 280 RVA: 0x0009E168 File Offset: 0x0009D168
		// (set) Token: 0x06000119 RID: 281 RVA: 0x0009E17C File Offset: 0x0009D17C
		public virtual PictureBox Image1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Image1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Image1 = value;
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x0600011A RID: 282 RVA: 0x0009E188 File Offset: 0x0009D188
		// (set) Token: 0x0600011B RID: 283 RVA: 0x0009E19C File Offset: 0x0009D19C
		public virtual Panel Frame1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Frame1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Frame1 = value;
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x0600011C RID: 284 RVA: 0x0009E1A8 File Offset: 0x0009D1A8
		// (set) Token: 0x0600011D RID: 285 RVA: 0x0009E1BC File Offset: 0x0009D1BC
		public virtual Label lblUtiLocateLogin_Employee
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblUtiLocateLogin_Employee;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblUtiLocateLogin_Employee = value;
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x0600011E RID: 286 RVA: 0x0009E1C8 File Offset: 0x0009D1C8
		// (set) Token: 0x0600011F RID: 287 RVA: 0x0009E1DC File Offset: 0x0009D1DC
		internal virtual TabPage TabPage3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TabPage3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TabPage3 = value;
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x06000120 RID: 288 RVA: 0x0009E1E8 File Offset: 0x0009D1E8
		// (set) Token: 0x06000121 RID: 289 RVA: 0x0009E1FC File Offset: 0x0009D1FC
		public virtual GroupBox GroupBox3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GroupBox3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GroupBox3 = value;
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x06000122 RID: 290 RVA: 0x0009E208 File Offset: 0x0009D208
		// (set) Token: 0x06000123 RID: 291 RVA: 0x0009E21C File Offset: 0x0009D21C
		public virtual TextBox ServerDocDatabaseName
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ServerDocDatabaseName;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ServerDocDatabaseName = value;
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x06000124 RID: 292 RVA: 0x0009E228 File Offset: 0x0009D228
		// (set) Token: 0x06000125 RID: 293 RVA: 0x0009E23C File Offset: 0x0009D23C
		public virtual Label Label6
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label6;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label6 = value;
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000126 RID: 294 RVA: 0x0009E248 File Offset: 0x0009D248
		// (set) Token: 0x06000127 RID: 295 RVA: 0x0009E25C File Offset: 0x0009D25C
		public virtual TextBox ServerDocDatabasePort
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ServerDocDatabasePort;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ServerDocDatabasePort = value;
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000128 RID: 296 RVA: 0x0009E268 File Offset: 0x0009D268
		// (set) Token: 0x06000129 RID: 297 RVA: 0x0009E27C File Offset: 0x0009D27C
		public virtual Label Label7
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label7;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label7 = value;
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x0600012A RID: 298 RVA: 0x0009E288 File Offset: 0x0009D288
		// (set) Token: 0x0600012B RID: 299 RVA: 0x0009E29C File Offset: 0x0009D29C
		public virtual TextBox ServerDocDatabasePassword
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ServerDocDatabasePassword;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ServerDocDatabasePassword = value;
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x0600012C RID: 300 RVA: 0x0009E2A8 File Offset: 0x0009D2A8
		// (set) Token: 0x0600012D RID: 301 RVA: 0x0009E2BC File Offset: 0x0009D2BC
		public virtual Label Label8
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label8;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label8 = value;
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x0600012E RID: 302 RVA: 0x0009E2C8 File Offset: 0x0009D2C8
		// (set) Token: 0x0600012F RID: 303 RVA: 0x0009E2DC File Offset: 0x0009D2DC
		public virtual TextBox ServerDocDatabaseUsername
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ServerDocDatabaseUsername;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ServerDocDatabaseUsername = value;
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x06000130 RID: 304 RVA: 0x0009E2E8 File Offset: 0x0009D2E8
		// (set) Token: 0x06000131 RID: 305 RVA: 0x0009E2FC File Offset: 0x0009D2FC
		public virtual Label Label9
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label9;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label9 = value;
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x06000132 RID: 306 RVA: 0x0009E308 File Offset: 0x0009D308
		// (set) Token: 0x06000133 RID: 307 RVA: 0x0009E31C File Offset: 0x0009D31C
		public virtual TextBox ServerDocDatabaseLocation
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ServerDocDatabaseLocation;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ServerDocDatabaseLocation = value;
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06000134 RID: 308 RVA: 0x0009E328 File Offset: 0x0009D328
		// (set) Token: 0x06000135 RID: 309 RVA: 0x0009E33C File Offset: 0x0009D33C
		public virtual Label Label10
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label10;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label10 = value;
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x06000136 RID: 310 RVA: 0x0009E348 File Offset: 0x0009D348
		// (set) Token: 0x06000137 RID: 311 RVA: 0x0009E35C File Offset: 0x0009D35C
		public virtual GroupBox GroupBox6
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GroupBox6;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GroupBox6 = value;
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000138 RID: 312 RVA: 0x0009E368 File Offset: 0x0009D368
		// (set) Token: 0x06000139 RID: 313 RVA: 0x0009E37C File Offset: 0x0009D37C
		public virtual RadioButton RadioButton5
		{
			[DebuggerNonUserCode]
			get
			{
				return this._RadioButton5;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._RadioButton5 = value;
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x0600013A RID: 314 RVA: 0x0009E388 File Offset: 0x0009D388
		// (set) Token: 0x0600013B RID: 315 RVA: 0x0009E39C File Offset: 0x0009D39C
		public virtual RadioButton RadioButton6
		{
			[DebuggerNonUserCode]
			get
			{
				return this._RadioButton6;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._RadioButton6 = value;
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x0600013C RID: 316 RVA: 0x0009E3A8 File Offset: 0x0009D3A8
		// (set) Token: 0x0600013D RID: 317 RVA: 0x0009E3BC File Offset: 0x0009D3BC
		public virtual GroupBox GroupBox5
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GroupBox5;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GroupBox5 = value;
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x0600013E RID: 318 RVA: 0x0009E3C8 File Offset: 0x0009D3C8
		// (set) Token: 0x0600013F RID: 319 RVA: 0x0009E3DC File Offset: 0x0009D3DC
		public virtual RadioButton RadioButton3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._RadioButton3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._RadioButton3 = value;
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000140 RID: 320 RVA: 0x0009E3E8 File Offset: 0x0009D3E8
		// (set) Token: 0x06000141 RID: 321 RVA: 0x0009E3FC File Offset: 0x0009D3FC
		public virtual RadioButton RadioButton4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._RadioButton4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._RadioButton4 = value;
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000142 RID: 322 RVA: 0x0009E408 File Offset: 0x0009D408
		// (set) Token: 0x06000143 RID: 323 RVA: 0x0009E41C File Offset: 0x0009D41C
		public virtual GroupBox GroupBox4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GroupBox4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GroupBox4 = value;
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000144 RID: 324 RVA: 0x0009E428 File Offset: 0x0009D428
		// (set) Token: 0x06000145 RID: 325 RVA: 0x0009E43C File Offset: 0x0009D43C
		public virtual RadioButton RadioButton1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._RadioButton1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._RadioButton1 = value;
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000146 RID: 326 RVA: 0x0009E448 File Offset: 0x0009D448
		// (set) Token: 0x06000147 RID: 327 RVA: 0x0009E45C File Offset: 0x0009D45C
		public virtual RadioButton RadioButton2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._RadioButton2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._RadioButton2 = value;
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x06000149 RID: 329 RVA: 0x000A15B0 File Offset: 0x000A05B0
		// (set) Token: 0x0600014A RID: 330 RVA: 0x000A15F0 File Offset: 0x000A05F0
		public static frmOptions DefInstance
		{
			get
			{
				if (frmOptions.m_vb6FormDefInstance == null || frmOptions.m_vb6FormDefInstance.IsDisposed)
				{
					frmOptions.m_InitializingDefInstance = true;
					frmOptions.m_vb6FormDefInstance = new frmOptions();
					frmOptions.m_InitializingDefInstance = false;
				}
				return frmOptions.m_vb6FormDefInstance;
			}
			set
			{
				frmOptions.m_vb6FormDefInstance = value;
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x0600014B RID: 331 RVA: 0x000A15F8 File Offset: 0x000A05F8
		public bool WasDatabaseChanged
		{
			get
			{
				return this.bDatabaseChanged;
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x0600014C RID: 332 RVA: 0x000A1610 File Offset: 0x000A0610
		public bool WasCancelled
		{
			get
			{
				return this.bCancelled;
			}
		}

		// Token: 0x0600014D RID: 333 RVA: 0x000A1628 File Offset: 0x000A0628
		private void cbAuxilaryReportName_TextChanged(object eventSender, EventArgs eventArgs)
		{
			this.bDatabaseChanged = true;
		}

		// Token: 0x0600014E RID: 334 RVA: 0x000A1634 File Offset: 0x000A0634
		private void cbPrimaryReportName_TextChanged(object eventSender, EventArgs eventArgs)
		{
			this.bDatabaseChanged = true;
		}

		// Token: 0x0600014F RID: 335 RVA: 0x000A1640 File Offset: 0x000A0640
		private void cmdApply_Click(object eventSender, EventArgs eventArgs)
		{
			this.UpdateOptions();
		}

		// Token: 0x06000150 RID: 336 RVA: 0x000A1648 File Offset: 0x000A0648
		private void cmdCancel_Click(object eventSender, EventArgs eventArgs)
		{
			this.bCancelled = true;
			frmOptions.DefInstance.Visible = false;
		}

		// Token: 0x06000151 RID: 337 RVA: 0x000A165C File Offset: 0x000A065C
		private void cmdOK_Click(object eventSender, EventArgs eventArgs)
		{
			this.UpdateOptions();
			frmOptions.DefInstance.Visible = false;
		}

		// Token: 0x06000152 RID: 338 RVA: 0x000A1670 File Offset: 0x000A0670
		private void cmdSelectFile_Click(object eventSender, EventArgs eventArgs)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.InitialDirectory = "c:\\";
			openFileDialog.Filter = "U2 Database *.db|*.db";
			openFileDialog.FilterIndex = 1;
			openFileDialog.RestoreDirectory = true;
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				this.txtField[0].Text = openFileDialog.FileName;
			}
		}

		// Token: 0x06000153 RID: 339 RVA: 0x000A16C8 File Offset: 0x000A06C8
		private void frmOptions_Load(object eventSender, EventArgs eventArgs)
		{
			this.LoadOptions();
		}

		// Token: 0x06000154 RID: 340 RVA: 0x000A16D0 File Offset: 0x000A06D0
		private void LoadOptions()
		{
			this.DataSourceLocal.Text = Config.GetOption(Config.Setting.DBLocalServer);
			this.DataSourceServer.Text = Config.GetOption(Config.Setting.DBServer);
			this.ServerDatabaseName.Text = Config.GetOption(Config.Setting.DBName);
			this.ServerDatabaseUsername.Text = Config.GetOption(Config.Setting.DBUsername);
			this.ServerDatabasePassword.Text = Config.GetOption(Config.Setting.DBPassword);
			this.ServerDatabasePort.Text = Config.GetOption(Config.Setting.DBPort);
			this.txtDrawingDatabase.Text = Config.GetOption(Config.Setting.DBDrawingDatabase);
			this.ServerDocDatabaseLocation.Text = Config.GetOption(Config.Setting.DocumentsDBServer);
			this.ServerDocDatabaseName.Text = Config.GetOption(Config.Setting.DocumentsDBName);
			this.ServerDocDatabaseUsername.Text = Config.GetOption(Config.Setting.DocumentsDBUsername);
			this.ServerDocDatabasePassword.Text = Config.GetOption(Config.Setting.DocumentsDBPassword);
			this.ServerDocDatabasePort.Text = Config.GetOption(Config.Setting.DocumentsDBPort);
			this.txtPrimaryReportImageHeight.Text = Config.GetOption(Config.Setting.PrimaryReportImageHeight);
			this.txtPrimaryReportImageWidth.Text = Config.GetOption(Config.Setting.PrimaryReportImageWidth);
			this.txtAuxilaryReportImageHeight.Text = Config.GetOption(Config.Setting.AuxilaryReportImageHeight);
			this.txtAuxilaryReportImageWidth.Text = Config.GetOption(Config.Setting.AuxilaryReportImageWidth);
			this.txtAuxiliaryReport.Text = Config.GetOption(Config.Setting.AuxiliaryReportFile);
			this.txtPrimaryReport.Text = Config.GetOption(Config.Setting.PrimaryReportFile);
			this.txtCompany.Text = Config.GetOption(Config.Setting.Company);
		}

		// Token: 0x06000155 RID: 341 RVA: 0x000A1830 File Offset: 0x000A0830
		private void UpdateOptions()
		{
			try
			{
				Config.SetOption(Config.Setting.DBLocalServer, this.DataSourceLocal.Text);
				Config.SetOption(Config.Setting.DBDrawingDatabase, this.txtDrawingDatabase.Text);
				Config.SetOption(Config.Setting.DBServer, this.DataSourceServer.Text);
				Config.SetOption(Config.Setting.DBName, this.ServerDatabaseName.Text);
				Config.SetOption(Config.Setting.DBUsername, this.ServerDatabaseUsername.Text);
				Config.SetOption(Config.Setting.DBPassword, this.ServerDatabasePassword.Text);
				Config.SetOption(Config.Setting.DBPort, this.ServerDatabasePort.Text);
				Config.SetOption(Config.Setting.DocumentsDBServer, this.ServerDocDatabaseLocation.Text);
				Config.SetOption(Config.Setting.DocumentsDBName, this.ServerDocDatabaseName.Text);
				Config.SetOption(Config.Setting.DocumentsDBUsername, this.ServerDocDatabaseUsername.Text);
				Config.SetOption(Config.Setting.DocumentsDBPassword, this.ServerDocDatabasePassword.Text);
				if (Versioned.IsNumeric(this.ServerDocDatabasePort.Text))
				{
					Config.SetOption(Config.Setting.DocumentsDBPort, this.ServerDocDatabasePort.Text);
				}
				Config.SetOption(Config.Setting.AuxiliaryReportFile, this.txtAuxiliaryReport.Text);
				Config.SetOption(Config.Setting.PrimaryReportFile, this.txtPrimaryReport.Text);
				if (Versioned.IsNumeric(this.txtAuxilaryReportImageHeight.Text))
				{
					Config.SetOption(Config.Setting.AuxilaryReportImageHeight, this.txtAuxilaryReportImageHeight.Text);
				}
				if (Versioned.IsNumeric(this.txtAuxilaryReportImageWidth.Text))
				{
					Config.SetOption(Config.Setting.AuxilaryReportImageWidth, this.txtAuxilaryReportImageWidth.Text);
				}
				if (Versioned.IsNumeric(this.txtPrimaryReportImageHeight.Text))
				{
					Config.SetOption(Config.Setting.PrimaryReportImageHeight, this.txtPrimaryReportImageHeight.Text);
				}
				if (Versioned.IsNumeric(this.txtPrimaryReportImageWidth.Text))
				{
					Config.SetOption(Config.Setting.PrimaryReportImageWidth, this.txtPrimaryReportImageWidth.Text);
				}
				Config.SetOption(Config.Setting.Company, this.txtCompany.Text);
				Config.Store();
			}
			catch (Exception e)
			{
				if (CodeConstructionTools.GetDebugMode() == 1)
				{
					CodeConstructionTools.ReportError(e, "frmOptions.UpdateOptions: System was unable to complete the operation", "ERROR IN frmOptions.UpdateOptions");
				}
			}
			finally
			{
			}
		}

		// Token: 0x06000156 RID: 342 RVA: 0x000A1A4C File Offset: 0x000A0A4C
		private short DiscardNonNumbers(ref short KeyAscii)
		{
			string left = Conversions.ToString(Strings.Chr((int)KeyAscii));
			left = Conversions.ToString(Strings.Chr((int)KeyAscii));
			short result;
			if (!(Operators.CompareString(left, "0", false) >= 0 & Operators.CompareString(left, "9", false) <= 0))
			{
				result = 0;
			}
			else
			{
				result = KeyAscii;
			}
			return result;
		}

		// Token: 0x06000157 RID: 343 RVA: 0x000A1AA4 File Offset: 0x000A0AA4
		private void txtAuxilaryReportImageHeight_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
		{
			short num = checked((short)Strings.Asc(eventArgs.KeyChar));
			num = this.DiscardNonNumbers(ref num);
			if (num == 0)
			{
				eventArgs.Handled = true;
			}
		}

		// Token: 0x06000158 RID: 344 RVA: 0x000A1AD4 File Offset: 0x000A0AD4
		private void txtAuxilaryReportImageWidth_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
		{
			short num = checked((short)Strings.Asc(eventArgs.KeyChar));
			num = this.DiscardNonNumbers(ref num);
			if (num == 0)
			{
				eventArgs.Handled = true;
			}
		}

		// Token: 0x06000159 RID: 345 RVA: 0x000A1B04 File Offset: 0x000A0B04
		private void txtPrimaryReportImageHeight_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
		{
			short num = checked((short)Strings.Asc(eventArgs.KeyChar));
			num = this.DiscardNonNumbers(ref num);
			if (num == 0)
			{
				eventArgs.Handled = true;
			}
		}

		// Token: 0x0600015A RID: 346 RVA: 0x000A1B34 File Offset: 0x000A0B34
		private void txtPrimaryReportImageWidth_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
		{
			short num = checked((short)Strings.Asc(eventArgs.KeyChar));
			num = this.DiscardNonNumbers(ref num);
			if (num == 0)
			{
				eventArgs.Handled = true;
			}
		}

		// Token: 0x0600015B RID: 347 RVA: 0x000A1B64 File Offset: 0x000A0B64
		private void btnSelectPrimaryReport_Click(object sender, EventArgs e)
		{
			this.getFile.ShowDialog();
			this.txtPrimaryReport.Text = this.getFile.FileName;
		}

		// Token: 0x0600015C RID: 348 RVA: 0x000A1B88 File Offset: 0x000A0B88
		private void btnSelectAuxiliaryReport_Click(object sender, EventArgs e)
		{
			this.getFile.ShowDialog();
			this.txtAuxiliaryReport.Text = this.getFile.FileName;
		}

		// Token: 0x0600015D RID: 349 RVA: 0x000A1BAC File Offset: 0x000A0BAC
		private void cmdChooseDrawingDatabase_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.InitialDirectory = "c:\\";
			openFileDialog.Filter = "U2 Database *.db|*.db";
			openFileDialog.FilterIndex = 1;
			openFileDialog.RestoreDirectory = true;
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				this.txtDrawingDatabase.Text = openFileDialog.FileName;
			}
		}

		// Token: 0x0600015E RID: 350 RVA: 0x000A1C00 File Offset: 0x000A0C00
		private void listbox_CompletionsForm_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.txtCompany.Text = Conversions.ToString(this.listbox_CompletionsForm.SelectedItem);
		}

		// Token: 0x04000031 RID: 49
		[AccessedThroughProperty("lblUtiLocateOptions_DBLocation")]
		private Label _lblUtiLocateOptions_DBLocation;

		// Token: 0x04000032 RID: 50
		[AccessedThroughProperty("fraDBLocations_1")]
		private GroupBox _fraDBLocations_1;

		// Token: 0x04000033 RID: 51
		[AccessedThroughProperty("_cmdSelectFile_0")]
		private Button __cmdSelectFile_0;

		// Token: 0x04000034 RID: 52
		[AccessedThroughProperty("lblUtiLocateOptions_Filename")]
		private Label _lblUtiLocateOptions_Filename;

		// Token: 0x04000035 RID: 53
		[AccessedThroughProperty("fraDBLocations_0")]
		private GroupBox _fraDBLocations_0;

		// Token: 0x04000036 RID: 54
		[AccessedThroughProperty("_SSTab1_TabPage0")]
		private TabPage __SSTab1_TabPage0;

		// Token: 0x04000037 RID: 55
		[AccessedThroughProperty("lblReportOptions_ColourPrinting_Allow")]
		private Label _lblReportOptions_ColourPrinting_Allow;

		// Token: 0x04000038 RID: 56
		[AccessedThroughProperty("_obAllowColourPrinting_1")]
		private RadioButton __obAllowColourPrinting_1;

		// Token: 0x04000039 RID: 57
		[AccessedThroughProperty("_obAllowColourPrinting_0")]
		private RadioButton __obAllowColourPrinting_0;

		// Token: 0x0400003A RID: 58
		[AccessedThroughProperty("lblReportOptions_ColourPrinting")]
		private GroupBox _lblReportOptions_ColourPrinting;

		// Token: 0x0400003B RID: 59
		[AccessedThroughProperty("txtPrimaryReportImageHeight")]
		private TextBox _txtPrimaryReportImageHeight;

		// Token: 0x0400003C RID: 60
		[AccessedThroughProperty("txtPrimaryReportImageWidth")]
		private TextBox _txtPrimaryReportImageWidth;

		// Token: 0x0400003D RID: 61
		[AccessedThroughProperty("lblReportOptions_ValuesInMM")]
		private Label _lblReportOptions_ValuesInMM;

		// Token: 0x0400003E RID: 62
		[AccessedThroughProperty("lblReportOptions_ImageHeight")]
		private Label _lblReportOptions_ImageHeight;

		// Token: 0x0400003F RID: 63
		[AccessedThroughProperty("lblReportOptions_ImageWidth")]
		private Label _lblReportOptions_ImageWidth;

		// Token: 0x04000040 RID: 64
		[AccessedThroughProperty("lblReportOptions_ImageSize")]
		private Label _lblReportOptions_ImageSize;

		// Token: 0x04000041 RID: 65
		[AccessedThroughProperty("lblReportOptions_PrimaryReport")]
		private Label _lblReportOptions_PrimaryReport;

		// Token: 0x04000042 RID: 66
		[AccessedThroughProperty("lblReportOptions_PrimaryReportOptions")]
		private GroupBox _lblReportOptions_PrimaryReportOptions;

		// Token: 0x04000043 RID: 67
		[AccessedThroughProperty("txtAuxilaryReportImageHeight")]
		private TextBox _txtAuxilaryReportImageHeight;

		// Token: 0x04000044 RID: 68
		[AccessedThroughProperty("txtAuxilaryReportImageWidth")]
		private TextBox _txtAuxilaryReportImageWidth;

		// Token: 0x04000045 RID: 69
		[AccessedThroughProperty("lblReportOptions_ValuesInMM1")]
		private Label _lblReportOptions_ValuesInMM1;

		// Token: 0x04000046 RID: 70
		[AccessedThroughProperty("lblReportOptions_Height1")]
		private Label _lblReportOptions_Height1;

		// Token: 0x04000047 RID: 71
		[AccessedThroughProperty("lblReportOptions_Width1")]
		private Label _lblReportOptions_Width1;

		// Token: 0x04000048 RID: 72
		[AccessedThroughProperty("lblReportOptions_ImageSize1")]
		private Label _lblReportOptions_ImageSize1;

		// Token: 0x04000049 RID: 73
		[AccessedThroughProperty("lblReportOptions_Report")]
		private Label _lblReportOptions_Report;

		// Token: 0x0400004A RID: 74
		[AccessedThroughProperty("lblReportOptions_AuxReportOption")]
		private GroupBox _lblReportOptions_AuxReportOption;

		// Token: 0x0400004B RID: 75
		[AccessedThroughProperty("_SSTab1_TabPage1")]
		private TabPage __SSTab1_TabPage1;

		// Token: 0x0400004C RID: 76
		[AccessedThroughProperty("lblUtiLocateOptions")]
		private TabControl _lblUtiLocateOptions;

		// Token: 0x0400004D RID: 77
		[AccessedThroughProperty("fraSample4")]
		private GroupBox _fraSample4;

		// Token: 0x0400004E RID: 78
		[AccessedThroughProperty("_picOptions_3")]
		private Panel __picOptions_3;

		// Token: 0x0400004F RID: 79
		[AccessedThroughProperty("fraSample3")]
		private GroupBox _fraSample3;

		// Token: 0x04000050 RID: 80
		[AccessedThroughProperty("_picOptions_2")]
		private Panel __picOptions_2;

		// Token: 0x04000051 RID: 81
		[AccessedThroughProperty("fraSample2")]
		private GroupBox _fraSample2;

		// Token: 0x04000052 RID: 82
		[AccessedThroughProperty("_picOptions_1")]
		private Panel __picOptions_1;

		// Token: 0x04000053 RID: 83
		[AccessedThroughProperty("cmdApply")]
		private Button _cmdApply;

		// Token: 0x04000054 RID: 84
		[AccessedThroughProperty("cmdCancel")]
		private Button _cmdCancel;

		// Token: 0x04000055 RID: 85
		[AccessedThroughProperty("cmdOK")]
		private Button _cmdOK;

		// Token: 0x04000056 RID: 86
		[AccessedThroughProperty("cmdSelectFile")]
		private ButtonArray _cmdSelectFile;

		// Token: 0x04000057 RID: 87
		[AccessedThroughProperty("fraDBLocations")]
		private GroupBoxArray _fraDBLocations;

		// Token: 0x04000058 RID: 88
		[AccessedThroughProperty("obAllowColourPrinting")]
		private RadioButtonArray _obAllowColourPrinting;

		// Token: 0x04000059 RID: 89
		[AccessedThroughProperty("picOptions")]
		private PanelArray _picOptions;

		// Token: 0x0400005A RID: 90
		[AccessedThroughProperty("txtField")]
		private TextBoxArray _txtField;

		// Token: 0x0400005B RID: 91
		[AccessedThroughProperty("ServerDatabaseUsername")]
		private TextBox _ServerDatabaseUsername;

		// Token: 0x0400005C RID: 92
		[AccessedThroughProperty("lblUtiLocateOptions_DBUserName")]
		private Label _lblUtiLocateOptions_DBUserName;

		// Token: 0x0400005D RID: 93
		[AccessedThroughProperty("ServerDatabasePassword")]
		private TextBox _ServerDatabasePassword;

		// Token: 0x0400005E RID: 94
		[AccessedThroughProperty("lblUtiLocateOptions_DBPassword")]
		private Label _lblUtiLocateOptions_DBPassword;

		// Token: 0x0400005F RID: 95
		[AccessedThroughProperty("ServerDatabasePort")]
		private TextBox _ServerDatabasePort;

		// Token: 0x04000060 RID: 96
		[AccessedThroughProperty("lblUtiLocateOptions_DBPort")]
		private Label _lblUtiLocateOptions_DBPort;

		// Token: 0x04000061 RID: 97
		[AccessedThroughProperty("ServerDatabaseName")]
		private TextBox _ServerDatabaseName;

		// Token: 0x04000062 RID: 98
		[AccessedThroughProperty("lblUtiLocateOptions_DBName")]
		private Label _lblUtiLocateOptions_DBName;

		// Token: 0x04000063 RID: 99
		[AccessedThroughProperty("txtPrimaryReport")]
		private TextBox _txtPrimaryReport;

		// Token: 0x04000064 RID: 100
		[AccessedThroughProperty("getFile")]
		private OpenFileDialog _getFile;

		// Token: 0x04000065 RID: 101
		[AccessedThroughProperty("btnSelectPrimaryReport")]
		private Button _btnSelectPrimaryReport;

		// Token: 0x04000066 RID: 102
		[AccessedThroughProperty("btnSelectAuxiliaryReport")]
		private Button _btnSelectAuxiliaryReport;

		// Token: 0x04000067 RID: 103
		[AccessedThroughProperty("txtAuxiliaryReport")]
		private TextBox _txtAuxiliaryReport;

		// Token: 0x04000068 RID: 104
		[AccessedThroughProperty("DataSourceServer")]
		private TextBox _DataSourceServer;

		// Token: 0x04000069 RID: 105
		[AccessedThroughProperty("DataSourceLocal")]
		private TextBox _DataSourceLocal;

		// Token: 0x0400006A RID: 106
		[AccessedThroughProperty("GroupBox1")]
		private GroupBox _GroupBox1;

		// Token: 0x0400006B RID: 107
		[AccessedThroughProperty("txtDrawingDatabase")]
		private TextBox _txtDrawingDatabase;

		// Token: 0x0400006C RID: 108
		[AccessedThroughProperty("cmdChooseDrawingDatabase")]
		private Button _cmdChooseDrawingDatabase;

		// Token: 0x0400006D RID: 109
		[AccessedThroughProperty("lbDrawingDatabase")]
		private Label _lbDrawingDatabase;

		// Token: 0x0400006E RID: 110
		[AccessedThroughProperty("TabPage1")]
		private TabPage _TabPage1;

		// Token: 0x0400006F RID: 111
		[AccessedThroughProperty("cmdForcePatch")]
		private Button _cmdForcePatch;

		// Token: 0x04000070 RID: 112
		[AccessedThroughProperty("cmdDatabaseRepair")]
		private Button _cmdDatabaseRepair;

		// Token: 0x04000071 RID: 113
		[AccessedThroughProperty("cmdLaunchLanguageSupport")]
		private Button _cmdLaunchLanguageSupport;

		// Token: 0x04000072 RID: 114
		[AccessedThroughProperty("TabPage2")]
		private TabPage _TabPage2;

		// Token: 0x04000073 RID: 115
		[AccessedThroughProperty("GroupBox2")]
		private GroupBox _GroupBox2;

		// Token: 0x04000074 RID: 116
		[AccessedThroughProperty("lbCompletionsForm")]
		private Label _lbCompletionsForm;

		// Token: 0x04000075 RID: 117
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x04000076 RID: 118
		[AccessedThroughProperty("TextBox1")]
		private TextBox _TextBox1;

		// Token: 0x04000077 RID: 119
		[AccessedThroughProperty("TextBox2")]
		private TextBox _TextBox2;

		// Token: 0x04000078 RID: 120
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x04000079 RID: 121
		[AccessedThroughProperty("TextBox3")]
		private TextBox _TextBox3;

		// Token: 0x0400007A RID: 122
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x0400007B RID: 123
		[AccessedThroughProperty("TextBox4")]
		private TextBox _TextBox4;

		// Token: 0x0400007C RID: 124
		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		// Token: 0x0400007D RID: 125
		[AccessedThroughProperty("TextBox5")]
		private TextBox _TextBox5;

		// Token: 0x0400007E RID: 126
		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		// Token: 0x0400007F RID: 127
		[AccessedThroughProperty("listbox_CompletionsForm")]
		private ListBox _listbox_CompletionsForm;

		// Token: 0x04000080 RID: 128
		[AccessedThroughProperty("txtCompany")]
		private TextBox _txtCompany;

		// Token: 0x04000081 RID: 129
		[AccessedThroughProperty("lbSelectedCompletionsForm")]
		private Label _lbSelectedCompletionsForm;

		// Token: 0x04000082 RID: 130
		[AccessedThroughProperty("txtCompletionsForm")]
		private TextBox _txtCompletionsForm;

		// Token: 0x04000083 RID: 131
		[AccessedThroughProperty("imgDiv")]
		private PictureBox _imgDiv;

		// Token: 0x04000084 RID: 132
		[AccessedThroughProperty("Image1")]
		private PictureBox _Image1;

		// Token: 0x04000085 RID: 133
		[AccessedThroughProperty("Frame1")]
		private Panel _Frame1;

		// Token: 0x04000086 RID: 134
		[AccessedThroughProperty("lblUtiLocateLogin_Employee")]
		private Label _lblUtiLocateLogin_Employee;

		// Token: 0x04000087 RID: 135
		[AccessedThroughProperty("TabPage3")]
		private TabPage _TabPage3;

		// Token: 0x04000088 RID: 136
		[AccessedThroughProperty("GroupBox3")]
		private GroupBox _GroupBox3;

		// Token: 0x04000089 RID: 137
		[AccessedThroughProperty("ServerDocDatabaseName")]
		private TextBox _ServerDocDatabaseName;

		// Token: 0x0400008A RID: 138
		[AccessedThroughProperty("Label6")]
		private Label _Label6;

		// Token: 0x0400008B RID: 139
		[AccessedThroughProperty("ServerDocDatabasePort")]
		private TextBox _ServerDocDatabasePort;

		// Token: 0x0400008C RID: 140
		[AccessedThroughProperty("Label7")]
		private Label _Label7;

		// Token: 0x0400008D RID: 141
		[AccessedThroughProperty("ServerDocDatabasePassword")]
		private TextBox _ServerDocDatabasePassword;

		// Token: 0x0400008E RID: 142
		[AccessedThroughProperty("Label8")]
		private Label _Label8;

		// Token: 0x0400008F RID: 143
		[AccessedThroughProperty("ServerDocDatabaseUsername")]
		private TextBox _ServerDocDatabaseUsername;

		// Token: 0x04000090 RID: 144
		[AccessedThroughProperty("Label9")]
		private Label _Label9;

		// Token: 0x04000091 RID: 145
		[AccessedThroughProperty("ServerDocDatabaseLocation")]
		private TextBox _ServerDocDatabaseLocation;

		// Token: 0x04000092 RID: 146
		[AccessedThroughProperty("Label10")]
		private Label _Label10;

		// Token: 0x04000093 RID: 147
		[AccessedThroughProperty("GroupBox6")]
		private GroupBox _GroupBox6;

		// Token: 0x04000094 RID: 148
		[AccessedThroughProperty("RadioButton5")]
		private RadioButton _RadioButton5;

		// Token: 0x04000095 RID: 149
		[AccessedThroughProperty("RadioButton6")]
		private RadioButton _RadioButton6;

		// Token: 0x04000096 RID: 150
		[AccessedThroughProperty("GroupBox5")]
		private GroupBox _GroupBox5;

		// Token: 0x04000097 RID: 151
		[AccessedThroughProperty("RadioButton3")]
		private RadioButton _RadioButton3;

		// Token: 0x04000098 RID: 152
		[AccessedThroughProperty("RadioButton4")]
		private RadioButton _RadioButton4;

		// Token: 0x04000099 RID: 153
		[AccessedThroughProperty("GroupBox4")]
		private GroupBox _GroupBox4;

		// Token: 0x0400009A RID: 154
		[AccessedThroughProperty("RadioButton1")]
		private RadioButton _RadioButton1;

		// Token: 0x0400009B RID: 155
		[AccessedThroughProperty("RadioButton2")]
		private RadioButton _RadioButton2;

		// Token: 0x0400009C RID: 156
		private static frmOptions m_vb6FormDefInstance;

		// Token: 0x0400009D RID: 157
		private static bool m_InitializingDefInstance;

		// Token: 0x0400009E RID: 158
		private bool bCancelled;

		// Token: 0x0400009F RID: 159
		private bool bDatabaseChanged;
	}
}
