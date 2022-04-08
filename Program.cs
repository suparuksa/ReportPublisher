using System;
using System.IO;
using FastReport;
using FastReport.Export.PdfSimple;
using ReportPublisher.Database;
using ReportPublisher.Dmo;
using ReportPublisher.Model;
using ReportPublisher.Util;


namespace ReportPublisher
{

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome! Press any key to procced...");
            Console.ReadKey();

            var inFolder = Utils.FindDirectory("in");
            var outFolder = Directory.GetParent(inFolder).FullName + "\\out";

            Report report = new Report();
            try
            {
                var _reportdatasetcreator = new DataSetCreator<MotsInvoiceItems>(new MotsInvoiceItemsDmo());
                var dataSet = _reportdatasetcreator.CreateReportDataSet();

                report.Load($@"{inFolder}\mots_frm_invoice_items.frx");
                report.RegisterData(dataSet);
                report.Prepare();

                report.Export(new PDFSimpleExport(), $@"{outFolder}\mots_invoice_items.pdf");

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                report.Dispose();
            }

            Console.WriteLine("\nPrepared report and report exported as pdf have been saved into the 'out' folder.");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
