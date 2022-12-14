<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LatihanPertemuan5
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
        Me.DatePickTanggalLahir = New System.Windows.Forms.DateTimePicker()
        Me.BtnDate = New System.Windows.Forms.Button()
        Me.TimePickerTime = New System.Windows.Forms.DateTimePicker()
        Me.LblTimePicker = New System.Windows.Forms.Label()
        Me.BtnTime = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.BtnDateTime = New System.Windows.Forms.Button()
        Me.RTBoxCatatan = New System.Windows.Forms.RichTextBox()
        Me.BtnOpenCatatan = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.PicFoto = New System.Windows.Forms.PictureBox()
        Me.BtnOpenFoto = New System.Windows.Forms.Button()
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog()
        Me.LblColorChange = New System.Windows.Forms.Label()
        Me.LblColorCode = New System.Windows.Forms.Label()
        Me.BtnChangeColor = New System.Windows.Forms.Button()
        Me.PnlColorChange = New System.Windows.Forms.Panel()
        Me.TxtColorMode = New System.Windows.Forms.TextBox()
        Me.BtnChangeGreen = New System.Windows.Forms.Button()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        CType(Me.PicFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DatePickTanggalLahir
        '
        Me.DatePickTanggalLahir.CalendarFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DatePickTanggalLahir.Location = New System.Drawing.Point(12, 29)
        Me.DatePickTanggalLahir.Name = "DatePickTanggalLahir"
        Me.DatePickTanggalLahir.Size = New System.Drawing.Size(200, 23)
        Me.DatePickTanggalLahir.TabIndex = 0
        '
        'BtnDate
        '
        Me.BtnDate.Location = New System.Drawing.Point(218, 25)
        Me.BtnDate.Name = "BtnDate"
        Me.BtnDate.Size = New System.Drawing.Size(85, 34)
        Me.BtnDate.TabIndex = 1
        Me.BtnDate.Text = "Show Date"
        Me.BtnDate.UseVisualStyleBackColor = True
        '
        'TimePickerTime
        '
        Me.TimePickerTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.TimePickerTime.Location = New System.Drawing.Point(12, 68)
        Me.TimePickerTime.Name = "TimePickerTime"
        Me.TimePickerTime.Size = New System.Drawing.Size(200, 23)
        Me.TimePickerTime.TabIndex = 3
        '
        'LblTimePicker
        '
        Me.LblTimePicker.AutoSize = True
        Me.LblTimePicker.Location = New System.Drawing.Point(12, 85)
        Me.LblTimePicker.Name = "LblTimePicker"
        Me.LblTimePicker.Size = New System.Drawing.Size(0, 15)
        Me.LblTimePicker.TabIndex = 4
        '
        'BtnTime
        '
        Me.BtnTime.Location = New System.Drawing.Point(218, 63)
        Me.BtnTime.Name = "BtnTime"
        Me.BtnTime.Size = New System.Drawing.Size(85, 37)
        Me.BtnTime.TabIndex = 5
        Me.BtnTime.Text = "Show Time"
        Me.BtnTime.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(218, 106)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(85, 34)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Show Date"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DateTimePicker1.Location = New System.Drawing.Point(12, 110)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 23)
        Me.DateTimePicker1.TabIndex = 6
        '
        'BtnDateTime
        '
        Me.BtnDateTime.Location = New System.Drawing.Point(309, 25)
        Me.BtnDateTime.Name = "BtnDateTime"
        Me.BtnDateTime.Size = New System.Drawing.Size(85, 115)
        Me.BtnDateTime.TabIndex = 8
        Me.BtnDateTime.Text = "Show Datetime"
        Me.BtnDateTime.UseVisualStyleBackColor = True
        '
        'RTBoxCatatan
        '
        Me.RTBoxCatatan.Location = New System.Drawing.Point(412, 29)
        Me.RTBoxCatatan.Name = "RTBoxCatatan"
        Me.RTBoxCatatan.Size = New System.Drawing.Size(231, 111)
        Me.RTBoxCatatan.TabIndex = 9
        Me.RTBoxCatatan.Text = ""
        '
        'BtnOpenCatatan
        '
        Me.BtnOpenCatatan.Location = New System.Drawing.Point(649, 29)
        Me.BtnOpenCatatan.Name = "BtnOpenCatatan"
        Me.BtnOpenCatatan.Size = New System.Drawing.Size(139, 34)
        Me.BtnOpenCatatan.TabIndex = 10
        Me.BtnOpenCatatan.Text = "Open Catatan"
        Me.BtnOpenCatatan.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'PicFoto
        '
        Me.PicFoto.Location = New System.Drawing.Point(50, 163)
        Me.PicFoto.Name = "PicFoto"
        Me.PicFoto.Size = New System.Drawing.Size(130, 162)
        Me.PicFoto.TabIndex = 11
        Me.PicFoto.TabStop = False
        '
        'BtnOpenFoto
        '
        Me.BtnOpenFoto.Location = New System.Drawing.Point(50, 331)
        Me.BtnOpenFoto.Name = "BtnOpenFoto"
        Me.BtnOpenFoto.Size = New System.Drawing.Size(130, 34)
        Me.BtnOpenFoto.TabIndex = 12
        Me.BtnOpenFoto.Text = "Open Foto"
        Me.BtnOpenFoto.UseVisualStyleBackColor = True
        '
        'OpenFileDialog2
        '
        Me.OpenFileDialog2.FileName = "OpenFileDialog2"
        '
        'LblColorChange
        '
        Me.LblColorChange.AutoSize = True
        Me.LblColorChange.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblColorChange.Location = New System.Drawing.Point(361, 211)
        Me.LblColorChange.Name = "LblColorChange"
        Me.LblColorChange.Size = New System.Drawing.Size(99, 28)
        Me.LblColorChange.TabIndex = 13
        Me.LblColorChange.Text = "Text Color"
        '
        'LblColorCode
        '
        Me.LblColorCode.AutoSize = True
        Me.LblColorCode.Location = New System.Drawing.Point(375, 273)
        Me.LblColorCode.Name = "LblColorCode"
        Me.LblColorCode.Size = New System.Drawing.Size(70, 15)
        Me.LblColorCode.TabIndex = 14
        Me.LblColorCode.Text = "Color Mode"
        '
        'BtnChangeColor
        '
        Me.BtnChangeColor.Location = New System.Drawing.Point(345, 163)
        Me.BtnChangeColor.Name = "BtnChangeColor"
        Me.BtnChangeColor.Size = New System.Drawing.Size(130, 34)
        Me.BtnChangeColor.TabIndex = 15
        Me.BtnChangeColor.Text = "Change Color"
        Me.BtnChangeColor.UseVisualStyleBackColor = True
        '
        'PnlColorChange
        '
        Me.PnlColorChange.Location = New System.Drawing.Point(345, 320)
        Me.PnlColorChange.Name = "PnlColorChange"
        Me.PnlColorChange.Size = New System.Drawing.Size(130, 103)
        Me.PnlColorChange.TabIndex = 16
        '
        'TxtColorMode
        '
        Me.TxtColorMode.Location = New System.Drawing.Point(345, 291)
        Me.TxtColorMode.Name = "TxtColorMode"
        Me.TxtColorMode.Size = New System.Drawing.Size(130, 23)
        Me.TxtColorMode.TabIndex = 17
        '
        'BtnChangeGreen
        '
        Me.BtnChangeGreen.Location = New System.Drawing.Point(491, 205)
        Me.BtnChangeGreen.Name = "BtnChangeGreen"
        Me.BtnChangeGreen.Size = New System.Drawing.Size(108, 83)
        Me.BtnChangeGreen.TabIndex = 18
        Me.BtnChangeGreen.Text = "Change to Green"
        Me.BtnChangeGreen.UseVisualStyleBackColor = True
        '
        'LatihanPertemuan5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 463)
        Me.Controls.Add(Me.BtnChangeGreen)
        Me.Controls.Add(Me.TxtColorMode)
        Me.Controls.Add(Me.PnlColorChange)
        Me.Controls.Add(Me.BtnChangeColor)
        Me.Controls.Add(Me.LblColorCode)
        Me.Controls.Add(Me.LblColorChange)
        Me.Controls.Add(Me.BtnOpenFoto)
        Me.Controls.Add(Me.PicFoto)
        Me.Controls.Add(Me.BtnOpenCatatan)
        Me.Controls.Add(Me.RTBoxCatatan)
        Me.Controls.Add(Me.BtnDateTime)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.BtnTime)
        Me.Controls.Add(Me.LblTimePicker)
        Me.Controls.Add(Me.TimePickerTime)
        Me.Controls.Add(Me.BtnDate)
        Me.Controls.Add(Me.DatePickTanggalLahir)
        Me.Name = "LatihanPertemuan5"
        Me.Text = "latihan pertemuan 5"
        CType(Me.PicFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DatePickTanggalLahir As DateTimePicker
    Friend WithEvents BtnDate As Button
    Friend WithEvents TimePickerTime As DateTimePicker
    Friend WithEvents LblTimePicker As Label
    Friend WithEvents BtnTime As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents BtnDateTime As Button
    Friend WithEvents RTBoxCatatan As RichTextBox
    Friend WithEvents BtnOpenCatatan As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents PicFoto As PictureBox
    Friend WithEvents BtnOpenFoto As Button
    Friend WithEvents OpenFileDialog2 As OpenFileDialog
    Friend WithEvents LblColorChange As Label
    Friend WithEvents LblColorCode As Label
    Friend WithEvents BtnChangeColor As Button
    Friend WithEvents PnlColorChange As Panel
    Friend WithEvents TxtColorMode As TextBox
    Friend WithEvents BtnChangeGreen As Button
    Friend WithEvents ColorDialog1 As ColorDialog
End Class
