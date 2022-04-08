using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Data;
using System.Data.SqlClient;

namespace ReportPublisher.Util
{
    public class ReportManager
    {
        const string _insertCommand = "INSERT INTO reports(report_name, report_bin) VALUES (@report_name, @report_file)";

        public void PubllishReportToDatabase(string reportName)
        {
            byte[] fileBytes;
            var filePath = Directory.GetCurrentDirectory() + reportName;
            using (var stream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                using (var reader = new BinaryReader(stream))
                {
                    fileBytes = reader.ReadBytes((int)stream.Length);
                }
            }
            var connection_string = @"Server=SPBNB\SQL2019DEV;Database=develop;Trusted_Connection=True;";
            using (var sqlconnect = new SqlConnection(connection_string))
            {

                const string statement = _insertCommand;

                using (var cmd = new SqlCommand() { Connection = sqlconnect, CommandText = statement })
                {
                    cmd.Parameters.Add("@report_file", SqlDbType.VarBinary, fileBytes.Length).Value = fileBytes;

                    cmd.Parameters.AddWithValue("@report_name", "Test Report");

                    try
                    {
                        sqlconnect.Open();
                        var NewIdentifier = Convert.ToInt32(cmd.ExecuteScalar());
                        Console.WriteLine("Success with" + NewIdentifier.ToString());

                    }
                    catch (Exception ex)
                    {
                        var ExceptionMessage = ex.Message;
                        Console.WriteLine("Error Message");
                    }
                }

            }

        }
    }
}
