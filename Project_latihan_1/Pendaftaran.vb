Imports System.IO
Public Class Pendaftaran

    Public Shared Kamar As Integer = 100

    'Public Shared foto_pasien
    'Public Shared NIK As String
    'Public Shared nama As String
    'Public Shared jenis_kelamin As String
    'Public Shared tanggal_lahir
    'Public Shared alamat
    'Public Shared layanan_value
    'Public Shared catatan_dokter
    Public Shared keluhan_list As New List(Of String)

    Dim max_char_alamat As Integer = 50
    Dim gender
    Dim length_alamat As Integer = 50

    Public Shared fungsiKamar As FungsiKamar

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        'LabelsJumlahKamar.Text = Kamar.ToString()
        'ComboBoxLayanan.DataSource = layanan_value
        fungsiKamar = New FungsiKamar()
        fungsiKamar.GSJumlahKamar = Kamar
        LabelsJumlahKamar.Text = fungsiKamar.GSJumlahKamar

    End Sub

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        Dim tambah_kamar = New tambahkamar()
        tambah_kamar.Show()
    End Sub

    Private Sub Pendaftaran_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        LabelsJumlahKamar.Text = fungsiKamar.GSJumlahKamar
    End Sub

    Private Sub TxtNIK_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNIK.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("Please insert number only")
        End If
    End Sub

    Private Sub TxtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNama.KeyPress
        If TxtNama.Text.Length < 1 Then
            TxtNama.Select()
            MessageBox.Show("Please add at least 1 String")
        End If
    End Sub

    Private Sub RtbAlamat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles RtbAlamat.KeyPress
        If RtbAlamat.Text.Length >= max_char_alamat Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
                MessageBox.Show("Max Length")
            End If
        ElseIf RtbAlamat.Text.Length < max_char_alamat And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Enter) Then
            length_alamat -= 1
            LblLengthAlamat.Text = length_alamat
        ElseIf e.KeyChar = Chr(Keys.Back) Then
            length_alamat += 1
            LblLengthAlamat.Text = length_alamat
            If RtbAlamat.Text.Length = 0 Then
                length_alamat = max_char_alamat
                LblLengthAlamat.Text = length_alamat
            ElseIf RtbAlamat.Text.Length = max_char_alamat Then
                length_alamat = 0
                LblLengthAlamat.Text = length_alamat
            End If
        End If
    End Sub

    Private Sub RdoLaki_CheckedChanged(sender As Object, e As EventArgs) Handles RdoLaki.CheckedChanged
        gender = "Laki - Laki"
    End Sub

    Private Sub RdoPerempuan_CheckedChanged(sender As Object, e As EventArgs) Handles RdoPerempuan.CheckedChanged
        gender = "Perempuan"
    End Sub

    Private Sub BtnShowCbSel_Click(sender As Object, e As EventArgs)
        Dim layanan_item = ComboBoxLayanan.SelectedItem()
        MessageBox.Show(layanan_item)
    End Sub

    Private Sub TambahKamarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TambahKamarToolStripMenuItem.Click
        Dim tambah_kamar = New tambahkamar()
        tambah_kamar.Show()
    End Sub

    Private Sub Pertemuan4ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Pertemuan4ToolStripMenuItem.Click
        Dim latihan_4 = New latihanPertemuan4()
        latihan_4.Show()
    End Sub

    Private Sub Pertemuan5ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Pertemuan5ToolStripMenuItem.Click
        Dim latihan_5 = New LatihanPertemuan5()
        latihan_5.Show()
    End Sub

    Private Sub BtnTampil_Click(sender As Object, e As EventArgs) Handles BtnTampil.Click
        'nama = TxtNama.Text
        fungsiKamar.GSNama = TxtNama.Text.ToString()

        'NIK = TxtNIK.Text
        fungsiKamar.GSNIK = TxtNIK.Text

        'tanggal_lahir = DatePickTanggalLahir.Value.ToShortDateString
        fungsiKamar.GSTanggal_Lahir = DatePickTanggalLahir.Value.ToShortDateString

        'alamat = RtbAlamat.Text
        fungsiKamar.GSAlamat = RtbAlamat.Text

        'jenis_kelamin = gender
        fungsiKamar.GSJenisKelamin = gender

        'layanan_value = ComboBoxLayanan.SelectedItem()
        fungsiKamar.GSLayanan = ComboBoxLayanan.SelectedItem()

        'catatan_dokter = RtbCatatanDokter.Text
        fungsiKamar.GSCatatanDokter = RtbCatatanDokter.Text

        'CheckBox CheckBox Value
        '===============================
        If ChkKel_Pusing.Checked() Then
            fungsiKamar.GSKeluhan_List.Add("Pusing")
        End If

        If ChkKel_Mual.Checked() Then
            fungsiKamar.GSKeluhan_List.Add("Mual")
        End If

        If ChkKel_Demam.Checked() Then
            fungsiKamar.GSKeluhan_List.Add("Demam")
        End If

        'kurangi jumlah kamar
        '===============================
        Kamar -= 1

        'Buka Form Pasien
        '==============================
        Dim pasien_form = New Pasien()
        pasien_form.Show()

    End Sub

    Private Sub BtnTambahFoto_Click(sender As Object, e As EventArgs) Handles BtnTambahFoto.Click
        OpenFileDialog1.Title = "Open Foto"
        OpenFileDialog1.Filter = "Image|*.bmp|Image JPG|*.jpg|Imahe JPEG|*.JPEG|Image PNG|*.png|Image GIF|*.gif|All Format|*.*"
        OpenFileDialog1.ShowDialog()

        PicFoto.Load(OpenFileDialog1.FileName)
        PicFoto.SizeMode = PictureBoxSizeMode.StretchImage
        'foto_pasien = PicFoto.ImageLocation
        fungsiKamar.GSFoto = PicFoto.ImageLocation
    End Sub

    Private Sub BtnOpenFile_Click(sender As Object, e As EventArgs) Handles BtnOpenFile.Click
        Dim fileReader As System.IO.StreamReader
        OpenFileDialog2.InitialDirectory = "~\Documents"
        OpenFileDialog2.Title = "Buka Catatan Dokter"
        OpenFileDialog2.Filter = "Text File [*.txt]|*.txt|All Files [*.*]|*.*"
        If OpenFileDialog2.ShowDialog() = Windows.Forms.DialogResult.OK Then
            OpenFileDialog2.OpenFile()
            fileReader = File.OpenText(OpenFileDialog2.FileName)
            RtbCatatanDokter.Text = fileReader.ReadToEnd()
            fileReader.Close()
        End If
    End Sub

    Private Sub Pertemuan6ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Pertemuan6ToolStripMenuItem.Click
        Dim latihan_6 = New latihanPertemuan6()
        latihan_6.Show()
    End Sub

    Private Sub BtnHitungBiaya_Click(sender As Object, e As EventArgs) Handles BtnHitungBiaya.Click
        If TxtHariInap.Text.Length > 0 Then
            fungsiKamar.SetHariInap = Integer.Parse(TxtHariInap.Text)
            Dim biaya As Integer = fungsiKamar.HitungBiaya()
            LblTotalBiaya.Text = biaya
        End If
    End Sub
End Class
