<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class tambahkamar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(tambahkamar))
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.LblNum = New System.Windows.Forms.Label()
        Me.BtnMin = New System.Windows.Forms.Button()
        Me.BtnTambah = New System.Windows.Forms.Button()
        Me.TxtValueKamar = New System.Windows.Forms.TextBox()
        Me.BtnPlus = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblTitle
        '
        Me.LblTitle.AutoSize = True
        Me.LblTitle.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblTitle.Location = New System.Drawing.Point(137, 19)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(223, 30)
        Me.LblTitle.TabIndex = 0
        Me.LblTitle.Text = "Kamar tersedia saat ini"
        '
        'LblNum
        '
        Me.LblNum.AutoSize = True
        Me.LblNum.Font = New System.Drawing.Font("Segoe UI", 65.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblNum.Location = New System.Drawing.Point(153, 74)
        Me.LblNum.Name = "LblNum"
        Me.LblNum.Size = New System.Drawing.Size(190, 116)
        Me.LblNum.TabIndex = 1
        Me.LblNum.Text = "100"
        '
        'BtnMin
        '
        Me.BtnMin.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnMin.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnMin.Location = New System.Drawing.Point(36, 241)
        Me.BtnMin.Name = "BtnMin"
        Me.BtnMin.Size = New System.Drawing.Size(56, 43)
        Me.BtnMin.TabIndex = 2
        Me.BtnMin.Text = "-"
        Me.BtnMin.UseVisualStyleBackColor = True
        '
        'BtnTambah
        '
        Me.BtnTambah.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnTambah.Location = New System.Drawing.Point(36, 299)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(421, 38)
        Me.BtnTambah.TabIndex = 3
        Me.BtnTambah.Text = "Tambah"
        Me.BtnTambah.UseVisualStyleBackColor = True
        '
        'TxtValueKamar
        '
        Me.TxtValueKamar.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtValueKamar.Location = New System.Drawing.Point(108, 243)
        Me.TxtValueKamar.Name = "TxtValueKamar"
        Me.TxtValueKamar.Size = New System.Drawing.Size(278, 39)
        Me.TxtValueKamar.TabIndex = 4
        '
        'BtnPlus
        '
        Me.BtnPlus.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnPlus.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnPlus.Location = New System.Drawing.Point(403, 241)
        Me.BtnPlus.Name = "BtnPlus"
        Me.BtnPlus.Size = New System.Drawing.Size(54, 41)
        Me.BtnPlus.TabIndex = 5
        Me.BtnPlus.Text = "+"
        Me.BtnPlus.UseVisualStyleBackColor = True
        '
        'tambahkamar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(494, 378)
        Me.Controls.Add(Me.BtnPlus)
        Me.Controls.Add(Me.TxtValueKamar)
        Me.Controls.Add(Me.BtnTambah)
        Me.Controls.Add(Me.BtnMin)
        Me.Controls.Add(Me.LblNum)
        Me.Controls.Add(Me.LblTitle)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "tambahkamar"
        Me.Text = "Tambah Kamar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblTitle As Label
    Friend WithEvents LblNum As Label
    Friend WithEvents BtnMin As Button
    Friend WithEvents BtnTambah As Button
    Friend WithEvents TxtValueKamar As TextBox
    Friend WithEvents BtnPlus As Button
End Class
