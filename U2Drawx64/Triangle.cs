using System;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using ComPeters;
using Microsoft.VisualBasic.CompilerServices;
using OpenTK.Graphics.OpenGL;

namespace U2Drawx64
{
	// Token: 0x02000024 RID: 36
	public class Triangle : IShape
	{
		// Token: 0x06000418 RID: 1048 RVA: 0x000AA6A0 File Offset: 0x000A96A0
		public Triangle()
		{
			this._Colour = Color.Black;
			this._Thickness = 1;
			this._Visible = true;
			this._IsSelected = false;
			this.TriangleSize = 10;
			this._Vertices = new PointF[0];
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x06000419 RID: 1049 RVA: 0x000AA6EC File Offset: 0x000A96EC
		// (set) Token: 0x0600041A RID: 1050 RVA: 0x000AA700 File Offset: 0x000A9700
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

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x0600041B RID: 1051 RVA: 0x000AA70C File Offset: 0x000A970C
		// (set) Token: 0x0600041C RID: 1052 RVA: 0x000AA720 File Offset: 0x000A9720
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

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x0600041D RID: 1053 RVA: 0x000AA72C File Offset: 0x000A972C
		// (set) Token: 0x0600041E RID: 1054 RVA: 0x000AA740 File Offset: 0x000A9740
		public int Thickness
		{
			get
			{
				return this._Thickness;
			}
			set
			{
				this._Thickness = value;
				this.TriangleSize = checked(10 + 2 * this._Thickness);
			}
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x0600041F RID: 1055 RVA: 0x000AA760 File Offset: 0x000A9760
		// (set) Token: 0x06000420 RID: 1056 RVA: 0x000AA774 File Offset: 0x000A9774
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

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x06000421 RID: 1057 RVA: 0x000AA780 File Offset: 0x000A9780
		// (set) Token: 0x06000422 RID: 1058 RVA: 0x000AA794 File Offset: 0x000A9794
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

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x06000423 RID: 1059 RVA: 0x000AA7A0 File Offset: 0x000A97A0
		public Rectangle BoundingRectangle
		{
			get
			{
				return this._BoundingRectangle;
			}
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x06000424 RID: 1060 RVA: 0x000AA7B4 File Offset: 0x000A97B4
		public PointF[] Vertices
		{
			get
			{
				this.CalculateBoundingRectangle();
				return this._Vertices;
			}
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x06000425 RID: 1061 RVA: 0x000AA7D0 File Offset: 0x000A97D0
		public GlobalVariables.ShapeType ShapeType
		{
			get
			{
				return GlobalVariables.ShapeType.Triangle;
			}
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x06000426 RID: 1062 RVA: 0x000AA7E0 File Offset: 0x000A97E0
		// (set) Token: 0x06000427 RID: 1063 RVA: 0x000AA7F0 File Offset: 0x000A97F0
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

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x06000428 RID: 1064 RVA: 0x000AA7F4 File Offset: 0x000A97F4
		public bool isSelected
		{
			get
			{
				return this._IsSelected;
			}
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x000AA808 File Offset: 0x000A9808
		private void CalculateBoundingRectangle()
		{
			checked
			{
				try
				{
					Point p = new Point(GlobalVariables.Canvas.Width, GlobalVariables.Canvas.Width);
					Point p2 = new Point(0, 0);
					foreach (PointF pointF in this._Vertices)
					{
						p.X = (int)Math.Round((double)Math.Min(pointF.X, (float)p.X));
						p.Y = (int)Math.Round((double)Math.Min(pointF.Y, (float)p.Y));
						p2.X = (int)Math.Round((double)Math.Max(pointF.X, (float)p2.X));
						p2.Y = (int)Math.Round((double)Math.Max(pointF.Y, (float)p2.Y));
					}
					this._BoundingRectangle = new Rectangle();
					Rectangle boundingRectangle = this._BoundingRectangle;
					Point p3 = new Point((Size)p);
					boundingRectangle.AddVertices(p3);
					Rectangle boundingRectangle2 = this._BoundingRectangle;
					p3 = new Point(p2.X, p.Y);
					boundingRectangle2.AddVertices(p3);
					Rectangle boundingRectangle3 = this._BoundingRectangle;
					p3 = new Point((Size)p2);
					boundingRectangle3.AddVertices(p3);
					Rectangle boundingRectangle4 = this._BoundingRectangle;
					p3 = new Point(p.X, p2.Y);
					boundingRectangle4.AddVertices(p3);
				}
				catch (Exception ex)
				{
					ComPetersError.DisplayError(ex);
				}
			}
		}

		// Token: 0x0600042A RID: 1066 RVA: 0x000AA9BC File Offset: 0x000A99BC
		public void AddVertices(PointF Vertex)
		{
			try
			{
				long num = (long)this._Vertices.Length;
				checked
				{
					this._Vertices = (PointF[])Utils.CopyArray((Array)this._Vertices, new PointF[(int)num + 1]);
					this._Vertices[(int)num] = Vertex;
					this.CalculateBoundingRectangle();
				}
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x000AAA38 File Offset: 0x000A9A38
		public void Draw()
		{
			try
			{
				GL.Color3(this._Colour);
				GL.LineWidth((float)this._Thickness);
				GL.Begin(BeginMode.Triangles);
				foreach (PointF pointF in this._Vertices)
				{
					GL.Vertex2(pointF.X, pointF.Y);
				}
				GL.End();
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x0600042C RID: 1068 RVA: 0x000AAAC4 File Offset: 0x000A9AC4
		public void Move(PointF NewTip)
		{
			checked
			{
				try
				{
					this._Vertices[1] = NewTip;
					PointF[] vertices = this._Vertices;
					int num = 0;
					Point p = new Point(Conversions.ToInteger(Operators.SubtractObject(NewTip.X, Operators.DivideObject(this.TriangleSize, 2))), (int)Math.Round(unchecked((double)NewTip.Y - Math.Sqrt(Conversions.ToDouble(Operators.SubtractObject(Operators.MultiplyObject(this.TriangleSize, this.TriangleSize), Operators.DivideObject(Operators.MultiplyObject(Operators.DivideObject(this.TriangleSize, 2), this.TriangleSize), 2)))))));
					vertices[num] = p;
					PointF[] vertices2 = this._Vertices;
					int num2 = 2;
					p = new Point(Conversions.ToInteger(Operators.AddObject(NewTip.X, Operators.DivideObject(this.TriangleSize, 2))), (int)Math.Round(unchecked((double)NewTip.Y - Math.Sqrt(Conversions.ToDouble(Operators.SubtractObject(Operators.MultiplyObject(this.TriangleSize, this.TriangleSize), Operators.DivideObject(Operators.MultiplyObject(Operators.DivideObject(this.TriangleSize, 2), this.TriangleSize), 2)))))));
					vertices2[num2] = p;
					this.CalculateBoundingRectangle();
				}
				catch (Exception ex)
				{
					ComPetersError.DisplayError(ex);
				}
			}
		}

		// Token: 0x0600042D RID: 1069 RVA: 0x000AAC54 File Offset: 0x000A9C54
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

		// Token: 0x0600042E RID: 1070 RVA: 0x000AAD14 File Offset: 0x000A9D14
		public void Rotate(double radians)
		{
			this.Rotate(radians, this._Vertices[1]);
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x000AAD30 File Offset: 0x000A9D30
		public void Rotate(double radians, PointF Pivot)
		{
			checked
			{
				try
				{
					int num = 0;
					int num2 = this._Vertices.Length - 1;
					for (int i = num; i <= num2; i++)
					{
						this._Vertices[i] = this.RotatePoint(this._Vertices[i], Pivot, radians);
					}
					this._BoundingRectangle.Rotate(radians, Pivot);
				}
				catch (Exception ex)
				{
					ComPetersError.DisplayError(ex);
				}
			}
		}

		// Token: 0x06000430 RID: 1072 RVA: 0x000AADB4 File Offset: 0x000A9DB4
		public bool isInSelection(PointF first, PointF last)
		{
			bool result;
			try
			{
				foreach (PointF pointF in this._Vertices)
				{
					if (pointF.X >= first.X & pointF.Y >= first.Y)
					{
						if (!(pointF.X <= last.X & pointF.Y <= last.Y))
						{
							return false;
						}
					}
					else if (pointF.X <= first.X & pointF.Y <= first.Y)
					{
						if (!(pointF.X >= last.X & pointF.Y >= last.Y))
						{
							return false;
						}
					}
					else if (pointF.X <= first.X & pointF.Y >= first.Y)
					{
						if (!(pointF.X >= last.X & pointF.Y <= last.Y))
						{
							return false;
						}
					}
					else
					{
						if (!(pointF.X >= first.X & pointF.Y <= first.Y))
						{
							return false;
						}
						if (!(pointF.X <= last.X & pointF.Y >= last.Y))
						{
							return false;
						}
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

		// Token: 0x06000431 RID: 1073 RVA: 0x000AAF98 File Offset: 0x000A9F98
		public void SelectThis()
		{
			this.Colour = Color.LightGreen;
			this._IsSelected = true;
			GlobalVariables.Canvas.AddShapeToSelection(this);
		}

		// Token: 0x06000432 RID: 1074 RVA: 0x000AAFB8 File Offset: 0x000A9FB8
		public void Unselect()
		{
			this.Colour = Color.Black;
			this._IsSelected = false;
		}

		// Token: 0x06000433 RID: 1075 RVA: 0x000AAFCC File Offset: 0x000A9FCC
		public void Move1(int AddToX, int AddToY)
		{
			checked
			{
				try
				{
					int num = 0;
					int num2 = this._Vertices.Length - 1;
					for (int i = num; i <= num2; i++)
					{
						PointF[] vertices = this._Vertices;
						int num3 = i;
						Point p = new Point((int)Math.Round((double)(unchecked(this._Vertices[i].X + (float)AddToX))), (int)Math.Round((double)(unchecked(this._Vertices[i].Y + (float)AddToY))));
						vertices[num3] = p;
					}
				}
				catch (Exception ex)
				{
					ComPetersError.DisplayError(ex);
				}
			}
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x000AB06C File Offset: 0x000AA06C
		public IShape Clone()
		{
			IShape result;
			try
			{
				Triangle triangle = new Triangle();
				triangle.Colour = this.Colour;
				triangle.LineStyle = this.LineStyle;
				triangle.Thickness = this.Thickness;
				triangle.Visible = this.Visible;
				foreach (PointF pointF in this._Vertices)
				{
					Triangle triangle2 = triangle;
					PointF vertex = new PointF(pointF.X, pointF.Y);
					triangle2.AddVertices(vertex);
				}
				result = triangle;
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
				result = null;
			}
			return result;
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x000AB124 File Offset: 0x000AA124
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
				sqliteCommand.Parameters.AddWithValue("@ShapeType", "triangle");
				sqliteCommand.ExecuteNonQuery();
				SQLiteCommand sqliteCommand2 = new SQLiteCommand("Select last_insert_rowid() as rowid", database);
				long num = Conversions.ToLong(sqliteCommand2.ExecuteScalar());
				foreach (PointF pointF in this._Vertices)
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

		// Token: 0x06000436 RID: 1078 RVA: 0x000AB2BC File Offset: 0x000AA2BC
		public void Load(DataTable data, Undo undoObj, string FileName = "")
		{
			checked
			{
				try
				{
					DataRow dataRow = data.Rows[0];
					this._lineStyle = (GlobalVariables.LineStyle)Conversions.ToInteger(dataRow["PenStyle"]);
					this._Thickness = Conversions.ToInteger(dataRow["Size"]);
					this._Colour = Color.FromArgb(Conversions.ToInteger(dataRow["Colour"]));
					int num = 0;
					int num2 = data.Rows.Count - 1;
					for (int i = num; i <= num2; i++)
					{
						DataRow dataRow2 = data.Rows[i];
						PointF vertex = new PointF(Conversions.ToSingle(dataRow2["XCoord"]), Conversions.ToSingle(dataRow2["YCoord"]));
						this.AddVertices(vertex);
					}
					this.SelectThis();
					GlobalVariables.Canvas.Add(this);
					undoObj.AddShape(this);
				}
				catch (Exception ex)
				{
					ComPetersError.DisplayError(ex);
				}
			}
		}

		// Token: 0x06000437 RID: 1079 RVA: 0x000AB3B4 File Offset: 0x000AA3B4
		public bool isInSelection(PointF Pixel)
		{
			bool result;
			try
			{
				PointF pointF = new PointF(this._Vertices[2].X - this._Vertices[0].X, this._Vertices[2].Y - this._Vertices[0].Y);
				PointF pointF2 = new PointF(this._Vertices[1].X - this._Vertices[0].X, this._Vertices[1].Y - this._Vertices[0].Y);
				PointF vector = new PointF(Pixel.X - this._Vertices[0].X, Pixel.Y - this._Vertices[0].Y);
				double num = GlobalVariables.Dot(pointF, pointF);
				double num2 = GlobalVariables.Dot(pointF, pointF2);
				double num3 = GlobalVariables.Dot(pointF, vector);
				double num4 = GlobalVariables.Dot(pointF2, pointF2);
				double num5 = GlobalVariables.Dot(pointF2, vector);
				double num6 = 1.0 / (num * num4 - num2 * num2);
				double num7 = (num4 * num3 - num2 * num5) * num6;
				double num8 = (num * num5 - num2 * num3) * num6;
				if (num7 >= 0.0 & num8 >= 0.0 & num7 + num8 < 1.0)
				{
					result = true;
				}
				else
				{
					result = false;
				}
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
				result = false;
			}
			return result;
		}

		// Token: 0x06000438 RID: 1080 RVA: 0x000AB568 File Offset: 0x000AA568
		public bool isInBounds(PointF Pixel)
		{
			bool result;
			try
			{
				PointF pointF = this._BoundingRectangle.Vertices[0];
				PointF pointF2 = this._BoundingRectangle.Vertices[2];
				if (Pixel.X >= pointF.X & Pixel.Y >= pointF.Y)
				{
					if (!(Pixel.X <= pointF2.X & Pixel.Y <= pointF2.Y))
					{
						return false;
					}
				}
				else if (Pixel.X <= pointF.X & Pixel.Y <= pointF.Y)
				{
					if (!(Pixel.X >= pointF2.X & Pixel.Y >= pointF2.Y))
					{
						return false;
					}
				}
				else if (Pixel.X <= pointF.X & Pixel.Y >= pointF.Y)
				{
					if (!(Pixel.X >= pointF2.X & Pixel.Y <= pointF2.Y))
					{
						return false;
					}
				}
				else
				{
					if (!(Pixel.X >= pointF.X & Pixel.Y <= pointF.Y))
					{
						return false;
					}
					if (!(Pixel.X <= pointF2.X & Pixel.Y >= pointF2.Y))
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

		// Token: 0x06000439 RID: 1081 RVA: 0x000AB74C File Offset: 0x000AA74C
		public void Resize(double X, double Y)
		{
		}

		// Token: 0x040001CB RID: 459
		private long _ShapeID;

		// Token: 0x040001CC RID: 460
		private Color _Colour;

		// Token: 0x040001CD RID: 461
		private int _Thickness;

		// Token: 0x040001CE RID: 462
		private GlobalVariables.LineStyle _lineStyle;

		// Token: 0x040001CF RID: 463
		private bool _Visible;

		// Token: 0x040001D0 RID: 464
		private bool _IsSelected;

		// Token: 0x040001D1 RID: 465
		private object TriangleSize;

		// Token: 0x040001D2 RID: 466
		public PointF[] _Vertices;

		// Token: 0x040001D3 RID: 467
		private double Angle;

		// Token: 0x040001D4 RID: 468
		private double RotateX;

		// Token: 0x040001D5 RID: 469
		private double RotateY;

		// Token: 0x040001D6 RID: 470
		private Rectangle _BoundingRectangle;
	}
}
