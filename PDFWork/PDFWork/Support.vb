Module Support
    Public G_Image_Path As String
    Public G_Log_Path As String
    Public G_Input_Path As String
    Public G_Output_Path As String
    Public G_Config_Path As String
    Public G_Run_Silent As Boolean
    Public G_Create_Daily_Folder As Boolean
    Public Sub INI_SUPPORT()
        G_Image_Path = Application.StartupPath() + "\Images\"
        G_Config_Path = Application.StartupPath() + "\PWConfig.txt"
        G_Log_Path = Application.StartupPath + "\Log\"
        G_Input_Path = "NA"
        G_Output_Path = "NA"
    End Sub
End Module
