using System;
using ceTe.DynamicPDF.Printing;

namespace print_manager_dotnet_core_cs
{
    class DuplexExample
    {
        public static void RunHorizontalDuplex()
        {
            // Create a print job with the document to be printed to the default printer
            PrintJob printJob = new PrintJob(Printer.Default, Util.GetPath("Resources/DocumentA.pdf"));

            // Set PrintOptions with DuplexMode
            printJob.PrintOptions.Scaling = new PercentagePageScaling(0.5f);
            printJob.PrintOptions.DuplexMode = DuplexMode.DuplexHorizontal;

            // Print the print job
            printJob.Print();
        }

        public static void RunSimplex()
        {
            // Create a print job with the document to be printed to the default printer
            PrintJob printJob = new PrintJob(Printer.Default, Util.GetPath("Resources/DocumentA.pdf"));

            // Set PrintOptions with DuplexMode
            printJob.PrintOptions.Scaling = new PercentagePageScaling(0.5f);
            printJob.PrintOptions.DuplexMode = DuplexMode.Simplex;

            // Print the print job
            printJob.Print();
        }

        public static void RunVerticalDuplex()
        {
            // Create a print job with the document to be printed to the default printer
            PrintJob printJob = new PrintJob(Printer.Default, Util.GetPath("Resources/DocumentA.pdf"));

            // Set PrintOptions with DuplexMode
            printJob.PrintOptions.Scaling = new PercentagePageScaling(0.5f);
            printJob.PrintOptions.DuplexMode = DuplexMode.DuplexVertical;

            // Print the print job
            printJob.Print();
        }
    }
}
