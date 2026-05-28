Imports ceTe.DynamicPDF.Printing


Friend Class PageRangeExample

    Public Shared Sub Run()
        FromConstr()
        FromAddPage()
    End Sub

    Public Shared Sub FromConstr()
        Dim printJob As New PrintJob(Printer.Default, Util.GetPath("Resources/DocumentA.pdf"), 1, 3)
        printJob.Print()
    End Sub

    Public Shared Sub FromAddPage()
        Dim printJob As New PrintJob(Printer.Default)

        printJob.Pages.Add(Util.GetPath("Resources/DocumentA.pdf"), 1, 3)
        printJob.Pages.Add(Util.GetPath("Resources/DocumentA.pdf"), 2, 1)

        printJob.Print()
    End Sub

End Class
