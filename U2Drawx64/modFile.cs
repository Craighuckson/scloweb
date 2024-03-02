using System;
using ComPeters;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace U2Drawx64
{
	// Token: 0x02000027 RID: 39
	[StandardModule]
	internal sealed class modFile
	{
		// Token: 0x06000442 RID: 1090 RVA: 0x000ABBA8 File Offset: 0x000AABA8
		public static string PathAndFile(ref string Path, ref string filename)
		{
			string result;
			if (Operators.CompareString(Strings.Right(Path, 1), "\\", false) == 0)
			{
				result = Path + filename;
			}
			else
			{
				result = Path + "\\" + filename;
			}
			return result;
		}

		// Token: 0x06000443 RID: 1091 RVA: 0x000ABBE8 File Offset: 0x000AABE8
		public static string GetFilePath(ref string Filename)
		{
			string empty;
			try
			{
				empty = string.Empty;
			}
			catch (Exception ex)
			{
				if (CodeConstructionTools.GetDebugMode() == 1)
				{
					CodeConstructionTools.ReportError(ex, "modFile.GetFilePath(ByRef: System was unable to complete the operation", "ERROR IN modFile.GetFilePath(ByRef" + ex.StackTrace);
				}
				empty = string.Empty;
			}
			finally
			{
			}
			return empty;
		}

		// Token: 0x06000444 RID: 1092 RVA: 0x000ABC54 File Offset: 0x000AAC54
		public static string GetFileNameOnly(ref object strFilePath)
		{
			checked
			{
				string result;
				if (Strings.Len(Operators.ConcatenateObject(strFilePath, "")) == 0)
				{
					result = "";
				}
				else
				{
					string text;
					if (Operators.CompareString(Strings.Right(Conversions.ToString(strFilePath), 1), "\\", false) == 0)
					{
						text = "";
					}
					else
					{
						short num = (short)Strings.InStr(Strings.StrReverse(Conversions.ToString(strFilePath)), "\\", CompareMethod.Binary);
						text = Strings.Right(Conversions.ToString(strFilePath), (int)(num - 1));
					}
					int num2 = Strings.InStr(text, ".", CompareMethod.Binary);
					text = Strings.Mid(text, 1, num2 - 1);
					result = text;
				}
				return result;
			}
		}

		// Token: 0x040001E5 RID: 485
		private static string sFilename;
	}
}
