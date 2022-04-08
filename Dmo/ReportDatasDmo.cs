using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using dotNetFastReport.Interface;

namespace dotNetFastReport.Dmo
{
    public class ReportDatasDmo : ITableDmo
    {
        private readonly DataTable _dataTable;

        public ReportDatasDmo()
        {
            _dataTable = new DataTable();
        }

        public DataTable GetDataTable()
        {
            _dataTable.TableName = "report_datas";
            _dataTable.Columns.Add("id", typeof(int));
            _dataTable.Columns.Add("report_name", typeof(string));
            _dataTable.Columns.Add("report_data", typeof(string));

            return _dataTable;
        }

        public string GetSelectCommand()
        {
            return "SELECT id, report_name, report_data From report_datas";
        }
    }
}
