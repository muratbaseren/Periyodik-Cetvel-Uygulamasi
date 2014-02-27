
Imports System.Xml
Imports System.Xml.XmlReader

Public Class WritingToTextFile
    'Belirtilen konumdaki dosyaya metni ekler..
    Public Sub WritingAppendFile(ByVal FilePath As String, ByVal Text As String)
        'Belirtilen konumdaki dosyaya FileStream ile ulaþýyoruz..
        Dim FS As System.IO.FileStream = New System.IO.FileStream(FilePath, IO.FileMode.Append, IO.FileAccess.Write)
        'StreamWriter ise, FS'da belirttiðmiz dosyaya metin eklemesi yapar.

        Dim SW As System.IO.StreamWriter = New System.IO.StreamWriter(FS, System.Text.ASCIIEncoding.GetEncoding("iso-8859-9"))
        '(Dim SW As System.IO.StreamWriter = New System.IO.StreamWriter(FS, System.Text.UTF8Encoding.UTF8) yukardakinin aynýsýný yapar..

        'StreamWriter kullanarak metni yaz diyoruz..
        SW.Write(Text)
        'Sonra StreamWriter'ý kapatýyoruz.
        SW.Close()
        'Dosyayý FileStream 'ý kapatýyoruz.
        FS.Close()
    End Sub

    'Dosya olusturulup kodlarýn eklenmesi..
    Public Sub WritingCreateFile(ByVal FilePath As String, ByVal Text As String)
        'Belirtilen konuma str(eklenecek metni alarak) dosya olusturma..
        Dim FileStream As System.IO.FileStream
        FileStream = New System.IO.FileStream(FilePath, IO.FileMode.Create, IO.FileAccess.Write)

        Dim FileWriter As System.IO.StreamWriter
        FileWriter = New System.IO.StreamWriter(FileStream, System.Text.Encoding.UTF8)
        'FileWriter = New System.IO.StreamWriter(FileStream, System.Text.ASCIIEncoding.GetEncoding("ISO-8859-9"))

        FileWriter.Write(Text)

        FileWriter.Close()
        FileStream.Close()
    End Sub

    Public Sub New()

    End Sub
End Class

Public Class FileReading
    Public Function FileRead(ByVal FilePath As String) As String
        Dim Text As String = ""

        Dim FS As System.IO.FileStream = New System.IO.FileStream(FilePath, IO.FileMode.Open, IO.FileAccess.Read)
        Dim SR As System.IO.StreamReader = New System.IO.StreamReader(FS, System.Text.ASCIIEncoding.GetEncoding("iso-8859-1"))

        Text += SR.ReadToEnd

        SR.Close()
        FS.Close()

        Return Text
    End Function

    Public Sub New()

    End Sub
End Class

Public Class WritingFromDataTable

    'DataTable'Dan TextFile içeriðine ekleme..
    Public Sub WriteTEXTFile(ByVal SourceTable As DataTable, ByVal FilePath As String, ByVal Toplam As String)
        Dim Statement As String = ""

        'DataTable'ýn tüm satýrlarý için dönülür..
        For i As Integer = 0 To SourceTable.Rows.Count - 1
            'Herbir kolon için..
            For j As Integer = 0 To SourceTable.Columns.Count - 1
                Statement &= SourceTable.Columns.Item(j).Caption.ToString & " : "
                Statement &= SourceTable.Rows(i)(j).ToString & vbCrLf
            Next
            Statement &= vbCrLf
        Next

        Statement &= vbCrLf & "=============================" & vbCrLf & "      Toplam : " & Toplam & vbCrLf

        'Belirtilen konuma Text dosya olusturma..
        Dim FC As WritingToTextFile = New WritingToTextFile
        FC.WritingCreateFile(FilePath, Statement)
    End Sub

    'DataTable'Dan HTML içeriði oluþturma..
    Public Sub WriteHTMLFile(ByVal SourceTable As DataTable, ByVal FilePath As String, ByVal TableCaption As String, ByVal CSSCodePath As String, ByVal JavaCodePath As String, ByVal Toplam As Single)

        '======================
        'Read CSS Code
        '======================
        Dim ReadCSS As FileReading = New FileReading
        Dim CssCode As String = ReadCSS.FileRead(CSSCodePath)

        '======================
        'Read Java Code
        '======================
        Dim ReadJava As FileReading = New FileReading
        Dim JavaCode As String = ReadJava.FileRead(JavaCodePath)

        '
        'First Statment(HTML File Information)
        '
        Dim TopStatment As String = "<!DOCTYPE html PUBLIC " & Chr(34) & "-//W3C//DTD XHTML 1.0 Transitional//TR" & Chr(34) & " " & Chr(34) & "http://www.w3.org//TR/xhtml1/DTD/xhtml1-transitional.dtd" & Chr(34) & ">" & vbCrLf & _
"<html xmlns=" & Chr(34) & "http://www.w3.org/1999/xhtml" & Chr(34) & ">" & vbCrLf & _
"<head>" & vbCrLf & _
"    <title>" & TableCaption & "</title>" & vbCrLf & _
"<meta http-equiv=" & Chr(34) & "content-type" & Chr(34) & vbCrLf & _
"    content=" & Chr(34) & "text/html; charset=iso-8859-1" & Chr(34) & " />" & vbCrLf & _
"<Style>" & vbCrLf & CssCode & vbCrLf & "</Style>" & vbCrLf & _
"</head>" & vbCrLf & _
"<body>" & vbCrLf & _
"<table class=" & Chr(34) & "datatable" & Chr(34) & ">" & vbCrLf & vbCrLf & _
"  <caption>" & TableCaption & "</caption>" & vbCrLf & _
"<!--Tablodaki kolon basliklari..-->"

        '
        'SecondStatment(Insert Columns Caption)
        '
        Dim MiddleStatment As String = "        <tr>" & vbCrLf
        For i As Integer = 0 To SourceTable.Columns.Count - 1
            MiddleStatment &= "    <th scope=" & Chr(34) & "col" & Chr(34) & ">" & SourceTable.Columns.Item(i).Caption.ToString & "</th>" & vbCrLf
        Next
        MiddleStatment &= "        </tr>" & vbCrLf

        '
        'ThirdStatment(Drawing Line)
        '
        Dim ThirdStatment As String = ""
        For i As Integer = 0 To SourceTable.Rows.Count
            '==========================
            'Satýr için Comment yazma..
            '==========================
            ThirdStatment &= "<!--" & i & ".satýr -->" & vbCrLf
            '==========================
            'Satýr aþýrý renkendirme..
            '==========================
            If i Mod 2 = 0 Then
                ThirdStatment &= "       <tr>" & vbCrLf
            Else
                ThirdStatment &= "       <tr class=" & Chr(34) & "altrow_" & Chr(34) & ">" & vbCrLf
            End If
            '==========================
            'Satýrlarý Yazma..
            '==========================
            For j As Integer = 0 To SourceTable.Columns.Count - 1
                If Not i = SourceTable.Rows.Count Then
                    ThirdStatment &= "    <td>" & SourceTable.Rows(i)(j).ToString & "</td>" & vbCrLf
                Else
                    If j = SourceTable.Columns.Count - 2 Then ThirdStatment &= "    <td style=" & Chr(34) & " font-style:italic; font-weight:bold;" & Chr(34) & ">" & "TOPLAM : " & "</td>" & vbCrLf
                    If j = SourceTable.Columns.Count - 1 Then ThirdStatment &= "    <td style=" & Chr(34) & " font-style:italic; font-weight:bold;" & Chr(34) & ">" & Toplam.ToString & "</td>" & vbCrLf
                    If j < SourceTable.Columns.Count - 2 Then ThirdStatment &= "    <td></td>" & vbCrLf
                End If
            Next
            'Satýrý sonlandýrma..
            ThirdStatment &= "       </tr>" & vbCrLf
        Next

        '
        'EndStatement(Closing Statement)
        '
        Dim EndSatetment As String = "<!--Table Body HTML kapanýþ cumleleri..-->" & vbCrLf
        EndSatetment &= "    </table>" & vbCrLf & vbCrLf

        '==========================
        'JavaScript Kodu ve Kapanýþ
        '==========================
        EndSatetment &= JavaCode & vbCrLf & _
        "</body>" & vbCrLf & _
        "</html>" & vbCrLf

        Dim FC As WritingToTextFile = New WritingToTextFile
        FC.WritingCreateFile(FilePath, TopStatment & MiddleStatment & ThirdStatment & EndSatetment)
    End Sub

    'Instance olusturma..
    Public Sub New()

    End Sub
End Class

Public Class XML

    Public Sub New()

    End Sub

    'DataTable'dan XML File oluþturacak Sub..
    Public Sub XMLFileWriter(ByVal Source As DataTable, ByVal TargetPath As String)

        Dim XTW As XmlTextWriter = New XmlTextWriter(TargetPath, System.Text.Encoding.GetEncoding("ISO-8859-9"))


        Dim Caption As String = ""
        Dim Value As String = ""

        XTW.Formatting = Formatting.Indented

        XTW.WriteStartDocument()

        XTW.WriteStartElement("Main", "")

        'Herbir satýr için dönülür..
        For i As Integer = 0 To Source.Rows.Count - 1

            'Her satýr için yukardaki örnekte oldugu gibi "row" tag açýlýr.Row tag'ýný açtýk ama kapanýþý kolonlarý okuduktan sonra olacak..
            XTW.WriteStartElement("Row")
            'Bu kýsým isteðe baðlýdýr ben herbir satýr için birde Attribute dediðimiz XML de,row elementine "rowID" özelliði ekliyorum.
            XTW.WriteStartAttribute("rowID", i)

            'Yukarda her satýr için dönerken; her satýr için her kolon için dönülür..
            For k As Integer = 0 To Source.Columns.Count - 1
                'Eðer kolon baþlýðýnda boþluk karakteri varsa bu þekilde bir tag tanýmlamamýz hataya yol açacaðýndan onu kaldýrmamýz gerekiyor..
                'Eðer kolon baþlýðýnda boþluk varsa;
                If Not Source.Columns(k).Caption.ToString.IndexOf(" ") = -1 Then
                    'Baþlýðý sýfýrla..
                    Caption = ""
                    'Baþlýktaki herbir karakter için dön!
                    For Each chr As Char In Source.Columns(k).Caption.ToString.ToCharArray
                        'Eðer okunan karakter boþluk deðilse "Caption" 'a ekle.Boþluk ise ekleme yapmayacaktýr.Böylece örneðin; "Günlük Satýþ" þeklinde bir baþlýk "GünlükSatýþ" olacaktýr..
                        If Not Char.IsWhiteSpace(chr) = True Then
                            Caption &= chr
                        End If
                    Next
                Else
                    'Eðer kolon adýnda bir boþluk karakteri yoksa o zaman aynen alýnacaktýr..Aslýnda bu Else kýsmý yazýlmayýp her halukarda ForEach ile tüm karakterler kontrol edilip Caption oluþturulabilirdi.Ama bi düþünün çok fazla kolon varsa ve eðer boþluk karakteri içermiyorsa neden bidaha tüm karakterleri için boþluk varmý diye sorgulayalým!Dimi? :)
                    Caption = Source.Columns(k).Caption.ToString
                End If

                'DataTable'dan o anki okuduðumuz satýrda ,okuduðumuz kolonun deðeri "Value" 'ya aktarýlýr..
                Value = Source.Rows(i)(k).ToString
                'XmlTextWriter'ýn WriteElementString metodu ile Element(Caption) ve Deðeri(Value) eklenir..
                XTW.WriteElementString(Caption, Value)
            Next
            'Yukarda Row tag'ý açmýþtýk ve iþte yazdýðýmýz satýr için row tag'ýný kapatýyoruz.Döngü DataTable'daki satýr sayýsý kadar devam eder ve satýrlar tek tek "row" tag'ý açýlarak XML dosyaya yazýlýr..
            XTW.WriteEndElement()
        Next
        'Root tag de kapatýlýr..
        XTW.WriteEndElement()
        'XML döküman yazýmý sonlandýrýlýr..Bu kýsmý sakýn unutmayýn yoksa XML dosya çalýþmaz.XML döküman yazarken mutlaka "WriteStartDocument" ile baþlar ve "WriteEndDocument" ile biter.
        XTW.WriteEndDocument()
        'XML dosya kapatýlýr..Bir XML dosya açýkken onun üzerinde baþka bir iþlem yapýlamaz..
        XTW.Close()
    End Sub

    'Belirtilen konumdaki XML dosyadan DataTable oluþturalým.
    Public Function ReadXMLFile(ByVal TargetPath As String) As DataTable

        'Function sonunda geri döndürülecek DataTable..
        Dim DT As DataTable = New DataTable

        'Yeni bir xmlDocument nesnesi oluþturulur..
        Dim myXmlDoc As XmlDocument = New XmlDocument()
        'Okunacak Xml dökümaný myXmlDoc nesnesine, konumu belirtilerek atanýr
        myXmlDoc.Load(TargetPath)

        'Root tag 'i "RootNode" nesnesine atanýyor.
        Dim RootNode As XmlNode = myXmlDoc.ChildNodes(1)

        'Aþaðýdaki döngü içinde her seferinde kolon oluþmasýn diye KolonlarOlustu adlý deðiþken False olduðu sürece kolon oluþacak. Hemen ilk kolon oluþmasýnda biz bu deðeri True yapacaz ve bidaha kolon oluþmayacak..
        Dim KolonlarOlustu As Boolean = False

        'Herbir RootNode altýndaki ChildNode için..
        'Burdaki ChildNode'larýn her biri Datatable'ýmýz 
        'için Row 'lar oluyor..
        For Each NodeSatir As XmlNode In RootNode.ChildNodes

            Dim DR As DataRow = DT.NewRow

            'Herbir Row altýndaki child node için..
            For i As Integer = 0 To NodeSatir.ChildNodes.Count - 1
                'Herbir RootNode altýndaki ChildNode(satýrlar) altýndaki ChildNode(kolonlar) için.
                If KolonlarOlustu = False Then
                    'Bu kýsým sadece node1'in childNode sayýsý kadar dönüyor.
                    'Böylece DataTable için kolonlar oluþuyor..
                    DT.Columns.Add(NodeSatir.ChildNodes(i).Name)
                End If
                'Oluþturulan DataRow 'a XML'deki deðerler aktarýlýr..
                DR(i) = NodeSatir.ChildNodes(i).InnerText
            Next

            'Tekrar Kolonlar oluþturulmasýn diye deðiþken "True" yapýlýr..
            KolonlarOlustu = True

            'DataRow(DataSatýrý) DataTable'a eklenir..
            DT.Rows.Add(DR)
        Next

        'DataTable gönderilir..
        Return DT
    End Function
End Class

