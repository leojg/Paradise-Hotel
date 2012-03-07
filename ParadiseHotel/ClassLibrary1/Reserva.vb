Public Class Reserva
    Dim idRes As Integer
    Dim objHab As Habitacion
    Dim colHuespedes As Hashtable
    Dim objResponsable As Huesped
    Dim CIn As Date
    Dim COut As Date
    Dim reserva As Integer
    Dim frealizacion As Date
    Dim total As Integer
    Dim fechaPagoSaldo As Date
    Dim montoRembolsado As Integer
    Dim objPers As PersReserva

    Public Sub guardame()
        objPers.guardar(Me)
    End Sub

    Public Sub cancelame()
        objPers.modificar(Me)
    End Sub

    Public Sub eliminame()
        objPers.eliminar(Me)
    End Sub

    Public Sub modificame()
        objPers.modificar(Me)
    End Sub

    Public Function devolverHuespedes() As Hashtable
        Return Me.colHuespedes
    End Function

    Public Sub New(ByVal objResp As Huesped, ByVal id As Integer, ByVal objhab As Habitacion, ByVal colHuespedes As Hashtable, ByVal cin As Date, ByVal cout As Date, ByVal Reserva As Integer, ByVal fRealizacion As Date, ByVal total As Integer)
        Me.idRes = id
        Me.objHab = objhab
        Me.colHuespedes = colHuespedes
        Me.CIn = cin
        Me.COut = cout
        Me.reserva = Reserva
        Me.frealizacion = fRealizacion
        Me.total = total
        Me.montoRembolsado = -1
        Me.objResponsable = objResp
        objPers = New PersReserva
    End Sub

    Public Property Resposalbe() As Huesped
        Get
            Return Me.objResponsable
        End Get
        Set(ByVal value As Huesped)
            objResponsable = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return "Reserva: " & idRes & " - Hab.: " & objHab.Numero & " Desde: " & CIn & " - Hasta: " & COut
    End Function

    Public Property Id() As Integer
        Get
            Return idRes
        End Get
        Set(ByVal value As Integer)
            idRes = value
        End Set
    End Property

    Public Property Habitacion() As Habitacion
        Get
            Return objHab
        End Get
        Set(ByVal value As Habitacion)
            objHab = value
        End Set
    End Property

    Public Property CheckIn() As Date
        Get
            Return CIn
        End Get
        Set(ByVal value As Date)
            CIn = value
        End Set
    End Property

    Public Property CheckOut() As Date
        Get
            Return COut
        End Get
        Set(ByVal value As Date)
            COut = value
        End Set
    End Property

    Public Property montoReserva() As Integer
        Get
            Return reserva
        End Get
        Set(ByVal value As Integer)
            Reserva = value
        End Set
    End Property

    Public Property montoTotal() As Integer
        Get
            Return Total
        End Get
        Set(ByVal value As Integer)
            total = value
        End Set
    End Property

    Public Property FechaPago() As Date
        Get
            Return fechaPagoSaldo
        End Get
        Set(ByVal value As Date)
            fechaPagoSaldo = value
        End Set
    End Property

    Public Property Rembolso() As Integer
        Get
            Return montoRembolsado
        End Get
        Set(ByVal value As Integer)
            montoRembolsado = value
        End Set
    End Property

    Public Property fechaRealizacion() As Date
        Get
            Return frealizacion
        End Get
        Set(ByVal value As Date)
            frealizacion = value
        End Set
    End Property


End Class
