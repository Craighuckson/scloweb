using System;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace U2Drawx64.My
{
	// Token: 0x02000019 RID: 25
	[HideModuleName]
	[DebuggerNonUserCode]
	[CompilerGenerated]
	[StandardModule]
	internal sealed class MySettingsProperty
	{
		// Token: 0x17000112 RID: 274
		// (get) Token: 0x060002EC RID: 748 RVA: 0x000A3088 File Offset: 0x000A2088
		[HelpKeyword("My.Settings")]
		internal static MySettings Settings
		{
			get
			{
				return MySettings.Default;
			}
		}
	}
}
