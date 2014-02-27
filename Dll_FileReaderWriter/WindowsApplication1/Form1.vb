Public Class Form1

    Private Sub btnKaydet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKaydetClass.Click

        'Kullanýcýya birkaç dosya uzantýsý seçme imkaný verdik.Bu kýsmý siz zenginleþtirebilirsiniz..Unutmayýki uzantýsý ne olursa olsun yazdýrdýðýnýz dosya "Not Defteri" ile kolayca okunabilir.
        SaveFileDialog1.Filter = "Metin Belgesi(*.txt)|*.txt|Word Belgesi(*.doc)|*.doc|Rastgele Belge(*.abc)|*.abc"

        'SaveFileDialog1'in ShowDialog metodu ile Dosya Kaydetme penceresi açtýrýyorum..
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            'Oluþturduðumuz Class'dan instance(nesne) oluþturuyoruz.
            Dim cls As DLL_FileReaderWriter.WritingToTextFile = New DLL_FileReaderWriter.WritingToTextFile

            'WritingAppendFile metodunu çaðýrarak yazdýrma,WritingCreateFile metodunuda çaðýrablirdik.Tamamen amacýnýza baðlý ikisininde ne iþe yaradýðý biliyorsunuz..iki metotta da Dosya konumunu ve Metni gönderiyorum.
            cls.WritingCreateFile(SaveFileDialog1.FileName, RichTextBox1.Text)
        End If

    End Sub

    Private Sub btnOkuClass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOkuClass.Click
        'Kullanýcýnýn açabileceði dosyalarý kýsýtlayabilirsiniz..
        OpenFileDialog1.Filter = "Metin Belgesi(*.txt)|*.txt|Word Belgesi(*.doc)|*.doc|Rastgele Belge(*.abc)|*.abc"
        'Ýlk filter'ýn seçilmesini saðladým.Yani *.txt lerin görünmesini..
        OpenFileDialog1.FilterIndex = 0

        'OpenFileDialog1'in ShowDialog metodu ile Dosya açma penceresi açtýrýyorum..
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            'Oluþturduðumuz Class'dan instance(nesne) oluþturuyoruz.
            Dim cls As DLL_FileReaderWriter.FileReading = New DLL_FileReaderWriter.FileReading

            'Kullanýcýnýn OpenFileDialog1 penceresinden seçtiði dosyanýn içeriðini yarattýðýmýz Class'daki "FileRead" metodu ile okutuyoruz ve RichTextBox1.Text 'e aktarýyoruz.
            RichTextBox1.Text = cls.FileRead(OpenFileDialog1.FileName)
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        SaveFileDialog1.Filter = "Metin Belgesi(*.txt)|*.txt|Word Belgesi(*.doc)|*.doc|Rastgele Belge(*.abc)|*.abc"

        'SaveFileDialog1'in ShowDialog metodu ile Dosya Kaydetme penceresi açtýrýyorum..
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            RichTextBox1.SaveFile(SaveFileDialog1.FileName, RichTextBoxStreamType.PlainText)
        End If

    End Sub
End Class
