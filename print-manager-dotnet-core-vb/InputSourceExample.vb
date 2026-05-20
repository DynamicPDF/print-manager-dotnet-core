Imports ceTe.DynamicPDF.Printing
Imports System
Friend Class InputSourceExample
    Public Shared Sub Run()
        Dim inputPdf As New InputPdf(Util.GetPath("Resources/DocumentA.pdf"), "password")

        Console.WriteLine("==== properties ====")
        Console.WriteLine("Author: " & inputPdf.Author)
        Console.WriteLine("Keywords: " & inputPdf.Keywords)
        Console.WriteLine("Title: " & inputPdf.Title)

        Dim printJob As New PrintJob(Printer.Default, inputPdf)
        printJob.Print()
    End Sub
End Class
