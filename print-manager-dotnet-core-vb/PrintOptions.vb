Imports ceTe.DynamicPDF.Printing

Public Class PrintOptions
    Public Shared Sub Run()
        ' Create a print job with the document to be printed to the default printer
        Dim MyPrintJob As PrintJob = New PrintJob(Printer.Default, Util.GetPath("Resources/DocumentA.pdf"), 3, 3)

        ' PrintOptions to set Resolution
        MyPrintJob.PrintOptions.Resolution = ResolutionList.High

        ' PrintOptions to set PrintPriority
        MyPrintJob.PrintPriority = 2

        ' PrintOptions to set Scaling
        MyPrintJob.PrintOptions.Scaling = New PercentagePageScaling(0.5F)

        ' PrintOptions to set Orientation
        MyPrintJob.PrintOptions.Orientation.Type = OrientationType.Portrait

        ' PrintOptions to set Color
        If MyPrintJob.Printer.Color Then
            MyPrintJob.PrintOptions.Color = True
        End If

        ' Print the print job
        MyPrintJob.Print()
    End Sub
End Class
