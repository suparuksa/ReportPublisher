using System;
using System.Collections.Generic;
using System.Text;

namespace ReportPublisher.Model
{
	public class Invoices : ModelBase
	{
		public string InvoiceNo { get; set; }
		public DateTime DocumentDate { get; set; }
		public string RefNo1 { get; set; }
		public string RefNo2 { get; set; }
		public DateTime ExpiredDate { get; set; }
		public string ReceivableName { get; set; }
		public string TaxNo { get; set; }
		public string TelNo { get; set; }
		public string InvoiceAddress { get; set; }
		public double TotalAmount { get; set; }

		public override object[] GetItemValue()
		{
			return new object[] {
				this.InvoiceNo,
				this.DocumentDate,
				this.RefNo1,
				this.RefNo2,
				this.ExpiredDate,
				this.ReceivableName,
				this.TaxNo,
				this.TelNo,
				this.InvoiceAddress,
				this.TotalAmount
			};
		}
	}
}
