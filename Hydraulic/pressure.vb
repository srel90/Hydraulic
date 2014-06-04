Imports Microsoft.Reporting.WinForms

Public Class pressure

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "0.00"
        Label2.Text = "0.00"
    End Sub

    Private Sub btncal_Click(sender As Object, e As EventArgs) Handles btncal.Click
        o2.Value = (0.443 * i3.Value * (1 - (i4.Value / 100))) + (0.443 * 1 * (i4.Value / 100))
        o1.Value = o2.Value * i2.Value
        o3.Value = o1.Value - i1.Value
        Label1.Text = i2.Value.ToString("0,0.00")
        Label2.Text = o1.Value.ToString("0,0.00")
    End Sub

    Private Sub btnprint_Click(sender As Object, e As EventArgs) Handles btnprint.Click
        Dim ds As New DataSet
        Dim dt As New DataTable
        Dim dr As DataRow

        dt.Columns.Add("r1")
        dt.Columns.Add("r2")
        dt.Columns.Add("r3")
        dt.Columns.Add("r4")
        dt.Columns.Add("r5")
        dt.Columns.Add("r6")
        dt.Columns.Add("r7")
        dt.Columns.Add("r8")
        dt.Columns.Add("r9")
        dt.Columns.Add("r10")
        dt.Columns.Add("r11")
        dt.Columns.Add("r12")
        dr = dt.NewRow()
        dr("r1") = i1.Value.ToString("0,0.00")
        dr("r2") = i2.Value.ToString("0,0.00")
        dr("r3") = i4.Value.ToString("0.00")
        dr("r4") = i3.Value.ToString("0.00")
        dr("r5") = "1 - " & (i4.Value / 100).ToString("0.000")
        dr("r6") = (1 - (i4.Value / 100)).ToString("0.000")
        dr("r7") = "(0.443 psi/ft. x" & i3.Value.ToString("0.00") & " x (1-" & (i4.Value / 100).ToString("0.000") & ")))+(0.443 psi/ft. x 1.0 x " & (i4.Value / 100).ToString("0.000") & ")"
        dr("r8") = o2.Value.ToString("0.000") & " psi/ft."
        dr("r9") = o2.Value.ToString("0.000") & " psi/ft. x " & i2.Value.ToString("0,0.00") & " ft."
        dr("r10") = o1.Value.ToString("0,0.00") & " psi."
        dr("r11") = o1.Value.ToString("0,0.00") & " - " & i1.Value.ToString("0,0.00")
        dr("r12") = o3.Value.ToString("0,0.00") & " psi."
        dt.Rows.Add(dr)
        ds.Tables.Add(dt)
        reportviewer.ReportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
        reportviewer.ReportViewer1.LocalReport.ReportPath = Application.StartupPath + "\pressure.rdlc"
        Dim ReportDataSource As New ReportDataSource("DataSet1", ds.Tables(0))
        reportviewer.ReportViewer1.LocalReport.EnableExternalImages = True
        reportviewer.ReportViewer1.LocalReport.DataSources.Clear()
        reportviewer.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource)
        reportviewer.ReportViewer1.LocalReport.Refresh()
        reportviewer.ReportViewer1.RefreshReport()
        reportviewer.Show()

    End Sub

    Private Sub btnstop_Click(sender As Object, e As EventArgs) Handles btnstop.Click
        Me.Hide()
    End Sub
End Class
