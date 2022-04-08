using System;
using System.Collections.Generic;
using System.Text;

namespace dotNetFastReport.Model
{
	public class MotsInvoice :ModelBase
	{
		public string invoice_no { get; set; }
		public string invoice_date { get; set; }
		public string ref1 { get; set; }
		public string ref2 { get; set; }
		public string due_date { get; set; }
		public string airline_company { get; set; }
		public string airline_branch { get; set; }
		public string airline_taxid { get; set; }
		public string airline_telno { get; set; }
		public string airline_address { get; set; }
		public string detail_item { get; set; }
		public string detail_item_price { get; set; }
		public string detail_total_baht { get; set; }
		public string detail_total_price { get; set; }

		public override object[] GetItemValue()
		{
			return new object[] {
				this.invoice_no,
				this.invoice_date,
				this.ref1,
				this.ref2,
				this.due_date,
				this.airline_company,
				this.airline_branch,
				this.airline_taxid,
				this.airline_telno,
				this.airline_address,
				this.detail_item,
				this.detail_item_price,
				this.detail_total_baht,
				this.detail_total_price
			};
		}

	}
}
