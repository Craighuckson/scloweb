using System;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using ComPeters;
using OpenTK.Graphics.OpenGL;

namespace U2Drawx64
{
	// Token: 0x0200001D RID: 29
	public class Grid : IShape
	{
		// Token: 0x06000334 RID: 820 RVA: 0x000A4B80 File Offset: 0x000A3B80
		public Grid()
		{
			this._colour = Color.Black;
			this._thickness = 1;
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x06000335 RID: 821 RVA: 0x000A4B9C File Offset: 0x000A3B9C
		public bool isSelected
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x06000336 RID: 822 RVA: 0x000A4BAC File Offset: 0x000A3BAC
		// (set) Token: 0x06000337 RID: 823 RVA: 0x000A4BC0 File Offset: 0x000A3BC0
		public Color Colour
		{
			get
			{
				return this._colour;
			}
			set
			{
				this._colour = value;
			}
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x06000338 RID: 824 RVA: 0x000A4BCC File Offset: 0x000A3BCC
		public Rectangle BoundingRectangle
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x06000339 RID: 825 RVA: 0x000A4BDC File Offset: 0x000A3BDC
		// (set) Token: 0x0600033A RID: 826 RVA: 0x000A4BEC File Offset: 0x000A3BEC
		public bool CanSelect
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x0600033B RID: 827 RVA: 0x000A4BF0 File Offset: 0x000A3BF0
		// (set) Token: 0x0600033C RID: 828 RVA: 0x000A4C00 File Offset: 0x000A3C00
		public GlobalVariables.LineStyle LineStyle
		{
			get
			{
				GlobalVariables.LineStyle result;
				return result;
			}
			set
			{
			}
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x0600033D RID: 829 RVA: 0x000A4C04 File Offset: 0x000A3C04
		// (set) Token: 0x0600033E RID: 830 RVA: 0x000A4C18 File Offset: 0x000A3C18
		public long ShapeID
		{
			get
			{
				return this._ShapeID;
			}
			set
			{
				this._ShapeID = value;
			}
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x0600033F RID: 831 RVA: 0x000A4C24 File Offset: 0x000A3C24
		// (set) Token: 0x06000340 RID: 832 RVA: 0x000A4C34 File Offset: 0x000A3C34
		public int Thickness
		{
			get
			{
				int result;
				return result;
			}
			set
			{
			}
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x06000341 RID: 833 RVA: 0x000A4C38 File Offset: 0x000A3C38
		// (set) Token: 0x06000342 RID: 834 RVA: 0x000A4C4C File Offset: 0x000A3C4C
		public bool Visible
		{
			get
			{
				return this._visible;
			}
			set
			{
				this._visible = value;
			}
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x06000343 RID: 835 RVA: 0x000A4C58 File Offset: 0x000A3C58
		public GlobalVariables.ShapeType ShapeType
		{
			get
			{
				GlobalVariables.ShapeType result;
				return result;
			}
		}

		// Token: 0x06000344 RID: 836 RVA: 0x000A4C68 File Offset: 0x000A3C68
		public IShape Clone()
		{
			return null;
		}

		// Token: 0x06000345 RID: 837 RVA: 0x000A4C78 File Offset: 0x000A3C78
		public void Draw()
		{
			checked
			{
				try
				{
					GL.Color3(this._colour);
					GL.PointSize((float)this._thickness);
					GL.Begin(BeginMode.Points);
					int num = 0;
					int width = GlobalVariables.Canvas.Width;
					for (int i = num; i <= width; i += 10)
					{
						int num2 = 0;
						int height = GlobalVariables.Canvas.Height;
						for (int j = num2; j <= height; j += 10)
						{
							GL.Vertex2(i, j);
						}
					}
					GL.End();
				}
				catch (Exception ex)
				{
					ComPetersError.DisplayError(ex);
				}
			}
		}

		// Token: 0x06000346 RID: 838 RVA: 0x000A4D08 File Offset: 0x000A3D08
		public bool isInSelection(PointF First, PointF Last)
		{
			bool result;
			return result;
		}

		// Token: 0x06000347 RID: 839 RVA: 0x000A4D18 File Offset: 0x000A3D18
		public void Move(int AddToX, int AddToY)
		{
		}

		// Token: 0x06000348 RID: 840 RVA: 0x000A4D1C File Offset: 0x000A3D1C
		public void Rotate(double radians, PointF Pivot)
		{
		}

		// Token: 0x06000349 RID: 841 RVA: 0x000A4D20 File Offset: 0x000A3D20
		public void SelectThis()
		{
		}

		// Token: 0x0600034A RID: 842 RVA: 0x000A4D24 File Offset: 0x000A3D24
		public void Unselect()
		{
		}

		// Token: 0x0600034B RID: 843 RVA: 0x000A4D28 File Offset: 0x000A3D28
		public void SaveToTemplate(SQLiteConnection database, SQLiteTransaction trans, long TemplateID, string FileName = "")
		{
		}

		// Token: 0x0600034C RID: 844 RVA: 0x000A4D2C File Offset: 0x000A3D2C
		public void Load(DataTable data, Undo undoObj, string FileName = "")
		{
		}

		// Token: 0x0600034D RID: 845 RVA: 0x000A4D30 File Offset: 0x000A3D30
		public bool isInSelection(PointF Pixel)
		{
			bool result;
			return result;
		}

		// Token: 0x0600034E RID: 846 RVA: 0x000A4D40 File Offset: 0x000A3D40
		public void Resize(double X, double Y)
		{
		}

		// Token: 0x0400018D RID: 397
		private long _ShapeID;

		// Token: 0x0400018E RID: 398
		private Color _colour;

		// Token: 0x0400018F RID: 399
		private GlobalVariables.LineStyle _linestyle;

		// Token: 0x04000190 RID: 400
		private bool _visible;

		// Token: 0x04000191 RID: 401
		private int _thickness;

		// Token: 0x04000192 RID: 402
		private Rectangle _BoundingRectangle;
	}
}
