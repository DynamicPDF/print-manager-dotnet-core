Imports ceTe.DynamicPDF.Printing

Public Class EventsExample
    Public Shared Sub Run()
        ' Create a print job with the document to be printed to the default printer
        Dim MyPrintJob As PrintJob = New PrintJob(Printer.Default, Util.GetPath("Resources/DocumentA.pdf"))

        ' PrintJob Events
        AddHandler MyPrintJob.Failed, AddressOf printer_PrintJobFalied
        AddHandler MyPrintJob.Succeeded, AddressOf printer_PrintJobSucceeded
        AddHandler MyPrintJob.Updated, AddressOf printer_PrintJobUpdated


        ' Print the print job
        MyPrintJob.Print()
    End Sub

    Shared Sub printer_PrintJobFalied(obj As Object, e As PrintJobFailedEventArgs)
        Console.WriteLine("Print Failed : JobId = " & e.PrintJob.JobId & " Exception.Message = " & e.Exception.Message)
    End Sub

    Shared Sub printer_PrintJobSucceeded(obj As Object, e As PrintJobEventArgs)
        Console.WriteLine("Print Succeeded : JobId = " & e.PrintJob.JobId)
    End Sub

    Shared Sub printer_PrintJobUpdated(obj As Object, e As PrintJobEventArgs)
        Console.WriteLine("PrintJob Updated: JobId = " & e.PrintJob.JobId & "  PrintStatus = " & e.PrintJob.Status & "  PagesPrinted = " & e.PrintJob.PagesPrinted)
    End Sub
End Class
