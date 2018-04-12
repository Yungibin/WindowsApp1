Public Class Car
    Inherits Vehicle

    Private Shared STD_DISPLACEMENT() As Integer = {1000, 1500, 2000, 2500, 3000, 3500}
    Private Shared STD_TAX() As Integer = {29500, 34500, 39500, 45000, 51000, 58000, 66500}

    Private Const MILEAGE As Double = 5.38
    Private Const VARIABLE_NAME As String = "排気量"
    Private Const VARIABLE_UNIT As String = "cc"

    Public Sub New(ByVal fName As String, ByVal fPrice As Integer, ByVal fVariable As Integer)
        MyBase.New(fName, fPrice, fVariable)
    End Sub

    Public Overrides ReadOnly Property VehicleTax As Integer
        Get
            Dim i As Integer
            For i = 0 To STD_DISPLACEMENT.Length - 1
                If fVariable <= STD_DISPLACEMENT(i) Then
                    Exit For
                End If
            Next

            Return STD_TAX(i)
        End Get
    End Property

    Public Overrides ReadOnly Property VariableName As String
        Get
            Return VARIABLE_NAME
        End Get
    End Property

    Public Overrides ReadOnly Property VariableUnit As String
        Get
            Return VARIABLE_UNIT
        End Get
    End Property

    Public Overrides Function ClacYearTax(distance As Integer) As Integer
        Dim yearTax As Integer
        yearTax = Me.VehicleTax + distance * MILEAGE
        Return yearTax
    End Function
End Class
