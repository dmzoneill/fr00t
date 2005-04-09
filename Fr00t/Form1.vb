Imports System.Threading

Public Class Form1
    Dim cmp As String
    Dim xx As New Form2
    Delegate Sub changeText1ControlDelegate(ByVal txtdisplay As TextBox, ByVal ret As String)
    Dim result As Boolean


    Private Sub proclist()
        Dim ret As String = ""
        Dim allowed As New ArrayList() ' allowed apps pre defined

        allowed.Add("NPROTECT")
        allowed.Add("SVCHOST")
        allowed.Add("NAVAPSVC")
        allowed.Add("SPBBCSvc")
        allowed.Add("symlcsvc")
        allowed.Add("svchost")
        allowed.Add("winlogon")
        allowed.Add("WINLOGON")
        allowed.Add("gcasDtServ")
        allowed.Add("CCAPP")
        allowed.Add("rundll32")
        allowed.Add("LSASS")
        allowed.Add("svchost")
        allowed.Add("explorer")
        allowed.Add("stop")
        allowed.Add("atiptaxx")
        allowed.Add("NPFMNTOR")
        allowed.Add("NMBgMonitor")
        allowed.Add("spoolsv")
        allowed.Add("MDM")
        allowed.Add("smss")
        allowed.Add("SNDSrvc")
        allowed.Add("lsass")
        allowed.Add("taskkill")
        allowed.Add("svchost")
        allowed.Add("csrss")
        allowed.Add("CCSETMGR")
        allowed.Add("services")
        allowed.Add("SERVICES")
        allowed.Add("svchost")
        allowed.Add("CCEVTMGR")
        allowed.Add("ati2evxx")
        allowed.Add("alg")
        allowed.Add("svchost")
        allowed.Add("NOPDB")
        allowed.Add("ati2evxx")
        allowed.Add("ctfmon")
        allowed.Add("cmd")
        allowed.Add("TaskSwitch")
        allowed.Add("System")
        allowed.Add("Idle")
        allowed.Add("ScreenShield")
        allowed.Add("Click Here Program Stopper.vshost")
        allowed.Add("devenv")
        allowed.Add("EXPLORER")
        allowed.Add("NMain")
        Dim y As Integer = 1
        xx.TreeView1.Nodes.Clear()
        Do While y > 0


            Dim p As Process
            For Each p In Process.GetProcesses
                If Not allowed.Contains(p.ProcessName.ToString) Then
                    '       "           ffffffffffff           " , " " ,"", 
                    ret = "|" + Chr(34) + p.ProcessName.ToString + Chr(34) + "," + Chr(34) + Chr(34) + "," + Chr(34) + Chr(34) + "," + Chr(34) + Chr(34) + "," + Chr(34) + Chr(34) + "," + Chr(34) + Chr(34) + "|"
                    y = y + 1
                    cmp = ret & cmp

                    If Me.txtDisplay.InvokeRequired Then
                        Me.txtDisplay.Invoke(New changeText1ControlDelegate(AddressOf setdisplaytext1), New Object() {txtDisplay, ret})

                    Else
                        Me.setdisplaytext1(txtDisplay, ret)
                    End If

                End If
            Next
            System.Threading.Thread.Sleep(5000)
        Loop

    End Sub

    Public Sub setdisplaytext1(ByVal txtdisplay As TextBox, ByVal ret As String)

        Dim xxxp As Integer
        Dim cock As Array
        Dim news As String = ""

        cock = ret.Split("|")
        For xxxp = 1 To 1
            Dim shit As Array
            shit = cock(xxxp).split(",")
            news = shit(0)
            xx.TreeView1.Nodes.Add(news)

        Next
        Try
            txtdisplay.AppendText(ret & System.Environment.NewLine)
        Catch ffff As Exception
            System.Console.Write("fff")
        End Try

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        xx.Hide()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim vv As Boolean = xx.Visible()
        Dim p As Integer = 0
        xx.ShowInTaskbar = False
        xx.ShowIcon = False
        xx.SendToBack()
        xx.Text = "Fr00000000t Options"
        xx.AllowTransparency = True

        xx.Opacity = 0.9

        If vv = True Then
            p = 1
        End If
        If vv = False Then
            p = 0
        End If

        If p = 1 Then
            xx.Hide()
        End If
        If p = 0 Then
            xx.Show()
        End If


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Dim newg As New System.Threading.Thread(AddressOf proclist)
        newg.Start()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim ddd As Integer

        For ddd = 0 To 100

            MsgBox(Chr(ddd) & "|" & ddd)
        Next

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim cc As New Dialog1
        cc.Text = "Allow run?"
        cc.ShowInTaskbar = False
        cc.CausesValidation = True
        cc.TopMost = True
        cc.Validate()
        cc.Select()
        cc.ShowDialog()
        result = True

        MsgBox(result)

        If cc.Cancel_Button.DialogResult = Windows.Forms.DialogResult.No Then
            result = False
        End If
        If cc.OK_Button.DialogResult = Windows.Forms.DialogResult.Yes Then
            result = True
        End If

        MsgBox(result)

    End Sub
End Class
