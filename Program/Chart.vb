Imports System.Data.SqlClient
Imports System.Configuration
Public Class Chart
    Public konek As GlobalVariable
    Dim connection As SqlConnection
    Dim command As SqlCommand
    Dim query As String
    Dim bulan As String
    Dim P29Good, P29NotGood, P29G, P29NG As Integer
    Dim P31Good, P31NotGood, P31G, P31NG As Integer
    Dim P32Good, P32NotGood, P32G, P32NG As Integer
    Dim P33Good, P33NotGood, P33G, P33NG As Integer

    Private Sub Bt_Home_Click(sender As Object, e As EventArgs) Handles Bt_Home.Click
        Me.Close()
        ProgMenu_Admin.Show()
    End Sub

    Private Sub Bt_Logout_Click(sender As Object, e As EventArgs) Handles Bt_Logout.Click
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub Chart1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Nampil()
    End Sub

    Private Sub Nampil()
        For index As Integer = 1 To 12
            If index = 1 Then
                bulan = "Januari"
                TampilP29()
                TampilP31()
                TampilP32()
                TampilP33()
            ElseIf index = 2 Then
                bulan = "Februari"
                TampilP29()
                TampilP31()
                TampilP32()
                TampilP33()
            ElseIf index = 3 Then
                bulan = "Maret"
                TampilP29()
                TampilP31()
                TampilP32()
                TampilP33()
            ElseIf index = 4 Then
                bulan = "April"
                TampilP29()
                TampilP31()
                TampilP32()
                TampilP33()
            ElseIf index = 5 Then
                bulan = "Mei"
                TampilP29()
                TampilP31()
                TampilP32()
                TampilP33()
            ElseIf index = 6 Then
                bulan = "Juni"
                TampilP29()
                TampilP31()
                TampilP32()
                TampilP33()
            ElseIf index = 7 Then
                bulan = "Juli"
                TampilP29()
                TampilP31()
                TampilP32()
                TampilP33()
            ElseIf index = 8 Then
                bulan = "Agustus"
                TampilP29()
                TampilP31()
                TampilP32()
                TampilP33()
            ElseIf index = 9 Then
                bulan = "September"
                TampilP29()
                TampilP31()
                TampilP32()
                TampilP33()
            ElseIf index = 10 Then
                bulan = "Oktober"
                TampilP29()
                TampilP31()
                TampilP32()
                TampilP33()
            ElseIf index = 11 Then
                bulan = "November"
                TampilP29()
                TampilP31()
                TampilP32()
                TampilP33()
            ElseIf index = 12 Then
                bulan = "Desember"
                TampilP29()
                TampilP31()
                TampilP32()
                TampilP33()
            End If
            P29G = P29G + P29Good
            P29NG = P29NG + P29NotGood
            P31G = P31G + P31Good
            P31NG = P31NG + P31NotGood
            P32G = P32G + P32Good
            P32NG = P32NG + P32NotGood
            P33G = P33G + P33Good
            P33NG = P33NG + P33NotGood
        Next
        Chart5.Series("Value").Points.AddXY("Good", P29G)
        Chart5.Series("Value").Points.AddXY("Not Good", P29NG)
        Chart6.Series("Value").Points.AddXY("Good", P31G)
        Chart6.Series("Value").Points.AddXY("Not Good", P31NG)
        Chart7.Series("Value").Points.AddXY("Good", P32G)
        Chart7.Series("Value").Points.AddXY("Not Good", P32NG)
        Chart8.Series("Value").Points.AddXY("Good", P33G)
        Chart8.Series("Value").Points.AddXY("Not Good", P33NG)
    End Sub
    Private Sub TampilP29()
        connection = New SqlConnection
        connection.ConnectionString = konek.ConString
        Dim M1, TotalG, TotalNG, TotalAll As Integer
        Try
            connection.Open()
            query = "SELECT COUNT(Result) FROM SKID INNER JOIN Waktu ON SKID.ID = Waktu.Idc WHERE SKID.SKID = 'P29' AND Waktu.Result = 'Good' AND Waktu.Bulan = '" & bulan & "' AND Waktu.Tahun = '" & Dt_Tahun.Text & "';"
            command = New SqlCommand(query, connection)
            M1 = command.ExecuteScalar()
            TotalG = M1
            P29Good = TotalG
            query = "SELECT COUNT(Result) FROM SKID INNER JOIN Waktu ON SKID.ID = Waktu.Idc WHERE SKID.SKID = 'P29' AND Waktu.Result = 'Not Good' AND Waktu.Bulan = '" & bulan & "' AND Waktu.Tahun = '" & Dt_Tahun.Text & "';"
            command = New SqlCommand(query, connection)
            M1 = command.ExecuteScalar()
            TotalNG = M1
            P29NotGood = TotalNG
            query = "SELECT COUNT(InspectionCheck) FROM SKID INNER JOIN Waktu ON SKID.ID = Waktu.Idc WHERE SKID.SKID = 'P29' AND Waktu.Bulan = '" & bulan & "' AND Waktu.Tahun = '" & Dt_Tahun.Text & "';"
            command = New SqlCommand(query, connection)
            TotalAll = command.ExecuteScalar() - (TotalG + TotalNG)
            Chart1.Series("Good").Points.AddXY(bulan, TotalG)
            Chart1.Series("Not Good").Points.AddXY(bulan, TotalNG)
            Chart1.Series("Belum diisi").Points.AddXY(bulan, TotalAll)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connection.Dispose()
        End Try
    End Sub

    Private Sub TampilP31()
        connection = New SqlConnection
        connection.ConnectionString = konek.ConString
        Dim M1, TotalG, TotalNG, TotalAll As Integer
        Try
            connection.Open()
            query = "SELECT COUNT(Result) FROM SKID INNER JOIN Waktu ON SKID.ID = Waktu.Idc WHERE SKID.SKID = 'P31' AND Waktu.Result = 'Good' AND Waktu.Bulan = '" & bulan & "' AND Waktu.Tahun = '" & Dt_Tahun.Text & "';"
            command = New SqlCommand(query, connection)
            M1 = command.ExecuteScalar()
            TotalG = M1
            P31Good = TotalG
            query = "SELECT COUNT(Result) FROM SKID INNER JOIN Waktu ON SKID.ID = Waktu.Idc WHERE SKID.SKID = 'P31' AND Waktu.Result = 'Not Good' AND Waktu.Bulan = '" & bulan & "' AND Waktu.Tahun = '" & Dt_Tahun.Text & "';"
            command = New SqlCommand(query, connection)
            M1 = command.ExecuteScalar()
            TotalNG = M1
            P31NotGood = TotalNG
            query = "SELECT COUNT(InspectionCheck) FROM SKID INNER JOIN Waktu ON SKID.ID = Waktu.Idc WHERE SKID.SKID = 'P31' AND Waktu.Bulan = '" & bulan & "' AND Waktu.Tahun = '" & Dt_Tahun.Text & "';"
            command = New SqlCommand(query, connection)
            TotalAll = command.ExecuteScalar() - (TotalG + TotalNG)
            Chart2.Series("Good").Points.AddXY(bulan, TotalG)
            Chart2.Series("Not Good").Points.AddXY(bulan, TotalNG)
            Chart2.Series("Belum diisi").Points.AddXY(bulan, TotalAll)

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connection.Dispose()
        End Try
    End Sub

    Private Sub TampilP32()
        connection = New SqlConnection
        connection.ConnectionString = konek.ConString
        Dim M1, TotalG, TotalNG, TotalAll As Integer
        Try
            connection.Open()
            query = "SELECT COUNT(Result) FROM SKID INNER JOIN Waktu ON SKID.ID = Waktu.Idc WHERE SKID.SKID = 'P32' AND Waktu.Result = 'Good' AND Waktu.Bulan = '" & bulan & "' AND Waktu.Tahun = '" & Dt_Tahun.Text & "';"
            command = New SqlCommand(query, connection)
            M1 = command.ExecuteScalar()
            TotalG = M1
            P32Good = TotalG
            query = "SELECT COUNT(Result) FROM SKID INNER JOIN Waktu ON SKID.ID = Waktu.Idc WHERE SKID.SKID = 'P32' AND Waktu.Result = 'Not Good' AND Waktu.Bulan = '" & bulan & "' AND Waktu.Tahun = '" & Dt_Tahun.Text & "';"
            command = New SqlCommand(query, connection)
            M1 = command.ExecuteScalar()
            TotalNG = M1
            P32NotGood = TotalNG
            query = "SELECT COUNT(InspectionCheck) FROM SKID INNER JOIN Waktu ON SKID.ID = Waktu.Idc WHERE SKID.SKID = 'P32' AND Waktu.Bulan = '" & bulan & "' AND Waktu.Tahun = '" & Dt_Tahun.Text & "';"
            command = New SqlCommand(query, connection)
            TotalAll = command.ExecuteScalar() - (TotalG + TotalNG)
            Chart3.Series("Good").Points.AddXY(bulan, TotalG)
            Chart3.Series("Not Good").Points.AddXY(bulan, TotalNG)
            Chart3.Series("Belum diisi").Points.AddXY(bulan, TotalAll)

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connection.Dispose()
        End Try
    End Sub

    Private Sub TampilP33()
        connection = New SqlConnection
        connection.ConnectionString = konek.ConString
        Dim M1, TotalG, TotalNG, TotalAll As Integer
        Try
            connection.Open()
            query = "SELECT COUNT(Result) FROM SKID INNER JOIN Waktu ON SKID.ID = Waktu.Idc WHERE SKID.SKID = 'P33' AND Waktu.Result = 'Good' AND Waktu.Bulan = '" & bulan & "' AND Waktu.Tahun = '" & Dt_Tahun.Text & "';"
            command = New SqlCommand(query, connection)
            M1 = command.ExecuteScalar()
            TotalG = M1
            P33Good = TotalG
            query = "SELECT COUNT(Result) FROM SKID INNER JOIN Waktu ON SKID.ID = Waktu.Idc WHERE SKID.SKID = 'P33' AND Waktu.Result = 'Not Good' AND Waktu.Bulan = '" & bulan & "' AND Waktu.Tahun = '" & Dt_Tahun.Text & "';"
            command = New SqlCommand(query, connection)
            M1 = command.ExecuteScalar()
            TotalNG = M1
            P33NotGood = TotalNG
            query = "SELECT COUNT(InspectionCheck) FROM SKID INNER JOIN Waktu ON SKID.ID = Waktu.Idc WHERE SKID.SKID = 'P33' AND Waktu.Result = '" & bulan & "' AND Waktu.Tahun = '" & Dt_Tahun.Text & "';"
            command = New SqlCommand(query, connection)
            TotalAll = command.ExecuteScalar() - (TotalG + TotalNG)
            Chart4.Series("Good").Points.AddXY(bulan, TotalG)
            Chart4.Series("Not Good").Points.AddXY(bulan, TotalNG)
            Chart4.Series("Belum diisi").Points.AddXY(bulan, TotalAll)

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connection.Dispose()
        End Try
    End Sub

    Private Sub Dt_Tahun_ValueChanged(sender As Object, e As EventArgs) Handles Dt_Tahun.ValueChanged
        updatechart1()
        updatechart2()
        updatechart3()
        updatechart4()
        updatechart5()
        updatechart6()
        updatechart7()
        updatechart8()
        Nampil()
    End Sub

    Private Sub updatechart1()
        Chart1.Series.Clear()
        Dim Good As New DataVisualization.Charting.Series
        With Good
            .Name = "Good"
            .ChartType = DataVisualization.Charting.SeriesChartType.Column
            .Color = Color.Lime
            .IsValueShownAsLabel = True
        End With
        Chart1.Series.Add(Good)
        Dim NotGood As New DataVisualization.Charting.Series
        With NotGood
            .Name = "Not Good"
            .ChartType = DataVisualization.Charting.SeriesChartType.Column
            .Color = Color.Yellow
            .IsValueShownAsLabel = True
        End With
        Chart1.Series.Add(NotGood)
        Dim All As New DataVisualization.Charting.Series
        With All
            .Name = "Belum diisi"
            .ChartType = DataVisualization.Charting.SeriesChartType.Column
            .Color = Color.Red
            .IsValueShownAsLabel = True
        End With
        Chart1.Series.Add(All)
    End Sub
    Private Sub updatechart2()
        Chart2.Series.Clear()
        Dim Good As New DataVisualization.Charting.Series
        With Good
            .Name = "Good"
            .ChartType = DataVisualization.Charting.SeriesChartType.Column
            .Color = Color.Lime
            .IsValueShownAsLabel = True
        End With
        Chart2.Series.Add(Good)
        Dim NotGood As New DataVisualization.Charting.Series
        With NotGood
            .Name = "Not Good"
            .ChartType = DataVisualization.Charting.SeriesChartType.Column
            .Color = Color.Yellow
            .IsValueShownAsLabel = True
        End With
        Chart2.Series.Add(NotGood)
        Dim All As New DataVisualization.Charting.Series
        With All
            .Name = "Belum diisi"
            .ChartType = DataVisualization.Charting.SeriesChartType.Column
            .Color = Color.Red
            .IsValueShownAsLabel = True
        End With
        Chart2.Series.Add(All)
    End Sub
    Private Sub updatechart3()
        Chart3.Series.Clear()
        Dim Good As New DataVisualization.Charting.Series
        With Good
            .Name = "Good"
            .ChartType = DataVisualization.Charting.SeriesChartType.Column
            .Color = Color.Lime
            .IsValueShownAsLabel = True
        End With
        Chart3.Series.Add(Good)
        Dim NotGood As New DataVisualization.Charting.Series
        With NotGood
            .Name = "Not Good"
            .ChartType = DataVisualization.Charting.SeriesChartType.Column
            .Color = Color.Yellow
            .IsValueShownAsLabel = True
        End With
        Chart3.Series.Add(NotGood)
        Dim All As New DataVisualization.Charting.Series
        With All
            .Name = "Belum diisi"
            .ChartType = DataVisualization.Charting.SeriesChartType.Column
            .Color = Color.Red
            .IsValueShownAsLabel = True
        End With
        Chart3.Series.Add(All)
    End Sub
    Private Sub updatechart4()
        Chart4.Series.Clear()
        Dim Good As New DataVisualization.Charting.Series
        With Good
            .Name = "Good"
            .ChartType = DataVisualization.Charting.SeriesChartType.Column
            .Color = Color.Lime
            .IsValueShownAsLabel = True
        End With
        Chart4.Series.Add(Good)
        Dim NotGood As New DataVisualization.Charting.Series
        With NotGood
            .Name = "Not Good"
            .ChartType = DataVisualization.Charting.SeriesChartType.Column
            .Color = Color.Yellow
            .IsValueShownAsLabel = True
        End With
        Chart4.Series.Add(NotGood)
        Dim All As New DataVisualization.Charting.Series
        With All
            .Name = "Belum diisi"
            .ChartType = DataVisualization.Charting.SeriesChartType.Column
            .Color = Color.Red
            .IsValueShownAsLabel = True
        End With
        Chart4.Series.Add(All)
    End Sub

    Private Sub updatechart5()
        Chart5.Series.Clear()
        Dim Value As New DataVisualization.Charting.Series
        With Value
            .Name = "Value"
            .ChartType = DataVisualization.Charting.SeriesChartType.Pie
            .IsValueShownAsLabel = True
        End With
        Chart5.Series.Add(Value)
    End Sub
    Private Sub updatechart6()
        Chart6.Series.Clear()
        Dim Value As New DataVisualization.Charting.Series
        With Value
            .Name = "Value"
            .ChartType = DataVisualization.Charting.SeriesChartType.Pie
            .IsValueShownAsLabel = True
        End With
        Chart6.Series.Add(Value)
    End Sub
    Private Sub updatechart7()
        Chart7.Series.Clear()
        Dim Value As New DataVisualization.Charting.Series
        With Value
            .Name = "Value"
            .ChartType = DataVisualization.Charting.SeriesChartType.Pie
            .IsValueShownAsLabel = True
        End With
        Chart7.Series.Add(Value)
    End Sub
    Private Sub updatechart8()
        Chart8.Series.Clear()
        Dim Value As New DataVisualization.Charting.Series
        With Value
            .Name = "Value"
            .ChartType = DataVisualization.Charting.SeriesChartType.Pie
            .IsValueShownAsLabel = True
        End With
        Chart8.Series.Add(Value)
    End Sub
End Class