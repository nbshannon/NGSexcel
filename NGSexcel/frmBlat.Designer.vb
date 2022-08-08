<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBlat
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboAssembly = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboQuery = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboSort = New System.Windows.Forms.ComboBox()
        Me.btnBLAT = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Assembly"
        '
        'cboAssembly
        '
        Me.cboAssembly.FormattingEnabled = True
        Me.cboAssembly.Items.AddRange(New Object() {"hg19", "hg18", "hg17", "hg16"})
        Me.cboAssembly.Location = New System.Drawing.Point(69, 12)
        Me.cboAssembly.Name = "cboAssembly"
        Me.cboAssembly.Size = New System.Drawing.Size(121, 21)
        Me.cboAssembly.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Query type"
        '
        'cboQuery
        '
        Me.cboQuery.FormattingEnabled = True
        Me.cboQuery.Items.AddRange(New Object() {"BlatGUESS", "DNA", "RNA", "protein", "transDNA", "transRNA"})
        Me.cboQuery.Location = New System.Drawing.Point(69, 39)
        Me.cboQuery.Name = "cboQuery"
        Me.cboQuery.Size = New System.Drawing.Size(121, 21)
        Me.cboQuery.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Sort output"
        '
        'cboSort
        '
        Me.cboSort.FormattingEnabled = True
        Me.cboSort.Items.AddRange(New Object() {"chrom,start", "chrom,score", "query,score", "query,start", "score"})
        Me.cboSort.Location = New System.Drawing.Point(69, 66)
        Me.cboSort.Name = "cboSort"
        Me.cboSort.Size = New System.Drawing.Size(121, 21)
        Me.cboSort.TabIndex = 6
        '
        'btnBLAT
        '
        Me.btnBLAT.Location = New System.Drawing.Point(69, 95)
        Me.btnBLAT.Name = "btnBLAT"
        Me.btnBLAT.Size = New System.Drawing.Size(75, 23)
        Me.btnBLAT.TabIndex = 8
        Me.btnBLAT.Text = "BLAT"
        Me.btnBLAT.UseVisualStyleBackColor = True
        '
        'frmBlat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(206, 130)
        Me.Controls.Add(Me.btnBLAT)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboSort)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboQuery)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboAssembly)
        Me.Name = "frmBlat"
        Me.Text = "frmBlat"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboAssembly As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboQuery As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboSort As System.Windows.Forms.ComboBox
    Friend WithEvents btnBLAT As System.Windows.Forms.Button
End Class
