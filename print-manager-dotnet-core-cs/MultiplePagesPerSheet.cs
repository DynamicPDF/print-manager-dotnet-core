using System;
using System.Drawing;
using ceTe.DynamicPDF.Printing;

namespace print_manager_dotnet_core_cs
{
    class MultiplePagesPerSheet
    {
        public static void Run()
        {
            // Create a print job with the document to be printed to the default printer
            PrintJob printJob = new PrintJob(Printer.Default);

            // Add pages to the print job from multiple PDFs
            printJob.Pages.Add(Util.GetPath("Resources/DocumentA1.pdf"));
            printJob.Pages.Add(Util.GetPath("Resources/DocumentB1.pdf"));
            printJob.Pages.Add(Util.GetPath("Resources/DocumentC1.pdf"));
            printJob.Pages.Add(Util.GetPath("Resources/DocumentD1.pdf"));

            // Create a MultiplepagePageScalling class and set the properties
            MultipagePageScaling multipagePageScaling = new MultipagePageScaling(4, 2);
            multipagePageScaling.Border = new Border(Color.Green, 2);
            multipagePageScaling.Margin = new Margin(5, 5, 5, 5);
            multipagePageScaling.Spacing = new Spacing(2, 2);
            multipagePageScaling.UniformScaling = true;

            // Add the class to the PrintOptions Scaling property
            printJob.PrintOptions.Scaling = multipagePageScaling;

            // Print the print job
            printJob.Print();
        }
    }
}
