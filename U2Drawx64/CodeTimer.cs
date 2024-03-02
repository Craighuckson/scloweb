using System;
using System.Diagnostics;
using Microsoft.VisualBasic;

namespace U2Drawx64
{
	// Token: 0x02000026 RID: 38
	public class CodeTimer
	{
		// Token: 0x0600043F RID: 1087 RVA: 0x000ABAE8 File Offset: 0x000AAAE8
		[DebuggerNonUserCode]
		public CodeTimer()
		{
		}

		// Token: 0x06000440 RID: 1088 RVA: 0x000ABAF0 File Offset: 0x000AAAF0
		[Conditional("DEBUG")]
		public static void Start()
		{
			CodeTimer.Start_Time = DateAndTime.Now;
			StackTrace stackTrace = new StackTrace(true);
			CodeTimer.previousLine = stackTrace.GetFrame(1).GetFileLineNumber();
			CodeTimer.Reports = 1;
			CodeTimer.PreviousTime = TimeSpan.Zero;
		}

		// Token: 0x06000441 RID: 1089 RVA: 0x000ABB30 File Offset: 0x000AAB30
		[Conditional("DEBUG")]
		public static void Report()
		{
			TimeSpan previousTime = DateAndTime.Now - CodeTimer.Start_Time;
			StackTrace stackTrace = new StackTrace(true);
			string fileName = stackTrace.GetFrame(1).GetFileName();
			checked
			{
				string text = fileName.Substring(fileName.LastIndexOf("\\") + 1);
				int fileLineNumber = stackTrace.GetFrame(1).GetFileLineNumber();
				CodeTimer.previousLine = stackTrace.GetFrame(1).GetFileLineNumber();
				CodeTimer.PreviousTime = previousTime;
				CodeTimer.Reports++;
			}
		}

		// Token: 0x040001E1 RID: 481
		private static DateTime Start_Time;

		// Token: 0x040001E2 RID: 482
		private static int Reports = 0;

		// Token: 0x040001E3 RID: 483
		private static int previousLine = 0;

		// Token: 0x040001E4 RID: 484
		private static TimeSpan PreviousTime;
	}
}
