<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddCoords
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
        Me.btnInsertLink = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboEnd = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboStart = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboChr = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtHeaderRow = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnInsertLink
        '
        Me.btnInsertLink.Location = New System.Drawing.Point(12, 156)
        Me.btnInsertLink.Name = "btnInsertLink"
        Me.btnInsertLink.Size = New System.Drawing.Size(129, 26)
        Me.btnInsertLink.TabIndex = 25
        Me.btnInsertLink.Text = "Insert Genomic Coords"
        Me.btnInsertLink.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 120)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 13)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "End:"
        '
        'cboEnd
        '
        Me.cboEnd.FormattingEnabled = True
        Me.cboEnd.Location = New System.Drawing.Point(42, 117)
        Me.cboEnd.Name = "cboEnd"
        Me.cboEnd.Size = New System.Drawing.Size(105, 21)
        Me.cboEnd.TabIndex = 23
        Me.cboEnd.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 93)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Start:"
        '
        'cboStart
        '
        Me.cboStart.FormattingEnabled = True
        Me.cboStart.Location = New System.Drawing.Point(42, 90)
        Me.cboStart.Name = "cboStart"
        Me.cboStart.Size = New System.Drawing.Size(105, 21)
        Me.cboStart.TabIndex = 21
        Me.cboStart.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Chr:"
        '
        'cboChr
        '
        Me.cboChr.FormattingEnabled = True
        Me.cboChr.Location = New System.Drawing.Point(42, 63)
        Me.cboChr.Name = "cboChr"
        Me.cboChr.Size = New System.Drawing.Size(105, 21)
        Me.cboChr.TabIndex = 19
        Me.cboChr.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "1. Select chr, start and end"
        '
        'txtHeaderRow
        '
        Me.txtHeaderRow.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHeaderRow.Location = New System.Drawing.Point(120, 8)
        Me.txtHeaderRow.Name = "txtHeaderRow"
        Me.txtHeaderRow.ReadOnly = True
        Me.txtHeaderRow.Size = New System.Drawing.Size(27, 20)
        Me.txtHeaderRow.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "0. Select header row"
        '
        'frmAddCoords
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(162, 194)
        Me.Controls.Add(Me.btnInsertLink)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cboEnd)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cboStart)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cboChr)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtHeaderRow)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmAddCoords"
        Me.ShowIcon = False
        Me.Text = "Add Coordinates"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnInsertLink As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cboEnd As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboStart As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cboChr As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtHeaderRow As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
