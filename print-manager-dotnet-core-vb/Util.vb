Imports System.Text.RegularExpressions

Public Class Util
    Shared Function GetPath(inputFileName As String) As String
        Dim exePath As String = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase)
        Dim appPathMatcher As Regex = New Regex("(?<!fil)[A-Za-z]:\\+[\S\s]*?(?=\\+bin)")
        Dim appRoot As String = appPathMatcher.Match(exePath).Value
        Return System.IO.Path.Combine(appRoot, inputFileName)
    End Function

End Class
