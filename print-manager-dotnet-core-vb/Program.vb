Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Printing Examples Started")

        SimplePrint.Run()

        ' Uncomment examples below to run them

        'AlignExample.RunHorizontalAlign()
        'AlignExample.RunVerticalAlign()

        'AttachmentsExample.Run()

        'DuplexExample.RunHorizontalDuplex()
        'DuplexExample.RunSimplex()
        'DuplexExample.RunVerticalDuplex()

        'EventsExample.Run()

        'MultiplePagesPerSheet.Run()

        'PageScalingExample.RunActualPaperScaling()
        'PageScalingExample.RunMultiPageScaling()
        'PageScalingExample.RunPageEdgeScaling()
        'PageScalingExample.RunPercentageScaling()

        'PrintOptions.Run()

        'ReadPrinterDetails.Run()

        Console.WriteLine("Printing Examples Completed")
        Console.ReadKey()
    End Sub
End Module
