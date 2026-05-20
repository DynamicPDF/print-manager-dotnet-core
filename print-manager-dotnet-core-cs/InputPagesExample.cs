

using ceTe.DynamicPDF.Printing;

namespace print_manager_dotnet_core_cs
{
    internal class InputPagesExample
    {
        public static void Run()
        {

            PrintJob printJob = new PrintJob(Printer.Default);
            InputPdf inputPdf = new InputPdf(Util.GetPath("Resources/DocumentA.pdf"));
            InputPdfPage firstPage = inputPdf.Pages[0];
            InputPdfPage fourthPage = inputPdf.Pages[3];
            printJob.Pages.Add(firstPage);
            printJob.Pages.Add(fourthPage);
            printJob.Print();
        }
    }
}
