<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip
        Me.btnYardimcilar = New System.Windows.Forms.ToolStripDropDownButton
        Me.btnAtomYaricap = New System.Windows.Forms.ToolStripMenuItem
        Me.btnElektronegatiflik = New System.Windows.Forms.ToolStripMenuItem
        Me.btnPeriyodikCetv2 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.btnHesapMakinesi = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.btnElementEdit = New System.Windows.Forms.ToolStripSplitButton
        Me.btnAciklamaEkle = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator
        Me.btnVarsayilanYap = New System.Windows.Forms.ToolStripMenuItem
        Me.toolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.cmbAra = New System.Windows.Forms.ToolStripComboBox
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
        Me.btnAra = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.btnInfo = New System.Windows.Forms.ToolStripDropDownButton
        Me.btnYardim = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator
        Me.btnHakkinda = New System.Windows.Forms.ToolStripMenuItem
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.grpMAHesaplama = New System.Windows.Forms.GroupBox
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.btnSil = New System.Windows.Forms.Button
        Me.btnTemizle = New System.Windows.Forms.Button
        Me.nudAdet = New System.Windows.Forms.NumericUpDown
        Me.Label8 = New System.Windows.Forms.Label
        Me.btnEkle = New System.Windows.Forms.Button
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.NewToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.OpenToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.SaveToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.btnSaveAll = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.PrintToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.btnTabPageKapat = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.btnMolekulYaz = New System.Windows.Forms.ToolStripButton
        Me.HelpToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.grpAtomDetaylari = New System.Windows.Forms.GroupBox
        Me.txtAciklama = New System.Windows.Forms.TextBox
        Me.txtGrup = New System.Windows.Forms.TextBox
        Me.txtPeriyot = New System.Windows.Forms.TextBox
        Me.txtAtomMA = New System.Windows.Forms.TextBox
        Me.txtAtomNo = New System.Windows.Forms.TextBox
        Me.txtAtomIsmi = New System.Windows.Forms.TextBox
        Me.txtAtomSimge = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.clmSec = New System.Windows.Forms.ColumnHeader
        Me.clmAtom = New System.Windows.Forms.ColumnHeader
        Me.clmAdet = New System.Windows.Forms.ColumnHeader
        Me.clmKismiToplam = New System.Windows.Forms.ColumnHeader
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.grpMAHesaplama.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.nudAdet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.grpAtomDetaylari.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.ToolStrip2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel1)
        Me.SplitContainer1.Size = New System.Drawing.Size(973, 640)
        Me.SplitContainer1.SplitterDistance = 725
        Me.SplitContainer1.TabIndex = 0
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnYardimcilar, Me.ToolStripSeparator3, Me.btnElementEdit, Me.toolStripSeparator5, Me.ToolStripLabel1, Me.cmbAra, Me.ToolStripSeparator6, Me.btnAra, Me.ToolStripSeparator4, Me.btnInfo})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(725, 25)
        Me.ToolStrip2.TabIndex = 1
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'btnYardimcilar
        '
        Me.btnYardimcilar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnYardimcilar.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAtomYaricap, Me.btnElektronegatiflik, Me.btnPeriyodikCetv2, Me.ToolStripMenuItem1, Me.btnHesapMakinesi})
        Me.btnYardimcilar.Image = CType(resources.GetObject("btnYardimcilar.Image"), System.Drawing.Image)
        Me.btnYardimcilar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnYardimcilar.Name = "btnYardimcilar"
        Me.btnYardimcilar.Size = New System.Drawing.Size(29, 22)
        Me.btnYardimcilar.Text = "Yardýmcý Araçlar"
        '
        'btnAtomYaricap
        '
        Me.btnAtomYaricap.Image = CType(resources.GetObject("btnAtomYaricap.Image"), System.Drawing.Image)
        Me.btnAtomYaricap.Name = "btnAtomYaricap"
        Me.btnAtomYaricap.Size = New System.Drawing.Size(210, 22)
        Me.btnAtomYaricap.Text = "Atom Yarýçaplarý"
        Me.btnAtomYaricap.ToolTipText = "Atom Yarýçap Deðerlerini Ýçeren Bir Tablo Gösterir."
        '
        'btnElektronegatiflik
        '
        Me.btnElektronegatiflik.Image = CType(resources.GetObject("btnElektronegatiflik.Image"), System.Drawing.Image)
        Me.btnElektronegatiflik.Name = "btnElektronegatiflik"
        Me.btnElektronegatiflik.Size = New System.Drawing.Size(210, 22)
        Me.btnElektronegatiflik.Text = "Elektronegatiflik Tablosu"
        Me.btnElektronegatiflik.ToolTipText = "Atom elektronegatiflik Deðerlerini Gösteren Bir Tablo Gösterir."
        '
        'btnPeriyodikCetv2
        '
        Me.btnPeriyodikCetv2.Image = CType(resources.GetObject("btnPeriyodikCetv2.Image"), System.Drawing.Image)
        Me.btnPeriyodikCetv2.Name = "btnPeriyodikCetv2"
        Me.btnPeriyodikCetv2.Size = New System.Drawing.Size(210, 22)
        Me.btnPeriyodikCetv2.Text = "Alternatif Periyodik Cetvel"
        Me.btnPeriyodikCetv2.ToolTipText = "Alternatif Web Sayfasý Formatýnda Bir Periyodik Cetvel Gösterir."
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(207, 6)
        '
        'btnHesapMakinesi
        '
        Me.btnHesapMakinesi.Image = CType(resources.GetObject("btnHesapMakinesi.Image"), System.Drawing.Image)
        Me.btnHesapMakinesi.Name = "btnHesapMakinesi"
        Me.btnHesapMakinesi.Size = New System.Drawing.Size(210, 22)
        Me.btnHesapMakinesi.Text = "Hesap Makinesi"
        Me.btnHesapMakinesi.ToolTipText = "Windows' un Hesap Makinesi Uygulamasýný Açar."
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'btnElementEdit
        '
        Me.btnElementEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnElementEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAciklamaEkle, Me.ToolStripMenuItem2, Me.btnVarsayilanYap})
        Me.btnElementEdit.Image = CType(resources.GetObject("btnElementEdit.Image"), System.Drawing.Image)
        Me.btnElementEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnElementEdit.Name = "btnElementEdit"
        Me.btnElementEdit.Size = New System.Drawing.Size(32, 22)
        Me.btnElementEdit.Text = "ToolStripSplitButton1"
        Me.btnElementEdit.ToolTipText = "Element Düzenleme."
        '
        'btnAciklamaEkle
        '
        Me.btnAciklamaEkle.Image = CType(resources.GetObject("btnAciklamaEkle.Image"), System.Drawing.Image)
        Me.btnAciklamaEkle.Name = "btnAciklamaEkle"
        Me.btnAciklamaEkle.Size = New System.Drawing.Size(197, 22)
        Me.btnAciklamaEkle.Text = "Element Bilgi Deðiþtirme"
        Me.btnAciklamaEkle.ToolTipText = "Her Element Ýçin Bilgilerin Deðiþtirilebilmesini Saðlar."
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(194, 6)
        '
        'btnVarsayilanYap
        '
        Me.btnVarsayilanYap.Image = CType(resources.GetObject("btnVarsayilanYap.Image"), System.Drawing.Image)
        Me.btnVarsayilanYap.Name = "btnVarsayilanYap"
        Me.btnVarsayilanYap.Size = New System.Drawing.Size(197, 22)
        Me.btnVarsayilanYap.Text = "Deðiþiklikleri Sýfýrla"
        Me.btnVarsayilanYap.ToolTipText = "Element Bilgilerinde Yapýlan Deðiþikliði Eski Haline Getirir."
        '
        'toolStripSeparator5
        '
        Me.toolStripSeparator5.Name = "toolStripSeparator5"
        Me.toolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(98, 22)
        Me.ToolStripLabel1.Text = "Atom No/Ýsim Ara :"
        '
        'cmbAra
        '
        Me.cmbAra.Name = "cmbAra"
        Me.cmbAra.Size = New System.Drawing.Size(121, 25)
        Me.cmbAra.ToolTipText = "Yazdýðýnýz Atom Nosunu Ya da Atom Ýsmini Arayarak Size Yerini Gösterir."
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'btnAra
        '
        Me.btnAra.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnAra.Image = CType(resources.GetObject("btnAra.Image"), System.Drawing.Image)
        Me.btnAra.ImageTransparentColor = System.Drawing.Color.White
        Me.btnAra.Name = "btnAra"
        Me.btnAra.Size = New System.Drawing.Size(23, 22)
        Me.btnAra.Text = "ToolStripButton1"
        Me.btnAra.ToolTipText = "Ara"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'btnInfo
        '
        Me.btnInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnInfo.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnYardim, Me.ToolStripMenuItem3, Me.btnHakkinda})
        Me.btnInfo.Image = CType(resources.GetObject("btnInfo.Image"), System.Drawing.Image)
        Me.btnInfo.ImageTransparentColor = System.Drawing.Color.White
        Me.btnInfo.Name = "btnInfo"
        Me.btnInfo.Size = New System.Drawing.Size(29, 22)
        Me.btnInfo.Text = "ToolStripDropDownButton1"
        '
        'btnYardim
        '
        Me.btnYardim.Image = CType(resources.GetObject("btnYardim.Image"), System.Drawing.Image)
        Me.btnYardim.ImageTransparentColor = System.Drawing.Color.White
        Me.btnYardim.Name = "btnYardim"
        Me.btnYardim.Size = New System.Drawing.Size(128, 22)
        Me.btnYardim.Text = "Yardým"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(125, 6)
        '
        'btnHakkinda
        '
        Me.btnHakkinda.Image = CType(resources.GetObject("btnHakkinda.Image"), System.Drawing.Image)
        Me.btnHakkinda.ImageTransparentColor = System.Drawing.Color.White
        Me.btnHakkinda.Name = "btnHakkinda"
        Me.btnHakkinda.Size = New System.Drawing.Size(128, 22)
        Me.btnHakkinda.Text = "Hakkýnda"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.grpMAHesaplama)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.grpAtomDetaylari)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(10)
        Me.Panel1.Size = New System.Drawing.Size(244, 640)
        Me.Panel1.TabIndex = 0
        '
        'grpMAHesaplama
        '
        Me.grpMAHesaplama.Controls.Add(Me.TabControl1)
        Me.grpMAHesaplama.Controls.Add(Me.Panel3)
        Me.grpMAHesaplama.Controls.Add(Me.ToolStrip1)
        Me.grpMAHesaplama.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpMAHesaplama.Location = New System.Drawing.Point(10, 253)
        Me.grpMAHesaplama.Name = "grpMAHesaplama"
        Me.grpMAHesaplama.Size = New System.Drawing.Size(222, 375)
        Me.grpMAHesaplama.TabIndex = 3
        Me.grpMAHesaplama.TabStop = False
        Me.grpMAHesaplama.Text = "Molekül Aðýrlýðý Hesaplama"
        '
        'TabControl1
        '
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(3, 117)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(216, 255)
        Me.TabControl1.TabIndex = 9
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnSil)
        Me.Panel3.Controls.Add(Me.btnTemizle)
        Me.Panel3.Controls.Add(Me.nudAdet)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.btnEkle)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(3, 41)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(2, 10, 2, 10)
        Me.Panel3.Size = New System.Drawing.Size(216, 76)
        Me.Panel3.TabIndex = 8
        '
        'btnSil
        '
        Me.btnSil.Location = New System.Drawing.Point(112, 42)
        Me.btnSil.Name = "btnSil"
        Me.btnSil.Size = New System.Drawing.Size(60, 23)
        Me.btnSil.TabIndex = 4
        Me.btnSil.Text = "&Sil"
        Me.ToolTip1.SetToolTip(Me.btnSil, "Belirttiðiniz Adet Kadar Ýþaretlediðiniz Atomlardann Siler.")
        Me.btnSil.UseVisualStyleBackColor = True
        '
        'btnTemizle
        '
        Me.btnTemizle.Location = New System.Drawing.Point(9, 42)
        Me.btnTemizle.Name = "btnTemizle"
        Me.btnTemizle.Size = New System.Drawing.Size(97, 23)
        Me.btnTemizle.TabIndex = 6
        Me.btnTemizle.Text = "Seçili Olanlarý Sil"
        Me.ToolTip1.SetToolTip(Me.btnTemizle, "Listede Baþýna Ýþaret Koyduðunuz Atomlarý Listeden Siler.")
        Me.btnTemizle.UseVisualStyleBackColor = True
        '
        'nudAdet
        '
        Me.nudAdet.Location = New System.Drawing.Point(46, 16)
        Me.nudAdet.Maximum = New Decimal(New Integer() {100000000, 0, 0, 0})
        Me.nudAdet.Name = "nudAdet"
        Me.nudAdet.Size = New System.Drawing.Size(60, 20)
        Me.nudAdet.TabIndex = 2
        Me.nudAdet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.nudAdet, "Molekül Aðýrlýðý Hesaplamada Ekleyeceðiniz Atomun Adetini Belirtme.")
        Me.nudAdet.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label8.Location = New System.Drawing.Point(5, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Adet :"
        '
        'btnEkle
        '
        Me.btnEkle.Location = New System.Drawing.Point(112, 15)
        Me.btnEkle.Name = "btnEkle"
        Me.btnEkle.Size = New System.Drawing.Size(60, 23)
        Me.btnEkle.TabIndex = 4
        Me.btnEkle.Text = "Ekl&e"
        Me.ToolTip1.SetToolTip(Me.btnEkle, "Periyodik Cetvelden Seçtiðiniz Atomu, Belirttiðiniz Adet Kadar Ekler.")
        Me.btnEkle.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripButton, Me.OpenToolStripButton, Me.SaveToolStripButton, Me.btnSaveAll, Me.ToolStripSeparator1, Me.PrintToolStripButton, Me.toolStripSeparator, Me.btnTabPageKapat, Me.ToolStripSeparator2, Me.btnMolekulYaz, Me.HelpToolStripButton})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 16)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(216, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'NewToolStripButton
        '
        Me.NewToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NewToolStripButton.Image = CType(resources.GetObject("NewToolStripButton.Image"), System.Drawing.Image)
        Me.NewToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewToolStripButton.Name = "NewToolStripButton"
        Me.NewToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.NewToolStripButton.Text = "&New"
        Me.NewToolStripButton.ToolTipText = "Yeni"
        '
        'OpenToolStripButton
        '
        Me.OpenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.OpenToolStripButton.Image = CType(resources.GetObject("OpenToolStripButton.Image"), System.Drawing.Image)
        Me.OpenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OpenToolStripButton.Name = "OpenToolStripButton"
        Me.OpenToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.OpenToolStripButton.Text = "&Open"
        Me.OpenToolStripButton.ToolTipText = "Kaydedilmiþ Dosyayý Aç"
        '
        'SaveToolStripButton
        '
        Me.SaveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SaveToolStripButton.Image = CType(resources.GetObject("SaveToolStripButton.Image"), System.Drawing.Image)
        Me.SaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveToolStripButton.Name = "SaveToolStripButton"
        Me.SaveToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.SaveToolStripButton.Text = "&Save"
        Me.SaveToolStripButton.ToolTipText = "Seçili Listeyi Kaydet"
        '
        'btnSaveAll
        '
        Me.btnSaveAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnSaveAll.Image = CType(resources.GetObject("btnSaveAll.Image"), System.Drawing.Image)
        Me.btnSaveAll.ImageTransparentColor = System.Drawing.Color.White
        Me.btnSaveAll.Name = "btnSaveAll"
        Me.btnSaveAll.Size = New System.Drawing.Size(23, 22)
        Me.btnSaveAll.Text = "ToolStripButton1"
        Me.btnSaveAll.ToolTipText = "Tüm Listeleri Kaydet"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'PrintToolStripButton
        '
        Me.PrintToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PrintToolStripButton.Image = CType(resources.GetObject("PrintToolStripButton.Image"), System.Drawing.Image)
        Me.PrintToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrintToolStripButton.Name = "PrintToolStripButton"
        Me.PrintToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.PrintToolStripButton.Text = "&Print"
        Me.PrintToolStripButton.ToolTipText = "Yazdýr"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'btnTabPageKapat
        '
        Me.btnTabPageKapat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnTabPageKapat.Image = CType(resources.GetObject("btnTabPageKapat.Image"), System.Drawing.Image)
        Me.btnTabPageKapat.ImageTransparentColor = System.Drawing.Color.White
        Me.btnTabPageKapat.Name = "btnTabPageKapat"
        Me.btnTabPageKapat.Size = New System.Drawing.Size(23, 22)
        Me.btnTabPageKapat.Text = "ToolStripButton2"
        Me.btnTabPageKapat.ToolTipText = "Seçili Listeyi Sil"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'btnMolekulYaz
        '
        Me.btnMolekulYaz.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnMolekulYaz.Image = CType(resources.GetObject("btnMolekulYaz.Image"), System.Drawing.Image)
        Me.btnMolekulYaz.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnMolekulYaz.Name = "btnMolekulYaz"
        Me.btnMolekulYaz.Size = New System.Drawing.Size(23, 22)
        Me.btnMolekulYaz.Text = "ToolStripButton1"
        Me.btnMolekulYaz.ToolTipText = "Molekül Yaz"
        '
        'HelpToolStripButton
        '
        Me.HelpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.HelpToolStripButton.Image = CType(resources.GetObject("HelpToolStripButton.Image"), System.Drawing.Image)
        Me.HelpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.HelpToolStripButton.Name = "HelpToolStripButton"
        Me.HelpToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.HelpToolStripButton.Text = "He&lp"
        Me.HelpToolStripButton.ToolTipText = "Hakkýnda"
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(10, 243)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(222, 10)
        Me.Panel2.TabIndex = 2
        '
        'grpAtomDetaylari
        '
        Me.grpAtomDetaylari.Controls.Add(Me.txtAciklama)
        Me.grpAtomDetaylari.Controls.Add(Me.txtGrup)
        Me.grpAtomDetaylari.Controls.Add(Me.txtPeriyot)
        Me.grpAtomDetaylari.Controls.Add(Me.txtAtomMA)
        Me.grpAtomDetaylari.Controls.Add(Me.txtAtomNo)
        Me.grpAtomDetaylari.Controls.Add(Me.txtAtomIsmi)
        Me.grpAtomDetaylari.Controls.Add(Me.txtAtomSimge)
        Me.grpAtomDetaylari.Controls.Add(Me.Label7)
        Me.grpAtomDetaylari.Controls.Add(Me.Label6)
        Me.grpAtomDetaylari.Controls.Add(Me.Label5)
        Me.grpAtomDetaylari.Controls.Add(Me.Label4)
        Me.grpAtomDetaylari.Controls.Add(Me.Label3)
        Me.grpAtomDetaylari.Controls.Add(Me.Label2)
        Me.grpAtomDetaylari.Controls.Add(Me.Label1)
        Me.grpAtomDetaylari.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpAtomDetaylari.Location = New System.Drawing.Point(10, 10)
        Me.grpAtomDetaylari.Name = "grpAtomDetaylari"
        Me.grpAtomDetaylari.Padding = New System.Windows.Forms.Padding(8)
        Me.grpAtomDetaylari.Size = New System.Drawing.Size(222, 233)
        Me.grpAtomDetaylari.TabIndex = 1
        Me.grpAtomDetaylari.TabStop = False
        Me.grpAtomDetaylari.Text = "Atom Detaylarý"
        '
        'txtAciklama
        '
        Me.txtAciklama.BackColor = System.Drawing.Color.White
        Me.txtAciklama.Location = New System.Drawing.Point(72, 180)
        Me.txtAciklama.Multiline = True
        Me.txtAciklama.Name = "txtAciklama"
        Me.txtAciklama.ReadOnly = True
        Me.txtAciklama.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAciklama.Size = New System.Drawing.Size(126, 43)
        Me.txtAciklama.TabIndex = 2
        '
        'txtGrup
        '
        Me.txtGrup.BackColor = System.Drawing.Color.White
        Me.txtGrup.Location = New System.Drawing.Point(72, 76)
        Me.txtGrup.Name = "txtGrup"
        Me.txtGrup.ReadOnly = True
        Me.txtGrup.Size = New System.Drawing.Size(126, 20)
        Me.txtGrup.TabIndex = 2
        '
        'txtPeriyot
        '
        Me.txtPeriyot.BackColor = System.Drawing.Color.White
        Me.txtPeriyot.Location = New System.Drawing.Point(72, 102)
        Me.txtPeriyot.Name = "txtPeriyot"
        Me.txtPeriyot.ReadOnly = True
        Me.txtPeriyot.Size = New System.Drawing.Size(126, 20)
        Me.txtPeriyot.TabIndex = 2
        '
        'txtAtomMA
        '
        Me.txtAtomMA.BackColor = System.Drawing.Color.White
        Me.txtAtomMA.Location = New System.Drawing.Point(72, 154)
        Me.txtAtomMA.Name = "txtAtomMA"
        Me.txtAtomMA.ReadOnly = True
        Me.txtAtomMA.Size = New System.Drawing.Size(126, 20)
        Me.txtAtomMA.TabIndex = 2
        '
        'txtAtomNo
        '
        Me.txtAtomNo.BackColor = System.Drawing.Color.White
        Me.txtAtomNo.Location = New System.Drawing.Point(72, 50)
        Me.txtAtomNo.Name = "txtAtomNo"
        Me.txtAtomNo.ReadOnly = True
        Me.txtAtomNo.Size = New System.Drawing.Size(126, 20)
        Me.txtAtomNo.TabIndex = 2
        '
        'txtAtomIsmi
        '
        Me.txtAtomIsmi.BackColor = System.Drawing.Color.White
        Me.txtAtomIsmi.Location = New System.Drawing.Point(72, 128)
        Me.txtAtomIsmi.Name = "txtAtomIsmi"
        Me.txtAtomIsmi.ReadOnly = True
        Me.txtAtomIsmi.Size = New System.Drawing.Size(126, 20)
        Me.txtAtomIsmi.TabIndex = 2
        '
        'txtAtomSimge
        '
        Me.txtAtomSimge.BackColor = System.Drawing.Color.White
        Me.txtAtomSimge.Location = New System.Drawing.Point(72, 24)
        Me.txtAtomSimge.Name = "txtAtomSimge"
        Me.txtAtomSimge.ReadOnly = True
        Me.txtAtomSimge.Size = New System.Drawing.Size(126, 20)
        Me.txtAtomSimge.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label7.Location = New System.Drawing.Point(11, 183)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Açýklama :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label6.Location = New System.Drawing.Point(11, 79)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Grup :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label5.Location = New System.Drawing.Point(11, 105)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Periyot :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 157)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "A. Aðýrlýðý :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Atom No :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 131)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Ýsmi :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Simge :"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
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
        'ToolTip1
        '
        Me.ToolTip1.IsBalloon = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(973, 640)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Periyodik Cetvel 2007"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.grpMAHesaplama.ResumeLayout(False)
        Me.grpMAHesaplama.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.nudAdet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.grpAtomDetaylari.ResumeLayout(False)
        Me.grpAtomDetaylari.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents grpAtomDetaylari As System.Windows.Forms.GroupBox
    Friend WithEvents txtAciklama As System.Windows.Forms.TextBox
    Friend WithEvents txtGrup As System.Windows.Forms.TextBox
    Friend WithEvents txtPeriyot As System.Windows.Forms.TextBox
    Friend WithEvents txtAtomMA As System.Windows.Forms.TextBox
    Friend WithEvents txtAtomNo As System.Windows.Forms.TextBox
    Friend WithEvents txtAtomIsmi As System.Windows.Forms.TextBox
    Friend WithEvents txtAtomSimge As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents grpMAHesaplama As System.Windows.Forms.GroupBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents nudAdet As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnSil As System.Windows.Forms.Button
    Friend WithEvents btnEkle As System.Windows.Forms.Button
    Friend WithEvents NewToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents OpenToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents SaveToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents PrintToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents HelpToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnTemizle As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents clmSec As System.Windows.Forms.ColumnHeader
    Friend WithEvents clmAtom As System.Windows.Forms.ColumnHeader
    Friend WithEvents clmAdet As System.Windows.Forms.ColumnHeader
    Friend WithEvents clmKismiToplam As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnSaveAll As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnTabPageKapat As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnYardimcilar As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents btnElementEdit As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents btnAtomYaricap As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnElektronegatiflik As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnPeriyodikCetv2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnHesapMakinesi As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnAciklamaEkle As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnVarsayilanYap As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents toolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cmbAra As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnAra As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnMolekulYaz As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnInfo As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents btnYardim As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnHakkinda As System.Windows.Forms.ToolStripMenuItem

End Class
