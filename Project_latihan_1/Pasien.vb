Public Class Pasien
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        'If Not String.IsNullOrEmpty(Pendaftaran.foto_pasien) Then
        '    PictFoto.Load(Pendaftaran.foto_pasien)
        '    PictFoto.SizeMode = PictureBoxSizeMode.StretchImage
        'End If

        If Not String.IsNullOrEmpty(Pendaftaran.fungsiKamar.GSFoto) Then
            PictFoto.Load(Pendaftaran.fungsiKamar.GSFoto)
            PictFoto.SizeMode = PictureBoxSizeMode.StretchImage
        End If

        'LblNameValue.Text = Pendaftaran.nama
        LblNameValue.Text = Pendaftaran.fungsiKamar.GSNama
        'LblNIKValue.Text = Pendaftaran.NIK
        LblNIKValue.Text = Pendaftaran.fungsiKamar.GSNIK
        'LblJenisKelaminValue.Text = Pendaftaran.jenis_kelamin
        LblJenisKelaminValue.Text = Pendaftaran.fungsiKamar.GSJenisKelamin
        'LblTanggalLahirValue.Text = Pendaftaran.tanggal_lahir
        LblTanggalLahirValue.Text = Pendaftaran.fungsiKamar.GSTanggal_Lahir
        'LblLayananValue.Text = Pendaftaran.layanan_value
        LblLayananValue.Text = Pendaftaran.fungsiKamar.GSLayanan
        'LblAlamatValue.Text = Pendaftaran.alamat
        LblAlamatValue.Text = Pendaftaran.fungsiKamar.GSAlamat

        ListBoxKeluhan.Items.Clear()

        'For Each kel In Pendaftaran.keluhan_list
        '    ListBoxKeluhan.Items.Add(kel)
        'Next
        For Each kel In Pendaftaran.fungsiKamar.GSKeluhan_List
            ListBoxKeluhan.Items.Add(kel)
        Next

        LblCatatanDokterValue.Text = Pendaftaran.fungsiKamar.GSCatatanDokter
    End Sub
    Private Sub BtnTutupForm_Click(sender As Object, e As EventArgs) Handles BtnTutupForm.Click
        Me.Close()
    End Sub

End Class