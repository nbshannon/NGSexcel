<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFilterOpt
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
        Me.cboSplit = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboFilterType = New System.Windows.Forms.ComboBox()
        Me.txtCriteria = New System.Windows.Forms.TextBox()
        Me.lblCriteria = New System.Windows.Forms.Label()
        Me.lblStart = New System.Windows.Forms.Label()
        Me.lblEnd = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtStart = New System.Windows.Forms.TextBox()
        Me.txtEnd = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Column to filter on"
        '
        'cboSplit
        '
        Me.cboSplit.FormattingEnabled = True
        Me.cboSplit.Location = New System.Drawing.Point(12, 24)
        Me.cboSplit.Name = "cboSplit"
        Me.cboSplit.Size = New System.Drawing.Size(121, 21)
        Me.cboSplit.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Filter Type"
        '
        'cboFilterType
        '
        Me.cboFilterType.FormattingEnabled = True
        Me.cboFilterType.Items.AddRange(New Object() {"text_inclusion", "text_exclusion", "range_inclusion (exclusive)", "range_exclusion (exclusive)"})
        Me.cboFilterType.Location = New System.Drawing.Point(12, 83)
        Me.cboFilterType.Name = "cboFilterType"
        Me.cboFilterType.Size = New System.Drawing.Size(121, 21)
        Me.cboFilterType.TabIndex = 3
        '
        'txtCriteria
        '
        Me.txtCriteria.Location = New System.Drawing.Point(12, 137)
        Me.txtCriteria.Multiline = True
        Me.txtCriteria.Name = "txtCriteria"
        Me.txtCriteria.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtCriteria.Size = New System.Drawing.Size(116, 113)
        Me.txtCriteria.TabIndex = 4
        '
        'lblCriteria
        '
        Me.lblCriteria.AutoSize = True
        Me.lblCriteria.Location = New System.Drawing.Point(6, 121)
        Me.lblCriteria.Name = "lblCriteria"
        Me.lblCriteria.Size = New System.Drawing.Size(64, 13)
        Me.lblCriteria.TabIndex = 5
        Me.lblCriteria.Text = "Filter Criteria"
        '
        'lblStart
        '
        Me.lblStart.AutoSize = True
        Me.lblStart.Location = New System.Drawing.Point(13, 140)
        Me.lblStart.Name = "lblStart"
        Me.lblStart.Size = New System.Drawing.Size(30, 13)
        Me.lblStart.TabIndex = 8
        Me.lblStart.Text = "start:"
        '
        'lblEnd
        '
        Me.lblEnd.AutoSize = True
        Me.lblEnd.Location = New System.Drawing.Point(13, 175)
        Me.lblEnd.Name = "lblEnd"
        Me.lblEnd.Size = New System.Drawing.Size(28, 13)
        Me.lblEnd.TabIndex = 9
        Me.lblEnd.Text = "end:"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(16, 267)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 10
        Me.btnAdd.Text = "Add filter"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtStart
        '
        Me.txtStart.Location = New System.Drawing.Point(49, 140)
        Me.txtStart.Name = "txtStart"
        Me.txtStart.Size = New System.Drawing.Size(84, 20)
        Me.txtStart.TabIndex = 11
        Me.txtStart.Text = "0"
        '
        'txtEnd
        '
        Me.txtEnd.Location = New System.Drawing.Point(49, 172)
        Me.txtEnd.Name = "txtEnd"
        Me.txtEnd.Size = New System.Drawing.Size(84, 20)
        Me.txtEnd.TabIndex = 12
        Me.txtEnd.Text = "0"
        '
        'frmFilterOpt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(140, 298)
        Me.Controls.Add(Me.txtEnd)
        Me.Controls.Add(Me.txtStart)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lblEnd)
        Me.Controls.Add(Me.lblStart)
        Me.Controls.Add(Me.lblCriteria)
        Me.Controls.Add(Me.txtCriteria)
        Me.Controls.Add(Me.cboFilterType)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboSplit)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmFilterOpt"
        Me.ShowIcon = False
        Me.Text = "Add Filter"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboSplit As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboFilterType As System.Windows.Forms.ComboBox
    Friend WithEvents txtCriteria As System.Windows.Forms.TextBox
    Friend WithEvents lblCriteria As System.Windows.Forms.Label
    Friend WithEvents lblStart As System.Windows.Forms.Label
    Friend WithEvents lblEnd As System.Windows.Forms.Label
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents txtStart As System.Windows.Forms.TextBox
    Friend WithEvents txtEnd As System.Windows.Forms.TextBox
End Class
