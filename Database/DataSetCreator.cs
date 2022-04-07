using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Data;
using Dapper;
using dotNetFastReport.Model;
using dotNetFastReport.Dmo;
using dotNetFastReport.Interface;

namespace dotNetFastReport.Database
{

    
    public partial class DataSetCreator
    {
        private readonly DataSet _reportDataSet;
        private readonly ITableDmo _reportDmo;

        public DataSetCreator(ITableDmo reportDmo)
        {
            _reportDataSet = new DataSet();
            _reportDmo = reportDmo;
        }
        public DataSet CreateReportDataSet()
        {
           var _reportDataTable = _reportDmo.GetDataTable();
            
            var connection_string = @"Server=SPBNB\SQL2019DEV;Database=develop;Trusted_Connection=True;";
            using (var sqlconnect = new SqlConnection(connection_string))
            {

                var allRows = sqlconnect.Query<mots_dat_invoice>(_reportDmo.GetSelectCommand());
                foreach (var row in allRows)
                {
                    /*
                    _reportDataTable.Rows.Add(
                        row.id, 
                        row.report_name, 
                        row.report_data
                    );
                    */

                    _reportDataTable.Rows.Add(
                            row.invoice_no,
                            row.invoice_date,
                            row.ref1,
                            row.ref2,
                            row.due_date,
                            row.airline_company,
                            row.airline_branch,
                            row.airline_taxid,
                            row.airline_telno,
                            row.airline_address,
                            row.detail_item,
                            row.detail_item_price,
                            row.detail_total_baht,
                            row.detail_total_price
                            );


                }

            }

            _reportDataSet.Tables.Add(_reportDataTable);

            return _reportDataSet;
        }
    }
}
