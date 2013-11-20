<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAction
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
        Me.btnCadet = New System.Windows.Forms.Button()
        Me.btnIn = New System.Windows.Forms.Button()
        Me.btnInOut = New System.Windows.Forms.Button()
        Me.btnShip = New System.Windows.Forms.Button()
        Me.btnVolunteer = New System.Windows.Forms.Button()
        Me.btnDonate = New System.Windows.Forms.Button()
        Me.btnReports = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnAddCadet = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCadet
        '
        Me.btnCadet.Location = New System.Drawing.Point(139, 19)
        Me.btnCadet.Name = "btnCadet"
        Me.btnCadet.Size = New System.Drawing.Size(75, 23)
        Me.btnCadet.TabIndex = 0
        Me.btnCadet.Text = "View Cadet"
        Me.btnCadet.UseVisualStyleBackColor = True
        '
        'btnIn
        '
        Me.btnIn.Location = New System.Drawing.Point(89, 184)
        Me.btnIn.Name = "btnIn"
        Me.btnIn.Size = New System.Drawing.Size(75, 23)
        Me.btnIn.TabIndex = 1
        Me.btnIn.Text = "Check In"
        Me.btnIn.UseVisualStyleBackColor = True
        '
        'btnInOut
        '
        Me.btnInOut.Location = New System.Drawing.Point(267, 184)
        Me.btnInOut.Name = "btnInOut"
        Me.btnInOut.Size = New System.Drawing.Size(75, 23)
        Me.btnInOut.TabIndex = 2
        Me.btnInOut.Text = "Check Out"
        Me.btnInOut.UseVisualStyleBackColor = True
        '
        'btnShip
        '
        Me.btnShip.Location = New System.Drawing.Point(420, 184)
        Me.btnShip.Name = "btnShip"
        Me.btnShip.Size = New System.Drawing.Size(75, 23)
        Me.btnShip.TabIndex = 3
        Me.btnShip.Text = "Shippment"
        Me.btnShip.UseVisualStyleBackColor = True
        '
        'btnVolunteer
        '
        Me.btnVolunteer.Location = New System.Drawing.Point(50, 14)
        Me.btnVolunteer.Name = "btnVolunteer"
        Me.btnVolunteer.Size = New System.Drawing.Size(88, 37)
        Me.btnVolunteer.TabIndex = 0
        Me.btnVolunteer.Text = "Volunteer Hours"
        Me.btnVolunteer.UseVisualStyleBackColor = True
        '
        'btnDonate
        '
        Me.btnDonate.Location = New System.Drawing.Point(228, 21)
        Me.btnDonate.Name = "btnDonate"
        Me.btnDonate.Size = New System.Drawing.Size(75, 23)
        Me.btnDonate.TabIndex = 1
        Me.btnDonate.Text = "Donations"
        Me.btnDonate.UseVisualStyleBackColor = True
        '
        'btnReports
        '
        Me.btnReports.Location = New System.Drawing.Point(381, 21)
        Me.btnReports.Name = "btnReports"
        Me.btnReports.Size = New System.Drawing.Size(75, 23)
        Me.btnReports.TabIndex = 2
        Me.btnReports.Text = "Reports"
        Me.btnReports.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnDonate)
        Me.GroupBox1.Controls.Add(Me.btnVolunteer)
        Me.GroupBox1.Controls.Add(Me.btnReports)
        Me.GroupBox1.Location = New System.Drawing.Point(39, 266)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(487, 58)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Miscellaneous"
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(39, 163)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(487, 59)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Uniforms"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnAddCadet)
        Me.GroupBox3.Controls.Add(Me.btnCadet)
        Me.GroupBox3.Location = New System.Drawing.Point(42, 79)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(484, 51)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Cadets"
        '
        'btnAddCadet
        '
        Me.btnAddCadet.Location = New System.Drawing.Point(293, 19)
        Me.btnAddCadet.Name = "btnAddCadet"
        Me.btnAddCadet.Size = New System.Drawing.Size(75, 23)
        Me.btnAddCadet.TabIndex = 1
        Me.btnAddCadet.Text = "Add Cadet"
        Me.btnAddCadet.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(420, 367)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmAction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(604, 402)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnShip)
        Me.Controls.Add(Me.btnInOut)
        Me.Controls.Add(Me.btnIn)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmAction"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Action"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCadet As System.Windows.Forms.Button
    Friend WithEvents btnIn As System.Windows.Forms.Button
    Friend WithEvents btnInOut As System.Windows.Forms.Button
    Friend WithEvents btnShip As System.Windows.Forms.Button
    Friend WithEvents btnVolunteer As System.Windows.Forms.Button
    Friend WithEvents btnDonate As System.Windows.Forms.Button
    Friend WithEvents btnReports As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnAddCadet As System.Windows.Forms.Button
End Class
