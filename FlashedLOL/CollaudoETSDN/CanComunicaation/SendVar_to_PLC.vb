Public Class SendVar_to_PLC
    Dim setOut1, setOut2, setOut3, setOut4, setOut5, setOut6, setOut7, setOut8, setOut9, setOut10,
        setOut11, setOut12, setOut13, setOut14, setOut15, setOut16, setOut17, setOut18, setOut19, setOut20 As Byte

    Public Sub SetStateOut1(stato)
        setOut1 = stato
    End Sub

    Public Sub SetStateOut2(stato)
        setOut2 = stato
    End Sub

    Public Sub SetStateOut3(stato)
        setOut3 = stato
    End Sub

    Public Sub SetStateOut4(stato)
        setOut4 = stato
    End Sub

    Public Sub SetStateOut5(stato)
        setOut5 = stato
    End Sub

    Public Sub SetStateOut6(stato)
        setOut6 = stato
    End Sub

    Public Sub SetStateOut7(stato)
        setOut7 = stato
    End Sub
    Public Sub SetStateOut8(stato)
        setOut8 = stato
    End Sub
    Public Sub SetStateOut9(stato)
        setOut9 = stato
    End Sub

    Public Sub SetStateOut10(stato)
        setOut10 = stato
    End Sub
    Public Sub SetStateOut11(stato)
        setOut11 = stato
    End Sub

    Public Sub SetStateOut12(stato)
        setOut12 = stato
    End Sub

    Public Sub SetStateOut13(stato)
        setOut13 = stato
    End Sub

    Public Sub SetStateOut14(stato)
        setOut14 = stato
    End Sub
    Public Sub SetStateOut15(stato)
        setOut15 = stato
    End Sub
    Public Sub SetStateOut16(stato)
        setOut16 = stato
    End Sub
    Public Sub SetStateOut17(stato)
        setOut17 = stato
    End Sub
    Public Sub SetStateOut18(stato)
        setOut18 = stato
    End Sub
    Public Sub SetStateOut19(stato)
        setOut19 = stato
    End Sub
    Public Sub SetStateOut20(stato)
        setOut20 = stato
    End Sub


    Function MsgComposer() As UShort
        Dim VarTempComposer As UShort

        VarTempComposer = 0
        VarTempComposer = VarTempComposer + setOut1
        VarTempComposer = VarTempComposer + (CType(setOut1, UShort) << 1)
        VarTempComposer = VarTempComposer + (CType(setOut2, UShort) << 2)
        VarTempComposer = VarTempComposer + (CType(setOut3, UShort) << 3)
        VarTempComposer = VarTempComposer + (CType(setOut4, UShort) << 4)
        VarTempComposer = VarTempComposer + (CType(setOut5, UShort) << 5)
        VarTempComposer = VarTempComposer + (CType(setOut6, UShort) << 6)
        VarTempComposer = VarTempComposer + (CType(setOut7, UShort) << 7)


        VarTempComposer = VarTempComposer + (CType(setOut8, UShort) << 8)
        VarTempComposer = VarTempComposer + (CType(setOut9, UShort) << 9)
        VarTempComposer = VarTempComposer + (CType(setOut10, UShort) << 10)
        VarTempComposer = VarTempComposer + (CType(setOut11, UShort) << 11)

        Return VarTempComposer
    End Function

End Class