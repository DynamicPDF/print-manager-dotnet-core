Imports System.Drawing
Imports ceTe.DynamicPDF.Printing

Public Class MultiplePagesPerSheet
    Public Shared Sub Run()
        ' Create a print job with the document to be printed to the default printer
        Dim MyPrintJob As PrintJob = New PrintJob(Printer.Default)

        ' Add pages to the print job from multiple PDFs
        MyPrintJob.Pages.Add(Util.GetPath("Resources/DocumentA1.pdf"))
        MyPrintJob.Pages.Add(Util.GetPath("Resources/DocumentB1.pdf"))
        MyPrintJob.Pages.Add(Util.GetPath("Resources/DocumentC1.pdf"))
        MyPrintJob.Pages.Add(Util.GetPath("Resources/DocumentD1.pdf"))

        ' Create a MultiplepagePageScalling class And set the properties
        Dim MultipagePageScaling As MultipagePageScaling = New MultipagePageScaling(4, 2)
        MultipagePageScaling.Border = New Border(Color.Green, 2)
        MultipagePageScaling.Margin = New Margin(5, 5, 5, 5)
        MultipagePageScaling.Spacing = New Spacing(2, 2)
        MultipagePageScaling.UniformScaling = True

        ' Add the class to the PrintOptions Scaling property
        MyPrintJob.PrintOptions.Scaling = MultipagePageScaling

        ' Print the print job
        MyPrintJob.Print()
    End Sub
End Class
