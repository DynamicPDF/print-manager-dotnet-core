Imports ceTe.DynamicPDF.Printing

Public Class DuplexExample
    Public Shared Sub RunHorizontalDuplex()
        ' Create a print job with the document to be printed to the default printer
        Dim MyPrintJob As PrintJob = New PrintJob(Printer.Default, Util.GetPath("Resources/DocumentA.pdf"))

        ' Set PrintOptions with DuplexMode
        MyPrintJob.PrintOptions.Scaling = New PercentagePageScaling(0.5F)
        MyPrintJob.PrintOptions.DuplexMode = DuplexMode.DuplexHorizontal

        ' Print the print job
        MyPrintJob.Print()
    End Sub

    Public Shared Sub RunSimplex()
        ' Create a print job with the document to be printed to the default printer
        Dim MyPrintJob As PrintJob = New PrintJob(Printer.Default, Util.GetPath("Resources/DocumentA.pdf"))

        ' Set PrintOptions with DuplexMode
        MyPrintJob.PrintOptions.Scaling = New PercentagePageScaling(0.5F)
        MyPrintJob.PrintOptions.DuplexMode = DuplexMode.Simplex

        ' Print the print job
        MyPrintJob.Print()
    End Sub

    Public Shared Sub RunVerticalDuplex()
        ' Create a print job with the document to be printed to the default printer
        Dim MyPrintJob As PrintJob = New PrintJob(Printer.Default, Util.GetPath("Resources/DocumentA.pdf"))

        ' Set PrintOptions with DuplexMode
        MyPrintJob.PrintOptions.Scaling = New PercentagePageScaling(0.5F)
        MyPrintJob.PrintOptions.DuplexMode = DuplexMode.DuplexVertical

        ' Print the print job
        MyPrintJob.Print()
    End Sub
End Class
