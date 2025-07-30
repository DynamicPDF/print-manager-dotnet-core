using System;

namespace print_manager_dotnet_core_cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Printing Examples Started");

            SimplePrint.Run();

            //SpecificPrinter.Run();

            //ByteArrayExample.Run();

            // Uncomment examples below to run them

            //AlignExample.RunHorizontalAlign();
            //AlignExample.RunVerticalAlign();

            //AttachmentsExample.Run();

            //DuplexExample.RunHorizontalDuplex();
            //DuplexExample.RunSimplex();
            //DuplexExample.RunVerticalDuplex();

            //EventsExample.Run();

            //MultiplePages.Run();

            //MultiplePagesPerSheet.Run();

            //PageScalingExample.RunActualPaperScaling();
            //PageScalingExample.RunMultiPageScaling();
            //PageScalingExample.RunPageEdgeScaling();
            //PageScalingExample.RunPercentageScaling();

            //PrintOptions.Run();

            //ReadPrinterDetails.Run();

            Console.WriteLine("Printing Examples Completed");
            Console.ReadKey();
        }
    }
}
