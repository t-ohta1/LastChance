Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        addRows(12)



    End Sub

    Sub addRows(rows As Integer)

        For i = 1 To rows

            DataGridView1.Rows.Add()

        Next
    End Sub
End Class
