using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Xml;
using ComPeters;
using Microsoft.VisualBasic.Compatibility.VB6;
using Microsoft.VisualBasic.CompilerServices;
using U2Drawx64.My.Resources;

namespace U2Drawx64
{
	// Token: 0x0200000B RID: 11
	internal partial class frmLogin : Form
	{
		// Token: 0x0600004C RID: 76 RVA: 0x0009C700 File Offset: 0x0009B700
		public frmLogin()
		{
			base.Activated += this.frmLogin_Activated;
			base.Load += this.frmLogin_Load;
			this.isRemote = false;
			if (frmLogin.m_vb6FormDefInstance == null)
			{
				if (frmLogin.m_InitializingDefInstance)
				{
					frmLogin.m_vb6FormDefInstance = this;
				}
				else
				{
					try
					{
						if (Assembly.GetExecutingAssembly().EntryPoint.DeclaringType == this.GetType())
						{
							frmLogin.m_vb6FormDefInstance = this;
						}
					}
					catch (Exception ex)
					{
					}
				}
			}
			this.InitializeComponent();
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600004E RID: 78 RVA: 0x0009C7B8 File Offset: 0x0009B7B8
		// (set) Token: 0x0600004F RID: 79 RVA: 0x0009C7CC File Offset: 0x0009B7CC
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

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000050 RID: 80 RVA: 0x0009C820 File Offset: 0x0009B820
		// (set) Token: 0x06000051 RID: 81 RVA: 0x0009C834 File Offset: 0x0009B834
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

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000052 RID: 82 RVA: 0x0009C888 File Offset: 0x0009B888
		// (set) Token: 0x06000053 RID: 83 RVA: 0x0009C89C File Offset: 0x0009B89C
		public virtual TextBox txtPassword
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtPassword;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtPassword = value;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000054 RID: 84 RVA: 0x0009C8A8 File Offset: 0x0009B8A8
		// (set) Token: 0x06000055 RID: 85 RVA: 0x0009C8BC File Offset: 0x0009B8BC
		public virtual Label lblUtiLocateLogin_EnterLogin
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblUtiLocateLogin_EnterLogin;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblUtiLocateLogin_EnterLogin = value;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000056 RID: 86 RVA: 0x0009C8C8 File Offset: 0x0009B8C8
		// (set) Token: 0x06000057 RID: 87 RVA: 0x0009C8DC File Offset: 0x0009B8DC
		public virtual Label lblUtiLocateEmployee
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblUtiLocateEmployee;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblUtiLocateEmployee = value;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000058 RID: 88 RVA: 0x0009C8E8 File Offset: 0x0009B8E8
		// (set) Token: 0x06000059 RID: 89 RVA: 0x0009C8FC File Offset: 0x0009B8FC
		public virtual Label lblUtiLocateLogin_Password
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblUtiLocateLogin_Password;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblUtiLocateLogin_Password = value;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600005A RID: 90 RVA: 0x0009C908 File Offset: 0x0009B908
		// (set) Token: 0x0600005B RID: 91 RVA: 0x0009C91C File Offset: 0x0009B91C
		public virtual LabelArray lblLabels
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblLabels;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblLabels = value;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600005C RID: 92 RVA: 0x0009C928 File Offset: 0x0009B928
		// (set) Token: 0x0600005D RID: 93 RVA: 0x0009C93C File Offset: 0x0009B93C
		internal virtual PictureBox PictureBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PictureBox1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PictureBox1 = value;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600005E RID: 94 RVA: 0x0009C948 File Offset: 0x0009B948
		// (set) Token: 0x0600005F RID: 95 RVA: 0x0009C95C File Offset: 0x0009B95C
		public virtual Label lblCopyright
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblCopyright;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblCopyright = value;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000060 RID: 96 RVA: 0x0009C968 File Offset: 0x0009B968
		// (set) Token: 0x06000061 RID: 97 RVA: 0x0009C97C File Offset: 0x0009B97C
		public virtual Label lblCompany
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblCompany;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblCompany = value;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000062 RID: 98 RVA: 0x0009C988 File Offset: 0x0009B988
		// (set) Token: 0x06000063 RID: 99 RVA: 0x0009C99C File Offset: 0x0009B99C
		public virtual Label lblVersion
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblVersion;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblVersion = value;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000064 RID: 100 RVA: 0x0009C9A8 File Offset: 0x0009B9A8
		// (set) Token: 0x06000065 RID: 101 RVA: 0x0009C9BC File Offset: 0x0009B9BC
		internal virtual ComboBox lstEmployee
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lstEmployee;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				if (this._lstEmployee != null)
				{
					this._lstEmployee.SelectedIndexChanged -= this.lstEmployee_SelectedIndexChanged;
				}
				this._lstEmployee = value;
				if (this._lstEmployee != null)
				{
					this._lstEmployee.SelectedIndexChanged += this.lstEmployee_SelectedIndexChanged;
				}
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000067 RID: 103 RVA: 0x0009D060 File Offset: 0x0009C060
		// (set) Token: 0x06000068 RID: 104 RVA: 0x0009D0A0 File Offset: 0x0009C0A0
		public static frmLogin DefInstance
		{
			get
			{
				if (frmLogin.m_vb6FormDefInstance == null || frmLogin.m_vb6FormDefInstance.IsDisposed)
				{
					frmLogin.m_InitializingDefInstance = true;
					frmLogin.m_vb6FormDefInstance = new frmLogin();
					frmLogin.m_InitializingDefInstance = false;
				}
				return frmLogin.m_vb6FormDefInstance;
			}
			set
			{
				frmLogin.m_vb6FormDefInstance = value;
			}
		}

		// Token: 0x06000069 RID: 105 RVA: 0x0009D0A8 File Offset: 0x0009C0A8
		private void cmdCancel_Click(object eventSender, EventArgs eventArgs)
		{
			modGV.LoginSucceeded = false;
			this.Close();
			Application.Exit();
		}

		// Token: 0x0600006A RID: 106 RVA: 0x0009D0BC File Offset: 0x0009C0BC
		private void cmdOK_Click(object eventSender, EventArgs eventArgs)
		{
		}

		// Token: 0x0600006B RID: 107 RVA: 0x0009D0C0 File Offset: 0x0009C0C0
		private void frmLogin_Activated(object sender, EventArgs e)
		{
			this.Connect();
		}

		// Token: 0x0600006C RID: 108 RVA: 0x0009D0C8 File Offset: 0x0009C0C8
		private void frmLogin_Load(object eventSender, EventArgs eventArgs)
		{
			try
			{
				this.lblVersion.Text = Application.ProductVersion;
				Config.Initialize(Application.StartupPath + "\\settings.dat");
				AutoUpdate autoUpdate = new AutoUpdate();
				if (autoUpdate.UpdateMe(Application.StartupPath, Application.ProductVersion))
				{
					Application.Exit();
				}
			}
			catch (Exception e)
			{
				if (CodeConstructionTools.GetDebugMode() == 1)
				{
					CodeConstructionTools.ReportError(e, "frmLogin_Load: The system was unable to access the local database\r\nand is unable to start up. Please contact your \r\nsupport administrator for assistance", "ERROR IN frmLogin_Load");
				}
			}
			finally
			{
			}
		}

		// Token: 0x0600006D RID: 109 RVA: 0x0009D15C File Offset: 0x0009C15C
		private void Connect()
		{
		}

		// Token: 0x0600006E RID: 110 RVA: 0x0009D160 File Offset: 0x0009C160
		private void SetListToLastUserIfPossible()
		{
			checked
			{
				try
				{
					string text = string.Empty;
					XmlDocument xmlDocument = new XmlDocument();
					if (File.Exists(Application.StartupPath + "\\localSettings.dat"))
					{
						xmlDocument.Load(Application.StartupPath + "\\localSettings.dat");
						XmlNodeList xmlNodeList = xmlDocument.SelectNodes("/U2/ConfigValues");
						try
						{
							foreach (object obj in xmlNodeList)
							{
								XmlNode xmlNode = (XmlNode)obj;
								this.xmlNode = xmlNode.ChildNodes.Item(1);
								this.m_xmld = xmlDocument;
								text = this.xmlNode.InnerXml;
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
						if (!string.IsNullOrEmpty(text))
						{
							int num = 0;
							int num2 = this.lstEmployee.Items.Count - 1;
							for (int i = num; i <= num2; i++)
							{
								modGV.cbItem cbItem = new modGV.cbItem();
								cbItem = (modGV.cbItem)this.lstEmployee.Items[i];
								if (Operators.CompareString(cbItem.ID, text, false) == 0)
								{
									this.lstEmployee.SelectedIndex = i;
									break;
								}
							}
						}
					}
				}
				catch (Exception e)
				{
					if (CodeConstructionTools.GetDebugMode() == 1)
					{
						CodeConstructionTools.ReportError(e, "frmLogin.SetListToLastUserIfPossible: The system was unable to access the local database\r\nand is unable to start up. Please contact your \r\nsupport administrator for assistance", "ERROR IN SetListToLastUserIfPossible");
					}
				}
				finally
				{
				}
			}
		}

		// Token: 0x0600006F RID: 111 RVA: 0x0009D2F8 File Offset: 0x0009C2F8
		private void lstEmployee_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.txtPassword.Clear();
		}

		// Token: 0x0400001E RID: 30
		[AccessedThroughProperty("cmdOK")]
		private Button _cmdOK;

		// Token: 0x0400001F RID: 31
		[AccessedThroughProperty("cmdCancel")]
		private Button _cmdCancel;

		// Token: 0x04000020 RID: 32
		[AccessedThroughProperty("txtPassword")]
		private TextBox _txtPassword;

		// Token: 0x04000021 RID: 33
		[AccessedThroughProperty("lblUtiLocateLogin_EnterLogin")]
		private Label _lblUtiLocateLogin_EnterLogin;

		// Token: 0x04000022 RID: 34
		[AccessedThroughProperty("lblUtiLocateEmployee")]
		private Label _lblUtiLocateEmployee;

		// Token: 0x04000023 RID: 35
		[AccessedThroughProperty("lblUtiLocateLogin_Password")]
		private Label _lblUtiLocateLogin_Password;

		// Token: 0x04000024 RID: 36
		[AccessedThroughProperty("lblLabels")]
		private LabelArray _lblLabels;

		// Token: 0x04000025 RID: 37
		[AccessedThroughProperty("PictureBox1")]
		private PictureBox _PictureBox1;

		// Token: 0x04000026 RID: 38
		[AccessedThroughProperty("lblCopyright")]
		private Label _lblCopyright;

		// Token: 0x04000027 RID: 39
		[AccessedThroughProperty("lblCompany")]
		private Label _lblCompany;

		// Token: 0x04000028 RID: 40
		[AccessedThroughProperty("lblVersion")]
		private Label _lblVersion;

		// Token: 0x04000029 RID: 41
		[AccessedThroughProperty("lstEmployee")]
		private ComboBox _lstEmployee;

		// Token: 0x0400002A RID: 42
		private static frmLogin m_vb6FormDefInstance;

		// Token: 0x0400002B RID: 43
		private static bool m_InitializingDefInstance;

		// Token: 0x0400002C RID: 44
		private XmlDocument m_xmld;

		// Token: 0x0400002D RID: 45
		private XmlNode xmlNode;

		// Token: 0x0400002E RID: 46
		private bool isRemote;
	}
}
