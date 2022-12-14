<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class latihanPertemuan4
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
        Me.CheckedListBoxKeluhan = New System.Windows.Forms.CheckedListBox()
        Me.ListBoxKeluhan = New System.Windows.Forms.ListBox()
        Me.LblListKeluhan = New System.Windows.Forms.Label()
        Me.BtnTransfer = New System.Windows.Forms.Button()
        Me.BtnListCheck = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnTransferSelected = New System.Windows.Forms.Button()
        Me.CheckedListBoxChckd = New System.Windows.Forms.CheckedListBox()
        Me.BtnOutput = New System.Windows.Forms.Button()
        Me.ChkDemam = New System.Windows.Forms.CheckBox()
        Me.ChkMual = New System.Windows.Forms.CheckBox()
        Me.ChkPusing = New System.Windows.Forms.CheckBox()
        Me.BtnAddItemListBox = New System.Windows.Forms.Button()
        Me.TxtAddItem = New System.Windows.Forms.TextBox()
        Me.BtnSelectedItem = New System.Windows.Forms.Button()
        Me.BtnCheckedItem = New System.Windows.Forms.Button()
        Me.ComboBoxLayanan = New System.Windows.Forms.ComboBox()
        Me.BtnShowCdSel = New System.Windows.Forms.Button()
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CheckedListBoxKeluhan
        '
        Me.CheckedListBoxKeluhan.FormattingEnabled = True
        Me.CheckedListBoxKeluhan.Items.AddRange(New Object() {"Pusing", "Mual", "Demam"})
        Me.CheckedListBoxKeluhan.Location = New System.Drawing.Point(414, 236)
        Me.CheckedListBoxKeluhan.Name = "CheckedListBoxKeluhan"
        Me.CheckedListBoxKeluhan.Size = New System.Drawing.Size(191, 166)
        Me.CheckedListBoxKeluhan.TabIndex = 0
        '
        'ListBoxKeluhan
        '
        Me.ListBoxKeluhan.FormattingEnabled = True
        Me.ListBoxKeluhan.ItemHeight = 15
        Me.ListBoxKeluhan.Location = New System.Drawing.Point(12, 236)
        Me.ListBoxKeluhan.Name = "ListBoxKeluhan"
        Me.ListBoxKeluhan.Size = New System.Drawing.Size(191, 169)
        Me.ListBoxKeluhan.TabIndex = 1
        '
        'LblListKeluhan
        '
        Me.LblListKeluhan.AutoSize = True
        Me.LblListKeluhan.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblListKeluhan.Location = New System.Drawing.Point(223, 25)
        Me.LblListKeluhan.Name = "LblListKeluhan"
        Me.LblListKeluhan.Size = New System.Drawing.Size(169, 28)
        Me.LblListKeluhan.TabIndex = 2
        Me.LblListKeluhan.Text = "Tambah Keluhan"
        '
        'BtnTransfer
        '
        Me.BtnTransfer.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnTransfer.Location = New System.Drawing.Point(12, 411)
        Me.BtnTransfer.Name = "BtnTransfer"
        Me.BtnTransfer.Size = New System.Drawing.Size(191, 25)
        Me.BtnTransfer.TabIndex = 3
        Me.BtnTransfer.Text = "Transfer"
        Me.BtnTransfer.UseVisualStyleBackColor = True
        '
        'BtnListCheck
        '
        Me.BtnListCheck.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnListCheck.Location = New System.Drawing.Point(414, 411)
        Me.BtnListCheck.Name = "BtnListCheck"
        Me.BtnListCheck.Size = New System.Drawing.Size(191, 25)
        Me.BtnListCheck.TabIndex = 4
        Me.BtnListCheck.Text = "Transfer ListCheck"
        Me.BtnListCheck.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnTransferSelected)
        Me.GroupBox1.Controls.Add(Me.CheckedListBoxChckd)
        Me.GroupBox1.Controls.Add(Me.BtnOutput)
        Me.GroupBox1.Controls.Add(Me.ChkDemam)
        Me.GroupBox1.Controls.Add(Me.ChkMual)
        Me.GroupBox1.Controls.Add(Me.ChkPusing)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(397, 162)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Keluhan"
        '
        'BtnTransferSelected
        '
        Me.BtnTransferSelected.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnTransferSelected.Location = New System.Drawing.Point(195, 126)
        Me.BtnTransferSelected.Name = "BtnTransferSelected"
        Me.BtnTransferSelected.Size = New System.Drawing.Size(185, 28)
        Me.BtnTransferSelected.TabIndex = 25
        Me.BtnTransferSelected.Text = "Transfer Selected"
        Me.BtnTransferSelected.UseVisualStyleBackColor = True
        '
        'CheckedListBoxChckd
        '
        Me.CheckedListBoxChckd.FormattingEnabled = True
        Me.CheckedListBoxChckd.Items.AddRange(New Object() {"Pusing", "Mual", "Demam"})
        Me.CheckedListBoxChckd.Location = New System.Drawing.Point(195, 24)
        Me.CheckedListBoxChckd.Name = "CheckedListBoxChckd"
        Me.CheckedListBoxChckd.Size = New System.Drawing.Size(185, 84)
        Me.CheckedListBoxChckd.TabIndex = 24
        '
        'BtnOutput
        '
        Me.BtnOutput.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnOutput.Location = New System.Drawing.Point(6, 126)
        Me.BtnOutput.Name = "BtnOutput"
        Me.BtnOutput.Size = New System.Drawing.Size(159, 28)
        Me.BtnOutput.TabIndex = 23
        Me.BtnOutput.Text = "Output"
        Me.BtnOutput.UseVisualStyleBackColor = True
        '
        'ChkDemam
        '
        Me.ChkDemam.AutoSize = True
        Me.ChkDemam.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ChkDemam.Location = New System.Drawing.Point(12, 86)
        Me.ChkDemam.Name = "ChkDemam"
        Me.ChkDemam.Size = New System.Drawing.Size(76, 23)
        Me.ChkDemam.TabIndex = 2
        Me.ChkDemam.Text = "Demam"
        Me.ChkDemam.UseVisualStyleBackColor = True
        '
        'ChkMual
        '
        Me.ChkMual.AutoSize = True
        Me.ChkMual.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ChkMual.Location = New System.Drawing.Point(12, 55)
        Me.ChkMual.Name = "ChkMual"
        Me.ChkMual.Size = New System.Drawing.Size(59, 23)
        Me.ChkMual.TabIndex = 1
        Me.ChkMual.Text = "Mual"
        Me.ChkMual.UseVisualStyleBackColor = True
        '
        'ChkPusing
        '
        Me.ChkPusing.AutoSize = True
        Me.ChkPusing.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ChkPusing.Location = New System.Drawing.Point(12, 24)
        Me.ChkPusing.Name = "ChkPusing"
        Me.ChkPusing.Size = New System.Drawing.Size(69, 23)
        Me.ChkPusing.TabIndex = 0
        Me.ChkPusing.Text = "Pusing"
        Me.ChkPusing.UseVisualStyleBackColor = True
        '
        'BtnAddItemListBox
        '
        Me.BtnAddItemListBox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnAddItemListBox.Location = New System.Drawing.Point(223, 267)
        Me.BtnAddItemListBox.Name = "BtnAddItemListBox"
        Me.BtnAddItemListBox.Size = New System.Drawing.Size(176, 25)
        Me.BtnAddItemListBox.TabIndex = 24
        Me.BtnAddItemListBox.Text = "Add Item"
        Me.BtnAddItemListBox.UseVisualStyleBackColor = True
        '
        'TxtAddItem
        '
        Me.TxtAddItem.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtAddItem.Location = New System.Drawing.Point(223, 236)
        Me.TxtAddItem.Name = "TxtAddItem"
        Me.TxtAddItem.Size = New System.Drawing.Size(176, 25)
        Me.TxtAddItem.TabIndex = 25
        '
        'BtnSelectedItem
        '
        Me.BtnSelectedItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnSelectedItem.Location = New System.Drawing.Point(13, 442)
        Me.BtnSelectedItem.Name = "BtnSelectedItem"
        Me.BtnSelectedItem.Size = New System.Drawing.Size(191, 25)
        Me.BtnSelectedItem.TabIndex = 26
        Me.BtnSelectedItem.Text = "Show Selected Item"
        Me.BtnSelectedItem.UseVisualStyleBackColor = True
        '
        'BtnCheckedItem
        '
        Me.BtnCheckedItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnCheckedItem.Location = New System.Drawing.Point(414, 442)
        Me.BtnCheckedItem.Name = "BtnCheckedItem"
        Me.BtnCheckedItem.Size = New System.Drawing.Size(191, 25)
        Me.BtnCheckedItem.TabIndex = 27
        Me.BtnCheckedItem.Text = "Show Checked Item"
        Me.BtnCheckedItem.UseVisualStyleBackColor = True
        '
        'ComboBoxLayanan
        '
        Me.ComboBoxLayanan.FormattingEnabled = True
        Me.ComboBoxLayanan.Items.AddRange(New Object() {"Inap", "Poliklinik", "Spesialis"})
        Me.ComboBoxLayanan.Location = New System.Drawing.Point(432, 65)
        Me.ComboBoxLayanan.Name = "ComboBoxLayanan"
        Me.ComboBoxLayanan.Size = New System.Drawing.Size(172, 23)
        Me.ComboBoxLayanan.TabIndex = 28
        '
        'BtnShowCdSel
        '
        Me.BtnShowCdSel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnShowCdSel.Location = New System.Drawing.Point(432, 94)
        Me.BtnShowCdSel.Name = "BtnShowCdSel"
        Me.BtnShowCdSel.Size = New System.Drawing.Size(172, 25)
        Me.BtnShowCdSel.TabIndex = 29
        Me.BtnShowCdSel.Text = "Show Selected Item"
        Me.BtnShowCdSel.UseVisualStyleBackColor = True
        '
        'BtnBack
        '
        Me.BtnBack.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnBack.Location = New System.Drawing.Point(221, 411)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(172, 56)
        Me.BtnBack.TabIndex = 30
        Me.BtnBack.Text = "Back"
        Me.BtnBack.UseVisualStyleBackColor = True
        '
        'listKeluhan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(616, 499)
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.BtnShowCdSel)
        Me.Controls.Add(Me.ComboBoxLayanan)
        Me.Controls.Add(Me.BtnCheckedItem)
        Me.Controls.Add(Me.BtnSelectedItem)
        Me.Controls.Add(Me.TxtAddItem)
        Me.Controls.Add(Me.BtnAddItemListBox)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnListCheck)
        Me.Controls.Add(Me.BtnTransfer)
        Me.Controls.Add(Me.LblListKeluhan)
        Me.Controls.Add(Me.ListBoxKeluhan)
        Me.Controls.Add(Me.CheckedListBoxKeluhan)
        Me.Name = "listKeluhan"
        Me.Text = "Tambah Keluhan"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CheckedListBoxKeluhan As CheckedListBox
    Friend WithEvents ListBoxKeluhan As ListBox
    Friend WithEvents LblListKeluhan As Label
    Friend WithEvents BtnTransfer As Button
    Friend WithEvents BtnListCheck As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnOutput As Button
    Friend WithEvents ChkDemam As CheckBox
    Friend WithEvents ChkMual As CheckBox
    Friend WithEvents ChkPusing As CheckBox
    Friend WithEvents BtnAddItemListBox As Button
    Friend WithEvents TxtAddItem As TextBox
    Friend WithEvents BtnSelectedItem As Button
    Friend WithEvents BtnCheckedItem As Button
    Friend WithEvents BtnTransferSelected As Button
    Friend WithEvents CheckedListBoxChckd As CheckedListBox
    Friend WithEvents ComboBoxLayanan As ComboBox
    Friend WithEvents BtnShowCdSel As Button
    Friend WithEvents BtnBack As Button
End Class
