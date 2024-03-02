using System;

namespace U2Drawx64
{
	// Token: 0x02000016 RID: 22
	public class LineTypeItem
	{
		// Token: 0x060002BE RID: 702 RVA: 0x000A2868 File Offset: 0x000A1868
		public LineTypeItem(string Description, string LineText)
		{
			this._LineText = string.Empty;
			this._Description = string.Empty;
			this._LineText = LineText;
			this._Description = Description;
		}

		// Token: 0x060002BF RID: 703 RVA: 0x000A2894 File Offset: 0x000A1894
		public override string ToString()
		{
			return this._Description;
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x060002C0 RID: 704 RVA: 0x000A28A8 File Offset: 0x000A18A8
		public string LineText
		{
			get
			{
				return this._LineText;
			}
		}

		// Token: 0x04000166 RID: 358
		private string _LineText;

		// Token: 0x04000167 RID: 359
		private string _Description;
	}
}
