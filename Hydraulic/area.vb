Imports Microsoft.Reporting.WinForms

Public Class area

    Private Sub area_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        i1.Value = width_radius.o1.Value
        i2.Value = width_radius.i5.Value
        i3.Value = efficient.o1.Value
        Label1.Text = pressure.i2.Value.ToString("0,0.00")
        Label2.Text = width_radius.o1.Value.ToString("0.00")
        Label3.Text = (width_radius.o2.Value / 2).ToString("0.00")
        Label4.Text = pressure.o1.Value.ToString("0,0.00")
        Label5.Text = width_radius.i5.Value.ToString("0,0.00")
        Label6.Text = efficient.o1.Value.ToString("0.00")
    End Sub

    Private Sub btncal_Click(sender As Object, e As EventArgs) Handles btncal.Click
        i1.Value = width_radius.o1.Value
        i2.Value = width_radius.i5.Value
        i3.Value = efficient.o1.Value
        o1.Value = ((i3.Value / 100) * i2.Value) / (7.48 * (i1.Value / 12))
        Label1.Text = pressure.i2.Value.ToString("0,0.00")
        Label2.Text = width_radius.o1.Value.ToString("0.00")
        Label3.Text = (width_radius.o2.Value / 2).ToString("0.00")
        Label4.Text = pressure.o1.Value.ToString("0,0.00")
        Label5.Text = width_radius.i5.Value.ToString("0,0.00")
        Label6.Text = efficient.o1.Value.ToString("0.00")
        Label7.Text = o1.Value.ToString("0,0.00")
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
        dt.Columns.Add("r23")
        dt.Columns.Add("r24")
        dt.Columns.Add("r25")
        dt.Columns.Add("r26")
        dt.Columns.Add("r27")
        dt.Columns.Add("r28")
        dt.Columns.Add("r29")
        dt.Columns.Add("r30")
        dt.Columns.Add("r31")
        dt.Columns.Add("r32")
        dt.Columns.Add("r33")
        dt.Columns.Add("r34")
        dt.Columns.Add("r35")
        dt.Columns.Add("r36")
        dt.Columns.Add("r37")
        dt.Columns.Add("r38")
        dt.Columns.Add("r39")
        dt.Columns.Add("r40")
        dt.Columns.Add("r41")
        dr = dt.NewRow()
        dr("r1") = width_radius.i1.Value.ToString("0,0.00")
        dr("r2") = width_radius.i2.Value.ToString("0.00")
        dr("r3") = efficient.i7.Value.ToString("0.0000")
        dr("r4") = efficient.i4.Value.ToString("0.00")
        dr("r5") = efficient.i3.Value.ToString("0.00")
        dr("r6") = width_radius.i1.Value.ToString("0,0.00")
        dr("r7") = "1 - " & (width_radius.i2.Value).ToString("0.00")
        dr("r8") = width_radius.o3.Value.ToString("0,0.00") & " psi."
        dr("r9") = width_radius.i5.Value.ToString("0,0.00")
        dr("r10") = "(42)" & width_radius.i4.Value.ToString("(0,0.00)")
        dr("r11") = width_radius.o4.Value.ToString("0,0.00") & " min."
        dr("r12") = width_radius.i3.Value.ToString("0.0000")
        dr("r13") = width_radius.i4.Value.ToString("0,0.00")
        dr("r14") = width_radius.o3.Value.ToString("0,0.00")
        dr("r15") = width_radius.o4.Value.ToString("(0.00)")
        dr("r16") = width_radius.o1.Value.ToString("0.00") & " in."
        dr("r17") = "(0.0374)" & pressure.o3.Value.ToString("(0,0.00)")
        dr("r18") = efficient.i3.Value.ToString("0.0000") & "/1,000"
        dr("r19") = efficient.i4.Value.ToString("0,0.00") & "/100"
        dr("r20") = "10 x 10"
        dr("r21") = efficient.i7.Value.ToString("0.0000")
        dr("r22") = efficient.o2.Value.ToString("0.00000") & " ft. /"
        dr("r23") = width_radius.o4.Value.ToString("0,0.00")
        dr("r24") = "(" & width_radius.o1.Value.ToString("0.00") & "/12)"
        dr("r25") = efficient.o3.Value.ToString("0.0000")
        dr("r26") = efficient.o3.Value.ToString("0.0000")
        dr("r27") = SpecialFunction.erfc(efficient.o3.Value).ToString("0.0000")
        dr("r28") = efficient.o3.Value.ToString("0.0000")
        dr("r29") = efficient.o3.Value.ToString("0.0000")
        dr("r30") = SpecialFunction.erfc(efficient.o3.Value).ToString("0.0000")
        dr("r31") = efficient.o1.Value.ToString("0,0.00") & " %"
        dr("r32") = "(" & efficient.o1.Value.ToString("0,0.00") & "/100) " & width_radius.i5.Value.ToString("(0,0.00)")
        dr("r33") = "(7.48)" & " (" & i1.Value.ToString("0.00") & "/12)"
        dr("r34") = o1.Value.ToString("0,0.00") & " ft²"

        dt.Rows.Add(dr)
        ds.Tables.Add(dt)
        Dim rpt As New reportviewer()

        rpt.ReportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
        rpt.ReportViewer1.LocalReport.ReportPath = Application.StartupPath + "\area.rdlc"
        Dim pr1 As New ReportParameter("ReportParameter1", width_radius.i4.Value.ToString("0.00"))
        Dim pr2 As New ReportParameter("ReportParameter2", width_radius.i5.Value.ToString("0,0.00"))
        Dim pr3 As New ReportParameter("ReportParameter3", efficient.i5.Value.ToString("0.00000"))
        Dim pr4 As New ReportParameter("ReportParameter4", efficient.i3.Value.ToString("0.000"))
        rpt.ReportViewer1.LocalReport.SetParameters(pr1)
        rpt.ReportViewer1.LocalReport.SetParameters(pr2)
        rpt.ReportViewer1.LocalReport.SetParameters(pr3)
        rpt.ReportViewer1.LocalReport.SetParameters(pr4)
        Dim ReportDataSource As New ReportDataSource("DataSet1", ds.Tables(0))

        rpt.ReportViewer1.LocalReport.DataSources.Clear()
        rpt.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource)
        rpt.ReportViewer1.LocalReport.Refresh()
        rpt.ReportViewer1.RefreshReport()
        rpt.Show()

        Dim rpt2 As New reportviewer()

        rpt2.ReportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
        rpt2.ReportViewer1.LocalReport.ReportPath = Application.StartupPath + "\area2.rdlc"

        Dim ReportDataSource2 As New ReportDataSource("DataSet1", ds.Tables(0))

        rpt2.ReportViewer1.LocalReport.DataSources.Clear()
        rpt2.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        rpt2.ReportViewer1.LocalReport.Refresh()
        rpt2.ReportViewer1.RefreshReport()
        rpt2.Show()
    End Sub

    Private Sub btnstop_Click(sender As Object, e As EventArgs) Handles btnstop.Click
        Me.Hide()
    End Sub
End Class