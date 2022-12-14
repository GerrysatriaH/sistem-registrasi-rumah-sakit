<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Pendaftaran
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pendaftaran))
        Me.TxtNIK = New System.Windows.Forms.TextBox()
        Me.LblNIK = New System.Windows.Forms.Label()
        Me.PnlLogo = New System.Windows.Forms.Panel()
        Me.LblRumahSakit = New System.Windows.Forms.Label()
        Me.LblNama = New System.Windows.Forms.Label()
        Me.TxtNama = New System.Windows.Forms.TextBox()
        Me.LblPNJ = New System.Windows.Forms.Label()
        Me.LblJumlah = New System.Windows.Forms.Label()
        Me.BtnTambah = New System.Windows.Forms.Button()
        Me.LblJenisKelamin = New System.Windows.Forms.Label()
        Me.RdoLaki = New System.Windows.Forms.RadioButton()
        Me.RdoPerempuan = New System.Windows.Forms.RadioButton()
        Me.BtnTampil = New System.Windows.Forms.Button()
        Me.LabelsJumlahKamar = New System.Windows.Forms.Label()
        Me.LblAlamat = New System.Windows.Forms.Label()
        Me.RtbAlamat = New System.Windows.Forms.RichTextBox()
        Me.LblLengthAlamat = New System.Windows.Forms.Label()
        Me.GbJenis = New System.Windows.Forms.GroupBox()
        Me.ComboBoxLayanan = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ChkKel_Demam = New System.Windows.Forms.CheckBox()
        Me.ChkKel_Mual = New System.Windows.Forms.CheckBox()
        Me.ChkKel_Pusing = New System.Windows.Forms.CheckBox()
        Me.DatePickTanggalLahir = New System.Windows.Forms.DateTimePicker()
        Me.LblTanggalLahir = New System.Windows.Forms.Label()
        Me.LblLayanan = New System.Windows.Forms.Label()
        Me.LblKeluhan = New System.Windows.Forms.Label()
        Me.BtnTambahFoto = New System.Windows.Forms.Button()
        Me.RtbCatatanDokter = New System.Windows.Forms.RichTextBox()
        Me.LblCatatanDokter = New System.Windows.Forms.Label()
        Me.BtnOpenFile = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MainToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KamarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TambahKamarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LatihanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Pertemuan4ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Pertemuan5ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Pertemuan6ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PicFoto = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog()
        Me.TxtHariInap = New System.Windows.Forms.TextBox()
        Me.LblHariInap = New System.Windows.Forms.Label()
        Me.LblBiaya = New System.Windows.Forms.Label()
        Me.LblTotalBiaya = New System.Windows.Forms.Label()
        Me.BtnHitungBiaya = New System.Windows.Forms.Button()
        Me.GbJenis.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PicFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtNIK
        '
        Me.TxtNIK.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtNIK.Location = New System.Drawing.Point(300, 177)
        Me.TxtNIK.Name = "TxtNIK"
        Me.TxtNIK.Size = New System.Drawing.Size(401, 29)
        Me.TxtNIK.TabIndex = 2
        '
        'LblNIK
        '
        Me.LblNIK.BackColor = System.Drawing.Color.Transparent
        Me.LblNIK.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblNIK.ForeColor = System.Drawing.Color.Black
        Me.LblNIK.Location = New System.Drawing.Point(172, 179)
        Me.LblNIK.Name = "LblNIK"
        Me.LblNIK.Size = New System.Drawing.Size(67, 29)
        Me.LblNIK.TabIndex = 3
        Me.LblNIK.Text = "NIK"
        '
        'PnlLogo
        '
        Me.PnlLogo.BackgroundImage = Global.Project_latihan_1.My.Resources.Resources.Logo_PNJ_Politeknik_Negeri_Jakarta_Terbaru_PNG
        Me.PnlLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PnlLogo.Location = New System.Drawing.Point(23, 40)
        Me.PnlLogo.Name = "PnlLogo"
        Me.PnlLogo.Size = New System.Drawing.Size(125, 127)
        Me.PnlLogo.TabIndex = 4
        '
        'LblRumahSakit
        '
        Me.LblRumahSakit.BackColor = System.Drawing.Color.Transparent
        Me.LblRumahSakit.Font = New System.Drawing.Font("Calibri", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblRumahSakit.ForeColor = System.Drawing.Color.Black
        Me.LblRumahSakit.Location = New System.Drawing.Point(168, 51)
        Me.LblRumahSakit.Name = "LblRumahSakit"
        Me.LblRumahSakit.Size = New System.Drawing.Size(326, 45)
        Me.LblRumahSakit.TabIndex = 5
        Me.LblRumahSakit.Text = "Rumah Sakit"
        '
        'LblNama
        '
        Me.LblNama.BackColor = System.Drawing.Color.Transparent
        Me.LblNama.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblNama.ForeColor = System.Drawing.Color.Black
        Me.LblNama.Location = New System.Drawing.Point(172, 217)
        Me.LblNama.Name = "LblNama"
        Me.LblNama.Size = New System.Drawing.Size(67, 29)
        Me.LblNama.TabIndex = 6
        Me.LblNama.Text = "Nama"
        '
        'TxtNama
        '
        Me.TxtNama.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtNama.Location = New System.Drawing.Point(300, 217)
        Me.TxtNama.Name = "TxtNama"
        Me.TxtNama.Size = New System.Drawing.Size(401, 29)
        Me.TxtNama.TabIndex = 7
        '
        'LblPNJ
        '
        Me.LblPNJ.BackColor = System.Drawing.Color.Transparent
        Me.LblPNJ.Font = New System.Drawing.Font("Calibri", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblPNJ.ForeColor = System.Drawing.Color.Black
        Me.LblPNJ.Location = New System.Drawing.Point(168, 109)
        Me.LblPNJ.Name = "LblPNJ"
        Me.LblPNJ.Size = New System.Drawing.Size(365, 45)
        Me.LblPNJ.TabIndex = 8
        Me.LblPNJ.Text = "Politeknik Negeri jakarta"
        '
        'LblJumlah
        '
        Me.LblJumlah.BackColor = System.Drawing.Color.Transparent
        Me.LblJumlah.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblJumlah.ForeColor = System.Drawing.Color.Black
        Me.LblJumlah.Location = New System.Drawing.Point(551, 71)
        Me.LblJumlah.Name = "LblJumlah"
        Me.LblJumlah.Size = New System.Drawing.Size(136, 35)
        Me.LblJumlah.TabIndex = 9
        Me.LblJumlah.Text = "Jumlah kamar"
        Me.LblJumlah.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnTambah
        '
        Me.BtnTambah.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnTambah.Location = New System.Drawing.Point(561, 109)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(159, 32)
        Me.BtnTambah.TabIndex = 10
        Me.BtnTambah.Text = "Tambah kamar"
        Me.BtnTambah.UseVisualStyleBackColor = True
        '
        'LblJenisKelamin
        '
        Me.LblJenisKelamin.BackColor = System.Drawing.Color.Transparent
        Me.LblJenisKelamin.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblJenisKelamin.ForeColor = System.Drawing.Color.Black
        Me.LblJenisKelamin.Location = New System.Drawing.Point(172, 272)
        Me.LblJenisKelamin.Name = "LblJenisKelamin"
        Me.LblJenisKelamin.Size = New System.Drawing.Size(122, 24)
        Me.LblJenisKelamin.TabIndex = 11
        Me.LblJenisKelamin.Text = "Jenis kelamin"
        '
        'RdoLaki
        '
        Me.RdoLaki.AutoSize = True
        Me.RdoLaki.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RdoLaki.Location = New System.Drawing.Point(12, 22)
        Me.RdoLaki.Name = "RdoLaki"
        Me.RdoLaki.Size = New System.Drawing.Size(90, 24)
        Me.RdoLaki.TabIndex = 12
        Me.RdoLaki.TabStop = True
        Me.RdoLaki.Text = "Laki - laki"
        Me.RdoLaki.UseVisualStyleBackColor = True
        '
        'RdoPerempuan
        '
        Me.RdoPerempuan.AutoSize = True
        Me.RdoPerempuan.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RdoPerempuan.Location = New System.Drawing.Point(12, 52)
        Me.RdoPerempuan.Name = "RdoPerempuan"
        Me.RdoPerempuan.Size = New System.Drawing.Size(101, 24)
        Me.RdoPerempuan.TabIndex = 13
        Me.RdoPerempuan.TabStop = True
        Me.RdoPerempuan.Text = "Perempuan"
        Me.RdoPerempuan.UseVisualStyleBackColor = True
        '
        'BtnTampil
        '
        Me.BtnTampil.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnTampil.Location = New System.Drawing.Point(857, 404)
        Me.BtnTampil.Name = "BtnTampil"
        Me.BtnTampil.Size = New System.Drawing.Size(137, 34)
        Me.BtnTampil.TabIndex = 14
        Me.BtnTampil.Text = "Tampilkan Pasien"
        Me.BtnTampil.UseVisualStyleBackColor = True
        '
        'LabelsJumlahKamar
        '
        Me.LabelsJumlahKamar.BackColor = System.Drawing.Color.Transparent
        Me.LabelsJumlahKamar.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelsJumlahKamar.ForeColor = System.Drawing.Color.Black
        Me.LabelsJumlahKamar.Location = New System.Drawing.Point(676, 71)
        Me.LabelsJumlahKamar.Name = "LabelsJumlahKamar"
        Me.LabelsJumlahKamar.Size = New System.Drawing.Size(44, 35)
        Me.LabelsJumlahKamar.TabIndex = 15
        Me.LabelsJumlahKamar.Text = "100"
        Me.LabelsJumlahKamar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblAlamat
        '
        Me.LblAlamat.BackColor = System.Drawing.Color.Transparent
        Me.LblAlamat.Font = New System.Drawing.Font("Calibri", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblAlamat.ForeColor = System.Drawing.Color.Black
        Me.LblAlamat.Location = New System.Drawing.Point(172, 409)
        Me.LblAlamat.Name = "LblAlamat"
        Me.LblAlamat.Size = New System.Drawing.Size(77, 29)
        Me.LblAlamat.TabIndex = 16
        Me.LblAlamat.Text = "Alamat"
        '
        'RtbAlamat
        '
        Me.RtbAlamat.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RtbAlamat.Location = New System.Drawing.Point(300, 409)
        Me.RtbAlamat.Name = "RtbAlamat"
        Me.RtbAlamat.Size = New System.Drawing.Size(401, 96)
        Me.RtbAlamat.TabIndex = 17
        Me.RtbAlamat.Text = ""
        '
        'LblLengthAlamat
        '
        Me.LblLengthAlamat.BackColor = System.Drawing.Color.Transparent
        Me.LblLengthAlamat.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblLengthAlamat.ForeColor = System.Drawing.Color.Red
        Me.LblLengthAlamat.Location = New System.Drawing.Point(707, 479)
        Me.LblLengthAlamat.Name = "LblLengthAlamat"
        Me.LblLengthAlamat.Size = New System.Drawing.Size(25, 26)
        Me.LblLengthAlamat.TabIndex = 18
        Me.LblLengthAlamat.Text = "50"
        Me.LblLengthAlamat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GbJenis
        '
        Me.GbJenis.Controls.Add(Me.RdoLaki)
        Me.GbJenis.Controls.Add(Me.RdoPerempuan)
        Me.GbJenis.Location = New System.Drawing.Point(300, 263)
        Me.GbJenis.Name = "GbJenis"
        Me.GbJenis.Size = New System.Drawing.Size(401, 90)
        Me.GbJenis.TabIndex = 19
        Me.GbJenis.TabStop = False
        Me.GbJenis.Text = "Jenis Kelamin"
        '
        'ComboBoxLayanan
        '
        Me.ComboBoxLayanan.FormattingEnabled = True
        Me.ComboBoxLayanan.Items.AddRange(New Object() {"Inap", "Poliklinik", "Spesialis"})
        Me.ComboBoxLayanan.Location = New System.Drawing.Point(300, 522)
        Me.ComboBoxLayanan.Name = "ComboBoxLayanan"
        Me.ComboBoxLayanan.Size = New System.Drawing.Size(401, 23)
        Me.ComboBoxLayanan.TabIndex = 32
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ChkKel_Demam)
        Me.GroupBox1.Controls.Add(Me.ChkKel_Mual)
        Me.GroupBox1.Controls.Add(Me.ChkKel_Pusing)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.Location = New System.Drawing.Point(300, 560)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(401, 117)
        Me.GroupBox1.TabIndex = 34
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Keluhan"
        '
        'ChkKel_Demam
        '
        Me.ChkKel_Demam.AutoSize = True
        Me.ChkKel_Demam.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ChkKel_Demam.Location = New System.Drawing.Point(12, 86)
        Me.ChkKel_Demam.Name = "ChkKel_Demam"
        Me.ChkKel_Demam.Size = New System.Drawing.Size(76, 23)
        Me.ChkKel_Demam.TabIndex = 2
        Me.ChkKel_Demam.Text = "Demam"
        Me.ChkKel_Demam.UseVisualStyleBackColor = True
        '
        'ChkKel_Mual
        '
        Me.ChkKel_Mual.AutoSize = True
        Me.ChkKel_Mual.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ChkKel_Mual.Location = New System.Drawing.Point(12, 55)
        Me.ChkKel_Mual.Name = "ChkKel_Mual"
        Me.ChkKel_Mual.Size = New System.Drawing.Size(59, 23)
        Me.ChkKel_Mual.TabIndex = 1
        Me.ChkKel_Mual.Text = "Mual"
        Me.ChkKel_Mual.UseVisualStyleBackColor = True
        '
        'ChkKel_Pusing
        '
        Me.ChkKel_Pusing.AutoSize = True
        Me.ChkKel_Pusing.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ChkKel_Pusing.Location = New System.Drawing.Point(12, 24)
        Me.ChkKel_Pusing.Name = "ChkKel_Pusing"
        Me.ChkKel_Pusing.Size = New System.Drawing.Size(69, 23)
        Me.ChkKel_Pusing.TabIndex = 0
        Me.ChkKel_Pusing.Text = "Pusing"
        Me.ChkKel_Pusing.UseVisualStyleBackColor = True
        '
        'DatePickTanggalLahir
        '
        Me.DatePickTanggalLahir.Location = New System.Drawing.Point(300, 368)
        Me.DatePickTanggalLahir.Name = "DatePickTanggalLahir"
        Me.DatePickTanggalLahir.Size = New System.Drawing.Size(401, 23)
        Me.DatePickTanggalLahir.TabIndex = 35
        '
        'LblTanggalLahir
        '
        Me.LblTanggalLahir.BackColor = System.Drawing.Color.Transparent
        Me.LblTanggalLahir.Font = New System.Drawing.Font("Calibri", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblTanggalLahir.ForeColor = System.Drawing.Color.Black
        Me.LblTanggalLahir.Location = New System.Drawing.Point(172, 368)
        Me.LblTanggalLahir.Name = "LblTanggalLahir"
        Me.LblTanggalLahir.Size = New System.Drawing.Size(122, 23)
        Me.LblTanggalLahir.TabIndex = 36
        Me.LblTanggalLahir.Text = "Tanggal lahir"
        '
        'LblLayanan
        '
        Me.LblLayanan.BackColor = System.Drawing.Color.Transparent
        Me.LblLayanan.Font = New System.Drawing.Font("Calibri", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblLayanan.ForeColor = System.Drawing.Color.Black
        Me.LblLayanan.Location = New System.Drawing.Point(172, 522)
        Me.LblLayanan.Name = "LblLayanan"
        Me.LblLayanan.Size = New System.Drawing.Size(77, 26)
        Me.LblLayanan.TabIndex = 37
        Me.LblLayanan.Text = "Layanan"
        '
        'LblKeluhan
        '
        Me.LblKeluhan.BackColor = System.Drawing.Color.Transparent
        Me.LblKeluhan.Font = New System.Drawing.Font("Calibri", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblKeluhan.ForeColor = System.Drawing.Color.Black
        Me.LblKeluhan.Location = New System.Drawing.Point(172, 571)
        Me.LblKeluhan.Name = "LblKeluhan"
        Me.LblKeluhan.Size = New System.Drawing.Size(77, 26)
        Me.LblKeluhan.TabIndex = 38
        Me.LblKeluhan.Text = "Keluhan"
        '
        'BtnTambahFoto
        '
        Me.BtnTambahFoto.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnTambahFoto.Location = New System.Drawing.Point(23, 409)
        Me.BtnTambahFoto.Name = "BtnTambahFoto"
        Me.BtnTambahFoto.Size = New System.Drawing.Size(125, 34)
        Me.BtnTambahFoto.TabIndex = 39
        Me.BtnTambahFoto.Text = "Tambah Foto"
        Me.BtnTambahFoto.UseVisualStyleBackColor = True
        '
        'RtbCatatanDokter
        '
        Me.RtbCatatanDokter.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RtbCatatanDokter.Location = New System.Drawing.Point(742, 217)
        Me.RtbCatatanDokter.Name = "RtbCatatanDokter"
        Me.RtbCatatanDokter.Size = New System.Drawing.Size(368, 136)
        Me.RtbCatatanDokter.TabIndex = 40
        Me.RtbCatatanDokter.Text = ""
        '
        'LblCatatanDokter
        '
        Me.LblCatatanDokter.BackColor = System.Drawing.Color.Transparent
        Me.LblCatatanDokter.Font = New System.Drawing.Font("Calibri", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblCatatanDokter.ForeColor = System.Drawing.Color.Black
        Me.LblCatatanDokter.Location = New System.Drawing.Point(742, 188)
        Me.LblCatatanDokter.Name = "LblCatatanDokter"
        Me.LblCatatanDokter.Size = New System.Drawing.Size(151, 23)
        Me.LblCatatanDokter.TabIndex = 41
        Me.LblCatatanDokter.Text = "Catatan Dokter"
        '
        'BtnOpenFile
        '
        Me.BtnOpenFile.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnOpenFile.Location = New System.Drawing.Point(973, 183)
        Me.BtnOpenFile.Name = "BtnOpenFile"
        Me.BtnOpenFile.Size = New System.Drawing.Size(137, 31)
        Me.BtnOpenFile.TabIndex = 42
        Me.BtnOpenFile.Text = "Buka File"
        Me.BtnOpenFile.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MainToolStripMenuItem, Me.KamarToolStripMenuItem, Me.LatihanToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1139, 24)
        Me.MenuStrip1.TabIndex = 43
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MainToolStripMenuItem
        '
        Me.MainToolStripMenuItem.Name = "MainToolStripMenuItem"
        Me.MainToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.MainToolStripMenuItem.Text = "Main"
        '
        'KamarToolStripMenuItem
        '
        Me.KamarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TambahKamarToolStripMenuItem})
        Me.KamarToolStripMenuItem.Name = "KamarToolStripMenuItem"
        Me.KamarToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.KamarToolStripMenuItem.Text = "Kamar"
        '
        'TambahKamarToolStripMenuItem
        '
        Me.TambahKamarToolStripMenuItem.Image = Global.Project_latihan_1.My.Resources.Resources.Logo_PNJ_Politeknik_Negeri_Jakarta_Terbaru_PNG
        Me.TambahKamarToolStripMenuItem.Name = "TambahKamarToolStripMenuItem"
        Me.TambahKamarToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.TambahKamarToolStripMenuItem.Text = "Tambah Kamar"
        '
        'LatihanToolStripMenuItem
        '
        Me.LatihanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Pertemuan4ToolStripMenuItem, Me.Pertemuan5ToolStripMenuItem, Me.Pertemuan6ToolStripMenuItem})
        Me.LatihanToolStripMenuItem.Name = "LatihanToolStripMenuItem"
        Me.LatihanToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.LatihanToolStripMenuItem.Text = "Latihan"
        '
        'Pertemuan4ToolStripMenuItem
        '
        Me.Pertemuan4ToolStripMenuItem.Image = Global.Project_latihan_1.My.Resources.Resources.Logo_PNJ_Politeknik_Negeri_Jakarta_Terbaru_PNG
        Me.Pertemuan4ToolStripMenuItem.Name = "Pertemuan4ToolStripMenuItem"
        Me.Pertemuan4ToolStripMenuItem.Size = New System.Drawing.Size(296, 22)
        Me.Pertemuan4ToolStripMenuItem.Text = "Pertemuan 4 - CheckBox_ListBox"
        '
        'Pertemuan5ToolStripMenuItem
        '
        Me.Pertemuan5ToolStripMenuItem.Image = Global.Project_latihan_1.My.Resources.Resources.Logo_PNJ_Politeknik_Negeri_Jakarta_Terbaru_PNG
        Me.Pertemuan5ToolStripMenuItem.Name = "Pertemuan5ToolStripMenuItem"
        Me.Pertemuan5ToolStripMenuItem.Size = New System.Drawing.Size(296, 22)
        Me.Pertemuan5ToolStripMenuItem.Text = "Pertemuan 5 - DateTimePicker_PictureBox"
        '
        'Pertemuan6ToolStripMenuItem
        '
        Me.Pertemuan6ToolStripMenuItem.Image = Global.Project_latihan_1.My.Resources.Resources.Logo_PNJ_Politeknik_Negeri_Jakarta_Terbaru_PNG
        Me.Pertemuan6ToolStripMenuItem.Name = "Pertemuan6ToolStripMenuItem"
        Me.Pertemuan6ToolStripMenuItem.Size = New System.Drawing.Size(296, 22)
        Me.Pertemuan6ToolStripMenuItem.Text = "Pertemuan 6 - Conditional_IF_Loop"
        '
        'PicFoto
        '
        Me.PicFoto.Location = New System.Drawing.Point(23, 217)
        Me.PicFoto.Name = "PicFoto"
        Me.PicFoto.Size = New System.Drawing.Size(125, 174)
        Me.PicFoto.TabIndex = 44
        Me.PicFoto.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'OpenFileDialog2
        '
        Me.OpenFileDialog2.FileName = "OpenFileDialog2"
        '
        'TxtHariInap
        '
        Me.TxtHariInap.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtHariInap.Location = New System.Drawing.Point(300, 699)
        Me.TxtHariInap.Name = "TxtHariInap"
        Me.TxtHariInap.Size = New System.Drawing.Size(401, 29)
        Me.TxtHariInap.TabIndex = 45
        '
        'LblHariInap
        '
        Me.LblHariInap.BackColor = System.Drawing.Color.Transparent
        Me.LblHariInap.Font = New System.Drawing.Font("Calibri", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblHariInap.ForeColor = System.Drawing.Color.Black
        Me.LblHariInap.Location = New System.Drawing.Point(172, 696)
        Me.LblHariInap.Name = "LblHariInap"
        Me.LblHariInap.Size = New System.Drawing.Size(77, 26)
        Me.LblHariInap.TabIndex = 46
        Me.LblHariInap.Text = "Hari Inap"
        '
        'LblBiaya
        '
        Me.LblBiaya.BackColor = System.Drawing.Color.Transparent
        Me.LblBiaya.Font = New System.Drawing.Font("Calibri", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblBiaya.ForeColor = System.Drawing.Color.Black
        Me.LblBiaya.Location = New System.Drawing.Point(172, 735)
        Me.LblBiaya.Name = "LblBiaya"
        Me.LblBiaya.Size = New System.Drawing.Size(99, 26)
        Me.LblBiaya.TabIndex = 47
        Me.LblBiaya.Text = "Total Biaya"
        '
        'LblTotalBiaya
        '
        Me.LblTotalBiaya.BackColor = System.Drawing.Color.Transparent
        Me.LblTotalBiaya.Font = New System.Drawing.Font("Calibri", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblTotalBiaya.ForeColor = System.Drawing.Color.Black
        Me.LblTotalBiaya.Location = New System.Drawing.Point(300, 735)
        Me.LblTotalBiaya.Name = "LblTotalBiaya"
        Me.LblTotalBiaya.Size = New System.Drawing.Size(77, 26)
        Me.LblTotalBiaya.TabIndex = 48
        Me.LblTotalBiaya.Text = "10000"
        '
        'BtnHitungBiaya
        '
        Me.BtnHitungBiaya.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnHitungBiaya.Location = New System.Drawing.Point(707, 696)
        Me.BtnHitungBiaya.Name = "BtnHitungBiaya"
        Me.BtnHitungBiaya.Size = New System.Drawing.Size(87, 34)
        Me.BtnHitungBiaya.TabIndex = 49
        Me.BtnHitungBiaya.Text = "Hitung"
        Me.BtnHitungBiaya.UseVisualStyleBackColor = True
        '
        'Pendaftaran
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1139, 796)
        Me.Controls.Add(Me.BtnHitungBiaya)
        Me.Controls.Add(Me.LblTotalBiaya)
        Me.Controls.Add(Me.LblBiaya)
        Me.Controls.Add(Me.LblHariInap)
        Me.Controls.Add(Me.TxtHariInap)
        Me.Controls.Add(Me.PicFoto)
        Me.Controls.Add(Me.BtnOpenFile)
        Me.Controls.Add(Me.LblCatatanDokter)
        Me.Controls.Add(Me.RtbCatatanDokter)
        Me.Controls.Add(Me.BtnTambahFoto)
        Me.Controls.Add(Me.LblKeluhan)
        Me.Controls.Add(Me.LblLayanan)
        Me.Controls.Add(Me.LblTanggalLahir)
        Me.Controls.Add(Me.DatePickTanggalLahir)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ComboBoxLayanan)
        Me.Controls.Add(Me.GbJenis)
        Me.Controls.Add(Me.LblLengthAlamat)
        Me.Controls.Add(Me.RtbAlamat)
        Me.Controls.Add(Me.LblAlamat)
        Me.Controls.Add(Me.LabelsJumlahKamar)
        Me.Controls.Add(Me.BtnTampil)
        Me.Controls.Add(Me.LblJenisKelamin)
        Me.Controls.Add(Me.BtnTambah)
        Me.Controls.Add(Me.LblJumlah)
        Me.Controls.Add(Me.LblPNJ)
        Me.Controls.Add(Me.TxtNama)
        Me.Controls.Add(Me.LblNama)
        Me.Controls.Add(Me.LblRumahSakit)
        Me.Controls.Add(Me.PnlLogo)
        Me.Controls.Add(Me.LblNIK)
        Me.Controls.Add(Me.TxtNIK)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Pendaftaran"
        Me.Text = "Pendaftaran"
        Me.GbJenis.ResumeLayout(False)
        Me.GbJenis.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PicFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtNIK As TextBox
    Friend WithEvents LblNIK As Label
    Friend WithEvents PnlLogo As Panel
    Friend WithEvents LblRumahSakit As Label
    Friend WithEvents LblNama As Label
    Friend WithEvents TxtNama As TextBox
    Friend WithEvents LblPNJ As Label
    Friend WithEvents LblJumlah As Label
    Friend WithEvents BtnTambah As Button
    Friend WithEvents LblJenisKelamin As Label
    Friend WithEvents RdoLaki As RadioButton
    Friend WithEvents RdoPerempuan As RadioButton
    Friend WithEvents BtnTampil As Button
    Friend WithEvents LabelsJumlahKamar As Label
    Friend WithEvents LblAlamat As Label
    Friend WithEvents RtbAlamat As RichTextBox
    Friend WithEvents LblLengthAlamat As Label
    Friend WithEvents GbJenis As GroupBox
    Friend WithEvents ComboBoxLayanan As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ChkKel_Demam As CheckBox
    Friend WithEvents ChkKel_Mual As CheckBox
    Friend WithEvents ChkKel_Pusing As CheckBox
    Friend WithEvents DatePickTanggalLahir As DateTimePicker
    Friend WithEvents LblTanggalLahir As Label
    Friend WithEvents LblLayanan As Label
    Friend WithEvents LblKeluhan As Label
    Friend WithEvents BtnTambahFoto As Button
    Friend WithEvents RtbCatatanDokter As RichTextBox
    Friend WithEvents LblCatatanDokter As Label
    Friend WithEvents BtnOpenFile As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MainToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KamarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TambahKamarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LatihanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Pertemuan4ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Pertemuan5ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PicFoto As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents OpenFileDialog2 As OpenFileDialog
    Friend WithEvents Pertemuan6ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TxtHariInap As TextBox
    Friend WithEvents LblHariInap As Label
    Friend WithEvents LblBiaya As Label
    Friend WithEvents LblTotalBiaya As Label
    Friend WithEvents BtnHitungBiaya As Button
End Class
