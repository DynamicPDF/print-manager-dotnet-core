Imports ceTe.DynamicPDF.Printing

Public Class FaxExample
    Public Shared Sub Run()
        Dim faxJob As New FaxPrintJob("My Fax Machine", "555-465-1177", Util.GetPath("Resources/DocumentA.pdf"))
        'faxJob.Print()
    End Sub
End Class

