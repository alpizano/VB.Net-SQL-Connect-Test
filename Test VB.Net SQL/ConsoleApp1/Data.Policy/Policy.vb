'Module Module1

Public NotInheritable Class Policy

  Private iPolicyNumber As Integer
  Private iPolicyUser As Integer
  Private sPolicyName As String

  Public Sub New(policyNumber As Integer, policyUser As Integer, policyName As String)

    Me.policyNumber = policyNumber
    Me.policyUser = policyUser
    Me.policyName = policyName
  End Sub

  Public Sub New()
    policyNumber = 0
    policyUser = 0
    policyName = ""
  End Sub

  ' Need properties for private values
  Public Property PolicyNumber() As Integer
    Get
      Return Me.iPolicyNumber
    End Get
    Set(value As Integer)
      Me.iPolicyNumber = value
    End Set
  End Property

  Public Property PolicyUser() As Integer
    Get
      Return Me.iPolicyUser
    End Get
    Set(value As Integer)
      Me.iPolicyUser = value
    End Set
  End Property

  Property PolicyName() As String
    Get
      Return Me.sPolicyName
    End Get
    Set(value As String)
      Me.sPolicyName = value
    End Set
  End Property



End Class

'End Module
