Imports ceTe.DynamicPDF.Printing

Friend Class SpecificPrinter

        Public Shared Sub Run()
            Dim printerName As String = String.Empty

            Console.WriteLine("This example shows using a specific printer using DynamicPDF Print Manager")
            Console.WriteLine()
            Console.WriteLine("Enter the printer name:")

            printerName = Console.ReadLine()

            ' Create a print job with the document to be printed to the specified printer.
            Dim printJob As New PrintJob(printerName, Util.GetPath("Resources/DocumentA.pdf"))

            ' Print the print job.
            printJob.Print()
        End Sub

    End Class
