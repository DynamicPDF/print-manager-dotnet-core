using System;
using ceTe.DynamicPDF.Printing;

namespace print_manager_dotnet_core_cs
{
    class PageScalingExample
    {
        public static void RunActualPaperScaling()
        {
            InputPdf pdf = new InputPdf(Util.GetPath("Resources/DocumentA.pdf"));

            // Create a print job with the document to be printed to the default printer
            PrintJob printJob = new PrintJob(Printer.Default);
            printJob.Pages.Add(pdf);
            printJob.PrintOptions.Scaling = PageScaling.ActualSize;

            //Print the job
            printJob.Print();
        }

        public static void RunMultiPageScaling()
        {
            InputPdf pdf = new InputPdf(Util.GetPath("Resources/DocumentA.pdf"));

            // Create a print job with the document to be printed to the default printer
            PrintJob printJob = new PrintJob(Printer.Default);
            printJob.Pages.Add(pdf);

            // Set MultipagePageScaling
            printJob.PrintOptions.Scaling = new MultipagePageScaling(4, 2);

            //Print the job
            printJob.Print();
        }

        public static void RunPageEdgeScaling()
        {
            InputPdf pdf = new InputPdf(Util.GetPath("Resources/DocumentA.pdf"));

            // Create a print job with the document to be printed to the default printer
            PrintJob printJob = new PrintJob(Printer.Default);
            printJob.Pages.Add(pdf);

            // Set AutoPageScaling
            printJob.PrintOptions.Scaling = new AutoPageScaling(ScaleTo.PageEdges);

            //Print the job
            printJob.Print();
        }

        public static void RunPercentageScaling()
        {
            InputPdf pdf = new InputPdf(Util.GetPath("Resources/DocumentA.pdf"));

            // Create a print job with the document to be printed to the default printer
            PrintJob printJob = new PrintJob(Printer.Default);
            printJob.Pages.Add(pdf);

            // Set PercentagePageScaling
            printJob.PrintOptions.Scaling = new PercentagePageScaling(0.75f);

            //Print the job
            printJob.Print();
        }
    }
}
