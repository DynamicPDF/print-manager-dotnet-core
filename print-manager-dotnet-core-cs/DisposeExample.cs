using ceTe.DynamicPDF.Printing;

namespace print_manager_dotnet_core_cs
{
    internal class DisposeExample
    {
        public static void Run()
        {
            PrintJob printJob = new PrintJob(Printer.Default, Util.GetPath("Resources/DocumentA.pdf"));
            printJob.Print();
            printJob.Dispose();

            InputPdf pdf = new InputPdf(Util.GetPath("Resources/DocumentA.pdf"));
            printJob = new PrintJob(Printer.Default, pdf);
            printJob.Print();
            pdf.Dispose();
        }
    }
}
