Public Class IDConsultas
    Inherits BaseClass
    Private frmConsultas As Consultas

    Dim id As Integer

    'Used in going back to previous form
    Public Sub New(consultas As Consultas)
        InitializeComponent()
        frmConsultas = consultas
    End Sub

    Private Sub IDConsultas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reset(False)
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim answer As MsgBoxResult = MsgBox("Deseja voltar atrás?", vbQuestion + vbYesNo, appname)
        If answer = MsgBoxResult.Yes Then
            returnback()
        End If
    End Sub

    Private Sub txtID_TextChanged(sender As Object, e As EventArgs) Handles txtID.TextChanged
        If txtID.Text <> "" Then
            reset(True)
        Else
            reset(False)
        End If
    End Sub

    Private Sub txtID_Keypress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtID.KeyPress
        'Will supress anything that is not numbers or backspace and shit
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnVerificar_Click(sender As Object, e As EventArgs) Handles btnVerificar.Click
        lstCart.Items.Clear()
        id = txtID.Text
        If currentpurchases = Nothing Then
            MsgBox("Nenhuma compra efetuada!", vbCritical + vbOKOnly, appname)
        ElseIf id >= currentpurchases Then
            MsgBox("ID inválido introduzido!", vbCritical + vbOKOnly, appname)
        Else
            filllst()
            reset(False)
        End If
    End Sub

    Private Sub reset(showhide As Boolean)
        If showhide = True Then
            btnVerificar.Enabled = True
        Else
            btnVerificar.Enabled = False
        End If
    End Sub

    Private Sub filllst()
        For i = 0 To purchaselist(id).Area.Count - 1
            Dim item As New ListViewItem(purchaselist(id).Area(i))
            item.SubItems.Add(purchaselist(id).Activity(i))
            item.SubItems.Add(purchaselist(id).Date_(i))
            item.SubItems.Add(purchaselist(id).Time(i))
            item.SubItems.Add(purchaselist(id).Type(i))
            item.SubItems.Add(purchaselist(id).Ntickets(i))
            lstCart.Items.Add(item)
        Next
        lblPrice.Text = purchaselist(id).Price
    End Sub

    Private Sub returnback()
        Controls.Clear()
        InitializeComponent()
        reset(False)
        frmConsultas.gobackConsultas()
    End Sub
End Class