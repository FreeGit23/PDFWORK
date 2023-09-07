Imports System.Security.AccessControl
Imports System.IO
Imports Ghostscript.NET.Rasterizer
Imports System
Imports System.Drawing.Imaging
Imports Ghostscript.NET
Public Class frmWorkspace
    Private Sub CmdSave_Click(sender As Object, e As EventArgs) Handles CmdSave.Click

        ' CmdSave.BackgroundImage = Image.FromFile(G_Image_Path + "Save.png")
        Dim ConfigText As String
        'Public G_Log_Path As String
        'Public G_Input_Path As String
        'Public G_Output_Path As String
        'Public G_Config_Path As String
        'Public G_Run_Silent As Boolean
        'Public G_Create_Daily_Folder As Boolean


        AddLog("Validating Input Folder")
        If Len(TxtInput.Text) = 0 Then
            AddLog("Input Folder Should Not Be Empty")
            Exit Sub
        End If
        If Directory.Exists(TxtInput.Text) = False Then
            AddLog("Invalid Input Directory " + TxtInput.Text)
            Exit Sub
        End If

        AddLog("Ok.")
        AddLog("Validating Output Folder")
        If Len(TxtOutput.Text) = 0 Then
            AddLog("Output Folder Should Not Be Empty")
            Exit Sub
        End If

        If Directory.Exists(TxtOutput.Text) = False Then
            AddLog("Invalid Ouput Directory " + TxtInput.Text)
            Exit Sub
        End If
        AddLog("Ok.")

        G_Input_Path = TxtInput.Text
        G_Output_Path = TxtOutput.Text

        G_Run_Silent = IIf(chkSilent.CheckState = CheckState.Checked, True, False)

        G_Create_Daily_Folder = IIf(ChkTimeStamp.CheckState = CheckState.Checked, True, False)

        ConfigText = "Input=" + G_Input_Path + vbCrLf
        ConfigText = ConfigText + "Output=" + G_Output_Path + vbCrLf
        ConfigText = ConfigText + "Silent=" + IIf(chkSilent.CheckState = CheckState.Checked, "True", "False") + vbCrLf
        ConfigText = ConfigText + "CreateFolder=" + IIf(ChkTimeStamp.CheckState = CheckState.Checked, "True", "False") + vbCrLf

        File.WriteAllText(G_Config_Path, ConfigText)
        MsgBox("Saved")
    End Sub

    Private Sub frmWorkspace_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CmdSave.Image = Image.FromFile(G_Image_Path + "Save.png")
        cmdRun.Image = Image.FromFile(G_Image_Path + "Run.png")
        CmdOpenIn.BackgroundImage = Image.FromFile(G_Image_Path + "Open.png")
        cmdOpenOut.BackgroundImage = Image.FromFile(G_Image_Path + "Open.png")
        If Directory.Exists(G_Log_Path) = False Then
            Directory.CreateDirectory(G_Log_Path)
        End If


        If G_Run_Silent = True Then
            Me.Visible = False
            Call cmdRun_Click(sender, e)
        End If

        TxtInput.Text = G_Input_Path
        TxtOutput.Text = G_Output_Path
        ChkTimeStamp.Checked = G_Create_Daily_Folder
    End Sub

    Private Sub AddLog(logs As String)
        lstLog.Items.Add(Now.ToString("dd-MMM-yyy HH:mm:ss") + "," + logs)
    End Sub
    Private Sub frmWorkspace_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated

    End Sub

    Private Sub CmdOpenIn_Click(sender As Object, e As EventArgs) Handles CmdOpenIn.Click
        FolderBrowserDialog1.ShowDialog()
        TxtInput.Text = FolderBrowserDialog1.SelectedPath

    End Sub

    Private Sub cmdOpenOut_Click(sender As Object, e As EventArgs) Handles cmdOpenOut.Click
        FolderBrowserDialog1.ShowDialog()
        TxtOutput.Text = FolderBrowserDialog1.SelectedPath
    End Sub

    Private Sub cmdRun_Click(sender As Object, e As EventArgs) Handles cmdRun.Click
        lstLog.Items.Clear()
        Dim t_output_path As String
        Try
            AddLog("Validating Input Folder")
            If Len(TxtInput.Text) = 0 Then
                AddLog("Input Folder Should Not Be Empty")
                If G_Run_Silent = True Then End
                Exit Sub
            End If
            If Directory.Exists(TxtInput.Text) = False Then
                AddLog("Invalid Input Directory " + TxtInput.Text)
                If G_Run_Silent = True Then End
                Exit Sub
            End If
            AddLog("Ok.")
            AddLog("Validating Output Folder")
            If Len(TxtOutput.Text) = 0 Then
                AddLog("Output Folder Should Not Be Empty")
                If G_Run_Silent = True Then End
                Exit Sub
            End If

            If Directory.Exists(TxtOutput.Text) = False Then
                AddLog("Invalid Ouput Directory " + TxtInput.Text)
                If G_Run_Silent = True Then End
                Exit Sub
            End If
            AddLog("Ok.")
            AddLog("Checking Option For Create Folder For Each Day is Required")
            If ChkTimeStamp.Checked = True Then
                Dim p As String
                p = TxtOutput.Text + "\" + Now.ToString("yyyyMMdd")
                t_output_path = p
                If Directory.Exists(p) = False Then
                    Directory.CreateDirectory(p)
                    AddLog("Folder Created " + p)
                Else
                    AddLog("Folder " + p + " is alredy exists ")
                End If
            End If
            AddLog("Looking For Files")
            Dim Input_FileList() As String = Directory.GetFiles(TxtInput.Text)
            For i = 0 To Input_FileList.Length - 1
                Dim InPath As String
                InPath = ""
                InPath = t_output_path + "\" + Path.GetFileNameWithoutExtension(Input_FileList(i))

                AddLog("Processing " + Input_FileList(i).ToString)
                Directory.CreateDirectory(InPath)


                PdfToPng(Input_FileList(i), InPath)
                AddLog("done ")
            Next
            AddLog("PDF to Image Process is Completed ")
        Catch ex As Exception
            AddLog(ex.Message)
        End Try
        Dim logstr As String
        For i = 0 To lstLog.Items.Count - 1
            logstr = logstr + lstLog.Items(i).ToString + vbCrLf
        Next
        File.WriteAllText(G_Log_Path + "log" + Now.ToString("yyyyMMMdd") + ".txt", logstr)
        If G_Run_Silent = True Then End
    End Sub

    Private Sub PdfToPng(inputFile As String, outputFileName As String)

        Dim xDpi = 100
        Dim yDpi = 100
        Dim pageNumber = 1



        Dim rasterizer = New GhostscriptRasterizer() ') '//create an instance For GhostscriptRasterizer

        rasterizer.Open(inputFile) '//opens the PDF file For rasterizing

        ' //set the output image(png's) complete path
        ' Dim outputPNGPath = Path.Combine(outputFolde, String.Format("{0}.png", outputFileName))
        Dim runFlag As Boolean
        runFlag = True
        Do While (runFlag)
            Try
                '//converts the PDF pages to png's 
                Dim pdf2PNG = rasterizer.GetPage(300, pageNumber)

                ' //save the png's
                pdf2PNG.Save(outputFileName + "\" + pageNumber.ToString + ".png", ImageFormat.Png)
                'Console.WriteLine("Saved " + outputPNGPath)
                pageNumber = pageNumber + 1
            Catch ex1 As Exception
                runFlag = False
            End Try

        Loop

    End Sub

    Private Sub frmWorkspace_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        GC.Collect()
        End

    End Sub

    Private Sub ChkTimeStamp_CheckedChanged(sender As Object, e As EventArgs) Handles ChkTimeStamp.CheckedChanged

        G_Create_Daily_Folder = IIf(ChkTimeStamp.CheckState = CheckState.Checked, True, False)
    End Sub

    Private Sub chkSilent_CheckedChanged(sender As Object, e As EventArgs) Handles chkSilent.CheckedChanged
        G_Run_Silent = IIf(chkSilent.CheckState = CheckState.Checked, True, False)
    End Sub

    Private Sub TxtInput_TextChanged(sender As Object, e As EventArgs) Handles TxtInput.TextChanged

    End Sub
End Class