using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Sirius.CustomControls
{
	public class EntityReport
	{
		public string Title { get; set; }

		public string Description { get; set; }

		public List<EntityReportElement> Items { get; set; }

		public EntityReport()
		{
			Title = "";
			Description = "";
			Items = new List<EntityReportElement>();
		}

		public EntityReport(string title, string description)
		{
			Title = title;
			Description = description;
			Items = new List<EntityReportElement>();
		}

		public void AddElement(EntityReportElement element)
		{
			Items.Add(element);
		}

		public string ToCSV()
		{
			string result = "";
			List<string> strings;
			foreach (EntityReportElement item in Items)
			{
				if (item is EntityReportTable)
				{
					EntityReportTable table = item as EntityReportTable;
					strings = new List<string>();
					if (table.Header != null)
					{
						foreach (EntityReportTableCell cell in table.Header.Cells)
						{
							strings.Add("\"" + cell.Text + "\"");
						}
						result += string.Join(";", strings.ToArray()) + Environment.NewLine;
					}
					foreach (EntityReportTableRow row in table.Rows)
					{
						strings.Clear();
						foreach (EntityReportTableCell cell in row.Cells)
						{
							strings.Add("\"" + cell.Text + "\"");
						}
						result += string.Join(";", strings.ToArray()) + Environment.NewLine;
					}
					if (table.Footer != null)
					{
						strings.Clear();
						foreach (EntityReportTableCell cell in table.Footer.Cells)
						{
							strings.Add("\"" + cell.Text + "\"");
						}
						result += string.Join(";", strings.ToArray()) + Environment.NewLine;
					}
					result += Environment.NewLine;
				}
			}
			return result;
		}

		/*public void ToCSVWebResponse(System.Web.HttpResponse response)
		{
			string fileName = "SmartDiesel_" + System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(Title.ToLower()).Replace(" ", "") + ".csv";
			response.ClearContent();
			response.AddHeader("content-disposition", "attachment; filename=" + fileName);
			response.ContentType = "application/CSV";
			char[] content = ToCSV().ToCharArray();
			response.Write(content, 0, content.Length);
			response.End();
		}*/

		public string ToHTML()
		{
			string result = "";
			result += "<b>" + Title + "</b>";
			result += "<br />" + Description.Replace(Environment.NewLine, "<br />");
			foreach (var item in Items)
			{
				item.Report = this;
				result += item.ToHTML();
			}
			return result;
		}
	}
}
