<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.cmbGorunum = New System.Windows.Forms.ToolStripComboBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.btnKaydet = New System.Windows.Forms.Button
        Me.btnIptal = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtAciklama = New System.Windows.Forms.TextBox
        Me.cmbPeriyot = New System.Windows.Forms.ComboBox
        Me.cmbGrup = New System.Windows.Forms.ComboBox
        Me.txtBirimAgirlik = New System.Windows.Forms.TextBox
        Me.txtAtomNo = New System.Windows.Forms.TextBox
        Me.txtAtomIsmi = New System.Windows.Forms.TextBox
        Me.txtSimge = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmbElementler = New System.Windows.Forms.ComboBox
        Me.ToolStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.cmbGorunum})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(245, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(57, 22)
        Me.ToolStripLabel1.Text = "Görünüm :"
        '
        'cmbGorunum
        '
        Me.cmbGorunum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGorunum.Items.AddRange(New Object() {"Simge", "Isim", "Simge + Isim", "Simge + AtomNo", "AtomNo + Simge", "AtomNo + Simge + Isim", "Grup + Simge + Isim", "Periyot + Simge + Isim", "Simge + Isim + Grup", "Simge + Isim + Periyot"})
        Me.cmbGorunum.Name = "cmbGorunum"
        Me.cmbGorunum.Size = New System.Drawing.Size(158, 25)
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 25)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(10)
        Me.Panel1.Size = New System.Drawing.Size(245, 380)
        Me.Panel1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnKaydet)
        Me.Panel2.Controls.Add(Me.btnIptal)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(10, 334)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(225, 36)
        Me.Panel2.TabIndex = 7
        '
        'btnKaydet
        '
        Me.btnKaydet.Location = New System.Drawing.Point(3, 6)
        Me.btnKaydet.Name = "btnKaydet"
        Me.btnKaydet.Size = New System.Drawing.Size(132, 23)
        Me.btnKaydet.TabIndex = 0
        Me.btnKaydet.Text = "Deðiþiklikleri Kaydet"
        Me.btnKaydet.UseVisualStyleBackColor = True
        '
        'btnIptal
        '
        Me.btnIptal.Location = New System.Drawing.Point(141, 6)
        Me.btnIptal.Name = "btnIptal"
        Me.btnIptal.Size = New System.Drawing.Size(75, 23)
        Me.btnIptal.TabIndex = 0
        Me.btnIptal.Text = "Ýptal"
        Me.btnIptal.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtAciklama)
        Me.GroupBox2.Controls.Add(Me.cmbPeriyot)
        Me.GroupBox2.Controls.Add(Me.cmbGrup)
        Me.GroupBox2.Controls.Add(Me.txtBirimAgirlik)
        Me.GroupBox2.Controls.Add(Me.txtAtomNo)
        Me.GroupBox2.Controls.Add(Me.txtAtomIsmi)
        Me.GroupBox2.Controls.Add(Me.txtSimge)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Location = New System.Drawing.Point(10, 77)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(8)
        Me.GroupBox2.Size = New System.Drawing.Size(225, 257)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Element Detaylarý"
        '
        'txtAciklama
        '
        Me.txtAciklama.Location = New System.Drawing.Point(95, 179)
        Me.txtAciklama.Multiline = True
        Me.txtAciklama.Name = "txtAciklama"
        Me.txtAciklama.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAciklama.Size = New System.Drawing.Size(121, 57)
        Me.txtAciklama.TabIndex = 9
        '
        'cmbPeriyot
        '
        Me.cmbPeriyot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPeriyot.FormattingEnabled = True
        Me.cmbPeriyot.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7"})
        Me.cmbPeriyot.Location = New System.Drawing.Point(95, 126)
        Me.cmbPeriyot.Name = "cmbPeriyot"
        Me.cmbPeriyot.Size = New System.Drawing.Size(121, 21)
        Me.cmbPeriyot.TabIndex = 8
        '
        'cmbGrup
        '
        Me.cmbGrup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGrup.FormattingEnabled = True
        Me.cmbGrup.Items.AddRange(New Object() {"1A", "2A", "3A", "4A", "5A", "6A", "7A", "8A", "1B", "2B", "3B", "4B", "5B", "6B", "7B"})
        Me.cmbGrup.Location = New System.Drawing.Point(95, 99)
        Me.cmbGrup.Name = "cmbGrup"
        Me.cmbGrup.Size = New System.Drawing.Size(121, 21)
        Me.cmbGrup.TabIndex = 7
        '
        'txtBirimAgirlik
        '
        Me.txtBirimAgirlik.Location = New System.Drawing.Point(95, 153)
        Me.txtBirimAgirlik.Name = "txtBirimAgirlik"
        Me.txtBirimAgirlik.Size = New System.Drawing.Size(121, 20)
        Me.txtBirimAgirlik.TabIndex = 6
        '
        'txtAtomNo
        '
        Me.txtAtomNo.Location = New System.Drawing.Point(95, 21)
        Me.txtAtomNo.Name = "txtAtomNo"
        Me.txtAtomNo.ReadOnly = True
        Me.txtAtomNo.Size = New System.Drawing.Size(121, 20)
        Me.txtAtomNo.TabIndex = 3
        '
        'txtAtomIsmi
        '
        Me.txtAtomIsmi.Location = New System.Drawing.Point(95, 47)
        Me.txtAtomIsmi.Name = "txtAtomIsmi"
        Me.txtAtomIsmi.Size = New System.Drawing.Size(121, 20)
        Me.txtAtomIsmi.TabIndex = 2
        '
        'txtSimge
        '
        Me.txtSimge.Location = New System.Drawing.Point(95, 73)
        Me.txtSimge.Name = "txtSimge"
        Me.txtSimge.Size = New System.Drawing.Size(121, 20)
        Me.txtSimge.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(5, 182)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Açýklama :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(5, 156)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Birim Aðýrlýk :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 129)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Periyot :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Grup :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Atom No :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Atom Ismi :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Simge :"
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(10, 67)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(225, 10)
        Me.Panel3.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbElementler)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(10, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(8)
        Me.GroupBox1.Size = New System.Drawing.Size(225, 57)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Elementler"
        '
        'cmbElementler
        '
        Me.cmbElementler.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbElementler.FormattingEnabled = True
        Me.cmbElementler.Location = New System.Drawing.Point(8, 21)
        Me.cmbElementler.Name = "cmbElementler"
        Me.cmbElementler.Size = New System.Drawing.Size(209, 21)
        Me.cmbElementler.Sorted = True
        Me.cmbElementler.TabIndex = 0
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(245, 405)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form4"
        Me.Text = "Element Düzenleme"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnKaydet As System.Windows.Forms.Button
    Friend WithEvents btnIptal As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbPeriyot As System.Windows.Forms.ComboBox
    Friend WithEvents cmbGrup As System.Windows.Forms.ComboBox
    Friend WithEvents txtBirimAgirlik As System.Windows.Forms.TextBox
    Friend WithEvents txtAtomNo As System.Windows.Forms.TextBox
    Friend WithEvents txtAtomIsmi As System.Windows.Forms.TextBox
    Friend WithEvents txtSimge As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbElementler As System.Windows.Forms.ComboBox
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cmbGorunum As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents txtAciklama As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
