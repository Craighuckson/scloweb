using System;
using System.Data;
using System.Data.SQLite;
using System.Drawing;

namespace U2Drawx64
{
	// Token: 0x0200001E RID: 30
	public interface IShape
	{
		// Token: 0x17000132 RID: 306
		// (get) Token: 0x0600034F RID: 847
		// (set) Token: 0x06000350 RID: 848
		long ShapeID { get; set; }

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x06000351 RID: 849
		// (set) Token: 0x06000352 RID: 850
		Color Colour { get; set; }

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x06000353 RID: 851
		// (set) Token: 0x06000354 RID: 852
		int Thickness { get; set; }

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x06000355 RID: 853
		// (set) Token: 0x06000356 RID: 854
		GlobalVariables.LineStyle LineStyle { get; set; }

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x06000357 RID: 855
		// (set) Token: 0x06000358 RID: 856
		bool Visible { get; set; }

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x06000359 RID: 857
		Rectangle BoundingRectangle { get; }

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x0600035A RID: 858
		GlobalVariables.ShapeType ShapeType { get; }

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x0600035B RID: 859
		// (set) Token: 0x0600035C RID: 860
		bool canSelect { get; set; }

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x0600035D RID: 861
		bool isSelected { get; }

		// Token: 0x0600035E RID: 862
		bool isInSelection(PointF First, PointF Last);

		// Token: 0x0600035F RID: 863
		bool isInSelection(PointF Pixel);

		// Token: 0x06000360 RID: 864
		IShape Clone();

		// Token: 0x06000361 RID: 865
		void SelectThis();

		// Token: 0x06000362 RID: 866
		void Unselect();

		// Token: 0x06000363 RID: 867
		void Draw();

		// Token: 0x06000364 RID: 868
		void Move(int AddToX, int AddToY);

		// Token: 0x06000365 RID: 869
		void Rotate(double radians, PointF Pivot);

		// Token: 0x06000366 RID: 870
		void Resize(double X, double Y);

		// Token: 0x06000367 RID: 871
		void SaveToTemplate(SQLiteConnection database, SQLiteTransaction trans, long TemplateID, string FileName = "");

		// Token: 0x06000368 RID: 872
		void Load(DataTable data, Undo undoObj, string FileName = "");
	}
}
