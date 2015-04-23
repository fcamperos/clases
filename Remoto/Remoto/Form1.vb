Imports System
Imports System.IO

Public Class Form1

    Dim modif As String
    Dim codec As String
    Dim frec As String
    Dim out As String
    Dim input As String
    Dim flujo As String
    Dim filtro As String
    Dim AGC As String
    Dim IP As String
    Dim puerto As String
    Dim conexionautomatica As String
    Dim inicio As String
    Dim retardo As String
    Dim empaq As String



    Private Sub rdbSpeex_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbSpeex.CheckedChanged
        rdb8KHZ.Visible = True
        rdb11KHZ.Visible = True
        rdb16KHZ.Visible = True
        rdb22KHZ.Visible = True
        rdb32KHZ.Visible = True
        rdb44KHZ.Visible = True

    End Sub


    Private Sub rdbILBC_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbILBC.CheckedChanged
        rdb8KHZ.Visible = True
        rdb11KHZ.Visible = True
        rdb16KHZ.Visible = False
        rdb22KHZ.Visible = True
        rdb32KHZ.Visible = False
        rdb44KHZ.Visible = False
    End Sub


    Private Sub rdbG711_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbG711.CheckedChanged
        rdb8KHZ.Visible = True
        rdb11KHZ.Visible = True
        rdb16KHZ.Visible = False
        rdb22KHZ.Visible = True
        rdb32KHZ.Visible = False
        rdb44KHZ.Visible = False
    End Sub

    Private Sub rdbGSM_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbGSM.CheckedChanged
        rdb8KHZ.Visible = True
        rdb11KHZ.Visible = True
        rdb16KHZ.Visible = False
        rdb22KHZ.Visible = True
        rdb32KHZ.Visible = False
        rdb44KHZ.Visible = False
    End Sub

    Private Sub rdbLPC10_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbLPC10.CheckedChanged
        rdb8KHZ.Visible = False
        rdb11KHZ.Visible = False
        rdb16KHZ.Visible = False
        rdb22KHZ.Visible = False
        rdb32KHZ.Visible = False
        rdb44KHZ.Visible = False
    End Sub

    Private Sub rdbG722_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbG722.CheckedChanged
        rdb8KHZ.Visible = True
        rdb11KHZ.Visible = True
        rdb16KHZ.Visible = False
        rdb22KHZ.Visible = True
        rdb32KHZ.Visible = False
        rdb44KHZ.Visible = True
    End Sub

    Private Sub rdbInputDefault_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbInputDefault.CheckedChanged
        txtInput.Enabled = False
    End Sub

    Private Sub rdbInputOtra_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbInputOtra.CheckedChanged
        txtInput.Enabled = True
    End Sub

    Private Sub rdbOutputDefault_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbOutputDefault.CheckedChanged
        txtOutput.Enabled = False
    End Sub

    Private Sub rdbOutputOtra_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbOutputOtra.CheckedChanged
        txtOutput.Enabled = True
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        txtRetardo.Enabled = False
        txtEmpaquetado.Enabled = False

    End Sub

    Private Sub chkRetardo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkRetardo.CheckedChanged
        If chkRetardo.Checked = True Then
            txtRetardo.Enabled = True
        Else
            txtRetardo.Enabled = False
        End If
    End Sub

    Private Sub chkEmpaquetado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkEmpaquetado.CheckedChanged
        If chkEmpaquetado.Checked = True Then
            txtEmpaquetado.Enabled = True
        Else
            txtEmpaquetado.Enabled = False
        End If
    End Sub


    Private Sub chkRetardo_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkRetardo.MouseHover

        lblAyuda.Text = "Solo utilize el retardo cuando la red este congestionada y existan saltos en el audio."

    End Sub

    Private Sub chkEmpaquetado_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkEmpaquetado.MouseHover

        lblAyuda.Text = "Modifique con numeros enteros el empaquetamiento en redes lentas (valores de 1- 3). En redes de buen desempeño utilize valores mas altos (5 - 10). SOLO EN CASO DE SER NECESARIO UTILIZE ESTA VARIABLE."

    End Sub

    Private Sub txtIP_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtIP.MouseHover

        lblAyuda.Text = "Si es Servidor digite la direccion IP Publica de su PC, si es esclavo digite la direccion IP del servidor."

    End Sub

    Private Sub Form1_MouseHover1(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MouseHover

        lblAyuda.Text = ""

    End Sub

    Private Sub rdbOutputOtra_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdbOutputOtra.MouseHover

        lblAyuda.Text = "Si tiene mas de una tarjeta de audio en el sistema y desea utilizar una diferente a la predeterminada utilice numeros enteros comenzando de 1 hasta el numero de tarjetas que tenga instaladas."

    End Sub


    Private Sub rdbInputOtra_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdbInputOtra.MouseHover

        lblAyuda.Text = "Si tiene mas de una tarjeta de audio en el sistema y desea utilizar una diferente a la predeterminada utilice numeros enteros comenzando de 1 hasta el numero de tarjetas que tenga instaladas."

    End Sub



    Private Sub btnIniciar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIniciar.Click

        codec = ""
        frec = ""
        input = ""
        input = ""
        out = ""
        flujo = ""
        Dim puertoIP As String
        Dim a As String
        Dim c As String
        Dim b As String
        Dim pgs As String
        Dim agc As String
        Dim n As String
        Dim proceso As Integer
        Dim Prog As String
        Dim directorio As String
        Dim path As String


        Prog = ("C:\Archivos de programa\Cracklock\Bin\MCL.exe" & "C:\ARCHIVOS DE PROGRAMA\AUDIO COMPASS\AUDIOCOMPASS.EXE")

        'Codec a utilizar
        If rdbSpeex.Checked = True Then codec = "speex_"
        If rdbILBC.Checked = True Then codec = "ilbc_"
        If rdbG711.Checked = True Then codec = "g711_"
        If rdbGSM.Checked = True Then codec = "gsm_"
        If rdbLPC10.Checked = True Then codec = "lpc10"
        If rdbG722.Checked = True Then codec = "g722_"

        'Frecuencia a utilizar
        If rdb8KHZ.Checked = True And rdb8KHZ.Visible = True Then frec = "8khz"
        If rdb11KHZ.Checked = True And rdb11KHZ.Visible = True Then frec = "11khz"
        If rdb16KHZ.Checked = True And rdb16KHZ.Visible = True Then frec = "16khz"
        If rdb22KHZ.Checked = True And rdb22KHZ.Visible = True Then frec = "22khz"
        If rdb32KHZ.Checked = True And rdb32KHZ.Visible = True Then frec = "32khz"
        If rdb44KHZ.Checked = True And rdb44KHZ.Visible = True Then frec = "44khz"

        'Entrada y Salida de Audio
        If rdbInputDefault.Checked = True Then input = "-i:0" Else input = "-i:" & txtInput.Text
        If rdbOutputDefault.Checked = True Then out = "-i:0" Else out = "-i:" & txtOutput.Text

        'Flujo de Audio
        If rdbEnviarRecibir.Checked = True Then flujo = ""
        If rdbEnviar.Checked = True Then flujo = "-d:send"
        If rdbRecibir.Checked = True Then flujo = "-d:receive"

        'IP y Puerto
        IP = txtIP.Text
        puerto = txtPuerto.Text
        puertoIP = "-c:" & IP & ":" & puerto & ","

        'Inicio automatico
        If chkConexion.Checked = True Then conexionautomatica = "Yes" Else conexionautomatica = ("No")

        'Retardo
        If chkRetardo.Checked = True Then b = "-b:" & txtRetardo.Text Else b = ""

        'Empaquetamiento
        If chkEmpaquetado.Checked = True Then pgs = "-pgs:" & txtEmpaquetado.Text Else pgs = ""

        'Control automatico de ganancia
        If chkAGC.Checked = True Then agc = "-agc" Else agc = ""

        'Filtro de ruido
        If chkFiltro.Checked = True Then n = "-n" Else n = ""

        a = "-a:" & codec & frec
        c = puertoIP & conexionautomatica

        modif = c & " " & a & " " & input & " " & out & " " & flujo & " " & b & " " & pgs & " " & agc & " " & n

        directorio = ("C:\Archivos de programa\Audio Compass")
        Directory.SetCurrentDirectory(directorio)

        path = """C:\Archivos de programa\Cracklock\Bin\MCL.exe """ & """C:\ARCHIVOS DE PROGRAMA\AUDIO COMPASS\AUDIOCOMPASS.EXE""" & modif

        MessageBox.Show(path)

        proceso = Shell(path, AppWinStyle.MinimizedNoFocus)


        MessageBox.Show(modif)

    End Sub

End Class
