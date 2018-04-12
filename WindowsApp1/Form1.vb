Public Class Form1

    Private vehicles(2) As IVehicle
    Private currentVehicle As IVehicle


    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim selectedVehicleName As String = ComboBox1.SelectedItem

        For i As Integer = 0 To vehicles.Length - 1
            If selectedVehicleName.Equals(vehicles(i).Name) Then
                currentVehicle = vehicles(i)
                Exit For
            End If
        Next

        variableLabel.Text = currentVehicle.Variable
        vehicleTaxLabel.Text = currentVehicle.VehicleTax
        variableNameLabel.Text = currentVehicle.VariableName & "   : "
        distanceText.Text = ""
        yearTaxLabel.Text = ""

    End Sub

    Private Sub yearTaxButton_Click(sender As Object, e As EventArgs) Handles yearTaxButton.Click

        Dim distance As Integer = distanceText.Text
        yearTaxLabel.Text = currentVehicle.ClacYearTax(distance)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        vehicles(0) = New Car("aruto", 700000, 658)
        vehicles(1) = New Car("sima", 1200000, 1800)
        vehicles(2) = New Truck("aruto", 2100000, 2)

        For i As Integer = 0 To vehicles.Length - 1
            ComboBox1.Items.Add(vehicles(i).Name)
        Next
        ComboBox1.SelectedIndex = 0

    End Sub
End Class
