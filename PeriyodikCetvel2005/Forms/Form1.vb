#Region "Imports"
Imports System.Xml
Imports System.Data
Imports system.Data.OleDb
#End Region

Public Class Form1

#Region "LocalVariables"
    Private SeciliBtn As ElementalButton
    Private SeciliTp As TabPage
    Private lstViewControl As ListView
    Private txtToplamControl As TextBox
#End Region

#Region "Methods"

    Private Function SetDataTable() As DataTable
        SetDataTable = New DataTable
        Dim DR As DataRow

        SetDataTable.Columns.Add("Atom Simgesi")
        SetDataTable.Columns.Add("Atom Ismi")
        SetDataTable.Columns.Add("Atom No")
        SetDataTable.Columns.Add("Grup")
        SetDataTable.Columns.Add("Periyot")
        SetDataTable.Columns.Add("Adet")
        SetDataTable.Columns.Add("Birim Aðýrlýk")
        SetDataTable.Columns.Add("Kýsmi Aðýrlýk")

        For Each itm As myListViewNesnesi In Me.lstViewControl.Items
            DR = SetDataTable.NewRow
            DR.Item(0) = itm.ElementButonu.Text
            DR.Item(1) = itm.ElementButonu.ElementNesnesi.Isim
            DR.Item(2) = itm.ElementButonu.ElementNesnesi.AtomNo
            DR.Item(3) = itm.ElementButonu.ElementNesnesi.Grup
            DR.Item(4) = itm.ElementButonu.ElementNesnesi.Periyot
            DR.Item(5) = itm.SubItems(2).Text
            DR.Item(6) = itm.ElementButonu.ElementNesnesi.AtomAgirlik
            DR.Item(7) = itm.SubItems(3).Text
            SetDataTable.Rows.Add(DR)
        Next

        Return SetDataTable
    End Function

    Private Sub GetDataTable(ByVal DataTable As DataTable)

        For Each dr As DataRow In DataTable.Rows

            Dim itm As myListViewNesnesi
            Dim btn As ElementalButton = New ElementalButton(New ElementObject(dr.Item(2), dr.Item(6), dr.Item(3).ToString, dr.Item(4), dr.Item(1).ToString, ""))

            btn.Text = dr.Item(0).ToString()

            itm = New myListViewNesnesi(btn)
            itm.SubItems.Add(dr.Item(0).ToString())
            itm.SubItems.Add(dr.Item(5).ToString())
            itm.SubItems.Add(dr.Item(7).ToString())

            Me.lstViewControl.Items.Add(itm)
        Next
    End Sub

    Private Function ToplamAl() As Single

        ToplamAl = 0.0

        If Not Me.lstViewControl.Items.Count = 0 Then
            For Each itm As myListViewNesnesi In Me.lstViewControl.Items
                ToplamAl += CType(itm.SubItems(3).Text, Single)
            Next
        End If

        Return ToplamAl
    End Function

    Private Sub NewTabPage(ByVal TabPageText As String)

        Dim tp As TabPage = New TabPage
        tp.Text = TabPageText

        Dim myCtrl As myMoleculeControl = New myMoleculeControl
        myCtrl.Dock = DockStyle.Fill
        tp.Controls.Add(myCtrl)

        Me.TabControl1.TabPages.Add(tp)

        Me.TabControl1.SelectedIndex = -1
        Me.TabControl1.SelectedTab = tp
    End Sub

    Private Sub Save(ByVal SavePath As String, ByVal FilterIndex As Integer)

        Select Case FilterIndex
            Case 1
                'Xml dosya oluþturma..
                Dim FRW As DLL_FileReaderWriter.XML
                FRW = New DLL_FileReaderWriter.XML
                FRW.XMLFileWriter(SetDataTable(), SavePath)
            Case 2
                'Html dokumaný oluþturma..
                Dim FRW As DLL_FileReaderWriter.WritingFromDataTable
                FRW = New DLL_FileReaderWriter.WritingFromDataTable
                FRW.WriteHTMLFile(SetDataTable(), SavePath, SeciliTp.Text, Application.StartupPath & "\Style.csscode", Application.StartupPath & "\java_script.javacode", ToplamAl())
            Case 3
                'Txt dosya oluþturma..
                Dim FRW As DLL_FileReaderWriter.WritingFromDataTable
                FRW = New DLL_FileReaderWriter.WritingFromDataTable
                FRW.WriteTEXTFile(SetDataTable(), SavePath, ToplamAl)
        End Select

    End Sub

    Private Sub ButonlariOlustur()

        Dim ButtonsPnl As Panel

        'SplitContainer içindeki "Buttons" isimli panel ele geçirilir. Çünkü bu butonlr bu kontrol içine eklenecektir..
        For Each ctrl As Control In Me.SplitContainer1.Panel1.Controls(1).Controls
            If TypeOf ctrl Is Panel AndAlso ctrl.Name = "Buttons" Then
                ButtonsPnl = CType(ctrl, Panel)
                ButtonsPnl.Controls.Clear()
                Exit For
            End If
        Next

        '========
        'BUTTONS
        '========
        'Okunacak XML dökümaný elde edilir.
        Dim Doc As XmlDocument = New XmlDocument
        Doc.Load(Application.StartupPath & "\DatabaseOfElements.xml")

        '<Atom> node'larýný içeren RootNode ele geçirilir..
        Dim root As XmlElement = Doc.ChildNodes(1)

        'RootNode içindeki childNode'lar tek tek okunur.
        'ChildNode içinde Atom özelliklerini içeren Node'lara sahiptir..
        For Each child As XmlElement In root.ChildNodes
            Dim btn As ElementalButton = New ElementalButton(New ElementObject(CInt(child.ChildNodes(6).InnerText), CType(child.ChildNodes(5).InnerText, Single), child.ChildNodes(1).InnerText, CInt(child.ChildNodes(2).InnerText), child.ChildNodes(7).InnerText, child.ChildNodes(8).InnerText))

            btn.Size = New Size(35, 35)
            btn.Location = New Point(CInt(child.ChildNodes(3).InnerText) * 35, CInt(child.ChildNodes(4).InnerText) * 35)
            btn.Text = child.ChildNodes(0).InnerText

            'Butona basilinca yapilacak iþlemler için Event yönlendirilcek..
            AddHandler btn.Click, AddressOf AtomDetails

            'Me.SplitContainer1.Controls.Add(btn)
            ButtonsPnl.Controls.Add(btn)
        Next

        'Me.SplitContainer1.Panel1.Controls(1).Controls.Add(pnl2)
    End Sub

    Private Sub ButonlariYenile(ByVal sender As Object, ByVal e As FormClosedEventArgs)
        'Ayarlar penceresinde(Form4) Element özellikleri deðiþtikten sonra Ana Ekrana gelince(Form1) butonlarýn güncellenmiþ özelliklerinin görüntülenmesi için ; deðiþen XML kaynaðýndan elementlerin yeni özellikleri okunarak butonlar yeniden oluþturulur..(Form4 'ün Closed Event'inde çalýþtýrýlýr.)
        ButonlariOlustur()
        Temizle()
    End Sub

    Private Sub Temizle()
        For Each ctrl As Control In Me.grpAtomDetaylari.Controls
            If TypeOf ctrl Is TextBox Then
                CType(ctrl, TextBox).Text = ""
            End If
        Next
    End Sub

#End Region

#Region "Events"

    Private Sub Form1_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        'CrystalReport'un Raporlama yapabilmesi için kopyalanan Database silinir..
        Try
            If Not System.IO.File.Exists("c:\Db.mdb") = False Then
                Kill("c:\Db.mdb")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Periyodik dizayn'ýn aþaðý istenilen deðerde kaymasý için baþýnda Dizayn yazan açýklama satýrlarýna bak!

        Dim lbl As Label
        Dim lblText As String
        Dim pnl As Panel

        pnl = New Panel
        pnl.Name = "labels"
        pnl.Dock = DockStyle.Fill
        pnl.BorderStyle = BorderStyle.FixedSingle

        '========
        'LABELS
        '========
        For i As Integer = 0 To 19
            If i < 18 Then
                lbl = New Label
                'Dizayn; Location(Y) deðerini istenilen þekilde arttýr ama diðer Dizayn sekmelerinide ayný deðerde arttýrmalýsýn!
                lbl.Location = New Point(i * 35 + 80, 40)
                lbl.Size = New Size(35, 35)
                lbl.TextAlign = ContentAlignment.MiddleCenter
                lbl.Font = New Font("Times New Roman", 8, FontStyle.Bold Or FontStyle.Underline)
                lbl.BorderStyle = BorderStyle.FixedSingle
                lbl.AutoSize = False
                lbl.BackColor = Color.LightSteelBlue
                lbl.ForeColor = Color.Navy

                Select Case i
                    Case 0
                        lblText = "1A"
                    Case 1
                        lblText = "2A"
                    Case 2
                        lblText = "3B"
                    Case 3
                        lblText = "4B"
                    Case 4
                        lblText = "5B"
                    Case 5
                        lblText = "6B"
                    Case 6
                        lblText = "7B"
                    Case 7
                        lblText = "8B"
                    Case 8
                        lblText = "8B"
                    Case 9
                        lblText = "8B"
                    Case 10
                        lblText = "1B"
                    Case 11
                        lblText = "2B"
                    Case 12
                        lblText = "3A"
                    Case 13
                        lblText = "4A"
                    Case 14
                        lblText = "5A"
                    Case 15
                        lblText = "6A"
                    Case 16
                        lblText = "7A"
                    Case 17
                        lblText = "8A"
                End Select

                lbl.Text = lblText
                pnl.Controls.Add(lbl)
            End If

            If i < 7 Then
                lbl = New Label
                'Dizayn; Location(Y) deðerini istenilen þekilde arttýr(toplam kýsmýný) ama diðer Dizayn sekmelerinide ayný deðerde arttýrmalýsýn!
                lbl.Location = New Point(10, i * 35 + 75)
                lbl.Size = New Size(70, 35)
                lbl.TextAlign = ContentAlignment.MiddleCenter
                lbl.Font = New Font("Times New Roman", 8, FontStyle.Bold Or FontStyle.Underline)
                lbl.BorderStyle = BorderStyle.FixedSingle
                lbl.AutoSize = False
                lbl.BackColor = Color.LightSteelBlue
                lbl.ForeColor = Color.Navy
                lbl.Tag = i + 1
                Select Case i
                    Case 0
                        lblText = "1.Periyot"
                    Case 1
                        lblText = "2.Periyot"
                    Case 2
                        lblText = "3.Periyot"
                    Case 3
                        lblText = "4.Periyot"
                    Case 4
                        lblText = "5.Periyot"
                    Case 5
                        lblText = "6.Periyot"
                    Case 6
                        lblText = "7.Periyot"
                End Select
                lbl.Text = lblText
                pnl.Controls.Add(lbl)
            End If

            If i > 17 Then
                lbl = New Label
                'Dizayn; Location(Y) deðerini istenilen þekilde arttýr(toplam kýsmýný) ama diðer Dizayn sekmelerinide ayný deðerde arttýrmalýsýn!
                lbl.Location = New Point(150, ((i - 10) * 35) + 75)
                lbl.Size = New Size(70, 35)
                lbl.TextAlign = ContentAlignment.MiddleCenter
                lbl.Font = New Font("Times New Roman", 9, FontStyle.Bold Or FontStyle.Underline Or FontStyle.Italic)
                lbl.AutoSize = False
                lbl.ForeColor = Color.Navy
                Select Case i
                    Case 18
                        lbl.Text = "Lantanitler"
                    Case 19
                        lbl.Text = "Aktinitler"
                End Select
                pnl.Controls.Add(lbl)
            End If
        Next

        'Butonlarý içine alacak panel oluþturuluyor..
        Dim pnl2 As Panel
        pnl2 = New Panel
        pnl2.Name = "Buttons"
        'Dizayn; Location(Y) deðerini istenilen þekilde arttýr(toplam kýsmýný) ama diðer Dizayn sekmelerinide ayný deðerde arttýrmalýsýn!
        pnl2.Location = New Point(80, 75)
        pnl2.Size = New Size(18 * 35, 10 * 35)
        'pnl2.BorderStyle = BorderStyle.FixedSingle

        'Butonlarý içine alacak panel ; Label'larý içine alan ana panel'e ekleniyor..
        pnl.Controls.Add(pnl2)

        'Ana Panel Splitcontainer'a ekleniyor..
        Me.SplitContainer1.Panel1.Controls.Add(pnl)

        'Buttonlarý pnl2 içine oluþturmak üzere Sub çalýþtýrýlýyor..
        ButonlariOlustur()
    End Sub

    Public Sub AtomDetails(ByVal sender As Object, ByVal e As EventArgs)
        'Seçilen buton ElementalButton kalýbýna dönüþtürülerek özelliklerine ulaþýlýr..
        SeciliBtn = CType(sender, ElementalButton)

        'AtomDetaylarý groupbox'ýndaki alanlar temizlenir.
        Me.Temizle()

        'Týklanan ElementalButton özellikleri gerekli yerlere aktarýlýr.
        Me.txtAtomSimge.Text = SeciliBtn.Text
        Me.txtAtomNo.Text = SeciliBtn.ElementNesnesi.AtomNo.ToString
        Me.txtAtomIsmi.Text = SeciliBtn.ElementNesnesi.Isim
        Me.txtAtomMA.Text = SeciliBtn.ElementNesnesi.AtomAgirlik.ToString
        Me.txtAciklama.Text = SeciliBtn.ElementNesnesi.Desc
        Me.txtGrup.Text = SeciliBtn.ElementNesnesi.Grup
        Me.txtPeriyot.Text = SeciliBtn.ElementNesnesi.Periyot.ToString

        'Periyodik Cetvelin Labell'larýný içinde tutan panel'e eriþilir ve Seçilen buton 'un Grup ve Periyot Label'ý kýrmýzý yazý tipine dönüþtürülür..
        For Each ctrl As Control In Me.SplitContainer1.Panel1.Controls(1).Controls
            If TypeOf ctrl Is Label Then
                Dim lbl As Label = CType(ctrl, Label)
                lbl.ForeColor = Color.Navy
                lbl.Font = New Font("Times New Roman", 9, FontStyle.Bold Or FontStyle.Underline)

                If lbl.Text = SeciliBtn.ElementNesnesi.Grup.ToString OrElse lbl.Tag = SeciliBtn.ElementNesnesi.Periyot.ToString Then
                    lbl.ForeColor = Color.Red
                    lbl.Font = New Font("Times New Roman", 9, FontStyle.Bold Or FontStyle.Underline Or FontStyle.Italic)
                End If
            End If
        Next
    End Sub

    Private Sub btnEkle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEkle.Click

        Dim ListedeYok As Boolean = False
        Dim LsvItm As myListViewNesnesi

        'Eðer açýlmýþ bir sekme yok ise sekme açar..
        If Me.TabControl1.TabPages.Count = 0 Then NewToolStripButton_Click(sender, e)

        'Eðer seçili element yoksa uyarý çýkarýr..
        If Not Me.nudAdet.Value = 0 AndAlso Not Me.SeciliBtn.Text = "" Then

            'Seçilen butondan bir myListViewNesnesi oluþturulur ve bu myListViewNesnesi özellikleri inþa edilir..
            LsvItm = New myListViewNesnesi(SeciliBtn)

            'ilk olarak atom listede yok olarak iþaretlenir..
            ListedeYok = True
            For i As Integer = 0 To Me.lstViewControl.Items.Count - 1
                'Eðer seçili element listede varsa..
                If Me.lstViewControl.Items(i).SubItems(1).Text = LsvItm.ElementButonu.Text Then
                    'Atom listede var olarak iþaretlenir..
                    ListedeYok = False
                    'Varolan liste Item'ýna deðerler eklenir..
                    Me.lstViewControl.Items(i).SubItems(2).Text += Me.nudAdet.Value
                    Me.lstViewControl.Items(i).SubItems(3).Text += CType(Me.nudAdet.Value * LsvItm.ElementButonu.ElementNesnesi.AtomAgirlik, Single)
                End If
            Next

            'Eðer yeni eklenecek element listede yoksa oluþturulan myListViewNesnesi listeye eklenir.
            If ListedeYok = True Then
                Me.lstViewControl.Items.Add(LsvItm)
                Me.lstViewControl.Items(Me.lstViewControl.Items.Count - 1).SubItems.Add(LsvItm.ElementButonu.Text)
                Me.lstViewControl.Items(Me.lstViewControl.Items.Count - 1).SubItems.Add(Me.nudAdet.Value)
                Me.lstViewControl.Items(Me.lstViewControl.Items.Count - 1).SubItems.Add(Me.nudAdet.Value * LsvItm.ElementButonu.ElementNesnesi.AtomAgirlik)
            End If

            '==========================
            'Toplam hesaplanýr..
            Me.txtToplamControl.Text = ToplamAl()
        Else
            MessageBox.Show("Adet girmediniz ya da bir element seçmediniz!", "Element veya Adet Yok !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End If
    End Sub

    Private Sub btnSil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSil.Click
        Dim Silinecek As Single = 0.0

        'iþaretlenmiþ item'lardan Adette belirtilen miktarda azaltýlýr..
        For Each itm As myListViewNesnesi In Me.lstViewControl.CheckedItems
            'Eðer belirtilen adet listedeki itm adetinden küçük yada eþit ise
            If itm.SubItems(2).Text >= Me.nudAdet.Value Then
                Silinecek = itm.ElementButonu.ElementNesnesi.AtomAgirlik * Me.nudAdet.Value
                itm.SubItems(2).Text -= Me.nudAdet.Value
                itm.SubItems(3).Text -= Silinecek

                'Eðer itm adeti "0" ise listeden kaldýrýlýr..
                If itm.SubItems(2).Text = 0 Then itm.Remove()
            Else
                MessageBox.Show(Chr(34) & itm.SubItems(1).Text & Chr(34) & " adlý element için adeti var olandan fazla girilmiþ. Lütfen kontrol ediniz !", "Hatalý Giriþ !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            End If
        Next

        'Toplam alýnýr..
        Me.txtToplamControl.Text = ToplamAl()
    End Sub

    Private Sub btnTemizle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTemizle.Click
        Dim Silinecek As Single = 0.0

        'iþaretlenen listItem'larý listeden kaldýrýlýr.
        If Not Me.lstViewControl.CheckedItems.Count = 0 Then
            For Each itm As myListViewNesnesi In Me.lstViewControl.CheckedItems
                itm.Remove()
            Next
        End If

        'Toplam alýnýr..
        Me.txtToplamControl.Text = ToplamAl()
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        'TabPage(sekme) seçilince seciliTabPage "SeciliTp" deðiþkenine ,Toplam TextBox 'da "txtToplamControl" deðiþkenine alýnýr.
        If Not Me.TabControl1.SelectedIndex = -1 Then
            SeciliTp = Me.TabControl1.SelectedTab
            Me.lstViewControl = CType(SeciliTp.Controls(0).Controls(0), ListView)
            Me.txtToplamControl = CType(SeciliTp.Controls(0).Controls(1).Controls(0), TextBox)
        End If
    End Sub

#End Region

#Region "ToolStrip_Agirlik_Hesaplama"
    Private Sub NewToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripButton.Click
        'Yeni bir sekme açýlýr..
        Dim MoleculName As String = InputBox("Molekül Ýsmi Giriniz :", "Molekül Ýsmi")
        NewTabPage(MoleculName)
    End Sub

    Private Sub SaveToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripButton.Click

        If Me.TabControl1.TabPages.Count = 0 Then Exit Sub

        'Secili TabPage baþlýðý dosya ismi olarak atanýr..
        Me.SaveFileDialog1.FileName = SeciliTp.Text
        Me.SaveFileDialog1.Filter = "XML Files(*.xml)|*.xml|Web Sayfasý(*.htm;*.html)|*.htm;*.html|Metin Belgesi(*.txt)|*.txt"
        Me.SaveFileDialog1.Title = "Verileri Kaydetme"
        Me.SaveFileDialog1.FilterIndex = 0

        'Dosya belirtilen þekilde kaydedilir..
        If Not Me.lstViewControl.Items.Count = 0 Then
            If Me.SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                Save(Me.SaveFileDialog1.FileName, Me.SaveFileDialog1.FilterIndex)
            End If
        Else
            MessageBox.Show("Listenizde kaydedilecek element bulunmamaktadýr!", "Element Yok !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End If

    End Sub

    Private Sub btnSaveAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveAll.Click

        If Me.TabControl1.TabPages.Count = 0 Then Exit Sub

        Me.SaveFileDialog1.DefaultExt = SeciliTp.Text
        Me.SaveFileDialog1.Filter = "XML Files(*.xml)|*.xml|Web Sayfasý(*.htm;*.html)|*.htm;*.html|Metin Belgesi(*.txt)|*.txt"
        Me.SaveFileDialog1.Title = "Verileri Kaydetme"
        Me.SaveFileDialog1.FilterIndex = 0

        If Me.SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.TabControl1.SelectedIndex = -1

            'TabPage baþlýklarý kullanýlarak isimlendirme yapýlarak sekmeler belirtilen formatta kaydedilir..
            For Each tp As TabPage In Me.TabControl1.TabPages
                Me.TabControl1.SelectedTab = tp
                If Not Me.lstViewControl.Items.Count = 0 Then
                    Dim DosyaIsmi As String = Me.SaveFileDialog1.FileName.Substring(0, Me.SaveFileDialog1.FileName.LastIndexOf("\") + 1) & tp.Text

                    Select Case Me.SaveFileDialog1.FilterIndex
                        Case 1
                            DosyaIsmi &= ".xml"
                        Case 2
                            DosyaIsmi &= ".html"
                        Case 3
                            DosyaIsmi &= ".txt"
                    End Select

                    Save(DosyaIsmi, Me.SaveFileDialog1.FilterIndex)
                Else
                    MessageBox.Show(tp.Text & " adlý listenizde kaydedilecek element bulunmamaktadýr! Bu liste kaydedilmeyecektir..", "Element Yok !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                End If
            Next
        End If

    End Sub

    Private Sub OpenToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripButton.Click
        Dim FRW As DLL_FileReaderWriter.XML

        Me.OpenFileDialog1.Filter = "XML Files(*.xml)|*.xml"
        Me.OpenFileDialog1.Title = "Verileri Okuma"

        If Me.OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then

            Dim DosyaIsmi As String = Me.OpenFileDialog1.FileName.ToString
            Dim DT As DataTable = New DataTable
            'Seçilen XML dosyasýndaki veriler DT adlý DataTable'a aktarýlýr.
            FRW = New DLL_FileReaderWriter.XML
            DT = FRW.ReadXMLFile(Me.OpenFileDialog1.FileName)

            'Seçilen dosya adý ile bir yeni bir tabpage oluþturulur..
            'Sadece dosya adý alýnýr.Örneðin: "c:\deneme.xml" --> 'deneme'
            NewTabPage(Me.OpenFileDialog1.FileName.Substring(DosyaIsmi.LastIndexOf("\") + 1, DosyaIsmi.LastIndexOf(".") - DosyaIsmi.LastIndexOf("\") - 1))
            'DataTable 'a cevrilen XML verileri oluþturulan TabPage'deki myMoleculeControl'deki ListView 'a aktarýlýr..
            GetDataTable(DT)

            'Seçili TabPage'deki txtToplam hanesine toplam hesaplanýr..
            Me.txtToplamControl.Text = ToplamAl()
        End If
    End Sub

    Private Sub PrintToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintToolStripButton.Click

        'Eger hesaplanmýþ bir molekul agýrlýðý sekmesi yoksa iþlem iptal..
        If Me.TabControl1.TabPages.Count = 0 Then
            MessageBox.Show("Raporlama yapýlacak bir sekme yok! Lütfen Raporlama için bir sekme oluþturun..", "Yazdýrýlacak Rapor Yok", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If

        'Connection ve Command oluþturulur..
        Dim ConnStr As String = "Provider=Microsoft.Jet.OleDb.4.0;Data Source=" & Application.StartupPath & "\Db.mdb;"
        Dim Conn As OleDbConnection
        Dim Cmd As OleDbCommand

        Try

            Conn = New OleDbConnection(ConnStr)
            Cmd = New OleDbCommand()
            Cmd.Connection = Conn
            Cmd.CommandType = CommandType.StoredProcedure

            'Ýlk olarak Tablodaki veriler silinir..
            Conn.Open()
            Cmd.CommandText = "ALL_DELETE"
            Cmd.ExecuteNonQuery()

            'ListView'deki her bir Item deðerleri Command'a parametre olarak verilir..
            For Each itm As myListViewNesnesi In Me.lstViewControl.Items
                Cmd.Parameters.AddWithValue("@param1", itm.ElementButonu.ElementNesnesi.AtomNo)
                Cmd.Parameters.AddWithValue("@param2", itm.SubItems(1).Text)
                Cmd.Parameters.AddWithValue("@param3", itm.ElementButonu.ElementNesnesi.Isim.ToString)
                Cmd.Parameters.AddWithValue("@param4", itm.ElementButonu.ElementNesnesi.Grup.ToString)
                Cmd.Parameters.AddWithValue("@param5", CInt(itm.ElementButonu.ElementNesnesi.Periyot))
                Cmd.Parameters.AddWithValue("@param6", CInt(itm.SubItems(2).Text))
                Cmd.Parameters.AddWithValue("@param7", CType(itm.ElementButonu.ElementNesnesi.AtomAgirlik, Single))
                Cmd.Parameters.AddWithValue("@param8", CType(itm.SubItems(3).Text, Single))
                Cmd.Parameters.AddWithValue("@param9", SeciliTp.Text)

                'Insert iþlemi..
                Cmd.CommandText = "ALL_INSERT"
                Cmd.ExecuteNonQuery()

                'parametre deðerleri temizlenir..
                Cmd.Parameters.Clear()
            Next

            System.Threading.Thread.Sleep(1000)

            'Raporlama için Database ,CrystalReport'un okuyabilmesi için C:\ ya kopyalanýr..
            FileCopy(Application.StartupPath & "\Db.mdb", "c:\Db.mdb")

        Catch exOle As OleDbException
            MessageBox.Show(exOle.Message.ToString, "DATABASE HATA", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "GENEL HATA", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        Finally
            Conn.Close()
            Cmd.Dispose()
            Conn.Dispose()
        End Try

        'Raporlama Form 'u açýlýr..
        Dim frm As Form2 = New Form2
        frm.Show()
    End Sub

    Private Sub btnTabPageKapat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTabPageKapat.Click
        If Not Me.TabControl1.SelectedIndex = -1 Then
            Me.TabControl1.SelectedTab.Dispose()
        End If
    End Sub

    Private Sub btnMolekulYaz_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMolekulYaz.Click
        Dim Molekul As String = ""

        Molekul = InputBox("Lütfen Molekülü Atomlar Arasýna " & vbCrLf & Chr(34) & "Tire(-)" & vbCrLf & Chr(34) & " Koyarak Yazýnýz : " & vbCrLf & "Örneðin;" & vbCrLf & "AmonyumSülfat : 2N-2H4-S-O4" & vbCrLf & "Su : H2-O  ... gibi.", "Molekül Yazma")

        Molekul = Trim(Molekul)

        'Eðer bir molekul yazýldýysa..
        If Not Molekul.Length = 0 Then

            If MessageBox.Show("Yeni bir sekmede açmak istiyorsanýz " & Chr(34) & "Evet" & Chr(34) & " 'i, var olan sekmeye eklenmesini istiyorsanýz " & Chr(34) & "Hayýr" & Chr(34) & " 'ý seçiniz..", "Yeni Sekmede Aç", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then NewToolStripButton_Click(sender, e)

            'String ifade atomlarýna ayrýlýr..
            Dim Atoms As String() = Molekul.Split("-")

            'Atomun önünde ve arkasýnda  yer alan mol sayýlarý ve element ismi için deðiþkenler tanýmlama..
            Dim OncekiMol As String = ""
            Dim SonrakiMol As String = ""
            Dim strElement As String = ""
            'Element ve mol sayýsý þeklinde listelencek..
            Dim Liste As ArrayList = New ArrayList
            Dim param As Paramaters

            'Dizideki her bir atom için..
            For Each str As String In Atoms
                Dim HarfChr As Boolean = False
                OncekiMol = ""
                SonrakiMol = ""

                'Her karakter için..
                For Each chr As Char In str.ToCharArray
                    'Eðer karakter sayý ise ve daha hiç harf okunmadýysa..
                    If Char.IsDigit(chr) = True AndAlso HarfChr = False Then
                        OncekiMol &= Char.ToString(chr)
                        'Eger karakter harf ise ve daha hiç harf okunmadýysa.
                    ElseIf Char.IsLetter(chr) = True AndAlso HarfChr = False Then
                        strElement = Char.ToUpper(chr).ToString
                        HarfChr = True
                        'Eðer karakter harf ise ve daha önce harf okunduysa..
                    ElseIf Char.IsLetter(chr) = True AndAlso HarfChr = True Then
                        strElement &= Char.ToLower(chr).ToString
                        'Eðer karakter sayý ise ve daha önce harf okunduysa..
                    ElseIf Char.IsDigit(chr) = True AndAlso HarfChr = True Then
                        SonrakiMol &= Char.ToString(chr)
                    End If
                Next

                If OncekiMol = "" Then OncekiMol = "1"
                If SonrakiMol = "" Then SonrakiMol = "1"

                'Ele geçen Elemnt ismi ve Mol sayýsý Listeye eklenir..
                param = New Paramaters(strElement, CStr(CInt(OncekiMol) * CInt(SonrakiMol)))
                Liste.Add(param)
            Next

            Dim ButtonsPnl As Panel

            'Butonlarýn bulunduðu panele eriþiyoruz..
            For Each ctrl As Control In Me.SplitContainer1.Panel1.Controls(1).Controls
                If TypeOf ctrl Is Panel AndAlso ctrl.Name = "Buttons" Then
                    ButtonsPnl = CType(ctrl, Panel)
                    Exit For
                End If
            Next

            'Butonlarýn bulunduðu paneldeki her buton için dönülür.Her buton için liste kontrol edilir.Eðer listede yer alan bir butona gelinilirse Element molekül aðýrlýðý hesaplama sekmesine eklenir..
            For Each btn As ElementalButton In ButtonsPnl.Controls
                For Each prm As Paramaters In Liste
                    If btn.Text = prm.Deger1 Then
                        SeciliBtn = btn
                        Me.nudAdet.Value = prm.Deger2
                        btnEkle_Click(sender, e)
                        Exit For
                    End If
                Next
            Next

        End If
    End Sub

    Private Sub HelpToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpToolStripButton.Click
        Dim frm As frmHakkinda = New frmHakkinda
        frm.ShowDialog()
    End Sub
#End Region

#Region "ToolStrip_PeriyodikCetvel"
    Private Sub btnAtomYaricap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtomYaricap.Click
        Dim frm As Form3 = New Form3
        frm.DosyaAc(Application.StartupPath & "\extras\atom_yaricaplari.jpg", "Atom Yarýçap Deðerleri")
        frm.Show()
    End Sub

    Private Sub btnElektronegatiflik_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnElektronegatiflik.Click
        Dim frm As Form3 = New Form3
        frm.DosyaAc(Application.StartupPath & "\extras\elektronegatiflik.htm", "Atom Elektronegatiflik Deðerleri")
        frm.Show()
    End Sub

    Private Sub btnPeriyodikCetv2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPeriyodikCetv2.Click
        Dim frm As Form3 = New Form3
        frm.DosyaAc(Application.StartupPath & "\extras\periyodik_tablo.htm", "Alternatif Periyodik Cetvel")
        frm.Show()
    End Sub

    Private Sub btnHesapMakinesi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHesapMakinesi.Click
        Shell("calc.exe")
    End Sub

    Private Sub btnAciklamaEkle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAciklamaEkle.Click
        Dim frm As Form4 = New Form4
        'Elementler için veriler deðiþtirildikten sonra Form Kapanýþýna AnaForm'daki butonlar yenilenir..
        AddHandler frm.FormClosed, AddressOf ButonlariYenile
        frm.Show()
    End Sub

    Private Sub btnVarsayilanYap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVarsayilanYap.Click

        'Element verilerini içeren XML dosyasý ilk haline dönüþtürülür..Yedeði bulunduðu için kopyalama ile kullanýlan dosya adýnda yedek kaydedilir.
        If System.IO.File.Exists(Application.StartupPath & "\DatabaseOfElements.xml") = True Then
            Kill(Application.StartupPath & "\DatabaseOfElements.xml")
        End If

        FileCopy(Application.StartupPath & "\DefaultDatabaseOfElements.xml", Application.StartupPath & "\DatabaseOfElements.xml")

        'Uygulama ufak bi beklemeye alýnýr..Bunu ne olur ne olmaz diye ekledim. Çünkü dosya kopyalama iþleminin ardýndan butonlar yeni verilere göre tekrardan oluþacak ve uygulama kodu hýzlý iþlettiðinde XML dosya kopyalanmadan okumaya geçilirse hata oluþur..
        Threading.Thread.Sleep(1000)

        ButonlariOlustur()
        Temizle()
    End Sub

    Private Sub cmbAra_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbAra.KeyDown
        'Enter 'a basýlýnca arama yapýlmasý saðlanýr..
        If e.KeyCode = Keys.Enter Then btnAra_Click(sender, e)
    End Sub

    Private Sub btnAra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAra.Click

        'Aranan sözcükteki ön ve arka boþluklar kesilir..Harfleri küçültülür.
        Dim Ara As String = Trim(Me.cmbAra.Text).ToLower
        'Aranan bulunamadý olarak iþaretlenir..
        Dim ArananVar As Boolean = False

        If Not Ara = "" Then
            Dim ButtonsPnl As Panel

            'Butonlarýn bulunduðu panele eriþiyoruz..
            For Each ctrl As Control In Me.SplitContainer1.Panel1.Controls(1).Controls
                If TypeOf ctrl Is Panel AndAlso ctrl.Name = "Buttons" Then
                    ButtonsPnl = CType(ctrl, Panel)
                    Exit For
                End If
            Next

            'Aranan atom butonu seçilerek görünür hale getirilir.Hatta týklanarak bilgileri gösterilir..
            For Each btn As ElementalButton In ButtonsPnl.Controls
                If btn.ElementNesnesi.AtomNo.ToString = Ara OrElse btn.ElementNesnesi.Isim.ToString.ToLower = Ara Then
                    'btn.Focus()
                    btn.Select()
                    AtomDetails(btn, e)
                    ArananVar = True
                    Beep()
                    Exit For
                End If
            Next

            'Aranan bulunamazsa msgbox gösterilir..
            If Not ArananVar = True Then
                MessageBox.Show(Chr(34) & Me.cmbAra.Text & Chr(34) & " atomu bulunamamýþtýr.", "Bulunamadý!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Me.Temizle()
            End If

            ArananVar = False
            'Aranan sözcük combobox'a eklenir..
            For Each obj As Object In Me.cmbAra.Items
                'Eðer arama yapýlan sözcük daha önceden combobox'a kaydedilmiþ ise, yakalanýr."ArananVar" deðiþkeni True olarak iþaretlenir..
                If CType(obj, String).ToString = Ara Then
                    ArananVar = True
                    Exit For
                End If
            Next

            'ArananVar deðiþkeni True deðlse,aranan sözcük daha önce combobox'a kaydedilmemiþ demektir.Aranan kelime combobox'a eklenir..
            If ArananVar = False Then
                Me.cmbAra.Items.Add(Me.cmbAra.Text)
            End If
        End If
    End Sub

    Private Sub cmbAra_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbAra.SelectedIndexChanged
        btnAra_Click(sender, e)
    End Sub

    Private Sub btnHakkinda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHakkinda.Click
        Dim frm As frmHakkinda = New frmHakkinda
        frm.Text = "Hakkýnda"
        frm.ShowDialog()
    End Sub

    Private Sub btnYardim_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnYardim.Click
        Dim frm As Form3 = New Form3
        frm.DosyaAc(Application.StartupPath & "\Help\Contents.htm", "Yardým")
        frm.Show()
    End Sub

#End Region

End Class
