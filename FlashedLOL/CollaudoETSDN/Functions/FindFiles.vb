
Imports Microsoft.VisualBasic.FileIO
Imports Microsoft.VisualBasic.Logging
Imports System.IO
Public Class FindFiles

    Public Sub New()

    End Sub

    Public Function Find_Files(gui As Main)

        Dim directory As String = Application.StartupPath & "\\CablesList\\"
        Dim cables_list As String() = System.IO.Directory.GetFiles(directory, "*")
        Dim partToRemove = ".csv"
        gui.listCable_cbox.Items.Clear()

        For Each file_code As String In cables_list
            Dim newFileName As String = file_code.Replace(partToRemove, String.Empty)
            gui.listCable_cbox.Items.Add(System.IO.Path.GetFileName(newFileName))
        Next
    End Function
End Class
