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

    Public Function GetId(direccion As Direccion) As Integer
        Dim rs As Recordset
        Dim id As Integer
        ' Consulta para obtener el id de la dirección ingresada
        Dim query = "SELECT id FROM direcciones" &
                              " WHERE calle='" & direccion.Calle & "'" &
                              " AND numero='" & direccion.Nro & "'" &
                              " AND localidad='" & direccion.Localidad & "'" &
                              " AND departamento=" & direccion.Departamento & ";"
        Try
            rs = Conn.Execute(query)
            If Not rs.BOF Then
                id = rs.Fields("id").Value
                Return id
            Else
                Throw New Exception("Error al obtener el ID de la dirección.")
            End If


        Catch ex As Exception
            Throw New Exception("Error al obtener el ID de la dirección.")
        End Try
    End Function

    Public Function GetIdByCi(pCi As Integer) As Integer
        Dim rs As Recordset
        Dim id As Integer
        ' Consulta para obtener el id de la dirección ingresada
        Dim query = "SELECT id FROM personas AS P JOIN direcciones AS D ON (P.idDireccion = D.id AND P.ci=" & pCi & ");"
        Try
            rs = Conn.Execute(query)
            If Not rs.BOF Then
                id = rs.Fields("id").Value
                Return id
            Else
                Throw New Exception("Error al obtener el ID de la dirección.")
            End If


        Catch ex As Exception
            Throw New Exception("Error al obtener el ID de la dirección.")
        End Try
    End Function
End Class
