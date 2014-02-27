Public Class ElementObjectWithSimge
    Inherits ElementObject

#Region "LocalVariables"
    Private Simge_ As String
    'Private ElementNesnesi_ As ElementObject
    Private Gorunum_ As DisplayDesign
#End Region

#Region "Properties"
    Public Property Simge() As String
        Get
            Return Me.Simge_
        End Get
        Set(ByVal value As String)
            Me.Simge_ = value
        End Set
    End Property
    'Public Property ElementNesnesi() As ElementObject
    '    Get
    '        Return Me.ElementNesnesi_
    '    End Get
    '    Set(ByVal value As ElementObject)
    '        Me.ElementNesnesi_ = value
    '    End Set
    'End Property
    Public Property Gorunum() As DisplayDesign
        Get
            Return Me.Gorunum_
        End Get
        Set(ByVal value As DisplayDesign)
            Me.Gorunum_ = value
        End Set
    End Property

#End Region

#Region "Constructor"
    Public Sub New()

    End Sub

    Public Sub New(ByVal ElementNesnesi As ElementObject, ByVal Simge As String, ByVal GorunumDuzeni As DisplayDesign)
        'Me.ElementNesnesi_ = ElementNesnesi
        Me.Simge_ = Simge
        Me.AtomAgirlik = ElementNesnesi.AtomAgirlik
        Me.AtomNo = ElementNesnesi.AtomNo
        Me.Desc = ElementNesnesi.Desc
        Me.Grup = ElementNesnesi.Grup
        Me.Isim = ElementNesnesi.Isim
        Me.Periyot = ElementNesnesi.Periyot
        Me.Gorunum_ = GorunumDuzeni
    End Sub
#End Region

    Public Overrides Function ToString() As String
        Dim Value As String = ""

        'Select Case Gorunum_
        '    Case DisplayDesign.Simge
        '        Value = Me.Simge_.ToString
        '    Case DisplayDesign.Isim
        '        Value = Me.ElementNesnesi.Isim.ToString
        '    Case DisplayDesign.Simge_Isim
        '        Value = Me.Simge_.ToString & "-" & Me.ElementNesnesi.Isim.ToString
        '    Case DisplayDesign.Simge_AtomNo
        '        Value = Me.Simge_.ToString & "-" & Me.ElementNesnesi.AtomNo.ToString
        '    Case DisplayDesign.AtomNo_Simge
        '        Value = Me.ElementNesnesi.AtomNo.ToString & "-" & Me.Simge_.ToString
        '    Case DisplayDesign.AtomNo_Simge_Isim
        '        Value = Me.ElementNesnesi.AtomNo.ToString & "-" & Me.Simge_ & "-" & Me.ElementNesnesi.Isim.ToString
        '    Case DisplayDesign.Grup_Simge_Isim
        '        Value = Me.ElementNesnesi.Grup.ToString & "-" & Me.Simge_ & "-" & Me.ElementNesnesi.Isim.ToString
        '    Case DisplayDesign.Periyot_Simge_Isim
        '        Value = Me.ElementNesnesi.Periyot.ToString & ".Periyot-" & Me.Simge_.ToString & "-" & Me.ElementNesnesi.Isim.ToString
        '    Case DisplayDesign.Simge_Isim_Grup
        '        Value = Me.Simge_.ToString & "-" & Me.ElementNesnesi.Isim.ToString & "-" & Me.ElementNesnesi.Grup.ToString
        '    Case DisplayDesign.Simge_Isim_Periyot
        '        Value = Me.Simge_.ToString & "-" & Me.ElementNesnesi.Isim.ToString & "-" & Me.ElementNesnesi.Periyot.ToString & ".Periyot"
        'End Select

        '================================================
        Select Case Gorunum_
            Case DisplayDesign.Simge
                Value = Me.Simge_.ToString
            Case DisplayDesign.Isim
                Value = Me.Isim.ToString
            Case DisplayDesign.Simge_Isim
                Value = Me.Simge_.ToString & "-" & Me.Isim.ToString
            Case DisplayDesign.Simge_AtomNo
                Value = Me.Simge_.ToString & "-" & Me.AtomNo.ToString
            Case DisplayDesign.AtomNo_Simge
                Value = Me.AtomNo.ToString & "-" & Me.Simge_.ToString
            Case DisplayDesign.AtomNo_Simge_Isim
                Value = Me.AtomNo.ToString & "-" & Me.Simge_ & "-" & Me.Isim.ToString
            Case DisplayDesign.Grup_Simge_Isim
                Value = Me.Grup.ToString & "-" & Me.Simge_ & "-" & Me.Isim.ToString
            Case DisplayDesign.Periyot_Simge_Isim
                Value = Me.Periyot.ToString & ".Periyot-" & Me.Simge_.ToString & "-" & Me.Isim.ToString
            Case DisplayDesign.Simge_Isim_Grup
                Value = Me.Simge_.ToString & "-" & Me.Isim.ToString & "-" & Me.Grup.ToString
            Case DisplayDesign.Simge_Isim_Periyot
                Value = Me.Simge_.ToString & "-" & Me.Isim.ToString & "-" & Me.Periyot.ToString & ".Periyot"
        End Select

        Return Value
    End Function
End Class

Public Enum DisplayDesign
    [Simge] = 0
    [Isim] = 1
    [Simge_Isim] = 2
    [Simge_AtomNo] = 3
    [AtomNo_Simge] = 4
    [AtomNo_Simge_Isim] = 5
    [Grup_Simge_Isim] = 6
    [Periyot_Simge_Isim] = 7
    [Simge_Isim_Grup] = 8
    [Simge_Isim_Periyot] = 9
End Enum