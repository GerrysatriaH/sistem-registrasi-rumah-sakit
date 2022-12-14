<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pasien
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
        Me.BtnTutupForm = New System.Windows.Forms.Button()
        Me.PictFoto = New System.Windows.Forms.PictureBox()
        Me.LblNameValue = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LblCatatanDokterValue = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.LblAlamatValue = New System.Windows.Forms.Label()
        Me.LblLayananValue = New System.Windows.Forms.Label()
        Me.LblTanggalLahirValue = New System.Windows.Forms.Label()
        Me.LblJenisKelaminValue = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ListBoxKeluhan = New System.Windows.Forms.ListBox()
        Me.LblNIKValue = New System.Windows.Forms.Label()
        CType(Me.PictFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnTutupForm
        '
        Me.BtnTutupForm.Location = New System.Drawing.Point(695, 425)
        Me.BtnTutupForm.Name = "BtnTutupForm"
        Me.BtnTutupForm.Size = New System.Drawing.Size(83, 30)
        Me.BtnTutupForm.TabIndex = 0
        Me.BtnTutupForm.Text = "Tutup"
        Me.BtnTutupForm.UseVisualStyleBackColor = True
        '
        'PictFoto
        '
        Me.PictFoto.Location = New System.Drawing.Point(12, 12)
        Me.PictFoto.Name = "PictFoto"
        Me.PictFoto.Size = New System.Drawing.Size(133, 174)
        Me.PictFoto.TabIndex = 1
        Me.PictFoto.TabStop = False
        '
        'LblNameValue
        '
        Me.LblNameValue.AutoSize = True
        Me.LblNameValue.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblNameValue.Location = New System.Drawing.Point(163, 12)
        Me.LblNameValue.Name = "LblNameValue"
        Me.LblNameValue.Size = New System.Drawing.Size(52, 21)
        Me.LblNameValue.TabIndex = 2
        Me.LblNameValue.Text = "Nama"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(163, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 21)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "NIK"
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.LblCatatanDokterValue)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.LblAlamatValue)
        Me.Panel1.Controls.Add(Me.LblLayananValue)
        Me.Panel1.Controls.Add(Me.LblTanggalLahirValue)
        Me.Panel1.Controls.Add(Me.LblJenisKelaminValue)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.ListBoxKeluhan)
        Me.Panel1.Location = New System.Drawing.Point(165, 78)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(540, 302)
        Me.Panel1.TabIndex = 4
        '
        'LblCatatanDokterValue
        '
        Me.LblCatatanDokterValue.AutoSize = True
        Me.LblCatatanDokterValue.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblCatatanDokterValue.Location = New System.Drawing.Point(15, 327)
        Me.LblCatatanDokterValue.Name = "LblCatatanDokterValue"
        Me.LblCatatanDokterValue.Size = New System.Drawing.Size(114, 21)
        Me.LblCatatanDokterValue.TabIndex = 16
        Me.LblCatatanDokterValue.Text = "Catatan Dokter"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(15, 298)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 21)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Catatan Dokter"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label10.Location = New System.Drawing.Point(15, 144)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 21)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Keluhan"
        '
        'LblAlamatValue
        '
        Me.LblAlamatValue.AutoSize = True
        Me.LblAlamatValue.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblAlamatValue.Location = New System.Drawing.Point(195, 105)
        Me.LblAlamatValue.Name = "LblAlamatValue"
        Me.LblAlamatValue.Size = New System.Drawing.Size(59, 21)
        Me.LblAlamatValue.TabIndex = 13
        Me.LblAlamatValue.Text = "Alamat"
        '
        'LblLayananValue
        '
        Me.LblLayananValue.AutoSize = True
        Me.LblLayananValue.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblLayananValue.Location = New System.Drawing.Point(195, 75)
        Me.LblLayananValue.Name = "LblLayananValue"
        Me.LblLayananValue.Size = New System.Drawing.Size(68, 21)
        Me.LblLayananValue.TabIndex = 12
        Me.LblLayananValue.Text = "Layanan"
        '
        'LblTanggalLahirValue
        '
        Me.LblTanggalLahirValue.AutoSize = True
        Me.LblTanggalLahirValue.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblTanggalLahirValue.Location = New System.Drawing.Point(195, 44)
        Me.LblTanggalLahirValue.Name = "LblTanggalLahirValue"
        Me.LblTanggalLahirValue.Size = New System.Drawing.Size(102, 21)
        Me.LblTanggalLahirValue.TabIndex = 11
        Me.LblTanggalLahirValue.Text = "Tanggal Lahir"
        '
        'LblJenisKelaminValue
        '
        Me.LblJenisKelaminValue.AutoSize = True
        Me.LblJenisKelaminValue.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblJenisKelaminValue.Location = New System.Drawing.Point(195, 13)
        Me.LblJenisKelaminValue.Name = "LblJenisKelaminValue"
        Me.LblJenisKelaminValue.Size = New System.Drawing.Size(104, 21)
        Me.LblJenisKelaminValue.TabIndex = 10
        Me.LblJenisKelaminValue.Text = "Jenis Kelamin"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(15, 105)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 21)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Alamat"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(15, 75)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 21)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Layanan"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(15, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 21)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Jenis Kelamin"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(15, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 21)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Tanggal Lahir"
        '
        'ListBoxKeluhan
        '
        Me.ListBoxKeluhan.FormattingEnabled = True
        Me.ListBoxKeluhan.ItemHeight = 15
        Me.ListBoxKeluhan.Location = New System.Drawing.Point(15, 179)
        Me.ListBoxKeluhan.Name = "ListBoxKeluhan"
        Me.ListBoxKeluhan.Size = New System.Drawing.Size(494, 109)
        Me.ListBoxKeluhan.TabIndex = 0
        '
        'LblNIKValue
        '
        Me.LblNIKValue.AutoSize = True
        Me.LblNIKValue.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblNIKValue.Location = New System.Drawing.Point(251, 42)
        Me.LblNIKValue.Name = "LblNIKValue"
        Me.LblNIKValue.Size = New System.Drawing.Size(35, 21)
        Me.LblNIKValue.TabIndex = 5
        Me.LblNIKValue.Text = "NIK"
        '
        'Pasien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 476)
        Me.Controls.Add(Me.LblNIKValue)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LblNameValue)
        Me.Controls.Add(Me.PictFoto)
        Me.Controls.Add(Me.BtnTutupForm)
        Me.Name = "Pasien"
        Me.Text = "Form Pasien"
        CType(Me.PictFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnTutupForm As Button
    Friend WithEvents PictFoto As PictureBox
    Friend WithEvents LblNameValue As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ListBoxKeluhan As ListBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LblNIKValue As Label
    Friend WithEvents LblAlamatValue As Label
    Friend WithEvents LblLayananValue As Label
    Friend WithEvents LblTanggalLahirValue As Label
    Friend WithEvents LblJenisKelaminValue As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LblCatatanDokterValue As Label
End Class
