
Imports Microsoft.VisualBasic.FileIO
Imports Microsoft.VisualBasic.Logging
Imports System.IO
Public Class FindFiles

    Public Sub New()

    End Sub

    Public Function Find_Files(gui As Main)

        Dim directory As String = "C:\SW\_Progetti\CableTester\FlashedLOL\CablesList"
        Dim cables_list As String() = System.IO.Directory.GetFiles(directory, "*")

        gui.cbox_list_cables.Items.Clear()

        For Each file_code As String In cables_list
            gui.cbox_list_cables.Items.Add(System.IO.Path.GetFileName(file_code))
        Next
    End Function
End Class
