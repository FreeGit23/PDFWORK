<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWorkspace
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(frmWorkspace))
        SplitContainer1 = New SplitContainer()
        TableLayoutPanel1 = New TableLayoutPanel()
        ChkTimeStamp = New CheckBox()
        Label2 = New Label()
        Label1 = New Label()
        cmdOpenOut = New Button()
        CmdOpenIn = New Button()
        TxtOutput = New TextBox()
        TxtInput = New TextBox()
        chkSilent = New CheckBox()
        chkLog = New CheckBox()
        ToolStrip1 = New ToolStrip()
        ToolStripLabel1 = New ToolStripLabel()
        CmdSave = New ToolStripButton()
        cmdRun = New ToolStripButton()
        lstLog = New ListBox()
        FolderBrowserDialog1 = New FolderBrowserDialog()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer1.Panel1.SuspendLayout()
        SplitContainer1.Panel2.SuspendLayout()
        SplitContainer1.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        ToolStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' SplitContainer1
        ' 
        SplitContainer1.Dock = DockStyle.Fill
        SplitContainer1.Location = New Point(0, 0)
        SplitContainer1.Margin = New Padding(4, 5, 4, 5)
        SplitContainer1.Name = "SplitContainer1"
        ' 
        ' SplitContainer1.Panel1
        ' 
        SplitContainer1.Panel1.Controls.Add(TableLayoutPanel1)
        SplitContainer1.Panel1.Controls.Add(ToolStrip1)
        ' 
        ' SplitContainer1.Panel2
        ' 
        SplitContainer1.Panel2.Controls.Add(lstLog)
        SplitContainer1.Size = New Size(961, 525)
        SplitContainer1.SplitterDistance = 213
        SplitContainer1.SplitterWidth = 6
        SplitContainer1.TabIndex = 0
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 3
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 83F))
        TableLayoutPanel1.Controls.Add(ChkTimeStamp, 0, 3)
        TableLayoutPanel1.Controls.Add(Label2, 0, 2)
        TableLayoutPanel1.Controls.Add(Label1, 0, 1)
        TableLayoutPanel1.Controls.Add(cmdOpenOut, 2, 2)
        TableLayoutPanel1.Controls.Add(CmdOpenIn, 2, 1)
        TableLayoutPanel1.Controls.Add(TxtOutput, 1, 2)
        TableLayoutPanel1.Controls.Add(TxtInput, 1, 1)
        TableLayoutPanel1.Controls.Add(chkSilent, 0, 4)
        TableLayoutPanel1.Controls.Add(chkLog, 0, 5)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 33)
        TableLayoutPanel1.Margin = New Padding(4, 5, 4, 5)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 10
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        TableLayoutPanel1.Size = New Size(213, 492)
        TableLayoutPanel1.TabIndex = 1
        ' 
        ' ChkTimeStamp
        ' 
        ChkTimeStamp.AutoSize = True
        TableLayoutPanel1.SetColumnSpan(ChkTimeStamp, 3)
        ChkTimeStamp.Dock = DockStyle.Fill
        ChkTimeStamp.FlatAppearance.CheckedBackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        ChkTimeStamp.Location = New Point(4, 152)
        ChkTimeStamp.Margin = New Padding(4, 5, 4, 5)
        ChkTimeStamp.Name = "ChkTimeStamp"
        ChkTimeStamp.Size = New Size(205, 39)
        ChkTimeStamp.TabIndex = 2
        ChkTimeStamp.Text = "Create DateTime Folder"
        ChkTimeStamp.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Dock = DockStyle.Fill
        Label2.Location = New Point(4, 98)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(57, 49)
        Label2.TabIndex = 1
        Label2.Text = "Output Folder"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Dock = DockStyle.Fill
        Label1.Location = New Point(4, 49)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(57, 49)
        Label1.TabIndex = 0
        Label1.Text = "Input Folder"
        ' 
        ' cmdOpenOut
        ' 
        cmdOpenOut.BackgroundImageLayout = ImageLayout.Stretch
        cmdOpenOut.Location = New Point(134, 103)
        cmdOpenOut.Margin = New Padding(4, 5, 4, 5)
        cmdOpenOut.Name = "cmdOpenOut"
        cmdOpenOut.Size = New Size(51, 38)
        cmdOpenOut.TabIndex = 6
        cmdOpenOut.UseVisualStyleBackColor = True
        ' 
        ' CmdOpenIn
        ' 
        CmdOpenIn.BackgroundImageLayout = ImageLayout.Stretch
        CmdOpenIn.Location = New Point(134, 54)
        CmdOpenIn.Margin = New Padding(4, 5, 4, 5)
        CmdOpenIn.Name = "CmdOpenIn"
        CmdOpenIn.Size = New Size(51, 38)
        CmdOpenIn.TabIndex = 5
        CmdOpenIn.UseVisualStyleBackColor = True
        ' 
        ' TxtOutput
        ' 
        TxtOutput.Dock = DockStyle.Fill
        TxtOutput.Location = New Point(69, 103)
        TxtOutput.Margin = New Padding(4, 5, 4, 5)
        TxtOutput.Name = "TxtOutput"
        TxtOutput.ReadOnly = True
        TxtOutput.Size = New Size(57, 31)
        TxtOutput.TabIndex = 3
        ' 
        ' TxtInput
        ' 
        TxtInput.Dock = DockStyle.Fill
        TxtInput.Location = New Point(69, 54)
        TxtInput.Margin = New Padding(4, 5, 4, 5)
        TxtInput.Name = "TxtInput"
        TxtInput.ReadOnly = True
        TxtInput.Size = New Size(57, 31)
        TxtInput.TabIndex = 4
        ' 
        ' chkSilent
        ' 
        chkSilent.AutoSize = True
        chkSilent.BackColor = SystemColors.Control
        TableLayoutPanel1.SetColumnSpan(chkSilent, 3)
        chkSilent.Dock = DockStyle.Fill
        chkSilent.FlatAppearance.CheckedBackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        chkSilent.Location = New Point(3, 199)
        chkSilent.Name = "chkSilent"
        chkSilent.Size = New Size(207, 43)
        chkSilent.TabIndex = 7
        chkSilent.Text = "Silent Mode"
        chkSilent.UseVisualStyleBackColor = True
        ' 
        ' chkLog
        ' 
        chkLog.AutoSize = True
        TableLayoutPanel1.SetColumnSpan(chkLog, 3)
        chkLog.Location = New Point(3, 248)
        chkLog.Name = "chkLog"
        chkLog.Size = New Size(110, 29)
        chkLog.TabIndex = 8
        chkLog.Text = "Save Log"
        chkLog.UseVisualStyleBackColor = True
        ' 
        ' ToolStrip1
        ' 
        ToolStrip1.ImageScalingSize = New Size(24, 24)
        ToolStrip1.Items.AddRange(New ToolStripItem() {ToolStripLabel1, CmdSave, cmdRun})
        ToolStrip1.Location = New Point(0, 0)
        ToolStrip1.Name = "ToolStrip1"
        ToolStrip1.Padding = New Padding(0, 0, 3, 0)
        ToolStrip1.Size = New Size(213, 33)
        ToolStrip1.TabIndex = 0
        ToolStrip1.Text = "ToolStrip1"
        ' 
        ' ToolStripLabel1
        ' 
        ToolStripLabel1.Name = "ToolStripLabel1"
        ToolStripLabel1.Size = New Size(101, 28)
        ToolStripLabel1.Text = "WorkSpace"
        ' 
        ' CmdSave
        ' 
        CmdSave.DisplayStyle = ToolStripItemDisplayStyle.Image
        CmdSave.Image = CType(resources.GetObject("CmdSave.Image"), Image)
        CmdSave.ImageTransparentColor = Color.Magenta
        CmdSave.Name = "CmdSave"
        CmdSave.Size = New Size(34, 28)
        CmdSave.Text = "Save"
        ' 
        ' cmdRun
        ' 
        cmdRun.DisplayStyle = ToolStripItemDisplayStyle.Image
        cmdRun.Image = CType(resources.GetObject("cmdRun.Image"), Image)
        cmdRun.ImageTransparentColor = Color.Magenta
        cmdRun.Name = "cmdRun"
        cmdRun.Size = New Size(34, 28)
        cmdRun.Text = "Run"
        ' 
        ' lstLog
        ' 
        lstLog.Dock = DockStyle.Fill
        lstLog.FormattingEnabled = True
        lstLog.ItemHeight = 25
        lstLog.Location = New Point(0, 0)
        lstLog.Margin = New Padding(4, 5, 4, 5)
        lstLog.Name = "lstLog"
        lstLog.Size = New Size(742, 525)
        lstLog.TabIndex = 2
        ' 
        ' frmWorkspace
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(961, 525)
        Controls.Add(SplitContainer1)
        Margin = New Padding(4, 5, 4, 5)
        Name = "frmWorkspace"
        Text = "Work Space"
        SplitContainer1.Panel1.ResumeLayout(False)
        SplitContainer1.Panel1.PerformLayout()
        SplitContainer1.Panel2.ResumeLayout(False)
        CType(SplitContainer1, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.ResumeLayout(False)
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        ToolStrip1.ResumeLayout(False)
        ToolStrip1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ChkTimeStamp As CheckBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents TxtOutput As TextBox
    Friend WithEvents TxtInput As TextBox
    Friend WithEvents CmdOpenIn As Button
    Friend WithEvents cmdOpenOut As Button
    Friend WithEvents CmdSave As ToolStripButton
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents cmdRun As ToolStripButton
    Friend WithEvents lstLog As ListBox
    Friend WithEvents chkSilent As CheckBox
    Friend WithEvents chkLog As CheckBox
End Class
