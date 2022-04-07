﻿using System;
using System.IO;
using FastReport;
using FastReport.Export.PdfSimple;
using dotNetFastReport.Database;
using dotNetFastReport.Util;
using dotNetFastReport.Dmo;


namespace dotNetFastReport
{

    class Program
    {
        private static string outFolder = @"..\..\..\out\";
        private static string inFolder = @"..\..\..\in\";

        static Program()
        {
            inFolder = Utils.FindDirectory("in");
            outFolder = Directory.GetParent(inFolder).FullName + "\\out";
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Welcome! Press any key to procced...");
            Console.ReadKey();

            Report report = new Report();
            try
            {
                var _reportdatasetcreator = new DataSetCreator(new mots_dat_invoice_dmo());
                var dataSet = _reportdatasetcreator.CreateReportDataSet();

                report.Load($@"{inFolder}\mots_frm_invoice.frx");
                report.RegisterData(dataSet);
                report.Prepare();

                report.Export(new PDFSimpleExport(), $@"{outFolder}\mots_invoice.pdf");

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
