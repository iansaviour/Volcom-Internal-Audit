Public Class FormMasterDesign
    Dim bnew_active As String = "1"
    Dim bedit_active As String = "1"
    Dim bdel_active As String = "1"

    Private Sub FormMasterProduct_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        apply_skin()
        view_design()
    End Sub

    Sub view_design()
        Try
            Dim query As String = "CALL view_all_design()"
            Dim data As DataTable = execute_query(query, -1, True, "", "", "", "")
            GCDesign.DataSource = data
            check_menu()
            If data.Rows.Count > 0 Then
                view_product(GVDesign.GetFocusedRowCellDisplayText("id_design").ToString)
                'XTPProduct.PageVisible = True
                GVDesign.FocusedRowHandle = 0
            Else
                'XTPProduct.PageVisible = False
            End If
        Catch ex As Exception
            errorConnection()
        End Try
    End Sub

    Sub view_product(ByVal id_design As String)
        Try
            Dim query As String = "CALL view_product_master('" & id_design & "')"
            Dim data As DataTable = execute_query(query, -1, True, "", "", "", "")
            'GCProduct.DataSource = data
            check_menu()
        Catch ex As Exception
            errorConnection()
        End Try
    End Sub

    Private Sub GVDesign_RowClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GVDesign.RowClick
        'view_product(GVDesign.GetFocusedRowCellDisplayText("id_design").ToString)
        'LabelPrintedName.Text = GVDesign.GetFocusedRowCellDisplayText("design_name").ToString
    End Sub

    Private Sub GVDesign_FocusedRowChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GVDesign.FocusedRowChanged
        noManipulating()
    End Sub

    Sub noManipulating()
        Try
            Dim indeks As Integer = GVDesign.FocusedRowHandle
            If indeks < 0 Then
                bnew_active = "1"
                bedit_active = "0"
                bdel_active = "0"
            Else
                bnew_active = "1"
                bedit_active = "1"
                bdel_active = "1"
            End If
            button_main(bnew_active, bedit_active, bdel_active)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub GVDesign_CustomColumnDisplayText(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles GVDesign.CustomColumnDisplayText
        If e.Column.FieldName = "id_season" Then
            Dim rowhandle As Integer = e.ListSourceRowIndex
            If GVDesign.IsGroupRow(rowhandle) Then
                rowhandle = GVDesign.GetDataRowHandleByGroupRowHandle(rowhandle)
                e.DisplayText = GVDesign.GetRowCellDisplayText(rowhandle, "season")
            End If
        End If
    End Sub

    Sub button_main(ByVal bnew As String, ByVal bedit As String, ByVal bdel As String)
        If bnew = "1" Then

        End If
    End Sub
    Sub check_menu()
        If GVDesign.RowCount < 1 Then
            'hide all except new
            bnew_active = "1"
            bedit_active = "0"
            bdel_active = "0"
            button_main(bnew_active, bedit_active, bdel_active)
            '
        Else
            'show all
            bnew_active = "1"
            bedit_active = "1"
            bdel_active = "1"
            button_main(bnew_active, bedit_active, bdel_active)
            '
        End If
    End Sub

    Private Sub BClose_Click(sender As Object, e As EventArgs) Handles BClose.Click
        Close()
    End Sub
End Class