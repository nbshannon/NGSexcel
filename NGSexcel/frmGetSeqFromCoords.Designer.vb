<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGetSeqFromCoords
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnGetSeqs = New System.Windows.Forms.Button()
        Me.ProgressBar = New System.Windows.Forms.ProgressBar()
        Me.txtExtend = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.chkFasta = New System.Windows.Forms.CheckBox()
        Me.chkEnclose = New System.Windows.Forms.CheckBox()
        Me.chkUseStrand = New System.Windows.Forms.CheckBox()
        Me.cboBuildVer = New System.Windows.Forms.ComboBox()
        Me.cboSource = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(203, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "0. Select cells containing genomic coords"
        '
        'btnGetSeqs
        '
        Me.btnGetSeqs.Location = New System.Drawing.Point(46, 82)
        Me.btnGetSeqs.Name = "btnGetSeqs"
        Me.btnGetSeqs.Size = New System.Drawing.Size(119, 23)
        Me.btnGetSeqs.TabIndex = 2
        Me.btnGetSeqs.Text = "Get Sequences"
        Me.btnGetSeqs.UseVisualStyleBackColor = True
        '
        'ProgressBar
        '
        Me.ProgressBar.Location = New System.Drawing.Point(12, 47)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(200, 23)
        Me.ProgressBar.TabIndex = 3
        '
        'txtExtend
        '
        Me.txtExtend.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtExtend.Location = New System.Drawing.Point(301, 29)
        Me.txtExtend.Name = "txtExtend"
        Me.txtExtend.Size = New System.Drawing.Size(43, 20)
        Me.txtExtend.TabIndex = 14
        Me.txtExtend.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(238, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Extend by:"
        '
        'chkFasta
        '
        Me.chkFasta.AutoSize = True
        Me.chkFasta.Location = New System.Drawing.Point(241, 76)
        Me.chkFasta.Name = "chkFasta"
        Me.chkFasta.Size = New System.Drawing.Size(84, 17)
        Me.chkFasta.TabIndex = 12
        Me.chkFasta.Text = "Fasta format"
        Me.chkFasta.UseVisualStyleBackColor = True
        '
        'chkEnclose
        '
        Me.chkEnclose.AutoSize = True
        Me.chkEnclose.Location = New System.Drawing.Point(241, 53)
        Me.chkEnclose.Name = "chkEnclose"
        Me.chkEnclose.Size = New System.Drawing.Size(84, 17)
        Me.chkEnclose.TabIndex = 11
        Me.chkEnclose.Text = "Enclose in []"
        Me.chkEnclose.UseVisualStyleBackColor = True
        '
        'chkUseStrand
        '
        Me.chkUseStrand.AutoSize = True
        Me.chkUseStrand.Location = New System.Drawing.Point(241, 9)
        Me.chkUseStrand.Name = "chkUseStrand"
        Me.chkUseStrand.Size = New System.Drawing.Size(77, 17)
        Me.chkUseStrand.TabIndex = 15
        Me.chkUseStrand.Text = "Use strand"
        Me.chkUseStrand.UseVisualStyleBackColor = True
        '
        'cboBuildVer
        '
        Me.cboBuildVer.FormattingEnabled = True
        Me.cboBuildVer.Items.AddRange(New Object() {"hg19", "hg18", "hg17", "hg16"})
        Me.cboBuildVer.Location = New System.Drawing.Point(314, 98)
        Me.cboBuildVer.Name = "cboBuildVer"
        Me.cboBuildVer.Size = New System.Drawing.Size(53, 21)
        Me.cboBuildVer.TabIndex = 17
        '
        'cboSource
        '
        Me.cboSource.FormattingEnabled = True
        Me.cboSource.Items.AddRange(New Object() {"ensembl", "UCSC"})
        Me.cboSource.Location = New System.Drawing.Point(223, 98)
        Me.cboSource.Name = "cboSource"
        Me.cboSource.Size = New System.Drawing.Size(84, 21)
        Me.cboSource.TabIndex = 16
        '
        'frmGetSeqFromCoords
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(379, 131)
        Me.Controls.Add(Me.cboBuildVer)
        Me.Controls.Add(Me.cboSource)
        Me.Controls.Add(Me.chkUseStrand)
        Me.Controls.Add(Me.txtExtend)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.chkFasta)
        Me.Controls.Add(Me.chkEnclose)
        Me.Controls.Add(Me.ProgressBar)
        Me.Controls.Add(Me.btnGetSeqs)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmGetSeqFromCoords"
        Me.ShowIcon = False
        Me.Text = "y"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnGetSeqs As System.Windows.Forms.Button
    Friend WithEvents ProgressBar As System.Windows.Forms.ProgressBar
    Friend WithEvents txtExtend As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents chkFasta As System.Windows.Forms.CheckBox
    Friend WithEvents chkEnclose As System.Windows.Forms.CheckBox
    Friend WithEvents chkUseStrand As System.Windows.Forms.CheckBox
    Friend WithEvents cboBuildVer As System.Windows.Forms.ComboBox
    Friend WithEvents cboSource As System.Windows.Forms.ComboBox
End Class
