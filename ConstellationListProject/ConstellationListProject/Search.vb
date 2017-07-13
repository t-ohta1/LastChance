Public Class Search


    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles searchButton.Click

        Dim season As String = condition.SelectedValue
        Dim dao As New SearchDao
        Dim constellationList As List(Of String)


        constellationList = dao.searchConstellation(season)

        resultView.Clear()

        resultView.View = View.Details

        resultView.Columns.Add("星座名", 118, HorizontalAlignment.Center)

        For i As Integer = 0 To constellationList.Count - 1

            resultView.Items.Add(constellationList(i))

            If i Mod 2 = 0 Then
                resultView.Items(i).BackColor = Color.Cyan
            End If

        Next

        resultView.GridLines = True


    End Sub

    Private Sub Search_Load(sender As Object, e As EventArgs) Handles Me.Load

        'DataTableオブジェクトの作成
        Dim seasonTable As New DataTable()

        'DataTableに列追加
        seasonTable.Columns.Add("ID", GetType(String))
        seasonTable.Columns.Add("NAME", GetType(String))

        '配列の用意
        Dim rowDataArray As String(,) = {{"0", "春"},
                                        {"1", "夏"},
                                        {"2", "秋"},
                                        {"3", "冬"}}

        For i As Integer = 0 To rowDataArray.GetLength(0) - 1
            '新しい行を作成
            Dim row As DataRow = seasonTable.NewRow()

            '各列に値をセット
            row("ID") = rowDataArray(i, 0)
            row("NAME") = rowDataArray(i, 1)

            'DataTableに行を追加
            seasonTable.Rows.Add(row)
        Next

        'コンボボックスのDataSourceにDataTableを割り当てる
        condition.DataSource = seasonTable

        '表示される値はDataTableのNAME列
        condition.DisplayMember = "NAME"

        '対応する値はDataTableのID列
        condition.ValueMember = "ID"

    End Sub

    Private Sub resultView_ColumnWidthChanging(sender As Object, e As ColumnWidthChangingEventArgs) Handles resultView.ColumnWidthChanging
        e.NewWidth = Me.resultView.Columns(e.ColumnIndex).Width
        e.Cancel = True
    End Sub
End Class