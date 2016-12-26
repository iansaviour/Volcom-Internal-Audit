Imports DevExpress.LookAndFeel

Module common
    Sub apply_skin()
        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.UserSkins.BonusSkins.Register()
        UserLookAndFeel.Default.UseWindowsXPTheme = False
        UserLookAndFeel.Default.SkinName = "Metropolis"
    End Sub
End Module
