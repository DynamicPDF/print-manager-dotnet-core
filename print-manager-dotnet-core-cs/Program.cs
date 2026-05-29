using System;

namespace print_manager_dotnet_core_cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Printing Examples Started");

            AlignExample.Run();
            AttachmentsExample.Run();
            AvailablePrintersExample.Run();
            ByteArrayExample.Run();
            DisposeExample.Run();
            DuplexExample.Run();
            EventsExample.Run();
            FaxExample.Run();
            InputPagesExample.Run();
            InputSourceExample.Run();
            MultiplePages.Run();
            MultiplePagesPerSheet.Run();
            PageRangeExample.Run();
            PageScalingExample.Run();
            PrintOptionsExample.Run();
            PrintPageOptionsExample.Run();
            PrintAreaExample.Run();
            ReadPrinterDetails.Run();
            ResolutionExample.Run();
            SecuredExample.Run();
            SimplePrint.Run();
            SpecificPrinter.Run();

            Console.WriteLine("Printing Examples Completed");
        }
    }
}
