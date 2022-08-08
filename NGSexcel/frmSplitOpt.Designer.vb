<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSplitOpt
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
        Me.cboSplit = New System.Windows.Forms.ComboBox()
        Me.btnAddSplit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cboSplit
        '
        Me.cboSplit.FormattingEnabled = True
        Me.cboSplit.Location = New System.Drawing.Point(12, 27)
        Me.cboSplit.Name = "cboSplit"
        Me.cboSplit.Size = New System.Drawing.Size(121, 21)
        Me.cboSplit.TabIndex = 0
        '
        'btnAddSplit
        '
        Me.btnAddSplit.Location = New System.Drawing.Point(31, 54)
        Me.btnAddSplit.Name = "btnAddSplit"
        Me.btnAddSplit.Size = New System.Drawing.Size(69, 23)
        Me.btnAddSplit.TabIndex = 1
        Me.btnAddSplit.Text = "Add split"
        Me.btnAddSplit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Column to split on"
        '
        'frmSplitOpt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(136, 84)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAddSplit)
        Me.Controls.Add(Me.cboSplit)
        Me.Name = "frmSplitOpt"
        Me.ShowIcon = False
        Me.Text = "Add Split"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboSplit As System.Windows.Forms.ComboBox
    Friend WithEvents btnAddSplit As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
