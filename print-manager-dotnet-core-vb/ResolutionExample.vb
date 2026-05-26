Imports ceTe.DynamicPDF.Printing

Friend Class ResolutionExample

        Public Shared Sub Run()

            Dim printJob As New PrintJob(
                Printer.Default,
                Util.GetPath("Resources/DocumentA.pdf"))

            printJob.PrintOptions.Resolution = ResolutionList.High

            printJob.Print()

        End Sub

    End Class
