
Imports Newtonsoft.Json
Public Class Form1

    Public obj As JSON_result
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        obj = JsonConvert.DeserializeObject(Of JSON_result)(TextBox2.Text)
        Label9.Text = "Lagitude: " + obj.lagitude.ToString + " Latitude: " + obj.latitude.ToString
        Label8.Text = obj.altitude.ToString + "km"
        Label3.Text = obj.temp.ToString + "°C"
        Label4.Text = obj.name
        Label6.Text = obj.speed.ToString + "m/s"
    End Sub
End Class

Public Class JSON_result
    Public altitude As Integer
    Public latitude As Integer
    Public lagitude As Integer
    Public speed As Integer
    Public course As Integer
    Public temp As Integer
    Public name As String
End Class
