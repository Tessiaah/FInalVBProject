Public Class DataAtividades
    Inherits BaseClass

    Private frmConsultas As Consultas

    Dim activity As String
    Dim selecteddate As String



    Sub New(consultas As Consultas)
        InitializeComponent()
        frmConsultas = consultas
    End Sub

    Private Sub DataAtividades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        setdefault()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim answer As MsgBoxResult = MsgBox("Deseja voltar atrás?", vbQuestion + vbYesNo, appname)
        If answer = MsgBoxResult.Yes Then
            goback()
        End If
    End Sub

    Private Sub cboAtividades_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboAtividades.SelectedIndexChanged
        If cboAtividades.SelectedIndex <> -1 Then
            btnVerificar.Enabled = True
        End If
        activity = cboAtividades.SelectedItem
    End Sub

    Private Sub datePicker_ValueChanged(sender As Object, e As EventArgs) Handles datePicker.ValueChanged
        selecteddate = datePicker.Value.ToString("dd/MM/yyyy")
    End Sub

    Private Sub btnVerificar_Click(sender As Object, e As EventArgs) Handles btnVerificar.Click
        lblAmount.Text = totalTickets(activity, selecteddate)
    End Sub

    Private Sub setdefault()
        datePicker.MinDate = Date.Now
        cboAtividades.SelectedIndex = -1
        lblAmount.Text = 0
        btnVerificar.Enabled = False
        selecteddate = datePicker.Value.ToString("dd/MM/yyyy")
    End Sub

    Private Sub goback()
        Controls.Clear()
        InitializeComponent()
        setdefault()
        frmConsultas.gobackConsultas()
    End Sub

    Private Function totalTickets(activity As String, selecteddate As String) As Integer
        Dim total As Integer = 0

        For Each encomenda In purchaselist
            For i = 0 To encomenda.Date_.Count - 1
                If encomenda.Date_(i) = selecteddate AndAlso encomenda.Activity(i) = activity Then
                    total += encomenda.Ntickets(i)
                End If
            Next
        Next

        Return total
    End Function


End Class