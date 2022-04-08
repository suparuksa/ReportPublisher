using System;
using System.Collections.Generic;
using System.Text;

namespace ReportPublisher.Model
{
	public class ReportDatas : ModelBase
	{
		public int id { get; set; }
		public string report_name { get; set; }
		public string report_data { get; set; }

		public override object[] GetItemValue()
		{
			return new object[] {
				this.id,
				this.report_name,
				this.report_data
			};
		}
	}
}
