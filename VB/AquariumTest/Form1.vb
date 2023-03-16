Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
#Region "#usings"
Imports DevExpress.UnitConversion
#End Region ' #usings

Namespace AquariumTest
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
'#Region "#tank"
'Quantity value is a value measured in a certain unit.
'You cannot mix different quantity values in a single expression.
'Instead, you can easily convert them as required and use the Value property to obtain numerical values.
Dim l As QuantityValue(Of Distance) = (48.25).Inches()
Dim w As QuantityValue(Of Distance) = (12.75).Inches()
Dim h As QuantityValue(Of Distance) = (21.0).Inches()
Dim vol As QuantityValue(Of Volume) = (l.ToMeters().Value * w.ToMeters().Value * h.ToMeters().Value).CubicMeters()
Dim m As QuantityValue(Of Mass) = (vol.ToLiters() * 1000).Value.Grams()
Dim loading As QuantityValue(Of Pressure) = (m.ToPounds() / (l * w).Value.SquareInches()).Value.PoundsPerSquareInch()
'US Standard uniform floor load is 0.2 psi.
Dim percentageUS As Double = loading.ToPoundsPerSquareInch() / (0.2).PoundsPerSquareInch() * 100
'British standard imposed load is 1500 Newtons per square meter.
Dim percentageEu As Double = loading.ToPascals() / (1500.0).Pascals() * 100

Dim textFormatUS As String = "The aquarium tank (length {0:g3} in, width {1:g3} in, height {2:g3} in) contains {3:g5} gallons of water. " & "It weights {4:g5} lbs. " & "The pressure at the bottom is {5:g3} percent of the standard US wood joist floor loading."
Dim textUS As String = String.Format(textFormatUS, l.ToInches().Value, w.ToInches().Value, h.ToInches().Value, vol.ToGallons().Value, m.ToPounds().Value, percentageUS)

Dim textFormatEu As String = "The aquarium tank (length {0:g3} m, width {1:g3} m, height {2:g3} m) contains {3:g5} liters of water. " & "It weights {4:g5} kg. " & "The pressure at the bottom is {5:g3} percent of the standard UK wood joist floor loading."
Dim textEu As String = String.Format(textFormatEu, l.ToMeters().Value, w.ToMeters().Value, h.ToMeters().Value, vol.ToLiters().Value, m.ToKilograms().Value, percentageEu)

Dim msg As String = If(radioButtonUS.Checked, textUS, textEu)
MessageBox.Show(msg)
'#End Region ' #tank
        End Sub
    End Class
End Namespace
