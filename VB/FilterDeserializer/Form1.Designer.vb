Imports Microsoft.VisualBasic
Imports System
Namespace FilterDeserializer
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.btnRestoreLayout = New DevExpress.XtraEditors.SimpleButton()
			Me.btnSaveLayout = New DevExpress.XtraEditors.SimpleButton()
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' gridControl1
			' 
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl1.Location = New System.Drawing.Point(0, 50)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.Size = New System.Drawing.Size(678, 298)
			Me.gridControl1.TabIndex = 3
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
			' 
			' gridView1
			' 
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
			' 
			' btnRestoreLayout
			' 
			Me.btnRestoreLayout.Location = New System.Drawing.Point(137, 12)
			Me.btnRestoreLayout.Name = "btnRestoreLayout"
			Me.btnRestoreLayout.Size = New System.Drawing.Size(119, 28)
			Me.btnRestoreLayout.TabIndex = 1
			Me.btnRestoreLayout.Text = "Restore Layout"
'			Me.btnRestoreLayout.Click += New System.EventHandler(Me.btnRestoreLayout_Click);
			' 
			' btnSaveLayout
			' 
			Me.btnSaveLayout.Location = New System.Drawing.Point(12, 12)
			Me.btnSaveLayout.Name = "btnSaveLayout"
			Me.btnSaveLayout.Size = New System.Drawing.Size(119, 28)
			Me.btnSaveLayout.TabIndex = 0
			Me.btnSaveLayout.Text = "Save Layout"
'			Me.btnSaveLayout.Click += New System.EventHandler(Me.btnSaveLayout_Click);
			' 
			' panelControl1
			' 
			Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.panelControl1.Controls.Add(Me.btnRestoreLayout)
			Me.panelControl1.Controls.Add(Me.btnSaveLayout)
			Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
			Me.panelControl1.Location = New System.Drawing.Point(0, 0)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New System.Drawing.Size(678, 50)
			Me.panelControl1.TabIndex = 2
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(678, 348)
			Me.Controls.Add(Me.gridControl1)
			Me.Controls.Add(Me.panelControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private WithEvents btnRestoreLayout As DevExpress.XtraEditors.SimpleButton
		Private WithEvents btnSaveLayout As DevExpress.XtraEditors.SimpleButton
		Private panelControl1 As DevExpress.XtraEditors.PanelControl
	End Class
End Namespace

