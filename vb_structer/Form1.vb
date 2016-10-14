Public Class Form1
  

    Structure UserBilgi
        Public KullaniciIsmi As String
        Private KullaniciSifresi As String
        Public Adi As String
        Public soyadi As String

        Public Sub set_KullaniciSifresi(ByVal sifre As String)
            KullaniciSifresi = sifre
        End Sub

        Public Function get_KullaniciSifresi() As String
            Return KullaniciSifresi
        End Function

    End Structure
    Structure AdresBilgi
        Private Adresi As String
        Private sehiri As String
        Private ilcesi As String
        Private telefonu As String
        Private GSMsi As String

        Public Sub set_Adres(ByVal address As String)
            Adresi = address
        End Sub
        Public Sub set_sehir(ByVal city As String)
            sehiri = city
        End Sub
        Public Sub set_ilcesi(ByVal district As String)
            ilcesi = district
        End Sub
        Public Sub set_telefon(ByVal telephone As String)
            telefonu = telephone
        End Sub
        Public Sub set_gsm(ByVal mobilePhone As String)
            GSMsi = mobilePhone
        End Sub


        Public Function get_adres() As String
            Return Adresi
        End Function
        Public Function get_sehir() As String
            Return sehiri
        End Function
        Public Function get_ilce() As String
            Return ilcesi
        End Function
        Public Function get_telefon() As String
            Return telefonu
        End Function

        Public Function get_gsm() As String
            Return GSMsi
        End Function
    End Structure
    Structure Kullanici

        Public UserB As UserBilgi
        Public AdresB As AdresBilgi

    End Structure
    Dim i As Integer = 0
    Dim kisi(100) As Kullanici

    Public Sub Temizle()
        txt_adres.Text = ""
        txt_aranacak.Text = ""
        txt_gsm.Text = ""
        txt_ilce.Text = ""
        txt_kSoyadi.Text = ""
        txt_kAdi.Text = ""
        txt_kIsmi.Text = ""
        txt_telefon.Text = ""
        txt_sehir.Text = ""
        txt_sifre.Text = ""

    End Sub
    Private Sub btn_ekle_Click(sender As Object, e As EventArgs) Handles btn_ekle.Click
        'userB
        kisi(i).UserB.KullaniciIsmi = txt_kIsmi.Text
        kisi(i).UserB.Adi = txt_kAdi.Text
        kisi(i).UserB.soyadi = txt_kSoyadi.Text
        kisi(i).UserB.set_KullaniciSifresi(txt_sifre.Text)

        'AdresB
        kisi(i).AdresB.set_Adres(txt_adres.Text)
        kisi(i).AdresB.set_ilcesi(txt_ilce.Text)
        kisi(i).AdresB.set_sehir(txt_sehir.Text)
        kisi(i).AdresB.set_telefon(txt_telefon.Text)
        kisi(i).AdresB.set_gsm(txt_gsm.Text)


        i += 1
        Temizle()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btn_guncelle.Enabled = False
        btn_sil.Enabled = False

    End Sub
    Dim sayac As Integer
    Public Sub gridViewGetir()
        DataGridView1.Rows.Add()
        DataGridView1.Rows(sayac).Cells(0).Value = kisi(sayac).UserB.KullaniciIsmi
        DataGridView1.Rows(sayac).Cells(1).Value = kisi(sayac).UserB.get_KullaniciSifresi()
        DataGridView1.Rows(sayac).Cells(2).Value = kisi(sayac).UserB.Adi
        DataGridView1.Rows(sayac).Cells(3).Value = kisi(sayac).UserB.soyadi


        DataGridView1.Rows(sayac).Cells(4).Value = kisi(sayac).AdresB.get_adres()
        DataGridView1.Rows(sayac).Cells(5).Value = kisi(sayac).AdresB.get_sehir()
        DataGridView1.Rows(sayac).Cells(6).Value = kisi(sayac).AdresB.get_ilce()
        DataGridView1.Rows(sayac).Cells(7).Value = kisi(sayac).AdresB.get_telefon()
        DataGridView1.Rows(sayac).Cells(8).Value = kisi(sayac).AdresB.get_gsm()
    End Sub
    Public Sub gridSutunGetir()
        DataGridView1.Columns.Clear()


        DataGridView1.Columns.Add("isim", "İSİM")
        DataGridView1.Columns.Add("sifre", "Şifre")
        DataGridView1.Columns.Add("Adi", "ADI")
        DataGridView1.Columns.Add("soyad", "SOYAD")

        DataGridView1.Columns.Add("adres", "ADRES")
        DataGridView1.Columns.Add("sehir", "SEHIR")
        DataGridView1.Columns.Add("ilce", "ILCE")
        DataGridView1.Columns.Add("telefon", "TELEFON")
        DataGridView1.Columns.Add("gsm", "GSM")


    End Sub

    Public Sub listele()
        gridSutunGetir()


        For Me.sayac = 0 To (i - 1)

            gridViewGetir()
        Next
    End Sub
    Private Sub btn_listele_Click(sender As Object, e As EventArgs) Handles btn_listele.Click
     
        listele()

    End Sub

    Private Sub btn_ara_Click(sender As Object, e As EventArgs) Handles btn_ara.Click
        gridSutunGetir()
        Dim aranan As String = txt_aranacak.Text
        For Me.sayac = 0 To i - 1
            If kisi(sayac).UserB.KullaniciIsmi = aranan Then
                gridViewGetir()
            End If

        Next


    End Sub
    Dim kulAdiGun As String
    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click

        kulAdiGun = DataGridView1.CurrentRow.Cells(0).Value.ToString()
        txt_kIsmi.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString()
        txt_sifre.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString()
        txt_kAdi.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString()
        txt_kSoyadi.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString()

        txt_adres.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString()
        txt_sehir.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString()
        txt_ilce.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString()
        txt_telefon.Text = DataGridView1.CurrentRow.Cells(7).Value.ToString()
        txt_gsm.Text = DataGridView1.CurrentRow.Cells(8).Value.ToString()
        btn_guncelle.Enabled = True
    End Sub

    Private Sub btn_guncelle_Click(sender As Object, e As EventArgs) Handles btn_guncelle.Click


        For Me.sayac = 0 To i - 1
            If kisi(sayac).UserB.KullaniciIsmi = kulAdiGun Then
                'UserB
                kisi(sayac).UserB.KullaniciIsmi = txt_kIsmi.Text
                kisi(sayac).UserB.Adi = txt_kAdi.Text
                kisi(sayac).UserB.soyadi = txt_kSoyadi.Text
                kisi(sayac).UserB.set_KullaniciSifresi(txt_sifre.Text)

                'AdresB
                kisi(sayac).AdresB.set_Adres(txt_adres.Text)
                kisi(sayac).AdresB.set_ilcesi(txt_ilce.Text)
                kisi(sayac).AdresB.set_sehir(txt_sehir.Text)
                kisi(sayac).AdresB.set_telefon(txt_telefon.Text)
                kisi(sayac).AdresB.set_gsm(txt_gsm.Text)
            End If

        Next
        listele()
        btn_guncelle.Enabled = False
    End Sub

    

  
    Private Sub btn_sil_Click(sender As Object, e As EventArgs) Handles btn_sil.Click
        For Me.sayac = 0 To i - 1
            If kisi(sayac).UserB.KullaniciIsmi = kulAdiGun Then
                'UserB
                kisi(sayac).UserB.KullaniciIsmi = kisi(sayac + 1).UserB.KullaniciIsmi
                kisi(sayac).UserB.Adi = kisi(sayac + 1).UserB.Adi
                kisi(sayac).UserB.soyadi = kisi(sayac + 1).UserB.soyadi
                kisi(sayac).UserB.set_KullaniciSifresi(kisi(sayac + 1).UserB.get_KullaniciSifresi())

                'AdresB
                kisi(sayac).AdresB.set_Adres(kisi(sayac + 1).AdresB.get_adres())
                kisi(sayac).AdresB.set_ilcesi(kisi(sayac + 1).AdresB.get_ilce())
                kisi(sayac).AdresB.set_sehir(kisi(sayac + 1).AdresB.get_sehir())
                kisi(sayac).AdresB.set_telefon(kisi(sayac + 1).AdresB.get_telefon())
                kisi(sayac).AdresB.set_gsm(kisi(sayac + 1).AdresB.get_gsm())
            End If
        Next
        i -= 1
        listele()
        btn_sil.Enabled = False
    End Sub
End Class
