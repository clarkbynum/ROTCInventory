<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReports
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
        Me.btnDonations = New System.Windows.Forms.Button()
        Me.btnVolunteer = New System.Windows.Forms.Button()
        Me.btnCadets = New System.Windows.Forms.Button()
        Me.btnInventory = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnDonations
        '
        Me.btnDonations.Location = New System.Drawing.Point(89, 224)
        Me.btnDonations.Name = "btnDonations"
        Me.btnDonations.Size = New System.Drawing.Size(75, 23)
        Me.btnDonations.TabIndex = 2
        Me.btnDonations.Text = "Donations"
        Me.btnDonations.UseVisualStyleBackColor = True
        '
        'btnVolunteer
        '
        Me.btnVolunteer.Location = New System.Drawing.Point(388, 224)
        Me.btnVolunteer.Name = "btnVolunteer"
        Me.btnVolunteer.Size = New System.Drawing.Size(75, 39)
        Me.btnVolunteer.TabIndex = 3
        Me.btnVolunteer.Text = "Volunteer Hours"
        Me.btnVolunteer.UseVisualStyleBackColor = True
        '
        'btnCadets
        '
        Me.btnCadets.Location = New System.Drawing.Point(89, 95)
        Me.btnCadets.Name = "btnCadets"
        Me.btnCadets.Size = New System.Drawing.Size(75, 23)
        Me.btnCadets.TabIndex = 0
        Me.btnCadets.Text = "Cadets"
        Me.btnCadets.UseVisualStyleBackColor = True
        '
        'btnInventory
        '
        Me.btnInventory.Location = New System.Drawing.Point(388, 95)
        Me.btnInventory.Name = "btnInventory"
        Me.btnInventory.Size = New System.Drawing.Size(75, 23)
        Me.btnInventory.TabIndex = 1
        Me.btnInventory.Text = "Inventory"
        Me.btnInventory.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(544, 373)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 4
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'frmReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(631, 408)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnInventory)
        Me.Controls.Add(Me.btnCadets)
        Me.Controls.Add(Me.btnVolunteer)
        Me.Controls.Add(Me.btnDonations)
        Me.Name = "frmReports"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reports"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnDonations As System.Windows.Forms.Button
    Friend WithEvents btnVolunteer As System.Windows.Forms.Button
    Friend WithEvents btnCadets As System.Windows.Forms.Button
    Friend WithEvents btnInventory As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
End Class
