Option Explicit On
Option Strict On

'Module for Common allows for DataAccess.Common instead of DataAccess.Common.Common
Imports DataAccess.Common
Imports bus = Business.Student
Imports dat = Data.Student


Public Class Test
  'Public Class Test


  ' must be shared inside of class
  'Public Shared Sub Main()
  Public Shared Sub Main()

    Dim testString As String = "'Test'"

    Console.WriteLine("Hello World")
    Console.WriteLine(testString)
    Console.WriteLine(ToDBString(testString))

    ' Declare Policy Collection
    Dim datStudents As dat.Students = Nothing

    Dim busStudent As New bus.Student

    datStudents = busStudent.Find(18422186)


    If datStudents IsNot Nothing Then
      For Each datStudent As dat.Student In datStudents
        Console.WriteLine(datStudent.PrimKeyID)
      Next
    End If




  End Sub
End Class
