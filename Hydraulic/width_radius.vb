Imports Microsoft.Reporting.WinForms

Public Class width_radius

    Private Sub btncal_Click(sender As Object, e As EventArgs) Handles btncal.Click
        o4.Value = i5.Value / (42 * i4.Value)
        o3.Value = i1.Value / (1 - i2.Value ^ 2)
        o2.Value = 0.52 * (o4.Value ^ (4 / 9)) * ((o3.Value * i4.Value ^ 3) / i3.Value) ^ (1 / 9)
        o1.Value = 2.17 * (o4.Value ^ (1 / 9)) * ((i3.Value ^ 2 * i4.Value ^ 3) / o3.Value ^ 2) ^ (1 / 9)
        Label1.Text = pressure.i2.Value.ToString("0,0.00")
        Label2.Text = o1.Value.ToString("0.00")
        Label3.Text = (o2.Value / 2).ToString("0.00")
        Label4.Text = pressure.o1.Value.ToString("0,0.00")
        Label5.Text = i5.Value.ToString("0,0.00")
    End Sub

    Private Sub width_radius_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = pressure.i2.Value.ToString("0,0.00")
        Label4.Text = pressure.o1.Value.ToString("0,0.00")
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
        dt.Columns.Add("r13")
        dt.Columns.Add("r14")
        dt.Columns.Add("r15")
        dt.Columns.Add("r16")
        dt.Columns.Add("r17")
        dt.Columns.Add("r18")
        dt.Columns.Add("r19")
        dt.Columns.Add("r20")
        dt.Columns.Add("r21")
        dt.Columns.Add("r22")
        dr = dt.NewRow()
        dr("r1") = i1.Value.ToString("0,0.00")
        dr("r2") = i2.Value.ToString("0.00")
        dr("r3") = i3.Value
        dr("r4") = i4.Value.ToString("0.00")
        dr("r5") = i5.Value.ToString("0,0.00")
        dr("r6") = i1.Value.ToString("0,0.00")
        dr("r7") = "1-" & i2.Value.ToString("0.00")
        dr("r8") = o3.Value.ToString("0,0.00") & " psi."
        dr("r9") = i5.Value.ToString("0,0.00")
        dr("r10") = "(42)(" & i4.Value.ToString("0.00") & ")"
        dr("r11") = o4.Value.ToString("0.00") & " min."
        dr("r12") = i3.Value.ToString("0.0000")
        dr("r13") = i4.Value.ToString("0.00")
        dr("r14") = o3.Value.ToString("0,0.00")
        dr("r15") = o4.Value.ToString("0,0.00")
        dr("r16") = o1.Value.ToString("0.00") & " in."
        dr("r17") = o3.Value.ToString("0,0.00")
        dr("r18") = i4.Value.ToString("0.00")
        dr("r19") = i3.Value.ToString("0.0000")
        dr("r20") = o4.Value.ToString("0.00")
        dr("r21") = o2.Value.ToString("0.00") & " ft."
        dt.Rows.Add(dr)
        ds.Tables.Add(dt)
        reportviewer.ReportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
        reportviewer.ReportViewer1.LocalReport.ReportPath = Application.StartupPath + "\width_radius.rdlc"
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