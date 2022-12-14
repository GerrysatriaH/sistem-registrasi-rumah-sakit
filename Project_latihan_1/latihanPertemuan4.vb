Public Class latihanPertemuan4
    Dim keluhan_arrlist As New List(Of String)
    Dim keluhan_arrlist_id As New List(Of String)
    Dim layanan As New List(Of String) From {"Inap", "Poliklinik", "Spesialis"}

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ComboBoxLayanan.DataSource = layanan

    End Sub

    Private Sub BtnTransfer_Click(sender As Object, e As EventArgs) Handles BtnTransfer.Click
        ListBoxKeluhan.Items.Clear()

        If ChkPusing.Checked() Then
            keluhan_arrlist.Add("Pusing")
        End If

        If ChkMual.Checked() Then
            keluhan_arrlist.Add("Mual")
        End If

        If ChkDemam.Checked() Then
            keluhan_arrlist.Add("Demam")
        End If

        For Each kel In keluhan_arrlist
            ListBoxKeluhan.Items.Add(kel)
        Next

        keluhan_arrlist.Clear()
    End Sub

    Private Sub BtnAddItemListBox_Click(sender As Object, e As EventArgs) Handles BtnAddItemListBox.Click
        Dim add_item = TxtAddItem.Text
        ListBoxKeluhan.Items.Add(add_item)
    End Sub

    Private Sub BtnOutput_Click_1(sender As Object, e As EventArgs) Handles BtnOutput.Click
        If ChkPusing.Checked() Then
            keluhan_arrlist.Add("Pusing")
        End If

        If ChkMual.Checked() Then
            keluhan_arrlist.Add("Mual")
        End If

        If ChkDemam.Checked() Then
            keluhan_arrlist.Add("Demam")
        End If

        Dim keluhan_str = String.Join(", ", keluhan_arrlist.ToArray)
        MessageBox.Show(keluhan_str)

        keluhan_arrlist.Clear()
    End Sub

    Private Sub BtnSelectedItem_Click(sender As Object, e As EventArgs) Handles BtnSelectedItem.Click
        MessageBox.Show(ListBoxKeluhan.SelectedItem())
    End Sub

    Private Sub BtnCheckedItem_Click(sender As Object, e As EventArgs) Handles BtnCheckedItem.Click
        For i = 0 To CheckedListBoxKeluhan.Items.Count - 1
            Dim Item As Object = CheckedListBoxKeluhan.Items(i)

            If CheckedListBoxKeluhan.GetItemChecked(i) Then
                keluhan_arrlist.Add(CheckedListBoxKeluhan.Items(i))
            End If
        Next

        Dim keluhan_str = String.Join(", ", keluhan_arrlist.ToArray)
        MessageBox.Show(keluhan_str)

        keluhan_arrlist.Clear()
    End Sub

    Private Sub BtnTransferSelected_Click(sender As Object, e As EventArgs) Handles BtnTransferSelected.Click
        'Unchecked All Item, (Reset() Selected Item)

        For i As Integer = 0 To CheckedListBoxChckd.Items.Count - 1
            CheckedListBoxChckd.SetItemChecked(1, False)
        Next

        'Check Item
        If ChkPusing.Checked() Then
            keluhan_arrlist_id.Add(0)
        End If

        If ChkMual.Checked() Then
            keluhan_arrlist_id.Add(1)
        End If

        If ChkDemam.Checked() Then
            keluhan_arrlist_id.Add(2)
        End If

        For Each kel In keluhan_arrlist_id
            CheckedListBoxChckd.SetItemChecked(kel, True)
        Next

        keluhan_arrlist_id.Clear()
    End Sub

    Private Sub BtnListCheck_Click(sender As Object, e As EventArgs) Handles BtnListCheck.Click
        'Unchecked All Item, (Reset() Selected Item)

        For i As Integer = 0 To CheckedListBoxKeluhan.Items.Count - 1
            CheckedListBoxKeluhan.SetItemChecked(1, False)
        Next

        'Check Item
        If ChkPusing.Checked() Then
            keluhan_arrlist_id.Add(0)
        End If

        If ChkMual.Checked() Then
            keluhan_arrlist_id.Add(1)
        End If

        If ChkDemam.Checked() Then
            keluhan_arrlist_id.Add(2)
        End If

        For Each kel In keluhan_arrlist_id
            CheckedListBoxKeluhan.SetItemChecked(kel, True)
        Next

        keluhan_arrlist_id.Clear()
    End Sub

    Private Sub BtnShowCdSel_Click(sender As Object, e As EventArgs) Handles BtnShowCdSel.Click
        Dim layanan_item = ComboBoxLayanan.SelectedItem()
        MessageBox.Show(layanan_item)
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Me.Close()
    End Sub
End Class