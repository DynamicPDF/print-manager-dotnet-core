
using ceTe.DynamicPDF.Printing;

namespace print_manager_dotnet_core_cs
{
    internal class PageRangeExample
    {
        public static void Run()
        {
            FromConstr();
            FromConstr();
        }

        public static void FromConstr()
        {
            PrintJob printJob = new PrintJob(Printer.Default, Util.GetPath("Resources/DocumentA.pdf"), 1, 3);
            printJob.Print();
        }
        public static void FromAddPage() {
            PrintJob printJob = new PrintJob(Printer.Default);
            printJob.Pages.Add(Util.GetPath("Resources/DocumentA.pdf"), 1, 3);
            printJob.Pages.Add(Util.GetPath("Resources/DocumentA.pdf"), 2, 1);
            printJob.Print();
        }
    }
}
