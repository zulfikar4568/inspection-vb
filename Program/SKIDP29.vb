Imports System.Data.SqlClient

Imports System.Linq
Imports System.Data.OleDb
Imports Microsoft.Office.Core
Imports Excel = Microsoft.Office.Interop.Excel
Imports ExcelAutoFormat = Microsoft.Office.Interop.Excel.XlRangeAutoFormat
Imports Microsoft.Office.Interop
Imports System.IO
Imports System.Xml.XPath
Imports System.Data
Imports System.Xml

Public Class SKIDP29
    Public SQL As New SQLControl
    Public SKID As SKID
    Dim x, y As Integer
    Dim newpoint As New Point
    Public Sub Loadgrid(Optional Query As String = "")
        If Query = "" Then
            addparam()
            If SKID.P29 = "True" And SKID.P31 = "False" And SKID.P32 = "False" And SKID.P33 = "False" Then
                SQL.ExecQuery("SELECT Waktu.ID, SKID.InspectionCheck, SKID.Standard, SKID.Week, Waktu.Result, Waktu.Tanggal, Waktu.PIC, Waktu.Remark, Waktu.Bulan FROM SKID INNER JOIN Waktu ON SKID.ID = Waktu.Idc WHERE SKID.SKID LIKE '%P29%';")
            End If
            If SKID.P29 = "False" And SKID.P31 = "True" And SKID.P32 = "False" And SKID.P33 = "False" Then
                SQL.ExecQuery("SELECT Waktu.ID, SKID.InspectionCheck, SKID.Standard, SKID.Week, Waktu.Result, Waktu.Tanggal, Waktu.PIC, Waktu.Remark, Waktu.Bulan FROM SKID INNER JOIN Waktu ON SKID.ID = Waktu.Idc WHERE SKID.SKID LIKE '%P31%';")
            End If
            If SKID.P29 = "False" And SKID.P31 = "False" And SKID.P32 = "True" And SKID.P33 = "False" Then
                SQL.ExecQuery("SELECT Waktu.ID, SKID.InspectionCheck, SKID.Standard, SKID.Week, Waktu.Result, Waktu.Tanggal, Waktu.PIC, Waktu.Remark, Waktu.Bulan FROM SKID INNER JOIN Waktu ON SKID.ID = Waktu.Idc WHERE SKID.SKID LIKE '%P32%';")
            End If
            If SKID.P29 = "False" And SKID.P31 = "False" And SKID.P32 = "False" And SKID.P33 = "True" Then
                SQL.ExecQuery("SELECT Waktu.ID, SKID.InspectionCheck, SKID.Standard, SKID.Week, Waktu.Result, Waktu.Tanggal, Waktu.PIC, Waktu.Remark, Waktu.Bulan FROM SKID INNER JOIN Waktu ON SKID.ID = Waktu.Idc WHERE SKID.SKID LIKE '%P33%';")
            End If
        Else
            SQL.ExecQuery(Query)
        End If

        If SQL.HasException(True) Then Exit Sub
        Dg_IC.DataSource = SQL.DBDT
    End Sub

    Private Sub search()
        addparam()
        If SKID.P29 = "True" And SKID.P31 = "False" And SKID.P32 = "False" And SKID.P33 = "False" Then
            Loadgrid("SELECT Waktu.ID, SKID.InspectionCheck, SKID.Standard, SKID.Week, Waktu.Result, Waktu.Tanggal, Waktu.Remark, Waktu.PIC, Waktu.Bulan FROM SKID INNER JOIN Waktu ON SKID.ID = Waktu.Idc WHERE Waktu.Bulan = @bulanp AND Waktu.Tahun = @tahunp AND SKID.SKID LIKE '%P29%';")
        End If
        If SKID.P29 = "False" And SKID.P31 = "True" And SKID.P32 = "False" And SKID.P33 = "False" Then
            Loadgrid("SELECT Waktu.ID, SKID.InspectionCheck, SKID.Standard, SKID.Week, Waktu.Result, Waktu.Tanggal, Waktu.Remark, Waktu.PIC, Waktu.Bulan FROM SKID INNER JOIN Waktu ON SKID.ID = Waktu.Idc WHERE Waktu.Bulan = @bulanp AND Waktu.Tahun = @tahunp AND SKID.SKID LIKE '%P31%';")
        End If
        If SKID.P29 = "False" And SKID.P31 = "False" And SKID.P32 = "True" And SKID.P33 = "False" Then
            Loadgrid("SELECT Waktu.ID, SKID.InspectionCheck, SKID.Standard, SKID.Week, Waktu.Result, Waktu.Tanggal, Waktu.Remark, Waktu.PIC, Waktu.Bulan FROM SKID INNER JOIN Waktu ON SKID.ID = Waktu.Idc WHERE Waktu.Bulan = @bulanp AND Waktu.Tahun = @tahunp AND SKID.SKID LIKE '%P32%';")
        End If
        If SKID.P29 = "False" And SKID.P31 = "False" And SKID.P32 = "False" And SKID.P33 = "True" Then
            Loadgrid("SELECT Waktu.ID, SKID.InspectionCheck, SKID.Standard, SKID.Week, Waktu.Result, Waktu.Tanggal, Waktu.Remark, Waktu.PIC, Waktu.Bulan FROM SKID INNER JOIN Waktu ON SKID.ID = Waktu.Idc WHERE Waktu.Bulan = @bulanp AND Waktu.Tahun = @tahunp AND SKID.SKID LIKE '%P33%';")
        End If
        If SQL.HasException(True) Then Exit Sub
        Dg_IC.DataSource = SQL.DBDT
    End Sub

    Private Sub addparam()
        SQL.AddParam("@bulanp", "" & Cb_BulanP.Text & "")
        SQL.AddParam("@tahunp", "" & Dt_Tahun.Text & "")
        SQL.AddParam("@id", "" & Tb_No.Text & "")
        SQL.AddParam("@ic", "" & Tb_IC.Text & "")
        SQL.AddParam("@standard", "" & Tb_Standard.Text & "")
        SQL.AddParam("@week", "" & Tb_Week.Text & "")
        SQL.AddParam("@result", "" & Cb_Result.Text & "")
        SQL.AddParam("@tanggal", "" & Dt_Tanggal.Value.ToString("yyyy-MM-dd") & "")
        SQL.AddParam("@remark", "" & Tb_Remark.Text & "")
    End Sub

    Private Overloads Sub update()
        addparam()
        If Cb_PIC.Text = "Others" Then
            Tb_PIC.Visible = True
            Loadgrid("UPDATE Waktu SET Result = @result, Tanggal = @tanggal, PIC = '" & Tb_PIC.Text & "', Remark = @remark WHERE ID = @id;")
            If SQL.HasException(True) Then Exit Sub
        Else
            Tb_PIC.Visible = False
            Loadgrid("UPDATE Waktu SET Result = @result, Tanggal = @tanggal, PIC = '" & Cb_PIC.Text & "', Remark = @remark WHERE ID = @id;")
        End If

    End Sub
    Private Sub Cb_PIC_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cb_PIC.SelectedIndexChanged
        If Cb_PIC.Text = "Others" Then
            Tb_PIC.Visible = True
        Else
            Tb_PIC.Visible = False
        End If
    End Sub
    Private Sub Bt_Logout_Click(sender As Object, e As EventArgs) Handles Bt_Logout.Click
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub Bt_minimazed_Click(sender As Object, e As EventArgs) Handles Bt_minimazed.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Bt_Close_Click(sender As Object, e As EventArgs) Handles Bt_Close.Click
        Application.Exit()
    End Sub

    Private Sub Bt_Home_Click(sender As Object, e As EventArgs) Handles Bt_Home.Click
        Me.Close()
        ProgMenu.Show()
    End Sub

    Private Sub PanelSKID_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelSKID.MouseDown
        x = Control.MousePosition.X - Me.Location.X
        y = Control.MousePosition.Y - Me.Location.Y
    End Sub

    Private Sub PanelSKID_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelSKID.MouseMove
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            newpoint = Control.MousePosition
            newpoint.X -= x
            newpoint.Y -= y
            Me.Location = newpoint
            Application.DoEvents()
        End If
    End Sub

    Private Sub SKIDP29_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If SKID.P29 = "True" And SKID.P31 = "False" And SKID.P32 = "False" And SKID.P33 = "False" Then
            LabelSKID.Text = "SKID P-29"
        End If
        If SKID.P29 = "False" And SKID.P31 = "True" And SKID.P32 = "False" And SKID.P33 = "False" Then
            LabelSKID.Text = "SKID P-31"
        End If
        If SKID.P29 = "False" And SKID.P31 = "False" And SKID.P32 = "True" And SKID.P33 = "False" Then
            LabelSKID.Text = "SKID P-32"
        End If
        If SKID.P29 = "False" And SKID.P31 = "False" And SKID.P32 = "False" And SKID.P33 = "True" Then
            LabelSKID.Text = "SKID P-33"
        End If
        search()
        Tb_PIC.Visible = False
        Tb_PIC.Enabled = True
    End Sub


    Private Sub Pb_Search_Click(sender As Object, e As EventArgs) Handles Pb_Search.Click
        DG()
        search()
    End Sub

    Private Sub Pb_All_Click(sender As Object, e As EventArgs) Handles Pb_All.Click
        DG()
        Loadgrid()
    End Sub
    Private Sub Pb_Excell_Click(sender As Object, e As EventArgs) Handles Pb_Excell.Click
        Try
            'Pb_Excell.Text = "Please Wait..."
            Pb_Excell.Enabled = False

            SaveFileDialog1.Filter = "Excel Document (*.xlsx)|*.xlsx"
            If SaveFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                Dim xlApp As Microsoft.Office.Interop.Excel.Application
                Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
                Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
                Dim misValue As Object = System.Reflection.Missing.Value
                Dim i As Integer
                Dim j As Integer

                xlApp = New Microsoft.Office.Interop.Excel.Application
                xlWorkBook = xlApp.Workbooks.Add(misValue)
                xlWorkSheet = xlWorkBook.Sheets("sheet1")

                For i = 0 To Dg_IC.RowCount - 2
                    For j = 0 To Dg_IC.ColumnCount - 1
                        For k As Integer = 1 To Dg_IC.Columns.Count
                            xlWorkSheet.Cells(1, k) = Dg_IC.Columns(k - 1).HeaderText
                            xlWorkSheet.Cells(i + 2, j + 1) = Dg_IC(j, i).Value '.ToString()
                        Next
                    Next
                Next

                xlWorkSheet.SaveAs(SaveFileDialog1.FileName)
                xlWorkBook.Close()
                xlApp.Quit()

                releaseObject(xlApp)
                releaseObject(xlWorkBook)
                releaseObject(xlWorkSheet)

                MsgBox("Sukses Tersimpan!!!" & vbCrLf & "File di simpan di : " & SaveFileDialog1.FileName, MsgBoxStyle.Information, "Informasi")

                'Pb_Excell.Text = "Export To MS Excel"
                Pb_Excell.Enabled = True
            End If
        Catch ex As Exception
            MessageBox.Show("Gagal Menyimpan !!!", "Pesan Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Pb_Excell.Enabled = True
            Return
        End Try
        Pb_Excell.Enabled = True
    End Sub

    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub Pb_Edit_Click(sender As Object, e As EventArgs) Handles Pb_Edit.Click
        update()
        DG()
        search()
    End Sub

    Private Sub Dg_IC_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dg_IC.CellClick
        Dim Index As Integer
        Index = e.RowIndex
        If Index >= 0 Then
            Dim Row As DataGridViewRow
            Row = Me.Dg_IC.Rows(e.RowIndex)
            Tb_No.Text = Row.Cells(0).Value.ToString()
            Tb_IC.Text = Row.Cells(1).Value.ToString()
            Tb_Standard.Text = Row.Cells(2).Value.ToString()
            Tb_Week.Text = Row.Cells(4).Value.ToString()
            Cb_Result.Text = Row.Cells(5).Value.ToString()
            'Dt_Tanggal.Value = CDate(Row.Cells(6).Value.ToString())
            Tb_Remark.Text = Row.Cells(7).Value.ToString()
        End If
    End Sub



    Private Sub DG()
        Dg_IC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        Dg_IC.AutoResizeColumns()
    End Sub
End Class