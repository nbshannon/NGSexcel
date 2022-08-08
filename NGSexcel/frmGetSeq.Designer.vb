<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGetSeq
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
        Me.cboChr = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtChrStart = New System.Windows.Forms.TextBox()
        Me.txtChrEnd = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnGetSeq = New System.Windows.Forms.Button()
        Me.chkEnclose = New System.Windows.Forms.CheckBox()
        Me.chkFasta = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtExtend = New System.Windows.Forms.TextBox()
        Me.chkReverse = New System.Windows.Forms.CheckBox()
        Me.chkForceDirection = New System.Windows.Forms.CheckBox()
        Me.cboSource = New System.Windows.Forms.ComboBox()
        Me.cboBuildVer = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'cboChr
        '
        Me.cboChr.FormattingEnabled = True
        Me.cboChr.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "X", "Y"})
        Me.cboChr.Location = New System.Drawing.Point(47, 6)
        Me.cboChr.Name = "cboChr"
        Me.cboChr.Size = New System.Drawing.Size(100, 21)
        Me.cboChr.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Chr: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Start:"
        '
        'txtChrStart
        '
        Me.txtChrStart.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtChrStart.Location = New System.Drawing.Point(47, 36)
        Me.txtChrStart.Name = "txtChrStart"
        Me.txtChrStart.Size = New System.Drawing.Size(100, 20)
        Me.txtChrStart.TabIndex = 3
        '
        'txtChrEnd
        '
        Me.txtChrEnd.Location = New System.Drawing.Point(47, 64)
        Me.txtChrEnd.Name = "txtChrEnd"
        Me.txtChrEnd.Size = New System.Drawing.Size(100, 20)
        Me.txtChrEnd.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "End:"
        '
        'btnGetSeq
        '
        Me.btnGetSeq.Location = New System.Drawing.Point(156, 105)
        Me.btnGetSeq.Name = "btnGetSeq"
        Me.btnGetSeq.Size = New System.Drawing.Size(75, 23)
        Me.btnGetSeq.TabIndex = 6
        Me.btnGetSeq.Text = "Get Seq"
        Me.btnGetSeq.UseVisualStyleBackColor = True
        '
        'chkEnclose
        '
        Me.chkEnclose.AutoSize = True
        Me.chkEnclose.Location = New System.Drawing.Point(156, 32)
        Me.chkEnclose.Name = "chkEnclose"
        Me.chkEnclose.Size = New System.Drawing.Size(84, 17)
        Me.chkEnclose.TabIndex = 7
        Me.chkEnclose.Text = "Enclose in []"
        Me.chkEnclose.UseVisualStyleBackColor = True
        '
        'chkFasta
        '
        Me.chkFasta.AutoSize = True
        Me.chkFasta.Location = New System.Drawing.Point(156, 55)
        Me.chkFasta.Name = "chkFasta"
        Me.chkFasta.Size = New System.Drawing.Size(84, 17)
        Me.chkFasta.TabIndex = 8
        Me.chkFasta.Text = "Fasta format"
        Me.chkFasta.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(153, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Extend by:"
        '
        'txtExtend
        '
        Me.txtExtend.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtExtend.Location = New System.Drawing.Point(216, 6)
        Me.txtExtend.Name = "txtExtend"
        Me.txtExtend.Size = New System.Drawing.Size(43, 20)
        Me.txtExtend.TabIndex = 10
        Me.txtExtend.Text = "0"
        '
        'chkReverse
        '
        Me.chkReverse.AutoSize = True
        Me.chkReverse.Location = New System.Drawing.Point(12, 90)
        Me.chkReverse.Name = "chkReverse"
        Me.chkReverse.Size = New System.Drawing.Size(100, 17)
        Me.chkReverse.TabIndex = 11
        Me.chkReverse.Text = "Reverse Strand"
        Me.chkReverse.UseVisualStyleBackColor = True
        '
        'chkForceDirection
        '
        Me.chkForceDirection.AutoSize = True
        Me.chkForceDirection.Location = New System.Drawing.Point(12, 113)
        Me.chkForceDirection.Name = "chkForceDirection"
        Me.chkForceDirection.Size = New System.Drawing.Size(85, 17)
        Me.chkForceDirection.TabIndex = 12
        Me.chkForceDirection.Text = "Keep 5' to 3'"
        Me.chkForceDirection.UseVisualStyleBackColor = True
        '
        'cboSource
        '
        Me.cboSource.FormattingEnabled = True
        Me.cboSource.Items.AddRange(New Object() {"ensembl", "UCSC"})
        Me.cboSource.Location = New System.Drawing.Point(156, 78)
        Me.cboSource.Name = "cboSource"
        Me.cboSource.Size = New System.Drawing.Size(84, 21)
        Me.cboSource.TabIndex = 13
        '
        'cboBuildVer
        '
        Me.cboBuildVer.FormattingEnabled = True
        Me.cboBuildVer.Items.AddRange(New Object() {"hg19", "hg18", "hg17", "hg16"})
        Me.cboBuildVer.Location = New System.Drawing.Point(247, 78)
        Me.cboBuildVer.Name = "cboBuildVer"
        Me.cboBuildVer.Size = New System.Drawing.Size(53, 21)
        Me.cboBuildVer.TabIndex = 14
        '
        'frmGetSeq
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(312, 142)
        Me.Controls.Add(Me.cboBuildVer)
        Me.Controls.Add(Me.cboSource)
        Me.Controls.Add(Me.chkForceDirection)
        Me.Controls.Add(Me.chkReverse)
        Me.Controls.Add(Me.txtExtend)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.chkFasta)
        Me.Controls.Add(Me.chkEnclose)
        Me.Controls.Add(Me.btnGetSeq)
        Me.Controls.Add(Me.txtChrEnd)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtChrStart)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboChr)
        Me.Name = "frmGetSeq"
        Me.ShowIcon = False
        Me.Text = "Get Single Sequence"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboChr As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtChrStart As System.Windows.Forms.TextBox
    Friend WithEvents txtChrEnd As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnGetSeq As System.Windows.Forms.Button
    Friend WithEvents chkEnclose As System.Windows.Forms.CheckBox
    Friend WithEvents chkFasta As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtExtend As System.Windows.Forms.TextBox
    Friend WithEvents chkReverse As System.Windows.Forms.CheckBox
    Friend WithEvents chkForceDirection As System.Windows.Forms.CheckBox
    Friend WithEvents cboSource As System.Windows.Forms.ComboBox
    Friend WithEvents cboBuildVer As System.Windows.Forms.ComboBox
End Class
