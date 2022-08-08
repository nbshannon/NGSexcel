<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSplit
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
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Splits")
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Filters")
        Me.btnSplit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFolderName = New System.Windows.Forms.TextBox()
        Me.cboSourceType = New System.Windows.Forms.ComboBox()
        Me.cboProvider = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.numHeader = New System.Windows.Forms.NumericUpDown()
        Me.LblHeaderDelim = New System.Windows.Forms.Label()
        Me.txtFileName = New System.Windows.Forms.TextBox()
        Me.cboDelim = New System.Windows.Forms.ComboBox()
        Me.txtDelim = New System.Windows.Forms.TextBox()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.lblDelim = New System.Windows.Forms.Label()
        Me.lblOptions = New System.Windows.Forms.Label()
        Me.btnAddSplit = New System.Windows.Forms.Button()
        Me.btnAddFilter = New System.Windows.Forms.Button()
        Me.treeOptions = New System.Windows.Forms.TreeView()
        Me.TxtOutFileName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.numHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSplit
        '
        Me.btnSplit.Location = New System.Drawing.Point(15, 296)
        Me.btnSplit.Name = "btnSplit"
        Me.btnSplit.Size = New System.Drawing.Size(104, 31)
        Me.btnSplit.TabIndex = 12
        Me.btnSplit.Text = "Split"
        Me.btnSplit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "0. Input split folder name:"
        '
        'txtFolderName
        '
        Me.txtFolderName.Location = New System.Drawing.Point(151, 6)
        Me.txtFolderName.Name = "txtFolderName"
        Me.txtFolderName.Size = New System.Drawing.Size(100, 20)
        Me.txtFolderName.TabIndex = 13
        Me.txtFolderName.Text = "split"
        '
        'cboSourceType
        '
        Me.cboSourceType.FormattingEnabled = True
        Me.cboSourceType.Location = New System.Drawing.Point(151, 79)
        Me.cboSourceType.Name = "cboSourceType"
        Me.cboSourceType.Size = New System.Drawing.Size(100, 21)
        Me.cboSourceType.TabIndex = 16
        Me.cboSourceType.Visible = False
        '
        'cboProvider
        '
        Me.cboProvider.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.cboProvider.FormattingEnabled = True
        Me.cboProvider.Items.AddRange(New Object() {"Complete Genomics"})
        Me.cboProvider.Location = New System.Drawing.Point(20, 79)
        Me.cboProvider.Name = "cboProvider"
        Me.cboProvider.Size = New System.Drawing.Size(121, 21)
        Me.cboProvider.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(221, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "(optional) Select known data source and type"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "1. Select file"
        '
        'numHeader
        '
        Me.numHeader.Location = New System.Drawing.Point(65, 184)
        Me.numHeader.Name = "numHeader"
        Me.numHeader.Size = New System.Drawing.Size(42, 20)
        Me.numHeader.TabIndex = 18
        '
        'LblHeaderDelim
        '
        Me.LblHeaderDelim.AutoSize = True
        Me.LblHeaderDelim.Location = New System.Drawing.Point(12, 160)
        Me.LblHeaderDelim.Name = "LblHeaderDelim"
        Me.LblHeaderDelim.Size = New System.Drawing.Size(210, 13)
        Me.LblHeaderDelim.TabIndex = 20
        Me.LblHeaderDelim.Text = "2. Select header row and column separator"
        Me.LblHeaderDelim.Visible = False
        '
        'txtFileName
        '
        Me.txtFileName.Location = New System.Drawing.Point(20, 128)
        Me.txtFileName.Name = "txtFileName"
        Me.txtFileName.Size = New System.Drawing.Size(231, 20)
        Me.txtFileName.TabIndex = 21
        '
        'cboDelim
        '
        Me.cboDelim.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.cboDelim.FormattingEnabled = True
        Me.cboDelim.Items.AddRange(New Object() {"tab", "comma", "other"})
        Me.cboDelim.Location = New System.Drawing.Point(157, 184)
        Me.cboDelim.Name = "cboDelim"
        Me.cboDelim.Size = New System.Drawing.Size(45, 21)
        Me.cboDelim.TabIndex = 22
        '
        'txtDelim
        '
        Me.txtDelim.Location = New System.Drawing.Point(212, 184)
        Me.txtDelim.Name = "txtDelim"
        Me.txtDelim.Size = New System.Drawing.Size(39, 20)
        Me.txtDelim.TabIndex = 23
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Location = New System.Drawing.Point(14, 186)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(45, 13)
        Me.lblHeader.TabIndex = 24
        Me.lblHeader.Text = "Header:"
        '
        'lblDelim
        '
        Me.lblDelim.AutoSize = True
        Me.lblDelim.Location = New System.Drawing.Point(113, 186)
        Me.lblDelim.Name = "lblDelim"
        Me.lblDelim.Size = New System.Drawing.Size(36, 13)
        Me.lblDelim.TabIndex = 25
        Me.lblDelim.Text = "Delim:"
        '
        'lblOptions
        '
        Me.lblOptions.AutoSize = True
        Me.lblOptions.Location = New System.Drawing.Point(14, 217)
        Me.lblOptions.Name = "lblOptions"
        Me.lblOptions.Size = New System.Drawing.Size(105, 13)
        Me.lblOptions.TabIndex = 26
        Me.lblOptions.Text = "3. Add optional filters"
        '
        'btnAddSplit
        '
        Me.btnAddSplit.Location = New System.Drawing.Point(20, 234)
        Me.btnAddSplit.Name = "btnAddSplit"
        Me.btnAddSplit.Size = New System.Drawing.Size(57, 23)
        Me.btnAddSplit.TabIndex = 27
        Me.btnAddSplit.Text = "+ split"
        Me.btnAddSplit.UseVisualStyleBackColor = True
        '
        'btnAddFilter
        '
        Me.btnAddFilter.Location = New System.Drawing.Point(20, 263)
        Me.btnAddFilter.Name = "btnAddFilter"
        Me.btnAddFilter.Size = New System.Drawing.Size(57, 23)
        Me.btnAddFilter.TabIndex = 28
        Me.btnAddFilter.Text = "+ filter"
        Me.btnAddFilter.UseVisualStyleBackColor = True
        '
        'treeOptions
        '
        Me.treeOptions.Location = New System.Drawing.Point(130, 217)
        Me.treeOptions.Name = "treeOptions"
        TreeNode7.Name = "splits"
        TreeNode7.Text = "Splits"
        TreeNode8.Name = "filters"
        TreeNode8.Text = "Filters"
        Me.treeOptions.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode7, TreeNode8})
        Me.treeOptions.Size = New System.Drawing.Size(121, 110)
        Me.treeOptions.TabIndex = 29
        '
        'TxtOutFileName
        '
        Me.TxtOutFileName.Location = New System.Drawing.Point(151, 29)
        Me.TxtOutFileName.Name = "TxtOutFileName"
        Me.TxtOutFileName.Size = New System.Drawing.Size(100, 20)
        Me.TxtOutFileName.TabIndex = 31
        Me.TxtOutFileName.Text = "split_"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(43, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 13)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "and split file name:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'frmSplit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(268, 342)
        Me.Controls.Add(Me.TxtOutFileName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.treeOptions)
        Me.Controls.Add(Me.btnAddFilter)
        Me.Controls.Add(Me.btnAddSplit)
        Me.Controls.Add(Me.lblOptions)
        Me.Controls.Add(Me.lblDelim)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.txtDelim)
        Me.Controls.Add(Me.cboDelim)
        Me.Controls.Add(Me.txtFileName)
        Me.Controls.Add(Me.LblHeaderDelim)
        Me.Controls.Add(Me.numHeader)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboSourceType)
        Me.Controls.Add(Me.cboProvider)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtFolderName)
        Me.Controls.Add(Me.btnSplit)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmSplit"
        Me.ShowIcon = False
        Me.Text = "Split big file"
        Me.TopMost = True
        CType(Me.numHeader, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSplit As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtFolderName As System.Windows.Forms.TextBox
    Friend WithEvents cboSourceType As System.Windows.Forms.ComboBox
    Friend WithEvents cboProvider As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents numHeader As System.Windows.Forms.NumericUpDown
    Friend WithEvents LblHeaderDelim As System.Windows.Forms.Label
    Friend WithEvents txtFileName As System.Windows.Forms.TextBox
    Friend WithEvents cboDelim As System.Windows.Forms.ComboBox
    Friend WithEvents txtDelim As System.Windows.Forms.TextBox
    Friend WithEvents lblHeader As System.Windows.Forms.Label
    Friend WithEvents lblDelim As System.Windows.Forms.Label
    Friend WithEvents lblOptions As System.Windows.Forms.Label
    Friend WithEvents btnAddSplit As System.Windows.Forms.Button
    Friend WithEvents btnAddFilter As System.Windows.Forms.Button
    Friend WithEvents treeOptions As System.Windows.Forms.TreeView
    Friend WithEvents TxtOutFileName As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
