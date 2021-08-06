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

Public Class Historical
    Public SQL As New SQLControl
    Dim x, y As Integer
    Dim newpoint As New Point
    Public Sub Loadgrid(Optional Query As String = "")
        If Query = "" Then
            addparam()
            Loadgrid("SELECT SKID.InspectionCheck, SKID.Standard, SKID.Week, Waktu.Result, Waktu.Tanggal, Waktu.Remark, Waktu.PIC FROM SKID INNER JOIN Waktu ON SKID.ID = Waktu.Idc;")
        Else
            SQL.ExecQuery(Query)
        End If

        If SQL.HasException(True) Then Exit Sub
        Dg_IC.DataSource = SQL.DBDT
    End Sub

    Private Sub search()
        addparam()
        Loadgrid("SELECT SKID.InspectionCheck, SKID.Standard, SKID.Week, Waktu.Result, Waktu.Tanggal, Waktu.Remark, Waktu.PIC FROM SKID INNER JOIN Waktu ON SKID.ID = Waktu.Idc WHERE Waktu.Bulan = @bulanp AND Waktu.Tahun = @tahunp AND SKID.SKID = @skidp;")
        If SQL.HasException(True) Then Exit Sub
        Dg_IC.DataSource = SQL.DBDT
    End Sub

    Private Sub addparam()
        SQL.AddParam("@bulanp", Cb_BulanP.Text)
        SQL.AddParam("@tahunp", Dt_Tahun.Text)
        SQL.AddParam("@skidp", Cb_SKIDp.Text)
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
        ProgMenu_Admin.Show()
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

    Private Sub Historical_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        search()
    End Sub


    Private Sub Pb_Search_Click(sender As Object, e As EventArgs) Handles Pb_Search.Click
        DG()
        search()
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

                ' Pb_Excell.Text = "Export To MS Excel"
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
    Private Sub DG()
        Dg_IC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        Dg_IC.AutoResizeColumns()
    End Sub

End Class