namespace QuadControlStation
{
    partial class QuadControlStation
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.DisconnectButton = new System.Windows.Forms.Button();
            this.Angles = new System.Windows.Forms.GroupBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.YawAngle = new System.Windows.Forms.Label();
            this.RollAngle = new System.Windows.Forms.Label();
            this.PitchAngle = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AngleSpeeds = new System.Windows.Forms.GroupBox();
            this.label34 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.YawSpeed = new System.Windows.Forms.Label();
            this.RollSpeed = new System.Windows.Forms.Label();
            this.PitchSpeed = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BatteryVoltageBox = new System.Windows.Forms.GroupBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.VoltageLevel3 = new System.Windows.Forms.Label();
            this.VoltageLevel2 = new System.Windows.Forms.Label();
            this.VoltageLevel1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Alltitude = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.TemperatureValue = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.Pressure = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label36 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.MagZ = new System.Windows.Forms.Label();
            this.MagY = new System.Windows.Forms.Label();
            this.MagX = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.ZAcceleration = new System.Windows.Forms.Label();
            this.YAcceleration = new System.Windows.Forms.Label();
            this.XAcceleration = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.joystickTimer = new System.Windows.Forms.Timer(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.HeightGain = new System.Windows.Forms.Label();
            this.HeightScrollBar = new System.Windows.Forms.VScrollBar();
            this.YawGain = new System.Windows.Forms.Label();
            this.RollGain = new System.Windows.Forms.Label();
            this.PitchGain = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.YawScrollBar = new System.Windows.Forms.VScrollBar();
            this.RollScrollBar = new System.Windows.Forms.VScrollBar();
            this.PitchScrollBar = new System.Windows.Forms.VScrollBar();
            this.Angles.SuspendLayout();
            this.AngleSpeeds.SuspendLayout();
            this.BatteryVoltageBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConnectButton
            // 
            this.ConnectButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.ConnectButton.Location = new System.Drawing.Point(365, 6);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(75, 23);
            this.ConnectButton.TabIndex = 0;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // DisconnectButton
            // 
            this.DisconnectButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.DisconnectButton.Location = new System.Drawing.Point(365, 35);
            this.DisconnectButton.Name = "DisconnectButton";
            this.DisconnectButton.Size = new System.Drawing.Size(75, 23);
            this.DisconnectButton.TabIndex = 2;
            this.DisconnectButton.Text = "Disconnect";
            this.DisconnectButton.UseVisualStyleBackColor = true;
            this.DisconnectButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Angles
            // 
            this.Angles.Controls.Add(this.label21);
            this.Angles.Controls.Add(this.label20);
            this.Angles.Controls.Add(this.label18);
            this.Angles.Controls.Add(this.YawAngle);
            this.Angles.Controls.Add(this.RollAngle);
            this.Angles.Controls.Add(this.PitchAngle);
            this.Angles.Controls.Add(this.label3);
            this.Angles.Controls.Add(this.label2);
            this.Angles.Controls.Add(this.label4);
            this.Angles.Location = new System.Drawing.Point(12, 12);
            this.Angles.Name = "Angles";
            this.Angles.Size = new System.Drawing.Size(123, 100);
            this.Angles.TabIndex = 5;
            this.Angles.TabStop = false;
            this.Angles.Text = "Angles";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(87, 66);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(9, 13);
            this.label21.TabIndex = 8;
            this.label21.Text = "\'";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(87, 44);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(9, 13);
            this.label20.TabIndex = 7;
            this.label20.Text = "\'";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(87, 24);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(9, 13);
            this.label18.TabIndex = 6;
            this.label18.Text = "\'";
            // 
            // YawAngle
            // 
            this.YawAngle.AutoSize = true;
            this.YawAngle.Location = new System.Drawing.Point(43, 66);
            this.YawAngle.Name = "YawAngle";
            this.YawAngle.Size = new System.Drawing.Size(13, 13);
            this.YawAngle.TabIndex = 5;
            this.YawAngle.Text = "0";
            // 
            // RollAngle
            // 
            this.RollAngle.AutoSize = true;
            this.RollAngle.Location = new System.Drawing.Point(43, 44);
            this.RollAngle.Name = "RollAngle";
            this.RollAngle.Size = new System.Drawing.Size(13, 13);
            this.RollAngle.TabIndex = 4;
            this.RollAngle.Text = "0";
            // 
            // PitchAngle
            // 
            this.PitchAngle.AutoSize = true;
            this.PitchAngle.Location = new System.Drawing.Point(43, 25);
            this.PitchAngle.Name = "PitchAngle";
            this.PitchAngle.Size = new System.Drawing.Size(13, 13);
            this.PitchAngle.TabIndex = 3;
            this.PitchAngle.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "yaw";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "roll";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "pitch";
            // 
            // AngleSpeeds
            // 
            this.AngleSpeeds.Controls.Add(this.label34);
            this.AngleSpeeds.Controls.Add(this.label33);
            this.AngleSpeeds.Controls.Add(this.label32);
            this.AngleSpeeds.Controls.Add(this.YawSpeed);
            this.AngleSpeeds.Controls.Add(this.RollSpeed);
            this.AngleSpeeds.Controls.Add(this.PitchSpeed);
            this.AngleSpeeds.Controls.Add(this.label9);
            this.AngleSpeeds.Controls.Add(this.label10);
            this.AngleSpeeds.Controls.Add(this.label11);
            this.AngleSpeeds.Location = new System.Drawing.Point(141, 12);
            this.AngleSpeeds.Name = "AngleSpeeds";
            this.AngleSpeeds.Size = new System.Drawing.Size(159, 100);
            this.AngleSpeeds.TabIndex = 6;
            this.AngleSpeeds.TabStop = false;
            this.AngleSpeeds.Text = "Speeds";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(129, 66);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(19, 13);
            this.label34.TabIndex = 11;
            this.label34.Text = "\'/s";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(129, 44);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(19, 13);
            this.label33.TabIndex = 10;
            this.label33.Text = "\'/s";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(129, 24);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(19, 13);
            this.label32.TabIndex = 9;
            this.label32.Text = "\'/s";
            // 
            // YawSpeed
            // 
            this.YawSpeed.AutoSize = true;
            this.YawSpeed.Location = new System.Drawing.Point(43, 66);
            this.YawSpeed.Name = "YawSpeed";
            this.YawSpeed.Size = new System.Drawing.Size(13, 13);
            this.YawSpeed.TabIndex = 5;
            this.YawSpeed.Text = "0";
            // 
            // RollSpeed
            // 
            this.RollSpeed.AutoSize = true;
            this.RollSpeed.Location = new System.Drawing.Point(43, 44);
            this.RollSpeed.Name = "RollSpeed";
            this.RollSpeed.Size = new System.Drawing.Size(13, 13);
            this.RollSpeed.TabIndex = 4;
            this.RollSpeed.Text = "0";
            // 
            // PitchSpeed
            // 
            this.PitchSpeed.AutoSize = true;
            this.PitchSpeed.Location = new System.Drawing.Point(43, 25);
            this.PitchSpeed.Name = "PitchSpeed";
            this.PitchSpeed.Size = new System.Drawing.Size(13, 13);
            this.PitchSpeed.TabIndex = 3;
            this.PitchSpeed.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "yaw";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "roll";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "pitch";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // BatteryVoltageBox
            // 
            this.BatteryVoltageBox.Controls.Add(this.label30);
            this.BatteryVoltageBox.Controls.Add(this.label29);
            this.BatteryVoltageBox.Controls.Add(this.label28);
            this.BatteryVoltageBox.Controls.Add(this.VoltageLevel3);
            this.BatteryVoltageBox.Controls.Add(this.VoltageLevel2);
            this.BatteryVoltageBox.Controls.Add(this.VoltageLevel1);
            this.BatteryVoltageBox.Controls.Add(this.label7);
            this.BatteryVoltageBox.Controls.Add(this.label8);
            this.BatteryVoltageBox.Controls.Add(this.label12);
            this.BatteryVoltageBox.Location = new System.Drawing.Point(12, 224);
            this.BatteryVoltageBox.Name = "BatteryVoltageBox";
            this.BatteryVoltageBox.Size = new System.Drawing.Size(123, 85);
            this.BatteryVoltageBox.TabIndex = 8;
            this.BatteryVoltageBox.TabStop = false;
            this.BatteryVoltageBox.Text = "BatteryVoltage";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(82, 66);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(14, 13);
            this.label30.TabIndex = 10;
            this.label30.Text = "V";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(83, 44);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(14, 13);
            this.label29.TabIndex = 9;
            this.label29.Text = "V";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(82, 24);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(14, 13);
            this.label28.TabIndex = 8;
            this.label28.Text = "V";
            // 
            // VoltageLevel3
            // 
            this.VoltageLevel3.AutoSize = true;
            this.VoltageLevel3.Location = new System.Drawing.Point(43, 66);
            this.VoltageLevel3.Name = "VoltageLevel3";
            this.VoltageLevel3.Size = new System.Drawing.Size(13, 13);
            this.VoltageLevel3.TabIndex = 5;
            this.VoltageLevel3.Text = "0";
            // 
            // VoltageLevel2
            // 
            this.VoltageLevel2.AutoSize = true;
            this.VoltageLevel2.Location = new System.Drawing.Point(43, 44);
            this.VoltageLevel2.Name = "VoltageLevel2";
            this.VoltageLevel2.Size = new System.Drawing.Size(13, 13);
            this.VoltageLevel2.TabIndex = 4;
            this.VoltageLevel2.Text = "0";
            // 
            // VoltageLevel1
            // 
            this.VoltageLevel1.AutoSize = true;
            this.VoltageLevel1.Location = new System.Drawing.Point(43, 25);
            this.VoltageLevel1.Name = "VoltageLevel1";
            this.VoltageLevel1.Size = new System.Drawing.Size(13, 13);
            this.VoltageLevel1.TabIndex = 3;
            this.VoltageLevel1.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "cell3";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "cell2";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "cell1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Alltitude);
            this.groupBox1.Controls.Add(this.label38);
            this.groupBox1.Controls.Add(this.label37);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label31);
            this.groupBox1.Controls.Add(this.TemperatureValue);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.Pressure);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Location = new System.Drawing.Point(141, 224);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(159, 85);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Other";
            // 
            // Alltitude
            // 
            this.Alltitude.AutoSize = true;
            this.Alltitude.Location = new System.Drawing.Point(81, 44);
            this.Alltitude.Name = "Alltitude";
            this.Alltitude.Size = new System.Drawing.Size(13, 13);
            this.Alltitude.TabIndex = 22;
            this.Alltitude.Text = "0";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(138, 44);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(15, 13);
            this.label38.TabIndex = 24;
            this.label38.Text = "m";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(8, 44);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(44, 13);
            this.label37.TabIndex = 23;
            this.label37.Text = "Alltitude";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(134, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Pa";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(134, 66);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(19, 13);
            this.label31.TabIndex = 9;
            this.label31.Text = "\' C";
            // 
            // TemperatureValue
            // 
            this.TemperatureValue.AutoSize = true;
            this.TemperatureValue.Location = new System.Drawing.Point(81, 66);
            this.TemperatureValue.Name = "TemperatureValue";
            this.TemperatureValue.Size = new System.Drawing.Size(13, 13);
            this.TemperatureValue.TabIndex = 5;
            this.TemperatureValue.Text = "0";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(8, 66);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(67, 13);
            this.label19.TabIndex = 4;
            this.label19.Text = "Temperature";
            // 
            // Pressure
            // 
            this.Pressure.AutoSize = true;
            this.Pressure.Location = new System.Drawing.Point(81, 24);
            this.Pressure.Name = "Pressure";
            this.Pressure.Size = new System.Drawing.Size(13, 13);
            this.Pressure.TabIndex = 3;
            this.Pressure.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(7, 24);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Pressure";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(303, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "SendValue";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(361, 118);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(46, 13);
            this.label39.TabIndex = 15;
            this.label39.Text = ";0;0;0;0;";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label36);
            this.groupBox2.Controls.Add(this.label35);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.MagZ);
            this.groupBox2.Controls.Add(this.MagY);
            this.groupBox2.Controls.Add(this.MagX);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Location = new System.Drawing.Point(141, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(159, 100);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Magnetic Field Strength";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(130, 72);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(23, 13);
            this.label36.TabIndex = 25;
            this.label36.Text = "mG";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(129, 50);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(23, 13);
            this.label35.TabIndex = 24;
            this.label35.Text = "mG";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(129, 30);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(23, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "mG";
            // 
            // MagZ
            // 
            this.MagZ.AutoSize = true;
            this.MagZ.Location = new System.Drawing.Point(44, 72);
            this.MagZ.Name = "MagZ";
            this.MagZ.Size = new System.Drawing.Size(13, 13);
            this.MagZ.TabIndex = 5;
            this.MagZ.Text = "0";
            // 
            // MagY
            // 
            this.MagY.AutoSize = true;
            this.MagY.Location = new System.Drawing.Point(44, 50);
            this.MagY.Name = "MagY";
            this.MagY.Size = new System.Drawing.Size(13, 13);
            this.MagY.TabIndex = 4;
            this.MagY.Text = "0";
            // 
            // MagX
            // 
            this.MagX.AutoSize = true;
            this.MagX.Location = new System.Drawing.Point(44, 31);
            this.MagX.Name = "MagX";
            this.MagX.Size = new System.Drawing.Size(13, 13);
            this.MagX.TabIndex = 3;
            this.MagX.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 72);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(12, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "z";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(8, 50);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(12, 13);
            this.label16.TabIndex = 1;
            this.label16.Text = "y";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(8, 30);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(12, 13);
            this.label17.TabIndex = 0;
            this.label17.Text = "x";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label27);
            this.groupBox3.Controls.Add(this.label26);
            this.groupBox3.Controls.Add(this.label25);
            this.groupBox3.Controls.Add(this.ZAcceleration);
            this.groupBox3.Controls.Add(this.YAcceleration);
            this.groupBox3.Controls.Add(this.XAcceleration);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Controls.Add(this.label24);
            this.groupBox3.Location = new System.Drawing.Point(12, 118);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(123, 100);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Acceleration";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(83, 72);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(13, 13);
            this.label27.TabIndex = 9;
            this.label27.Text = "g";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(83, 50);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(13, 13);
            this.label26.TabIndex = 8;
            this.label26.Text = "g";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(83, 30);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(13, 13);
            this.label25.TabIndex = 7;
            this.label25.Text = "g";
            // 
            // ZAcceleration
            // 
            this.ZAcceleration.AutoSize = true;
            this.ZAcceleration.Location = new System.Drawing.Point(43, 72);
            this.ZAcceleration.Name = "ZAcceleration";
            this.ZAcceleration.Size = new System.Drawing.Size(13, 13);
            this.ZAcceleration.TabIndex = 5;
            this.ZAcceleration.Text = "0";
            // 
            // YAcceleration
            // 
            this.YAcceleration.AutoSize = true;
            this.YAcceleration.Location = new System.Drawing.Point(43, 50);
            this.YAcceleration.Name = "YAcceleration";
            this.YAcceleration.Size = new System.Drawing.Size(13, 13);
            this.YAcceleration.TabIndex = 4;
            this.YAcceleration.Text = "0";
            // 
            // XAcceleration
            // 
            this.XAcceleration.AutoSize = true;
            this.XAcceleration.Location = new System.Drawing.Point(43, 31);
            this.XAcceleration.Name = "XAcceleration";
            this.XAcceleration.Size = new System.Drawing.Size(13, 13);
            this.XAcceleration.TabIndex = 3;
            this.XAcceleration.Text = "0";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(7, 72);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(12, 13);
            this.label22.TabIndex = 2;
            this.label22.Text = "z";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(7, 50);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(12, 13);
            this.label23.TabIndex = 1;
            this.label23.Text = "y";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(7, 30);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(12, 13);
            this.label24.TabIndex = 0;
            this.label24.Text = "x";
            // 
            // joystickTimer
            // 
            this.joystickTimer.Enabled = true;
            this.joystickTimer.Interval = 20;
            this.joystickTimer.Tick += new System.EventHandler(this.joystickTimer_Tick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.HeightGain);
            this.groupBox4.Controls.Add(this.HeightScrollBar);
            this.groupBox4.Controls.Add(this.YawGain);
            this.groupBox4.Controls.Add(this.RollGain);
            this.groupBox4.Controls.Add(this.PitchGain);
            this.groupBox4.Controls.Add(this.label40);
            this.groupBox4.Controls.Add(this.YawScrollBar);
            this.groupBox4.Controls.Add(this.RollScrollBar);
            this.groupBox4.Controls.Add(this.PitchScrollBar);
            this.groupBox4.Location = new System.Drawing.Point(306, 167);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(128, 142);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "GamePadGain";
            // 
            // HeightGain
            // 
            this.HeightGain.AutoSize = true;
            this.HeightGain.Location = new System.Drawing.Point(100, 111);
            this.HeightGain.Name = "HeightGain";
            this.HeightGain.Size = new System.Drawing.Size(19, 13);
            this.HeightGain.TabIndex = 27;
            this.HeightGain.Text = "40";
            // 
            // HeightScrollBar
            // 
            this.HeightScrollBar.LargeChange = 1;
            this.HeightScrollBar.Location = new System.Drawing.Point(97, 31);
            this.HeightScrollBar.Maximum = 40;
            this.HeightScrollBar.Name = "HeightScrollBar";
            this.HeightScrollBar.Size = new System.Drawing.Size(17, 80);
            this.HeightScrollBar.TabIndex = 26;
            this.HeightScrollBar.ValueChanged += new System.EventHandler(this.HeightScrollBar_ValueChanged);
            // 
            // YawGain
            // 
            this.YawGain.AutoSize = true;
            this.YawGain.Location = new System.Drawing.Point(75, 111);
            this.YawGain.Name = "YawGain";
            this.YawGain.Size = new System.Drawing.Size(19, 13);
            this.YawGain.TabIndex = 25;
            this.YawGain.Text = "40";
            // 
            // RollGain
            // 
            this.RollGain.AutoSize = true;
            this.RollGain.Location = new System.Drawing.Point(49, 111);
            this.RollGain.Name = "RollGain";
            this.RollGain.Size = new System.Drawing.Size(19, 13);
            this.RollGain.TabIndex = 24;
            this.RollGain.Text = "40";
            // 
            // PitchGain
            // 
            this.PitchGain.AutoSize = true;
            this.PitchGain.Location = new System.Drawing.Point(19, 111);
            this.PitchGain.Name = "PitchGain";
            this.PitchGain.Size = new System.Drawing.Size(19, 13);
            this.PitchGain.TabIndex = 21;
            this.PitchGain.Text = "40";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(12, 18);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(112, 13);
            this.label40.TabIndex = 23;
            this.label40.Text = "pitch   roll   yaw height";
            // 
            // YawScrollBar
            // 
            this.YawScrollBar.LargeChange = 1;
            this.YawScrollBar.Location = new System.Drawing.Point(71, 30);
            this.YawScrollBar.Maximum = 40;
            this.YawScrollBar.Name = "YawScrollBar";
            this.YawScrollBar.Size = new System.Drawing.Size(17, 80);
            this.YawScrollBar.TabIndex = 22;
            this.YawScrollBar.ValueChanged += new System.EventHandler(this.YawScrollBar_ValueChanged);
            // 
            // RollScrollBar
            // 
            this.RollScrollBar.LargeChange = 1;
            this.RollScrollBar.Location = new System.Drawing.Point(45, 31);
            this.RollScrollBar.Maximum = 40;
            this.RollScrollBar.Name = "RollScrollBar";
            this.RollScrollBar.Size = new System.Drawing.Size(17, 80);
            this.RollScrollBar.TabIndex = 21;
            this.RollScrollBar.ValueChanged += new System.EventHandler(this.RollScrollBar_ValueChanged);
            // 
            // PitchScrollBar
            // 
            this.PitchScrollBar.LargeChange = 1;
            this.PitchScrollBar.Location = new System.Drawing.Point(15, 30);
            this.PitchScrollBar.Maximum = 40;
            this.PitchScrollBar.Name = "PitchScrollBar";
            this.PitchScrollBar.Size = new System.Drawing.Size(17, 80);
            this.PitchScrollBar.TabIndex = 20;
            this.PitchScrollBar.ValueChanged += new System.EventHandler(this.PitchScrollBar_ValueChanged);
            // 
            // QuadControlStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 313);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label39);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BatteryVoltageBox);
            this.Controls.Add(this.AngleSpeeds);
            this.Controls.Add(this.Angles);
            this.Controls.Add(this.DisconnectButton);
            this.Controls.Add(this.ConnectButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "QuadControlStation";
            this.Text = "QuadControlStation";
            this.Load += new System.EventHandler(this.QuadControl_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.Angles.ResumeLayout(false);
            this.Angles.PerformLayout();
            this.AngleSpeeds.ResumeLayout(false);
            this.AngleSpeeds.PerformLayout();
            this.BatteryVoltageBox.ResumeLayout(false);
            this.BatteryVoltageBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button ConnectButton;
        public System.Windows.Forms.Button DisconnectButton;
        private System.Windows.Forms.GroupBox Angles;
        private System.Windows.Forms.Label YawAngle;
        private System.Windows.Forms.Label RollAngle;
        public System.Windows.Forms.Label PitchAngle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox AngleSpeeds;
        private System.Windows.Forms.Label YawSpeed;
        private System.Windows.Forms.Label RollSpeed;
        public System.Windows.Forms.Label PitchSpeed;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox BatteryVoltageBox;
        private System.Windows.Forms.Label VoltageLevel3;
        private System.Windows.Forms.Label VoltageLevel2;
        public System.Windows.Forms.Label VoltageLevel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label Pressure;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label MagZ;
        private System.Windows.Forms.Label MagY;
        public System.Windows.Forms.Label MagX;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        public System.Windows.Forms.Label TemperatureValue;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label ZAcceleration;
        private System.Windows.Forms.Label YAcceleration;
        public System.Windows.Forms.Label XAcceleration;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Timer joystickTimer;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label YawGain;
        private System.Windows.Forms.Label RollGain;
        private System.Windows.Forms.Label PitchGain;
        private System.Windows.Forms.Label label40;
        public System.Windows.Forms.VScrollBar YawScrollBar;
        public System.Windows.Forms.VScrollBar RollScrollBar;
        public System.Windows.Forms.VScrollBar PitchScrollBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label37;
        public System.Windows.Forms.Label Alltitude;
        private System.Windows.Forms.Label HeightGain;
        public System.Windows.Forms.VScrollBar HeightScrollBar;
    }
}

