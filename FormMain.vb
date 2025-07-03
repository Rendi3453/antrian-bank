Public Class FormMain
    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblnama.Click

    End Sub

    Private Sub txtNama_TextChanged(sender As Object, e As EventArgs) Handles txtNama.TextChanged

    End Sub

    Private Sub lblLayanan_Click(sender As Object, e As EventArgs) Handles lblLayanan.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub cmblayanan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbLayanan.SelectedIndexChanged
        'combo box
        cmbLayanan.Items.Clear()
        cmbLayanan.Items.Add("Teller")
        cmbLayanan.Items.Add("Customer Service")
        cmbLayanan.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub


    Private Sub btnAmbilAntrian_Click(sender As Object, e As EventArgs) Handles btnAmbilAntrian.Click
        If txtNama.Text = "" Or cmbLayanan.SelectedIndex = -1 Then
            MessageBox.Show("Lengkapi nama dan layanan.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Panggil fungsi dari back-end untuk simpan
        SimpanAntrian(txtNama.Text, cmbLayanan.Text)

        txtNama.Clear()
        cmbLayanan.SelectedIndex = -1

        ' Refresh DataGridView
        TampilkanAntrian()
    End Sub


    Private Sub dgaAntrian_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgaAntrian.CellContentClick

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        With CetakForm
            .lblNomor.Text = nomorTerakhir ' ← Pastikan sudah diambil dari backend
            .lblNama.Text = txtNama.Text
            .lblLayanan.Text = cmbLayanan.Text
            .lblWaktu.Text = Now.ToString("HH:mm, dd MMM yyyy")
            .Show()
        End With
    End Sub
End Class