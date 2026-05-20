Imports ceTe.DynamicPDF.Printing

Friend Class SecuredExample
        Public Shared Sub Run()
            Dim inputPdf As New InputPdf(Util.GetPath("Resources/secured.pdf"), "password")
            Dim printJob As New PrintJob(Printer.Default, inputPdf)

            printJob.Print()
        End Sub
End Class