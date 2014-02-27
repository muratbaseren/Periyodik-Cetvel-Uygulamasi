Public Class Form3

    Public Sub DosyaAc(ByVal DosyaKonumu As String, ByVal FormText As String)
        Me.WebBrowser1.Navigate(DosyaKonumu)
        Me.Text = FormText
    End Sub
End Class