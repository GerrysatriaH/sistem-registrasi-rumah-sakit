Public Class latihanPertemuan6

    'Tipe Variable dan Value nya
    Dim artists As Short = 2500
    Dim hours As UShort = 5000
    Dim population As Integer = 375000
    Dim seconds As UInteger = 3000000
    Dim bugs As Long = 7800000016
    Dim sandGrains As ULong = 1800000000000000000
    Dim unitCost As Single = 899.99
    Dim pi As Double = 3.1415926535
    Dim debt As Decimal = 7600300.5
    Dim retKey As Byte = 13
    Dim negNum As SByte = -20
    Dim unicodeChar As Char = "A"c
    Dim greeting As String = "hello world"
    Dim flag As Boolean = True
    Dim birthday As Date = #3/17/1900#

    Private Sub ListBoxExampleVariable_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxExampleVariable.SelectedIndexChanged

        Dim tipeVariable As String = ListBoxExampleVariable.SelectedItem()

        'IF Operator

        If tipeVariable = "Short" Then
            TxtVariableWithIF.Text = artists

        ElseIf tipeVariable = "UShort" Then
            TxtVariableWithIF.Text = hours

        ElseIf tipeVariable = "Integer" Then
            TxtVariableWithIF.Text = population

        ElseIf tipeVariable = "UInteger" Then
            TxtVariableWithIF.Text = seconds

        ElseIf tipeVariable = "Long" Then
            TxtVariableWithIF.Text = bugs

        ElseIf tipeVariable = "ULong" Then
            TxtVariableWithIF.Text = sandGrains

        ElseIf tipeVariable = "Single" Then
            TxtVariableWithIF.Text = unitCost

        ElseIf tipeVariable = "Double" Then
            TxtVariableWithIF.Text = pi

        ElseIf tipeVariable = "Decimal" Then
            TxtVariableWithIF.Text = debt

        ElseIf tipeVariable = "Byte" Then
            TxtVariableWithIF.Text = retKey

        ElseIf tipeVariable = "SByte" Then
            TxtVariableWithIF.Text = negNum

        ElseIf tipeVariable = "Char" Then
            TxtVariableWithIF.Text = unicodeChar

        ElseIf tipeVariable = "String" Then
            TxtVariableWithIF.Text = greeting

        ElseIf tipeVariable = "Boolean" Then
            TxtVariableWithIF.Text = flag.ToString()

        ElseIf tipeVariable = "Date" Then
            TxtVariableWithIF.Text = birthday
        End If
    End Sub

    Private Sub ListBoxTipeVariableSwitch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxTipeVariableSwitch.SelectedIndexChanged

        Dim tipeVariable As String = ListBoxTipeVariableSwitch.SelectedItem()

        Select Case tipeVariable
            Case "Short"
                TxtVariableWithSwitch.Text = artists
            Case "UShort"
                TxtVariableWithSwitch.Text = hours
            Case "Integer"
                TxtVariableWithSwitch.Text = population
            Case "UInteger"
                TxtVariableWithSwitch.Text = seconds
            Case "Long"
                TxtVariableWithSwitch.Text = bugs
            Case "ULong"
                TxtVariableWithSwitch.Text = sandGrains
            Case "Single"
                TxtVariableWithSwitch.Text = unitCost
            Case "Double"
                TxtVariableWithSwitch.Text = pi
            Case "Decimal"
                TxtVariableWithSwitch.Text = debt
            Case "Byte"
                TxtVariableWithSwitch.Text = retKey
            Case "SByte"
                TxtVariableWithSwitch.Text = negNum
            Case "Char"
                TxtVariableWithSwitch.Text = unicodeChar
            Case "String"
                TxtVariableWithSwitch.Text = greeting
            Case "Boolean"
                TxtVariableWithSwitch.Text = flag.ToString()
            Case "Date"
                TxtVariableWithSwitch.Text = birthday
        End Select
    End Sub

    Private Sub BtnToString_Click(sender As Object, e As EventArgs) Handles BtnToString.Click
        Dim originInt As Integer = 12345
        Dim convertString As String
        convertString = originInt.ToString()
        TxtConvertedString.Text = convertString
    End Sub

    Private Sub BtnParseInt_Click(sender As Object, e As EventArgs) Handles BtnParseInt.Click
        Dim originString As String = "1234"
        Dim convertInteger As Integer
        convertInteger = Integer.Parse(originString)
        TxtConvertedInteger.Text = convertInteger
    End Sub

    Private Sub BtnCInt_Click(sender As Object, e As EventArgs) Handles BtnCInt.Click
        Dim originDouble As Double = 3.1415926535
        Dim convertDbltoInt As Integer
        convertDbltoInt = CInt(originDouble)
        TxtConvInteger.Text = convertDbltoInt
    End Sub

    Private Sub BtnFor1_Click(sender As Object, e As EventArgs) Handles BtnFor1.Click
        ListBoxLoop.Items.Clear()
        Dim i As Integer
        For i = 0 To 20
            ListBoxLoop.Items.Add(i)
        Next
    End Sub

    Private Sub BtnFor2_Click(sender As Object, e As EventArgs) Handles BtnFor2.Click
        ListBoxLoop.Items.Clear()
        Dim i As Integer
        For i = 0 To 20 Step 5
            ListBoxLoop.Items.Add(i)
        Next
    End Sub

    Private Sub BtnDo1_Click(sender As Object, e As EventArgs) Handles BtnDo1.Click
        ListBoxLoop.Items.Clear()
        Dim i As Integer
        Do While i <= 20
            ListBoxLoop.Items.Add(i)
            i += 1
        Loop
    End Sub

    Private Sub BtnDo2_Click(sender As Object, e As EventArgs) Handles BtnDo2.Click
        ListBoxLoop.Items.Clear()
        Dim i As Integer
        Do
            ListBoxLoop.Items.Add(i)
            i += 5
        Loop While i <= 20
    End Sub

    Private Sub BtnPangkat_Click(sender As Object, e As EventArgs) Handles BtnPangkat.Click
        Dim A As Integer = TxtA.Text
        Dim B As Integer = TxtB.Text

        TxtHasil.Text = A ^ B
    End Sub

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        Dim A As Integer = TxtA.Text
        Dim B As Integer = TxtB.Text

        TxtHasil.Text = A + B
    End Sub

    Private Sub BtnKurang_Click(sender As Object, e As EventArgs) Handles BtnKurang.Click
        Dim A As Integer = TxtA.Text
        Dim B As Integer = TxtB.Text

        TxtHasil.Text = A - B
    End Sub

    Private Sub BtnKali_Click(sender As Object, e As EventArgs) Handles BtnKali.Click
        Dim A As Integer = TxtA.Text
        Dim B As Integer = TxtB.Text

        TxtHasil.Text = A * B
    End Sub

    Private Sub BtnBagiFloat_Click(sender As Object, e As EventArgs) Handles BtnBagiFloat.Click
        Dim A As Integer = TxtA.Text
        Dim B As Integer = TxtB.Text

        TxtHasil.Text = A / B
    End Sub

    Private Sub BtnBagiInteger_Click(sender As Object, e As EventArgs) Handles BtnBagiInteger.Click
        Dim A As Integer = TxtA.Text
        Dim B As Integer = TxtB.Text

        TxtHasil.Text = A \ B
    End Sub

    Private Sub BtnMod_Click(sender As Object, e As EventArgs) Handles BtnMod.Click
        Dim A As Integer = TxtA.Text
        Dim B As Integer = TxtB.Text

        TxtHasil.Text = A Mod B
    End Sub

    Private Sub BtnConcat_Click(sender As Object, e As EventArgs) Handles BtnConcat.Click
        Dim A As String = TxtA.Text
        Dim B As String = TxtB.Text

        TxtHasil.Text = A & B
    End Sub

    Private Sub TxtUmur_TextChanged(sender As Object, e As EventArgs) Handles TxtUmur.TextChanged

        If TxtUmur.Text.Length > 0 Then
            Dim umur As Integer = Integer.Parse(TxtUmur.Text)
            If umur <= 5 And umur >= 0 Then
                LblKategoriWithIF.Text = "Balita"
            ElseIf umur <= 11 And umur >= 6 Then
                LblKategoriWithIF.Text = "Kanak-kanak"
            ElseIf umur <= 16 And umur >= 12 Then
                LblKategoriWithIF.Text = "Remaja Awal"
            ElseIf umur <= 25 And umur >= 17 Then
                LblKategoriWithIF.Text = "Remaja Akhir"
            ElseIf umur <= 35 And umur >= 26 Then
                LblKategoriWithIF.Text = "Dewasa Awal"
            ElseIf umur <= 45 And umur >= 36 Then
                LblKategoriWithIF.Text = "Dewasa Akhir"
            ElseIf umur <= 55 And umur >= 46 Then
                LblKategoriWithIF.Text = "Lansia Awal"
            ElseIf umur <= 65 And umur >= 56 Then
                LblKategoriWithIF.Text = "Lansia Akhir"
            ElseIf umur > 65 Then
                LblKategoriWithIF.Text = "Manula"
            End If

            Select Case umur
                Case 0 To 5
                    LblKategoriWithSwitch.Text = "Balita"
                Case 6 To 11
                    LblKategoriWithSwitch.Text = "Kanak-kanak"
                Case 12 To 16
                    LblKategoriWithSwitch.Text = "Remaja Awal"
                Case 17 To 25
                    LblKategoriWithSwitch.Text = "Remaja Akhir"
                Case 26 To 35
                    LblKategoriWithSwitch.Text = "Dewasa Awal"
                Case 36 To 45
                    LblKategoriWithSwitch.Text = "Dewasa Akhir"
                Case 46 To 55
                    LblKategoriWithSwitch.Text = "Lansia Awal"
                Case 56 To 65
                    LblKategoriWithSwitch.Text = "Lansia Akhir"
                Case > 65
                    LblKategoriWithSwitch.Text = "Manula"
            End Select
        End If
    End Sub

    Private Sub TxtUmur_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtUmur.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("Please insert number only")
        End If
    End Sub

    Private Sub TxtA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtA.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("Please insert number only")
        End If
    End Sub

    Private Sub TxtB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtB.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("Please insert number only")
        End If
    End Sub
End Class