using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles
{
    
        class Reports
    {// This class is responsible for handling report-related operations
        public void GetReport()
            {
                // Code to generate report
                Console.WriteLine("Report Content.");
            }
            public void SaveReport()
            {
                // Code to save report
                Console.WriteLine("Report saved.");
            }
            public void SendReport()
            {
                // Code to send report
                Console.WriteLine("Report sent.");
            }
        }
        class PrintReports
    {// This class is responsible for handling report printing and exporting operations
        public void PrintReport()
            {
                // Code to print report
                Console.WriteLine("Report printed.");
            }
            public void MsExcelReport()
            {
                // Code to export report to Excel
                Console.WriteLine("Report exported to Excel.");
            }

            public void MsWordReport()
            {
                // Code to export report to Word
                Console.WriteLine("Report exported to Word.");
            }
            public void PdfReport()
            {
                // Code to export report to PDF
                Console.WriteLine("Report exported to PDF.");
            }
        }
        class BillReports
    {
        // This class is responsible for handling bill-related operations and 
        //when implementing the Single Responsibility Principle, we should ensure that each class has only one reason to change. In this case, the BillReports class should only be responsible for handling bill-related operations,
        //and any changes related to bill generation should only affect this class.
        //it acn have single or multiple methods related to bill generation, but it should not have methods related to report generation or other unrelated functionalities.
        public void generateBill()
            {
                // Code to generate bill
                Console.WriteLine("Bill generated.");
            }
          
           
        }
    internal class ClassLevelSingleResponsibilityPrinciple
    {
        static void Main(string[] args)
        {
            Reports report = new Reports();
            report.GetReport();
            report.SaveReport();
            report.SendReport();
            PrintReports printReport = new PrintReports();
            printReport.PrintReport();
            printReport.MsExcelReport();
            printReport.MsWordReport();
            printReport.PdfReport();
            BillReports billReport = new BillReports();
            billReport.generateBill();
        }


    }
}
