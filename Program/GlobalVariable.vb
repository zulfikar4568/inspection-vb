Imports System.Data.SqlClient
Imports System.Configuration
Public Class GlobalVariable
    Public Shared Back As String = "False"
    Public Shared ConString As String = Convert.ToString(ConfigurationManager.ConnectionStrings("PIC2").ConnectionString)
    'Public Shared ConString As String = "Data Source=ZULFIKAR_PC\SQLEXPRESS;Initial Catalog=PIC;Integrated Security=True"
End Class
Public Class SKID
    Public Shared P29 As String = "False"
    Public Shared P31 As String = "False"
    Public Shared P32 As String = "False"
    Public Shared P33 As String = "False"
End Class