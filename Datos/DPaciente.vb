Imports ADODB
Public Class DPaciente
    Inherits DBConnection

    Public Sub New(user As String, password As String)
        _User = user
        _Password = password
    End Sub

    Public Function Insert(
            ci As Integer,
            foto As String,
            nombre As String,
            apellidoP As String,
            apellidoM As String,
            calle As String,
            nro As Integer,
            localidad As String,
            departamento As String,
            detalle As String,
            telefono As Integer,
            fecha_nacimiento As Date,
            password As String,
            email As String,
            NucleoFlia As String,
            AntecedentesFlia As String,
            antecedentesLab As String,
            medicacion As String,
            tratamiento As String) As Boolean

        Dim rs As Recordset

        ' Sentencia para ingresar la direccion
        Dim insertDireccion = "INSERT INTO direcciones
                               (calle, numero, localidad, departamento, detalle) 
                               VALUES (" &
                               calle & "," &
                               nro.ToString & "," &
                               localidad & "," &
                               departamento & "," &
                               detalle & ");"

        ' Consulta para obtener el id de la dirección ingresada
        Dim getIdDireccion = "SELECT id FROM direcciones" &
                              "WHERE calle='" & calle & "'" &
                              " AND nro='" & nro.ToString & "'" &
                              " AND localidad='" & localidad & "'" &
                              " AND departamento='" & departamento & "';"
        Dim idDireccion As Integer

        ' Sentencia para ingresar un paciente
        Dim insertPaciente = "INSERT INTO personas(" &
                              "ci," &
                              "foto," &
                              "nombre," &
                              " apellidoP," &
                              " apellidoM," &
                              " fechaNacimiento," &
                              " telefono," &
                              " esPaciente," &
                              " email," &
                              " nucleoFlia," &
                              " antecedentesFlia," &
                              " antecedentesLab," &
                              " medicacion," &
                              " tratamiento," &
                              " password," &
                              " idDireccion)" &
                              "VALUES(" &
                              ci.ToString & ",'" &
                              foto & "','" &
                              nombre & "','" &
                              apellidoP & "','" &
                              apellidoM & "'," &
                              fecha_nacimiento & "," & ' #IMPORTANTE: CONVERTIR FECHA AL FORMATO CORRESPONDIENTE. WORK IN PROGRESS
                              telefono & "," &
                              "True" & "," &
                              email & "," &
                              NucleoFlia & "," &
                              AntecedentesFlia & "," &
                              antecedentesLab & "," &
                              medicacion & "," &
                              tratamiento & "," &
                              password & "," &
                              idDireccion.ToString &
                              ");"

        'Abro la conexión con la base de datos
        Dim con As Connection = Conectar()

        Try
            'Abro transacción
            con.BeginTrans()

            'Ingreso la dirección a la DB
            con.Execute(insertDireccion)

            'Obtener idDireccion

            rs = con.Execute(getIdDireccion)
            'idDireccion = 

            'Ingreso los datos del paciente a la DB
            con.Execute(insertPaciente)

            'Hago el commit de la transacción y retorno True
            con.CommitTrans()
            Return True

        Catch ex As Exception
            'Hubo una excepción, por lo que debo hacer un rollback
            'para mantener la integridad de los datos.
            con.RollbackTrans()
            Console.WriteLine("No se pudo insertar el paciente.") ' Mensaje en consola para debug

            'Retorno False, significando esto que la transacción
            'no se pudo concretar.
            Return False

        End Try
    End Function
End Class
