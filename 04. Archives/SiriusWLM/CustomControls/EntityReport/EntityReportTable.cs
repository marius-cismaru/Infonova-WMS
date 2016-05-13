using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sirius.CustomControls
{
	public class EntityReportTable: EntityReportElement
	{
		public EntityReportTableRow Header { get; set; }

		public EntityReportTableRow Footer { get; set; }

		public List<EntityReportTableRow> Rows { get; set; }

		public List<string> ColumnAlignments { get; set; }

		public string Description { get; set; }
		
		public EntityReportTable()
		{
			Header = new EntityReportTableRow();
			Footer = new EntityReportTableRow();
			Rows = new List<EntityReportTableRow>();
			ColumnAlignments = new List<string>();
			Description = string.Empty;
		}

		public void AddColumnAlignments(string[] alignments)
		{
			ColumnAlignments.Clear();
			foreach (var align in alignments)
			{
				ColumnAlignments.Add(align);
			}
		}

		private void PrepareTable()
		{
			foreach (var cell in Header.Cells)
			{
				cell.IsTextBold = true;
				cell.Align = "center";
				cell.BackgroundColor = "#555555";
				cell.ForegroundColor = "white";
			}
			foreach (var cell in Footer.Cells)
			{
				cell.IsTextBold = true;
				cell.BackgroundColor = "#555555";
				cell.ForegroundColor = "white";
			}
			if (ColumnAlignments.Count > 0)
			{
				if (ColumnAlignments.Count >= Footer.Cells.Count)
				{
					for (int i = 0; i < Footer.Cells.Count; i++)
					{
						Footer.Cells[i].Align = ColumnAlignments[i];
					}
				}
				foreach (var row in Rows)
				{
					if (ColumnAlignments.Count >= row.Cells.Count)
					{
						for (int i = 0; i < row.Cells.Count; i++)
						{
							row.Cells[i].Align = ColumnAlignments[i];
							//row.Cells[i].IsTextBold = false;
						}
					}
				}
			}
		}

		#region IEntityReportElement Members

		public override string ToHTML()
		{
			string result;
			PrepareTable();
			result = "\n<br /><br />";
			result += Description != string.Empty ? ("\n<b>" + Description + "</b>") : "";
			result+= "\n<table style=\"border: 1px solid black; border-spacing: 0; border-collapse: collapse; font-family: arial, sans-serif; font-size: 13px\">";
			result += Header.ToHTML();
			foreach (var row in Rows)
			{
				row.Report = this.Report;
				result += row.ToHTML();
			}
			result += Footer.ToHTML();
			result += "\n</table>";
			return result;
		}

		#endregion
	}
}
