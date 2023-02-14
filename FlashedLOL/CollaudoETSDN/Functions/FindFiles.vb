
Imports Microsoft.VisualBasic.FileIO
Imports Microsoft.VisualBasic.Logging
Imports System.IO
Public Class FindFiles

    Public Sub New()

    End Sub

    Public Function Find_Files(gui As Main)

        Dim path As String = Application.StartupPath & "\\CablesList\\"
        Dim cables_list As String() = System.IO.Directory.GetFiles(path, "*")
        Dim part_to_remove = ".csv"
        gui.listCable_cbox.Items.Clear()

        For Each code As String In cables_list
            Dim new_code As String = code.Replace(part_to_remove, String.Empty)
            gui.listCable_cbox.Items.Add(System.IO.Path.GetFileName(new_code))
        Next
    End Function
End Class
