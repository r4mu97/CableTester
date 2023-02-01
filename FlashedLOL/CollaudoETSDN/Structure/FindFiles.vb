
Imports Microsoft.VisualBasic.FileIO
Imports Microsoft.VisualBasic.Logging
Imports System.IO
Public Class FindFiles

    Public Sub New()

    End Sub

    Public Function Find_Files(gui As Main)
        Dim files() As String = IO.Directory.GetFiles(Application.StartupPath + "\CablesList")

        gui.cbox_list_cables.Items.Clear()
        For Each file As String In files
            gui.cbox_list_cables.Items.Add(file.Substring(60))
        Next

    End Function




End Class
