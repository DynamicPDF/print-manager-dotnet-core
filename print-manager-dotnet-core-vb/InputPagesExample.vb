Imports ceTe.DynamicPDF.Printing


Friend Class InputPagesExample

    Public Shared Sub Run()

        Dim printJob As New PrintJob(Printer.Default)
        Dim inputPdf As New InputPdf(Util.GetPath("Resources/DocumentA.pdf"))

        Dim firstPage As InputPdfPage = inputPdf.Pages(0)
        Dim fourthPage As InputPdfPage = inputPdf.Pages(3)

        printJob.Pages.Add(firstPage)
        printJob.Pages.Add(fourthPage)

        printJob.Print()

    End Sub

End Class
