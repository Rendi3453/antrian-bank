<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
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
        Me.lblnama = New System.Windows.Forms.Label()
        Me.lblLayanan = New System.Windows.Forms.Label()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.cmbLayanan = New System.Windows.Forms.ComboBox()
        Me.btnAmbilAntrian = New System.Windows.Forms.Button()
        Me.dgaAntrian = New System.Windows.Forms.DataGridView()
        Me.HEADER = New System.Windows.Forms.TextBox()
        Me.HEADER2 = New System.Windows.Forms.TextBox()
        Me.lblDaftar = New System.Windows.Forms.Label()
        Me.btnCetak = New System.Windows.Forms.Button()
        CType(Me.dgaAntrian, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblnama
        '
        Me.lblnama.AutoSize = True
        Me.lblnama.Location = New System.Drawing.Point(40, 62)
        Me.lblnama.Name = "lblnama"
        Me.lblnama.Size = New System.Drawing.Size(103, 16)
        Me.lblnama.TabIndex = 0
        Me.lblnama.Text = "Nama Nasabah"
        '
        'lblLayanan
        '
        Me.lblLayanan.AutoSize = True
        Me.lblLayanan.Location = New System.Drawing.Point(40, 131)
        Me.lblLayanan.Name = "lblLayanan"
        Me.lblLayanan.Size = New System.Drawing.Size(59, 16)
        Me.lblLayanan.TabIndex = 1
        Me.lblLayanan.Text = "Layanan"
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(43, 81)
        Me.txtNama.Multiline = True
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(1181, 38)
        Me.txtNama.TabIndex = 2
        '
        'cmbLayanan
        '
        Me.cmbLayanan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLayanan.FormattingEnabled = True
        Me.cmbLayanan.Items.AddRange(New Object() {"Teller", "CS"})
        Me.cmbLayanan.Location = New System.Drawing.Point(43, 160)
        Me.cmbLayanan.Name = "cmbLayanan"
        Me.cmbLayanan.Size = New System.Drawing.Size(1181, 24)
        Me.cmbLayanan.TabIndex = 4
        '
        'btnAmbilAntrian
        '
        Me.btnAmbilAntrian.Location = New System.Drawing.Point(43, 189)
        Me.btnAmbilAntrian.Name = "btnAmbilAntrian"
        Me.btnAmbilAntrian.Size = New System.Drawing.Size(1181, 73)
        Me.btnAmbilAntrian.TabIndex = 5
        Me.btnAmbilAntrian.Text = "AMBIL ANTRIAN"
        Me.btnAmbilAntrian.UseVisualStyleBackColor = True
        '
        'dgaAntrian
        '
        Me.dgaAntrian.AccessibleName = "(untuk menampilkan data)" & Global.Microsoft.VisualBasic.ChrW(10)
        Me.dgaAntrian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgaAntrian.Location = New System.Drawing.Point(43, 291)
        Me.dgaAntrian.Name = "dgaAntrian"
        Me.dgaAntrian.RowHeadersWidth = 51
        Me.dgaAntrian.RowTemplate.Height = 24
        Me.dgaAntrian.Size = New System.Drawing.Size(1181, 360)
        Me.dgaAntrian.TabIndex = 6
        '
        'HEADER
        '
        Me.HEADER.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.HEADER.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.HEADER.Location = New System.Drawing.Point(388, 12)
        Me.HEADER.Name = "HEADER"
        Me.HEADER.Size = New System.Drawing.Size(383, 26)
        Me.HEADER.TabIndex = 7
        Me.HEADER.Text = "SILAHKAN DIISI DAN DAPATKAN CETAK PRINT"
        '
        'HEADER2
        '
        Me.HEADER2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.HEADER2.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.HEADER2.Location = New System.Drawing.Point(442, 43)
        Me.HEADER2.Name = "HEADER2"
        Me.HEADER2.Size = New System.Drawing.Size(274, 15)
        Me.HEADER2.TabIndex = 8
        Me.HEADER2.Text = "DAN TUNGGU PANGGILAN NOMER ANDA "
        '
        'lblDaftar
        '
        Me.lblDaftar.AutoSize = True
        Me.lblDaftar.Location = New System.Drawing.Point(43, 265)
        Me.lblDaftar.Name = "lblDaftar"
        Me.lblDaftar.Size = New System.Drawing.Size(125, 16)
        Me.lblDaftar.TabIndex = 14
        Me.lblDaftar.Text = "DAFTAR ANTRIAN"
        '
        'btnCetak
        '
        Me.btnCetak.Location = New System.Drawing.Point(43, 670)
        Me.btnCetak.Name = "btnCetak"
        Me.btnCetak.Size = New System.Drawing.Size(1178, 71)
        Me.btnCetak.TabIndex = 9
        Me.btnCetak.Text = "CETAK TIKET"
        Me.btnCetak.UseVisualStyleBackColor = True
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1253, 785)
        Me.Controls.Add(Me.lblDaftar)
        Me.Controls.Add(Me.btnCetak)
        Me.Controls.Add(Me.HEADER2)
        Me.Controls.Add(Me.HEADER)
        Me.Controls.Add(Me.dgaAntrian)
        Me.Controls.Add(Me.btnAmbilAntrian)
        Me.Controls.Add(Me.cmbLayanan)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.lblLayanan)
        Me.Controls.Add(Me.lblnama)
        Me.Name = "FormMain"
        Me.Text = "(untuk menampilkan data)" & Global.Microsoft.VisualBasic.ChrW(10)
        CType(Me.dgaAntrian, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblnama As Label
    Friend WithEvents lblLayanan As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents cmbLayanan As ComboBox
    Friend WithEvents btnAmbilAntrian As Button
    Friend WithEvents dgaAntrian As DataGridView
    Friend WithEvents HEADER As TextBox
    Friend WithEvents HEADER2 As TextBox
    Friend WithEvents lblDaftar As Label
    Friend WithEvents btnCetak As Button
End Class
