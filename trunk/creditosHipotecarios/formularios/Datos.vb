Public Module Datos

    Public Structure SesionUser
        Public usuario As Integer
        Public cargo As String
        Public codigoAgencia As String
    End Structure

    Public UsuarioActivo As SesionUser
    Public CargoUsuario As SesionUser
    Public codigoAgencia As SesionUser

End Module
