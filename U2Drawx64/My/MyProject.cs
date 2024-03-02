using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;

namespace U2Drawx64.My
{
	// Token: 0x02000004 RID: 4
	[StandardModule]
	[HideModuleName]
	[GeneratedCode("MyTemplate", "8.0.0.0")]
	internal sealed class MyProject
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000006 RID: 6 RVA: 0x000ABE34 File Offset: 0x000AAE34
		[HelpKeyword("My.Computer")]
		internal static MyComputer Computer
		{
			[DebuggerHidden]
			get
			{
				return MyProject.m_ComputerObjectProvider.GetInstance;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000007 RID: 7 RVA: 0x000ABE4C File Offset: 0x000AAE4C
		[HelpKeyword("My.Application")]
		internal static MyApplication Application
		{
			[DebuggerHidden]
			get
			{
				return MyProject.m_AppObjectProvider.GetInstance;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000008 RID: 8 RVA: 0x000ABE64 File Offset: 0x000AAE64
		[HelpKeyword("My.User")]
		internal static User User
		{
			[DebuggerHidden]
			get
			{
				return MyProject.m_UserObjectProvider.GetInstance;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000009 RID: 9 RVA: 0x000ABE7C File Offset: 0x000AAE7C
		[HelpKeyword("My.Forms")]
		internal static MyProject.MyForms Forms
		{
			[DebuggerHidden]
			get
			{
				return MyProject.m_MyFormsObjectProvider.GetInstance;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000A RID: 10 RVA: 0x000ABE94 File Offset: 0x000AAE94
		[HelpKeyword("My.WebServices")]
		internal static MyProject.MyWebServices WebServices
		{
			[DebuggerHidden]
			get
			{
				return MyProject.m_MyWebServicesObjectProvider.GetInstance;
			}
		}

		// Token: 0x04000001 RID: 1
		private static readonly MyProject.ThreadSafeObjectProvider<MyComputer> m_ComputerObjectProvider = new MyProject.ThreadSafeObjectProvider<MyComputer>();

		// Token: 0x04000002 RID: 2
		private static readonly MyProject.ThreadSafeObjectProvider<MyApplication> m_AppObjectProvider = new MyProject.ThreadSafeObjectProvider<MyApplication>();

		// Token: 0x04000003 RID: 3
		private static readonly MyProject.ThreadSafeObjectProvider<User> m_UserObjectProvider = new MyProject.ThreadSafeObjectProvider<User>();

		// Token: 0x04000004 RID: 4
		private static MyProject.ThreadSafeObjectProvider<MyProject.MyForms> m_MyFormsObjectProvider = new MyProject.ThreadSafeObjectProvider<MyProject.MyForms>();

		// Token: 0x04000005 RID: 5
		private static readonly MyProject.ThreadSafeObjectProvider<MyProject.MyWebServices> m_MyWebServicesObjectProvider = new MyProject.ThreadSafeObjectProvider<MyProject.MyWebServices>();

		// Token: 0x02000005 RID: 5
		[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		internal sealed class MyForms
		{
			// Token: 0x17000006 RID: 6
			// (get) Token: 0x0600000B RID: 11 RVA: 0x000ABEAC File Offset: 0x000AAEAC
			// (set) Token: 0x0600000F RID: 15 RVA: 0x000ABF3C File Offset: 0x000AAF3C
			public frmDrawing frmDrawing
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_frmDrawing = MyProject.MyForms.Create__Instance__<frmDrawing>(this.m_frmDrawing);
					return this.m_frmDrawing;
				}
				[DebuggerNonUserCode]
				set
				{
					if (value == this.m_frmDrawing)
					{
						return;
					}
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<frmDrawing>(ref this.m_frmDrawing);
				}
			}

			// Token: 0x17000007 RID: 7
			// (get) Token: 0x0600000C RID: 12 RVA: 0x000ABED0 File Offset: 0x000AAED0
			// (set) Token: 0x06000010 RID: 16 RVA: 0x000ABF64 File Offset: 0x000AAF64
			public frmImageCrop frmImageCrop
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_frmImageCrop = MyProject.MyForms.Create__Instance__<frmImageCrop>(this.m_frmImageCrop);
					return this.m_frmImageCrop;
				}
				[DebuggerNonUserCode]
				set
				{
					if (value == this.m_frmImageCrop)
					{
						return;
					}
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<frmImageCrop>(ref this.m_frmImageCrop);
				}
			}

			// Token: 0x17000008 RID: 8
			// (get) Token: 0x0600000D RID: 13 RVA: 0x000ABEF4 File Offset: 0x000AAEF4
			// (set) Token: 0x06000011 RID: 17 RVA: 0x000ABF8C File Offset: 0x000AAF8C
			public frmLogin frmLogin
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_frmLogin = MyProject.MyForms.Create__Instance__<frmLogin>(this.m_frmLogin);
					return this.m_frmLogin;
				}
				[DebuggerNonUserCode]
				set
				{
					if (value == this.m_frmLogin)
					{
						return;
					}
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<frmLogin>(ref this.m_frmLogin);
				}
			}

			// Token: 0x17000009 RID: 9
			// (get) Token: 0x0600000E RID: 14 RVA: 0x000ABF18 File Offset: 0x000AAF18
			// (set) Token: 0x06000012 RID: 18 RVA: 0x000ABFB4 File Offset: 0x000AAFB4
			public frmOptions frmOptions
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_frmOptions = MyProject.MyForms.Create__Instance__<frmOptions>(this.m_frmOptions);
					return this.m_frmOptions;
				}
				[DebuggerNonUserCode]
				set
				{
					if (value == this.m_frmOptions)
					{
						return;
					}
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<frmOptions>(ref this.m_frmOptions);
				}
			}

			// Token: 0x06000013 RID: 19 RVA: 0x000ABFDC File Offset: 0x000AAFDC
			[DebuggerHidden]
			private static T Create__Instance__<T>(T Instance) where T : Form, new()
			{
				if (Instance == null || Instance.IsDisposed)
				{
					if (MyProject.MyForms.m_FormBeingCreated != null)
					{
						if (MyProject.MyForms.m_FormBeingCreated.ContainsKey(typeof(T)))
						{
							throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
						}
					}
					else
					{
						MyProject.MyForms.m_FormBeingCreated = new Hashtable();
					}
					MyProject.MyForms.m_FormBeingCreated.Add(typeof(T), null);
					try
					{
						return Activator.CreateInstance<T>();
					}
					catch (TargetInvocationException ex) when (ex.InnerException != null)
					{
						string resourceString = Utils.GetResourceString("WinForms_SeeInnerException", new string[]
						{
							ex.InnerException.Message
						});
						throw new InvalidOperationException(resourceString, ex.InnerException);
					}
					finally
					{
						MyProject.MyForms.m_FormBeingCreated.Remove(typeof(T));
					}
					return Instance;
				}
				return Instance;
			}

			// Token: 0x06000014 RID: 20 RVA: 0x000AC0E8 File Offset: 0x000AB0E8
			[DebuggerHidden]
			private void Dispose__Instance__<T>(ref T instance) where T : Form
			{
				instance.Dispose();
				instance = default(T);
			}

			// Token: 0x06000015 RID: 21 RVA: 0x000AC110 File Offset: 0x000AB110
			[EditorBrowsable(EditorBrowsableState.Never)]
			[DebuggerHidden]
			public MyForms()
			{
			}

			// Token: 0x06000016 RID: 22 RVA: 0x000AC118 File Offset: 0x000AB118
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override bool Equals(object o)
			{
				return base.Equals(RuntimeHelpers.GetObjectValue(o));
			}

			// Token: 0x06000017 RID: 23 RVA: 0x000AC134 File Offset: 0x000AB134
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override int GetHashCode()
			{
				return base.GetHashCode();
			}

			// Token: 0x06000018 RID: 24 RVA: 0x000AC148 File Offset: 0x000AB148
			[EditorBrowsable(EditorBrowsableState.Never)]
			internal new Type GetType()
			{
				return typeof(MyProject.MyForms);
			}

			// Token: 0x06000019 RID: 25 RVA: 0x000AC160 File Offset: 0x000AB160
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override string ToString()
			{
				return base.ToString();
			}

			// Token: 0x04000006 RID: 6
			public frmDrawing m_frmDrawing;

			// Token: 0x04000007 RID: 7
			public frmImageCrop m_frmImageCrop;

			// Token: 0x04000008 RID: 8
			public frmLogin m_frmLogin;

			// Token: 0x04000009 RID: 9
			public frmOptions m_frmOptions;

			// Token: 0x0400000A RID: 10
			[ThreadStatic]
			private static Hashtable m_FormBeingCreated;
		}

		// Token: 0x02000006 RID: 6
		[EditorBrowsable(EditorBrowsableState.Never)]
		[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
		internal sealed class MyWebServices
		{
			// Token: 0x0600001A RID: 26 RVA: 0x000AC174 File Offset: 0x000AB174
			[EditorBrowsable(EditorBrowsableState.Never)]
			[DebuggerHidden]
			public override bool Equals(object o)
			{
				return base.Equals(RuntimeHelpers.GetObjectValue(o));
			}

			// Token: 0x0600001B RID: 27 RVA: 0x000AC190 File Offset: 0x000AB190
			[EditorBrowsable(EditorBrowsableState.Never)]
			[DebuggerHidden]
			public override int GetHashCode()
			{
				return base.GetHashCode();
			}

			// Token: 0x0600001C RID: 28 RVA: 0x000AC1A4 File Offset: 0x000AB1A4
			[DebuggerHidden]
			[EditorBrowsable(EditorBrowsableState.Never)]
			internal new Type GetType()
			{
				return typeof(MyProject.MyWebServices);
			}

			// Token: 0x0600001D RID: 29 RVA: 0x000AC1BC File Offset: 0x000AB1BC
			[EditorBrowsable(EditorBrowsableState.Never)]
			[DebuggerHidden]
			public override string ToString()
			{
				return base.ToString();
			}

			// Token: 0x0600001E RID: 30 RVA: 0x000AC1D0 File Offset: 0x000AB1D0
			[DebuggerHidden]
			private static T Create__Instance__<T>(T instance) where T : new()
			{
				if (instance == null)
				{
					return Activator.CreateInstance<T>();
				}
				return instance;
			}

			// Token: 0x0600001F RID: 31 RVA: 0x000AC1EC File Offset: 0x000AB1EC
			[DebuggerHidden]
			private void Dispose__Instance__<T>(ref T instance)
			{
				instance = default(T);
			}

			// Token: 0x06000020 RID: 32 RVA: 0x000AC208 File Offset: 0x000AB208
			[EditorBrowsable(EditorBrowsableState.Never)]
			[DebuggerHidden]
			public MyWebServices()
			{
			}
		}

		// Token: 0x02000007 RID: 7
		[ComVisible(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		internal sealed class ThreadSafeObjectProvider<T> where T : new()
		{
			// Token: 0x1700000A RID: 10
			// (get) Token: 0x06000021 RID: 33 RVA: 0x000AC210 File Offset: 0x000AB210
			internal T GetInstance
			{
				[DebuggerHidden]
				get
				{
					if (MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue == null)
					{
						MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue = Activator.CreateInstance<T>();
					}
					return MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue;
				}
			}

			// Token: 0x06000022 RID: 34 RVA: 0x000AC238 File Offset: 0x000AB238
			[DebuggerHidden]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public ThreadSafeObjectProvider()
			{
			}

			// Token: 0x0400000B RID: 11
			[ThreadStatic]
			[CompilerGenerated]
			private static T m_ThreadStaticValue;
		}
	}
}
