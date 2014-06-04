Imports System.Windows.Forms
Imports DevComponents.DotNetBar

Public Class main
    Private Sub btnpressure_Click(sender As Object, e As EventArgs) Handles btnpressure.Click
        DisplayForm(pressure)
    End Sub

    Private Sub btnwidth_radius_Click(sender As Object, e As EventArgs) Handles btnwidth_radius.Click
        DisplayForm(width_radius)
    End Sub

    Private Sub btnefficient_Click(sender As Object, e As EventArgs) Handles btnefficient.Click
        DisplayForm(efficient)
    End Sub

    Private Sub btnarea_Click(sender As Object, e As EventArgs) Handles btnarea.Click
        DisplayForm(area)
    End Sub

    Private Sub btnproductivity_ratio_Click(sender As Object, e As EventArgs) Handles btnproductivity_ratio.Click
        DisplayForm(productivity_ratio)
    End Sub

    Private Sub ButtonItem1_Click(sender As Object, e As EventArgs) Handles ButtonItem1.Click
        Me.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade)
    End Sub

    Private Sub ButtonItem2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnhelp_Click(sender As Object, e As EventArgs) Handles btnhelp.Click
        Dim webAddress As String = "http://www.example.com/"
        Process.Start(webAddress)
    End Sub
End Class
