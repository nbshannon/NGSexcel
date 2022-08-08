<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMisc
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
        Me.btnGetSeq = New System.Windows.Forms.Button()
        Me.btnAddCoords = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnLinks = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnBLAT = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnGetSeq
        '
        Me.btnGetSeq.Location = New System.Drawing.Point(6, 19)
        Me.btnGetSeq.Name = "btnGetSeq"
        Me.btnGetSeq.Size = New System.Drawing.Size(117, 23)
        Me.btnGetSeq.TabIndex = 0
        Me.btnGetSeq.Text = "Get Sequence"
        Me.btnGetSeq.UseVisualStyleBackColor = True
        '
        'btnAddCoords
        '
        Me.btnAddCoords.Location = New System.Drawing.Point(8, 17)
        Me.btnAddCoords.Name = "btnAddCoords"
        Me.btnAddCoords.Size = New System.Drawing.Size(115, 23)
        Me.btnAddCoords.TabIndex = 1
        Me.btnAddCoords.Text = "Add genomic coords"
        Me.btnAddCoords.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(8, 46)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(115, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Get Sequences"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.btnAddCoords)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 91)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(135, 75)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Batch tools"
        '
        'btnLinks
        '
        Me.btnLinks.Location = New System.Drawing.Point(6, 48)
        Me.btnLinks.Name = "btnLinks"
        Me.btnLinks.Size = New System.Drawing.Size(117, 23)
        Me.btnLinks.TabIndex = 4
        Me.btnLinks.Text = "Links"
        Me.btnLinks.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnGetSeq)
        Me.GroupBox2.Controls.Add(Me.btnLinks)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(129, 73)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Misc tools"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnBLAT)
        Me.GroupBox3.Location = New System.Drawing.Point(153, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(129, 81)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Misc tools"
        '
        'btnBLAT
        '
        Me.btnBLAT.Location = New System.Drawing.Point(6, 19)
        Me.btnBLAT.Name = "btnBLAT"
        Me.btnBLAT.Size = New System.Drawing.Size(117, 23)
        Me.btnBLAT.TabIndex = 0
        Me.btnBLAT.Text = "BLAT"
        Me.btnBLAT.UseVisualStyleBackColor = True
        '
        'frmMisc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(294, 172)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmMisc"
        Me.ShowIcon = False
        Me.Text = "Misc tools"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnGetSeq As System.Windows.Forms.Button
    Friend WithEvents btnAddCoords As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnLinks As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnBLAT As System.Windows.Forms.Button
End Class
