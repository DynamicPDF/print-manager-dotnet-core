Imports ceTe.DynamicPDF.Printing

Public Class SimplePrint
    Shared Sub Run()
        ' Create a print job with the document to be printed to the default printer
        Dim MyPrintJob As PrintJob = New PrintJob(Printer.Default, Util.GetPath("Resources/DocumentA.pdf"))

        ' Print the print job
        MyPrintJob.Print()
    End Sub
End Class
