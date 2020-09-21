using System;
using ceTe.DynamicPDF.Printing;

namespace print_manager_dotnet_core_cs
{
    class AlignExample
    {
        public static void RunVerticalAlign()
        {
            // Create a print job with the document to be printed to the default printer
            PrintJob printJob = new PrintJob(Printer.Default, Util.GetPath("Resources/DocumentA.pdf"), 1, 1);

            // Set PrintOptions with vertical align
            printJob.PrintOptions.Scaling = new PercentagePageScaling(0.5f);
            printJob.PrintOptions.VerticalAlign = VerticalAlign.Bottom;

            // Print the print job
            printJob.Print();
        }

        public static void RunHorizontalAlign()
        {
            // Create a print job with the document to be printed to the default printer
            PrintJob printJob = new PrintJob(Printer.Default, Util.GetPath("Resources/DocumentA.pdf"));

            // Set PrintOptions with Horizontal align
            printJob.PrintOptions.Scaling = new PercentagePageScaling(0.5f);
            printJob.PrintOptions.HorizontalAlign = HorizontalAlign.Center;

            // Print the print job
            printJob.Print();
        }
    }
}
