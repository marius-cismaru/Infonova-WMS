using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sirius.SiriusOnline
{
	public static class ToolMessage
	{
		public enum Kinds
		{
			INFO = 1,
			SUCCESS = 2,
			WARNING = 3,
			ERROR = 4
		}

		private static string GetKindIconPath(Kinds kind)
		{
			switch (kind)
			{
				case Kinds.INFO: return "Resources/icon_32x32_info.png";
				case Kinds.SUCCESS: return "Resources/icon_32x32_success.png";
				case Kinds.WARNING: return "Resources/icon_32x32_warning.png";
				case Kinds.ERROR: return "Resources/icon_32x32_error.png";
			}
			return "";
		}

		private static string GetKindDescription(Kinds kind)
		{
			switch (kind)
			{
				case Kinds.INFO: return "INFO";
				case Kinds.SUCCESS: return "SUCCESS";
				case Kinds.WARNING: return "WARNING";
				case Kinds.ERROR: return "ERROR";
			}
			return "";
		}

		public static string Render(Kinds kind, string text)
		{
			System.Text.StringBuilder sb = new System.Text.StringBuilder();
			sb.Append("\n<table style=\"border:1px solid black; font-family:arial, sans-serif; font-size:12px\" >");
			sb.Append("\n  <tr>");
			sb.Append("\n    <td rowspan=\"2\">");
			sb.Append("\n      <img src=\"" + GetKindIconPath(kind) + "\">");
			sb.Append("\n    </td>");
			sb.Append("\n    <td valign=\"bottom\">");
			sb.Append("\n      <b>" + GetKindDescription(kind) + "</b>");
			sb.Append("\n    </td>");
			sb.Append("\n  </tr>");
			sb.Append("\n  <tr>");
			sb.Append("\n    <td valign=\"top\">");
			sb.Append("\n      <i>" + text + "</i>");
			sb.Append("\n    </td>");
			sb.Append("\n  </tr>");
			sb.Append("\n</table>");
			sb.Append("\n<br />");
			return sb.ToString();
		}
	}
}
