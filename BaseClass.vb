Public Class BaseClass
    Inherits Form

    Public appname As String = "Parques de Sintra"

    'Random ahh sub that changes forms :skull:
    Public Sub formchanger(form As Form)
        Controls.Clear()
        form.TopLevel = False
        form.FormBorderStyle = FormBorderStyle.None
        form.Dock = DockStyle.Fill
        Controls.Add(form)
        form.Show()
    End Sub


    Private Sub InitializeComponent()
        Me.SuspendLayout()
        '
        'BaseClass
        '
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Name = "BaseClass"
        Me.ResumeLayout(False)

    End Sub


End Class
