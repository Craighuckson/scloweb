using System;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using ComPeters;
using Microsoft.VisualBasic.CompilerServices;
using OpenTK.Graphics.OpenGL;

namespace U2Drawx64
{
	// Token: 0x0200001A RID: 26
	public class Arc : IShape
	{
		// Token: 0x060002ED RID: 749 RVA: 0x000A309C File Offset: 0x000A209C
		public Arc()
		{
			this._Colour = Color.Black;
			this._Thickness = 1;
			this._Visible = true;
			this._IsSelected = false;
			this._canSelect = false;
			this.CreationIsCompleted = false;
			this.Vertices = new PointF[0];
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x060002EE RID: 750 RVA: 0x000A30D8 File Offset: 0x000A20D8
		// (set) Token: 0x060002EF RID: 751 RVA: 0x000A30EC File Offset: 0x000A20EC
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

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x060002F0 RID: 752 RVA: 0x000A30F8 File Offset: 0x000A20F8
		// (set) Token: 0x060002F1 RID: 753 RVA: 0x000A310C File Offset: 0x000A210C
		public Arc.ArcType MyArcType
		{
			get
			{
				return this._MyArcType;
			}
			set
			{
				this._MyArcType = value;
				this.SetAngles();
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x060002F2 RID: 754 RVA: 0x000A311C File Offset: 0x000A211C
		// (set) Token: 0x060002F3 RID: 755 RVA: 0x000A3130 File Offset: 0x000A2130
		public Color Colour
		{
			get
			{
				return this._Colour;
			}
			set
			{
				this._Colour = value;
			}
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x060002F4 RID: 756 RVA: 0x000A313C File Offset: 0x000A213C
		// (set) Token: 0x060002F5 RID: 757 RVA: 0x000A3150 File Offset: 0x000A2150
		public int Thickness
		{
			get
			{
				return this._Thickness;
			}
			set
			{
				this._Thickness = value;
			}
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x060002F6 RID: 758 RVA: 0x000A315C File Offset: 0x000A215C
		// (set) Token: 0x060002F7 RID: 759 RVA: 0x000A3170 File Offset: 0x000A2170
		public GlobalVariables.LineStyle LineStyle
		{
			get
			{
				return this._lineStyle;
			}
			set
			{
				this._lineStyle = value;
			}
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x060002F8 RID: 760 RVA: 0x000A317C File Offset: 0x000A217C
		// (set) Token: 0x060002F9 RID: 761 RVA: 0x000A3190 File Offset: 0x000A2190
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

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x060002FA RID: 762 RVA: 0x000A319C File Offset: 0x000A219C
		public Rectangle BoundingRectangle
		{
			get
			{
				return this._BoundingRectangle;
			}
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x060002FB RID: 763 RVA: 0x000A31B0 File Offset: 0x000A21B0
		public GlobalVariables.ShapeType ShapeType
		{
			get
			{
				return GlobalVariables.ShapeType.Arc;
			}
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x060002FC RID: 764 RVA: 0x000A31C0 File Offset: 0x000A21C0
		// (set) Token: 0x060002FD RID: 765 RVA: 0x000A31D0 File Offset: 0x000A21D0
		public bool canSelect
		{
			get
			{
				return true;
			}
			set
			{
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x060002FE RID: 766 RVA: 0x000A31D4 File Offset: 0x000A21D4
		public bool isSelected
		{
			get
			{
				return this._IsSelected;
			}
		}

		// Token: 0x060002FF RID: 767 RVA: 0x000A31E8 File Offset: 0x000A21E8
		public void FinishCreation()
		{
			try
			{
				this.CreationIsCompleted = true;
				double startAngle = this._StartAngle;
				double endAngle = this._EndAngle;
				for (double num = startAngle; num <= endAngle; num += 0.01)
				{
					PointF vertex = new PointF((float)((double)this._Width * Math.Cos(num) + (double)this._Center.X), (float)((double)this._Height * Math.Sin(num) + (double)this._Center.Y));
					this.AddVertices(vertex);
				}
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x06000300 RID: 768 RVA: 0x000A3288 File Offset: 0x000A2288
		public void AddVertices(PointF Vertex)
		{
			try
			{
				long num = (long)this.Vertices.Length;
				checked
				{
					this.Vertices = (PointF[])Utils.CopyArray((Array)this.Vertices, new PointF[(int)num + 1]);
					this.Vertices[(int)num] = Vertex;
				}
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x06000301 RID: 769 RVA: 0x000A32FC File Offset: 0x000A22FC
		public void CreateArc(Rectangle rect)
		{
			checked
			{
				try
				{
					this._BoundingRectangle = rect;
					this._Width = (int)Math.Round(rect.width);
					this._Height = (int)Math.Round(rect.height);
					this._Center = rect.Vertices[1];
					if (rect.Vertices[0].X <= rect.Vertices[2].X & rect.Vertices[0].Y <= rect.Vertices[2].Y)
					{
						this.MyArcType = Arc.ArcType.LowerLeft;
					}
					else if (rect.Vertices[0].X >= rect.Vertices[2].X & rect.Vertices[0].Y <= rect.Vertices[2].Y)
					{
						this.MyArcType = Arc.ArcType.LowerRight;
					}
					else if (rect.Vertices[0].X <= rect.Vertices[2].X & rect.Vertices[0].Y >= rect.Vertices[2].Y)
					{
						this.MyArcType = Arc.ArcType.UpperLeft;
					}
					else if (rect.Vertices[0].X >= rect.Vertices[2].X & rect.Vertices[0].Y >= rect.Vertices[2].Y)
					{
						this.MyArcType = Arc.ArcType.UpperRight;
					}
				}
				catch (Exception ex)
				{
					ComPetersError.DisplayError(ex);
				}
			}
		}

		// Token: 0x06000302 RID: 770 RVA: 0x000A34EC File Offset: 0x000A24EC
		private void SetAngles()
		{
			try
			{
				switch (this._MyArcType)
				{
				case Arc.ArcType.UpperRight:
					this._StartAngle = 4.71238898038469;
					this._EndAngle = 6.283185307179586;
					break;
				case Arc.ArcType.UpperLeft:
					this._StartAngle = 3.141592653589793;
					this._EndAngle = 4.71238898038469;
					break;
				case Arc.ArcType.LowerLeft:
					this._StartAngle = 1.5707963267948966;
					this._EndAngle = 3.141592653589793;
					break;
				case Arc.ArcType.LowerRight:
					this._StartAngle = 0.0;
					this._EndAngle = 1.5707963267948966;
					break;
				}
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x06000303 RID: 771 RVA: 0x000A35C0 File Offset: 0x000A25C0
		public void Draw()
		{
			try
			{
				GL.Color3(this._Colour);
				GL.LineWidth((float)this._Thickness);
				if (this._lineStyle == GlobalVariables.LineStyle.Dashed)
				{
					GL.Enable(EnableCap.LineStipple);
					GL.LineStipple(checked(1 + this._Thickness), 56173);
				}
				GL.Begin(BeginMode.LineStrip);
				if (!this.CreationIsCompleted)
				{
					double startAngle = this._StartAngle;
					double endAngle = this._EndAngle;
					for (double num = startAngle; num <= endAngle; num += 0.01)
					{
						GL.Vertex2((double)this._Width * Math.Cos(num) + (double)this._Center.X, (double)this._Height * Math.Sin(num) + (double)this._Center.Y);
					}
				}
				else
				{
					foreach (PointF pointF in this.Vertices)
					{
						GL.Vertex2(pointF.X, pointF.Y);
					}
				}
				GL.End();
				GL.Disable(EnableCap.LineStipple);
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x06000304 RID: 772 RVA: 0x000A36E8 File Offset: 0x000A26E8
		public bool isInSelection(PointF First, PointF Last)
		{
			return this._BoundingRectangle.isInSelection(First, Last);
		}

		// Token: 0x06000305 RID: 773 RVA: 0x000A3704 File Offset: 0x000A2704
		public void SelectThis()
		{
			try
			{
				this.Colour = Color.LightGreen;
				this._IsSelected = true;
				GlobalVariables.Canvas.AddShapeToSelection(this);
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x06000306 RID: 774 RVA: 0x000A3754 File Offset: 0x000A2754
		public void Unselect()
		{
			this.Colour = Color.Black;
			this._IsSelected = false;
		}

		// Token: 0x06000307 RID: 775 RVA: 0x000A3768 File Offset: 0x000A2768
		public void Move(int AddToX, int AddToY)
		{
			checked
			{
				try
				{
					this._BoundingRectangle.Move(AddToX, AddToY);
					int num = 0;
					int num2 = this.Vertices.Length - 1;
					for (int i = num; i <= num2; i++)
					{
						this.Vertices[i] = unchecked(new PointF(this.Vertices[i].X + (float)AddToX, this.Vertices[i].Y + (float)AddToY));
					}
				}
				catch (Exception ex)
				{
					ComPetersError.DisplayError(ex);
				}
			}
		}

		// Token: 0x06000308 RID: 776 RVA: 0x000A37F8 File Offset: 0x000A27F8
		public void Rotate(double radians, PointF Pivot)
		{
			checked
			{
				try
				{
					int num = 0;
					int num2 = this.Vertices.Length - 1;
					for (int i = num; i <= num2; i++)
					{
						this.Vertices[i] = this.RotatePoint(this.Vertices[i], Pivot, radians);
					}
					this._BoundingRectangle.Rotate(radians, Pivot);
				}
				catch (Exception ex)
				{
					ComPetersError.DisplayError(ex);
				}
			}
		}

		// Token: 0x06000309 RID: 777 RVA: 0x000A387C File Offset: 0x000A287C
		private PointF RotatePoint(PointF pPointf, PointF pOrigin, double Radians)
		{
			PointF result;
			try
			{
				result = new PointF
				{
					X = (float)((double)pOrigin.X + (Math.Cos(Radians) * (double)(pPointf.X - pOrigin.X) - Math.Sin(Radians) * (double)(pPointf.Y - pOrigin.Y))),
					Y = (float)((double)pOrigin.Y + (Math.Sin(Radians) * (double)(pPointf.X - pOrigin.X) + Math.Cos(Radians) * (double)(pPointf.Y - pOrigin.Y)))
				};
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
			return result;
		}

		// Token: 0x0600030A RID: 778 RVA: 0x000A393C File Offset: 0x000A293C
		public IShape Clone()
		{
			IShape result;
			try
			{
				Arc arc = new Arc();
				arc.Colour = this.Colour;
				arc.LineStyle = this.LineStyle;
				arc.MyArcType = this.MyArcType;
				arc.Thickness = this.Thickness;
				arc.Visible = this.Visible;
				arc.CreateArc(this._BoundingRectangle);
				result = arc;
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
				result = null;
			}
			return result;
		}

		// Token: 0x0600030B RID: 779 RVA: 0x000A39C4 File Offset: 0x000A29C4
		public void SaveToTemplate(SQLiteConnection database, SQLiteTransaction trans, long TemplateID, string FileName = "")
		{
			try
			{
				SQLiteCommand sqliteCommand = new SQLiteCommand();
				sqliteCommand.CommandText = "Insert into tbDrawing_TemplateShapes (ParentTemplate,Size,Colour,PenStyle,ShapeType) values (@ParentTemplate,@Size,@Colour,@PenStyle,@ShapeType)";
				sqliteCommand.Connection = database;
				sqliteCommand.Transaction = trans;
				sqliteCommand.Parameters.AddWithValue("@ParentTemplate", TemplateID);
				sqliteCommand.Parameters.AddWithValue("@Size", this._Thickness);
				sqliteCommand.Parameters.AddWithValue("@Colour", this._Colour.ToArgb());
				sqliteCommand.Parameters.AddWithValue("@PenStyle", this._lineStyle);
				sqliteCommand.Parameters.AddWithValue("@ShapeType", "arc");
				sqliteCommand.ExecuteNonQuery();
				SQLiteCommand sqliteCommand2 = new SQLiteCommand("Select last_insert_rowid() as rowid", database, trans);
				long num = Conversions.ToLong(sqliteCommand2.ExecuteScalar());
				foreach (PointF pointF in this.BoundingRectangle.Vertices)
				{
					SQLiteCommand sqliteCommand3 = new SQLiteCommand("Insert into tbDrawing_TemplateShapeCoords (ShapeIndex,XCoord,YCoord) values (@ShapeIndex,@XCoord,@YCoord)", database, trans);
					sqliteCommand3.Parameters.AddWithValue("@ShapeIndex", num);
					sqliteCommand3.Parameters.AddWithValue("@XCoord", pointF.X);
					sqliteCommand3.Parameters.AddWithValue("@YCoord", pointF.Y);
					sqliteCommand3.ExecuteNonQuery();
				}
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x0600030C RID: 780 RVA: 0x000A3B64 File Offset: 0x000A2B64
		public void Load(DataTable data, Undo undoObj, string FileName = "")
		{
			try
			{
				DataRow dataRow = data.Rows[0];
				DataRow dataRow2 = data.Rows[1];
				DataRow dataRow3 = data.Rows[2];
				DataRow dataRow4 = data.Rows[3];
				this._BoundingRectangle = new Rectangle();
				Rectangle boundingRectangle = this._BoundingRectangle;
				PointF vertex = new PointF(Conversions.ToSingle(dataRow["XCoord"]), Conversions.ToSingle(dataRow["YCoord"]));
				boundingRectangle.AddVertices(vertex);
				Rectangle boundingRectangle2 = this._BoundingRectangle;
				vertex = new PointF(Conversions.ToSingle(dataRow2["XCoord"]), Conversions.ToSingle(dataRow2["YCoord"]));
				boundingRectangle2.AddVertices(vertex);
				Rectangle boundingRectangle3 = this._BoundingRectangle;
				vertex = new PointF(Conversions.ToSingle(dataRow3["XCoord"]), Conversions.ToSingle(dataRow3["YCoord"]));
				boundingRectangle3.AddVertices(vertex);
				Rectangle boundingRectangle4 = this._BoundingRectangle;
				vertex = new PointF(Conversions.ToSingle(dataRow4["XCoord"]), Conversions.ToSingle(dataRow4["YCoord"]));
				boundingRectangle4.AddVertices(vertex);
				this._lineStyle = (GlobalVariables.LineStyle)Conversions.ToInteger(dataRow["PenStyle"]);
				this._Thickness = Conversions.ToInteger(dataRow["Size"]);
				this._Colour = Color.FromArgb(Conversions.ToInteger(dataRow["Colour"]));
				this.CreateArc(this._BoundingRectangle);
				this.FinishCreation();
				this.SelectThis();
				GlobalVariables.Canvas.Add(this);
				undoObj.AddShape(this);
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x0600030D RID: 781 RVA: 0x000A3D28 File Offset: 0x000A2D28
		public bool isInSelection(PointF Pixel)
		{
			bool result;
			try
			{
				foreach (PointF pointF in this.Vertices)
				{
					if (Math.Abs(pointF.X - Pixel.X) < 3f && Math.Abs(pointF.Y - Pixel.Y) < 3f)
					{
						result = true;
						break;
					}
				}
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
			return result;
		}

		// Token: 0x0600030E RID: 782 RVA: 0x000A3DBC File Offset: 0x000A2DBC
		public void Resize(double X, double Y)
		{
		}

		// Token: 0x0400016D RID: 365
		private long _ShapeID;

		// Token: 0x0400016E RID: 366
		private Color _Colour;

		// Token: 0x0400016F RID: 367
		private int _Thickness;

		// Token: 0x04000170 RID: 368
		private GlobalVariables.LineStyle _lineStyle;

		// Token: 0x04000171 RID: 369
		private bool _Visible;

		// Token: 0x04000172 RID: 370
		private bool _IsSelected;

		// Token: 0x04000173 RID: 371
		private int _Width;

		// Token: 0x04000174 RID: 372
		private int _Height;

		// Token: 0x04000175 RID: 373
		private PointF _Center;

		// Token: 0x04000176 RID: 374
		private double _StartAngle;

		// Token: 0x04000177 RID: 375
		private double _EndAngle;

		// Token: 0x04000178 RID: 376
		private Arc.ArcType _MyArcType;

		// Token: 0x04000179 RID: 377
		private Rectangle _BoundingRectangle;

		// Token: 0x0400017A RID: 378
		private bool CreationIsCompleted;

		// Token: 0x0400017B RID: 379
		public PointF[] Vertices;

		// Token: 0x0200001B RID: 27
		public enum ArcType
		{
			// Token: 0x0400017D RID: 381
			UpperRight,
			// Token: 0x0400017E RID: 382
			UpperLeft,
			// Token: 0x0400017F RID: 383
			LowerLeft,
			// Token: 0x04000180 RID: 384
			LowerRight
		}
	}
}
