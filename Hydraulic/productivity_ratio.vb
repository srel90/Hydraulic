Imports Microsoft.Reporting.WinForms

Public Class productivity_ratio

    Private Sub productivity_ratio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        i3.Value = width_radius.o2.Value
        i4.Value = area.o1.Value
        i6.Value = efficient.i3.Value
        i7.Value = width_radius.o1.Value
        Label1.Text = width_radius.o1.Value.ToString("0.00")
        Label6.Text = area.o1.Value.ToString("0,0.00")

    End Sub

    Private Sub btncal_Click(sender As Object, e As EventArgs) Handles btncal.Click
        o3.Value = (i5.Value / 12) / 2
        o2.Value = (Math.Sqrt((4 * i4.Value) / (22 / 7))) / 2
        o1.Value = (i1.Value * i7.Value) / (i6.Value * i2.Value) * ((((i6.Value * i2.Value) / (i1.Value * i7.Value)) + 1) * (Math.Log(o2.Value / o3.Value))) / ((((i1.Value * i7.Value) / (i6.Value * i2.Value)) + 1) * ((Math.Log(o2.Value / i3.Value)) + (Math.Log(i3.Value / o3.Value))))
        Label2.Text = o2.Value.ToString("0.00")
        Label9.Text = i3.Value.ToString("0.00")
        Label3.Text = i1.Value.ToString("0.00")
        Label4.Text = i6.Value.ToString("0.00")
        Label5.Text = i2.Value.ToString("0.00")
        Label7.Text = o3.Value.ToString("0.00")
        Label8.Text = o1.Value.ToString("0.00")
    End Sub

    Private Sub btnprint_Click(sender As Object, e As EventArgs) Handles btnprint.Click
        Dim rpt, rpt2 As New reportviewer()
        Dim r1 As New ReportParameter("r1", i1.Value.ToString("0.00"))
        Dim r2 As New ReportParameter("r2", i2.Value.ToString("0.00"))
        Dim r3 As New ReportParameter("r3", i3.Value.ToString("0.00"))
        Dim r4 As New ReportParameter("r4", width_radius.i1.Value.ToString("0,0.00"))
        Dim r5 As New ReportParameter("r5", width_radius.i2.Value.ToString("0.00"))
        Dim r6 As New ReportParameter("r6", width_radius.i3.Value.ToString("0.0000"))
        Dim r7 As New ReportParameter("r7", o2.Value.ToString("0.00"))
        Dim r8 As New ReportParameter("r8", o3.Value.ToString("0.000"))
        Dim r9 As New ReportParameter("r9", i6.Value.ToString("0.00"))
        Dim r10 As New ReportParameter("r10", pressure.i4.Value.ToString("0.00"))
        Dim r11 As New ReportParameter("r11", i5.Value.ToString("0.00"))
        Dim r12 As New ReportParameter("r12", width_radius.i1.Value.ToString("0,0.00"))
        Dim r13 As New ReportParameter("r13", "1 - " & width_radius.i2.Value.ToString("0.00"))
        Dim r14 As New ReportParameter("r14", width_radius.o3.Value.ToString("0,0.00") & " psi.")
        Dim r15 As New ReportParameter("r15", width_radius.i5.Value.ToString("0,0.00"))
        Dim r16 As New ReportParameter("r16", "(42)(" & width_radius.i4.Value.ToString("0.00") & ")")
        Dim r17 As New ReportParameter("r17", width_radius.o4.Value.ToString("0.00") & " min.")
        Dim r18 As New ReportParameter("r18", width_radius.i3.Value.ToString("0.0000"))
        Dim r19 As New ReportParameter("r19", width_radius.i4.Value.ToString("0.00"))
        Dim r20 As New ReportParameter("r20", width_radius.o3.Value.ToString("0,0.00"))
        Dim r21 As New ReportParameter("r21", width_radius.o4.Value.ToString("(0.00)"))
        Dim r22 As New ReportParameter("r22", efficient.i1.Value.ToString("0.00") & " in.")
        Dim r23 As New ReportParameter("r23", "(0.0374)" & pressure.o3.Value.ToString("(0.00)"))
        Dim r24 As New ReportParameter("r24", efficient.i3.Value.ToString("0.000") & "/1,000")
        Dim r25 As New ReportParameter("r25", efficient.i4.Value.ToString("0.00") & "/100")
        Dim r26 As New ReportParameter("r26", "10 x 10")
        Dim r27 As New ReportParameter("r27", efficient.i7.Value.ToString("0.0000"))
        Dim r28 As New ReportParameter("r28", efficient.o2.Value.ToString("0.00000") & " ft. /")
        Dim r29 As New ReportParameter("r29", width_radius.o4.Value.ToString("0.00"))
        Dim r30 As New ReportParameter("r30", "(" & width_radius.o1.Value.ToString("0.00") & "/12)")
        Dim r31 As New ReportParameter("r31", efficient.o3.Value.ToString("0.0000"))

        Dim r32 As New ReportParameter("r32", efficient.o3.Value.ToString("0.0000"))
        Dim r33 As New ReportParameter("r33", SpecialFunction.erfc(efficient.o3.Value).ToString("0.0000"))
        Dim r34 As New ReportParameter("r34", efficient.o3.Value.ToString("0.0000"))
        Dim r35 As New ReportParameter("r35", efficient.o3.Value.ToString("0.0000"))
        Dim r36 As New ReportParameter("r36", efficient.o3.Value.ToString("0.0000"))
        Dim r37 As New ReportParameter("r37", efficient.o1.Value.ToString("0.00") & " %")
        Dim r38 As New ReportParameter("r38", "(" & efficient.o1.Value.ToString("0.00") & " / 100)" & width_radius.i5.Value.ToString("(0,0.00)"))
        Dim r39 As New ReportParameter("r39", "(7.48)" & "(" & width_radius.o1.Value.ToString("0.00") & "/12)")
        Dim r40 As New ReportParameter("r40", area.o1.Value.ToString("0,0.00") & " ft²")
        Dim r41 As New ReportParameter("r41", area.o1.Value.ToString("0,0.00"))
        Dim r42 As New ReportParameter("r42", o2.Value.ToString("0,0.00") & " ft.")
        Dim r43 As New ReportParameter("r43", i5.Value.ToString("0.00") & " /12")
        Dim r44 As New ReportParameter("r44", o3.Value.ToString("0.000") & " ft.")
        Dim r45 As New ReportParameter("r45", i1.Value.ToString("(0.0000)") & width_radius.o1.Value.ToString("(0.00)"))
        Dim r46 As New ReportParameter("r46", i6.Value.ToString("(0.0000)") & i2.Value.ToString("(0.00)"))
        Dim r47 As New ReportParameter("r47", i6.Value.ToString("(0.0000)") & i2.Value.ToString("(0.00)"))
        Dim r48 As New ReportParameter("r48", i1.Value.ToString("(0.0000)") & width_radius.o1.Value.ToString("(0.00)"))
        Dim r49 As New ReportParameter("r49", i1.Value.ToString("(0.0000)") & width_radius.o1.Value.ToString("(0.00)"))
        Dim r50 As New ReportParameter("r50", i6.Value.ToString("(0.0000)") & i2.Value.ToString("(0.00)"))
        Dim r51 As New ReportParameter("r51", "ln(" & o2.Value.ToString("0.00") & " / " & o3.Value.ToString("0.000") & ")")
        Dim r52 As New ReportParameter("r52", "ln(" & o2.Value.ToString("0.00") & " / " & width_radius.o2.Value.ToString("0.00") & ") + ln(" & width_radius.o2.Value.ToString("0.00") & " / " & o3.Value.ToString("0.000") & ")")
        Dim r53 As New ReportParameter("r53", o1.Value.ToString("0.00"))

        Dim pr1 As New ReportParameter("ReportParameter1", width_radius.i4.Value.ToString("0.00"))
        Dim pr2 As New ReportParameter("ReportParameter2", width_radius.i5.Value.ToString("0,0.00"))
        Dim pr3 As New ReportParameter("ReportParameter3", efficient.i5.Value.ToString("0.00000"))
        Dim pr4 As New ReportParameter("ReportParameter4", efficient.i3.Value.ToString("0.000"))
       

        rpt.ReportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
        rpt.ReportViewer1.LocalReport.ReportPath = Application.StartupPath + "\productivity_ratio.rdlc"
        rpt.ReportViewer1.LocalReport.SetParameters(r1)
        rpt.ReportViewer1.LocalReport.SetParameters(r2)
        rpt.ReportViewer1.LocalReport.SetParameters(r3)
        rpt.ReportViewer1.LocalReport.SetParameters(r4)
        rpt.ReportViewer1.LocalReport.SetParameters(r5)
        rpt.ReportViewer1.LocalReport.SetParameters(r6)
        rpt.ReportViewer1.LocalReport.SetParameters(r7)
        rpt.ReportViewer1.LocalReport.SetParameters(r8)
        rpt.ReportViewer1.LocalReport.SetParameters(r9)
        rpt.ReportViewer1.LocalReport.SetParameters(r10)
        rpt.ReportViewer1.LocalReport.SetParameters(r11)
        rpt.ReportViewer1.LocalReport.SetParameters(r12)
        rpt.ReportViewer1.LocalReport.SetParameters(r13)
        rpt.ReportViewer1.LocalReport.SetParameters(r14)
        rpt.ReportViewer1.LocalReport.SetParameters(r15)
        rpt.ReportViewer1.LocalReport.SetParameters(r16)
        rpt.ReportViewer1.LocalReport.SetParameters(r17)
        rpt.ReportViewer1.LocalReport.SetParameters(r18)
        rpt.ReportViewer1.LocalReport.SetParameters(r19)
        rpt.ReportViewer1.LocalReport.SetParameters(r20)
        rpt.ReportViewer1.LocalReport.SetParameters(r21)
        rpt.ReportViewer1.LocalReport.SetParameters(r22)
        rpt.ReportViewer1.LocalReport.SetParameters(r23)
        rpt.ReportViewer1.LocalReport.SetParameters(r24)
        rpt.ReportViewer1.LocalReport.SetParameters(r25)
        rpt.ReportViewer1.LocalReport.SetParameters(r26)
        rpt.ReportViewer1.LocalReport.SetParameters(r27)
        rpt.ReportViewer1.LocalReport.SetParameters(r28)
        rpt.ReportViewer1.LocalReport.SetParameters(r29)
        rpt.ReportViewer1.LocalReport.SetParameters(r30)
        rpt.ReportViewer1.LocalReport.SetParameters(r31)

        rpt.ReportViewer1.LocalReport.SetParameters(pr1)
        rpt.ReportViewer1.LocalReport.SetParameters(pr2)
        rpt.ReportViewer1.LocalReport.SetParameters(pr3)
        rpt.ReportViewer1.LocalReport.SetParameters(pr4)
        rpt.ReportViewer1.LocalReport.Refresh()
        rpt.ReportViewer1.RefreshReport()
        rpt.Show()

        rpt2.ReportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
        rpt2.ReportViewer1.LocalReport.ReportPath = Application.StartupPath + "\productivity_ratio2.rdlc"
        rpt2.ReportViewer1.LocalReport.SetParameters(r32)
        rpt2.ReportViewer1.LocalReport.SetParameters(r33)
        rpt2.ReportViewer1.LocalReport.SetParameters(r34)
        rpt2.ReportViewer1.LocalReport.SetParameters(r35)
        rpt2.ReportViewer1.LocalReport.SetParameters(r36)
        rpt2.ReportViewer1.LocalReport.SetParameters(r37)
        rpt2.ReportViewer1.LocalReport.SetParameters(r38)
        rpt2.ReportViewer1.LocalReport.SetParameters(r39)
        rpt2.ReportViewer1.LocalReport.SetParameters(r40)
        rpt2.ReportViewer1.LocalReport.SetParameters(r41)
        rpt2.ReportViewer1.LocalReport.SetParameters(r42)
        rpt2.ReportViewer1.LocalReport.SetParameters(r43)
        rpt2.ReportViewer1.LocalReport.SetParameters(r44)
        rpt2.ReportViewer1.LocalReport.SetParameters(r45)
        rpt2.ReportViewer1.LocalReport.SetParameters(r46)
        rpt2.ReportViewer1.LocalReport.SetParameters(r47)
        rpt2.ReportViewer1.LocalReport.SetParameters(r48)
        rpt2.ReportViewer1.LocalReport.SetParameters(r49)
        rpt2.ReportViewer1.LocalReport.SetParameters(r50)
        rpt2.ReportViewer1.LocalReport.SetParameters(r51)
        rpt2.ReportViewer1.LocalReport.SetParameters(r52)
        rpt2.ReportViewer1.LocalReport.SetParameters(r53)
        rpt2.ReportViewer1.LocalReport.Refresh()
        rpt2.ReportViewer1.RefreshReport()
        rpt2.Show()
    End Sub

    Private Sub btnstop_Click(sender As Object, e As EventArgs) Handles btnstop.Click
        Me.Hide()
    End Sub
End Class