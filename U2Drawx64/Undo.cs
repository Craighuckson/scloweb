using System;
using System.Collections;
using System.Drawing;
using ComPeters;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace U2Drawx64
{
	// Token: 0x02000025 RID: 37
	public class Undo
	{
		// Token: 0x0600043A RID: 1082 RVA: 0x000AB750 File Offset: 0x000AA750
		public Undo()
		{
			this.drawObjects = new ArrayList();
		}

		// Token: 0x0600043B RID: 1083 RVA: 0x000AB764 File Offset: 0x000AA764
		public bool AddShape(IShape shape)
		{
			try
			{
				this.drawObjects.Add(shape);
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
			bool result;
			return result;
		}

		// Token: 0x0600043C RID: 1084 RVA: 0x000AB7A8 File Offset: 0x000AA7A8
		public bool DeleteShapes()
		{
			try
			{
				try
				{
					foreach (object obj in this.drawObjects)
					{
						IShape shape = (IShape)obj;
						GlobalVariables.Canvas.Remove(shape);
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
			}
			catch (Exception ex)
			{
				ComPetersError.DisplayError(ex);
			}
			bool result;
			return result;
		}

		// Token: 0x0600043D RID: 1085 RVA: 0x000AB82C File Offset: 0x000AA82C
		public bool Undo()
		{
			checked
			{
				bool result;
				try
				{
					switch (this.operationType)
					{
					case GlobalVariables.DrawMode.DrawLines:
					case GlobalVariables.DrawMode.DrawPencil:
					case GlobalVariables.DrawMode.DrawAngledLines:
					case GlobalVariables.DrawMode.DrawText:
					case GlobalVariables.DrawMode.DrawRectangle:
					case GlobalVariables.DrawMode.DrawEllipse:
					case GlobalVariables.DrawMode.DrawTriangle:
					case GlobalVariables.DrawMode.DrawMeasureLines:
					case GlobalVariables.DrawMode.DrawSymbol:
					case GlobalVariables.DrawMode.DrawArrow:
					case GlobalVariables.DrawMode.DrawNorthSign:
					case GlobalVariables.DrawMode.DrawArc:
					case GlobalVariables.DrawMode.InsertText:
					case GlobalVariables.DrawMode.InsertStamp:
					case GlobalVariables.DrawMode.InsertTemplate:
						try
						{
							foreach (object obj in this.drawObjects)
							{
								IShape shape = (IShape)obj;
								if (shape != null)
								{
									GlobalVariables.Canvas.Remove(shape);
								}
							}
							return result;
						}
						finally
						{
							IEnumerator enumerator;
							if (enumerator is IDisposable)
							{
								(enumerator as IDisposable).Dispose();
							}
						}
						break;
					case GlobalVariables.DrawMode.Undo:
					case GlobalVariables.DrawMode.InsertSymbol:
						goto IL_1EC;
					case GlobalVariables.DrawMode.Move:
						break;
					case GlobalVariables.DrawMode.Rotate:
						goto IL_172;
					case GlobalVariables.DrawMode.Delete:
						goto IL_126;
					default:
						goto IL_1EC;
					}
					try
					{
						foreach (object obj2 in this.drawObjects)
						{
							IShape shape2 = (IShape)obj2;
							shape2.Move((int)Math.Round(unchecked(this.oldX - this.newX)), (int)Math.Round(unchecked(this.oldY - this.newY)));
						}
						return result;
					}
					finally
					{
						IEnumerator enumerator2;
						if (enumerator2 is IDisposable)
						{
							(enumerator2 as IDisposable).Dispose();
						}
					}
					try
					{
						IL_126:
						foreach (object obj3 in this.drawObjects)
						{
							IShape shape3 = (IShape)obj3;
							shape3.Visible = true;
						}
						return result;
					}
					finally
					{
						IEnumerator enumerator3;
						if (enumerator3 is IDisposable)
						{
							(enumerator3 as IDisposable).Dispose();
						}
					}
					try
					{
						IL_172:
						foreach (object obj4 in this.drawObjects)
						{
							IShape shape4 = (IShape)obj4;
							IShape shape5 = shape4;
							double radians = unchecked(this.newAngle - this.oldAngle);
							Point p = new Point((int)Math.Round(this.RotateCentreX), (int)Math.Round(this.RotateCentreY));
							shape5.Rotate(radians, p);
						}
						return result;
					}
					finally
					{
						IEnumerator enumerator4;
						if (enumerator4 is IDisposable)
						{
							(enumerator4 as IDisposable).Dispose();
						}
					}
					IL_1EC:
					Interaction.MsgBox("unsupported undo operation " + Conversions.ToString((int)this.operationType), MsgBoxStyle.OkOnly, null);
				}
				catch (Exception ex)
				{
					ComPetersError.DisplayError(ex);
				}
				return result;
			}
		}

		// Token: 0x040001D7 RID: 471
		public GlobalVariables.DrawMode operationType;

		// Token: 0x040001D8 RID: 472
		public double oldX;

		// Token: 0x040001D9 RID: 473
		public double oldY;

		// Token: 0x040001DA RID: 474
		public double newX;

		// Token: 0x040001DB RID: 475
		public double newY;

		// Token: 0x040001DC RID: 476
		public double RotateCentreX;

		// Token: 0x040001DD RID: 477
		public double RotateCentreY;

		// Token: 0x040001DE RID: 478
		public double oldAngle;

		// Token: 0x040001DF RID: 479
		public double newAngle;

		// Token: 0x040001E0 RID: 480
		private ArrayList drawObjects;
	}
}
