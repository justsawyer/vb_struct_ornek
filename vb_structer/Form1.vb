Public Class Form1
    Enum OgrenciDurumu
        Normalkayit
        YatayGelen
        DikeyGelen
        AftanDonen
    End Enum

    Structure UserBilgi
        Public KullaniciIsmi As String
        Private KullaniciSifresi As String
        Public Adi As String
        Public soyadi As String

        Public Sub set_KullaniciSifresi(ByVal sifre As String)
            KullaniciSifresi = sifre
        End Sub

        Public Function get_KullaniciSifresi() As String
            Return KullaniciIsmi
        End Function

    End Structure
    Structure AdresBilgi
        Private Adresi As String
        Private sehiri As String
        Private ilcesi As String
        Private telefonu As String
        Private GSMsi As String
    End Structure
    Structure Kullanici
        Public durum As OgrenciDurumu
        Public UserB As UserBilgi
        Public AdresB As AdresBilgi

    End Structure
    Dim i As Integer = 0
    Dim kisi(100) As Kullanici
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        kisi(i).UserB.KullaniciIsmi = txt_kIsmi.Text
        kisi(i).UserB.Adi = txt_kAdi.Text
        kisi(i).UserB.soyadi = txt_kSoyadi.Text
        kisi(i).UserB.set_KullaniciSifresi(txt_sifre.Text)
        i += 1
        'abc
    End Sub
End Class
