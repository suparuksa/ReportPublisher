using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using dotNetFastReport.Interface;

namespace dotNetFastReport.Dmo
{
    public class MotsInvoiceItemsDmo : ITableDmo
    {
        private readonly DataTable _dataTable;

        public MotsInvoiceItemsDmo()
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
            //
            _dataTable.Columns.Add("detail_item1", typeof(string));
            _dataTable.Columns.Add("detail_item1_price", typeof(string));
            _dataTable.Columns.Add("detail_item2", typeof(string));
            _dataTable.Columns.Add("detail_item2_price", typeof(string));
            _dataTable.Columns.Add("detail_item3", typeof(string));
            _dataTable.Columns.Add("detail_item3_price", typeof(string));
            _dataTable.Columns.Add("detail_item4", typeof(string));
            _dataTable.Columns.Add("detail_item4_price", typeof(string));
            _dataTable.Columns.Add("detail_item5", typeof(string));
            _dataTable.Columns.Add("detail_item5_price", typeof(string));
            _dataTable.Columns.Add("detail_item6", typeof(string));
            _dataTable.Columns.Add("detail_item6_price", typeof(string));
            _dataTable.Columns.Add("detail_item7", typeof(string));
            _dataTable.Columns.Add("detail_item7_price", typeof(string));
            _dataTable.Columns.Add("detail_item8", typeof(string));
            _dataTable.Columns.Add("detail_item8_price", typeof(string));
            _dataTable.Columns.Add("detail_item9", typeof(string));
            _dataTable.Columns.Add("detail_item9_price", typeof(string));
            _dataTable.Columns.Add("detail_item10", typeof(string));
            _dataTable.Columns.Add("detail_item10_price", typeof(string));
            _dataTable.Columns.Add("detail_item11", typeof(string));
            _dataTable.Columns.Add("detail_item11_price", typeof(string));
            _dataTable.Columns.Add("detail_item12", typeof(string));
            _dataTable.Columns.Add("detail_item12_price", typeof(string));
            _dataTable.Columns.Add("detail_item13", typeof(string));
            _dataTable.Columns.Add("detail_item13_price", typeof(string));
            _dataTable.Columns.Add("detail_item14", typeof(string));
            _dataTable.Columns.Add("detail_item14_price", typeof(string));
            _dataTable.Columns.Add("detail_item15", typeof(string));
            _dataTable.Columns.Add("detail_item15_price", typeof(string));
            _dataTable.Columns.Add("detail_item16", typeof(string));
            _dataTable.Columns.Add("detail_item16_price", typeof(string));
            _dataTable.Columns.Add("detail_item17", typeof(string));
            _dataTable.Columns.Add("detail_item17_price", typeof(string));
            _dataTable.Columns.Add("detail_item18", typeof(string));
            _dataTable.Columns.Add("detail_item18_price", typeof(string));
            _dataTable.Columns.Add("detail_item19", typeof(string));
            _dataTable.Columns.Add("detail_item19_price", typeof(string));
            _dataTable.Columns.Add("detail_item20", typeof(string));
            _dataTable.Columns.Add("detail_item20_price", typeof(string));
            _dataTable.Columns.Add("detail_item21", typeof(string));
            _dataTable.Columns.Add("detail_item21_price", typeof(string));
            _dataTable.Columns.Add("detail_item22", typeof(string));
            _dataTable.Columns.Add("detail_item22_price", typeof(string));
            _dataTable.Columns.Add("detail_item23", typeof(string));
            _dataTable.Columns.Add("detail_item23_price", typeof(string));
            _dataTable.Columns.Add("detail_item24", typeof(string));
            _dataTable.Columns.Add("detail_item24_price", typeof(string));
            //
            _dataTable.Columns.Add("detail_total_baht", typeof(string));
            _dataTable.Columns.Add("detail_total_price", typeof(string));
            _dataTable.Columns.Add("conclude_detail", typeof(string));
            _dataTable.Columns.Add("conclude_detial_price", typeof(string));

            return _dataTable;
        }

        public string GetSelectCommand()
        {
            return "SELECT * From mots_dat_invoice_items";
        }

    }
}
