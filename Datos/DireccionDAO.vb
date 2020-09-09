Imports ADODB
Imports Dominio
Public Class DireccionDAO
    Inherits DBConnection

    Public Sub Insert(direccion As Direccion)
        Dim query As String = "INSERT INTO direcciones(calle, numero, localidad, departamento, detalle) VALUES('" & direccion.Calle & "'," & direccion.Nro & ",'" & direccion.Localidad & "'," & direccion.Departamento & ",'" & direccion.Detalle & "');"

        ' La inserción de direcciones se realiza SIEMPRE
        ' en conjunto con otra entidad, por lo que, cuando
        ' este procedimiento se ejecute, la conexión estará
        ' abierta.
        Try
            Conn.Execute(query)
        Catch ex As Exception
            Throw New ApplicationException("No se pudo ingresar la dirección del paciente.")
        End Try
    End Sub
End Class
