using System;
using ceTe.DynamicPDF.Printing;

namespace print_manager_dotnet_core_cs
{
    class EventsExample
    {
        public static void Run()
        {
            // Create a print job with the document to be printed to the default printer
            PrintJob printJob = new PrintJob(Printer.Default, Util.GetPath("Resources/DocumentA.pdf"));

            // PrintJob Events
            printJob.Failed += new PrintJobFailedEventHandler(printer_PrintJobFalied);
            printJob.Succeeded += new PrintJobEventHandler(printer_PrintJobSucceeded);
            printJob.Updated += new PrintJobEventHandler(printer_PrintJobUpdated);

            //Print the job
            printJob.Print();
        }

        static void printer_PrintJobFalied(object obj, PrintJobFailedEventArgs e)
        {
            Console.WriteLine("Print Failed : JobId = " + e.PrintJob.JobId + " Exception.Message = " + e.Exception.Message);
        }

        static void printer_PrintJobSucceeded(object obj, PrintJobEventArgs e)
        {
            Console.WriteLine("Print Succeeded : JobId = " + e.PrintJob.JobId);
        }

        static void printer_PrintJobUpdated(object obj, PrintJobEventArgs e)
        {
            Console.WriteLine("PrintJob Updated: JobId = " + e.PrintJob.JobId + "  PrintStatus = " + e.PrintJob.Status + "  PagesPrinted = " + e.PrintJob.PagesPrinted);
        }
    }
}
