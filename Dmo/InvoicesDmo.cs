using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using ReportPublisher.Interface;

namespace ReportPublisher.Dmo
{
    public class InvoicesDmo : ITableDmo
    {
        private readonly DataTable _dataTable;

        public InvoicesDmo()
        {
            _dataTable = new DataTable();
        }

        public DataTable GetDataTable()
        {
            _dataTable.TableName = "Invoices";
            _dataTable.Columns.Add("InvoiceNo", typeof(string));
            _dataTable.Columns.Add("DocumentDate", typeof(DateTime));
            _dataTable.Columns.Add("RefNo1", typeof(string));
            _dataTable.Columns.Add("RefNo2", typeof(string));
            _dataTable.Columns.Add("ExpiredDate", typeof(DateTime));
            _dataTable.Columns.Add("ReceivableName", typeof(string));
            _dataTable.Columns.Add("TaxNo", typeof(string));
            _dataTable.Columns.Add("TelNo", typeof(string));
            _dataTable.Columns.Add("InvoiceAddress", typeof(string));
            _dataTable.Columns.Add("TotalAmount", typeof(double));

            return _dataTable;
        }

        public string GetSelectCommand()
        {
            return "SELECT [InvoiceNo] "
                          +",[DocumentDate]"
                          +",[RefNo1]"
                          + ",[RefNo2]"
                          + ",[ExpiredDate]"
                          + ",[ReceivableName]"
                          + ",[TaxNo]"
                          + ",[TelNo]"
                          + ",[InvoiceAddress]"
                          + ",[TotalAmount]"
                   + "FROM[dbo].[Invoices] "
                   + "WHERE [Id] = 1722";
        }
    }
}
