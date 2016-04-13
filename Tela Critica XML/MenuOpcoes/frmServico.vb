Imports System.ServiceProcess

Public Class frmServico

    Private Sub frmServico_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim service As ServiceController = New ServiceController(".InspetorXML")

        If ((service.Status.Equals(ServiceControllerStatus.Stopped)) Or (service.Status.Equals(ServiceControllerStatus.StopPending))) Then

            Label1.Text = " Serviço Parado"

        ElseIf service.Status.Equals(ServiceControllerStatus.Running) Then

            Label1.Text = " Serviço Iniciado"

        End If

    End Sub

    Private Sub btnPararServico_Click(sender As Object, e As EventArgs) Handles btnPararServico.Click

        Dim service As ServiceController = New ServiceController(".InspetorXML")

        service.Stop()

        If service.Status.Equals(ServiceControllerStatus.Stopped) Then

            Label1.Text = " Serviço Parado"

        End If

    End Sub

    Private Sub btnIniciar_Click(sender As Object, e As EventArgs) Handles btnIniciar.Click

        Dim service As ServiceController = New ServiceController(".InspetorXML")

        service.Start()

        If service.Status.Equals(ServiceControllerStatus.Running) Then

            Label1.Text = " Serviço Iniciado"

        End If

    End Sub

    Private Sub btnStatus_Click(sender As Object, e As EventArgs) Handles btnStatus.Click

        Dim service As ServiceController = New ServiceController(".InspetorXML")

        If ((service.Status.Equals(ServiceControllerStatus.Stopped)) Or (service.Status.Equals(ServiceControllerStatus.StopPending))) Then

            Label1.Text = " Serviço Parado"

        ElseIf service.Status.Equals(ServiceControllerStatus.Running) Then

            Label1.Text = " Serviço Iniciado"

        End If

    End Sub
End Class