Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class frmObjectDemonstrations
    Private objDemoForm As Object
    Public Property ToolTipMe As Object
    Public Property ToolTip1 As Object
    Private Function Button1() As Object
    End Function
    Private Function Button2() As Object

    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Assign appropriate tooltips to the buttons
        ToolTip1.SetToolTip(Button1, "Load Object Demo")
        ToolTip1.SetToolTip(Button2, "Exit")
    End Sub
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Click
        Me.BackColor = Color.Red
    End Sub
    Private Sub LoadObjectDemo_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        Dim objectDemoForm As New frmObjectDemonstrations

        objDemoForm.show()
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

End Class
