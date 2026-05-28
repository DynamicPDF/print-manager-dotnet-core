Imports ceTe.DynamicPDF.Printing
Friend Class PrintAreaExample
    Public Shared Sub Run()
        Dim pdf As New InputPdf(Util.GetPath("Resources/DocumentA.pdf"))
        Dim printJob As New PrintJob(Printer.Default)

        ' Specify print area for the second & third pages and add them to print job.
        Dim printArea As New System.Drawing.Rectangle(0, 0, 600, 400)
        printJob.Pages.Add(pdf, printArea, 2, 2)

        printJob.Print()
    End Sub
End Class
