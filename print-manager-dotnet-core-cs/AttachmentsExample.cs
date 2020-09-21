using System;
using ceTe.DynamicPDF.Printing;

namespace print_manager_dotnet_core_cs
{
    class AttachmentsExample
    {
        public static void Run()
        {
            // Get the source PDF which has the attachments as byte data
            byte[] pdfArray = System.IO.File.ReadAllBytes(Util.GetPath("Resources/PdfWithAttachments.pdf"));
            
            // Create an InputPdf object using the PDF byte data
            InputPdf inputPdf = new InputPdf(pdfArray);

            // Loop through the attachments
            for (int i = 0; i < inputPdf.Attachments.Length; i++)
            {
                if (inputPdf.Attachments[i] != null)
                {
                    InputPdf attachedPdf = inputPdf.Attachments[i].TryGetPdf();
                    if (attachedPdf != null)
                    {
                        // Create a print job with the document to be printed to the default printer
                        PrintJob printJob = new PrintJob(Printer.Default, attachedPdf);

                        // Print the print job
                        printJob.Print();
                    }
                }
            }
        }
    }
}
