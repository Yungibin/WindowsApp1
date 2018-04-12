Public Interface IVehicle
    Function ClacYearTax(ByVal distance As Integer) As Integer

    ReadOnly Property Name() As String
    ReadOnly Property Price() As Integer
    ReadOnly Property VehicleTax() As Integer
    ReadOnly Property VariableName() As String
    ReadOnly Property VariableUnit() As String
    ReadOnly Property Variable() As Integer

End Interface
