using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sirius.CustomControls
{
	public class EntityReportElement: IEntityReportElement
	{
		public EntityReport Report { get; set; }

		#region IEntityReportElement Members

		public virtual string ToHTML()
		{
			return "";
		}

		#endregion
	}
}
