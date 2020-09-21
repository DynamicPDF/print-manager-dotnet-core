Imports ceTe.DynamicPDF.Printing

Public Class ReadPrinterDetails
    Public Shared Sub Run()
        Dim MyPrintJob As PrintJob = New PrintJob(Printer.Default)

        Console.WriteLine("Options for: " + MyPrintJob.Printer.Name)
        Console.WriteLine("Collate " + MyPrintJob.Printer.Collate.ToString())
        Console.WriteLine("Duplex " + MyPrintJob.Printer.Duplex.ToString())
        Console.WriteLine("MaxCopies " + MyPrintJob.Printer.MaxCopies.ToString())
        Console.WriteLine("MaxPaperHeight " + MyPrintJob.Printer.MaxPaperHeight.ToString())
        Console.WriteLine("MaxPaperWidth " + MyPrintJob.Printer.MaxPaperWidth.ToString())
        Console.WriteLine("MinPaperHeight " + MyPrintJob.Printer.MinPaperHeight.ToString())
        Console.WriteLine("MinPaperWidth " + MyPrintJob.Printer.MinPaperWidth.ToString())
        ListPaperSizes(MyPrintJob.Printer.PaperSizes)
        ListPaperSources(MyPrintJob.Printer.PaperSources)
        ListResolutions(MyPrintJob.Printer.Resolutions)
    End Sub

    Shared Sub ListPaperSizes(paperSizes As PaperSizeList)
        Console.WriteLine("List of Paper Sizes: ")
        For i As Integer = 0 To paperSizes.Count - 1
            Console.WriteLine(" " & paperSizes(i).Name & " : Width= " & UnitConverter.PointsToInches(paperSizes(i).Width.ToString()) & " : Height = " & UnitConverter.PointsToInches(paperSizes(i).Height.ToString()))
        Next
    End Sub

    Shared Sub ListPaperSources(paperSources As PaperSourceList)
        Console.WriteLine("List of Paper Sources ")
        For i As Integer = 0 To paperSources.Count - 1
            Console.WriteLine(" " & paperSources(i).Name)
        Next
    End Sub

    Shared Sub ListResolutions(resolutions As ResolutionList)
        Console.WriteLine("List of Resolution ")
        For i As Integer = 0 To resolutions.Count - 1
            Console.WriteLine(" " & resolutions(i).HorizontalDpi.ToString() & " dpi " & resolutions(i).VerticalDpi.ToString() & " dpi")
        Next
    End Sub
End Class
