using System.Data.SqlClient;
using System.Data;
using Dapper;
using ReportPublisher.Model;
using ReportPublisher.Interface;

namespace ReportPublisher.Database
{
    public partial class DataSetCreator<T> where T : ModelBase
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

                var allRows = sqlconnect.Query<T>(_reportDmo.GetSelectCommand());
                foreach (var row in allRows)
                {
                    
                    _reportDataTable.Rows.Add(row.GetItemValue()); 
                }

            }

            _reportDataSet.Tables.Add(_reportDataTable);

            return _reportDataSet;
        }
    }
}
