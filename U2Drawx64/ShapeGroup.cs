using System;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using ComPeters;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace U2Drawx64
{
	// Token: 0x02000021 RID: 33
	public class ShapeGroup : IShape
	{
		// Token: 0x060003AC RID: 940 RVA: 0x000A72E8 File Offset: 0x000A62E8
		public ShapeGroup()
		{
			this._Thickness = 1;
			this._Visible = true;
			this._IsSelected = false;
			this.Shapes = new IShape[0];
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x060003AD RID: 941 RVA: 0x000A7314 File Offset: 0x000A6314
		// (set) Token: 0x060003AE RID: 942 RVA: 0x000A7328 File Offset: 0x000A6328
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

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x060003AF RID: 943 RVA: 0x000A7334 File Offset: 0x000A6334
		// (set) Token: 0x060003B0 RID: 944 RVA: 0x000A7348 File Offset: 0x000A6348
		public int Thickness
		{
			get
			{
				return this._Thickness;
			}
			set
			{
				this._Thickness = value;
				foreach (IShape shape in this.Shapes)
				{
					shape.Thickness = value;
				}
			}
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x060003B1 RID: 945 RVA: 0x000A737C File Offset: 0x000A637C
		// (set) Token: 0x060003B2 RID: 946 RVA: 0x000A7390 File Offset: 0x000A6390
		public GlobalVariables.LineStyle LineStyle
		{
			get
			{
				return this._linestyle;
			}
			set
			{
				this._linestyle = value;
				foreach (IShape shape in this.Shapes)
				{
					shape.LineStyle = value;
				}
			}
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x060003B3 RID: 947 RVA: 0x000A73C4 File Offset: 0x000A63C4
		// (set) Token: 0x060003B4 RID: 948 RVA: 0x000A73D8 File Offset: 0x000A63D8
		public Color Colour
		{
			get
			{
				return this._Colour;
			}
			set
			{
				this._Colour = value;
				foreach (IShape shape in this.Shapes)
				{
					shape.Colour = value;
				}
			}
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x060003B5 RID: 949 RVA: 0x000A740C File Offset: 0x000A640C
		// (set) Token: 0x060003B6 RID: 950 RVA: 0x000A7420 File Offset: 0x000A6420
		public bool Visible
		{
			get
			{
				return this._Visible;
			}
			set
			{
				this._Visible = value;
			}
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x060003B7 RID: 951 RVA: 0x000A742C File Offset: 0x000A642C
		public Rectangle BoundingRectangle
		{
			get
			{
				return this._BoundingRectangle;
			}
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x060003B8 RID: 952 RVA: 0x000A7440 File Offset: 0x000A6440
		public GlobalVariables.ShapeType ShapeType
		{
			get
			{
				return GlobalVariables.ShapeType.Group;
			}
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x060003B9 RID: 953 RVA: 0x000A7450 File Offset: 0x000A6450
		// (set) Token: 0x060003BA RID: 954 RVA: 0x000A7460 File Offset: 0x000A6460
		public bool CanSelect
		{
			get
			{
				return true;
			}
			set
			{
			}
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x060003BB RID: 955 RVA: 0x000A7464 File Offset: 0x000A6464
		public bool isSelected
		{
			get
			{
				return this._IsSelected;
			}
		}

		// Token: 0x060003BC RID: 956 RVA: 0x000A7478 File Offset: 0x000A6478
		public void CalculateBoundingRectangle()
		{
			try
			{
				PointF pointF = new PointF((float)GlobalVariables.Canvas.Width, (float)GlobalVariables.Canvas.Height);
				PointF pointF2 = new PointF(0f, 0f);
				foreach (IShape shape in this.Shapes)
				{
					if (Information.IsNothing(shape.BoundingRectangle))
					{
						return;
					}
					foreach (PointF pointF3 in shape.BoundingRectangle.Vertices)
					{
						pointF.X = Math.Min(pointF3.X, pointF.X);
						pointF.Y = Math.Min(pointF3.Y, pointF.Y);
						pointF2.X = Math.Max(pointF3.X, pointF2.X);
						pointF2.Y = Math.Max(pointF3.Y, pointF2.Y);
					}
				}
				this._BoundingRectangle = new Rectangle();
				Rectangle boundingRectangle = this._BoundingRectangle;
				PointF vertex = new PointF(pointF.X, pointF.Y);
				boundingRectangle.AddVertices(vertex);
				Rectangle boundingRectangle2 = this._BoundingRectangle;
				vertex = new PointF(pointF2.X, pointF.Y);
				boundingRectangle2.AddVertices(vertex);
				Rectangle boundingRectangle3 = this._BoundingRectangle;
				vertex = new PointF(pointF2.X, pointF2.Y);
				boundingRectangle3.AddVertices(vertex);
				Rectangle boundingRectangle4 = this._BoundingRectangle;
				Point p = checked(new Point((int)Math.Round((double)pointF.X), (int)Math.Round((double)pointF2.Y)));
				boundingRectangle4.AddVertices(p);
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x060003BD RID: 957 RVA: 0x000A7668 File Offset: 0x000A6668
		public void Add(IShape Shape)
		{
			try
			{
				long num = (long)this.Shapes.Length;
				checked
				{
					this.Shapes = (IShape[])Utils.CopyArray((Array)this.Shapes, new IShape[(int)num + 1]);
					this.Shapes[(int)num] = Shape;
					this.CalculateBoundingRectangle();
				}
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x060003BE RID: 958 RVA: 0x000A76DC File Offset: 0x000A66DC
		public void Remove(IShape Shape)
		{
			try
			{
				long shapeID = Shape.ShapeID;
				if (shapeID != (long)(checked(this.Shapes.Length - 1)))
				{
					long num = shapeID;
					long num2 = (long)(checked(this.Shapes.Length - 2));
					checked
					{
						for (long num3 = num; num3 <= num2; num3 += 1L)
						{
							this.Shapes[(int)num3] = this.Shapes[(int)(num3 + 1L)];
						}
					}
				}
				this.Shapes = (IShape[])Utils.CopyArray((Array)this.Shapes, new IShape[checked(this.Shapes.Length - 2 + 1)]);
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x060003BF RID: 959 RVA: 0x000A7780 File Offset: 0x000A6780
		public void Draw()
		{
			try
			{
				foreach (IShape shape in this.Shapes)
				{
					shape.Draw();
				}
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x060003C0 RID: 960 RVA: 0x000A77D4 File Offset: 0x000A67D4
		public bool isInSelection(PointF first, PointF last)
		{
			bool result;
			try
			{
				foreach (IShape shape in this.Shapes)
				{
					if (!shape.isInSelection(first, last))
					{
						return false;
					}
				}
				result = true;
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
				result = false;
			}
			return result;
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x000A7838 File Offset: 0x000A6838
		public void SelectThis()
		{
			this.Colour = Color.LightGreen;
			this._IsSelected = true;
			GlobalVariables.Canvas.AddShapeToSelection(this);
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x000A7858 File Offset: 0x000A6858
		public void Unselect()
		{
			this.Colour = Color.Black;
			this._IsSelected = false;
		}

		// Token: 0x060003C3 RID: 963 RVA: 0x000A786C File Offset: 0x000A686C
		public void Move(int AddToX, int AddToY)
		{
			try
			{
				foreach (IShape shape in this.Shapes)
				{
					shape.Move(AddToX, AddToY);
				}
				this.CalculateBoundingRectangle();
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x000A78C8 File Offset: 0x000A68C8
		public void Rotate(double radians, PointF Pivot)
		{
			try
			{
				foreach (IShape shape in this.Shapes)
				{
					shape.Rotate(radians, Pivot);
				}
				this._BoundingRectangle.Rotate(radians, Pivot);
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x000A792C File Offset: 0x000A692C
		public IShape Clone()
		{
			IShape result;
			try
			{
				ShapeGroup shapeGroup = new ShapeGroup();
				foreach (IShape shape in this.Shapes)
				{
					shapeGroup.Add(shape.Clone());
				}
				result = shapeGroup;
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
				result = null;
			}
			return result;
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x000A7998 File Offset: 0x000A6998
		public void SaveToTemplate(SQLiteConnection database, SQLiteTransaction trans, long TemplateID, string FileName = "")
		{
			try
			{
				foreach (IShape shape in this.Shapes)
				{
					shape.SaveToTemplate(database, trans, TemplateID, "");
				}
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x000A79F4 File Offset: 0x000A69F4
		public void Load(DataTable data, Undo undoObj, string FileName = "")
		{
		}

		// Token: 0x060003C8 RID: 968 RVA: 0x000A79F8 File Offset: 0x000A69F8
		public bool isInSelection(PointF Pixel)
		{
			bool result;
			try
			{
				foreach (IShape shape in this.Shapes)
				{
					if (shape.isInSelection(Pixel))
					{
						return true;
					}
				}
				result = false;
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
			return result;
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x000A7A58 File Offset: 0x000A6A58
		public void Resize(double X, double Y)
		{
		}

		// Token: 0x040001A6 RID: 422
		private long _ShapeID;

		// Token: 0x040001A7 RID: 423
		private Color _Colour;

		// Token: 0x040001A8 RID: 424
		private int _Thickness;

		// Token: 0x040001A9 RID: 425
		private GlobalVariables.LineStyle _linestyle;

		// Token: 0x040001AA RID: 426
		private bool _Visible;

		// Token: 0x040001AB RID: 427
		private bool _IsSelected;

		// Token: 0x040001AC RID: 428
		public IShape[] Shapes;

		// Token: 0x040001AD RID: 429
		private Rectangle _BoundingRectangle;
	}
}
