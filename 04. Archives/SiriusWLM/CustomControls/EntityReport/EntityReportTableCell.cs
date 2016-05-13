using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sirius.CustomControls
{
	public class EntityReportTableCell: EntityReportElement
	{
		public string Text { get; set; }
		public string Align { get; set; }
		public bool IsTextBold { get; set; }
		public string BackgroundColor { get; set; }
		public string ForegroundColor { get; set; }

		public EntityReportTableCell()
		{
			Text = "";
			Align = "left";
			IsTextBold = false;
			BackgroundColor = "white";
			ForegroundColor = "black";
		}

		public EntityReportTableCell(string text)
		{
			Text = text;
			Align = "left";
			IsTextBold = false;
			BackgroundColor = "white";
			ForegroundColor = "black";
		}

		#region IReportElement Members

		public override string ToHTML()
		{
			return "\n    <td align=\"" + Align + "\" style=\"margin: 0; padding: 2px; border-color: black; border-width: 0 0 1px 1px; border-style: solid; background-color: " + BackgroundColor + "; color: " + ForegroundColor + "\">" + (IsTextBold ? "<b>" : "") + (Text != null ? (Text != "" ? Text.Replace(" ", "&nbsp;").Replace(Environment.NewLine, "<br />") : "&nbsp;") : "&nbsp;") + (IsTextBold ? "</b>" : "") + "</td>";
		}

		#endregion
	}
}
