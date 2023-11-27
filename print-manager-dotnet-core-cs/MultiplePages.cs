using ceTe.DynamicPDF.Printing;

namespace print_manager_dotnet_core_cs
{
    class MultiplePages
    {
        public static void Run()
        {
            PrintJob printJob = new PrintJob(Printer.Default);
            printJob.Pages.Add(Util.GetPath("Resources/DocumentA1.pdf"));
            printJob.Pages.Add(Util.GetPath("Resources/DocumentB1.pdf"));
            printJob.Pages.Add(Util.GetPath("Resources/DocumentC1.pdf"));
            printJob.Pages.Add(Util.GetPath("Resources/DocumentD1.pdf"));

            printJob.Print();

        }
    }
}
