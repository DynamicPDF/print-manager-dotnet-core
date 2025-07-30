
using ceTe.DynamicPDF.Printing;
using System;

namespace print_manager_dotnet_core_cs
{
    class SpecificPrinter
    {

        public static void Run()
        {
            string printerName = string.Empty;
            Console.WriteLine("This example shows using a specific printer using DynamicPDF Print Manager");
            Console.WriteLine();
            Console.WriteLine("Enter the printer name:");
            printerName = Console.ReadLine();

            // Create a print job with the document to be printed to the default printer
            PrintJob printJob = new PrintJob(printerName, Util.GetPath("Resources/DocumentA.pdf"));

            // Print the print job
            printJob.Print();
        }

    }
}
