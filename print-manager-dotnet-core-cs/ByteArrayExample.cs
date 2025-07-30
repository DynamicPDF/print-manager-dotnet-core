using ceTe.DynamicPDF.Printing;

namespace print_manager_dotnet_core_cs
{
    class ByteArrayExample
    {
        public static void Run()
        {
            byte[] pdfBytes = System.IO.File.ReadAllBytes(Util.GetPath("Resources/DocumentA.pdf"));

            InputPdf pdf = new InputPdf(pdfBytes);
            PrintJob printJob = new PrintJob(Printer.Default, pdf);

            printJob.Print();
        }

    }
}
