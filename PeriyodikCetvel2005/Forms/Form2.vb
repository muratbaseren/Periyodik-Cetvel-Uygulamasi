
Public Class Form2

    Private Rapor As CrystalReport1

    Private Sub Form2_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Rapor.Dispose()
        Me.CrystalReportViewer1.ReportSource = Nothing
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Rapor = New CrystalReport1
        Me.CrystalReportViewer1.ReportSource = Rapor
    End Sub

End Class