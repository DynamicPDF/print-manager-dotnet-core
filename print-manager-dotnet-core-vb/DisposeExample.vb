Imports ceTe.DynamicPDF.Printing

Friend Class DisposeExample

    Public Shared Sub Run()

        Dim printJob As New PrintJob(
                Printer.Default,
                Util.GetPath("Resources/DocumentA.pdf"))

        printJob.Print()
        printJob.Dispose()

        Dim pdf As New InputPdf(
                Util.GetPath("Resources/DocumentA.pdf"))

        printJob = New PrintJob(Printer.Default, pdf)

        printJob.Print()

        pdf.Dispose()

    End Sub

End Class
