Imports Microsoft.Reporting.WinForms

Public Class efficient

    Private Sub btncal_Click(sender As Object, e As EventArgs) Handles btncal.Click
        i1.Value = width_radius.o1.Value
        i2.Value = pressure.o3.Value
        i4.Value = pressure.i4.Value
        'i5.Value = 10 * 10 ^ -6
        i6.Value = width_radius.o4.Value
        o2.Value = 0.0374 * i2.Value * (((i3.Value / 1000) * (i4.Value / 100) * i5.Value) / i7.Value) ^ (1 / 2)
        o3.Value = (2 * o2.Value * ((22 / 7) * i6.Value) ^ (1 / 2)) / (i1.Value / 12)
        o1.Value = ((1 / o3.Value ^ 2) * ((Math.Exp(o3.Value ^ 2) * SpecialFunction.erfc(o3.Value) + ((2 * o3.Value) / (22 / 7) ^ (1 / 2)) - 1)) * 100)
        Label1.Text = pressure.i2.Value.ToString("0,0.00")
        Label2.Text = width_radius.o1.Value.ToString("0.00")
        Label3.Text = (width_radius.o2.Value / 2).ToString("0.00")
        Label4.Text = pressure.o1.Value.ToString("0,0.00")
        Label5.Text = width_radius.i5.Value.ToString("0,0.00")
        Label6.Text = o1.Value.ToString("0.00")
    End Sub

    Private Sub efficient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        i1.Value = width_radius.o1.Value
        i2.Value = pressure.o3.Value
        i4.Value = pressure.i4.Value
        'i5.Value = 10 * 10 ^ -6
        i6.Value = width_radius.o4.Value
        Label1.Text = pressure.i2.Value.ToString("0,0.00")
        Label2.Text = width_radius.o1.Value.ToString("0.00")
        Label3.Text = (width_radius.o2.Value / 2).ToString("0.00")
        Label4.Text = pressure.o1.Value.ToString("0,0.00")
        Label5.Text = width_radius.i5.Value.ToString("0,0.00")
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
        dr("r1") = pressure.i1.Value.ToString("0,0.00")
        dr("r2") = pressure.i2.Value.ToString("0,0.00")
        dr("r3") = "1.00"
        dr("r4") = pressure.i3.Value.ToString("0.00")
        dr("r5") = width_radius.i1.Value.ToString("0,0.00")
        dr("r6") = width_radius.i2.Value.ToString("0.00")
        dr("r7") = width_radius.i3.Value.ToString("0.0000")
        dr("r8") = i4.Value.ToString("0,0.00")
        dr("r9") = "1 - " & (i4.Value / 100).ToString("0.000")
        dr("r10") = (1 - ((i4.Value / 100))).ToString("0.000")
        dr("r11") = "(0.443 psi/ft. x " & pressure.i3.Value.ToString("0.00") & " x (1 -" & ((i4.Value / 100)).ToString("0.000") & ")+(0.443 psi/ft. x 1.00 x " & (i4.Value / 100).ToString("0.000") & ")"
        dr("r12") = pressure.o2.Value.ToString("0.000") & " psi/ft."
        dr("r13") = pressure.o2.Value.ToString("0.000") & " psi/ft. x " & pressure.i2.Value.ToString("0,0.00") & "  ft."
        dr("r14") = pressure.o1.Value.ToString("0,0.00") & " psi."
        dr("r15") = pressure.o1.Value.ToString("0,0.00") & " - " & pressure.i1.Value.ToString("0,0.00")
        dr("r16") = pressure.o3.Value.ToString("0,0.00") & " psi."
        dr("r17") = "(0.0374)" & pressure.o3.Value.ToString("(0.00)")
        dr("r18") = i3.Value.ToString("0.000") & "/1,000"
        dr("r19") = i4.Value.ToString("0.00") & "/100"
        dr("r20") = "10 x 10"
        dr("r21") = i7.Value.ToString("0.0000")
        dr("r22") = o2.Value.ToString("0.00000") & " ft. /"
        dr("r23") = width_radius.i5.Value.ToString("0,0.00")
        dr("r24") = "(42)" & width_radius.i4.Value.ToString("(0,0.00)")
        dr("r25") = width_radius.o4.Value.ToString("0,0.00") & " min."
        dr("r26") = width_radius.i1.Value.ToString("0,0.00")
        dr("r27") = "1 - " & width_radius.i2.Value.ToString("0.00")
        dr("r28") = width_radius.o3.Value.ToString("0,0.00") & " psi."
        dr("r29") = width_radius.i3.Value.ToString("0.0000")
        dr("r30") = width_radius.i4.Value.ToString("0.00")
        dr("r31") = width_radius.o3.Value.ToString("0,0.00")
        dr("r32") = i6.Value.ToString("0.00")
        dr("r33") = i1.Value.ToString("0.00") & " in."
        dr("r34") = i6.Value.ToString("0,0.00")
        dr("r35") = o3.Value.ToString("0.0000")
        dr("r36") = o3.Value.ToString("0.0000")
        dr("r37") = SpecialFunction.erfc(o3.Value).ToString("0.0000")
        dr("r38") = o3.Value.ToString("0.0000")
        dr("r39") = o3.Value.ToString("0.0000")
        dr("r40") = SpecialFunction.erfc(o3.Value).ToString("0.0000")
        dr("r41") = o1.Value.ToString("0,0.00") & " %"
        dt.Rows.Add(dr)
        ds.Tables.Add(dt)
        Dim rpt As New reportviewer()

        rpt.ReportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
        rpt.ReportViewer1.LocalReport.ReportPath = Application.StartupPath + "\efficient.rdlc"
        Dim pr1 As New ReportParameter("ReportParameter1", i3.Value.ToString("0.000"))
        Dim pr2 As New ReportParameter("ReportParameter2", width_radius.i4.Value.ToString("0.00"))
        Dim pr3 As New ReportParameter("ReportParameter3", width_radius.i5.Value.ToString("0,0.00"))
        Dim pr4 As New ReportParameter("ReportParameter4", i5.Value.ToString("0.00000"))
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
        rpt2.ReportViewer1.LocalReport.ReportPath = Application.StartupPath + "\efficient2.rdlc"
        Dim ReportParameter1 As New ReportParameter("ReportParameter1", "(" & width_radius.o1.Value.ToString("0.00") & "/12)")
        Dim ReportParameter2 As New ReportParameter("ReportParameter2", i3.Value.ToString("0.000"))
        rpt2.ReportViewer1.LocalReport.SetParameters(ReportParameter1)
        rpt2.ReportViewer1.LocalReport.SetParameters(ReportParameter2)
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