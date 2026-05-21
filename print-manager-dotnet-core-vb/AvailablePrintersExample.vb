Imports ceTe.DynamicPDF.Printing
Imports System

Namespace print_manager_dotnet_core_vb
    Friend Class AvailablePrintersExample

        Public Shared Sub Run()

            For Each printer As Printer In Printer.GetLocalPrinters()
                Console.WriteLine(printer.Name)
            Next

        End Sub

    End Class
End Namespace
