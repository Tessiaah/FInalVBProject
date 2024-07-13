Imports System.Globalization

Public Class Encomendar
    Inherits BaseClass
    Private frmHP As Form1
    ReadOnly parquesmonumentos() As Image = {My.Resources.PalacioPena, My.Resources.VisitaPena, My.Resources.Visista_Condessa,
                                             My.Resources.ParqueMonserrate, My.Resources.VisitaMonserrate, My.Resources.CasteloMouros,
                                             My.Resources.VisistaMouros, My.Resources.NacionalSintra, My.Resources.VisistaNacionalSintra, My.Resources.ParqueQueluz,
                                             My.Resources.VisitaQueluz, My.Resources.VisitaMaria, My.Resources.ArteCavalos, My.Resources.JardinsQueluz, My.Resources.ConventoCap,
                                             My.Resources.VisitaConvento, My.Resources.ParquePena, My.Resources.CaboRocha}

    ReadOnly experiencias() As Image = {My.Resources.poneipena, My.Resources.tesouromonserrate, My.Resources.tesouropena, My.Resources.visitaarte, My.Resources.flroestafrades,
                                        My.Resources.jogos, My.Resources.diario, My.Resources.diaadia, My.Resources.conquistacastelo, My.Resources.tesourorei, My.Resources.aventurrapena,
                                        My.Resources.enigmapalacio, My.Resources.visitapeninha, My.Resources.nature, My.Resources.bicharada, My.Resources.casareal, My.Resources.comarainha,
                                        My.Resources.ajudantesjardins, My.Resources.caçada, My.Resources.outrolado, My.Resources.jardimbotanico, My.Resources.luar, My.Resources.osanfibios,
                                        My.Resources.produtoscolmeia, My.Resources.pirilampos, My.Resources.tintassilvestres, My.Resources.artebotanica, My.Resources.primaveraparque,
                                        My.Resources.noitecapuchos, My.Resources.mel, My.Resources.apicultor, My.Resources.noitejardim, My.Resources.estrategias, My.Resources.reliquia,
                                        My.Resources.rendezvous, My.Resources.pragasjardins, My.Resources.oficinaverao, My.Resources.overaonoparque, My.Resources.overaonojardimmonserrate}

    ReadOnly programacao() As Image = {My.Resources.jazz, My.Resources.galas, My.Resources.marialva, My.Resources.baixaescola, My.Resources.treinocavalo, My.Resources.cavaolusitano,
                                       My.Resources.simbolo, My.Resources.tritoes}



    'Ticket prices to be used in calculations, allow for easy change of values as wanted
    Const adultticket As Decimal = 17
    Const youngticket As Decimal = 15.3
    Const oldticket As Decimal = 15.3
    Const childticket As Decimal = 0
    Const familyticket As Decimal = 55.25

    'Constructor to allow a callback to the mainform by having frmMenu serve as an object of Form1
    Public Sub New(menu As Form1)
        InitializeComponent()
        frmHP = menu
    End Sub

    Private Sub Encomendar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Setting base view when loading
        setshittofalse()
    End Sub

    'This will wipe the form to allow for a clean reset each time you go back to HP. Added: Msg to ensure user wants to return
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim answer As MsgBoxResult = MsgBox("Voltar a trás irá limpar os dados inseridos!" & vbNewLine & "Deseja voltar à página principal?",
                                            vbExclamation + vbOKCancel, appname)
        If answer = MsgBoxResult.Ok Then
            returnHP()
        End If
    End Sub

    'These allow for me to show the stuff in the order showed in the website
    Private Sub cboArea_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboArea.SelectedIndexChanged
        setactivitiesdisplay(True)
    End Sub

    'Handles all boxes at the same time lessss go
    Private Sub cbo_IndexChange(sender As Object, e As EventArgs) Handles cboProg.SelectedIndexChanged, cboParques.SelectedIndexChanged, cboExp.SelectedIndexChanged
        If sender Is cboParques Then
            pbxActivity.Image = parquesmonumentos(cboParques.SelectedIndex)
        ElseIf sender Is cboExp Then
            pbxActivity.Image = experiencias(cboExp.SelectedIndex)
        ElseIf sender Is cboProg Then
            pbxActivity.Image = programacao(cboProg.SelectedIndex)
        End If
        setdatetimedisplay(True)
        addenabler()
    End Sub

    Private Sub cboTime_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTime.SelectedIndexChanged
        settypeamount(True)
        addenabler()
    End Sub

    Private Sub cboType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboType.SelectedIndexChanged
        addenabler()
    End Sub

    Private Sub nTickets_ValueChanged(sender As Object, e As EventArgs) Handles nTickets.ValueChanged
        addenabler()
    End Sub


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim price As Decimal = lblPrice.Text
        price += ticketprice()
        lblPrice.Text = price
        addtocart()
        'Enable the finish button
        finishenabler(True)
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        subtractlabel()
        lstCart.Items.Remove(lstCart.SelectedItems(0))
        If lstCart.Items.Count = 0 Then
            finishenabler(False)
        End If
    End Sub

    Private Sub btnFinish_Click(sender As Object, e As EventArgs) Handles btnFinish.Click
        If currentpurchases = Nothing Then
            currentpurchases = 0
        End If
        purchaselist.Add(New Encomenda)
        'This will take care of all the fields in the object
        filltheobject()
        MsgBox("Obrigado pela Sua compra!" & vbNewLine & "O seu ID de compra é: " & purchaselist(currentpurchases).ID & vbNewLine &
               "Aguardámo-lo ansiosamente!", vbOKOnly + vbInformation, appname)
        currentpurchases += 1
        returnHP()
    End Sub

    Private Sub lstCart_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstCart.SelectedIndexChanged
        'checks whether theres a selected row and if so will enable the remove button
        If lstCart.SelectedItems.Count > 0 Then
            btnRemove.Enabled = True
        Else
            btnRemove.Enabled = False
        End If
    End Sub

    'Return user to main menu and clears everything
    Private Sub returnHP()
        Controls.Clear()
        InitializeComponent()
        setshittofalse()
        frmHP.resetHomePage()
    End Sub

    Private Sub setactivitiesdisplay(showhide As Boolean)
        If showhide = True AndAlso cboArea.SelectedIndex <> -1 Then
            iconAtividade.Visible = True
            lblAtividade.Visible = True
            If cboArea.SelectedItem = "Parques e Monumentos" Then
                cboParques.Visible = True
                cboExp.Visible = False
                cboProg.Visible = False
            ElseIf cboArea.SelectedItem = "Experiências" Then
                cboExp.Visible = True
                cboParques.Visible = False
                cboProg.Visible = False
            ElseIf cboArea.SelectedItem = "Programação Cultural" Then
                cboProg.Visible = True
                cboParques.Visible = False
                cboExp.Visible = False
            End If
        Else
            iconAtividade.Visible = False
            lblAtividade.Visible = False
            cboParques.Visible = False
            cboExp.Visible = False
            cboProg.Visible = False
        End If
    End Sub

    Private Sub setdatetimedisplay(showhide As Boolean)
        If showhide = True AndAlso cboParques.SelectedIndex <> -1 Or cboExp.SelectedIndex <> -1 Or cboProg.SelectedIndex <> -1 Then
            iconDate.Visible = True
            lblDate.Visible = True
            iconTime.Visible = True
            lblTime.Visible = True
            datePicker.Visible = True
            cboTime.Visible = True
        Else
            iconDate.Visible = False
            lblDate.Visible = False
            iconTime.Visible = False
            lblTime.Visible = False
            datePicker.Visible = False
            cboTime.Visible = False
        End If
    End Sub

    Private Sub settypeamount(showhide As Boolean)
        If showhide = True AndAlso cboTime.SelectedIndex <> -1 Then
            iconType.Visible = True
            lblType.Visible = True
            cboType.Visible = True
            iconAmount.Visible = True
            lblAmount.Visible = True
            nTickets.Visible = True
        Else
            iconType.Visible = False
            lblType.Visible = False
            cboType.Visible = False
            iconAmount.Visible = False
            lblAmount.Visible = False
            nTickets.Visible = False
        End If
    End Sub

    Private Sub setshittofalse()
        setactivitiesdisplay(False)
        setdatetimedisplay(False)
        settypeamount(False)
        btnAdd.Enabled = False
        btnRemove.Enabled = False
        btnFinish.Enabled = False
        lblPrice.Text = 0
        datePicker.MinDate = Date.Now
    End Sub

    'Will add all the information on the fields to the lstview asdndashjadsjhkadsjkhdaskjhsadjhdskajlhhkjl
    Private Sub addtocart()
        Dim listviewitem As New ListViewItem(cboArea.SelectedItem.ToString())

        If cboParques.Visible = True Then
            listviewitem.SubItems.Add(cboParques.SelectedItem.ToString())
        ElseIf cboExp.Visible = True Then
            listviewitem.SubItems.Add(cboExp.SelectedItem.ToString())
        ElseIf cboProg.Visible = True Then
            listviewitem.SubItems.Add(cboProg.SelectedItem.ToString())
        End If

        Dim selectedate As Date = datePicker.Value.ToString("dd/MM/yyyy")
        listviewitem.SubItems.Add(selectedate)

        listviewitem.SubItems.Add(cboTime.SelectedItem.ToString())

        listviewitem.SubItems.Add(cboType.SelectedItem.ToString())
        listviewitem.SubItems.Add(nTickets.Value.ToString())

        lstCart.Items.Add(listviewitem)
    End Sub

    'So fun to check if all field have something inside
    Private Sub addenabler()
        If cboParques.SelectedIndex <> -1 OrElse cboProg.SelectedIndex <> -1 OrElse cboExp.SelectedIndex <> -1 AndAlso
           cboTime.SelectedIndex <> -1 AndAlso cboType.SelectedIndex <> -1 AndAlso cboArea.SelectedIndex <> -1 Then

            btnAdd.Enabled = True
        End If
    End Sub

    'Will enable/disable the Finish button based on what the fuck i want (and commonsense too btw)
    Private Sub finishenabler(enabledisable As Boolean)
        If enabledisable = True Then
            btnFinish.Enabled = True
        Else
            btnFinish.Enabled = False
        End If
    End Sub

    Private Function ticketprice() As Decimal
        Select Case cboType.SelectedIndex
            Case 0
                Return adultticket * nTickets.Value
            Case 1
                Return youngticket * nTickets.Value
            Case 2
                Return oldticket * nTickets.Value
            Case 3
                Return childticket * nTickets.Value
            Case 4
                Return familyticket * nTickets.Value
        End Select
    End Function

    Private Sub subtractlabel()
        Dim selecteditem As ListViewItem = lstCart.SelectedItems(0)
        Dim infoticket As String = selecteditem.SubItems(4).Text
        Dim infoamount As Integer = selecteditem.SubItems(5).Text
        Dim tosubtract As Decimal
        Dim currentprice As Decimal = Decimal.Parse(lblPrice.Text)


        Select Case infoticket
            Case "Adulto (18-64) 17.00 €"
                tosubtract = currentprice - (infoamount * adultticket)
            Case "Jovem (6-17)  15.30 €"
                tosubtract = currentprice - (infoamount * youngticket)
            Case "Sénior (65+)  15.30 €"
                tosubtract = currentprice - (infoamount * oldticket)
            Case "Criança (<6) 0.00 €"
                tosubtract = currentprice - (infoamount * childticket)
            Case "Família (2 Adultos 18-64 + 2 Jovens 6-17) 55.25 €"
                tosubtract = currentprice - (infoamount * familyticket)
        End Select
        lblPrice.Text = tosubtract


    End Sub

    'The "i have no idea what the fuck im doing" classic (somehow it works)(efficiency is propbably shit)
    'This will collect all the information in the listview and fill the current instance of Encomenda
    Sub filltheobject()
        Dim data As String
        'Add the stuff in the Area column
        For Each item As ListViewItem In lstCart.Items
            purchaselist(currentpurchases).Area.Add(item.Text)
        Next
        'Add the stuff in Atividade column
        For Each item As ListViewItem In lstCart.Items
            data = item.SubItems(1).Text
            purchaselist(currentpurchases).Activity.Add(data)
        Next
        'Add the stuff in Data column
        For Each item As ListViewItem In lstCart.Items
            data = item.SubItems(2).Text
            purchaselist(currentpurchases).Date_.Add(data)
        Next
        'Add the stuff in Hora column
        For Each item As ListViewItem In lstCart.Items
            data = item.SubItems(3).Text
            purchaselist(currentpurchases).Time.Add(data)
        Next
        'Add the stuff in Bilhete column
        For Each item As ListViewItem In lstCart.Items
            data = item.SubItems(4).Text
            purchaselist(currentpurchases).Type.Add(data)
        Next
        'Add the stuff in Qtd column
        For Each item As ListViewItem In lstCart.Items
            data = item.SubItems(5).Text
            purchaselist(currentpurchases).Ntickets.Add(CInt(data))
        Next
        purchaselist(currentpurchases).Price = lblPrice.Text.ToString(CultureInfo.InvariantCulture)
    End Sub
End Class