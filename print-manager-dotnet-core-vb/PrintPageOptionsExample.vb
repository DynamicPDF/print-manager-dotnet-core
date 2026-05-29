Imports ceTe.DynamicPDF.Printing

Friend Class PrintPageOptionsExample
    Public Shared Sub Run()
        Dim printJob As New PrintJob(Printer.Default, Util.GetPath("Resources/DocumentA.pdf"))

        If printJob.Printer.Color Then
            printJob.PrintOptions.Color = True
        End If

        printJob.PrintOptions.Copies = 2
        printJob.PrintOptions.Scaling = PageScaling.ActualSize
        printJob.PrintOptions.PrintAnnotations = False

        Dim printJobPage As PrintJobPage = printJob.Pages(printJob.Pages.Count - 1)
        Dim pagePrintOptions As PrintJobPagePrintOptions = printJobPage.PrintOptions

        pagePrintOptions.Inherit = False
        pagePrintOptions.Scaling = New PercentagePageScaling(0.5F)
        pagePrintOptions.HorizontalAlign = HorizontalAlign.Left
        pagePrintOptions.PrintAnnotations = True

        printJob.Print()
    End Sub
End Class
