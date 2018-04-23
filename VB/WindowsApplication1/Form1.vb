Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraReports.UI

Namespace WindowsApplication1
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton1.Click
			Dim r As New XtraReport1()
			r.DataSource = schedulerStorage1.GetAppointments(schedulerControl1.ActiveView.GetVisibleIntervals())
			Dim rpt As New ReportPrintTool(r)
			rpt.ShowPreviewDialog()
		End Sub
	End Class
End Namespace