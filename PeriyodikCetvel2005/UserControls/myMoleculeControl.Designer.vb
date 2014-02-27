<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class myMoleculeControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtToplam = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lsvListe = New System.Windows.Forms.ListView
        Me.clmSec = New System.Windows.Forms.ColumnHeader
        Me.clmAtom = New System.Windows.Forms.ColumnHeader
        Me.clmAdet = New System.Windows.Forms.ColumnHeader
        Me.clmKismiToplam = New System.Windows.Forms.ColumnHeader
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtToplam
        '
        Me.txtToplam.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtToplam.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtToplam.Location = New System.Drawing.Point(55, 6)
        Me.txtToplam.Name = "txtToplam"
        Me.txtToplam.Size = New System.Drawing.Size(154, 21)
        Me.txtToplam.TabIndex = 8
        Me.txtToplam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label9.Location = New System.Drawing.Point(1, 11)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 13)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Toplam :"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtToplam)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 124)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.Panel1.Size = New System.Drawing.Size(209, 34)
        Me.Panel1.TabIndex = 9
        '
        'lsvListe
        '
        Me.lsvListe.CheckBoxes = True
        Me.lsvListe.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clmSec, Me.clmAtom, Me.clmAdet, Me.clmKismiToplam})
        Me.lsvListe.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lsvListe.FullRowSelect = True
        Me.lsvListe.Location = New System.Drawing.Point(0, 0)
        Me.lsvListe.Name = "lsvListe"
        Me.lsvListe.Size = New System.Drawing.Size(209, 124)
        Me.lsvListe.TabIndex = 10
        Me.lsvListe.UseCompatibleStateImageBehavior = False
        Me.lsvListe.View = System.Windows.Forms.View.Details
        '
        'clmSec
        '
        Me.clmSec.Text = "Seç"
        Me.clmSec.Width = 35
        '
        'clmAtom
        '
        Me.clmAtom.Text = "Atom"
        Me.clmAtom.Width = 40
        '
        'clmAdet
        '
        Me.clmAdet.Text = "Adet"
        Me.clmAdet.Width = 40
        '
        'clmKismiToplam
        '
        Me.clmKismiToplam.Text = "Kýsmi Toplam"
        Me.clmKismiToplam.Width = 80
        '
        'myMoleculeControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lsvListe)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "myMoleculeControl"
        Me.Size = New System.Drawing.Size(209, 158)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtToplam As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lsvListe As System.Windows.Forms.ListView
    Friend WithEvents clmSec As System.Windows.Forms.ColumnHeader
    Friend WithEvents clmAtom As System.Windows.Forms.ColumnHeader
    Friend WithEvents clmAdet As System.Windows.Forms.ColumnHeader
    Friend WithEvents clmKismiToplam As System.Windows.Forms.ColumnHeader

End Class
