Imports DevExpress.LookAndFeel
Imports DevExpress.XtraEditors

Module common
    Public connection_problem As Boolean = False
    Public id_user As String
    Public id_role_login As String

    Sub apply_skin()
        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.UserSkins.BonusSkins.Register()
        UserLookAndFeel.Default.UseWindowsXPTheme = False
        UserLookAndFeel.Default.SkinName = "Metropolis"
    End Sub
    Sub errorProcess()
        XtraMessageBox.Show("Process Error, please try again later", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Sub errorConnection()
        XtraMessageBox.Show("Connection failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Sub errorDuplicate(ByVal value As String)
        XtraMessageBox.Show("Proses Failed, Duplicate" & value, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Sub errorDelete()
        XtraMessageBox.Show("Delete failed, this data currently used", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Sub errorInput()
        XtraMessageBox.Show("Please check your input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Sub errorCustom(ByVal err_msg As String)
        XtraMessageBox.Show(err_msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Sub stopCustom(ByVal stop_msg As String)
        XtraMessageBox.Show(stop_msg, "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop)
    End Sub

    Sub infoCustom(ByVal info_msg As String)
        XtraMessageBox.Show(info_msg, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Sub warningCustom(ByVal warning_msg As String)
        XtraMessageBox.Show(warning_msg, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub
End Module
