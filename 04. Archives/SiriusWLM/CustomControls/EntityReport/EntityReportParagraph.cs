using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sirius.CustomControls
{
	public class EntityReportParagraph: EntityReportElement
	{
		public string Text { get; set; }

		public EntityReportParagraph()
		{
			Text = "";
		}

		public EntityReportParagraph(string text)
		{
			Text = text;
		}

		#region IReportElement Members

		public override string ToHTML()
		{
			return "<br /><br />" + Text.Replace("\n", "<br />");
		}

		#endregion
	}
}
