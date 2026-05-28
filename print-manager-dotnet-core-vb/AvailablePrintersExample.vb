Imports ceTe.DynamicPDF.Printing
Imports System

Friend Class AvailablePrintersExample

    Public Shared Sub Run()

        For Each printer As Printer In Printer.GetLocalPrinters()
            Console.WriteLine(printer.Name)
        Next

    End Sub

End Class
