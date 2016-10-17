Public Class frmVersao

    Private Sub frmVersao_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With My.Application.Info.Version
            lVersionNumber.Text = "Version " & .Major & "." & .Minor & " (Build " & .Build & "." & .Revision & ")"
        End With
    End Sub

End Class