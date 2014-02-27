Imports System.Xml

Public Class Form4

#Region "LocalVariables"
    Private cmbNesnesi As ElementObjectWithSimge
#End Region

#Region "Methods"
    Private Sub ElementDoldur()

        'Element verilerini içeren XML dosya okunarak DataTable olarak elimize geçer..Burada DataTable kullanmadan XMLDocument nesnesi ile okuyabilirdik ama hazýr XML okuyacak bir DLL uygulamada import edilmiþ olduðundan bunu kullandým.
        Dim DT As DataTable = New DataTable
        Dim XMLRead As DLL_FileReaderWriter.XML = New DLL_FileReaderWriter.XML
        DT = XMLRead.ReadXMLFile(Application.StartupPath & "\DatabaseOfElements.xml")

        Me.cmbElementler.Items.Clear()

        'Her DataRow için ElementObject nesnesi oluþturulur..
        'Bu nesneyi ElementObjectWithSimge instance 'ýný oluþturmakta kullanacaðýz.
        For Each dr As DataRow In DT.Rows
            Dim ElementNes As ElementObject = New ElementObject(CInt(dr.Item(6)), CType(dr.Item(5), Single), dr.Item(1).ToString, CInt(dr.Item(2)), dr.Item(7).ToString, dr.Item(8).ToString)

            cmbNesnesi = New ElementObjectWithSimge(ElementNes, dr.Item(0).ToString, Me.cmbGorunum.SelectedIndex)

            'Oluþturulan ElementObjectWithSimge combobox'a eklenir.
            Me.cmbElementler.Items.Add(cmbNesnesi)
        Next
    End Sub
#End Region

#Region "Events"
    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cmbGorunum.SelectedIndex = 2
        ElementDoldur()
        If Not Me.cmbElementler.Items.Count = 0 Then Me.cmbElementler.SelectedIndex = 0
    End Sub

    Private Sub cmbElementler_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbElementler.Click
        Me.cmbNesnesi = CType(Me.cmbElementler.SelectedItem, ElementObjectWithSimge)

        Me.cmbNesnesi.Isim = Me.txtAtomIsmi.Text
        Me.cmbNesnesi.Simge = Me.txtSimge.Text
        Me.cmbNesnesi.Grup = Me.cmbGrup.SelectedItem.ToString
        Me.cmbNesnesi.Periyot = Me.cmbPeriyot.SelectedItem.ToString
        Me.cmbNesnesi.AtomAgirlik = Me.txtBirimAgirlik.Text
        Me.cmbNesnesi.Desc = Me.txtAciklama.Text
    End Sub

    Private Sub cmbElementler_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbElementler.SelectedIndexChanged
        Me.cmbNesnesi = CType(Me.cmbElementler.SelectedItem, ElementObjectWithSimge)

        Me.txtAtomIsmi.Text = Me.cmbNesnesi.Isim.ToString
        Me.txtSimge.Text = Me.cmbNesnesi.Simge.ToString
        Me.txtAtomNo.Text = Me.cmbNesnesi.AtomNo.ToString
        Me.cmbGrup.SelectedItem = Me.cmbNesnesi.Grup.ToString
        Me.cmbPeriyot.SelectedItem = Me.cmbNesnesi.Periyot.ToString
        Me.txtBirimAgirlik.Text = Me.cmbNesnesi.AtomAgirlik.ToString
        Me.txtAciklama.Text = Me.cmbNesnesi.Desc.ToString
    End Sub

    Private Sub cmbGorunum_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbGorunum.SelectedIndexChanged
        ElementDoldur()
        If Not Me.cmbElementler.Items.Count = 0 Then
            Me.cmbElementler.SelectedIndex = 0
        End If
    End Sub

    Private Sub btnIptal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIptal.Click
        If MessageBox.Show("Yaptýðýnýz deðiþiklikleri kaydetmeden çýkmak istediðinize emin misiniz?", "Çýkýþ", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then Me.Close()
    End Sub

    Private Sub btnKaydet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKaydet.Click
        cmbElementler_Click(sender, e)

        Dim Doc As XmlDocument = New XmlDocument
        Doc.Load(Application.StartupPath & "\DatabaseOfElements.xml")

        Dim root As XmlElement = Doc.ChildNodes(1)

        'Tüm XML'deki Atomlar için dönülür..
        For Each child As XmlNode In root.ChildNodes
            Dim AtomNo As Integer = CInt(child.ChildNodes(6).InnerText)
            'XML'deki her atom için Combobox'daki elementler taranýr ve XML'den AtomNo'sunu okuduðumuz element'e gelince bilgileri Doc adlý XMLDocument'e yazýlýr..
            For Each obj As Object In Me.cmbElementler.Items
                Dim SimgeliElementNesnesi As ElementObjectWithSimge = CType(obj, ElementObjectWithSimge)
                If CInt(SimgeliElementNesnesi.AtomNo.ToString) = AtomNo Then
                    child.ChildNodes(0).InnerText = SimgeliElementNesnesi.Simge.ToString
                    child.ChildNodes(1).InnerText = SimgeliElementNesnesi.Grup.ToString
                    child.ChildNodes(2).InnerText = SimgeliElementNesnesi.Periyot.ToString
                    child.ChildNodes(5).InnerText = SimgeliElementNesnesi.AtomAgirlik.ToString
                    child.ChildNodes(7).InnerText = SimgeliElementNesnesi.Isim.ToString
                    child.ChildNodes(8).InnerText = SimgeliElementNesnesi.Desc.ToString
                    'Combobox'da XML'den okuduðumuz atoma geldik ve verilerini guncelledik.XML'den okuduðumuz bu element için combobox'daki diðer atomlar için boþuna dönmemek için ExitFor ile dýþ for döngüsüne geçilir ve diðer Element combobox'da aranýr ve bilgileri güncellenir..
                    Exit For
                End If
            Next
        Next

        'Bilgilerini güncellediðimiz XML'i yine ayný dosyamýza save yaparak kaydederiz..
        Doc.Save(Application.StartupPath & "\DatabaseOfElements.xml")
        'XML dosyasýný serbest býrakýlýr..
        Doc = Nothing
    End Sub

#End Region

End Class