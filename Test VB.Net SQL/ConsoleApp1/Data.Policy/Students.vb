Public Class Students

  'Dim studentsList As New List(Of Student)

  'Sub New()

  'End Sub

  'Public Sub Add(studentObj As Student)
  'studentsList.Add(studentObj)
  ' End Sub

  'Public Sub Remove(studentObj As Student)

  ' End Sub

  Inherits System.Collections.ObjectModel.Collection(Of Student)


  Public Sub New()
    MyBase.New(New System.Collections.Generic.List(Of Student))
  End Sub


  Public ReadOnly Property ItemByID(ByVal StudentID As Integer) As Student
    Get

      For Each datStudent As Student In Me
        If datStudent.PrimKeyID = StudentID Then
          Return datStudent
        End If
      Next

      Return Nothing

    End Get
  End Property

  Public Sub RemoveByID(ByVal StudentID As Integer)

    For Each datStudent As Student In Me
      If datStudent.PrimKeyID = StudentID Then
        Remove(datStudent)
        Exit For
      End If
    Next

  End Sub



End Class
