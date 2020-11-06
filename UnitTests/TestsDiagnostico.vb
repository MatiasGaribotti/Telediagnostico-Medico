Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports Dominio
Imports Logica
Imports System.Threading
<TestClass()> Public Class TestsDiagnostico


    <ClassInitialize()> Public Shared Sub ClassInitialize(context As TestContext)
        AuthenticationBUS.LogIn(11755149, "123")

    End Sub

    <TestMethod()> Public Sub GetDiagnostico_1()
        Dim successful As Boolean = True

        AutoconsultaBUS.instance.AddSintoma(New Sintoma(1, "Dolor de Cabeza", "", Sintoma.TiposSintomas.Cabeza))
        AutoconsultaBUS.instance.AddSintoma(New Sintoma(5, "Fiebre", "", Sintoma.TiposSintomas.Cabeza))
        AutoconsultaBUS.instance.AddSintoma(New Sintoma(6, "Tos", "", Sintoma.TiposSintomas.Cabeza))
        AutoconsultaBUS.instance.AddSintoma(New Sintoma(7, "Flemas", "", Sintoma.TiposSintomas.Cabeza))
        AutoconsultaBUS.instance.AddSintoma(New Sintoma(10, "Fatiga", "", Sintoma.TiposSintomas.Cabeza))
        AutoconsultaBUS.instance.AddSintoma(New Sintoma(11, "Falta de apetito", "", Sintoma.TiposSintomas.Cabeza))
        AutoconsultaBUS.instance.AddSintoma(New Sintoma(12, "Dificultad para respirar", "", Sintoma.TiposSintomas.Cabeza))
        AutoconsultaBUS.instance.AddSintoma(New Sintoma(13, "Escalofríos", "", Sintoma.TiposSintomas.Cabeza))
        AutoconsultaBUS.instance.AddSintoma(New Sintoma(14, "Dolor muscular generalizado", "", Sintoma.TiposSintomas.Cabeza))

        Try
            AutoconsultaBUS.instance.consulta.Diagnosticos = AutoconsultaBUS.instance.GetDiagnosis()
            AutoconsultaBUS.instance.Insert()

        Catch ex As Exception
            successful = False
        End Try

        Assert.AreEqual(True, successful)
    End Sub

    <TestMethod()> Public Sub GetDiagnosticoAndChat()
        Dim successful As Boolean = True

        AutoconsultaBUS.instance.AddSintoma(New Sintoma(1, "Dolor de Cabeza", "", Sintoma.TiposSintomas.Cabeza))
        AutoconsultaBUS.instance.AddSintoma(New Sintoma(5, "Fiebre", "", Sintoma.TiposSintomas.Cabeza))
        AutoconsultaBUS.instance.AddSintoma(New Sintoma(6, "Tos", "", Sintoma.TiposSintomas.Cabeza))
        AutoconsultaBUS.instance.AddSintoma(New Sintoma(7, "Flemas", "", Sintoma.TiposSintomas.Cabeza))
        AutoconsultaBUS.instance.AddSintoma(New Sintoma(10, "Fatiga", "", Sintoma.TiposSintomas.Cabeza))
        AutoconsultaBUS.instance.AddSintoma(New Sintoma(11, "Falta de apetito", "", Sintoma.TiposSintomas.Cabeza))
        AutoconsultaBUS.instance.AddSintoma(New Sintoma(12, "Dificultad para respirar", "", Sintoma.TiposSintomas.Cabeza))
        AutoconsultaBUS.instance.AddSintoma(New Sintoma(13, "Escalofríos", "", Sintoma.TiposSintomas.Cabeza))
        AutoconsultaBUS.instance.AddSintoma(New Sintoma(14, "Dolor muscular generalizado", "", Sintoma.TiposSintomas.Cabeza))

        Try
            AutoconsultaBUS.instance.consulta.Diagnosticos = AutoconsultaBUS.instance.GetDiagnosis()
            AutoconsultaBUS.instance.Insert(True)

        Catch ex As Exception
            successful = False
        End Try

        Assert.AreEqual(True, successful)
    End Sub

End Class