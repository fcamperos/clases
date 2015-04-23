<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.grbCodec = New System.Windows.Forms.GroupBox
        Me.rdbG722 = New System.Windows.Forms.RadioButton
        Me.rdbLPC10 = New System.Windows.Forms.RadioButton
        Me.rdbGSM = New System.Windows.Forms.RadioButton
        Me.rdbG711 = New System.Windows.Forms.RadioButton
        Me.rdbILBC = New System.Windows.Forms.RadioButton
        Me.rdbSpeex = New System.Windows.Forms.RadioButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.grbFrecuencia = New System.Windows.Forms.GroupBox
        Me.rdb44KHZ = New System.Windows.Forms.RadioButton
        Me.rdb32KHZ = New System.Windows.Forms.RadioButton
        Me.rdb22KHZ = New System.Windows.Forms.RadioButton
        Me.rdb16KHZ = New System.Windows.Forms.RadioButton
        Me.rdb11KHZ = New System.Windows.Forms.RadioButton
        Me.rdb8KHZ = New System.Windows.Forms.RadioButton
        Me.grbAudioIn = New System.Windows.Forms.GroupBox
        Me.txtInput = New System.Windows.Forms.TextBox
        Me.rdbInputOtra = New System.Windows.Forms.RadioButton
        Me.rdbInputDefault = New System.Windows.Forms.RadioButton
        Me.grbAudioOut = New System.Windows.Forms.GroupBox
        Me.txtOutput = New System.Windows.Forms.TextBox
        Me.rdbOutputOtra = New System.Windows.Forms.RadioButton
        Me.rdbOutputDefault = New System.Windows.Forms.RadioButton
        Me.grpFlujoAudio = New System.Windows.Forms.GroupBox
        Me.rdbRecibir = New System.Windows.Forms.RadioButton
        Me.rdbEnviar = New System.Windows.Forms.RadioButton
        Me.rdbEnviarRecibir = New System.Windows.Forms.RadioButton
        Me.chkFiltro = New System.Windows.Forms.CheckBox
        Me.txtIP = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtPuerto = New System.Windows.Forms.TextBox
        Me.chkConexion = New System.Windows.Forms.CheckBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rdbEsclavo = New System.Windows.Forms.RadioButton
        Me.rdbServidor = New System.Windows.Forms.RadioButton
        Me.chkRetardo = New System.Windows.Forms.CheckBox
        Me.chkEmpaquetado = New System.Windows.Forms.CheckBox
        Me.txtRetardo = New System.Windows.Forms.TextBox
        Me.txtEmpaquetado = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnIniciar = New System.Windows.Forms.Button
        Me.btnSalir = New System.Windows.Forms.Button
        Me.lblAyuda = New System.Windows.Forms.Label
        Me.chkAGC = New System.Windows.Forms.CheckBox
        Me.grbCodec.SuspendLayout()
        Me.grbFrecuencia.SuspendLayout()
        Me.grbAudioIn.SuspendLayout()
        Me.grbAudioOut.SuspendLayout()
        Me.grpFlujoAudio.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbCodec
        '
        Me.grbCodec.Controls.Add(Me.rdbG722)
        Me.grbCodec.Controls.Add(Me.rdbLPC10)
        Me.grbCodec.Controls.Add(Me.rdbGSM)
        Me.grbCodec.Controls.Add(Me.rdbG711)
        Me.grbCodec.Controls.Add(Me.rdbILBC)
        Me.grbCodec.Controls.Add(Me.rdbSpeex)
        Me.grbCodec.Location = New System.Drawing.Point(23, 49)
        Me.grbCodec.Name = "grbCodec"
        Me.grbCodec.Size = New System.Drawing.Size(90, 161)
        Me.grbCodec.TabIndex = 0
        Me.grbCodec.TabStop = False
        Me.grbCodec.Text = "Codec"
        '
        'rdbG722
        '
        Me.rdbG722.AutoSize = True
        Me.rdbG722.Location = New System.Drawing.Point(6, 136)
        Me.rdbG722.Name = "rdbG722"
        Me.rdbG722.Size = New System.Drawing.Size(49, 17)
        Me.rdbG722.TabIndex = 5
        Me.rdbG722.TabStop = True
        Me.rdbG722.Text = "g722"
        Me.rdbG722.UseVisualStyleBackColor = True
        '
        'rdbLPC10
        '
        Me.rdbLPC10.AutoSize = True
        Me.rdbLPC10.Location = New System.Drawing.Point(6, 113)
        Me.rdbLPC10.Name = "rdbLPC10"
        Me.rdbLPC10.Size = New System.Drawing.Size(51, 17)
        Me.rdbLPC10.TabIndex = 4
        Me.rdbLPC10.TabStop = True
        Me.rdbLPC10.Text = "lpc10"
        Me.rdbLPC10.UseVisualStyleBackColor = True
        '
        'rdbGSM
        '
        Me.rdbGSM.AutoSize = True
        Me.rdbGSM.Location = New System.Drawing.Point(6, 88)
        Me.rdbGSM.Name = "rdbGSM"
        Me.rdbGSM.Size = New System.Drawing.Size(49, 17)
        Me.rdbGSM.TabIndex = 3
        Me.rdbGSM.TabStop = True
        Me.rdbGSM.Text = "GSM"
        Me.rdbGSM.UseVisualStyleBackColor = True
        '
        'rdbG711
        '
        Me.rdbG711.AutoSize = True
        Me.rdbG711.Location = New System.Drawing.Point(6, 65)
        Me.rdbG711.Name = "rdbG711"
        Me.rdbG711.Size = New System.Drawing.Size(49, 17)
        Me.rdbG711.TabIndex = 2
        Me.rdbG711.TabStop = True
        Me.rdbG711.Text = "g711"
        Me.rdbG711.UseVisualStyleBackColor = True
        '
        'rdbILBC
        '
        Me.rdbILBC.AutoSize = True
        Me.rdbILBC.Location = New System.Drawing.Point(6, 42)
        Me.rdbILBC.Name = "rdbILBC"
        Me.rdbILBC.Size = New System.Drawing.Size(48, 17)
        Me.rdbILBC.TabIndex = 1
        Me.rdbILBC.TabStop = True
        Me.rdbILBC.Text = "ILBC"
        Me.rdbILBC.UseVisualStyleBackColor = True
        '
        'rdbSpeex
        '
        Me.rdbSpeex.AutoSize = True
        Me.rdbSpeex.Checked = True
        Me.rdbSpeex.Location = New System.Drawing.Point(6, 19)
        Me.rdbSpeex.Name = "rdbSpeex"
        Me.rdbSpeex.Size = New System.Drawing.Size(55, 17)
        Me.rdbSpeex.TabIndex = 0
        Me.rdbSpeex.TabStop = True
        Me.rdbSpeex.Text = "Speex"
        Me.rdbSpeex.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 258)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(17, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "IP"
        '
        'grbFrecuencia
        '
        Me.grbFrecuencia.Controls.Add(Me.rdb44KHZ)
        Me.grbFrecuencia.Controls.Add(Me.rdb32KHZ)
        Me.grbFrecuencia.Controls.Add(Me.rdb22KHZ)
        Me.grbFrecuencia.Controls.Add(Me.rdb16KHZ)
        Me.grbFrecuencia.Controls.Add(Me.rdb11KHZ)
        Me.grbFrecuencia.Controls.Add(Me.rdb8KHZ)
        Me.grbFrecuencia.Location = New System.Drawing.Point(119, 49)
        Me.grbFrecuencia.Name = "grbFrecuencia"
        Me.grbFrecuencia.Size = New System.Drawing.Size(88, 161)
        Me.grbFrecuencia.TabIndex = 6
        Me.grbFrecuencia.TabStop = False
        Me.grbFrecuencia.Text = "Frecuencia"
        '
        'rdb44KHZ
        '
        Me.rdb44KHZ.AutoSize = True
        Me.rdb44KHZ.Checked = True
        Me.rdb44KHZ.Location = New System.Drawing.Point(6, 136)
        Me.rdb44KHZ.Name = "rdb44KHZ"
        Me.rdb44KHZ.Size = New System.Drawing.Size(58, 17)
        Me.rdb44KHZ.TabIndex = 5
        Me.rdb44KHZ.TabStop = True
        Me.rdb44KHZ.Text = "44 Khz"
        Me.rdb44KHZ.UseVisualStyleBackColor = True
        '
        'rdb32KHZ
        '
        Me.rdb32KHZ.AutoSize = True
        Me.rdb32KHZ.Location = New System.Drawing.Point(6, 113)
        Me.rdb32KHZ.Name = "rdb32KHZ"
        Me.rdb32KHZ.Size = New System.Drawing.Size(58, 17)
        Me.rdb32KHZ.TabIndex = 4
        Me.rdb32KHZ.TabStop = True
        Me.rdb32KHZ.Text = "32 Khz"
        Me.rdb32KHZ.UseVisualStyleBackColor = True
        '
        'rdb22KHZ
        '
        Me.rdb22KHZ.AutoSize = True
        Me.rdb22KHZ.Location = New System.Drawing.Point(6, 88)
        Me.rdb22KHZ.Name = "rdb22KHZ"
        Me.rdb22KHZ.Size = New System.Drawing.Size(58, 17)
        Me.rdb22KHZ.TabIndex = 3
        Me.rdb22KHZ.TabStop = True
        Me.rdb22KHZ.Text = "22 Khz"
        Me.rdb22KHZ.UseVisualStyleBackColor = True
        '
        'rdb16KHZ
        '
        Me.rdb16KHZ.AutoSize = True
        Me.rdb16KHZ.Location = New System.Drawing.Point(6, 65)
        Me.rdb16KHZ.Name = "rdb16KHZ"
        Me.rdb16KHZ.Size = New System.Drawing.Size(58, 17)
        Me.rdb16KHZ.TabIndex = 2
        Me.rdb16KHZ.TabStop = True
        Me.rdb16KHZ.Text = "16 Khz"
        Me.rdb16KHZ.UseVisualStyleBackColor = True
        '
        'rdb11KHZ
        '
        Me.rdb11KHZ.AutoSize = True
        Me.rdb11KHZ.Location = New System.Drawing.Point(6, 42)
        Me.rdb11KHZ.Name = "rdb11KHZ"
        Me.rdb11KHZ.Size = New System.Drawing.Size(58, 17)
        Me.rdb11KHZ.TabIndex = 1
        Me.rdb11KHZ.TabStop = True
        Me.rdb11KHZ.Text = "11 Khz"
        Me.rdb11KHZ.UseVisualStyleBackColor = True
        '
        'rdb8KHZ
        '
        Me.rdb8KHZ.AutoSize = True
        Me.rdb8KHZ.Location = New System.Drawing.Point(6, 19)
        Me.rdb8KHZ.Name = "rdb8KHZ"
        Me.rdb8KHZ.Size = New System.Drawing.Size(52, 17)
        Me.rdb8KHZ.TabIndex = 0
        Me.rdb8KHZ.TabStop = True
        Me.rdb8KHZ.Text = "8 Khz"
        Me.rdb8KHZ.UseVisualStyleBackColor = True
        '
        'grbAudioIn
        '
        Me.grbAudioIn.Controls.Add(Me.txtInput)
        Me.grbAudioIn.Controls.Add(Me.rdbInputOtra)
        Me.grbAudioIn.Controls.Add(Me.rdbInputDefault)
        Me.grbAudioIn.Location = New System.Drawing.Point(264, 49)
        Me.grbAudioIn.Name = "grbAudioIn"
        Me.grbAudioIn.Size = New System.Drawing.Size(189, 73)
        Me.grbAudioIn.TabIndex = 7
        Me.grbAudioIn.TabStop = False
        Me.grbAudioIn.Text = "Entrada de Audio"
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(103, 39)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(51, 20)
        Me.txtInput.TabIndex = 2
        '
        'rdbInputOtra
        '
        Me.rdbInputOtra.AutoSize = True
        Me.rdbInputOtra.Location = New System.Drawing.Point(7, 42)
        Me.rdbInputOtra.Name = "rdbInputOtra"
        Me.rdbInputOtra.Size = New System.Drawing.Size(45, 17)
        Me.rdbInputOtra.TabIndex = 1
        Me.rdbInputOtra.TabStop = True
        Me.rdbInputOtra.Text = "Otra"
        Me.rdbInputOtra.UseVisualStyleBackColor = True
        '
        'rdbInputDefault
        '
        Me.rdbInputDefault.AutoSize = True
        Me.rdbInputDefault.Checked = True
        Me.rdbInputDefault.Location = New System.Drawing.Point(7, 19)
        Me.rdbInputDefault.Name = "rdbInputDefault"
        Me.rdbInputDefault.Size = New System.Drawing.Size(161, 17)
        Me.rdbInputDefault.TabIndex = 0
        Me.rdbInputDefault.TabStop = True
        Me.rdbInputDefault.Text = "Predeterminada de Windows"
        Me.rdbInputDefault.UseVisualStyleBackColor = True
        '
        'grbAudioOut
        '
        Me.grbAudioOut.Controls.Add(Me.txtOutput)
        Me.grbAudioOut.Controls.Add(Me.rdbOutputOtra)
        Me.grbAudioOut.Controls.Add(Me.rdbOutputDefault)
        Me.grbAudioOut.Location = New System.Drawing.Point(264, 137)
        Me.grbAudioOut.Name = "grbAudioOut"
        Me.grbAudioOut.Size = New System.Drawing.Size(189, 73)
        Me.grbAudioOut.TabIndex = 8
        Me.grbAudioOut.TabStop = False
        Me.grbAudioOut.Text = "Entrada de Audio"
        '
        'txtOutput
        '
        Me.txtOutput.Location = New System.Drawing.Point(103, 39)
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.Size = New System.Drawing.Size(51, 20)
        Me.txtOutput.TabIndex = 2
        '
        'rdbOutputOtra
        '
        Me.rdbOutputOtra.AutoSize = True
        Me.rdbOutputOtra.Location = New System.Drawing.Point(7, 42)
        Me.rdbOutputOtra.Name = "rdbOutputOtra"
        Me.rdbOutputOtra.Size = New System.Drawing.Size(45, 17)
        Me.rdbOutputOtra.TabIndex = 1
        Me.rdbOutputOtra.TabStop = True
        Me.rdbOutputOtra.Text = "Otra"
        Me.rdbOutputOtra.UseVisualStyleBackColor = True
        '
        'rdbOutputDefault
        '
        Me.rdbOutputDefault.AutoSize = True
        Me.rdbOutputDefault.Checked = True
        Me.rdbOutputDefault.Location = New System.Drawing.Point(7, 19)
        Me.rdbOutputDefault.Name = "rdbOutputDefault"
        Me.rdbOutputDefault.Size = New System.Drawing.Size(161, 17)
        Me.rdbOutputDefault.TabIndex = 0
        Me.rdbOutputDefault.TabStop = True
        Me.rdbOutputDefault.Text = "Predeterminada de Windows"
        Me.rdbOutputDefault.UseVisualStyleBackColor = True
        '
        'grpFlujoAudio
        '
        Me.grpFlujoAudio.Controls.Add(Me.rdbRecibir)
        Me.grpFlujoAudio.Controls.Add(Me.rdbEnviar)
        Me.grpFlujoAudio.Controls.Add(Me.rdbEnviarRecibir)
        Me.grpFlujoAudio.Location = New System.Drawing.Point(514, 49)
        Me.grpFlujoAudio.Name = "grpFlujoAudio"
        Me.grpFlujoAudio.Size = New System.Drawing.Size(172, 82)
        Me.grpFlujoAudio.TabIndex = 9
        Me.grpFlujoAudio.TabStop = False
        Me.grpFlujoAudio.Text = "Flujo de Audio"
        '
        'rdbRecibir
        '
        Me.rdbRecibir.AutoSize = True
        Me.rdbRecibir.Location = New System.Drawing.Point(6, 60)
        Me.rdbRecibir.Name = "rdbRecibir"
        Me.rdbRecibir.Size = New System.Drawing.Size(82, 17)
        Me.rdbRecibir.TabIndex = 2
        Me.rdbRecibir.TabStop = True
        Me.rdbRecibir.Text = "Solo Recibir"
        Me.rdbRecibir.UseVisualStyleBackColor = True
        '
        'rdbEnviar
        '
        Me.rdbEnviar.AutoSize = True
        Me.rdbEnviar.Location = New System.Drawing.Point(6, 39)
        Me.rdbEnviar.Name = "rdbEnviar"
        Me.rdbEnviar.Size = New System.Drawing.Size(79, 17)
        Me.rdbEnviar.TabIndex = 1
        Me.rdbEnviar.TabStop = True
        Me.rdbEnviar.Text = "Solo Enviar"
        Me.rdbEnviar.UseVisualStyleBackColor = True
        '
        'rdbEnviarRecibir
        '
        Me.rdbEnviarRecibir.AutoSize = True
        Me.rdbEnviarRecibir.Checked = True
        Me.rdbEnviarRecibir.Location = New System.Drawing.Point(6, 19)
        Me.rdbEnviarRecibir.Name = "rdbEnviarRecibir"
        Me.rdbEnviarRecibir.Size = New System.Drawing.Size(99, 17)
        Me.rdbEnviarRecibir.TabIndex = 0
        Me.rdbEnviarRecibir.TabStop = True
        Me.rdbEnviarRecibir.Text = "Enviar y Recibir"
        Me.rdbEnviarRecibir.UseVisualStyleBackColor = True
        '
        'chkFiltro
        '
        Me.chkFiltro.AutoSize = True
        Me.chkFiltro.Location = New System.Drawing.Point(520, 156)
        Me.chkFiltro.Name = "chkFiltro"
        Me.chkFiltro.Size = New System.Drawing.Size(139, 17)
        Me.chkFiltro.TabIndex = 10
        Me.chkFiltro.Text = "Filtro Supresor de Ruido"
        Me.chkFiltro.UseVisualStyleBackColor = True
        '
        'txtIP
        '
        Me.txtIP.Location = New System.Drawing.Point(18, 279)
        Me.txtIP.Name = "txtIP"
        Me.txtIP.Size = New System.Drawing.Size(95, 20)
        Me.txtIP.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(139, 258)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Puerto"
        '
        'txtPuerto
        '
        Me.txtPuerto.Location = New System.Drawing.Point(142, 279)
        Me.txtPuerto.Name = "txtPuerto"
        Me.txtPuerto.Size = New System.Drawing.Size(58, 20)
        Me.txtPuerto.TabIndex = 13
        Me.txtPuerto.Text = "8000"
        '
        'chkConexion
        '
        Me.chkConexion.AutoSize = True
        Me.chkConexion.Checked = True
        Me.chkConexion.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkConexion.Location = New System.Drawing.Point(18, 314)
        Me.chkConexion.Name = "chkConexion"
        Me.chkConexion.Size = New System.Drawing.Size(154, 17)
        Me.chkConexion.TabIndex = 14
        Me.chkConexion.Text = "Conectar Automaticamente"
        Me.chkConexion.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdbEsclavo)
        Me.GroupBox1.Controls.Add(Me.rdbServidor)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 386)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(182, 71)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Iniciar como..."
        '
        'rdbEsclavo
        '
        Me.rdbEsclavo.AutoSize = True
        Me.rdbEsclavo.Location = New System.Drawing.Point(5, 43)
        Me.rdbEsclavo.Name = "rdbEsclavo"
        Me.rdbEsclavo.Size = New System.Drawing.Size(63, 17)
        Me.rdbEsclavo.TabIndex = 1
        Me.rdbEsclavo.TabStop = True
        Me.rdbEsclavo.Text = "Esclavo"
        Me.rdbEsclavo.UseVisualStyleBackColor = True
        '
        'rdbServidor
        '
        Me.rdbServidor.AutoSize = True
        Me.rdbServidor.Location = New System.Drawing.Point(5, 20)
        Me.rdbServidor.Name = "rdbServidor"
        Me.rdbServidor.Size = New System.Drawing.Size(64, 17)
        Me.rdbServidor.TabIndex = 0
        Me.rdbServidor.TabStop = True
        Me.rdbServidor.Text = "Servidor"
        Me.rdbServidor.UseVisualStyleBackColor = True
        '
        'chkRetardo
        '
        Me.chkRetardo.AutoSize = True
        Me.chkRetardo.Location = New System.Drawing.Point(264, 279)
        Me.chkRetardo.Name = "chkRetardo"
        Me.chkRetardo.Size = New System.Drawing.Size(64, 17)
        Me.chkRetardo.TabIndex = 16
        Me.chkRetardo.Text = "Retardo"
        Me.chkRetardo.UseVisualStyleBackColor = True
        '
        'chkEmpaquetado
        '
        Me.chkEmpaquetado.AutoSize = True
        Me.chkEmpaquetado.Location = New System.Drawing.Point(264, 344)
        Me.chkEmpaquetado.Name = "chkEmpaquetado"
        Me.chkEmpaquetado.Size = New System.Drawing.Size(92, 17)
        Me.chkEmpaquetado.TabIndex = 17
        Me.chkEmpaquetado.Text = "Empaquetado"
        Me.chkEmpaquetado.UseVisualStyleBackColor = True
        '
        'txtRetardo
        '
        Me.txtRetardo.Location = New System.Drawing.Point(264, 302)
        Me.txtRetardo.Name = "txtRetardo"
        Me.txtRetardo.Size = New System.Drawing.Size(58, 20)
        Me.txtRetardo.TabIndex = 18
        '
        'txtEmpaquetado
        '
        Me.txtEmpaquetado.Location = New System.Drawing.Point(264, 367)
        Me.txtEmpaquetado.Name = "txtEmpaquetado"
        Me.txtEmpaquetado.Size = New System.Drawing.Size(58, 20)
        Me.txtEmpaquetado.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(328, 309)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "milisegundos."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(328, 374)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "1 a 10"
        '
        'btnIniciar
        '
        Me.btnIniciar.Location = New System.Drawing.Point(264, 429)
        Me.btnIniciar.Name = "btnIniciar"
        Me.btnIniciar.Size = New System.Drawing.Size(75, 23)
        Me.btnIniciar.TabIndex = 22
        Me.btnIniciar.Text = "Iniciar"
        Me.btnIniciar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(378, 429)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 23
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'lblAyuda
        '
        Me.lblAyuda.AutoSize = True
        Me.lblAyuda.Location = New System.Drawing.Point(488, 279)
        Me.lblAyuda.MaximumSize = New System.Drawing.Size(250, 100)
        Me.lblAyuda.Name = "lblAyuda"
        Me.lblAyuda.Size = New System.Drawing.Size(0, 13)
        Me.lblAyuda.TabIndex = 24
        '
        'chkAGC
        '
        Me.chkAGC.AutoSize = True
        Me.chkAGC.Location = New System.Drawing.Point(520, 185)
        Me.chkAGC.Name = "chkAGC"
        Me.chkAGC.Size = New System.Drawing.Size(179, 17)
        Me.chkAGC.TabIndex = 25
        Me.chkAGC.Text = "Control Automatico de Ganancia"
        Me.chkAGC.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(754, 490)
        Me.Controls.Add(Me.chkAGC)
        Me.Controls.Add(Me.lblAyuda)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnIniciar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtEmpaquetado)
        Me.Controls.Add(Me.txtRetardo)
        Me.Controls.Add(Me.chkEmpaquetado)
        Me.Controls.Add(Me.chkRetardo)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.chkConexion)
        Me.Controls.Add(Me.txtPuerto)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtIP)
        Me.Controls.Add(Me.chkFiltro)
        Me.Controls.Add(Me.grpFlujoAudio)
        Me.Controls.Add(Me.grbAudioOut)
        Me.Controls.Add(Me.grbAudioIn)
        Me.Controls.Add(Me.grbFrecuencia)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grbCodec)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.grbCodec.ResumeLayout(False)
        Me.grbCodec.PerformLayout()
        Me.grbFrecuencia.ResumeLayout(False)
        Me.grbFrecuencia.PerformLayout()
        Me.grbAudioIn.ResumeLayout(False)
        Me.grbAudioIn.PerformLayout()
        Me.grbAudioOut.ResumeLayout(False)
        Me.grbAudioOut.PerformLayout()
        Me.grpFlujoAudio.ResumeLayout(False)
        Me.grpFlujoAudio.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grbCodec As System.Windows.Forms.GroupBox
    Friend WithEvents rdbILBC As System.Windows.Forms.RadioButton
    Friend WithEvents rdbSpeex As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rdbG722 As System.Windows.Forms.RadioButton
    Friend WithEvents rdbLPC10 As System.Windows.Forms.RadioButton
    Friend WithEvents rdbGSM As System.Windows.Forms.RadioButton
    Friend WithEvents rdbG711 As System.Windows.Forms.RadioButton
    Friend WithEvents grbFrecuencia As System.Windows.Forms.GroupBox
    Friend WithEvents rdb44KHZ As System.Windows.Forms.RadioButton
    Friend WithEvents rdb32KHZ As System.Windows.Forms.RadioButton
    Friend WithEvents rdb22KHZ As System.Windows.Forms.RadioButton
    Friend WithEvents rdb16KHZ As System.Windows.Forms.RadioButton
    Friend WithEvents rdb11KHZ As System.Windows.Forms.RadioButton
    Friend WithEvents rdb8KHZ As System.Windows.Forms.RadioButton
    Friend WithEvents grbAudioIn As System.Windows.Forms.GroupBox
    Friend WithEvents txtInput As System.Windows.Forms.TextBox
    Friend WithEvents rdbInputOtra As System.Windows.Forms.RadioButton
    Friend WithEvents rdbInputDefault As System.Windows.Forms.RadioButton
    Friend WithEvents grbAudioOut As System.Windows.Forms.GroupBox
    Friend WithEvents txtOutput As System.Windows.Forms.TextBox
    Friend WithEvents rdbOutputOtra As System.Windows.Forms.RadioButton
    Friend WithEvents rdbOutputDefault As System.Windows.Forms.RadioButton
    Friend WithEvents grpFlujoAudio As System.Windows.Forms.GroupBox
    Friend WithEvents rdbRecibir As System.Windows.Forms.RadioButton
    Friend WithEvents rdbEnviar As System.Windows.Forms.RadioButton
    Friend WithEvents rdbEnviarRecibir As System.Windows.Forms.RadioButton
    Friend WithEvents chkFiltro As System.Windows.Forms.CheckBox
    Friend WithEvents txtIP As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPuerto As System.Windows.Forms.TextBox
    Friend WithEvents chkConexion As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdbEsclavo As System.Windows.Forms.RadioButton
    Friend WithEvents rdbServidor As System.Windows.Forms.RadioButton
    Friend WithEvents chkRetardo As System.Windows.Forms.CheckBox
    Friend WithEvents chkEmpaquetado As System.Windows.Forms.CheckBox
    Friend WithEvents txtRetardo As System.Windows.Forms.TextBox
    Friend WithEvents txtEmpaquetado As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnIniciar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents lblAyuda As System.Windows.Forms.Label
    Friend WithEvents chkAGC As System.Windows.Forms.CheckBox

End Class
