using System;
using ceTe.DynamicPDF.Printing;

namespace print_manager_dotnet_core_cs
{
    class ReadPrinterDetails
    {
        public static void Run()
        {
            PrintJob printJob = new PrintJob(Printer.Default);

            Console.WriteLine("Options for: " + printJob.Printer.Name);
            Console.WriteLine("Collate " + printJob.Printer.Collate);
            Console.WriteLine("Duplex " + printJob.Printer.Duplex);
            Console.WriteLine("MaxCopies " + printJob.Printer.MaxCopies);
            Console.WriteLine("MaxPaperHeight " + printJob.Printer.MaxPaperHeight);
            Console.WriteLine("MaxPaperWidth " + printJob.Printer.MaxPaperWidth);
            Console.WriteLine("MinPaperHeight " + printJob.Printer.MinPaperHeight);
            Console.WriteLine("MinPaperWidth " + printJob.Printer.MinPaperWidth);
            ListPaperSizes(printJob.Printer.PaperSizes);
            ListPaperSources(printJob.Printer.PaperSources);
            ListResolutions(printJob.Printer.Resolutions);
        }

        static void ListPaperSizes(PaperSizeList paperSizes)
        {
            Console.WriteLine("List of Paper Sizes: ");
            for (int i = 0; i < paperSizes.Count; i++)
            {
                Console.WriteLine(" " + paperSizes[i].Name + " : Width= " + UnitConverter.PointsToInches(paperSizes[i].Width) + " : Height = " + UnitConverter.PointsToInches(paperSizes[i].Height));
            }
        }

        static void ListPaperSources(PaperSourceList paperSources)
        {
            Console.WriteLine("List of Paper Sources ");
            for (int i = 0; i < paperSources.Count; i++)
            {
                Console.WriteLine(" " + paperSources[i].Name);
            }
        }

        static void ListResolutions(ResolutionList resolutions)
        {
            Console.WriteLine("List of Resolution ");
            for (int i = 0; i < resolutions.Count; i++)
            {
                Console.WriteLine(" " + resolutions[i].HorizontalDpi + " dpi " + resolutions[i].VerticalDpi + " dpi");
            }
        }
    }
}
