using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace U2Drawx64.My
{
	// Token: 0x02000018 RID: 24
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "8.0.0.0")]
	internal sealed partial class MySettings : ApplicationSettingsBase
	{
		// Token: 0x060002EA RID: 746 RVA: 0x000A3008 File Offset: 0x000A2008
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		[DebuggerNonUserCode]
		private static void AutoSaveSettings(object sender, EventArgs e)
		{
			if (MyProject.Application.SaveMySettingsOnExit)
			{
				MySettingsProperty.Settings.Save();
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x060002EB RID: 747 RVA: 0x000A3020 File Offset: 0x000A2020
		public static MySettings Default
		{
			get
			{
				if (!MySettings.addedHandler)
				{
					object obj = MySettings.addedHandlerLockObject;
					ObjectFlowControl.CheckForSyncLockOnValueType(obj);
					lock (obj)
					{
						if (!MySettings.addedHandler)
						{
							MyProject.Application.Shutdown += MySettings.AutoSaveSettings;
							MySettings.addedHandler = true;
						}
					}
				}
				return MySettings.defaultInstance;
			}
		}

		// Token: 0x0400016A RID: 362
		private static MySettings defaultInstance = (MySettings)SettingsBase.Synchronized(new MySettings());

		// Token: 0x0400016B RID: 363
		private static bool addedHandler;

		// Token: 0x0400016C RID: 364
		private static object addedHandlerLockObject = RuntimeHelpers.GetObjectValue(new object());
	}
}
