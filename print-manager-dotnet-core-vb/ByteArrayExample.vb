Imports ceTe.DynamicPDF.Printing

Namespace print_manager_dotnet_core_vb
    Class ByteArrayExample
        Public Shared Sub Run()
            Dim pdfBytes As Byte() = System.IO.File.ReadAllBytes(Util.GetPath("Resources/DocumentA.pdf"))

            Dim pdf As New InputPdf(pdfBytes)
            Dim printJob As New PrintJob(Printer.Default, pdf)

            printJob.Print()
        End Sub
    End Class
End Namespace
