Imports System.Threading
Imports System.Globalization
Imports Logica

Public Class F_Pacientes

    Public Sub New()
        Thread.CurrentThread.CurrentUICulture = Logica.Env.CurrentLangugage
        InitializeComponent()
        ConfigMode()
    End Sub

    Public Sub ConfigMode()
        Select Case Env.UserType
            Case Env.UserTypes.Recepcionista
                'Buttons
                BtnModificar.Enabled = False
                BtnEliminar.Enabled = False
                BtnAddEnfermedad.Enabled = False
                BtnDelEnfermedad.Enabled = False
                BtnIAddMed.Enabled = False
                BtnIDelMed.Enabled = False


                'Fields
                TxtINFam.Enabled = False
                TxtIAntFam.Enabled = False
                TxtITratamientos.Enabled = False
                TxtIAntLab.Enabled = False
                TxtIMedicacion.Enabled = False
                TxtIEnfermedad.Enabled = False
                CmbIEnfermedad.Enabled = False
                CmbIMedicacion.Enabled = False


            Case Env.UserTypes.RRHH
                BtnIngresar.Enabled = False
                BtnModificar.Enabled = False
                BtnEliminar.Enabled = False
                BtnResetPassword.Enabled = False
                BtnAddEnfermedad.Enabled = False
                BtnDelEnfermedad.Enabled = False
                BtnIAddMed.Enabled = False
                BtnIDelMed.Enabled = False


                'Fields
                TxtINFam.Enabled = False
                TxtIAntFam.Enabled = False
                TxtITratamientos.Enabled = False
                TxtIAntLab.Enabled = False
                TxtIMedicacion.Enabled = False

            Case Env.UserTypes.Administrador
                BtnResetPassword.Enabled = False
        End Select
    End Sub

    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click
        If ValidateFields() Then
            Dim paciente = GetPaciente()
            paciente.Insert()
            LoadDgv()
            ClearFields()
        End If
    End Sub

    'Procedimiento que limpia el contenido de los campos
    Private Sub ClearFields()

    End Sub

    Private Function ValidateFields() As Boolean

        Return True
    End Function

    Private Sub F_Pacientes_Load(sender As Object, e As EventArgs) Handles Me.Load
        CmbIDepartamento.DataSource = [Enum].GetValues(GetType(Direccion.Departamentos))
        LoadDgv()
    End Sub


    Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles BtnVolver.Click
        F_ABM.Show()
        Close()
    End Sub

    Private Sub BtnIAddItem_Click(sender As Object, e As EventArgs) Handles BtnIAddMed.Click
        CmbIMedicacion.Items.Add(TxtIMedicacion.Text)
    End Sub

    Private Sub BtnIDelItem_Click(sender As Object, e As EventArgs) Handles BtnIDelMed.Click
        CmbIMedicacion.Items.RemoveAt(CmbIMedicacion.SelectedIndex)
    End Sub

    Private Sub BtnAddEnfermedad_Click(sender As Object, e As EventArgs) Handles BtnAddEnfermedad.Click
        CmbIEnfermedad.Items.Add(TxtIEnfermedad.Text)
    End Sub

    Private Sub BtnDelEnfermedad_Click(sender As Object, e As EventArgs) Handles BtnDelEnfermedad.Click
        CmbIEnfermedad.Items.RemoveAt(CmbIEnfermedad.SelectedIndex)
    End Sub

    Private Function GetPaciente() As Paciente
        Dim paciente As Paciente
        Try
            If Env.UserType = Env.UserTypes.Recepcionista Then
                paciente = New Paciente(
                            CInt(TxtICi.Text),
                            TxtINombre.Text,
                            TxtIApellidoP.Text,
                            TxtIApellidoM.Text,
                            New Direccion(TxtICalle.Text,
                                            CInt(TxtINumero.Text),
                                            TxtILocalidad.Text,
                                            CmbIDepartamento.SelectedIndex + 1),
                            CInt(TxtITelefono.Text),
                            Format(DTPickerFNac.Value, "yyyy-MM-dd"),
                            "password",
                            TxtIEmail.Text
                            )
            ElseIf Env.UserType = Env.UserTypes.Administrador Then

                Dim medicacion As String = ""
                For i As Integer = 0 To CmbIMedicacion.Items.Count - 1
                    medicacion += CmbIMedicacion.Items.Item(i).ToString
                    If i < CmbIMedicacion.Items.Count - 1 Then
                        medicacion += ","
                    End If
                Next

                paciente = New Paciente(
                            CInt(TxtICi.Text),
                            TxtINombre.Text,
                            TxtIApellidoP.Text,
                            TxtIApellidoM.Text,
                            New Direccion(TxtICalle.Text,
                                            CInt(TxtINumero.Text),
                                            TxtILocalidad.Text,
                                            CmbIDepartamento.SelectedIndex + 1),
                            CInt(TxtITelefono.Text),
                            Format(DTPickerFNac.Value, "yyyy-MM-dd"),
                            "password",
                            TxtIEmail.Text,
                            TxtINFam.Text,
                            TxtIAntFam.Text,
                            TxtIAntLab.Text,
                            medicacion,
                            TxtITratamientos.Text
                            )

            End If
        Catch ex As Exception
            MsgBox("Algo ha salido mal.")
        End Try

        Return paciente
    End Function
    Private Sub LoadDgv()
        Dim paciente As New Paciente()
        Dim dt As DataTable = paciente.GetDgvData()
        DgvPacientes.DataSource = dt
    End Sub

End Class