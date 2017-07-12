Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        addRows(12)

        DataGridView1(0, 1).Value = 1

    End Sub

    Sub addRows(rows As Integer)

        For i = 1 To rows

            DataGridView1.Rows.Add()

        Next
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class
