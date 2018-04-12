Imports WindowsApp1

Public MustInherit Class Vehicle
    Implements IVehicle

    Protected fName As String
    Protected fPrice As Integer
    Protected fVariable As Integer

    Public Sub New(ByVal fName As String, ByVal fPrice As Integer, ByVal fVariable As Integer)
        Me.fName = fName
        Me.fPrice = fPrice
        Me.fVariable = fVariable
    End Sub

    Public ReadOnly Property Name As String Implements IVehicle.Name
        Get
            Return fName
        End Get
    End Property

    Public ReadOnly Property Price As Integer Implements IVehicle.Price
        Get
            Return fPrice
        End Get
    End Property

    Public ReadOnly Property Variable As Integer Implements IVehicle.Variable
        Get
            Return fVariable
        End Get
    End Property

    Public MustOverride Function ClacYearTax(ByVal distance As Integer) As Integer Implements IVehicle.ClacYearTax

    Public MustOverride ReadOnly Property VehicleTax() As Integer Implements IVehicle.VehicleTax
    Public MustOverride ReadOnly Property VariableName() As String Implements IVehicle.VariableName
    Public MustOverride ReadOnly Property VariableUnit() As String Implements IVehicle.VariableUnit

End Class
