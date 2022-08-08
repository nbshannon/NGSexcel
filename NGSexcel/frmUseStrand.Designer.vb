<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUseStrand
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
        Me.chkForceDirection = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboStrand = New System.Windows.Forms.ComboBox()
        Me.txtHeaderRow = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnApply = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'chkForceDirection
        '
        Me.chkForceDirection.AutoSize = True
        Me.chkForceDirection.Location = New System.Drawing.Point(6, 59)
        Me.chkForceDirection.Name = "chkForceDirection"
        Me.chkForceDirection.Size = New System.Drawing.Size(135, 17)
        Me.chkForceDirection.TabIndex = 18
        Me.chkForceDirection.Text = "Keep sequence 5' to 3'"
        Me.chkForceDirection.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Strand:"
        '
        'cboStrand
        '
        Me.cboStrand.FormattingEnabled = True
        Me.cboStrand.Location = New System.Drawing.Point(50, 32)
        Me.cboStrand.Name = "cboStrand"
        Me.cboStrand.Size = New System.Drawing.Size(91, 21)
        Me.cboStrand.TabIndex = 23
        '
        'txtHeaderRow
        '
        Me.txtHeaderRow.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHeaderRow.Location = New System.Drawing.Point(114, 6)
        Me.txtHeaderRow.Name = "txtHeaderRow"
        Me.txtHeaderRow.ReadOnly = True
        Me.txtHeaderRow.Size = New System.Drawing.Size(27, 20)
        Me.txtHeaderRow.TabIndex = 22
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "0. Select header row"
        '
        'btnApply
        '
        Me.btnApply.Location = New System.Drawing.Point(33, 82)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(75, 23)
        Me.btnApply.TabIndex = 25
        Me.btnApply.Text = "Apply"
        Me.btnApply.UseVisualStyleBackColor = True
        '
        'frmUseStrand
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(153, 115)
        Me.Controls.Add(Me.btnApply)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cboStrand)
        Me.Controls.Add(Me.txtHeaderRow)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.chkForceDirection)
        Me.Name = "frmUseStrand"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Use Strand Information"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chkForceDirection As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cboStrand As System.Windows.Forms.ComboBox
    Friend WithEvents txtHeaderRow As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnApply As System.Windows.Forms.Button
End Class
