using System;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using ComPeters;
using Microsoft.VisualBasic.CompilerServices;
using OpenTK.Graphics.OpenGL;

namespace U2Drawx64
{
	// Token: 0x02000020 RID: 32
	public class Rectangle : IShape
	{
		// Token: 0x06000389 RID: 905 RVA: 0x000A5B38 File Offset: 0x000A4B38
		public Rectangle()
		{
			this._Colour = Color.Black;
			this._Thickness = 1;
			this._Visible = true;
			this._canSelect = true;
			this._IsSelected = false;
			this.Vertices = new PointF[0];
			this.SubVertices = new PointF[0];
			this.CreationIsCompleted = false;
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x0600038A RID: 906 RVA: 0x000A5B94 File Offset: 0x000A4B94
		// (set) Token: 0x0600038B RID: 907 RVA: 0x000A5BA8 File Offset: 0x000A4BA8
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

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x0600038C RID: 908 RVA: 0x000A5BB4 File Offset: 0x000A4BB4
		// (set) Token: 0x0600038D RID: 909 RVA: 0x000A5BC8 File Offset: 0x000A4BC8
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

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x0600038E RID: 910 RVA: 0x000A5BD4 File Offset: 0x000A4BD4
		// (set) Token: 0x0600038F RID: 911 RVA: 0x000A5BE8 File Offset: 0x000A4BE8
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

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x06000390 RID: 912 RVA: 0x000A5BF4 File Offset: 0x000A4BF4
		// (set) Token: 0x06000391 RID: 913 RVA: 0x000A5C08 File Offset: 0x000A4C08
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

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x06000392 RID: 914 RVA: 0x000A5C14 File Offset: 0x000A4C14
		public double width
		{
			get
			{
				double num = Math.Pow((double)(this.Vertices[2].X - this.Vertices[3].X), 2.0);
				double num2 = Math.Pow((double)(this.Vertices[2].Y - this.Vertices[3].Y), 2.0);
				return Math.Sqrt(num + num2);
			}
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x06000393 RID: 915 RVA: 0x000A5C90 File Offset: 0x000A4C90
		public double height
		{
			get
			{
				double num = Math.Pow((double)(this.Vertices[3].X - this.Vertices[0].X), 2.0);
				double num2 = Math.Pow((double)(this.Vertices[3].Y - this.Vertices[0].Y), 2.0);
				return Math.Sqrt(num + num2);
			}
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x06000394 RID: 916 RVA: 0x000A5D0C File Offset: 0x000A4D0C
		// (set) Token: 0x06000395 RID: 917 RVA: 0x000A5D20 File Offset: 0x000A4D20
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

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x06000396 RID: 918 RVA: 0x000A5D2C File Offset: 0x000A4D2C
		public Rectangle BoundingRectangle
		{
			get
			{
				return this;
			}
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x06000397 RID: 919 RVA: 0x000A5D3C File Offset: 0x000A4D3C
		public GlobalVariables.ShapeType ShapeType
		{
			get
			{
				return GlobalVariables.ShapeType.Rectangle;
			}
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x06000398 RID: 920 RVA: 0x000A5D4C File Offset: 0x000A4D4C
		// (set) Token: 0x06000399 RID: 921 RVA: 0x000A5D60 File Offset: 0x000A4D60
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

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x0600039A RID: 922 RVA: 0x000A5D6C File Offset: 0x000A4D6C
		public bool isSelected
		{
			get
			{
				return this._IsSelected;
			}
		}

		// Token: 0x0600039B RID: 923 RVA: 0x000A5D80 File Offset: 0x000A4D80
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

		// Token: 0x0600039C RID: 924 RVA: 0x000A5DF4 File Offset: 0x000A4DF4
		public void AddSubVertices(PointF Vertex)
		{
			try
			{
				long num = (long)this.SubVertices.Length;
				checked
				{
					this.SubVertices = (PointF[])Utils.CopyArray((Array)this.SubVertices, new PointF[(int)num + 1]);
					this.SubVertices[(int)num] = Vertex;
				}
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x0600039D RID: 925 RVA: 0x000A5E68 File Offset: 0x000A4E68
		private void CalculateSubVertices()
		{
			try
			{
				int num = 0;
				PointF pointF;
				PointF pointF2;
				PointF pointF3;
				PointF pointF4;
				checked
				{
					double num2;
					double num3;
					do
					{
						num2 = Math.Max((double)this.Vertices[num].X, num2);
						num3 = Math.Max((double)this.Vertices[num].Y, num3);
						num++;
					}
					while (num <= 3);
					pointF = this.Vertices[0];
					pointF2 = this.Vertices[0];
					pointF3 = this.Vertices[0];
					pointF4 = this.Vertices[0];
					int num4 = 0;
					do
					{
						if ((double)this.Vertices[num4].X == num2 & (double)this.Vertices[num4].Y == num3)
						{
							pointF3 = this.Vertices[num4];
						}
						else if ((double)this.Vertices[num4].X == num2 & (double)this.Vertices[num4].Y != num3)
						{
							pointF2 = this.Vertices[num4];
						}
						else if ((double)this.Vertices[num4].X != num2 & (double)this.Vertices[num4].Y == num3)
						{
							pointF4 = this.Vertices[num4];
						}
						else
						{
							pointF = this.Vertices[num4];
						}
						num4++;
					}
					while (num4 <= 3);
					this.SubVertices = new PointF[0];
				}
				double num5 = 0.5 * (double)this._Thickness;
				PointF vertex = new PointF((float)((double)pointF.X - num5), (float)((double)pointF.Y - num5));
				this.AddSubVertices(vertex);
				vertex = new PointF((float)((double)pointF2.X + num5), (float)((double)pointF2.Y - num5));
				this.AddSubVertices(vertex);
				vertex = new PointF((float)((double)pointF2.X + num5), (float)((double)pointF2.Y + num5));
				this.AddSubVertices(vertex);
				vertex = new PointF((float)((double)pointF.X - num5), (float)((double)pointF.Y + num5));
				this.AddSubVertices(vertex);
				vertex = new PointF((float)((double)pointF2.X - num5), (float)((double)pointF2.Y - num5));
				this.AddSubVertices(vertex);
				vertex = new PointF((float)((double)pointF2.X + num5), (float)((double)pointF2.Y - num5));
				this.AddSubVertices(vertex);
				vertex = new PointF((float)((double)pointF3.X + num5), (float)((double)pointF3.Y + num5));
				this.AddSubVertices(vertex);
				vertex = new PointF((float)((double)pointF3.X - num5), (float)((double)pointF3.Y + num5));
				this.AddSubVertices(vertex);
				vertex = new PointF((float)((double)pointF3.X + num5), (float)((double)pointF3.Y + num5));
				this.AddSubVertices(vertex);
				vertex = new PointF((float)((double)pointF3.X + num5), (float)((double)pointF3.Y - num5));
				this.AddSubVertices(vertex);
				vertex = new PointF((float)((double)pointF4.X - num5), (float)((double)pointF4.Y - num5));
				this.AddSubVertices(vertex);
				vertex = new PointF((float)((double)pointF4.X - num5), (float)((double)pointF4.Y + num5));
				this.AddSubVertices(vertex);
				vertex = new PointF((float)((double)pointF4.X - num5), (float)((double)pointF4.Y + num5));
				this.AddSubVertices(vertex);
				vertex = new PointF((float)((double)pointF4.X + num5), (float)((double)pointF4.Y + num5));
				this.AddSubVertices(vertex);
				vertex = new PointF((float)((double)pointF.X + num5), (float)((double)pointF.Y - num5));
				this.AddSubVertices(vertex);
				vertex = new PointF((float)((double)pointF.X - num5), (float)((double)pointF.Y - num5));
				this.AddSubVertices(vertex);
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x0600039E RID: 926 RVA: 0x000A62A0 File Offset: 0x000A52A0
		public void FinishCreation()
		{
			this.CreationIsCompleted = true;
			this.CalculateSubVertices();
		}

		// Token: 0x0600039F RID: 927 RVA: 0x000A62B0 File Offset: 0x000A52B0
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
					GL.Begin(BeginMode.LineLoop);
					foreach (PointF pointF in this.Vertices)
					{
						GL.Vertex2(pointF.X, pointF.Y);
					}
					GL.End();
					GL.Disable(EnableCap.LineStipple);
				}
				else
				{
					if (!this.CreationIsCompleted)
					{
						this.CalculateSubVertices();
					}
					GL.Begin(BeginMode.Quads);
					foreach (PointF pointF2 in this.SubVertices)
					{
						GL.Vertex2(pointF2.X, pointF2.Y);
					}
					GL.End();
				}
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x000A63C4 File Offset: 0x000A53C4
		public bool isInSelection(PointF first, PointF last)
		{
			bool result;
			try
			{
				PointF pointF = this.Vertices[0];
				PointF pointF2 = this.Vertices[2];
				if (pointF.X >= first.X & pointF.Y >= first.Y)
				{
					if (!(pointF.X <= last.X & pointF.Y <= last.Y))
					{
						return false;
					}
					if (!(pointF2.X >= first.X & pointF2.Y >= first.Y))
					{
						return false;
					}
					if (!(pointF2.X <= last.X & pointF2.Y <= last.Y))
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
					if (!(pointF2.X <= first.X & pointF2.Y <= first.Y))
					{
						return false;
					}
					if (!(pointF2.X >= last.X & pointF2.Y >= last.Y))
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
					if (!(pointF2.X <= first.X & pointF2.Y >= first.Y))
					{
						return false;
					}
					if (!(pointF2.X >= last.X & pointF2.Y <= last.Y))
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
					if (!(pointF.X >= first.X & pointF2.Y <= first.Y))
					{
						return false;
					}
					if (!(pointF.X <= last.X & pointF.Y >= last.Y))
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

		// Token: 0x060003A1 RID: 929 RVA: 0x000A6728 File Offset: 0x000A5728
		public void SelectThis()
		{
			this.Colour = Color.LightGreen;
			this._IsSelected = true;
			GlobalVariables.Canvas.AddShapeToSelection(this);
		}

		// Token: 0x060003A2 RID: 930 RVA: 0x000A6748 File Offset: 0x000A5748
		public void Unselect()
		{
			this.Colour = Color.Black;
			this._IsSelected = false;
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x000A675C File Offset: 0x000A575C
		public void Move(int AddToX, int AddToY)
		{
			checked
			{
				try
				{
					int num = 0;
					int num2 = this.Vertices.Length - 1;
					for (int i = num; i <= num2; i++)
					{
						PointF[] vertices = this.Vertices;
						int num3 = i;
						Point p = new Point((int)Math.Round((double)(unchecked(this.Vertices[i].X + (float)AddToX))), (int)Math.Round((double)(unchecked(this.Vertices[i].Y + (float)AddToY))));
						vertices[num3] = p;
					}
					int num4 = 0;
					int num5 = this.SubVertices.Length - 1;
					for (int j = num4; j <= num5; j++)
					{
						PointF[] subVertices = this.SubVertices;
						int num6 = j;
						Point p = new Point((int)Math.Round((double)(unchecked(this.SubVertices[j].X + (float)AddToX))), (int)Math.Round((double)(unchecked(this.SubVertices[j].Y + (float)AddToY))));
						subVertices[num6] = p;
					}
				}
				catch (Exception ex)
				{
					ComPetersError.DisplayError(ex);
				}
			}
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x000A6870 File Offset: 0x000A5870
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
					int num3 = 0;
					int num4 = this.SubVertices.Length - 1;
					for (int j = num3; j <= num4; j++)
					{
						this.SubVertices[j] = this.RotatePoint(this.SubVertices[j], Pivot, radians);
					}
				}
				catch (Exception ex)
				{
					ComPetersError.DisplayError(ex);
				}
			}
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x000A6928 File Offset: 0x000A5928
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

		// Token: 0x060003A6 RID: 934 RVA: 0x000A69E8 File Offset: 0x000A59E8
		public IShape Clone()
		{
			IShape result;
			try
			{
				Rectangle rectangle = new Rectangle();
				rectangle.Colour = this.Colour;
				rectangle.LineStyle = this.LineStyle;
				rectangle.Thickness = this.Thickness;
				rectangle.Visible = this.Visible;
				foreach (PointF pointF in this.Vertices)
				{
					Rectangle rectangle2 = rectangle;
					PointF vertex = new PointF(pointF.X, pointF.Y);
					rectangle2.AddVertices(vertex);
				}
				foreach (PointF pointF2 in this.SubVertices)
				{
					Rectangle rectangle3 = rectangle;
					PointF vertex = new PointF(pointF2.X, pointF2.Y);
					rectangle3.AddSubVertices(vertex);
				}
				result = rectangle;
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
				result = null;
			}
			return result;
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x000A6AE8 File Offset: 0x000A5AE8
		public override string ToString()
		{
			string result;
			try
			{
				string text = string.Empty;
				foreach (PointF pointF in this.Vertices)
				{
					text = pointF.ToString() + text;
				}
				result = text;
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
				result = string.Empty;
			}
			return result;
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x000A6B68 File Offset: 0x000A5B68
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
				sqliteCommand.Parameters.AddWithValue("@ShapeType", "rectangle");
				sqliteCommand.ExecuteNonQuery();
				SQLiteCommand sqliteCommand2 = new SQLiteCommand("Select last_insert_rowid() as rowid", database, trans);
				long num = Conversions.ToLong(sqliteCommand2.ExecuteScalar());
				foreach (PointF pointF in this.Vertices)
				{
					SQLiteCommand sqliteCommand3 = new SQLiteCommand("Insert into tbDrawing_TemplateShapeCoords (ShapeIndex,XCoord,YCoord) values (@ShapeIndex,@XCoord,@YCoord)", database, trans);
					sqliteCommand3.Parameters.AddWithValue("@ShapeIndex", num);
					sqliteCommand3.Parameters.AddWithValue("@XCoord", pointF.X);
					sqliteCommand3.Parameters.AddWithValue("@YCoord", pointF.Y);
					sqliteCommand3.ExecuteNonQuery();
				}
				foreach (PointF pointF2 in this.SubVertices)
				{
					SQLiteCommand sqliteCommand4 = new SQLiteCommand("Insert into tbDrawing_TemplateShapeCoords (ShapeIndex,XCoord,YCoord) values (@ShapeIndex,@XCoord,@YCoord)", database, trans);
					sqliteCommand4.Parameters.AddWithValue("@ShapeIndex", num);
					sqliteCommand4.Parameters.AddWithValue("@XCoord", pointF2.X);
					sqliteCommand4.Parameters.AddWithValue("@YCoord", pointF2.Y);
					sqliteCommand4.ExecuteNonQuery();
				}
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x000A6D9C File Offset: 0x000A5D9C
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
					this.Vertices = new PointF[0];
					int num = 0;
					do
					{
						DataRow dataRow2 = data.Rows[num];
						PointF vertex = new PointF(Conversions.ToSingle(dataRow2["XCoord"]), Conversions.ToSingle(dataRow2["YCoord"]));
						this.AddVertices(vertex);
						num++;
					}
					while (num <= 3);
					this.SubVertices = new PointF[0];
					int num2 = 4;
					int num3 = data.Rows.Count - 1;
					for (int i = num2; i <= num3; i++)
					{
						DataRow dataRow3 = data.Rows[i];
						PointF vertex = new PointF(Conversions.ToSingle(dataRow3["XCoord"]), Conversions.ToSingle(dataRow3["YCoord"]));
						this.AddSubVertices(vertex);
					}
					this.CreationIsCompleted = true;
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

		// Token: 0x060003AA RID: 938 RVA: 0x000A6F0C File Offset: 0x000A5F0C
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
					if (Math.Abs(num5 + num6 - num4) < 0.15)
					{
						return true;
					}
				}
				double num7 = Math.Sqrt(Math.Pow((double)(this.Vertices[0].X - this.Vertices[3].X), 2.0) + Math.Pow((double)(this.Vertices[0].Y - this.Vertices[3].Y), 2.0));
				double num8 = Math.Sqrt(Math.Pow((double)(Pixel.X - this.Vertices[0].X), 2.0) + Math.Pow((double)(Pixel.Y - this.Vertices[0].Y), 2.0));
				double num9 = Math.Sqrt(Math.Pow((double)(Pixel.X - this.Vertices[3].X), 2.0) + Math.Pow((double)(Pixel.Y - this.Vertices[3].Y), 2.0));
				if (Math.Abs(num8 + num9 - num7) < 0.15)
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

		// Token: 0x060003AB RID: 939 RVA: 0x000A7204 File Offset: 0x000A6204
		public void Resize(double X, double Y)
		{
			try
			{
				this.Vertices[1] = new PointF((float)((double)this.Vertices[1].X + X), this.Vertices[1].Y);
				this.Vertices[2] = new PointF((float)((double)this.Vertices[2].X + X), (float)((double)this.Vertices[2].Y + Y));
				this.Vertices[3] = new PointF(this.Vertices[3].X, (float)((double)this.Vertices[3].Y + Y));
				this.CalculateSubVertices();
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x0400019C RID: 412
		private long _ShapeID;

		// Token: 0x0400019D RID: 413
		private Color _Colour;

		// Token: 0x0400019E RID: 414
		private int _Thickness;

		// Token: 0x0400019F RID: 415
		private GlobalVariables.LineStyle _lineStyle;

		// Token: 0x040001A0 RID: 416
		private bool _Visible;

		// Token: 0x040001A1 RID: 417
		private bool _canSelect;

		// Token: 0x040001A2 RID: 418
		private bool _IsSelected;

		// Token: 0x040001A3 RID: 419
		public PointF[] Vertices;

		// Token: 0x040001A4 RID: 420
		public PointF[] SubVertices;

		// Token: 0x040001A5 RID: 421
		private bool CreationIsCompleted;
	}
}
