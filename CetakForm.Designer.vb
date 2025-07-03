<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CetakForm
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
        Me.lblJudul = New System.Windows.Forms.Label()
        Me.lblNomor = New System.Windows.Forms.Label()
        Me.lblNama = New System.Windows.Forms.Label()
        Me.lblLayanan = New System.Windows.Forms.Label()
        Me.lblWaktu = New System.Windows.Forms.Label()
        Me.btnCetakNow = New System.Windows.Forms.Button()
        Me.btnOut = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblJudul
        '
        Me.lblJudul.AutoSize = True
        Me.lblJudul.Location = New System.Drawing.Point(258, 55)
        Me.lblJudul.Name = "lblJudul"
        Me.lblJudul.Size = New System.Drawing.Size(108, 16)
        Me.lblJudul.TabIndex = 0
        Me.lblJudul.Text = "TIKET ANTRIAN"
        '
        'lblNomor
        '
        Me.lblNomor.AutoSize = True
        Me.lblNomor.Location = New System.Drawing.Point(160, 105)
        Me.lblNomor.Name = "lblNomor"
        Me.lblNomor.Size = New System.Drawing.Size(99, 16)
        Me.lblNomor.TabIndex = 1
        Me.lblNomor.Text = "NO. ANTRIAN :"
        '
        'lblNama
        '
        Me.lblNama.AutoSize = True
        Me.lblNama.Location = New System.Drawing.Point(160, 156)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Size = New System.Drawing.Size(52, 16)
        Me.lblNama.TabIndex = 2
        Me.lblNama.Text = "NAMA :"
        '
        'lblLayanan
        '
        Me.lblLayanan.AutoSize = True
        Me.lblLayanan.Location = New System.Drawing.Point(160, 204)
        Me.lblLayanan.Name = "lblLayanan"
        Me.lblLayanan.Size = New System.Drawing.Size(76, 16)
        Me.lblLayanan.TabIndex = 3
        Me.lblLayanan.Text = "LAYANAN :"
        '
        'lblWaktu
        '
        Me.lblWaktu.AutoSize = True
        Me.lblWaktu.Location = New System.Drawing.Point(160, 251)
        Me.lblWaktu.Name = "lblWaktu"
        Me.lblWaktu.Size = New System.Drawing.Size(62, 16)
        Me.lblWaktu.TabIndex = 4
        Me.lblWaktu.Text = "WAKTU :"
        '
        'btnCetakNow
        '
        Me.btnCetakNow.Location = New System.Drawing.Point(169, 300)
        Me.btnCetakNow.Name = "btnCetakNow"
        Me.btnCetakNow.Size = New System.Drawing.Size(116, 43)
        Me.btnCetakNow.TabIndex = 5
        Me.btnCetakNow.Text = "CETAK SEKAARANG"
        Me.btnCetakNow.UseVisualStyleBackColor = True
        '
        'btnOut
        '
        Me.btnOut.Location = New System.Drawing.Point(316, 300)
        Me.btnOut.Name = "btnOut"
        Me.btnOut.Size = New System.Drawing.Size(116, 43)
        Me.btnOut.TabIndex = 6
        Me.btnOut.Text = "KELUAR"
        Me.btnOut.UseVisualStyleBackColor = True
        '
        'CetakForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1256, 770)
        Me.Controls.Add(Me.btnOut)
        Me.Controls.Add(Me.btnCetakNow)
        Me.Controls.Add(Me.lblWaktu)
        Me.Controls.Add(Me.lblLayanan)
        Me.Controls.Add(Me.lblNama)
        Me.Controls.Add(Me.lblNomor)
        Me.Controls.Add(Me.lblJudul)
        Me.Name = "CetakForm"
        Me.Text = "CetakForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblJudul As Label
    Friend WithEvents lblNomor As Label
    Friend WithEvents lblNama As Label
    Friend WithEvents lblLayanan As Label
    Friend WithEvents lblWaktu As Label
    Friend WithEvents btnCetakNow As Button
    Friend WithEvents btnOut As Button
End Class
