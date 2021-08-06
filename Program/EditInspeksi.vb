Imports System.Data.SqlClient
Imports System.Configuration
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

Public Class EditInspeksi
    Public SQL As New SQLControl
    Public SKID As SKID
    Dim x, y As Integer
    Dim newpoint As New Point
    Public Sub Loadgrid(Optional Query As String = "")
        If Query = "" Then
            addparam()
            SQL.ExecQuery("SELECT ID, InspectionCheck, Standard, SKID, Week FROM SKID;")
        Else
            SQL.ExecQuery(Query)
        End If

        If SQL.HasException(True) Then Exit Sub
        Dg_IC.DataSource = SQL.DBDT
    End Sub

    '**********************************************************************************SEARCH************************************************************

    Private Sub search()
        addparam()
        Loadgrid("SELECT ID, InspectionCheck, Standard, SKID, Week FROM SKID WHERE SKID = @skidp;")
        If SQL.HasException(True) Then Exit Sub
        Dg_IC.DataSource = SQL.DBDT
    End Sub
    '***********************************************************************************Tambah*************************************************************
    Private Sub addparam()
        SQL.AddParam("@week", "" & Cb_Week.Text & "")
        SQL.AddParam("@skidp", "" & Cb_CariSKID.Text & "")
        SQL.AddParam("@skid", "" & Cb_SKID.Text & "")
        SQL.AddParam("@id", "" & Tb_No.Text & "")
        SQL.AddParam("@ic", "" & Tb_IC.Text & "")
        SQL.AddParam("@standard", "" & Tb_Standard.Text & "")
    End Sub

    '**********************************************************************************************Tambah****************************************

    Private Sub tambah()
        addparam()
        SQL.ExecQuery("INSERT INTO SKID (SKID,InspectionCheck, Standard, Week) VALUES (@skid,@ic,@standard,@week);")
        For indexplus As Integer = 2018 To 2100 Step 1
            SQL.ExecQuery("INSERT INTO Waktu (Idc,Tahun,Bulan) SELECT MAX(ID),'" & indexplus & "','Januari' FROM SKID;")
            SQL.ExecQuery("INSERT INTO Waktu (Idc,Tahun,Bulan) SELECT MAX(ID),'" & indexplus & "','Februari' FROM SKID;")
            SQL.ExecQuery("INSERT INTO Waktu (Idc,Tahun,Bulan) SELECT MAX(ID),'" & indexplus & "','Maret' FROM SKID;")
            SQL.ExecQuery("INSERT INTO Waktu (Idc,Tahun,Bulan) SELECT MAX(ID),'" & indexplus & "','April' FROM SKID;")
            SQL.ExecQuery("INSERT INTO Waktu (Idc,Tahun,Bulan) SELECT MAX(ID),'" & indexplus & "','Mei' FROM SKID;")
            SQL.ExecQuery("INSERT INTO Waktu (Idc,Tahun,Bulan) SELECT MAX(ID),'" & indexplus & "','Juni' FROM SKID;")
            SQL.ExecQuery("INSERT INTO Waktu (Idc,Tahun,Bulan) SELECT MAX(ID),'" & indexplus & "','Juli' FROM SKID;")
            SQL.ExecQuery("INSERT INTO Waktu (Idc,Tahun,Bulan) SELECT MAX(ID),'" & indexplus & "','Agustus' FROM SKID;")
            SQL.ExecQuery("INSERT INTO Waktu (Idc,Tahun,Bulan) SELECT MAX(ID),'" & indexplus & "','September' FROM SKID;")
            SQL.ExecQuery("INSERT INTO Waktu (Idc,Tahun,Bulan) SELECT MAX(ID),'" & indexplus & "','Oktober' FROM SKID;")
            SQL.ExecQuery("INSERT INTO Waktu (Idc,Tahun,Bulan) SELECT MAX(ID),'" & indexplus & "','November' FROM SKID;")
            SQL.ExecQuery("INSERT INTO Waktu (Idc,Tahun,Bulan) SELECT MAX(ID),'" & indexplus & "','Desember' FROM SKID;")
        Next
    End Sub
    '******************************************************************************Update**************************************************************************
    Private Overloads Sub update()
        addparam()
        Loadgrid("UPDATE SKID SET InspectionCheck = @ic, Standard = @standard, SKID = @skid, Week = @week WHERE ID = @id;")
    End Sub
    '******************************************************************************Hapus***************************************************************************
    Private Sub Hapus()
        Dim result As Integer = MessageBox.Show("Apakah yakin jenis Inspeksi akan dihapus?", "Perhatian !!!", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            addparam()
            Loadgrid("DELETE FROM SKID WHERE ID = @id;")
            addparam()
            Loadgrid("DELETE FROM Waktu WHERE Idc = @id;")
        ElseIf result = DialogResult.No Then

        End If
    End Sub
    '***************************************************************************************************************************************************************
    '***************************************************************************************************************************************************************
    '***************************************************************************************************************************************************************



    Private Sub EditInspeksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DG()
        search()
    End Sub
    Private Sub Pb_Search_Click(sender As Object, e As EventArgs) Handles Pb_Search.Click
        DG()
        search()
    End Sub

    Private Sub Pb_All_Click(sender As Object, e As EventArgs) Handles Pb_All.Click
        DG()
        Loadgrid()
    End Sub
    Private Sub Pb_Edit_Click(sender As Object, e As EventArgs) Handles Pb_Edit.Click
        update()
        DG()
        search()
    End Sub
    Private Sub Pb_Add_Click(sender As Object, e As EventArgs) Handles Pb_Add.Click
        tambah()
        search()
    End Sub
    Private Sub Pb_Hapus_Click(sender As Object, e As EventArgs) Handles Pb_Hapus.Click
        Hapus()
        DG()
        search()
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
    Private Sub Pb_Excell_Click(sender As Object, e As EventArgs) Handles Pb_Excell.Click
        Try
            Pb_Excell.Text = "Please Wait..."
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
                            xlWorkSheet.Cells(i + 2, j + 1) = Dg_IC(j, i).Value.ToString()
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

                Pb_Excell.Text = "Export To MS Excel"
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



    Private Sub Dg_IC_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dg_IC.CellClick
        Dim Index As Integer
        Index = e.RowIndex
        If Index >= 0 Then
            Dim Row As DataGridViewRow
            Row = Me.Dg_IC.Rows(e.RowIndex)
            Tb_No.Text = Row.Cells(0).Value.ToString()
            Tb_IC.Text = Row.Cells(1).Value.ToString()
            Tb_Standard.Text = Row.Cells(2).Value.ToString()
            Cb_SKID.Text = Row.Cells(3).Value.ToString()
            Cb_Week.Text = Row.Cells(4).Value.ToString()
        End If
    End Sub

    Private Sub DG()
        Dg_IC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        Dg_IC.AutoResizeColumns()
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
End Class