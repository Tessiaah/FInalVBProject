Public Class Encomenda
    Private _id As Integer = currentpurchases
    Private _price As String = ""
    'Private _tickets As New List(Of Ticket) 'Stores info of all tickets
    Private _area As New List(Of String)
    Private _ntickets As New List(Of Integer)
    Private _date As New List(Of String)
    Private _time As New List(Of String)
    Private _activity As New List(Of String)
    Private _type As New List(Of String)



    'Encapsulation asdasjkpoidsahjklçasdioçjhasdklçjhasd

    Public Property Area As List(Of String)
        Get
            Return _area
        End Get
        Set(value As List(Of String))
            _area = value
        End Set

    End Property
    Public Property Price As String
        Get
            Return _price
        End Get
        Set(value As String)
            _price = value
        End Set
    End Property

    Public Property Ntickets As List(Of Integer)
        Get
            Return _ntickets
        End Get
        Set(value As List(Of Integer))
            _ntickets = value
        End Set
    End Property

    Public Property Date_ As List(Of String)
        Get
            Return _date
        End Get
        Set(value As List(Of String))
            _date = value
        End Set
    End Property

    Public Property Time As List(Of String)
        Get
            Return _time
        End Get
        Set(value As List(Of String))
            _time = value
        End Set
    End Property

    Public Property Activity As List(Of String)
        Get
            Return _activity
        End Get
        Set(value As List(Of String))
            _activity = value
        End Set
    End Property

    Public Property Type As List(Of String)
        Get
            Return _type
        End Get
        Set(value As List(Of String))
            _type = value
        End Set
    End Property

    'Allows the code to just read what is inside the _id field, as its only ever changed with the call to idgenerator()
    Public ReadOnly Property ID As Integer
        Get
            Return _id
        End Get
    End Property
End Class
