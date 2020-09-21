Imports ceTe.DynamicPDF.Printing

Public Class PageScalingExample
    Public Shared Sub RunActualPaperScaling()
        Dim pdf As InputPdf = New InputPdf(Util.GetPath("Resources/DocumentA.pdf"))

        ' Create a print job with the document to be printed to the default printer
        Dim MyPrintJob As PrintJob = New PrintJob(Printer.Default)
        MyPrintJob.Pages.Add(pdf)
        MyPrintJob.PrintOptions.Scaling = PageScaling.ActualSize

        ' Print the print job
        MyPrintJob.Print()
    End Sub

    Public Shared Sub RunMultiPageScaling()
        Dim pdf As InputPdf = New InputPdf(Util.GetPath("Resources/DocumentA.pdf"))

        ' Create a print job with the document to be printed to the default printer
        Dim MyPrintJob As PrintJob = New PrintJob(Printer.Default)
        MyPrintJob.Pages.Add(pdf)

        ' Set MultipagePageScaling
        MyPrintJob.PrintOptions.Scaling = New MultipagePageScaling(4, 2)

        ' Print the print job
        MyPrintJob.Print()
    End Sub

    Public Shared Sub RunPageEdgeScaling()
        Dim pdf As InputPdf = New InputPdf(Util.GetPath("Resources/DocumentA.pdf"))

        ' Create a print job with the document to be printed to the default printer
        Dim MyPrintJob As PrintJob = New PrintJob(Printer.Default)
        MyPrintJob.Pages.Add(pdf)

        ' Set AutoPageScaling
        MyPrintJob.PrintOptions.Scaling = New AutoPageScaling(ScaleTo.PageEdges)

        ' Print the print job
        MyPrintJob.Print()
    End Sub

    Public Shared Sub RunPercentageScaling()
        Dim pdf As InputPdf = New InputPdf(Util.GetPath("Resources/DocumentA.pdf"))

        ' Create a print job with the document to be printed to the default printer
        Dim MyPrintJob As PrintJob = New PrintJob(Printer.Default)
        MyPrintJob.Pages.Add(pdf)

        ' Set PercentagePageScaling
        MyPrintJob.PrintOptions.Scaling = New PercentagePageScaling(0.75F)

        ' Print the print job
        MyPrintJob.Print()
    End Sub
End Class
