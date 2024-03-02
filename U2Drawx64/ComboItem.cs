using System;
using System.Diagnostics;

namespace U2Drawx64
{
	// Token: 0x02000008 RID: 8
	public class ComboItem
	{
		// Token: 0x06000023 RID: 35 RVA: 0x0009AFFC File Offset: 0x00099FFC
		[DebuggerNonUserCode]
		public ComboItem()
		{
		}

		// Token: 0x06000024 RID: 36 RVA: 0x0009B004 File Offset: 0x0009A004
		public override string ToString()
		{
			return this.name;
		}

		// Token: 0x0400000C RID: 12
		public string ID;

		// Token: 0x0400000D RID: 13
		public string name;
	}
}
