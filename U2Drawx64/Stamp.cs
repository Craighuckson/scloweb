using System;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ComPeters;
using Microsoft.VisualBasic.CompilerServices;
using OpenTK.Graphics.OpenGL;

namespace U2Drawx64
{
	// Token: 0x02000022 RID: 34
	public class Stamp : IShape
	{
		// Token: 0x060003CA RID: 970 RVA: 0x000A7A5C File Offset: 0x000A6A5C
		public Stamp()
		{
			this._Colour = Color.Black;
			this._Thickness = 1;
			this._Visible = true;
			this._SIZE = 0;
			this._actualsize = new SizeF(0f, 0f);
			this._isSelected = false;
			this.GridVertices = new PointF[0];
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x060003CB RID: 971 RVA: 0x000A7AB8 File Offset: 0x000A6AB8
		// (set) Token: 0x060003CC RID: 972 RVA: 0x000A7ACC File Offset: 0x000A6ACC
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

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x060003CD RID: 973 RVA: 0x000A7AD8 File Offset: 0x000A6AD8
		// (set) Token: 0x060003CE RID: 974 RVA: 0x000A7AEC File Offset: 0x000A6AEC
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

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x060003CF RID: 975 RVA: 0x000A7AF8 File Offset: 0x000A6AF8
		// (set) Token: 0x060003D0 RID: 976 RVA: 0x000A7B0C File Offset: 0x000A6B0C
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

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x060003D1 RID: 977 RVA: 0x000A7B18 File Offset: 0x000A6B18
		// (set) Token: 0x060003D2 RID: 978 RVA: 0x000A7B2C File Offset: 0x000A6B2C
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

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x060003D3 RID: 979 RVA: 0x000A7B38 File Offset: 0x000A6B38
		// (set) Token: 0x060003D4 RID: 980 RVA: 0x000A7B4C File Offset: 0x000A6B4C
		public PointF Location
		{
			get
			{
				return this._location;
			}
			set
			{
				this._location = value;
			}
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x060003D5 RID: 981 RVA: 0x000A7B58 File Offset: 0x000A6B58
		// (set) Token: 0x060003D6 RID: 982 RVA: 0x000A7B6C File Offset: 0x000A6B6C
		public object ImageFile
		{
			get
			{
				return this._imageFile;
			}
			set
			{
				this._imageFile = Conversions.ToString(value);
				this.LoadJPGIntoTexture();
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x060003D7 RID: 983 RVA: 0x000A7B80 File Offset: 0x000A6B80
		// (set) Token: 0x060003D8 RID: 984 RVA: 0x000A7B94 File Offset: 0x000A6B94
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

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x060003D9 RID: 985 RVA: 0x000A7BA0 File Offset: 0x000A6BA0
		public Rectangle BoundingRectangle
		{
			get
			{
				return this._BoundingRectangle;
			}
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x060003DA RID: 986 RVA: 0x000A7BB4 File Offset: 0x000A6BB4
		public GlobalVariables.ShapeType ShapeType
		{
			get
			{
				return GlobalVariables.ShapeType.Stamp;
			}
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x060003DB RID: 987 RVA: 0x000A7BC4 File Offset: 0x000A6BC4
		// (set) Token: 0x060003DC RID: 988 RVA: 0x000A7BD4 File Offset: 0x000A6BD4
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

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x060003DD RID: 989 RVA: 0x000A7BD8 File Offset: 0x000A6BD8
		public bool isSelected
		{
			get
			{
				return this._isSelected;
			}
		}

		// Token: 0x060003DE RID: 990 RVA: 0x000A7BEC File Offset: 0x000A6BEC
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
				location2 = this.Location;
				double num = (double)location2.X;
				double num2 = (double)(this.Location.X + this._actualsize.Width);
				double num3 = 0.03 * (double)this._actualsize.Width;
				double limit = num2;
				double num4 = num;
				while (ObjectFlowControl.ForLoopControl.ForNextCheckR8(num4, limit, num3))
				{
					double num5 = (double)this.Location.Y;
					double num6 = (double)(this.Location.Y + this._actualsize.Height);
					double num7 = 0.03 * (double)this._actualsize.Height;
					double limit2 = num6;
					double num8 = num5;
					while (ObjectFlowControl.ForLoopControl.ForNextCheckR8(num8, limit2, num7))
					{
						Point p = checked(new Point((int)Math.Round(num4), (int)Math.Round(num8)));
						this.AddVertices(p);
						num8 += num7;
					}
					num4 += num3;
				}
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x060003DF RID: 991 RVA: 0x000A7E08 File Offset: 0x000A6E08
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

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x060003E0 RID: 992 RVA: 0x000A7E7C File Offset: 0x000A6E7C
		private int Size
		{
			get
			{
				return this._SIZE;
			}
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x000A7E90 File Offset: 0x000A6E90
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

		// Token: 0x060003E2 RID: 994 RVA: 0x000A7F28 File Offset: 0x000A6F28
		private void LoadJPGIntoTexture()
		{
			try
			{
				Image image = Image.FromFile(this._imageFile);
				this._actualsize = image.Size;
				this.SetRAMSize(image.Size);
				this.CalculateBoundingBox();
				Bitmap bitmap = new Bitmap(this.Size, this.Size, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
				Graphics graphics = Graphics.FromImage(bitmap);
				Graphics graphics2 = graphics;
				Image image2 = image;
				Rectangle rectangle = new Rectangle(0, 0, image.Width, image.Height);
				Rectangle destRect = rectangle;
				Rectangle srcRect = new Rectangle(0, 0, image.Width, image.Height);
				graphics2.DrawImage(image2, destRect, srcRect, GraphicsUnit.Pixel);
				graphics.Dispose();
				BitmapData bitmapData = new BitmapData();
				Rectangle rect = new Rectangle(0, 0, image.Width, image.Height);
				bitmapData = bitmap.LockBits(rect, ImageLockMode.ReadOnly, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
				GL.GenTextures(1, out this._textureID);
				GL.BindTexture(TextureTarget.Texture2D, this._textureID);
				GL.TexImage2D(TextureTarget.Texture2D, 0, PixelInternalFormat.Rgb8, bitmap.Width, bitmap.Height, 0, OpenTK.Graphics.OpenGL.PixelFormat.Bgr, PixelType.UnsignedByte, bitmapData.Scan0);
				GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureWrapS, 33071);
				GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureWrapT, 33071);
				GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMinFilter, 9729);
				GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMagFilter, 9729);
				bitmap.UnlockBits(bitmapData);
				bitmap.Dispose();
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x060003E3 RID: 995 RVA: 0x000A80D0 File Offset: 0x000A70D0
		private void LoadBytesIntoTexture(byte[] Bytes)
		{
			try
			{
				MemoryStream stream = new MemoryStream(Bytes);
				Image image = Image.FromStream(stream);
				this._actualsize = image.Size;
				this.SetRAMSize(image.Size);
				this.CalculateBoundingBox();
				Bitmap bitmap = new Bitmap(this.Size, this.Size, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
				Graphics graphics = Graphics.FromImage(bitmap);
				Graphics graphics2 = graphics;
				Image image2 = image;
				Rectangle rectangle = new Rectangle(0, 0, image.Width, image.Height);
				Rectangle destRect = rectangle;
				Rectangle srcRect = new Rectangle(0, 0, image.Width, image.Height);
				graphics2.DrawImage(image2, destRect, srcRect, GraphicsUnit.Pixel);
				graphics.Dispose();
				BitmapData bitmapData = new BitmapData();
				Rectangle rect = new Rectangle(0, 0, image.Width, image.Height);
				bitmapData = bitmap.LockBits(rect, ImageLockMode.ReadOnly, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
				GL.GenTextures(1, out this._textureID);
				GL.BindTexture(TextureTarget.Texture2D, this._textureID);
				GL.TexImage2D(TextureTarget.Texture2D, 0, PixelInternalFormat.Rgb8, bitmap.Width, bitmap.Height, 0, OpenTK.Graphics.OpenGL.PixelFormat.Bgr, PixelType.UnsignedByte, bitmapData.Scan0);
				GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureWrapS, 33071);
				GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureWrapT, 33071);
				GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMinFilter, 9729);
				GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMagFilter, 9729);
				bitmap.UnlockBits(bitmapData);
				bitmap.Dispose();
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x060003E4 RID: 996 RVA: 0x000A8278 File Offset: 0x000A7278
		public void Draw()
		{
			try
			{
				GL.Enable(EnableCap.Texture2D);
				GL.LineWidth((float)this._Thickness);
				GL.BindTexture(TextureTarget.Texture2D, this._textureID);
				GL.TexEnv(TextureEnvTarget.TextureEnv, TextureEnvParameter.TextureEnvMode, 8449);
				GL.Begin(BeginMode.Quads);
				GL.TexCoord2(0.0, 0.0);
				GL.Vertex3(this._BoundingRectangle.Vertices[0].X, this._BoundingRectangle.Vertices[0].Y, 5f);
				GL.TexCoord2((double)(this._actualsize.Width / (float)this.Size), 0.0);
				GL.Vertex3(this._BoundingRectangle.Vertices[1].X, this._BoundingRectangle.Vertices[1].Y, 5f);
				GL.TexCoord2(this._actualsize.Width / (float)this.Size, this._actualsize.Height / (float)this.Size);
				GL.Vertex3(this._BoundingRectangle.Vertices[2].X, this._BoundingRectangle.Vertices[2].Y, 5f);
				GL.TexCoord2(0.0, (double)(this._actualsize.Height / (float)this.Size));
				GL.Vertex3(this._BoundingRectangle.Vertices[3].X, this._BoundingRectangle.Vertices[3].Y, 5f);
				GL.End();
				GL.Disable(EnableCap.Texture2D);
				if (this.isSelected)
				{
					GL.PointSize(2f);
					GL.Color3(Color.LightGreen);
					GL.Begin(BeginMode.Points);
					foreach (PointF pointF in this.GridVertices)
					{
						GL.Vertex2(pointF.X, pointF.Y);
					}
					GL.End();
				}
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x060003E5 RID: 997 RVA: 0x000A84C0 File Offset: 0x000A74C0
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

		// Token: 0x060003E6 RID: 998 RVA: 0x000A8844 File Offset: 0x000A7844
		public void SelectThis()
		{
			this._isSelected = true;
			GlobalVariables.Canvas.AddShapeToSelection(this);
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x000A8858 File Offset: 0x000A7858
		public void Unselect()
		{
			this._isSelected = false;
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x000A8864 File Offset: 0x000A7864
		public void Move(int AddToX, int AddToY)
		{
			try
			{
				this._location.X = this._location.X + (float)AddToX;
				this._location.Y = this._location.Y + (float)AddToY;
				int num = 0;
				checked
				{
					int num2 = this.GridVertices.Length - 1;
					for (int i = num; i <= num2; i++)
					{
						this.GridVertices[i] = unchecked(new PointF(this.GridVertices[i].X + (float)AddToX, this.GridVertices[i].Y + (float)AddToY));
					}
					this._BoundingRectangle.Move(AddToX, AddToY);
				}
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x000A8928 File Offset: 0x000A7928
		public void Rotate(double radians, PointF Pivot)
		{
			checked
			{
				try
				{
					this._location = this.RotatePoint(this._location, Pivot, radians);
					int num = 0;
					int num2 = this.GridVertices.Length - 1;
					for (int i = num; i <= num2; i++)
					{
						this.GridVertices[i] = this.RotatePoint(this.GridVertices[i], Pivot, radians);
					}
					this._BoundingRectangle.Rotate(radians, Pivot);
				}
				catch (Exception ex)
				{
					ComPetersError.DisplayError(ex);
				}
			}
		}

		// Token: 0x060003EA RID: 1002 RVA: 0x000A89C0 File Offset: 0x000A79C0
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

		// Token: 0x060003EB RID: 1003 RVA: 0x000A8A80 File Offset: 0x000A7A80
		public IShape Clone()
		{
			IShape result;
			try
			{
				Stamp stamp = new Stamp();
				stamp.Colour = this.Colour;
				stamp.ImageFile = RuntimeHelpers.GetObjectValue(this.ImageFile);
				stamp.LineStyle = this.LineStyle;
				Stamp stamp2 = stamp;
				PointF location = new PointF(this.Location.X, this.Location.Y);
				stamp2.Location = location;
				stamp.Thickness = this.Thickness;
				stamp.Visible = this.Visible;
				result = stamp;
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
				result = null;
			}
			return result;
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x000A8B2C File Offset: 0x000A7B2C
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

		// Token: 0x060003ED RID: 1005 RVA: 0x000A8D6C File Offset: 0x000A7D6C
		public void Load(DataTable data, Undo undoObj, string FileName = "")
		{
			checked
			{
				try
				{
					SQLiteConnection sqliteConnection = new SQLiteConnection();
					sqliteConnection.ConnectionString = "Data Source=" + Application.StartupPath + Config.GetOption(Config.Setting.DBDrawingDatabase) + ";Version=3;";
					DataRow dataRow = data.Rows[0];
					string commandText = Conversions.ToString(Operators.ConcatenateObject("Select FileBytes from tbDrawing_TemplateShapes where ShapeIndex=", dataRow["ShapeIndex"]));
					sqliteConnection.Open();
					SQLiteCommand sqliteCommand = new SQLiteCommand(commandText, sqliteConnection);
					this.LoadBytesIntoTexture((byte[])sqliteCommand.ExecuteScalar());
					sqliteConnection.Close();
					this._lineStyle = (GlobalVariables.LineStyle)Conversions.ToInteger(dataRow["PenStyle"]);
					this._Thickness = Conversions.ToInteger(dataRow["Size"]);
					this._Colour = Color.FromArgb(Conversions.ToInteger(dataRow["Colour"]));
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
					GlobalVariables.Canvas.Add(this);
					undoObj.AddShape(this);
				}
				catch (Exception ex)
				{
					ComPetersError.DisplayError(ex);
				}
			}
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x000A8F58 File Offset: 0x000A7F58
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
			}
			return result;
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x000A90FC File Offset: 0x000A80FC
		public void Resize(double X, double Y)
		{
			try
			{
				this._BoundingRectangle.Resize(X, Y);
				this.GridVertices = new PointF[0];
				double num = (double)this._BoundingRectangle.Vertices[0].X;
				double num2 = (double)this._BoundingRectangle.Vertices[1].X;
				double num3 = 0.03 * (double)(this._BoundingRectangle.Vertices[1].X - this._BoundingRectangle.Vertices[0].X);
				double limit = num2;
				double num4 = num;
				while (ObjectFlowControl.ForLoopControl.ForNextCheckR8(num4, limit, num3))
				{
					double num5 = (double)this._BoundingRectangle.Vertices[0].Y;
					double num6 = (double)this._BoundingRectangle.Vertices[2].Y;
					double num7 = 0.03 * (double)(this._BoundingRectangle.Vertices[2].Y - this._BoundingRectangle.Vertices[0].Y);
					double limit2 = num6;
					double num8 = num5;
					while (ObjectFlowControl.ForLoopControl.ForNextCheckR8(num8, limit2, num7))
					{
						Point p = checked(new Point((int)Math.Round(num4), (int)Math.Round(num8)));
						this.AddVertices(p);
						num8 += num7;
					}
					num4 += num3;
				}
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x040001AE RID: 430
		private long _ShapeID;

		// Token: 0x040001AF RID: 431
		private Color _Colour;

		// Token: 0x040001B0 RID: 432
		private int _Thickness;

		// Token: 0x040001B1 RID: 433
		private GlobalVariables.LineStyle _lineStyle;

		// Token: 0x040001B2 RID: 434
		private bool _Visible;

		// Token: 0x040001B3 RID: 435
		private PointF _location;

		// Token: 0x040001B4 RID: 436
		private string _imageFile;

		// Token: 0x040001B5 RID: 437
		private byte[] _imageBytes;

		// Token: 0x040001B6 RID: 438
		private int _SIZE;

		// Token: 0x040001B7 RID: 439
		private SizeF _actualsize;

		// Token: 0x040001B8 RID: 440
		private int _textureID;

		// Token: 0x040001B9 RID: 441
		private Rectangle _BoundingRectangle;

		// Token: 0x040001BA RID: 442
		private bool _isSelected;

		// Token: 0x040001BB RID: 443
		private PointF[] GridVertices;
	}
}
