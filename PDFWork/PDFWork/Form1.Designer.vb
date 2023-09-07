<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStartup
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        SplitContainer1 = New SplitContainer()
        PicLogoBox = New PictureBox()
        Label1 = New Label()
        LinkLabel1 = New LinkLabel()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer1.Panel1.SuspendLayout()
        SplitContainer1.Panel2.SuspendLayout()
        SplitContainer1.SuspendLayout()
        CType(PicLogoBox, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' SplitContainer1
        ' 
        SplitContainer1.Dock = DockStyle.Fill
        SplitContainer1.Location = New Point(0, 0)
        SplitContainer1.Name = "SplitContainer1"
        SplitContainer1.Orientation = Orientation.Horizontal
        ' 
        ' SplitContainer1.Panel1
        ' 
        SplitContainer1.Panel1.Controls.Add(PicLogoBox)
        ' 
        ' SplitContainer1.Panel2
        ' 
        SplitContainer1.Panel2.Controls.Add(Label1)
        SplitContainer1.Panel2.Controls.Add(LinkLabel1)
        SplitContainer1.Size = New Size(810, 483)
        SplitContainer1.SplitterDistance = 425
        SplitContainer1.SplitterWidth = 3
        SplitContainer1.TabIndex = 0
        ' 
        ' PicLogoBox
        ' 
        PicLogoBox.BackgroundImageLayout = ImageLayout.Stretch
        PicLogoBox.Dock = DockStyle.Fill
        PicLogoBox.Location = New Point(0, 0)
        PicLogoBox.Name = "PicLogoBox"
        PicLogoBox.Size = New Size(810, 425)
        PicLogoBox.TabIndex = 1
        PicLogoBox.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Dock = DockStyle.Top
        Label1.Location = New Point(0, 0)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(546, 25)
        Label1.TabIndex = 1
        Label1.Text = "Please refer below URL for License Details, And Click me to continue"
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Dock = DockStyle.Bottom
        LinkLabel1.Location = New Point(0, 30)
        LinkLabel1.Margin = New Padding(4, 0, 4, 0)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(456, 25)
        LinkLabel1.TabIndex = 0
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "https://www.gnu.org/licenses/agpl-3.0.html#license-text"
        ' 
        ' frmStartup
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(810, 483)
        Controls.Add(SplitContainer1)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmStartup"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Start Up"
        SplitContainer1.Panel1.ResumeLayout(False)
        SplitContainer1.Panel2.ResumeLayout(False)
        SplitContainer1.Panel2.PerformLayout()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.ResumeLayout(False)
        CType(PicLogoBox, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents PicLogoBox As PictureBox
    Friend WithEvents cmdButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
