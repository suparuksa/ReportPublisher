using System;
using System.Collections.Generic;
using System.Text;

namespace dotNetFastReport.Model
{
	public class mots_dat_invoice
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

	}
}
