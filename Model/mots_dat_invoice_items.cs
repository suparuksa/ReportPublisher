using System;
using System.Collections.Generic;
using System.Text;

namespace dotNetFastReport.Model
{
    public class mots_dat_invoice_items : model_base
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
		public string detail_item1 { get; set; }
		public string detail_item1_price { get; set; }
		public string detail_item2 { get; set; }
		public string detail_item2_price { get; set; }
		public string detail_item3 { get; set; }
		public string detail_item3_price { get; set; }
		public string detail_item4 { get; set; }
		public string detail_item4_price { get; set; }
		public string detail_item5 { get; set; }
		public string detail_item5_price { get; set; }
		public string detail_item6 { get; set; }
		public string detail_item6_price { get; set; }
		public string detail_item7 { get; set; }
		public string detail_item7_price { get; set; }
		public string detail_item8 { get; set; }
		public string detail_item8_price { get; set; }
		public string detail_item9 { get; set; }
		public string detail_item9_price { get; set; }
		public string detail_item10 { get; set; }
		public string detail_item10_price { get; set; }
		public string detail_item11 { get; set; }
		public string detail_item11_price { get; set; }
		public string detail_item12 { get; set; }
		public string detail_item12_price { get; set; }
		public string detail_item13 { get; set; }
		public string detail_item13_price { get; set; }
		public string detail_item14 { get; set; }
		public string detail_item14_price { get; set; }
		public string detail_item15 { get; set; }
		public string detail_item15_price { get; set; }
		public string detail_item16 { get; set; }
		public string detail_item16_price { get; set; }
		public string detail_item17 { get; set; }
		public string detail_item17_price { get; set; }
		public string detail_item18 { get; set; }
		public string detail_item18_price { get; set; }
		public string detail_item19 { get; set; }
		public string detail_item19_price { get; set; }
		public string detail_item20 { get; set; }
		public string detail_item20_price { get; set; }
		public string detail_item21 { get; set; }
		public string detail_item21_price { get; set; }
		public string detail_item22 { get; set; }
		public string detail_item22_price { get; set; }
		public string detail_item23 { get; set; }
		public string detail_item23_price { get; set; }
		public string detail_item24 { get; set; }
		public string detail_item24_price { get; set; }
		public string detail_total_baht { get; set; }
		public string detail_total_price { get; set; }
		public string conclude_detail { get; set; }
		public string conclude_detial_price { get; set; }

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
					this.detail_item1,
					this.detail_item1_price,
					this.detail_item3,
					this.detail_item3_price,
					this.detail_item4,
					this.detail_item4_price,
					this.detail_item5,
					this.detail_item5_price,
					this.detail_item6,
					this.detail_item6_price,
					this.detail_item7,
					this.detail_item7_price,
					this.detail_item8,
					this.detail_item8_price,
					this.detail_item9,
					this.detail_item9_price,
					this.detail_item10,
					this.detail_item10_price,
					this.detail_item11,
					this.detail_item11_price,
					this.detail_item12,
					this.detail_item12_price,
					this.detail_item13,
					this.detail_item13_price,
					this.detail_item14,
					this.detail_item14_price,
					this.detail_item15,
					this.detail_item15_price,
					this.detail_item16,
					this.detail_item16_price,
					this.detail_item17,
					this.detail_item17_price,
					this.detail_item18,
					this.detail_item18_price,
					this.detail_item19,
					this.detail_item19_price,
					this.detail_item20,
					this.detail_item20_price,
					this.detail_item21,
					this.detail_item21_price,
					this.detail_item22,
					this.detail_item22_price,
					this.detail_item23,
					this.detail_item23_price,
					this.detail_item24,
					this.detail_item24_price,
					this.detail_total_baht,
					this.detail_total_price,
					this.conclude_detail,
					this.conclude_detial_price
			};
		}
	}

}
