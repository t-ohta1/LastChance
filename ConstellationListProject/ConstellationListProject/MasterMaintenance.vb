Public Class MasterMaintenance

    Dim endType As Integer
    '0がユーザ、1が星座
    Dim maintenanceType As Integer

    Dim cn As System.Data.SqlClient.SqlConnection

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        endType = 0

        Me.Close()

    End Sub

    Private Sub MasterMaintenance_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

        If endType = 0 Then

            MaintenanceMenu.Show()

            My.Application.ApplicationContext.MainForm = MaintenanceMenu

        End If
    End Sub

    Private Sub MasterMaintenance_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        connectDb()

        If Label2.Text = "ユーザー" Then

            maintenanceType = 0

        ElseIf Label2.Text = "星座" Then

            maintenanceType = 1

        End If

        setData()

        closeConnection()

    End Sub

    Sub connectDb()

        Try

            Dim serverName As String = "192.168.0.173"
            Dim dbName As String = "master"
            Dim userName As String = "sa"
            Dim password As String = "SaPassword2017"

            cn = New System.Data.SqlClient.SqlConnection()

            cn.ConnectionString =
                "Data Source = " & serverName &
                ";Initial Catalog = " & dbName &
                ";User ID = " & userName &
                ";Password = " & password

            cn.Open()

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

    Sub setData()

        Dim cmd As New SqlClient.SqlCommand

        cmd.Connection = cn
        cmd.CommandType = CommandType.Text

        Dim sr As SqlClient.SqlDataReader

        If maintenanceType = 0 Then

            cmd.CommandText = "SELECT G_ROW.USER_NAME FROM(
                                SELECT ROW_NUMBER() OVER(ORDER BY USER_ID ASC) AS ROW,
                                    USER_NAME
                                FROM M_USER)G_ROW
                                WHERE G_ROW.ROW BETWEEN 1 AND 4"

        ElseIf maintenanceType = 1 Then

            cmd.CommandText = "SELECT G_ROW.CONSTELLATION_NAME FROM(
                                SELECT ROW_NUMBER() OVER(ORDER BY CONSTELLATION_ID ASC) AS ROW,
                                    CONSTELLATION_NAME
                                FROM M_CONSTELLATION)G_ROW
                                WHERE G_ROW.ROW BETWEEN 1 AND 5"
        End If

        sr = cmd.ExecuteReader()

        cmd.Dispose()

        sr.Read()

        TextBox1.Text = sr(0).ToString()
        sr.Read()
        TextBox2.Text = sr(0).ToString()
        sr.Read()
        TextBox3.Text = sr(0).ToString()
        sr.Read()
        TextBox4.Text = sr(0).ToString()

    End Sub

    Sub closeConnection()

        If cn.State <> ConnectionState.Closed Then

            cn.Close()
            cn.Dispose()

        End If
    End Sub
End Class