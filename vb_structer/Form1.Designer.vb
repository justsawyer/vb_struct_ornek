<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btn_guncelle = New System.Windows.Forms.Button()
        Me.btn_listele = New System.Windows.Forms.Button()
        Me.btn_sil = New System.Windows.Forms.Button()
        Me.btn_ara = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_gsm = New System.Windows.Forms.TextBox()
        Me.txt_telefon = New System.Windows.Forms.TextBox()
        Me.txt_ilce = New System.Windows.Forms.TextBox()
        Me.txt_sehir = New System.Windows.Forms.TextBox()
        Me.txt_adres = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_kSoyadi = New System.Windows.Forms.TextBox()
        Me.txt_kAdi = New System.Windows.Forms.TextBox()
        Me.txt_sifre = New System.Windows.Forms.TextBox()
        Me.txt_kIsmi = New System.Windows.Forms.TextBox()
        Me.btn_ekle = New System.Windows.Forms.Button()
        Me.txt_aranacak = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_guncelle
        '
        Me.btn_guncelle.Location = New System.Drawing.Point(642, 277)
        Me.btn_guncelle.Name = "btn_guncelle"
        Me.btn_guncelle.Size = New System.Drawing.Size(75, 23)
        Me.btn_guncelle.TabIndex = 15
        Me.btn_guncelle.Text = "GÜNCELLE"
        Me.btn_guncelle.UseVisualStyleBackColor = True
        '
        'btn_listele
        '
        Me.btn_listele.Location = New System.Drawing.Point(561, 277)
        Me.btn_listele.Name = "btn_listele"
        Me.btn_listele.Size = New System.Drawing.Size(75, 23)
        Me.btn_listele.TabIndex = 14
        Me.btn_listele.Text = "LİSTELE"
        Me.btn_listele.UseVisualStyleBackColor = True
        '
        'btn_sil
        '
        Me.btn_sil.Location = New System.Drawing.Point(480, 277)
        Me.btn_sil.Name = "btn_sil"
        Me.btn_sil.Size = New System.Drawing.Size(75, 23)
        Me.btn_sil.TabIndex = 13
        Me.btn_sil.Text = "SİL"
        Me.btn_sil.UseVisualStyleBackColor = True
        '
        'btn_ara
        '
        Me.btn_ara.Location = New System.Drawing.Point(399, 277)
        Me.btn_ara.Name = "btn_ara"
        Me.btn_ara.Size = New System.Drawing.Size(75, 23)
        Me.btn_ara.TabIndex = 12
        Me.btn_ara.Text = "ARA"
        Me.btn_ara.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_gsm)
        Me.GroupBox2.Controls.Add(Me.txt_telefon)
        Me.GroupBox2.Controls.Add(Me.txt_ilce)
        Me.GroupBox2.Controls.Add(Me.txt_sehir)
        Me.GroupBox2.Controls.Add(Me.txt_adres)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(318, 10)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(328, 259)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Adres Bilgileri"
        '
        'txt_gsm
        '
        Me.txt_gsm.Location = New System.Drawing.Point(81, 215)
        Me.txt_gsm.Multiline = True
        Me.txt_gsm.Name = "txt_gsm"
        Me.txt_gsm.Size = New System.Drawing.Size(218, 20)
        Me.txt_gsm.TabIndex = 9
        '
        'txt_telefon
        '
        Me.txt_telefon.Location = New System.Drawing.Point(81, 189)
        Me.txt_telefon.Multiline = True
        Me.txt_telefon.Name = "txt_telefon"
        Me.txt_telefon.Size = New System.Drawing.Size(218, 20)
        Me.txt_telefon.TabIndex = 8
        '
        'txt_ilce
        '
        Me.txt_ilce.Location = New System.Drawing.Point(81, 163)
        Me.txt_ilce.Multiline = True
        Me.txt_ilce.Name = "txt_ilce"
        Me.txt_ilce.Size = New System.Drawing.Size(218, 20)
        Me.txt_ilce.TabIndex = 7
        '
        'txt_sehir
        '
        Me.txt_sehir.Location = New System.Drawing.Point(81, 137)
        Me.txt_sehir.Multiline = True
        Me.txt_sehir.Name = "txt_sehir"
        Me.txt_sehir.Size = New System.Drawing.Size(218, 20)
        Me.txt_sehir.TabIndex = 6
        '
        'txt_adres
        '
        Me.txt_adres.Location = New System.Drawing.Point(81, 22)
        Me.txt_adres.Multiline = True
        Me.txt_adres.Name = "txt_adres"
        Me.txt_adres.Size = New System.Drawing.Size(218, 111)
        Me.txt_adres.TabIndex = 5
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(17, 220)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(31, 13)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "GSM"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(10, 192)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 13)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Telefon"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(22, 163)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(24, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "İlçe"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(22, 140)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Sehir"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Adresi"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(11, 172)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(285, 150)
        Me.DataGridView1.TabIndex = 10
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_kSoyadi)
        Me.GroupBox1.Controls.Add(Me.txt_kAdi)
        Me.GroupBox1.Controls.Add(Me.txt_sifre)
        Me.GroupBox1.Controls.Add(Me.txt_kIsmi)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(285, 133)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sistem Bilgileri"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(34, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Kullanıcı Soyadı"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Kullanıcı Adı"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Şifre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Kullanıcı İsmi"
        '
        'txt_kSoyadi
        '
        Me.txt_kSoyadi.Location = New System.Drawing.Point(117, 97)
        Me.txt_kSoyadi.Name = "txt_kSoyadi"
        Me.txt_kSoyadi.Size = New System.Drawing.Size(144, 20)
        Me.txt_kSoyadi.TabIndex = 3
        '
        'txt_kAdi
        '
        Me.txt_kAdi.Location = New System.Drawing.Point(117, 71)
        Me.txt_kAdi.Name = "txt_kAdi"
        Me.txt_kAdi.Size = New System.Drawing.Size(144, 20)
        Me.txt_kAdi.TabIndex = 2
        '
        'txt_sifre
        '
        Me.txt_sifre.Location = New System.Drawing.Point(117, 45)
        Me.txt_sifre.Name = "txt_sifre"
        Me.txt_sifre.Size = New System.Drawing.Size(144, 20)
        Me.txt_sifre.TabIndex = 1
        '
        'txt_kIsmi
        '
        Me.txt_kIsmi.Location = New System.Drawing.Point(117, 19)
        Me.txt_kIsmi.Name = "txt_kIsmi"
        Me.txt_kIsmi.Size = New System.Drawing.Size(144, 20)
        Me.txt_kIsmi.TabIndex = 0
        '
        'btn_ekle
        '
        Me.btn_ekle.Location = New System.Drawing.Point(318, 277)
        Me.btn_ekle.Name = "btn_ekle"
        Me.btn_ekle.Size = New System.Drawing.Size(75, 23)
        Me.btn_ekle.TabIndex = 8
        Me.btn_ekle.Text = "EKLE"
        Me.btn_ekle.UseVisualStyleBackColor = True
        '
        'txt_aranacak
        '
        Me.txt_aranacak.Location = New System.Drawing.Point(399, 306)
        Me.txt_aranacak.Name = "txt_aranacak"
        Me.txt_aranacak.Size = New System.Drawing.Size(100, 20)
        Me.txt_aranacak.TabIndex = 16
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(314, 309)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(79, 13)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Aranacak Kayıt"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(80, 153)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(142, 13)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Güncellenecek ögeyi seciniz"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(720, 352)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txt_aranacak)
        Me.Controls.Add(Me.btn_guncelle)
        Me.Controls.Add(Me.btn_listele)
        Me.Controls.Add(Me.btn_sil)
        Me.Controls.Add(Me.btn_ara)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_ekle)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_guncelle As System.Windows.Forms.Button
    Friend WithEvents btn_listele As System.Windows.Forms.Button
    Friend WithEvents btn_sil As System.Windows.Forms.Button
    Friend WithEvents btn_ara As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_gsm As System.Windows.Forms.TextBox
    Friend WithEvents txt_telefon As System.Windows.Forms.TextBox
    Friend WithEvents txt_ilce As System.Windows.Forms.TextBox
    Friend WithEvents txt_sehir As System.Windows.Forms.TextBox
    Friend WithEvents txt_adres As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_kSoyadi As System.Windows.Forms.TextBox
    Friend WithEvents txt_kAdi As System.Windows.Forms.TextBox
    Friend WithEvents txt_sifre As System.Windows.Forms.TextBox
    Friend WithEvents txt_kIsmi As System.Windows.Forms.TextBox
    Friend WithEvents btn_ekle As System.Windows.Forms.Button
    Friend WithEvents txt_aranacak As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label

End Class
