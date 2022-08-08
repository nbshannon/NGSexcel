<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImport
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
        Me.btnImport = New System.Windows.Forms.Button()
        Me.cboSourceType = New System.Windows.Forms.ComboBox()
        Me.cboProvider = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnImport
        '
        Me.btnImport.Location = New System.Drawing.Point(22, 82)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(140, 31)
        Me.btnImport.TabIndex = 10
        Me.btnImport.Text = "Import"
        Me.btnImport.UseVisualStyleBackColor = True
        '
        'cboSourceType
        '
        Me.cboSourceType.FormattingEnabled = True
        Me.cboSourceType.Location = New System.Drawing.Point(151, 40)
        Me.cboSourceType.Name = "cboSourceType"
        Me.cboSourceType.Size = New System.Drawing.Size(121, 21)
        Me.cboSourceType.TabIndex = 9
        Me.cboSourceType.Visible = False
        '
        'cboProvider
        '
        Me.cboProvider.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.cboProvider.FormattingEnabled = True
        Me.cboProvider.Items.AddRange(New Object() {"Complete Genomics"})
        Me.cboProvider.Location = New System.Drawing.Point(19, 40)
        Me.cboProvider.Name = "cboProvider"
        Me.cboProvider.Size = New System.Drawing.Size(121, 21)
        Me.cboProvider.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "0. Select data source and type"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(192, 82)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "testing"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmImport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 124)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnImport)
        Me.Controls.Add(Me.cboSourceType)
        Me.Controls.Add(Me.cboProvider)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmImport"
        Me.ShowIcon = False
        Me.Text = "Import"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnImport As System.Windows.Forms.Button
    Friend WithEvents cboSourceType As System.Windows.Forms.ComboBox
    Friend WithEvents cboProvider As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
