<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCGenomics
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
        Me.clbZygosity = New System.Windows.Forms.CheckedListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.clbVarType = New System.Windows.Forms.CheckedListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.clbAllele1Q = New System.Windows.Forms.CheckedListBox()
        Me.clbAllele2Q = New System.Windows.Forms.CheckedListBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnImport = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboSplit = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'clbZygosity
        '
        Me.clbZygosity.CheckOnClick = True
        Me.clbZygosity.FormattingEnabled = True
        Me.clbZygosity.Items.AddRange(New Object() {"No-call", "hom", "het-ref", "het-alt", "half"})
        Me.clbZygosity.Location = New System.Drawing.Point(12, 60)
        Me.clbZygosity.Name = "clbZygosity"
        Me.clbZygosity.Size = New System.Drawing.Size(76, 79)
        Me.clbZygosity.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "1. Filter data to include"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "a) Zygosity"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(117, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "b) VarType"
        '
        'clbVarType
        '
        Me.clbVarType.CheckOnClick = True
        Me.clbVarType.FormattingEnabled = True
        Me.clbVarType.Items.AddRange(New Object() {"complex", "del", "ins", "no-ref", "ref", "snp", "sub"})
        Me.clbVarType.Location = New System.Drawing.Point(120, 60)
        Me.clbVarType.Name = "clbVarType"
        Me.clbVarType.Size = New System.Drawing.Size(76, 109)
        Me.clbVarType.Sorted = True
        Me.clbVarType.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(226, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "c) Allele1 Quality"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(226, 108)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "d) Allele2 Quality"
        '
        'clbAllele1Q
        '
        Me.clbAllele1Q.CheckOnClick = True
        Me.clbAllele1Q.FormattingEnabled = True
        Me.clbAllele1Q.Items.AddRange(New Object() {"VQHIGH", "VQLOW", ""})
        Me.clbAllele1Q.Location = New System.Drawing.Point(248, 47)
        Me.clbAllele1Q.Name = "clbAllele1Q"
        Me.clbAllele1Q.Size = New System.Drawing.Size(76, 49)
        Me.clbAllele1Q.TabIndex = 7
        '
        'clbAllele2Q
        '
        Me.clbAllele2Q.CheckOnClick = True
        Me.clbAllele2Q.FormattingEnabled = True
        Me.clbAllele2Q.Items.AddRange(New Object() {"VQHIGH", "VQLOW", ""})
        Me.clbAllele2Q.Location = New System.Drawing.Point(248, 129)
        Me.clbAllele2Q.Name = "clbAllele2Q"
        Me.clbAllele2Q.Size = New System.Drawing.Size(76, 49)
        Me.clbAllele2Q.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 256)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "3. Click import"
        '
        'btnImport
        '
        Me.btnImport.Location = New System.Drawing.Point(15, 283)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(111, 21)
        Me.btnImport.TabIndex = 10
        Me.btnImport.Text = "Import"
        Me.btnImport.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 191)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(130, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "2. Optional, split sheets by"
        '
        'cboSplit
        '
        Me.cboSplit.DisplayMember = "name"
        Me.cboSplit.FormattingEnabled = True
        Me.cboSplit.Items.AddRange(New Object() {"varType"})
        Me.cboSplit.Location = New System.Drawing.Point(15, 220)
        Me.cboSplit.Name = "cboSplit"
        Me.cboSplit.Size = New System.Drawing.Size(121, 21)
        Me.cboSplit.TabIndex = 12
        Me.cboSplit.ValueMember = "column"
        '
        'frmCGenomics
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(342, 325)
        Me.Controls.Add(Me.cboSplit)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnImport)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.clbAllele2Q)
        Me.Controls.Add(Me.clbAllele1Q)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.clbVarType)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.clbZygosity)
        Me.Name = "frmCGenomics"
        Me.ShowIcon = False
        Me.Text = "Complete Genomics"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents clbZygosity As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents clbVarType As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents clbAllele1Q As System.Windows.Forms.CheckedListBox
    Friend WithEvents clbAllele2Q As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnImport As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cboSplit As System.Windows.Forms.ComboBox
End Class
