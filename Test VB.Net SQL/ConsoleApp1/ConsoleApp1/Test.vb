Option Explicit On
Option Strict On

'Module for Common allows for DataAccess.Common instead of DataAccess.Common.Common
Imports DataAccess.Common


Public Class Test
  'Public Class Test


  ' must be shared inside of class
  'Public Shared Sub Main()
  Public Shared Sub Main()

    Dim testString As String = "'Test'"

    Console.WriteLine("Hello World")

    Console.WriteLine(testString)

    Console.WriteLine(ToDBString(testString))




  End Sub
End Class
