Public Class SendVar_to_PLC
    Dim can As New CanCommunication


    Function MsgComposer() As UShort
        Dim VarTempComposer As UShort


    End Function

    Function SetOutput(output_to_set As UInt16)

        Dim var As UInt32 = 0

        var = 1 << (output_to_set - 1)

        can.SendCmdToPLC(var)

    End Function
End Class