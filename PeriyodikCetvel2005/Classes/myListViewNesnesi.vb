Public Class myListViewNesnesi
    Inherits ListViewItem

#Region "LocalVariables"
    Private ElementNesnesi_ As ElementObject
    Private ElementButonu_ As ElementalButton
#End Region

#Region "Properties"
    Public Property ElementButonu() As ElementalButton
        Get
            Return Me.ElementButonu_
        End Get
        Set(ByVal value As ElementalButton)
            Me.ElementButonu_ = value
        End Set
    End Property
#End Region

#Region "Constructor"
    Public Sub New()

    End Sub

    Public Sub New(ByVal ElementalButton As ElementalButton)
        Me.ElementButonu_ = ElementalButton
    End Sub

#End Region

End Class
