Public Class Form2

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Boþ bir Datatable oluþturuyoruz.
        Dim DataTab As DataTable = New DataTable

        '3 tane kolon ekliyoruz.Veri girebilmek için..
        DataTab.Columns.Add("Element")
        DataTab.Columns.Add("Agirlik")
        DataTab.Columns.Add("Aciklama")

        'Datagrid 'nin DataSource(DataKaynaðý) kýsmýna oluþturduðumuz DataTable'ý ayarlýyoruz..
        DataGridView1.DataSource = DataTab
    End Sub

    Private Sub btnKaydet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKaydet.Click

        SaveFileDialog1.Filter = "Metin Belgesi(*.txt)|*.txt"

        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim DosyayaYaz As DLL_FileReaderWriter.WritingFromDataTable
            DosyayaYaz = New DLL_FileReaderWriter.WritingFromDataTable

            Dim DataTab As DataTable = New DataTable
            DataTab = DataGridView1.DataSource

            DosyayaYaz.WriteTEXTFile(DataTab, SaveFileDialog1.FileName)

            MessageBox.Show("Dosyanýz Yazýldý..", "Ýþlem Tamamlandý !", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub btnXML_Yaz_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnXML_Yaz.Click
        'Sadece uzantýsý *.xml olan dosyalarýn görünmesi saðlanýr. 
        SaveFileDialog1.Filter = "XML Files(*.xml)|*.xml"

        'Dosya Kaydet penceresi açýlýr ve "OK" butonu ile kaydet denildiyse.
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then

            'Dll dosyamýzadaki XML class 'ýndan Instance oluþturduk..
            Dim XML_Yaz As DLL_FileReaderWriter.XML = New DLL_FileReaderWriter.XML

            'DataGridView 'ýmýzýn kaynaðýný DataTable olarak ve SaveFileDialog da dosyayý kaydetmek için belirtilen konumuda XML dosyayý oluþturacak konum olarak belirttik..(Dll Class da Sub 'ý yazarken bahsettiðimiz parametreler bunlarý biz oluþturmuþtuk..)
            XML_Yaz.XMLFileWriter(DataGridView1.DataSource, SaveFileDialog1.FileName)

        End If
    End Sub

    Private Sub btnXML_Oku_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnXML_Oku.Click

        Dim DT As DataTable
        OpenFileDialog1.Filter = "XML Files(*.xml)|*.xml"

        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim XML_Oku As DLL_FileReaderWriter.XML = New DLL_FileReaderWriter.XML
            'Bize çalýþtýracaðýmýz fonksiyon sonunda DataTable döneceði için oluþturduk..
            DT = New DataTable
            'Oluþturduðumuz DataTable 'a ReadXMLFile function 'ý ile XML dosyasýný okuyoruz. Parametre olarak okumasýný istediðimiz XML dosyanýn konumunu yolluyoruz..
            DT = XML_Oku.ReadXMLFile(OpenFileDialog1.FileName)
            'DataGridView 'in Data kaynaðýna bize dönen DataTable 'ý gönderiyoruz..
            DataGridView1.DataSource = DT
        End If
    End Sub

End Class