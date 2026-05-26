

using ceTe.DynamicPDF.Printing;

namespace print_manager_dotnet_core_cs
{
    internal class ResolutionExample
    {
        public static void Run()
        {
            PrintJob printJob = new PrintJob(Printer.Default, Util.GetPath("Resources/DocumentA.pdf"));
            printJob.PrintOptions.Resolution = ResolutionList.High;
            printJob.Print();
        }
    }
}
