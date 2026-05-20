
using ceTe.DynamicPDF.Printing;
using System;

namespace print_manager_dotnet_core_cs
{
    internal class InputSourceExample
    {
        public static void Run()
        {
            InputPdf inputPdf = new InputPdf(Util.GetPath("Resources/DocumentA.pdf"), "password");
            Console.WriteLine("==== properties ====");
            Console.WriteLine("Author: " + inputPdf.Author);
            Console.WriteLine("Keywords: " + inputPdf.Keywords);
            Console.WriteLine("Title: " + inputPdf.Title);
            PrintJob printJob = new PrintJob(Printer.Default, inputPdf);
            printJob.Print();
        }
    }
}
