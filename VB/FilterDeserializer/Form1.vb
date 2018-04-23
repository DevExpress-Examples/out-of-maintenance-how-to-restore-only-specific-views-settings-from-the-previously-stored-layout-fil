Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Namespace FilterDeserializer
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub
		Private layoutFileName As String = "test.xml"
		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Dim tbl As New DataTable()
			tbl.Columns.Add("ID", GetType(Integer))
			tbl.Columns.Add("Name", GetType(String))
			tbl.Columns.Add("Date", GetType(DateTime))
			tbl.Columns.Add("Payment", GetType(Decimal))
			For i As Integer = 1 To 29
				tbl.Rows.Add(i, String.Format("Item{0}", i Mod 7), DateTime.Now.AddDays(-60).AddDays(i), i * 3.3)
			Next i
			gridControl1.DataSource = tbl
		End Sub

		Private Sub btnSaveLayout_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSaveLayout.Click
			gridView1.SaveLayoutToXml(layoutFileName, DevExpress.Utils.OptionsLayoutGrid.FullLayout)
		End Sub

		Private Sub btnRestoreLayout_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRestoreLayout.Click
			If System.IO.File.Exists(layoutFileName) Then
				FilterDeserializer.LoadFilter(gridView1, layoutFileName)
			End If
		End Sub
	End Class
End Namespace