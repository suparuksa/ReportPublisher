using System;
using System.Collections.Generic;
using System.Text;

namespace dotNetFastReport.Model
{
	public class mots_dat_invoice
	{
		public string mots_invoice_invoice_no { get; set; }
		public DateTime mots_invoice_invoice_date { get; set; }
		public string mots_invoice_ref1 { get; set; }
		public string mots_invoice_ref2 { get; set; }
		public DateTime mots_invoice_due_date { get; set; }
		public string mots_invoice_airline_company { get; set; }
		public string mots_invoice_airline_branch { get; set; }
		public long mots_invoice_airline_taxid { get; set; }
		public string mots_invoice_airline_telno { get; set; }
		public string mots_invoice_airline_address { get; set; }
		public string mots_invoice_detail_item { get; set; }
		public int mots_invoice_detail_item_price { get; set; }
		public string mots_invoice_detail_total_baht { get; set; }
		public int mots_invoice_detail_total_price { get; set; }

	}
}
