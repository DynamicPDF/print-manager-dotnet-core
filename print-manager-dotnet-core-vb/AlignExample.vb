Imports ceTe.DynamicPDF.Printing

Public Class AlignExample
    Public Shared Sub RunVerticalAlign()
        ' Create a print job with the document to be printed to the default printer
        Dim MyPrintJob As PrintJob = New PrintJob(Printer.Default, Util.GetPath("Resources/DocumentA.pdf"))

        ' Set PrintOptions with vertical align
        MyPrintJob.PrintOptions.Scaling = New PercentagePageScaling(0.5F)
        MyPrintJob.PrintOptions.VerticalAlign = VerticalAlign.Bottom

        ' Print the print job
        MyPrintJob.Print()
    End Sub


    Public Shared Sub RunHorizontalAlign()
        ' Create a print job with the document to be printed to the default printer
        Dim MyPrintJob As PrintJob = New PrintJob(Printer.Default, Util.GetPath("Resources/DocumentA.pdf"))

        ' Set PrintOptions with Horizontal align
        MyPrintJob.PrintOptions.Scaling = New PercentagePageScaling(0.5F)
        MyPrintJob.PrintOptions.HorizontalAlign = HorizontalAlign.Center

        ' Print the print job
        MyPrintJob.Print()
    End Sub
End Class
