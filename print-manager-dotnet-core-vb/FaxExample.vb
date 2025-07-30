Imports ceTe.DynamicPDF.Printing

Namespace print_manager_dotnet_core_vb
    Public Class FaxExample
        Public Shared Sub Run()
            Dim faxJob As New FaxPrintJob("My Fax Machine", "555-465-1177", Util.GetPath("Resources/DocumentA.pdf"))
            faxJob.Print()
        End Sub
    End Class
End Namespace

