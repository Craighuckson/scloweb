using System;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using ComPeters;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using OpenTK.Graphics.OpenGL;

namespace U2Drawx64
{
	// Token: 0x0200001C RID: 28
	public class Ellipse : IShape
	{
		// Token: 0x0600030F RID: 783 RVA: 0x000A3DC0 File Offset: 0x000A2DC0
		public Ellipse()
		{
			this._Colour = Color.Black;
			this._Thickness = 1;
			this._Visible = true;
			this._IsSelected = false;
			this._Width = 0;
			this._Height = 0;
			this.CreationIsCompleted = false;
			this.Vertices = new PointF[0];
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x06000310 RID: 784 RVA: 0x000A3E14 File Offset: 0x000A2E14
		// (set) Token: 0x06000311 RID: 785 RVA: 0x000A3E28 File Offset: 0x000A2E28
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

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x06000312 RID: 786 RVA: 0x000A3E34 File Offset: 0x000A2E34
		// (set) Token: 0x06000313 RID: 787 RVA: 0x000A3E48 File Offset: 0x000A2E48
		public int Width
		{
			get
			{
				return this._Width;
			}
			set
			{
				this._Width = value;
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x06000314 RID: 788 RVA: 0x000A3E54 File Offset: 0x000A2E54
		// (set) Token: 0x06000315 RID: 789 RVA: 0x000A3E68 File Offset: 0x000A2E68
		public int Height
		{
			get
			{
				return this._Height;
			}
			set
			{
				this._Height = value;
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x06000316 RID: 790 RVA: 0x000A3E74 File Offset: 0x000A2E74
		// (set) Token: 0x06000317 RID: 791 RVA: 0x000A3E88 File Offset: 0x000A2E88
		public PointF Center
		{
			get
			{
				return this._Center;
			}
			set
			{
				this._Center = value;
			}
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x06000318 RID: 792 RVA: 0x000A3E94 File Offset: 0x000A2E94
		// (set) Token: 0x06000319 RID: 793 RVA: 0x000A3EA8 File Offset: 0x000A2EA8
		public Color Colour
		{
			get
			{
				return this._Colour;
			}
			set
			{
				if (value == Color.LightGreen)
				{
					this._Colour = Color.Green;
				}
				else
				{
					this._Colour = value;
				}
			}
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x0600031A RID: 794 RVA: 0x000A3ECC File Offset: 0x000A2ECC
		// (set) Token: 0x0600031B RID: 795 RVA: 0x000A3EE0 File Offset: 0x000A2EE0
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

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x0600031C RID: 796 RVA: 0x000A3EEC File Offset: 0x000A2EEC
		// (set) Token: 0x0600031D RID: 797 RVA: 0x000A3F00 File Offset: 0x000A2F00
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

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x0600031E RID: 798 RVA: 0x000A3F0C File Offset: 0x000A2F0C
		// (set) Token: 0x0600031F RID: 799 RVA: 0x000A3F20 File Offset: 0x000A2F20
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

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x06000320 RID: 800 RVA: 0x000A3F2C File Offset: 0x000A2F2C
		public Rectangle BoundingRectangle
		{
			get
			{
				return this._BoundingRectangle;
			}
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x06000321 RID: 801 RVA: 0x000A3F40 File Offset: 0x000A2F40
		public GlobalVariables.ShapeType ShapeType
		{
			get
			{
				return GlobalVariables.ShapeType.Ellipse;
			}
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x06000322 RID: 802 RVA: 0x000A3F50 File Offset: 0x000A2F50
		// (set) Token: 0x06000323 RID: 803 RVA: 0x000A3F60 File Offset: 0x000A2F60
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

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x06000324 RID: 804 RVA: 0x000A3F64 File Offset: 0x000A2F64
		public bool isSelected
		{
			get
			{
				return this._IsSelected;
			}
		}

		// Token: 0x06000325 RID: 805 RVA: 0x000A3F78 File Offset: 0x000A2F78
		public void FinishCreation()
		{
			try
			{
				this.CreationIsCompleted = true;
				this.CalculateBoundingRectangle();
				double num = 0.0;
				do
				{
					PointF vertex = new PointF((float)((double)this._Width * Math.Cos(num) + (double)this._Center.X), (float)((double)this._Height * Math.Sin(num) + (double)this._Center.Y));
					this.AddVertices(vertex);
					num += 0.01;
				}
				while (num <= 6.283185307179586);
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x06000326 RID: 806 RVA: 0x000A4020 File Offset: 0x000A3020
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

		// Token: 0x06000327 RID: 807 RVA: 0x000A4094 File Offset: 0x000A3094
		private void CalculateBoundingRectangle()
		{
			checked
			{
				try
				{
					if (this.Width != 0 & this.Height != 0 & !Information.IsNothing(this.Center))
					{
						this._BoundingRectangle = new Rectangle();
						Rectangle boundingRectangle = this._BoundingRectangle;
						Point p = new Point((int)Math.Round((double)(unchecked(this.Center.X - (float)this.Width))), (int)Math.Round((double)(unchecked(this.Center.Y - (float)this.Height))));
						boundingRectangle.AddVertices(p);
						Rectangle boundingRectangle2 = this._BoundingRectangle;
						p = new Point((int)Math.Round((double)(unchecked(this.Center.X + (float)this.Width))), (int)Math.Round((double)(unchecked(this.Center.Y - (float)this.Height))));
						boundingRectangle2.AddVertices(p);
						Rectangle boundingRectangle3 = this._BoundingRectangle;
						p = new Point((int)Math.Round((double)(unchecked(this.Center.X + (float)this.Width))), (int)Math.Round((double)(unchecked(this.Center.Y + (float)this.Height))));
						boundingRectangle3.AddVertices(p);
						Rectangle boundingRectangle4 = this._BoundingRectangle;
						p = new Point((int)Math.Round((double)(unchecked(this.Center.X - (float)this.Width))), (int)Math.Round((double)(unchecked(this.Center.Y + (float)this.Height))));
						boundingRectangle4.AddVertices(p);
					}
				}
				catch (Exception ex)
				{
					ComPetersError.DisplayError(ex);
				}
			}
		}

		// Token: 0x06000328 RID: 808 RVA: 0x000A4260 File Offset: 0x000A3260
		public void Draw()
		{
			try
			{
				GL.Color3(this._Colour);
				if (this._lineStyle == GlobalVariables.LineStyle.Dashed)
				{
					GL.Enable(EnableCap.LineStipple);
					GL.LineStipple(checked(1 + this._Thickness), 56173);
				}
				GL.LineWidth((float)this._Thickness);
				GL.Begin(BeginMode.LineLoop);
				if (!this.CreationIsCompleted)
				{
					double num = 0.0;
					do
					{
						GL.Vertex2((double)this.Width * Math.Cos(num) + (double)this.Center.X, (double)this.Height * Math.Sin(num) + (double)this.Center.Y);
						num += 0.01;
					}
					while (num <= 6.283185307179586);
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

		// Token: 0x06000329 RID: 809 RVA: 0x000A4390 File Offset: 0x000A3390
		public bool isInSelection(PointF first, PointF last)
		{
			return this._BoundingRectangle.isInSelection(first, last);
		}

		// Token: 0x0600032A RID: 810 RVA: 0x000A43AC File Offset: 0x000A33AC
		public void SelectThis()
		{
			try
			{
				this.Colour = Color.Green;
				this._IsSelected = true;
				GlobalVariables.Canvas.AddShapeToSelection(this);
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x0600032B RID: 811 RVA: 0x000A43FC File Offset: 0x000A33FC
		public void Unselect()
		{
			this.Colour = Color.Black;
			this._IsSelected = false;
		}

		// Token: 0x0600032C RID: 812 RVA: 0x000A4410 File Offset: 0x000A3410
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

		// Token: 0x0600032D RID: 813 RVA: 0x000A44A0 File Offset: 0x000A34A0
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
				}
				catch (Exception ex)
				{
					ComPetersError.DisplayError(ex);
				}
			}
		}

		// Token: 0x0600032E RID: 814 RVA: 0x000A4514 File Offset: 0x000A3514
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

		// Token: 0x0600032F RID: 815 RVA: 0x000A45D4 File Offset: 0x000A35D4
		public IShape Clone()
		{
			IShape result;
			try
			{
				Ellipse ellipse = new Ellipse();
				ellipse.Colour = this.Colour;
				ellipse.LineStyle = this.LineStyle;
				ellipse.Thickness = this.Thickness;
				ellipse.Visible = this.Visible;
				ellipse.Width = this.Width;
				ellipse.Height = this.Height;
				Ellipse ellipse2 = ellipse;
				PointF center = new PointF(this.Center.X, this.Center.Y);
				ellipse2.Center = center;
				result = ellipse;
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
				result = null;
			}
			return result;
		}

		// Token: 0x06000330 RID: 816 RVA: 0x000A4688 File Offset: 0x000A3688
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
				sqliteCommand.Parameters.AddWithValue("@ShapeType", "ellipse");
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
				foreach (PointF pointF2 in this.Vertices)
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

		// Token: 0x06000331 RID: 817 RVA: 0x000A48C4 File Offset: 0x000A38C4
		public void Load(DataTable data, Undo undoObj, string FileName = "")
		{
			checked
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
					this.Vertices = new PointF[0];
					int num = 4;
					int num2 = data.Rows.Count - 1;
					for (int i = num; i <= num2; i++)
					{
						DataRow dataRow5 = data.Rows[i];
						vertex = new PointF(Conversions.ToSingle(dataRow5["XCoord"]), Conversions.ToSingle(dataRow5["YCoord"]));
						this.AddVertices(vertex);
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

		// Token: 0x06000332 RID: 818 RVA: 0x000A4AE8 File Offset: 0x000A3AE8
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

		// Token: 0x06000333 RID: 819 RVA: 0x000A4B7C File Offset: 0x000A3B7C
		public void Resize(double X, double Y)
		{
		}

		// Token: 0x04000181 RID: 385
		private long _ShapeID;

		// Token: 0x04000182 RID: 386
		private Color _Colour;

		// Token: 0x04000183 RID: 387
		private int _Thickness;

		// Token: 0x04000184 RID: 388
		private GlobalVariables.LineStyle _lineStyle;

		// Token: 0x04000185 RID: 389
		private bool _Visible;

		// Token: 0x04000186 RID: 390
		private bool _IsSelected;

		// Token: 0x04000187 RID: 391
		private int _Width;

		// Token: 0x04000188 RID: 392
		private int _Height;

		// Token: 0x04000189 RID: 393
		private PointF _Center;

		// Token: 0x0400018A RID: 394
		private Rectangle _BoundingRectangle;

		// Token: 0x0400018B RID: 395
		private bool CreationIsCompleted;

		// Token: 0x0400018C RID: 396
		public PointF[] Vertices;
	}
}
