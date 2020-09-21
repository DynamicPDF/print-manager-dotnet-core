using System;
using ceTe.DynamicPDF.Printing;

namespace print_manager_dotnet_core_cs
{
    class PrintOptions
    {
        public static void Run()
        {
            // Create a print job with the document to be printed to the default printer
            PrintJob printJob = new PrintJob(Printer.Default, Util.GetPath("Resources/DocumentA.pdf"), 2, 2);

            // Set resolution to high
            printJob.PrintOptions.Resolution = ResolutionList.High;

            // Set the print priority
            printJob.PrintPriority = 2;

            // Sent the print scaling
            printJob.PrintOptions.Scaling = new PercentagePageScaling(0.5f);

            // Set the page orientation
            printJob.PrintOptions.Orientation.Type = OrientationType.Portrait;

            // Set the option to print in color
            if (printJob.Printer.Color)
            {
                printJob.PrintOptions.Color = true;
            }

            // Print the print job
            printJob.Print();
        }
    }
}
