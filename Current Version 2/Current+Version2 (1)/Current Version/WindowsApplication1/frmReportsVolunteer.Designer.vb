<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportsVolunteer
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
        Me.dtpStart = New System.Windows.Forms.DateTimePicker()
        Me.dtpEnd = New System.Windows.Forms.DateTimePicker()
        Me.dgvRepVolunteer = New System.Windows.Forms.DataGridView()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Rank = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Hours = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvRepVolunteer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtpStart
        '
        Me.dtpStart.Location = New System.Drawing.Point(12, 6)
        Me.dtpStart.Name = "dtpStart"
        Me.dtpStart.Size = New System.Drawing.Size(200, 20)
        Me.dtpStart.TabIndex = 0
        '
        'dtpEnd
        '
        Me.dtpEnd.Location = New System.Drawing.Point(299, 6)
        Me.dtpEnd.Name = "dtpEnd"
        Me.dtpEnd.Size = New System.Drawing.Size(200, 20)
        Me.dtpEnd.TabIndex = 1
        '
        'dgvRepVolunteer
        '
        Me.dgvRepVolunteer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRepVolunteer.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Rank, Me.LastName, Me.Hours})
        Me.dgvRepVolunteer.Location = New System.Drawing.Point(12, 32)
        Me.dgvRepVolunteer.Name = "dgvRepVolunteer"
        Me.dgvRepVolunteer.Size = New System.Drawing.Size(487, 260)
        Me.dgvRepVolunteer.TabIndex = 3
        '
        'btnGenerate
        '
        Me.btnGenerate.Location = New System.Drawing.Point(12, 298)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(62, 39)
        Me.btnGenerate.TabIndex = 2
        Me.btnGenerate.Text = "Generate Report"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(224, 298)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(62, 39)
        Me.btnPrint.TabIndex = 3
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(436, 298)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(62, 39)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Back"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Rank
        '
        Me.Rank.HeaderText = "Rank"
        Me.Rank.Name = "Rank"
        Me.Rank.ReadOnly = True
        '
        'LastName
        '
        Me.LastName.HeaderText = "Last Name"
        Me.LastName.Name = "LastName"
        Me.LastName.ReadOnly = True
        '
        'Hours
        '
        Me.Hours.HeaderText = "Hours"
        Me.Hours.Name = "Hours"
        Me.Hours.ReadOnly = True
        '
        'frmReportsVolunteer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(507, 345)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnGenerate)
        Me.Controls.Add(Me.dgvRepVolunteer)
        Me.Controls.Add(Me.dtpEnd)
        Me.Controls.Add(Me.dtpStart)
        Me.Name = "frmReportsVolunteer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Volunteer Report"
        CType(Me.dgvRepVolunteer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dtpStart As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents dgvRepVolunteer As System.Windows.Forms.DataGridView
    Friend WithEvents btnGenerate As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Rank As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Hours As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
