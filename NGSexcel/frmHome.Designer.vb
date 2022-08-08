<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHome
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
        Me.brnBrowser = New System.Windows.Forms.Button()
        Me.btnSplit = New System.Windows.Forms.Button()
        Me.btnMisc = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'brnBrowser
        '
        Me.brnBrowser.Location = New System.Drawing.Point(12, 136)
        Me.brnBrowser.Name = "brnBrowser"
        Me.brnBrowser.Size = New System.Drawing.Size(91, 30)
        Me.brnBrowser.TabIndex = 3
        Me.brnBrowser.Text = "Link to Browser"
        Me.brnBrowser.UseVisualStyleBackColor = True
        '
        'btnSplit
        '
        Me.btnSplit.Location = New System.Drawing.Point(12, 103)
        Me.btnSplit.Name = "btnSplit"
        Me.btnSplit.Size = New System.Drawing.Size(91, 27)
        Me.btnSplit.TabIndex = 2
        Me.btnSplit.Text = "Split"
        Me.btnSplit.UseVisualStyleBackColor = True
        '
        'btnMisc
        '
        Me.btnMisc.Location = New System.Drawing.Point(12, 172)
        Me.btnMisc.Name = "btnMisc"
        Me.btnMisc.Size = New System.Drawing.Size(91, 29)
        Me.btnMisc.TabIndex = 5
        Me.btnMisc.Text = "Misc Tools"
        Me.btnMisc.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.NGSexcel.My.Resources.Resources.ngs_ex
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Image = Global.NGSexcel.My.Resources.Resources.ngs_ex
        Me.PictureBox1.Location = New System.Drawing.Point(1, -3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(257, 223)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'frmHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(256, 221)
        Me.Controls.Add(Me.btnMisc)
        Me.Controls.Add(Me.brnBrowser)
        Me.Controls.Add(Me.btnSplit)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmHome"
        Me.ShowIcon = False
        Me.Text = "NGSxl Home"
        Me.TopMost = True
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents brnBrowser As System.Windows.Forms.Button
    Friend WithEvents btnSplit As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnMisc As System.Windows.Forms.Button
End Class
