Public Class FormDashboard
    Private Sub FormDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        apply_skin()
        Cursor = Cursors.WaitCursor
        Try
            read_database_configuration()
            check_connection(True, "", "", "", "")
            Cursor = Cursors.Default
            Opacity = 100
        Catch ex As Exception
            Cursor = Cursors.Default
            connection_problem = True
            Opacity = 0
            FormDatabase.id_type = "2"
            FormDatabase.TopMost = True
            FormDatabase.Show()
            FormDatabase.Focus()
            FormDatabase.TopMost = False
            Exit Sub
        End Try

        My.Application.ChangeCulture("en-US")
        My.Application.Culture.NumberFormat.NumberDecimalSeparator = ","
        My.Application.Culture.NumberFormat.NumberGroupSeparator = "."
        Cursor = Cursors.Default
    End Sub

    Private Sub PIClose_Click(sender As Object, e As EventArgs) Handles PIClose.Click
        Close()
    End Sub

    Private Sub PIClose_MouseHover(sender As Object, e As EventArgs) Handles PIClose.MouseHover
        PIClose.BackColor = Color.LightSkyBlue
    End Sub

    Private Sub PIClose_MouseLeave(sender As Object, e As EventArgs) Handles PIClose.MouseLeave
        PIClose.BackColor = Color.Transparent
    End Sub

    Private Sub PictureEdit4_Click(sender As Object, e As EventArgs) Handles PictureEdit4.Click
        Close()
    End Sub

    Private Sub LabelControl5_Click(sender As Object, e As EventArgs) Handles LabelControl5.Click
        Close()
    End Sub

    Private Sub LMaster_Click(sender As Object, e As EventArgs) Handles LMaster.Click
        FormMasterDesign.ShowDialog()
    End Sub

    Private Sub PIMaster_Click(sender As Object, e As EventArgs) Handles PIMaster.Click
        FormMasterDesign.ShowDialog()
    End Sub
End Class