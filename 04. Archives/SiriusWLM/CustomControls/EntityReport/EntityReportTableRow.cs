using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sirius.CustomControls
{
	public class EntityReportTableRow: EntityReportElement
	{
		public List<EntityReportTableCell> Cells { get; set; }

		public EntityReportTableRow()
		{
			Cells = new List<EntityReportTableCell>();
		}

		public EntityReportTableRow(string[] cells) 
		{
			Cells = new List<EntityReportTableCell>();
			foreach (string cell in cells)
			{
				Cells.Add(new EntityReportTableCell(cell));
			}
		}

		public void AddCells(string[] cells)
		{
			foreach (string cell in cells)
			{
				Cells.Add(new EntityReportTableCell(cell));
			}
		}

		#region IEntityReportElement Members

		public override string ToHTML()
		{
			string result;
			result = "\n  <tr>";
			foreach (var cell in Cells)
			{
				cell.Report = this.Report;
				result += cell.ToHTML();
			}
			result += "\n  </tr>";
			return result;
		}

		#endregion
	}
}
