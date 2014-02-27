Public Class ElementalButton
    Inherits Button

#Region "LocalVariables"
    Private ElementNesnesi_ As ElementObject
#End Region

#Region "Properties"
    Public Property ElementNesnesi() As ElementObject
        Get
            Return Me.ElementNesnesi_
        End Get
        Set(ByVal value As ElementObject)
            Me.ElementNesnesi_ = value
        End Set
    End Property
#End Region

#Region "Constructor"
    Public Sub New()

    End Sub

    Public Sub New(ByVal ElementOzellikleri As ElementObject)
        Me.ElementNesnesi_ = ElementOzellikleri
    End Sub
#End Region

End Class