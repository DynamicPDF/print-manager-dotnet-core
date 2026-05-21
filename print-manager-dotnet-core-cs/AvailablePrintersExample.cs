using ceTe.DynamicPDF.Printing;
using System;

namespace print_manager_dotnet_core_cs
{
    internal class AvailablePrintersExample
    {
        public static void Run()
        {
            {
                foreach (Printer printer in Printer.GetLocalPrinters()) 
                   Console.WriteLine(printer.Name);
            }
        }
    }
}
