Imports System.IO
Public Class frmStartup
    Private Sub SplitContainer1_SplitterMoved(sender As Object, e As SplitterEventArgs) Handles SplitContainer1.SplitterMoved

    End Sub

    Private Sub frmStartup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Support.INI_SUPPORT()

        Dim txts As String
        txts = File.ReadAllText(G_Config_Path)
        If Len(Trim(txts)) = 0 Then
            'AddLog("Please config all required information (Input Path/Output path etc.")
        Else
            If txts.Contains(vbCrLf) Then
                Dim lines() As String = Split(txts, vbCrLf)
                For i = 0 To lines.Length - 1
                    If Trim(lines(i)) <> "" Then
                        If lines(i).Contains("=") Then
                            Dim valuesSplit() As String = Split(lines(i), "=")
                            If valuesSplit(0).Trim.ToUpper = "INPUT" Then
                                G_Input_Path = valuesSplit(1)

                            End If
                            If valuesSplit(0).Trim.ToUpper = "OUTPUT" Then
                                G_Output_Path = valuesSplit(1)
                            End If
                            If valuesSplit(0).Trim.ToUpper = "SILENT" Then
                                If valuesSplit(1).Trim.ToUpper = "TRUE" Then
                                    G_Run_Silent = True
                                Else
                                    G_Run_Silent = False
                                End If

                            End If

                            If valuesSplit(0).Trim.ToUpper = "CREATEFOLDER" Then
                                If valuesSplit(1).Trim.ToUpper = "TRUE" Then
                                    G_Create_Daily_Folder = True
                                Else
                                    G_Create_Daily_Folder = False
                                End If

                            End If

                        End If
                    End If

                Next
            End If
        End If

        PicLogoBox.BackgroundImage = Image.FromFile(G_Image_Path + "startup4.png")

        If G_Run_Silent = True Then ShowWorkSpace()
    End Sub

    Private Sub cmdButton_Click(sender As Object, e As EventArgs)
        'Process.Start("chrome.exe " + Chr(34) + "https://www.gnu.org/licenses/agpl-3.0.html#license-text" + Chr(34))
        Process.Start("microsoft-edge:https://www.gnu.org/licenses/agpl-3.0.html#license-text")
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Clipboard.SetText("https://www.gnu.org/licenses/agpl-3.0.html#license-text")
        MsgBox("Link Copied to the clipboard", MsgBoxStyle.Information)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        ShowWorkSpace()
    End Sub

    Private Sub PicLogoBox_Click(sender As Object, e As EventArgs) Handles PicLogoBox.Click
        ShowWorkSpace()
    End Sub
    Private Sub ShowWorkSpace()
        frmWorkspace.WindowState = FormWindowState.Maximized
        frmWorkspace.Show()
        Me.Hide()
    End Sub
End Class
