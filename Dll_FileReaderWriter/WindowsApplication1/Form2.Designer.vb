<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.btnKaydet = New System.Windows.Forms.Button
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.btnXML_Oku = New System.Windows.Forms.Button
        Me.btnXML_Yaz = New System.Windows.Forms.Button
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(351, 158)
        Me.DataGridView1.TabIndex = 0
        '
        'btnKaydet
        '
        Me.btnKaydet.Location = New System.Drawing.Point(263, 176)
        Me.btnKaydet.Name = "btnKaydet"
        Me.btnKaydet.Size = New System.Drawing.Size(100, 23)
        Me.btnKaydet.TabIndex = 1
        Me.btnKaydet.Text = "btnKaydet"
        Me.btnKaydet.UseVisualStyleBackColor = True
        '
        'btnXML_Oku
        '
        Me.btnXML_Oku.Location = New System.Drawing.Point(12, 176)
        Me.btnXML_Oku.Name = "btnXML_Oku"
        Me.btnXML_Oku.Size = New System.Drawing.Size(87, 23)
        Me.btnXML_Oku.TabIndex = 2
        Me.btnXML_Oku.Text = "btnXML_Oku"
        Me.btnXML_Oku.UseVisualStyleBackColor = True
        '
        'btnXML_Yaz
        '
        Me.btnXML_Yaz.Location = New System.Drawing.Point(105, 176)
        Me.btnXML_Yaz.Name = "btnXML_Yaz"
        Me.btnXML_Yaz.Size = New System.Drawing.Size(87, 23)
        Me.btnXML_Yaz.TabIndex = 2
        Me.btnXML_Yaz.Text = "btnXML_Yaz"
        Me.btnXML_Yaz.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(375, 212)
        Me.Controls.Add(Me.btnXML_Yaz)
        Me.Controls.Add(Me.btnXML_Oku)
        Me.Controls.Add(Me.btnKaydet)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnKaydet As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents btnXML_Oku As System.Windows.Forms.Button
    Friend WithEvents btnXML_Yaz As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
End Class
