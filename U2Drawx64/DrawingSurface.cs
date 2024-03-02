using System;
using System.Collections;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ComPeters;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using U2Drawx64.My;

namespace U2Drawx64
{
	// Token: 0x02000009 RID: 9
	public class DrawingSurface
	{
		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000025 RID: 37 RVA: 0x0009B018 File Offset: 0x0009A018
		public int Width
		{
			get
			{
				return this.Control.Size.Width;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000026 RID: 38 RVA: 0x0009B038 File Offset: 0x0009A038
		public int Height
		{
			get
			{
				return this.Control.Size.Height;
			}
		}

		// Token: 0x06000027 RID: 39 RVA: 0x0009B058 File Offset: 0x0009A058
		public DrawingSurface(GLControl GLControl)
		{
			this.Shapes = new IShape[0];
			this.TextIDs = new long[0];
			this.SelectedShapes = new IShape[0];
			this.GridOn = false;
			this.drawingissaving = false;
			this.Control = GLControl;
		}

		// Token: 0x06000028 RID: 40 RVA: 0x0009B0A4 File Offset: 0x0009A0A4
		public void Add(IShape Shape)
		{
			try
			{
				long num = (long)this.Shapes.Length;
				checked
				{
					this.Shapes = (IShape[])Utils.CopyArray((Array)this.Shapes, new IShape[(int)num + 1]);
					Shape.ShapeID = num;
					this.Shapes[(int)num] = Shape;
					if (Shape.ShapeType == GlobalVariables.ShapeType.Text)
					{
						this.AddText((Text)Shape);
					}
				}
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x06000029 RID: 41 RVA: 0x0009B12C File Offset: 0x0009A12C
		private void AddText(Text thisText)
		{
			try
			{
				long num = (long)this.TextIDs.Length;
				checked
				{
					this.TextIDs = (long[])Utils.CopyArray((Array)this.TextIDs, new long[(int)num + 1]);
					this.TextIDs[(int)num] = thisText.ShapeID;
				}
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x0600002A RID: 42 RVA: 0x0009B19C File Offset: 0x0009A19C
		private void RemoveText(Text thisText)
		{
			try
			{
				long num = 0L;
				long num2 = (long)(checked(this.TextIDs.Length - 1));
				checked
				{
					for (long num3 = num; num3 <= num2; num3 += 1L)
					{
						if (this.TextIDs[(int)num3] == thisText.ShapeID)
						{
							this.TextIDs[(int)num3] = 0L;
						}
					}
				}
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x0600002B RID: 43 RVA: 0x0009B208 File Offset: 0x0009A208
		private void ChangeTextID(long oldID, long newID)
		{
			try
			{
				long num = 0L;
				long num2 = (long)(checked(this.TextIDs.Length - 1));
				checked
				{
					for (long num3 = num; num3 <= num2; num3 += 1L)
					{
						if (this.TextIDs[(int)num3] == oldID)
						{
							this.TextIDs[(int)num3] = newID;
						}
					}
				}
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x0600002C RID: 44 RVA: 0x0009B26C File Offset: 0x0009A26C
		public void Remove(IShape Shape)
		{
			try
			{
				long shapeID = Shape.ShapeID;
				if (shapeID < (long)this.Shapes.Length)
				{
					if (shapeID != (long)(checked(this.Shapes.Length - 1)))
					{
						long num = shapeID;
						long num2 = (long)(checked(this.Shapes.Length - 2));
						checked
						{
							for (long num3 = num; num3 <= num2; num3 += 1L)
							{
								this.Shapes[(int)num3] = this.Shapes[(int)(num3 + 1L)];
								if (this.Shapes[(int)num3].ShapeType == GlobalVariables.ShapeType.Text)
								{
									this.ChangeTextID(this.Shapes[(int)num3].ShapeID, num3);
								}
								this.Shapes[(int)num3].ShapeID = num3;
							}
						}
					}
					this.Shapes = (IShape[])Utils.CopyArray((Array)this.Shapes, new IShape[checked(this.Shapes.Length - 2 + 1)]);
				}
				if (Shape.ShapeType == GlobalVariables.ShapeType.Text)
				{
					this.RemoveText((Text)Shape);
				}
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x0600002D RID: 45 RVA: 0x0009B368 File Offset: 0x0009A368
		public void AddShapeToSelection(IShape shape)
		{
			try
			{
				long num = (long)this.SelectedShapes.Length;
				checked
				{
					this.SelectedShapes = (IShape[])Utils.CopyArray((Array)this.SelectedShapes, new IShape[(int)num + 1]);
					this.SelectedShapes[(int)num] = shape;
				}
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x0600002E RID: 46 RVA: 0x0009B3D4 File Offset: 0x0009A3D4
		public void RemoveShapeFromSelection(IShape shape)
		{
			checked
			{
				try
				{
					long num = 0L;
					foreach (IShape shape2 in this.SelectedShapes)
					{
						if (shape2.ShapeID == shape.ShapeID)
						{
							long num2 = num;
							long num3 = unchecked((long)(checked(this.SelectedShapes.Length - 2)));
							for (long num4 = num2; num4 <= num3; num4 += 1L)
							{
								this.SelectedShapes[(int)num4] = this.SelectedShapes[(int)(num4 + 1L)];
							}
							this.SelectedShapes = (IShape[])Utils.CopyArray((Array)this.SelectedShapes, new IShape[this.SelectedShapes.Length - 2 + 1]);
						}
						num += 1L;
					}
				}
				catch (Exception ex)
				{
					ComPetersError.DisplayError(ex);
				}
			}
		}

		// Token: 0x0600002F RID: 47 RVA: 0x0009B4A0 File Offset: 0x0009A4A0
		public void Draw(double X, double Y)
		{
			checked
			{
				try
				{
					GL.Clear(ClearBufferMask.DepthBufferBit | ClearBufferMask.ColorBufferBit);
					GL.MatrixMode(MatrixMode.Modelview);
					GL.LoadIdentity();
					GL.Enable(EnableCap.Blend);
					GL.BlendFunc(BlendingFactorSrc.One, BlendingFactorDest.OneMinusSrcAlpha);
					GL.Enable(EnableCap.LineSmooth);
					GL.Disable(EnableCap.DepthTest);
					foreach (long num in this.TextIDs)
					{
						if (num != 0L && this.Shapes[(int)num].Visible)
						{
							this.Shapes[(int)num].Draw();
						}
					}
					if (this.Shapes.Length != 0)
					{
						foreach (IShape shape in this.Shapes)
						{
							if (shape.Visible & shape.ShapeType != GlobalVariables.ShapeType.Text)
							{
								shape.Draw();
							}
						}
					}
					if (!this.drawingissaving)
					{
						this.DrawAlignmentLines(X, Y);
					}
					this.Control.SwapBuffers();
				}
				catch (Exception ex)
				{
					ComPetersError.DisplayError(ex);
				}
			}
		}

		// Token: 0x06000030 RID: 48 RVA: 0x0009B5B8 File Offset: 0x0009A5B8
		public void Draw()
		{
			this.Draw(0.0, 0.0);
		}

		// Token: 0x06000031 RID: 49 RVA: 0x0009B5D4 File Offset: 0x0009A5D4
		private void DrawAlignmentLines(double X, double Y)
		{
			try
			{
				GL.Color3(Color.Black);
				GL.LineWidth(0.5f);
				GL.Begin(BeginMode.Lines);
				GL.Vertex2(X, 0.0);
				GL.Vertex2(X, (double)GlobalVariables.Canvas.Height);
				GL.End();
				GL.Begin(BeginMode.Lines);
				GL.Vertex2(0.0, Y);
				GL.Vertex2((double)GlobalVariables.Canvas.Width, Y);
				GL.End();
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x06000032 RID: 50 RVA: 0x0009B674 File Offset: 0x0009A674
		public IShape SelectShapeWithPixel(PointF pixel)
		{
			checked
			{
				IShape result;
				try
				{
					for (int i = this.Shapes.Length - 1; i >= 0; i += -1)
					{
						if (this.Shapes[i].canSelect && this.Shapes[i].isInSelection(pixel))
						{
							return this.Shapes[i];
						}
					}
					result = null;
				}
				catch (Exception ex)
				{
					ComPetersError.DisplayError(ex);
					result = null;
				}
				return result;
			}
		}

		// Token: 0x06000033 RID: 51 RVA: 0x0009B6EC File Offset: 0x0009A6EC
		public void SelectShapesWithBox(PointF First, PointF Last)
		{
			try
			{
				if (this.Shapes.Length != 0)
				{
					foreach (IShape shape in this.Shapes)
					{
						if (shape.isInSelection(First, Last))
						{
							shape.SelectThis();
						}
					}
				}
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x06000034 RID: 52 RVA: 0x0009B754 File Offset: 0x0009A754
		public void Clear()
		{
			try
			{
				this.Shapes = new IShape[0];
				this.SelectedShapes = new IShape[0];
				this.TextIDs = new long[0];
				this.Grid = new Grid();
				this.Grid.Visible = this.GridOn;
				GlobalVariables.Canvas.Add(this.Grid);
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x06000035 RID: 53 RVA: 0x0009B7D8 File Offset: 0x0009A7D8
		public void DeselectAll()
		{
			try
			{
				if (this.SelectedShapes.Length != 0)
				{
					foreach (IShape shape in this.SelectedShapes)
					{
						shape.Unselect();
					}
					this.SelectedShapes = new IShape[0];
				}
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x06000036 RID: 54 RVA: 0x0009B844 File Offset: 0x0009A844
		public void DeleteSelected()
		{
			try
			{
				Undo undo = new Undo();
				foreach (IShape shape in this.SelectedShapes)
				{
					shape.Visible = false;
					shape.Unselect();
					undo.AddShape(shape);
				}
				this.DeselectAll();
				undo.operationType = GlobalVariables.DrawMode.Delete;
				GlobalVariables.UndoStack.Push(undo);
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x06000037 RID: 55 RVA: 0x0009B8C8 File Offset: 0x0009A8C8
		public void MoveSelected(int AddToX, int AddToY)
		{
			try
			{
				if (this.SelectedShapes.Length != 0)
				{
					foreach (IShape shape in this.SelectedShapes)
					{
						shape.Move(AddToX, AddToY);
					}
				}
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x06000038 RID: 56 RVA: 0x0009B928 File Offset: 0x0009A928
		public void ResizeSelected(int AddToX, int AddToY)
		{
			try
			{
				if (this.SelectedShapes.Length != 0)
				{
					foreach (IShape shape in this.SelectedShapes)
					{
						shape.Resize((double)AddToX, (double)AddToY);
					}
				}
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
		}

		// Token: 0x06000039 RID: 57 RVA: 0x0009B98C File Offset: 0x0009A98C
		public void SaveTemplateToDatabase(ref string sTemplateName)
		{
			GlobalVariables.drawingDatabaseConnection.Open();
			SQLiteTransaction sqliteTransaction = GlobalVariables.drawingDatabaseConnection.BeginTransaction();
			try
			{
				SQLiteCommand sqliteCommand = new SQLiteCommand();
				sqliteCommand.CommandText = "Insert into tbDrawing_Templates (Name) values (@Name)";
				sqliteCommand.Connection = GlobalVariables.drawingDatabaseConnection;
				sqliteCommand.Transaction = sqliteTransaction;
				sqliteCommand.Parameters.AddWithValue("@Name", sTemplateName);
				sqliteCommand.ExecuteNonQuery();
				SQLiteCommand sqliteCommand2 = new SQLiteCommand("Select last_insert_rowid() as rowid", GlobalVariables.drawingDatabaseConnection, sqliteTransaction);
				long templateID = Conversions.ToLong(sqliteCommand2.ExecuteScalar());
				foreach (IShape shape in GlobalVariables.Canvas.Shapes)
				{
					if (shape.Visible)
					{
						shape.SaveToTemplate(GlobalVariables.drawingDatabaseConnection, sqliteTransaction, templateID, Application.StartupPath + Config.GetOption(Config.Setting.DBDrawingDatabase));
					}
				}
				sqliteTransaction.Commit();
				GlobalVariables.drawingDatabaseConnection.Close();
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
				sqliteTransaction.Rollback();
			}
			finally
			{
				GlobalVariables.drawingDatabaseConnection.Close();
			}
		}

		// Token: 0x0600003A RID: 58 RVA: 0x0009BAAC File Offset: 0x0009AAAC
		public void SaveNativeFile(string filepath)
		{
			SQLiteConnection sqliteConnection = new SQLiteConnection(MyProject.Forms.frmDrawing.ConnectionString);
			sqliteConnection.Open();
			SQLiteTransaction sqliteTransaction = sqliteConnection.BeginTransaction();
			try
			{
				File.Copy(Application.StartupPath + "/Drawings/emptyDrawing.db", filepath, true);
				SQLiteCommand sqliteCommand = new SQLiteCommand();
				sqliteCommand.CommandText = "Insert into tbDrawinsg_Templates (Name) values (@Name)";
				sqliteCommand.Connection = GlobalVariables.drawingDatabaseConnection;
				sqliteCommand.Transaction = sqliteTransaction;
				sqliteCommand.Parameters.AddWithValue("@Name", "Drawing");
				sqliteCommand.ExecuteNonQuery();
				SQLiteCommand sqliteCommand2 = new SQLiteCommand("Select last_insert_rowid() as rowid", GlobalVariables.drawingDatabaseConnection, sqliteTransaction);
				long templateID = Conversions.ToLong(sqliteCommand2.ExecuteScalar());
				foreach (IShape shape in GlobalVariables.Canvas.Shapes)
				{
					if (shape.Visible)
					{
						shape.SaveToTemplate(sqliteConnection, sqliteTransaction, templateID, filepath);
					}
				}
				sqliteTransaction.Commit();
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
				sqliteTransaction.Rollback();
			}
			finally
			{
				sqliteConnection.Close();
			}
		}

		// Token: 0x0600003B RID: 59 RVA: 0x0009BBD4 File Offset: 0x0009ABD4
		public void LoadTemplatefromDatabase(long TemplateID)
		{
			SQLiteConnection sqliteConnection = new SQLiteConnection(MyProject.Forms.frmDrawing.ConnectionString);
			try
			{
				Undo undo = new Undo();
				undo.operationType = GlobalVariables.DrawMode.InsertTemplate;
				GlobalVariables.Canvas.DeselectAll();
				GlobalVariables.userMode = GlobalVariables.DrawMode.SelectTool;
				sqliteConnection.Open();
				SQLiteDataAdapter sqliteDataAdapter = new SQLiteDataAdapter("Select tbDrawing_TemplateShapes.ShapeIndex,ParentTemplate,ShapeType,Colour,Size,PenStyle,DisplayText,Angle,ID,XCoord,YCoord from tbDrawing_TemplateShapes inner join tbDrawing_TemplateShapeCoords on tbDrawing_TemplateShapeCoords.ShapeIndex =  tbDrawing_TemplateShapes.ShapeIndex where ParentTemplate= " + Conversions.ToString(TemplateID) + " order by ID", sqliteConnection);
				DataTable dataTable = new DataTable();
				sqliteDataAdapter.Fill(dataTable);
				sqliteConnection.Close();
				long num = 0L;
				DataTable dataTable2 = new DataTable();
				dataTable2.Columns.Add("ShapeIndex");
				dataTable2.Columns.Add("ParentTemplate");
				dataTable2.Columns.Add("ShapeType");
				dataTable2.Columns.Add("Colour");
				dataTable2.Columns.Add("Size");
				dataTable2.Columns.Add("PenStyle");
				dataTable2.Columns.Add("DisplayText");
				dataTable2.Columns.Add("Angle");
				dataTable2.Columns.Add("ID");
				dataTable2.Columns.Add("XCoord");
				dataTable2.Columns.Add("YCoord");
				DataRow dataRow = null;
				try
				{
					foreach (object obj in dataTable.Rows)
					{
						DataRow dataRow2 = (DataRow)obj;
						long num2 = Conversions.ToLong(dataRow2["ShapeIndex"]);
						if (num2 != num)
						{
							if (num != 0L)
							{
								if (!Information.IsNothing(dataRow))
								{
									if (Operators.ConditionalCompareObjectEqual(dataRow["ShapeType"], "arc", false))
									{
										Arc arc = new Arc();
										arc.Load(dataTable2, undo, "");
									}
									else if (Operators.ConditionalCompareObjectEqual(dataRow["ShapeType"], "line", false))
									{
										Line line = new Line();
										line.Load(dataTable2, undo, "");
									}
									else if (Operators.ConditionalCompareObjectEqual(dataRow["ShapeType"], "rectangle", false))
									{
										Rectangle rectangle = new Rectangle();
										rectangle.Load(dataTable2, undo, "");
									}
									else if (Operators.ConditionalCompareObjectEqual(dataRow["ShapeType"], "text", false))
									{
										Text text = new Text();
										text.Load(dataTable2, undo, "");
									}
									else if (Operators.ConditionalCompareObjectEqual(dataRow["ShapeType"], "triangle", false))
									{
										Triangle triangle = new Triangle();
										triangle.Load(dataTable2, undo, "");
									}
									else if (Operators.ConditionalCompareObjectEqual(dataRow["ShapeType"], "ellipse", false))
									{
										Ellipse ellipse = new Ellipse();
										ellipse.Load(dataTable2, undo, "");
									}
									else if (Operators.ConditionalCompareObjectEqual(dataRow["ShapeType"], "stamp", false))
									{
										Stamp stamp = new Stamp();
										stamp.Load(dataTable2, undo, "");
									}
								}
								num = num2;
								dataTable2.Clear();
							}
							else
							{
								num = num2;
							}
						}
						dataRow = dataTable2.NewRow();
						try
						{
							foreach (object obj2 in dataTable.Columns)
							{
								DataColumn dataColumn = (DataColumn)obj2;
								dataRow[dataColumn.ColumnName] = RuntimeHelpers.GetObjectValue(dataRow2[dataColumn.ColumnName]);
							}
						}
						finally
						{
							IEnumerator enumerator2;
							if (enumerator2 is IDisposable)
							{
								(enumerator2 as IDisposable).Dispose();
							}
						}
						dataTable2.Rows.Add(dataRow);
					}
				}
				finally
				{
					IEnumerator enumerator;
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				if (!Information.IsNothing(dataRow))
				{
					if (Operators.ConditionalCompareObjectEqual(dataRow["ShapeType"], "arc", false))
					{
						Arc arc2 = new Arc();
						arc2.Load(dataTable2, undo, "");
					}
					else if (Operators.ConditionalCompareObjectEqual(dataRow["ShapeType"], "line", false))
					{
						Line line2 = new Line();
						line2.Load(dataTable2, undo, "");
					}
					else if (Operators.ConditionalCompareObjectEqual(dataRow["ShapeType"], "rectangle", false))
					{
						Rectangle rectangle2 = new Rectangle();
						rectangle2.Load(dataTable2, undo, "");
					}
					else if (Operators.ConditionalCompareObjectEqual(dataRow["ShapeType"], "text", false))
					{
						Text text2 = new Text();
						text2.Load(dataTable2, undo, "");
					}
					else if (Operators.ConditionalCompareObjectEqual(dataRow["ShapeType"], "triangle", false))
					{
						Triangle triangle2 = new Triangle();
						triangle2.Load(dataTable2, undo, "");
					}
					else if (Operators.ConditionalCompareObjectEqual(dataRow["ShapeType"], "ellipse", false))
					{
						Ellipse ellipse2 = new Ellipse();
						ellipse2.Load(dataTable2, undo, "");
					}
					else if (Operators.ConditionalCompareObjectEqual(dataRow["ShapeType"], "stamp", false))
					{
						Stamp stamp2 = new Stamp();
						stamp2.Load(dataTable2, undo, "");
					}
				}
				GlobalVariables.SavableChanges = true;
				GlobalVariables.UndoStack.Push(undo);
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
			finally
			{
				sqliteConnection.Close();
			}
		}

		// Token: 0x0600003C RID: 60 RVA: 0x0009C170 File Offset: 0x0009B170
		public void LoadNativeFile(string filepath)
		{
			SQLiteConnection sqliteConnection = new SQLiteConnection(MyProject.Forms.frmDrawing.ConnectionString);
			try
			{
				if (File.Exists(filepath))
				{
					sqliteConnection.Open();
					Undo undo = new Undo();
					undo.operationType = GlobalVariables.DrawMode.InsertTemplate;
					GlobalVariables.Canvas.DeselectAll();
					GlobalVariables.userMode = GlobalVariables.DrawMode.SelectTool;
					SQLiteDataAdapter sqliteDataAdapter = new SQLiteDataAdapter("Select tbDrawing_TemplateShapes.ShapeIndex,ParentTemplate,ShapeType,Colour,Size,PenStyle,DisplayText,Angle,ID,XCoord,YCoord from tbDrawing_TemplateShapes inner join tbDrawing_TemplateShapeCoords on tbDrawing_TemplateShapeCoords.ShapeIndex =  tbDrawing_TemplateShapes.ShapeIndex order by ID", sqliteConnection);
					DataTable dataTable = new DataTable();
					sqliteDataAdapter.Fill(dataTable);
					long num = 0L;
					DataTable dataTable2 = new DataTable();
					dataTable2.Columns.Add("ShapeIndex");
					dataTable2.Columns.Add("ParentTemplate");
					dataTable2.Columns.Add("ShapeType");
					dataTable2.Columns.Add("Colour");
					dataTable2.Columns.Add("Size");
					dataTable2.Columns.Add("PenStyle");
					dataTable2.Columns.Add("DisplayText");
					dataTable2.Columns.Add("Angle");
					dataTable2.Columns.Add("ID");
					dataTable2.Columns.Add("XCoord");
					dataTable2.Columns.Add("YCoord");
					DataRow dataRow = null;
					try
					{
						foreach (object obj in dataTable.Rows)
						{
							DataRow dataRow2 = (DataRow)obj;
							long num2 = Conversions.ToLong(dataRow2["ShapeIndex"]);
							if (num2 != num)
							{
								if (num != 0L)
								{
									if (!Information.IsNothing(dataRow))
									{
										if (Operators.ConditionalCompareObjectEqual(dataRow["ShapeType"], "arc", false))
										{
											Arc arc = new Arc();
											arc.Load(dataTable2, undo, "");
										}
										else if (Operators.ConditionalCompareObjectEqual(dataRow["ShapeType"], "line", false))
										{
											Line line = new Line();
											line.Load(dataTable2, undo, "");
										}
										else if (Operators.ConditionalCompareObjectEqual(dataRow["ShapeType"], "rectangle", false))
										{
											Rectangle rectangle = new Rectangle();
											rectangle.Load(dataTable2, undo, "");
										}
										else if (Operators.ConditionalCompareObjectEqual(dataRow["ShapeType"], "text", false))
										{
											Text text = new Text();
											text.Load(dataTable2, undo, "");
										}
										else if (Operators.ConditionalCompareObjectEqual(dataRow["ShapeType"], "triangle", false))
										{
											Triangle triangle = new Triangle();
											triangle.Load(dataTable2, undo, "");
										}
										else if (Operators.ConditionalCompareObjectEqual(dataRow["ShapeType"], "ellipse", false))
										{
											Ellipse ellipse = new Ellipse();
											ellipse.Load(dataTable2, undo, "");
										}
										else if (Operators.ConditionalCompareObjectEqual(dataRow["ShapeType"], "stamp", false))
										{
											Stamp stamp = new Stamp();
											stamp.Load(dataTable2, undo, filepath);
										}
									}
									num = num2;
									dataTable2.Clear();
								}
								else
								{
									num = num2;
								}
							}
							dataRow = dataTable2.NewRow();
							try
							{
								foreach (object obj2 in dataTable.Columns)
								{
									DataColumn dataColumn = (DataColumn)obj2;
									dataRow[dataColumn.ColumnName] = RuntimeHelpers.GetObjectValue(dataRow2[dataColumn.ColumnName]);
								}
							}
							finally
							{
								IEnumerator enumerator2;
								if (enumerator2 is IDisposable)
								{
									(enumerator2 as IDisposable).Dispose();
								}
							}
							dataTable2.Rows.Add(dataRow);
						}
					}
					finally
					{
						IEnumerator enumerator;
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
					}
					if (!Information.IsNothing(dataRow))
					{
						if (Operators.ConditionalCompareObjectEqual(dataRow["ShapeType"], "arc", false))
						{
							Arc arc2 = new Arc();
							arc2.Load(dataTable2, undo, "");
						}
						else if (Operators.ConditionalCompareObjectEqual(dataRow["ShapeType"], "line", false))
						{
							Line line2 = new Line();
							line2.Load(dataTable2, undo, "");
						}
						else if (Operators.ConditionalCompareObjectEqual(dataRow["ShapeType"], "rectangle", false))
						{
							Rectangle rectangle2 = new Rectangle();
							rectangle2.Load(dataTable2, undo, "");
						}
						else if (Operators.ConditionalCompareObjectEqual(dataRow["ShapeType"], "text", false))
						{
							Text text2 = new Text();
							text2.Load(dataTable2, undo, "");
						}
						else if (Operators.ConditionalCompareObjectEqual(dataRow["ShapeType"], "triangle", false))
						{
							Triangle triangle2 = new Triangle();
							triangle2.Load(dataTable2, undo, "");
						}
						else if (Operators.ConditionalCompareObjectEqual(dataRow["ShapeType"], "ellipse", false))
						{
							Ellipse ellipse2 = new Ellipse();
							ellipse2.Load(dataTable2, undo, "");
						}
						else if (Operators.ConditionalCompareObjectEqual(dataRow["ShapeType"], "stamp", false))
						{
							Stamp stamp2 = new Stamp();
							stamp2.Load(dataTable2, undo, filepath);
						}
					}
					GlobalVariables.SavableChanges = true;
					GlobalVariables.UndoStack.Push(undo);
				}
				this.DeselectAll();
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
			finally
			{
				sqliteConnection.Close();
			}
		}

		// Token: 0x0400000E RID: 14
		private GLControl Control;

		// Token: 0x0400000F RID: 15
		private IShape[] Shapes;

		// Token: 0x04000010 RID: 16
		private long[] TextIDs;

		// Token: 0x04000011 RID: 17
		public IShape[] SelectedShapes;

		// Token: 0x04000012 RID: 18
		private Size _size;

		// Token: 0x04000013 RID: 19
		public Grid Grid;

		// Token: 0x04000014 RID: 20
		public bool GridOn;

		// Token: 0x04000015 RID: 21
		public bool drawingissaving;
	}
}
