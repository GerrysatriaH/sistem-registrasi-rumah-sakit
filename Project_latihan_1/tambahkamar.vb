Public Class tambahkamar
    Public TotalAddkamar As Integer = 0
    Private fungsiKamar As FungsiKamar

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        fungsiKamar = New FungsiKamar()

        LblNum.Text = Pendaftaran.fungsiKamar.GSJumlahKamar
        TxtValueKamar.Text = TotalAddkamar

        If TotalAddkamar < 1 Then
            BtnMin.Enabled = False
        End If
    End Sub

    Private Sub BtnMin_Click(sender As Object, e As EventArgs) Handles BtnMin.Click
        TotalAddkamar = TotalAddkamar - 1
        TxtValueKamar.Text = TotalAddkamar

        If TotalAddkamar < 1 Then
            BtnMin.Enabled = False
        End If
    End Sub

    Private Sub BtnPlus_Click(sender As Object, e As EventArgs) Handles BtnPlus.Click
        TotalAddkamar = TotalAddkamar + 1
        TxtValueKamar.Text = TotalAddkamar


        If TotalAddkamar >= 1 Then
            BtnMin.Enabled = True
        End If
    End Sub

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        'Pendaftaran.Kamar += Integer.Parse(TxtValueKamar.Text)
        Pendaftaran.fungsiKamar.TambahKamar(Integer.Parse(TxtValueKamar.Text))
        Me.Close()
    End Sub

End Class