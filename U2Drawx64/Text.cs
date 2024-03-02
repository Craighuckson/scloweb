using System;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Drawing.Imaging;
using ComPeters;
using Microsoft.VisualBasic.CompilerServices;
using OpenTK.Graphics.OpenGL;

namespace U2Drawx64
{
	// Token: 0x02000023 RID: 35
	public class Text : IShape
	{
		// Token: 0x060003F0 RID: 1008 RVA: 0x000A9278 File Offset: 0x000A8278
		public Text()
		{
			this._Colour = Color.Black;
			this._Thickness = 13;
			this._Visible = true;
			this._SIZE = 2048;
			this._actualsize = new SizeF(0f, 0f);
			this._IsSelected = false;
			this.InternalFormat = PixelInternalFormat.Rgba;
			this.format = OpenTK.Graphics.OpenGL.PixelFormat.Bgra;
			this.GridVertices = new PointF[0];
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x060003F1 RID: 1009 RVA: 0x000A92F0 File Offset: 0x000A82F0
		// (set) Token: 0x060003F2 RID: 1010 RVA: 0x000A9304 File Offset: 0x000A8304
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

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x060003F3 RID: 1011 RVA: 0x000A9310 File Offset: 0x000A8310
		// (set) Token: 0x060003F4 RID: 1012 RVA: 0x000A9324 File Offset: 0x000A8324
		public Color Colour
		{
			get
			{
				return this._Colour;
			}
			set
			{
				this._Colour = value;
				this.LoadStringIntoTexture();
			}
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x060003F5 RID: 1013 RVA: 0x000A9334 File Offset: 0x000A8334
		// (set) Token: 0x060003F6 RID: 1014 RVA: 0x000A935C File Offset: 0x000A835C
		public int Thickness
		{
			get
			{
				return checked((int)Math.Round((double)(this._Thickness - 11) / 2.0));
			}
			set
			{
				this._Thickness = checked(value * 2 + 11);
				this.Resize();
				this.LoadStringIntoTexture();
			}
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x060003F7 RID: 1015 RVA: 0x000A9378 File Offset: 0x000A8378
		// (set) Token: 0x060003F8 RID: 1016 RVA: 0x000A938C File Offset: 0x000A838C
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

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x060003F9 RID: 1017 RVA: 0x000A9398 File Offset: 0x000A8398
		// (set) Token: 0x060003FA RID: 1018 RVA: 0x000A93AC File Offset: 0x000A83AC
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

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x060003FB RID: 1019 RVA: 0x000A93B8 File Offset: 0x000A83B8
		public double Width
		{
			get
			{
				return (double)this._actualsize.Width;
			}
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x060003FC RID: 1020 RVA: 0x000A93D4 File Offset: 0x000A83D4
		public double Height
		{
			get
			{
				return (double)this._actualsize.Height;
			}
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x060003FD RID: 1021 RVA: 0x000A93F0 File Offset: 0x000A83F0
		// (set) Token: 0x060003FE RID: 1022 RVA: 0x000A9404 File Offset: 0x000A8404
		public PointF Location
		{
			get
			{
				return this._location;
			}
			set
			{
				this._location = value;
				this.CalculateBoundingBox();
			}
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x060003FF RID: 1023 RVA: 0x000A9414 File Offset: 0x000A8414
		// (set) Token: 0x06000400 RID: 1024 RVA: 0x000A9428 File Offset: 0x000A8428
		public string Text
		{
			get
			{
				return this._text;
			}
			set
			{
				this._text = value;
				if (Operators.CompareString(value, string.Empty, false) != 0)
				{
					this.Resize();
				}
				this.LoadStringIntoTexture();
			}
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x06000401 RID: 1025 RVA: 0x000A944C File Offset: 0x000A844C
		public Rectangle BoundingRectangle
		{
			get
			{
				return this._BoundingRectangle;
			}
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x06000402 RID: 1026 RVA: 0x000A9460 File Offset: 0x000A8460
		public GlobalVariables.ShapeType ShapeType
		{
			get
			{
				return GlobalVariables.ShapeType.Text;
			}
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x06000403 RID: 1027 RVA: 0x000A9470 File Offset: 0x000A8470
		// (set) Token: 0x06000404 RID: 1028 RVA: 0x000A9480 File Offset: 0x000A8480
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

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x06000405 RID: 1029 RVA: 0x000A9484 File Offset: 0x000A8484
		public bool isSelected
		{
			get
			{
				return this._IsSelected;
			}
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x06000406 RID: 1030 RVA: 0x000A9498 File Offset: 0x000A8498
		private int Size
		{
			get
			{
				return this._SIZE;
			}
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x000A94AC File Offset: 0x000A84AC
		private void SetRAMSize(SizeF size)
		{
			checked
			{
				try
				{
					int num = (int)Math.Round((double)Math.Max(size.Width, size.Height));
					int num2 = 0;
					while (Math.Max((double)num, Math.Pow(2.0, (double)num2)) == (double)num)
					{
						num2++;
						if (num2 > 20)
						{
							return;
						}
					}
					this._SIZE = (int)Math.Round(Math.Pow(2.0, (double)num2));
				}
				catch (Exception ex)
				{
					ComPetersError.DisplayError(ex);
				}
			}
		}

		// Token: 0x06000408 RID: 1032 RVA: 0x000A9544 File Offset: 0x000A8544
		private void CalculateBoundingBox()
		{
			try
			{
				this._BoundingRectangle = new Rectangle();
				Rectangle boundingRectangle = this._BoundingRectangle;
				PointF location = this.Location;
				PointF location2 = new PointF(location.X, this.Location.Y);
				boundingRectangle.AddVertices(location2);
				Rectangle boundingRectangle2 = this._BoundingRectangle;
				location2 = this.Location;
				location = new PointF(location2.X + this._actualsize.Width, this.Location.Y);
				boundingRectangle2.AddVertices(location);
				Rectangle boundingRectangle3 = this._BoundingRectangle;
				location2 = this.Location;
				location = new PointF(location2.X + this._actualsize.Width, this.Location.Y + this._actualsize.Height);
				boundingRectangle3.AddVertices(location);
				Rectangle boundingRectangle4 = this._BoundingRectangle;
				float x = this.Location.X;
				location2 = this.Location;
				location = new PointF(x, location2.Y + this._actualsize.Height);
				boundingRectangle4.AddVertices(location);
				this._BoundingRectangle.FinishCreation();
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x06000409 RID: 1033 RVA: 0x000A9688 File Offset: 0x000A8688
		private void AddVertices(PointF Vertex)
		{
			try
			{
				long num = (long)this.GridVertices.Length;
				checked
				{
					this.GridVertices = (PointF[])Utils.CopyArray((Array)this.GridVertices, new PointF[(int)num + 1]);
					this.GridVertices[(int)num] = Vertex;
				}
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x000A96FC File Offset: 0x000A86FC
		private void LoadStringIntoTexture()
		{
			try
			{
				if (Operators.CompareString(this.Text, string.Empty, false) != 0)
				{
					Bitmap bitmap = new Bitmap(this.Size, this.Size, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
					Graphics graphics = Graphics.FromImage(bitmap);
					graphics.Clear(Color.White);
					graphics.DrawString(this._text, new Font("Arial", (float)this._Thickness, FontStyle.Regular, GraphicsUnit.Pixel), new SolidBrush(this._Colour), 0f, 0f);
					graphics.Dispose();
					BitmapData bitmapData = new BitmapData();
					Rectangle rect = checked(new Rectangle(0, 0, (int)Math.Round((double)this._actualsize.Width), (int)Math.Round((double)this._actualsize.Height)));
					bitmapData = bitmap.LockBits(rect, ImageLockMode.ReadOnly, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
					GL.GenTextures(1, out this._textureID);
					GL.BindTexture(TextureTarget.Texture2D, this._textureID);
					GL.TexImage2D(TextureTarget.Texture2D, 0, this.InternalFormat, bitmap.Width, bitmap.Height, 0, this.format, PixelType.UnsignedByte, bitmapData.Scan0);
					GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureWrapS, 33071);
					GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureWrapT, 33071);
					GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMinFilter, 9729);
					GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMagFilter, 9729);
					bitmap.UnlockBits(bitmapData);
					bitmap.Dispose();
				}
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x000A98A0 File Offset: 0x000A88A0
		private void Resize()
		{
			try
			{
				Bitmap image = new Bitmap(this.Size, this.Size, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
				Graphics graphics = Graphics.FromImage(image);
				this._actualsize = graphics.MeasureString(this._text, new Font("Arial", (float)this._Thickness, FontStyle.Regular, GraphicsUnit.Pixel));
				this.SetRAMSize(this._actualsize);
				graphics.Dispose();
				this.CalculateBoundingBox();
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x0600040C RID: 1036 RVA: 0x000A9930 File Offset: 0x000A8930
		public void Draw()
		{
			try
			{
				if (Operators.CompareString(this.Text, string.Empty, false) != 0)
				{
					GL.Enable(EnableCap.Texture2D);
					GL.TexEnv(TextureEnvTarget.TextureEnv, TextureEnvParameter.TextureEnvMode, 8449);
					GL.BindTexture(TextureTarget.Texture2D, this._textureID);
					GL.Begin(BeginMode.Quads);
					GL.TexCoord2(0.0, 0.0);
					GL.Vertex2(this._BoundingRectangle.Vertices[0].X, this._BoundingRectangle.Vertices[0].Y);
					GL.TexCoord2((double)(this._actualsize.Width / (float)this.Size), 0.0);
					GL.Vertex2(this._BoundingRectangle.Vertices[1].X, this._BoundingRectangle.Vertices[1].Y);
					GL.TexCoord2(this._actualsize.Width / (float)this.Size, this._actualsize.Height / (float)this.Size);
					GL.Vertex2(this._BoundingRectangle.Vertices[2].X, this._BoundingRectangle.Vertices[2].Y);
					GL.TexCoord2(0.0, (double)(this._actualsize.Height / (float)this.Size));
					GL.Vertex2(this._BoundingRectangle.Vertices[3].X, this._BoundingRectangle.Vertices[3].Y);
					GL.End();
					GL.Disable(EnableCap.Texture2D);
				}
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x0600040D RID: 1037 RVA: 0x000A9B14 File Offset: 0x000A8B14
		public bool isInSelection(PointF first, PointF last)
		{
			bool result;
			try
			{
				PointF location = this.Location;
				PointF pointF = new PointF(this.Location.X + this._actualsize.Width, this.Location.Y + this._actualsize.Height);
				if (location.X >= first.X & location.Y >= first.Y)
				{
					if (!(location.X <= last.X & location.Y <= last.Y))
					{
						return false;
					}
					if (!(pointF.X >= first.X & pointF.Y >= first.Y))
					{
						return false;
					}
					if (!(pointF.X <= last.X & pointF.Y <= last.Y))
					{
						return false;
					}
				}
				else if (location.X <= first.X & location.Y <= first.Y)
				{
					if (!(location.X >= last.X & location.Y >= last.Y))
					{
						return false;
					}
					if (!(pointF.X <= first.X & pointF.Y <= first.Y))
					{
						return false;
					}
					if (!(pointF.X >= last.X & pointF.Y >= last.Y))
					{
						return false;
					}
				}
				else if (location.X <= first.X & location.Y >= first.Y)
				{
					if (!(location.X >= last.X & location.Y <= last.Y))
					{
						return false;
					}
					if (!(pointF.X <= first.X & pointF.Y >= first.Y))
					{
						return false;
					}
					if (!(pointF.X >= last.X & pointF.Y <= last.Y))
					{
						return false;
					}
				}
				else
				{
					if (!(location.X >= first.X & location.Y <= first.Y))
					{
						return false;
					}
					if (!(location.X <= last.X & location.Y >= last.Y))
					{
						return false;
					}
					if (!(location.X >= first.X & pointF.Y <= first.Y))
					{
						return false;
					}
					if (!(location.X <= last.X & location.Y >= last.Y))
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

		// Token: 0x0600040E RID: 1038 RVA: 0x000A9E98 File Offset: 0x000A8E98
		public void SelectThis()
		{
			this.Colour = Color.LightGreen;
			this.LoadStringIntoTexture();
			this._IsSelected = true;
			GlobalVariables.Canvas.AddShapeToSelection(this);
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x000A9EC0 File Offset: 0x000A8EC0
		public void Unselect()
		{
			this.Colour = Color.Black;
			this.LoadStringIntoTexture();
			this._IsSelected = false;
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x000A9EDC File Offset: 0x000A8EDC
		public void Move(int AddToX, int AddToY)
		{
			try
			{
				this._location.X = this._location.X + (float)AddToX;
				this._location.Y = this._location.Y + (float)AddToY;
				this._BoundingRectangle.Move(AddToX, AddToY);
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x000A9F50 File Offset: 0x000A8F50
		public void Rotate(double radians, PointF Pivot)
		{
			try
			{
				this._location = this.RotatePoint(this._location, Pivot, radians);
				this._BoundingRectangle.Rotate(radians, Pivot);
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x06000412 RID: 1042 RVA: 0x000A9FA4 File Offset: 0x000A8FA4
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

		// Token: 0x06000413 RID: 1043 RVA: 0x000AA064 File Offset: 0x000A9064
		public IShape Clone()
		{
			IShape result;
			try
			{
				Text text = new Text();
				text.Colour = this.Colour;
				text.LineStyle = this.LineStyle;
				Text text2 = text;
				PointF location = new PointF(this.Location.X, this.Location.Y);
				text2.Location = location;
				text.Text = this.Text;
				text.Thickness = this.Thickness;
				text.Visible = this.Visible;
				result = text;
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
				result = null;
			}
			return result;
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x000AA10C File Offset: 0x000A910C
		public void SaveToTemplate(SQLiteConnection database, SQLiteTransaction trans, long TemplateID, string FileName = "")
		{
			try
			{
				SQLiteCommand sqliteCommand = new SQLiteCommand();
				sqliteCommand.CommandText = "Insert into tbDrawing_TemplateShapes (ParentTemplate,Size,Colour,PenStyle,ShapeType,DisplayText) values (@ParentTemplate,@Size,@Colour,@PenStyle,@ShapeType,@DisplayText)";
				sqliteCommand.Connection = database;
				sqliteCommand.Transaction = trans;
				sqliteCommand.Parameters.AddWithValue("@ParentTemplate", TemplateID);
				sqliteCommand.Parameters.AddWithValue("@Size", this._Thickness);
				sqliteCommand.Parameters.AddWithValue("@Colour", this._Colour.ToArgb());
				sqliteCommand.Parameters.AddWithValue("@PenStyle", this._lineStyle);
				sqliteCommand.Parameters.AddWithValue("@ShapeType", "text");
				sqliteCommand.Parameters.AddWithValue("@DisplayText", this.Text);
				sqliteCommand.ExecuteNonQuery();
				SQLiteCommand sqliteCommand2 = new SQLiteCommand("Select last_insert_rowid() as rowid", database, trans);
				long num = Conversions.ToLong(sqliteCommand2.ExecuteScalar());
				foreach (PointF pointF in this._BoundingRectangle.Vertices)
				{
					SQLiteCommand sqliteCommand3 = new SQLiteCommand("Insert into tbDrawing_TemplateShapeCoords (ShapeIndex,XCoord,YCoord) values (@ShapeIndex,@XCoord,@YCoord)", database, trans);
					sqliteCommand3.Parameters.AddWithValue("@ShapeIndex", num);
					sqliteCommand3.Parameters.AddWithValue("@XCoord", pointF.X);
					sqliteCommand3.Parameters.AddWithValue("@YCoord", pointF.Y);
					sqliteCommand3.ExecuteNonQuery();
				}
				foreach (PointF pointF2 in this._BoundingRectangle.SubVertices)
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

		// Token: 0x06000415 RID: 1045 RVA: 0x000AA364 File Offset: 0x000A9364
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
					this.Text = Conversions.ToString(dataRow["DisplayText"]);
					this._BoundingRectangle.Vertices = new PointF[0];
					int num = 0;
					do
					{
						DataRow dataRow2 = data.Rows[num];
						Rectangle boundingRectangle = this._BoundingRectangle;
						PointF vertex = new PointF(Conversions.ToSingle(dataRow2["XCoord"]), Conversions.ToSingle(dataRow2["YCoord"]));
						boundingRectangle.AddVertices(vertex);
						num++;
					}
					while (num <= 3);
					this._BoundingRectangle.SubVertices = new PointF[0];
					int num2 = 4;
					int num3 = data.Rows.Count - 1;
					for (int i = num2; i <= num3; i++)
					{
						DataRow dataRow3 = data.Rows[i];
						Rectangle boundingRectangle2 = this._BoundingRectangle;
						PointF vertex = new PointF(Conversions.ToSingle(dataRow3["XCoord"]), Conversions.ToSingle(dataRow3["YCoord"]));
						boundingRectangle2.AddSubVertices(vertex);
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

		// Token: 0x06000416 RID: 1046 RVA: 0x000AA4F8 File Offset: 0x000A94F8
		public bool isInSelection(PointF Pixel)
		{
			bool result;
			try
			{
				PointF pointF = new PointF(this._BoundingRectangle.Vertices[1].X - this._BoundingRectangle.Vertices[0].X, this._BoundingRectangle.Vertices[1].Y - this._BoundingRectangle.Vertices[0].Y);
				PointF pointF2 = new PointF(this._BoundingRectangle.Vertices[3].X - this._BoundingRectangle.Vertices[0].X, this._BoundingRectangle.Vertices[3].Y - this._BoundingRectangle.Vertices[0].Y);
				PointF vector = new PointF(Pixel.X - this._BoundingRectangle.Vertices[0].X, Pixel.Y - this._BoundingRectangle.Vertices[0].Y);
				if (0.0 <= GlobalVariables.Dot(vector, pointF) & GlobalVariables.Dot(vector, pointF) <= GlobalVariables.Dot(pointF, pointF) & 0.0 <= GlobalVariables.Dot(vector, pointF2) & GlobalVariables.Dot(vector, pointF2) <= GlobalVariables.Dot(pointF2, pointF2))
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

		// Token: 0x06000417 RID: 1047 RVA: 0x000AA69C File Offset: 0x000A969C
		public void Resize1(double X, double Y)
		{
		}

		// Token: 0x040001BC RID: 444
		private long _ShapeID;

		// Token: 0x040001BD RID: 445
		private Color _Colour;

		// Token: 0x040001BE RID: 446
		private int _Thickness;

		// Token: 0x040001BF RID: 447
		private GlobalVariables.LineStyle _lineStyle;

		// Token: 0x040001C0 RID: 448
		private bool _Visible;

		// Token: 0x040001C1 RID: 449
		private PointF _location;

		// Token: 0x040001C2 RID: 450
		private string _text;

		// Token: 0x040001C3 RID: 451
		private int _SIZE;

		// Token: 0x040001C4 RID: 452
		private SizeF _actualsize;

		// Token: 0x040001C5 RID: 453
		private int _textureID;

		// Token: 0x040001C6 RID: 454
		private bool _IsSelected;

		// Token: 0x040001C7 RID: 455
		private Rectangle _BoundingRectangle;

		// Token: 0x040001C8 RID: 456
		public PixelInternalFormat InternalFormat;

		// Token: 0x040001C9 RID: 457
		public OpenTK.Graphics.OpenGL.PixelFormat format;

		// Token: 0x040001CA RID: 458
		private PointF[] GridVertices;
	}
}
