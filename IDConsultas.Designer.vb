<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IDConsultas
    Inherits BaseClass

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lstCart = New System.Windows.Forms.ListView()
        Me.clmArea = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clmActivity = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clmDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clmTime = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clmType = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clmAmount = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnVerificar = New System.Windows.Forms.Button()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstCart
        '
        Me.lstCart.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clmArea, Me.clmActivity, Me.clmDate, Me.clmTime, Me.clmType, Me.clmAmount})
        Me.lstCart.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstCart.FullRowSelect = True
        Me.lstCart.GridLines = True
        Me.lstCart.HideSelection = False
        Me.lstCart.Location = New System.Drawing.Point(362, 448)
        Me.lstCart.Name = "lstCart"
        Me.lstCart.Size = New System.Drawing.Size(981, 500)
        Me.lstCart.TabIndex = 42
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
        Me.clmActivity.Width = 394
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
        Me.clmType.Width = 123
        '
        'clmAmount
        '
        Me.clmAmount.Text = "Qtd."
        Me.clmAmount.Width = 127
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(699, 82)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(255, 20)
        Me.Label7.TabIndex = 45
        Me.Label7.Text = """Património da Humanidade desde 1995"""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(124, 152)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(855, 45)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "Para mais informações indique-nos o seu ID de compra:"
        '
        'txtID
        '
        Me.txtID.BackColor = System.Drawing.Color.Silver
        Me.txtID.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(157, 285)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(124, 35)
        Me.txtID.TabIndex = 50
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Gold
        Me.PictureBox4.Location = New System.Drawing.Point(35, 232)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(976, 16)
        Me.PictureBox4.TabIndex = 49
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Final_Project.My.Resources.Resources.idicon
        Me.PictureBox3.Location = New System.Drawing.Point(35, 142)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(83, 73)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 47
        Me.PictureBox3.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Black
        Me.PictureBox1.Location = New System.Drawing.Point(688, 105)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(276, 10)
        Me.PictureBox1.TabIndex = 46
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Final_Project.My.Resources.Resources.Logo
        Me.PictureBox2.Location = New System.Drawing.Point(697, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(257, 90)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 44
        Me.PictureBox2.TabStop = False
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
        Me.btnBack.TabIndex = 43
        Me.btnBack.TabStop = False
        Me.btnBack.Text = "Voltar"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(30, 288)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 30)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "O seu ID:"
        '
        'btnVerificar
        '
        Me.btnVerificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnVerificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVerificar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerificar.Location = New System.Drawing.Point(80, 375)
        Me.btnVerificar.Name = "btnVerificar"
        Me.btnVerificar.Size = New System.Drawing.Size(134, 46)
        Me.btnVerificar.TabIndex = 52
        Me.btnVerificar.Text = "Verificar"
        Me.btnVerificar.UseVisualStyleBackColor = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Black
        Me.PictureBox5.Location = New System.Drawing.Point(25, 335)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(276, 10)
        Me.PictureBox5.TabIndex = 53
        Me.PictureBox5.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(357, 391)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 30)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "Total Pago:"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.Location = New System.Drawing.Point(485, 391)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(25, 30)
        Me.lblPrice.TabIndex = 55
        Me.lblPrice.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(611, 391)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(25, 30)
        Me.Label5.TabIndex = 56
        Me.Label5.Text = "€"
        '
        'IDConsultas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1599, 1026)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.btnVerificar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lstCart)
        Me.Name = "IDConsultas"
        Me.Text = "IDConsultas"
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents lstCart As ListView
    Friend WithEvents clmArea As ColumnHeader
    Friend WithEvents clmActivity As ColumnHeader
    Friend WithEvents clmDate As ColumnHeader
    Friend WithEvents clmTime As ColumnHeader
    Friend WithEvents clmType As ColumnHeader
    Friend WithEvents clmAmount As ColumnHeader
    Friend WithEvents btnBack As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnVerificar As Button
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents Label5 As Label
End Class
