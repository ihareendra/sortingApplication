<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container
        Me.btnOpenFile = New System.Windows.Forms.Button
        Me.tbResults = New System.Windows.Forms.RichTextBox
        Me.btnSort = New System.Windows.Forms.Button
        Me.btnSaveAs = New System.Windows.Forms.Button
        Me.btnClear = New System.Windows.Forms.Button
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnQuickSave = New System.Windows.Forms.Button
        Me.cbQuickSave = New System.Windows.Forms.CheckBox
        Me.txtFileName = New System.Windows.Forms.TextBox
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnOpenFile
        '
        Me.btnOpenFile.Location = New System.Drawing.Point(26, 21)
        Me.btnOpenFile.Name = "btnOpenFile"
        Me.btnOpenFile.Size = New System.Drawing.Size(75, 38)
        Me.btnOpenFile.TabIndex = 0
        Me.btnOpenFile.Text = "Open File"
        Me.ToolTip1.SetToolTip(Me.btnOpenFile, "Click here to open a file")
        Me.btnOpenFile.UseVisualStyleBackColor = True
        '
        'tbResults
        '
        Me.tbResults.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.tbResults.Enabled = False
        Me.tbResults.Location = New System.Drawing.Point(26, 62)
        Me.tbResults.Name = "tbResults"
        Me.tbResults.Size = New System.Drawing.Size(300, 275)
        Me.tbResults.TabIndex = 1
        Me.tbResults.Text = ""
        '
        'btnSort
        '
        Me.btnSort.Location = New System.Drawing.Point(26, 65)
        Me.btnSort.Name = "btnSort"
        Me.btnSort.Size = New System.Drawing.Size(75, 38)
        Me.btnSort.TabIndex = 2
        Me.btnSort.Text = "Sort"
        Me.ToolTip1.SetToolTip(Me.btnSort, "Click to sort")
        Me.btnSort.UseVisualStyleBackColor = True
        '
        'btnSaveAs
        '
        Me.btnSaveAs.Location = New System.Drawing.Point(26, 108)
        Me.btnSaveAs.Name = "btnSaveAs"
        Me.btnSaveAs.Size = New System.Drawing.Size(75, 38)
        Me.btnSaveAs.TabIndex = 3
        Me.btnSaveAs.Text = "Save File As"
        Me.ToolTip1.SetToolTip(Me.btnSaveAs, "Click to Save your file As")
        Me.btnSaveAs.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(26, 255)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 38)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Clear Text"
        Me.ToolTip1.SetToolTip(Me.btnClear, "Click to clear all text")
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(475, 24)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.btnQuickSave)
        Me.Panel1.Controls.Add(Me.cbQuickSave)
        Me.Panel1.Controls.Add(Me.btnClear)
        Me.Panel1.Controls.Add(Me.btnSaveAs)
        Me.Panel1.Controls.Add(Me.btnOpenFile)
        Me.Panel1.Controls.Add(Me.btnSort)
        Me.Panel1.Location = New System.Drawing.Point(332, 36)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(131, 301)
        Me.Panel1.TabIndex = 6
        '
        'btnQuickSave
        '
        Me.btnQuickSave.Enabled = False
        Me.btnQuickSave.Location = New System.Drawing.Point(26, 199)
        Me.btnQuickSave.Name = "btnQuickSave"
        Me.btnQuickSave.Size = New System.Drawing.Size(75, 38)
        Me.btnQuickSave.TabIndex = 6
        Me.btnQuickSave.Text = "Quick Save"
        Me.ToolTip1.SetToolTip(Me.btnQuickSave, "Quickly save your file in to your original location")
        Me.btnQuickSave.UseVisualStyleBackColor = True
        '
        'cbQuickSave
        '
        Me.cbQuickSave.AutoSize = True
        Me.cbQuickSave.Location = New System.Drawing.Point(24, 176)
        Me.cbQuickSave.Name = "cbQuickSave"
        Me.cbQuickSave.Size = New System.Drawing.Size(82, 17)
        Me.cbQuickSave.TabIndex = 5
        Me.cbQuickSave.Text = "Quick Save"
        Me.ToolTip1.SetToolTip(Me.cbQuickSave, "Click to enable or Disable quick save button")
        Me.cbQuickSave.UseVisualStyleBackColor = True
        '
        'txtFileName
        '
        Me.txtFileName.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.txtFileName.Enabled = False
        Me.txtFileName.Location = New System.Drawing.Point(26, 36)
        Me.txtFileName.Name = "txtFileName"
        Me.txtFileName.Size = New System.Drawing.Size(300, 20)
        Me.txtFileName.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(475, 342)
        Me.Controls.Add(Me.txtFileName)
        Me.Controls.Add(Me.tbResults)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sorting Application"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnOpenFile As System.Windows.Forms.Button
    Friend WithEvents tbResults As System.Windows.Forms.RichTextBox
    Friend WithEvents btnSort As System.Windows.Forms.Button
    Friend WithEvents btnSaveAs As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnQuickSave As System.Windows.Forms.Button
    Friend WithEvents cbQuickSave As System.Windows.Forms.CheckBox
    Friend WithEvents txtFileName As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip

End Class
