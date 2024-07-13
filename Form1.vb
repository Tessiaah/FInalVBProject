Public Class Form1
    Inherits BaseClass
    Private frmEncomendar As Encomendar
    Private frmConsultas As Consultas

    Dim currentimg As Integer = 0
    ReadOnly demoimages() As Image = {My.Resources.kekinsanebanner,
                                      My.Resources.banner2,
                                      My.Resources.banner3,
                                      My.Resources.banner4}

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmEncomendar = New Encomendar(Me) 'Passing this instance to the constructor
        frmConsultas = New Consultas(Me) 'Passing this instance to the constructor
        pbxMain.Image = demoimages(0)
        lblImagePos.Text = currentimg + 1 & "/4"
    End Sub


    '⠀⠀⠀⠀⠀⢀⡤⠖⢊⡩⠟⣋⣉⣉⡉⠳⡒⢄⠀⠀⣀⡤⠴⠒⠒⠀⠀⠐⠲⢄⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
    '⠀⠀⠀⢀⠶⠉⠀⡴⠋⠀⠈⠀⠀⠈⢯⠆⣿⡤⠖⠋⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠙⠯⣉⠉⡍⠒⠢⣄⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
    '⠀⠀⣰⠋⠀⠀⣸⠁⠀⢠⠀⠀⣀⣠⡾⠛⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠓⢄⠉⠉⠒⠛⠲⢤⣀⠀⠀⠀⠀⠀⠀⠀⠀
    '⠀⢠⡟⠀⠀⢀⡟⠀⢀⣸⠾⢋⣵⠏⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢬⣣⡀⠀⠀⠀⠀⠈⠓⠦⡀⠀⠀⠀⠀⠀
    '⠀⣾⠀⠀⠀⢸⡇⠀⣠⡶⢖⣿⠁⠀⠀⠀⠀⠀⠀⡰⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣠⣾⣷⣽⣿⡛⠒⢤⡀⠀⠀⠀⠈⠢⡀⠀⠀⠀
    '⠀⣿⠀⠀⠀⠈⠓⠋⣩⠖⣿⡏⠀⠀⠀⠀⠀⢀⠞⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣴⡿⠋⠉⠀⠀⠺⣿⣆⠀⠙⣄⠀⠀⠈⣆⢹⡄⠀⠀
    '⢸⡟⠧⣀⣀⡤⠤⠞⠁⣰⣿⡇⠀⠀⠀⠀⣰⠏⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⡴⣫⠋⠀⠀⠀⠀⠀⠀⠈⢻⡇⠀⢹⡀⠀⠀⠘⣎⡇⠀⠀
    '⢸⣿⣄⠀⠀⠀⠀⠀⣰⡿⣿⢧⠀⠀⠀⢪⠏⠀⠀⠀⠀⠀⠀⠀⠀⠀⡠⠋⡼⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⢻⠀⢨⣿⡄⠀⠀⢹⡇⠀⠀
    '⠈⢿⣍⠓⢦⠤⢴⣾⣿⡇⣿⠘⣆⠀⢠⡟⠀⠀⠀⠀⣠⠂⠀⠀⣠⠞⢀⡼⠡⠤⠤⠤⢄⣀⡀⠀⠀⠀⠀⠸⡇⢸⠃⢻⡄⠀⠈⡇⠀⠀
    '⠀⠀⠙⢯⣠⢴⡟⣸⢻⠃⣿⠀⠘⣷⡾⠀⠀⠀⢀⡜⢁⡠⢢⡞⠁⣰⡟⠀⠀⠀⠀⠀⠀⠀⠉⠓⠶⣦⣤⣀⣷⠞⠀⠈⢻⡀⠀⡇⠀⠀
    '⠀⠀⠀⠀⠀⢸⡇⣿⣼⠀⢿⡄⠀⣿⠃⠀⠀⠴⢋⣴⠏⢀⡞⠀⣸⠏⠀⠀⠀⠀⠀⠤⠤⠤⠤⢤⡤⠀⠈⣹⠏⠀⠀⣠⣿⢷⣸⠃⠀⠀
    '⠀⠀⠀⠀⠀⢸⣧⡿⣿⠀⠸⣇⢀⡿⠀⠀⠤⢒⡽⠋⢀⡜⢀⣴⡟⠐⠤⣤⣤⣶⡶⠶⣶⣶⣦⡬⠅⠀⣠⠟⠀⢀⠔⢹⡿⣼⡏⠀⠀⠀
    '⠀⠀⠀⠀⠠⠿⠋⠀⣿⠀⢠⡿⢚⠳⢤⡤⠶⠋⠀⠀⢊⡴⠋⣼⠁⠀⠀⠀⠲⡄⠀⠀⣿⣿⡭⠛⠉⠉⠀⠀⢠⣿⣾⣿⣷⣿⡇⠀⠀⠀
    '⠀⠀⠀⠀⠀⠀⠀⠀⣿⡀⢸⡇⠟⢹⠢⣌⠳⣤⣴⢾⠋⠀⢠⡇⠀⠀⠀⠀⠀⠙⠓⠤⠿⣿⣇⠀⠀⠀⠀⠀⢸⡄⣿⣿⠀⣿⡇⠀⠀⠀
    '⠀⠀⠀⠀⠀⠀⠀⠀⢹⣧⠐⢷⠀⣼⠐⡾⢓⡟⠀⡏⢀⡄⣸⠁⠀⠀⠀⠀⠀⠀⠀⠀⠁⠀⠈⠉⠀⠀⠀⠀⠀⠙⣿⣯⡄⣿⡇⠀⠀⠀
    '⠀⠀⠀⠀⠀⠀⠀⠀⠈⢿⣧⡸⡆⠙⡘⢧⣸⡇⠀⠃⣼⡀⢿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠙⣷⣬⡇⠀⠀⠀
    '⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠛⠧⢽⣦⡈⠢⢿⡇⠀⠀⣿⣧⢸⠀⠀⠀⣤⣄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣾⠃⣿⡇⠀⠀⠀
    '⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠉⠢⣼⡇⠐⢸⡿⠘⣿⡄⠀⢠⠾⠵⣷⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣸⡟⠀⢹⠀⠀⠀⠀
    '⠀⠀⠀⠀⠀⠀⠀⢀⣀⣀⣠⡤⣤⣤⣄⣀⣸⡇⠀⢸⣧⠀⠈⢣⣠⠋⠀⣸⠃⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⢿⠏⡷⠀⣿⠀⠀⠀⠀
    '⠀⠀⠀⠀⣠⣴⣚⣿⡷⠶⠟⠛⠛⠛⠛⠛⣿⡇⠀⢸⡏⢷⣄⡼⠁⠀⢰⠃⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⡏⠀⣿⢀⡏⠀⠀⠀⠀
    '⠀⠀⠀⣾⣿⣿⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣷⠀⢸⡇⢀⠟⠁⠀⣠⠟⠦⣀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡾⠀⠀⢸⣸⠃⠀⠀⠀⠀
    '⠀⠀⢰⡟⢸⡏⠀⠀⠀⠀⠀⠀⡀⠀⠀⠀⢸⡿⣆⢸⡷⠋⠀⠀⣴⡁⠀⠀⠉⠙⠓⠲⠤⣤⣤⣤⣄⣀⣀⣠⠇⠀⠀⣸⡏⠀⠀⠀⠀⠀
    '⠀⠀⣾⠀⠘⣷⠀⠀⠀⠀⠂⠀⢀⣠⡤⠶⡯⠉⢷⣀⣷⡀⠀⡼⡏⠱⡄⠀⠀⠀⠀⠀⠀⢸⡏⠛⠛⡦⣄⠀⠀⠀⢀⡿⠀⠀⠀⠀⠀⠀
    '⠀⣼⠇⠀⠀⣿⡄⠀⢔⣶⠶⠚⠛⠁⠀⠀⠀⠀⠀⢻⣷⠛⣼⠁⢳⡀⠹⡄⠀⠀⠀⠀⠀⣿⢷⣀⠀⠈⠊⠙⠲⣤⣞⡀⠀⠀⠀⠀⠀⠀
    '⠖⣿⡀⠀⠀⠘⣿⣠⣿⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠹⣷⣌⠳⡄⣷⡀⠘⣆⠀⠀⠀⠀⣿⡆⠙⠻⢦⣤⣶⠾⠋⠀⠋⢛⣗⣲⣦⣤⡄
    '⠀⠙⣧⡀⠀⠀⠹⣿⡟⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⣿⣦⠀⠈⠻⣧⠀⠈⢦⠀⢀⣠⣿⣿⡆⠀⠀⠈⠙⠛⣶⣤⡴⠶⠛⠋⣡⣾⠁
    '⠀⠀⠈⢷⡄⠀⠀⣿⠃⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡿⠛⠁⢳⡄⠀⠙⢷⡀⠈⢻⡟⠉⠁⢘⣿⠶⣶⣤⠶⠛⣩⡴⠊⠀⢀⣼⣻⡇⠀
    '⡆⠀⠀⠈⠻⣦⣄⡿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠷⠀⠀⣼⣿⣦⡀⠀⠑⢄⡀⠹⣦⣴⣾⡷⠟⠋⠀⣠⠾⠋⠀⢀⣠⠾⠛⠉⢉⡍
    '⠹⣄⢀⣤⣾⠞⢻⠇⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣀⣠⠤⠤⠾⠿⠿⠿⠷⠄⠀⠀⠈⠓⠬⠻⣇⠀⠀⣠⡞⠁⠀⠀⢀⡾⠁⠀⠀⣠⠞⠁
    '⠀⢈⣿⠟⠁⡴⠋⠀⠀⠀⠀⠀⠀⠀⠀⢺⣿⠛⢀⣀⣀⣀⣀⣀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠙⢿⡁⠀⠀⠀⣰⣏⠀⠀⢀⡴⠋⠀⠀
    '⣴⡿⠋⠀⣸⠃⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣠⣿⣭⣙⡿⠗⠛⠛⠛⠛⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠉⠳⣦⡾⠁⠈⠳⣦⠞⠀⠀⠀⠀


    'Buttons Begin Here :DD
    Private Sub btnSkipRight_Click(sender As Object, e As EventArgs) Handles btnSkipRight.Click
        changeimage("+")
    End Sub

    Private Sub btnSkipLeft_Click(sender As Object, e As EventArgs) Handles btnSkipLeft.Click
        changeimage("-")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub btnCompra_Click(sender As Object, e As EventArgs) Handles btnCompra.Click
        formchanger(frmEncomendar)
    End Sub

    Private Sub btnConsultas_Click(sender As Object, e As EventArgs) Handles btnConsultas.Click
        formchanger(frmConsultas)
    End Sub

    'Makes the other random forms go back to this if i pass the form as a parameter for the constructor
    Public Sub resetHomePage()
        Controls.Clear()
        InitializeComponent()
    End Sub

    'Controls the images based on arrow click n shit like that :D
    Private Sub changeimage(type As String)
        If type = "+" Then
            currentimg += 1
            If currentimg > 3 Then
                currentimg = 0
            End If
            lblImagePos.Text = currentimg + 1 & "/4"
            pbxMain.Image = demoimages(currentimg)
        Else
            currentimg -= 1
            If currentimg < 0 Then
                currentimg = 3
            End If
            lblImagePos.Text = currentimg + 1 & "/4"
            pbxMain.Image = demoimages(currentimg)
        End If

    End Sub


End Class
