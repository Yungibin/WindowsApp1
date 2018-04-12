Public Class Truck
    Inherits Vehicle

    Private Shared STD_CAPACITY() As Integer = {1, 2, 3, 4}
    Private Shared STD_TAX() As Integer = {8000, 11500, 16000, 20500, 25500}
    Private Const MILEAGE As Double = 2.92
    Private Const VARIABLE_NAME As String = "最大積載量"
    Private Const VARIABLE_UNIT As String = "t"

    Public Sub New(ByVal fName As String, ByVal fPrice As Integer, ByVal fVariable As Integer)
        MyBase.New(fName, fPrice, fVariable)
    End Sub

    Public Overrides ReadOnly Property VehicleTax As Integer
        Get
            Dim i As Integer
            For i = 0 To STD_CAPACITY.Length - 1
                If fVariable <= STD_CAPACITY(i) Then
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
