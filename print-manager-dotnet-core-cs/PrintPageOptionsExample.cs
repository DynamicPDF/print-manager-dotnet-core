
using ceTe.DynamicPDF.Printing;

namespace print_manager_dotnet_core_cs
{
    internal class PrintPageOptionsExample
    {
        public static void Run()
        {
            PrintJob printJob = new PrintJob(Printer.Default, Util.GetPath("Resources/DocumentA.pdf"));

            if (printJob.Printer.Color)
                printJob.PrintOptions.Color = true;

            printJob.PrintOptions.Copies = 2;
            printJob.PrintOptions.Scaling = PageScaling.ActualSize;
            printJob.PrintOptions.PrintAnnotations = false;
            PrintJobPage printJobPage = printJob.Pages[printJob.Pages.Count - 1];
            PrintJobPagePrintOptions pagePrintOptions = printJobPage.PrintOptions;
            pagePrintOptions.Inherit = false;
            pagePrintOptions.Scaling = new PercentagePageScaling(0.5f);
            pagePrintOptions.HorizontalAlign = HorizontalAlign.Left;
            pagePrintOptions.PrintAnnotations = true;
            printJob.Print();
        }
    }
}
