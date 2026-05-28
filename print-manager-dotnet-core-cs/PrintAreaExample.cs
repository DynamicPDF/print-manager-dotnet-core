
using ceTe.DynamicPDF.Printing;

namespace print_manager_dotnet_core_cs
{
    internal class PrintAreaExample
    {
        public static void Run()
        {
            InputPdf pdf = new InputPdf(Util.GetPath("Resources/DocumentA.pdf"));
            PrintJob printJob = new PrintJob(Printer.Default);
            //Specify print area for the second & third pages and add them to print job.
            System.Drawing.Rectangle printArea = new System.Drawing.Rectangle(0, 0, 600, 400);
            printJob.Pages.Add(pdf, printArea, 2, 2);
            printJob.Print();
        }
    }
}
