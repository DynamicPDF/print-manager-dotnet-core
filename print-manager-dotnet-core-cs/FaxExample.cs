using ceTe.DynamicPDF.Printing;

namespace print_manager_dotnet_core_cs
{
    public class FaxExample
    {
        public static void Run()
        {
            FaxPrintJob faxJob = new FaxPrintJob("My Fax Machine", "555-465-1177", Util.GetPath("Resources/DocumentA.pdf"));
            faxPrintJob.Print();
        }
    }
}
