Imports ceTe.DynamicPDF.Printing

Public Class AttachmentsExample
    Public Shared Sub Run()
        ' Get the source PDF source PDF which has the attachments as byte data
        Dim pdfArray As Byte() = System.IO.File.ReadAllBytes(Util.GetPath("Resources/PdfWithAttachments.pdf"))

        ' Create a InputPdf object using the PDF byte data
        Dim inputPdf As InputPdf = New InputPdf(pdfArray)

        ' Loop through the attachments
        For i As Integer = 0 To inputPdf.Attachments.Length - 1
            If inputPdf.Attachments(i) IsNot Nothing Then
                Dim attachedPdf As InputPdf = inputPdf.Attachments(i).TryGetPdf()
                If attachedPdf IsNot Nothing Then
                    ' Create a print job with the document to be printed to the default printer
                    Dim MyPrintJob As PrintJob = New PrintJob(Printer.Default, attachedPdf)

                    ' Print the print job
                    MyPrintJob.Print()
                End If
            End If
        Next
    End Sub
End Class