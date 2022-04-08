using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using ReportPublisher.Interface;

namespace ReportPublisher.Dmo
{
    public class MotsInvoiceDmo : ITableDmo
    {
        private readonly DataTable _dataTable;

        public MotsInvoiceDmo()
        {
            _dataTable = new DataTable();
        }
        public DataTable GetDataTable()
        {
            _dataTable.TableName = "mots_invoice";
            _dataTable.Columns.Add("invoice_no", typeof(string));
            _dataTable.Columns.Add("invoice_date", typeof(string));
            _dataTable.Columns.Add("ref1", typeof(string));
            _dataTable.Columns.Add("ref2", typeof(string));
            _dataTable.Columns.Add("due_date", typeof(string));
            _dataTable.Columns.Add("airline_company", typeof(string));
            _dataTable.Columns.Add("airline_branch", typeof(string));
            _dataTable.Columns.Add("airline_taxid", typeof(string));
            _dataTable.Columns.Add("airline_telno", typeof(string));
            _dataTable.Columns.Add("airline_address", typeof(string));
            _dataTable.Columns.Add("detail_item", typeof(string));
            _dataTable.Columns.Add("detail_item_price", typeof(string));
            _dataTable.Columns.Add("detail_total_baht", typeof(string));
            _dataTable.Columns.Add("detail_total_price", typeof(string));

            return _dataTable;
        }

        public string GetSelectCommand()
        {
            return "SELECT * From mots_dat_invoice";
        }
    }
}
