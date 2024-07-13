Public Class Consultas
    Inherits BaseClass
    Private frmHP As Form1
    Private frmID As IDConsultas
    Private frmAtividades As DataAtividades

    'Constructor to allow a callback to the mainform by having frmMenu serve as an object of Form1
    Public Sub New(menu As Form1)
        InitializeComponent()
        frmHP = menu
    End Sub

    Private Sub Consultas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmID = New IDConsultas(Me)
        frmAtividades = New DataAtividades(Me)
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim answer As MsgBoxResult = MsgBox("Deseja voltar à página principal?", vbYesNo + vbQuestion, appname)
        If answer = MsgBoxResult.Yes Then
            frmHP.resetHomePage()
        End If
    End Sub

    Private Sub btnID_Click(sender As Object, e As EventArgs) Handles btnID.Click
        formchanger(frmID)
    End Sub

    Private Sub btnAtividades_Click(sender As Object, e As EventArgs) Handles btnAtividades.Click
        formchanger(frmAtividades)
    End Sub


    Public Sub gobackConsultas()
        Controls.Clear()
        InitializeComponent()
    End Sub


End Class