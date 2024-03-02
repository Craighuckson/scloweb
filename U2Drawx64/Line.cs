using System;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using ComPeters;
using Microsoft.VisualBasic.CompilerServices;
using OpenTK.Graphics.OpenGL;

namespace U2Drawx64
{
	// Token: 0x0200001F RID: 31
	public class Line : IShape
	{
		// Token: 0x06000369 RID: 873 RVA: 0x000A4D44 File Offset: 0x000A3D44
		public Line()
		{
			this._Colour = Color.Black;
			this._Thickness = 1;
			this._visible = true;
			this._IsSelected = false;
			this._canSelect = true;
			this._Vertices = new PointF[0];
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x0600036A RID: 874 RVA: 0x000A4D80 File Offset: 0x000A3D80
		// (set) Token: 0x0600036B RID: 875 RVA: 0x000A4D94 File Offset: 0x000A3D94
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

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x0600036C RID: 876 RVA: 0x000A4DA0 File Offset: 0x000A3DA0
		// (set) Token: 0x0600036D RID: 877 RVA: 0x000A4DB4 File Offset: 0x000A3DB4
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

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x0600036E RID: 878 RVA: 0x000A4DC0 File Offset: 0x000A3DC0
		// (set) Token: 0x0600036F RID: 879 RVA: 0x000A4DD4 File Offset: 0x000A3DD4
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

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x06000370 RID: 880 RVA: 0x000A4DE0 File Offset: 0x000A3DE0
		// (set) Token: 0x06000371 RID: 881 RVA: 0x000A4DF4 File Offset: 0x000A3DF4
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

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x06000372 RID: 882 RVA: 0x000A4E00 File Offset: 0x000A3E00
		// (set) Token: 0x06000373 RID: 883 RVA: 0x000A4E14 File Offset: 0x000A3E14
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

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x06000374 RID: 884 RVA: 0x000A4E20 File Offset: 0x000A3E20
		public Rectangle BoundingRectangle
		{
			get
			{
				return this._BoundingRectangle;
			}
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x06000375 RID: 885 RVA: 0x000A4E34 File Offset: 0x000A3E34
		public PointF[] Vertices
		{
			get
			{
				this.CalculateBoundingRectangle();
				return this._Vertices;
			}
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x06000376 RID: 886 RVA: 0x000A4E50 File Offset: 0x000A3E50
		public GlobalVariables.ShapeType ShapeType
		{
			get
			{
				return GlobalVariables.ShapeType.Line;
			}
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x06000377 RID: 887 RVA: 0x000A4E60 File Offset: 0x000A3E60
		// (set) Token: 0x06000378 RID: 888 RVA: 0x000A4E74 File Offset: 0x000A3E74
		public bool canSelect
		{
			get
			{
				return this._canSelect;
			}
			set
			{
				this._canSelect = value;
			}
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x06000379 RID: 889 RVA: 0x000A4E80 File Offset: 0x000A3E80
		public bool isSelected
		{
			get
			{
				return this._IsSelected;
			}
		}

		// Token: 0x0600037A RID: 890 RVA: 0x000A4E94 File Offset: 0x000A3E94
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

		// Token: 0x0600037B RID: 891 RVA: 0x000A5048 File Offset: 0x000A4048
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

		// Token: 0x0600037C RID: 892 RVA: 0x000A50C4 File Offset: 0x000A40C4
		public void RemoveVertice(int VertexIndex)
		{
		}

		// Token: 0x0600037D RID: 893 RVA: 0x000A50C8 File Offset: 0x000A40C8
		public void Draw()
		{
			checked
			{
				try
				{
					GL.Color3(this._Colour);
					GL.LineWidth((float)this._Thickness);
					if (this._lineStyle == GlobalVariables.LineStyle.Dashed)
					{
						GL.Enable(EnableCap.LineStipple);
						GL.LineStipple(1 + this._Thickness, 56173);
					}
					if (this.Vertices.Length > 2)
					{
						GL.Begin(BeginMode.Lines);
						long num = 0L;
						long num2 = unchecked((long)(checked(this.Vertices.Length - 1)));
						for (long num3 = num; num3 <= num2; num3 += 1L)
						{
							GL.Vertex2(this.Vertices[(int)num3].X, this.Vertices[(int)num3].Y);
							if (num3 < unchecked((long)(checked(this.Vertices.Length - 2))))
							{
								GL.Vertex2(this.Vertices[(int)(num3 + 1L)].X, this.Vertices[(int)(num3 + 1L)].Y);
							}
						}
						GL.End();
					}
					else
					{
						GL.Begin(BeginMode.LineStrip);
						foreach (PointF pointF in this._Vertices)
						{
							GL.Vertex2(pointF.X, pointF.Y);
						}
						GL.End();
					}
					if (this._lineStyle == GlobalVariables.LineStyle.Dashed)
					{
						GL.Disable(EnableCap.LineStipple);
					}
				}
				catch (Exception ex)
				{
					ComPetersError.DisplayError(ex);
				}
			}
		}

		// Token: 0x0600037E RID: 894 RVA: 0x000A523C File Offset: 0x000A423C
		public bool isInSelection(PointF First, PointF Last)
		{
			bool result;
			try
			{
				foreach (PointF pointF in this.Vertices)
				{
					if (pointF.X >= First.X & pointF.Y >= First.Y)
					{
						if (!(pointF.X <= Last.X & pointF.Y <= Last.Y))
						{
							return false;
						}
					}
					else if (pointF.X <= First.X & pointF.Y <= First.Y)
					{
						if (!(pointF.X >= Last.X & pointF.Y >= Last.Y))
						{
							return false;
						}
					}
					else if (pointF.X <= First.X & pointF.Y >= First.Y)
					{
						if (!(pointF.X >= Last.X & pointF.Y <= Last.Y))
						{
							return false;
						}
					}
					else
					{
						if (!(pointF.X >= First.X & pointF.Y <= First.Y))
						{
							return false;
						}
						if (!(pointF.X <= Last.X & pointF.Y >= Last.Y))
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

		// Token: 0x0600037F RID: 895 RVA: 0x000A5420 File Offset: 0x000A4420
		public void SelectThis()
		{
			this.Colour = Color.LightGreen;
			this._IsSelected = true;
			GlobalVariables.Canvas.AddShapeToSelection(this);
		}

		// Token: 0x06000380 RID: 896 RVA: 0x000A5440 File Offset: 0x000A4440
		public void Unselect()
		{
			this.Colour = Color.Black;
			this._IsSelected = false;
		}

		// Token: 0x06000381 RID: 897 RVA: 0x000A5454 File Offset: 0x000A4454
		public void Move(int AddToX, int AddToY)
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

		// Token: 0x06000382 RID: 898 RVA: 0x000A54F4 File Offset: 0x000A44F4
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

		// Token: 0x06000383 RID: 899 RVA: 0x000A5578 File Offset: 0x000A4578
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

		// Token: 0x06000384 RID: 900 RVA: 0x000A5638 File Offset: 0x000A4638
		public IShape Clone()
		{
			IShape result;
			try
			{
				Line line = new Line();
				line.Colour = this.Colour;
				line.LineStyle = this.LineStyle;
				line.Thickness = this.Thickness;
				line.Visible = this.Visible;
				foreach (PointF pointF in this._Vertices)
				{
					Line line2 = line;
					PointF vertex = new PointF(pointF.X, pointF.Y);
					line2.AddVertices(vertex);
				}
				result = line;
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
				result = null;
			}
			return result;
		}

		// Token: 0x06000385 RID: 901 RVA: 0x000A56F0 File Offset: 0x000A46F0
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
				sqliteCommand.Parameters.AddWithValue("@ShapeType", "line");
				sqliteCommand.ExecuteNonQuery();
				SQLiteCommand sqliteCommand2 = new SQLiteCommand("Select last_insert_rowid() as rowid", database, trans);
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

		// Token: 0x06000386 RID: 902 RVA: 0x000A588C File Offset: 0x000A488C
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

		// Token: 0x06000387 RID: 903 RVA: 0x000A5984 File Offset: 0x000A4984
		public bool isInSelection(PointF Pixel)
		{
			bool result;
			try
			{
				long num = 0L;
				long num2 = (long)(checked(this.Vertices.Length - 2));
				for (long num3 = num; num3 <= num2; num3 = checked(num3 + 1L))
				{
					double num4 = Math.Sqrt(Math.Pow((double)(this.Vertices[checked((int)(num3 + 1L))].X - this.Vertices[checked((int)num3)].X), 2.0) + Math.Pow((double)(this.Vertices[checked((int)(num3 + 1L))].Y - this.Vertices[checked((int)num3)].Y), 2.0));
					double num5 = Math.Sqrt(Math.Pow((double)(Pixel.X - this.Vertices[checked((int)(num3 + 1L))].X), 2.0) + Math.Pow((double)(Pixel.Y - this.Vertices[checked((int)(num3 + 1L))].Y), 2.0));
					double num6 = Math.Sqrt(Math.Pow((double)(Pixel.X - this.Vertices[checked((int)num3)].X), 2.0) + Math.Pow((double)(Pixel.Y - this.Vertices[checked((int)num3)].Y), 2.0));
					if (Math.Abs(num5 + num6 - num4) < 0.2)
					{
						return true;
					}
				}
				result = false;
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
				result = false;
			}
			return result;
		}

		// Token: 0x06000388 RID: 904 RVA: 0x000A5B34 File Offset: 0x000A4B34
		public void Resize(double X, double Y)
		{
		}

		// Token: 0x04000193 RID: 403
		private long _ShapeID;

		// Token: 0x04000194 RID: 404
		private Color _Colour;

		// Token: 0x04000195 RID: 405
		private int _Thickness;

		// Token: 0x04000196 RID: 406
		private GlobalVariables.LineStyle _lineStyle;

		// Token: 0x04000197 RID: 407
		private bool _visible;

		// Token: 0x04000198 RID: 408
		private bool _IsSelected;

		// Token: 0x04000199 RID: 409
		private Rectangle _BoundingRectangle;

		// Token: 0x0400019A RID: 410
		private bool _canSelect;

		// Token: 0x0400019B RID: 411
		public PointF[] _Vertices;
	}
}
