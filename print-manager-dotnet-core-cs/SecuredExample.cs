
using ceTe.DynamicPDF.Printing;

namespace print_manager_dotnet_core_cs
{
    internal class SecuredExample
    {
        public static void Run()
        {
            InputPdf inputPdf = new InputPdf(Util.GetPath("Resources/secured.pdf"), "password");
            PrintJob printJob = new PrintJob(Printer.Default, inputPdf);
            printJob.Print();
        }       
    }
}
