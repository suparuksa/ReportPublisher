using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Data;
using Dapper;
using dotNetFastReport.Model;

namespace dotNetFastReport.Database
{

    
    public partial class DataSetCreator
    {
        private readonly DataSet _reportDataSet;
        private readonly DataTable _reportDataTable;

        public DataSetCreator()
        {
            _reportDataSet = new DataSet();
            _reportDataTable = new DataTable();
        }
        public DataSet CreateReportDataSet()
        {

            _reportDataTable.TableName = "report_datas";
            _reportDataTable.Columns.Add("id", typeof(int));
            _reportDataTable.Columns.Add("report_name", typeof(string));
            _reportDataTable.Columns.Add("report_data", typeof(string));

            var connection_string = @"Server=SPBNB\SQL2019DEV;Database=develop;Trusted_Connection=True;";
            using (var sqlconnect = new SqlConnection(connection_string))
            {

                var allReportDatas = sqlconnect.Query<report_datas>("SELECT id, report_name, report_data From report_datas");
                foreach (var report_data in allReportDatas)
                {
                    _reportDataTable.Rows.Add(report_data.id, report_data.report_name, report_data.report_data);
                }

            }

            _reportDataSet.Tables.Add(_reportDataTable);

            return _reportDataSet;
        }
    }
}
