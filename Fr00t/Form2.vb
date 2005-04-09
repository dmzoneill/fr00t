Public Class Form2
    Dim allowed(250) As String
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' allowed apps pre defined


        allowed(0) = "NPROTECT"
        allowed(1) = "SVCHOST"
        allowed(2) = "NAVAPSVC"
        allowed(3) = "SPBBCSvc"
        allowed(4) = "symlcsvc"
        allowed(5) = "svchost"
        allowed(6) = "winlogon"
        allowed(7) = "WINLOGON"
        allowed(8) = "gcasDtServ"
        allowed(9) = "CCAPP"
        allowed(10) = "rundll32"
        allowed(11) = "LSASS"
        allowed(12) = "svchost"
        allowed(13) = "explorer"
        allowed(14) = "stop"
        allowed(15) = "atiptaxx"
        allowed(16) = "NPFMNTOR"
        allowed(17) = "NMBgMonitor"
        allowed(18) = "spoolsv"
        allowed(19) = "MDM"
        allowed(20) = "smss"
        allowed(21) = "SNDSrvc"
        allowed(22) = "lsass"
        allowed(23) = "taskkill"
        allowed(24) = "svchost"
        allowed(25) = "csrss"
        allowed(26) = "CCSETMGR"
        allowed(27) = "services"
        allowed(28) = "SERVICES"
        allowed(29) = "svchost"
        allowed(30) = "CCEVTMGR"
        allowed(31) = "ati2evxx"
        allowed(32) = "alg"
        allowed(33) = "svchost"
        allowed(34) = "NOPDB"
        allowed(35) = "ati2evxx"
        allowed(36) = "ctfmon"
        allowed(37) = "cmd"
        allowed(38) = "TaskSwitch"
        allowed(39) = "System"
        allowed(40) = "Idle"
        allowed(41) = "ScreenShield"
        allowed(42) = "Click Here Program Stopper.vshost"
        allowed(43) = "devenv"
        allowed(44) = "EXPLORER"
        allowed(45) = "NMain"
        

        Dim f As Integer
        For f = 0 To allowed.Length - 1
            If allowed(f) = "" Then

                Continue For
            End If
            ListView1.Items.Add(allowed(f))
        Next

    End Sub

End Class