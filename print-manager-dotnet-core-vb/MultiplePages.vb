Imports ceTe.DynamicPDF.Printing

Namespace print_manager_dotnet_core_vb
    Class MultiplePages

        Public Shared Sub Run()
            Dim printJob As New PrintJob(Printer.Default)
            printJob.Pages.Add(Util.GetPath("Resources/DocumentA1.pdf"))
            printJob.Pages.Add(Util.GetPath("Resources/DocumentB1.pdf"))
            printJob.Pages.Add(Util.GetPath("Resources/DocumentC1.pdf"))
            printJob.Pages.Add(Util.GetPath("Resources/DocumentD1.pdf"))

            printJob.Print()
        End Sub

    End Class
End Namespace
