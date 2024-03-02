using System;
using System.Collections;
using System.Data.SQLite;
using System.Drawing;
using ComPeters;
//using Microsoft.VisualBasic.CompilerServices;
using U2Drawx64.My;

namespace U2Drawx64
{
	// Token: 0x02000010 RID: 16
	[StandardModule]
	public sealed class GlobalVariables
	{
		// Token: 0x060002BD RID: 701 RVA: 0x000A2810 File Offset: 0x000A1810
		public static double Dot(PointF Vector1, PointF vector2)
		{
			double result;
			try
			{
				double num = (double)(Vector1.X * vector2.X + Vector1.Y * vector2.Y);
				result = num;
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
			return result;
		}

		// Token: 0x04000137 RID: 311
		public static Stack UndoStack = new Stack();

		// Token: 0x04000138 RID: 312
		public static DrawingSurface Canvas;

		// Token: 0x04000139 RID: 313
		public static SQLiteConnection drawingDatabaseConnection = new SQLiteConnection(MyProject.Forms.frmDrawing.ConnectionString);

		// Token: 0x0400013A RID: 314
		public static object TriangleSize = 10;

		// Token: 0x0400013B RID: 315
		public static bool SavableChanges = false;

		// Token: 0x0400013C RID: 316
		public static GlobalVariables.DrawMode userMode = GlobalVariables.DrawMode.SelectTool;

		// Token: 0x02000011 RID: 17
		public enum DrawingTypes
		{
			// Token: 0x0400013E RID: 318
			primary = 1,
			// Token: 0x0400013F RID: 319
			auxiliary
		}

		// Token: 0x02000012 RID: 18
		public enum LineStyle
		{
			// Token: 0x04000141 RID: 321
			Dashed = 2,
			// Token: 0x04000142 RID: 322
			Solid = 1
		}

		// Token: 0x02000013 RID: 19
		public enum DrawMode
		{
			// Token: 0x04000144 RID: 324
			SelectTool,
			// Token: 0x04000145 RID: 325
			DrawLines,
			// Token: 0x04000146 RID: 326
			DrawPencil,
			// Token: 0x04000147 RID: 327
			DrawAngledLines,
			// Token: 0x04000148 RID: 328
			Undo,
			// Token: 0x04000149 RID: 329
			DrawText,
			// Token: 0x0400014A RID: 330
			DrawRectangle,
			// Token: 0x0400014B RID: 331
			DrawEllipse,
			// Token: 0x0400014C RID: 332
			DrawTriangle,
			// Token: 0x0400014D RID: 333
			Move,
			// Token: 0x0400014E RID: 334
			DrawMeasureLines,
			// Token: 0x0400014F RID: 335
			DrawSymbol,
			// Token: 0x04000150 RID: 336
			DrawArrow,
			// Token: 0x04000151 RID: 337
			DrawNorthSign,
			// Token: 0x04000152 RID: 338
			DrawArc,
			// Token: 0x04000153 RID: 339
			InsertSymbol,
			// Token: 0x04000154 RID: 340
			InsertText,
			// Token: 0x04000155 RID: 341
			Rotate,
			// Token: 0x04000156 RID: 342
			InsertStamp,
			// Token: 0x04000157 RID: 343
			InsertTemplate,
			// Token: 0x04000158 RID: 344
			Delete,
			// Token: 0x04000159 RID: 345
			Resize
		}

		// Token: 0x02000014 RID: 20
		public enum TextMode
		{
			// Token: 0x0400015B RID: 347
			SingleRow,
			// Token: 0x0400015C RID: 348
			MultiRow
		}

		// Token: 0x02000015 RID: 21
		public enum ShapeType
		{
			// Token: 0x0400015E RID: 350
			Arc = 1,
			// Token: 0x0400015F RID: 351
			Ellipse,
			// Token: 0x04000160 RID: 352
			Line,
			// Token: 0x04000161 RID: 353
			Rectangle,
			// Token: 0x04000162 RID: 354
			Group,
			// Token: 0x04000163 RID: 355
			Stamp,
			// Token: 0x04000164 RID: 356
			Text,
			// Token: 0x04000165 RID: 357
			Triangle
		}
	}
}
