<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Encomendar
    Inherits BaseClass

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.datePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblAtividade = New System.Windows.Forms.Label()
        Me.cboParques = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblType = New System.Windows.Forms.Label()
        Me.cboArea = New System.Windows.Forms.ComboBox()
        Me.cboExp = New System.Windows.Forms.ComboBox()
        Me.cboProg = New System.Windows.Forms.ComboBox()
        Me.cboTime = New System.Windows.Forms.ComboBox()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.cboType = New System.Windows.Forms.ComboBox()
        Me.nTickets = New System.Windows.Forms.NumericUpDown()
        Me.lblAmount = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lstCart = New System.Windows.Forms.ListView()
        Me.clmArea = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clmActivity = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clmDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clmTime = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clmType = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clmAmount = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnFinish = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.pbxActivity = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.iconAmount = New System.Windows.Forms.PictureBox()
        Me.iconType = New System.Windows.Forms.PictureBox()
        Me.iconTime = New System.Windows.Forms.PictureBox()
        Me.iconDate = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.iconAtividade = New System.Windows.Forms.PictureBox()
        Me.iconArea = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.nTickets, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxActivity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iconAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iconType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iconTime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iconDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iconAtividade, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iconArea, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(124, 152)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(536, 45)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Está um passo mais perto de nós..."
        '
        'datePicker
        '
        Me.datePicker.CalendarMonthBackground = System.Drawing.Color.Gold
        Me.datePicker.CalendarTitleBackColor = System.Drawing.Color.Gold
        Me.datePicker.CalendarTrailingForeColor = System.Drawing.Color.Gold
        Me.datePicker.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datePicker.Location = New System.Drawing.Point(12, 411)
        Me.datePicker.MaxDate = New Date(2025, 12, 31, 0, 0, 0, 0)
        Me.datePicker.MinDate = New Date(2024, 6, 4, 20, 35, 27, 0)
        Me.datePicker.Name = "datePicker"
        Me.datePicker.Size = New System.Drawing.Size(346, 35)
        Me.datePicker.TabIndex = 7
        Me.datePicker.Value = New Date(2024, 6, 4, 20, 35, 27, 0)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(57, 282)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(159, 25)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Selecione a área:"
        '
        'lblAtividade
        '
        Me.lblAtividade.AutoSize = True
        Me.lblAtividade.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAtividade.Location = New System.Drawing.Point(448, 282)
        Me.lblAtividade.Name = "lblAtividade"
        Me.lblAtividade.Size = New System.Drawing.Size(231, 25)
        Me.lblAtividade.TabIndex = 9
        Me.lblAtividade.Text = "Selecione uma atividade:"
        '
        'cboParques
        '
        Me.cboParques.BackColor = System.Drawing.Color.Gold
        Me.cboParques.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboParques.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboParques.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboParques.FormattingEnabled = True
        Me.cboParques.Items.AddRange(New Object() {"Parque e Palácio Nacional da Pena", "Visita ao Palácio Nacional da Pena", "Visita ao Chalet da Condessa d'Edla", "Parque e Palácio de Monserrate", "Visita ao Parque e Palácio de Monserrate", "Castelo dos Mouros", "Visita ao Castelo dos Mouros", "Palácio Nacional de Sintra", "Visita ao Palácio Nacional de Sintra", "Palácio Nacional e Jardins de Queluz", "Visita ao Palácio Nacional e Jardins de Queluz", "Visita ao Pavilhão D. Maria I", "Escola Portuguesa de Arte Equestre", "Jardins de Queluz", "Convento dos Capuchos", "Visita ao Convento dos Capuchos", "Parque da Pena", "Farol do Cabo da Roca"})
        Me.cboParques.Location = New System.Drawing.Point(403, 315)
        Me.cboParques.Name = "cboParques"
        Me.cboParques.Size = New System.Drawing.Size(416, 33)
        Me.cboParques.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(699, 82)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(255, 20)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = """Património da Humanidade desde 1995"""
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblType.Location = New System.Drawing.Point(57, 485)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(149, 25)
        Me.lblType.TabIndex = 20
        Me.lblType.Text = "Tipo de Bilhete:"
        '
        'cboArea
        '
        Me.cboArea.BackColor = System.Drawing.Color.Gold
        Me.cboArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboArea.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboArea.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboArea.FormattingEnabled = True
        Me.cboArea.Items.AddRange(New Object() {"Parques e Monumentos", "Experiências", "Programação Cultural"})
        Me.cboArea.Location = New System.Drawing.Point(12, 315)
        Me.cboArea.Name = "cboArea"
        Me.cboArea.Size = New System.Drawing.Size(297, 33)
        Me.cboArea.TabIndex = 21
        '
        'cboExp
        '
        Me.cboExp.BackColor = System.Drawing.Color.Gold
        Me.cboExp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboExp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboExp.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboExp.FormattingEnabled = True
        Me.cboExp.Items.AddRange(New Object() {"Passeios de Pónei no Parque da Pena", "Caça ao Tesouro em Monserrate", "Caça ao Tesouro no Parque da Pena", "Bastidores Da Escola Portuguesa de Arte", "A Floresta dos Frades", "Jogos. Árvores. Animais e Outros Que Tais", "O Diário da Princesa", "O Dia-a-Dia dos Animais", "À Conquista do Castelo", "O Tesouro do Rei", "Uma Aventura no Palácio da Pena", "Enigmas do Palácio", "Visita guiada ao Santuário da Peninha", "Visita ao Centro de Interpretação da Nature", "Pão. Coentros e Bicharada", "Espaços e vivências da Casa Rea", "No Palácio de Sintra com a Rainha", "Os Ajudantes de Jardim", "A Caçada", "O Outro Lado do Palácio Nacional de Sintra", "Jardim Botânico de Queluz", "Sintra ao Luar", "Vamos conhecer… os Anfíbios", "Os produtos da colmeia", "Vamos conhecer os Pirilampos", "Ateliê de Tintas Silvestres", "Ateliê de Arte Botânica", "A primavera no Parque", "À Noite no Convento dos Capuchos", "Os produtos da colmeia: o que é o mel?", "Um Dia Quero Ser Apicultor", "À Noite no Jardim", "Gestão de Invasoras lenhosas", "A Mata relíquia do Convento dos Capuchos", "Rendez vous aux jardins", "As Pragas dos Jardins de Queluz", "Oficina de Verão", "Visita guiada à Pena ", "Visita guiada a Monserrate "})
        Me.cboExp.Location = New System.Drawing.Point(403, 315)
        Me.cboExp.Name = "cboExp"
        Me.cboExp.Size = New System.Drawing.Size(416, 33)
        Me.cboExp.TabIndex = 22
        '
        'cboProg
        '
        Me.cboProg.BackColor = System.Drawing.Color.Gold
        Me.cboProg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboProg.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProg.FormattingEnabled = True
        Me.cboProg.Items.AddRange(New Object() {"Concerto de apresentação Jazz", "Galas de Arte Equestre", "Arte de Marialva: o ensino do cavalo", "A Baixa Escola e o trabalho à guia", "Princípios básicos e treino do cavalo", "Criação e seleção do cavalo Lusitano", "Símbolo da Arte Equestre Portuguesa", "Deuses e Deusas, Nereides e Tritões"})
        Me.cboProg.Location = New System.Drawing.Point(403, 315)
        Me.cboProg.Name = "cboProg"
        Me.cboProg.Size = New System.Drawing.Size(416, 33)
        Me.cboProg.TabIndex = 23
        '
        'cboTime
        '
        Me.cboTime.BackColor = System.Drawing.Color.Gold
        Me.cboTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboTime.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTime.FormattingEnabled = True
        Me.cboTime.Items.AddRange(New Object() {"12:00", "14:30", "15:45", "16:30", "18:00"})
        Me.cboTime.Location = New System.Drawing.Point(403, 411)
        Me.cboTime.Name = "cboTime"
        Me.cboTime.Size = New System.Drawing.Size(360, 33)
        Me.cboTime.TabIndex = 24
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(57, 380)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(195, 25)
        Me.lblDate.TabIndex = 25
        Me.lblDate.Text = "Selecione a sua data:"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(448, 380)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(197, 25)
        Me.lblTime.TabIndex = 27
        Me.lblTime.Text = "Selecione a sua hora:"
        '
        'cboType
        '
        Me.cboType.BackColor = System.Drawing.Color.Gold
        Me.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboType.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboType.FormattingEnabled = True
        Me.cboType.Items.AddRange(New Object() {"Adulto (18-64) 17.00 €", "Jovem (6-17)  15.30 €", "Sénior (65+)  15.30 €", "Criança (<6) 0.00 €", "Família (2 Adultos 18-64 + 2 Jovens 6-17) 55.25 €"})
        Me.cboType.Location = New System.Drawing.Point(12, 516)
        Me.cboType.Name = "cboType"
        Me.cboType.Size = New System.Drawing.Size(297, 33)
        Me.cboType.TabIndex = 30
        '
        'nTickets
        '
        Me.nTickets.BackColor = System.Drawing.Color.Gold
        Me.nTickets.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nTickets.Location = New System.Drawing.Point(403, 516)
        Me.nTickets.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nTickets.Name = "nTickets"
        Me.nTickets.ReadOnly = True
        Me.nTickets.Size = New System.Drawing.Size(216, 33)
        Me.nTickets.TabIndex = 31
        Me.nTickets.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblAmount
        '
        Me.lblAmount.AutoSize = True
        Me.lblAmount.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmount.Location = New System.Drawing.Point(448, 485)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(121, 25)
        Me.lblAmount.TabIndex = 32
        Me.lblAmount.Text = "Quantidade:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(1032, 196)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(183, 50)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Carrinho:"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.Location = New System.Drawing.Point(1221, 196)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(43, 50)
        Me.lblPrice.TabIndex = 39
        Me.lblPrice.Text = "0"
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Silver
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(12, 583)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(175, 60)
        Me.btnAdd.TabIndex = 40
        Me.btnAdd.Text = "ADICIONAR"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'lstCart
        '
        Me.lstCart.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clmArea, Me.clmActivity, Me.clmDate, Me.clmTime, Me.clmType, Me.clmAmount})
        Me.lstCart.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstCart.FullRowSelect = True
        Me.lstCart.GridLines = True
        Me.lstCart.HideSelection = False
        Me.lstCart.Location = New System.Drawing.Point(882, 315)
        Me.lstCart.Name = "lstCart"
        Me.lstCart.Size = New System.Drawing.Size(705, 500)
        Me.lstCart.TabIndex = 41
        Me.lstCart.UseCompatibleStateImageBehavior = False
        Me.lstCart.View = System.Windows.Forms.View.Details
        '
        'clmArea
        '
        Me.clmArea.Text = "Área"
        Me.clmArea.Width = 170
        '
        'clmActivity
        '
        Me.clmActivity.Text = "Atividade"
        Me.clmActivity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.clmActivity.Width = 250
        '
        'clmDate
        '
        Me.clmDate.Text = "Data"
        Me.clmDate.Width = 100
        '
        'clmTime
        '
        Me.clmTime.Text = "Hora"
        '
        'clmType
        '
        Me.clmType.Text = "Bilhete"
        '
        'clmAmount
        '
        Me.clmAmount.Text = "Qtd."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(1526, 196)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 50)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "€"
        '
        'btnFinish
        '
        Me.btnFinish.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnFinish.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFinish.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFinish.Location = New System.Drawing.Point(882, 834)
        Me.btnFinish.Name = "btnFinish"
        Me.btnFinish.Size = New System.Drawing.Size(175, 60)
        Me.btnFinish.TabIndex = 44
        Me.btnFinish.Text = "Finalizar compra"
        Me.btnFinish.UseVisualStyleBackColor = False
        '
        'btnRemove
        '
        Me.btnRemove.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemove.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.Location = New System.Drawing.Point(1412, 834)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(175, 60)
        Me.btnRemove.TabIndex = 45
        Me.btnRemove.Text = "Remover"
        Me.btnRemove.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(26, 674)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(171, 50)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "Como é?"
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Gold
        Me.PictureBox4.Location = New System.Drawing.Point(12, 727)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(276, 10)
        Me.PictureBox4.TabIndex = 47
        Me.PictureBox4.TabStop = False
        '
        'pbxActivity
        '
        Me.pbxActivity.Location = New System.Drawing.Point(208, 752)
        Me.pbxActivity.Name = "pbxActivity"
        Me.pbxActivity.Size = New System.Drawing.Size(437, 262)
        Me.pbxActivity.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxActivity.TabIndex = 42
        Me.pbxActivity.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.BackColor = System.Drawing.Color.Black
        Me.PictureBox8.Location = New System.Drawing.Point(896, 249)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(471, 10)
        Me.PictureBox8.TabIndex = 38
        Me.PictureBox8.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = Global.Final_Project.My.Resources.Resources.Cart
        Me.PictureBox7.Location = New System.Drawing.Point(896, 142)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(130, 130)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox7.TabIndex = 37
        Me.PictureBox7.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Gold
        Me.PictureBox5.Location = New System.Drawing.Point(847, 152)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(18, 775)
        Me.PictureBox5.TabIndex = 35
        Me.PictureBox5.TabStop = False
        '
        'iconAmount
        '
        Me.iconAmount.Image = Global.Final_Project.My.Resources.Resources.iconAmount
        Me.iconAmount.Location = New System.Drawing.Point(403, 485)
        Me.iconAmount.Name = "iconAmount"
        Me.iconAmount.Size = New System.Drawing.Size(39, 25)
        Me.iconAmount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.iconAmount.TabIndex = 33
        Me.iconAmount.TabStop = False
        '
        'iconType
        '
        Me.iconType.Image = Global.Final_Project.My.Resources.Resources.personicon
        Me.iconType.Location = New System.Drawing.Point(12, 485)
        Me.iconType.Name = "iconType"
        Me.iconType.Size = New System.Drawing.Size(39, 25)
        Me.iconType.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.iconType.TabIndex = 29
        Me.iconType.TabStop = False
        '
        'iconTime
        '
        Me.iconTime.Image = Global.Final_Project.My.Resources.Resources.clock_icon
        Me.iconTime.Location = New System.Drawing.Point(403, 380)
        Me.iconTime.Name = "iconTime"
        Me.iconTime.Size = New System.Drawing.Size(39, 25)
        Me.iconTime.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.iconTime.TabIndex = 28
        Me.iconTime.TabStop = False
        '
        'iconDate
        '
        Me.iconDate.Image = Global.Final_Project.My.Resources.Resources.callendar
        Me.iconDate.Location = New System.Drawing.Point(12, 380)
        Me.iconDate.Name = "iconDate"
        Me.iconDate.Size = New System.Drawing.Size(39, 25)
        Me.iconDate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.iconDate.TabIndex = 26
        Me.iconDate.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.Black
        Me.PictureBox6.Location = New System.Drawing.Point(688, 105)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(276, 10)
        Me.PictureBox6.TabIndex = 19
        Me.PictureBox6.TabStop = False
        '
        'iconAtividade
        '
        Me.iconAtividade.Image = Global.Final_Project.My.Resources.Resources.hiking_icon
        Me.iconAtividade.Location = New System.Drawing.Point(403, 282)
        Me.iconAtividade.Name = "iconAtividade"
        Me.iconAtividade.Size = New System.Drawing.Size(39, 25)
        Me.iconAtividade.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.iconAtividade.TabIndex = 12
        Me.iconAtividade.TabStop = False
        '
        'iconArea
        '
        Me.iconArea.Image = Global.Final_Project.My.Resources.Resources.area
        Me.iconArea.Location = New System.Drawing.Point(12, 282)
        Me.iconArea.Name = "iconArea"
        Me.iconArea.Size = New System.Drawing.Size(39, 25)
        Me.iconArea.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.iconArea.TabIndex = 11
        Me.iconArea.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Gold
        Me.PictureBox3.Location = New System.Drawing.Point(12, 230)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(751, 16)
        Me.PictureBox3.TabIndex = 6
        Me.PictureBox3.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Final_Project.My.Resources.Resources.ticketture
        Me.PictureBox1.Location = New System.Drawing.Point(35, 142)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(83, 73)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.White
        Me.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Segoe UI Emoji", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Image = Global.Final_Project.My.Resources.Resources.PikPng_com_back_arrow_png_2465368_resized
        Me.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBack.Location = New System.Drawing.Point(35, 24)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(121, 41)
        Me.btnBack.TabIndex = 3
        Me.btnBack.TabStop = False
        Me.btnBack.Text = "Voltar"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Final_Project.My.Resources.Resources.Logo
        Me.PictureBox2.Location = New System.Drawing.Point(697, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(257, 90)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'Encomendar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1599, 1026)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnFinish)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.pbxActivity)
        Me.Controls.Add(Me.lstCart)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.iconAmount)
        Me.Controls.Add(Me.lblAmount)
        Me.Controls.Add(Me.nTickets)
        Me.Controls.Add(Me.cboType)
        Me.Controls.Add(Me.iconType)
        Me.Controls.Add(Me.iconTime)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.iconDate)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.cboTime)
        Me.Controls.Add(Me.cboProg)
        Me.Controls.Add(Me.cboExp)
        Me.Controls.Add(Me.cboArea)
        Me.Controls.Add(Me.lblType)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.iconAtividade)
        Me.Controls.Add(Me.iconArea)
        Me.Controls.Add(Me.cboParques)
        Me.Controls.Add(Me.lblAtividade)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.datePicker)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.PictureBox2)
        Me.Name = "Encomendar"
        Me.Text = "Encomendar"
        CType(Me.nTickets, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxActivity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iconAmount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iconType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iconTime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iconDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iconAtividade, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iconArea, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnBack As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents datePicker As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents lblAtividade As Label
    Friend WithEvents cboParques As ComboBox
    Friend WithEvents iconArea As PictureBox
    Friend WithEvents iconAtividade As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents lblType As Label
    Friend WithEvents cboArea As ComboBox
    Friend WithEvents cboExp As ComboBox
    Friend WithEvents cboProg As ComboBox
    Friend WithEvents cboTime As ComboBox
    Friend WithEvents lblDate As Label
    Friend WithEvents iconDate As PictureBox
    Friend WithEvents lblTime As Label
    Friend WithEvents iconTime As PictureBox
    Friend WithEvents iconType As PictureBox
    Friend WithEvents cboType As ComboBox
    Friend WithEvents nTickets As NumericUpDown
    Friend WithEvents lblAmount As Label
    Friend WithEvents iconAmount As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents lblPrice As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents lstCart As ListView
    Friend WithEvents clmArea As ColumnHeader
    Friend WithEvents clmActivity As ColumnHeader
    Friend WithEvents clmDate As ColumnHeader
    Friend WithEvents clmTime As ColumnHeader
    Friend WithEvents clmType As ColumnHeader
    Friend WithEvents clmAmount As ColumnHeader
    Friend WithEvents pbxActivity As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnFinish As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox4 As PictureBox
End Class
