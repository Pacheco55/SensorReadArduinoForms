using System;

namespace SensorReadArduinoIDE
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttondisconnect = new System.Windows.Forms.Button();
            this.buttonconnect = new System.Windows.Forms.Button();
            this.comboBoxbaudrate = new System.Windows.Forms.ComboBox();
            this.labelbaudrate = new System.Windows.Forms.Label();
            this.comboBoxPort = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.progresbarspeed = new CircularProgressBar.CircularProgressBar();
            this.speedlbl = new System.Windows.Forms.Label();
            this.baterypanel = new System.Windows.Forms.Panel();
            this.bateriastat = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.iamgenbateria = new System.Windows.Forms.PictureBox();
            this.baterylevel = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.statuslabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tempbox = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.baterypanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iamgenbateria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AccessibleName = "ConnectionPanel";
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.buttonconnect);
            this.panel1.Controls.Add(this.comboBoxbaudrate);
            this.panel1.Controls.Add(this.labelbaudrate);
            this.panel1.Controls.Add(this.comboBoxPort);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttondisconnect);
            this.panel1.Location = new System.Drawing.Point(15, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 182);
            this.panel1.TabIndex = 0;
            // 
            // buttondisconnect
            // 
            this.buttondisconnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttondisconnect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttondisconnect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttondisconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttondisconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttondisconnect.Location = new System.Drawing.Point(33, 138);
            this.buttondisconnect.Name = "buttondisconnect";
            this.buttondisconnect.Size = new System.Drawing.Size(133, 34);
            this.buttondisconnect.TabIndex = 6;
            this.buttondisconnect.Text = "Desconectar";
            this.buttondisconnect.UseVisualStyleBackColor = false;
            // 
            // buttonconnect
            // 
            this.buttonconnect.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonconnect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.buttonconnect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonconnect.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonconnect.Location = new System.Drawing.Point(33, 138);
            this.buttonconnect.Name = "buttonconnect";
            this.buttonconnect.Size = new System.Drawing.Size(138, 34);
            this.buttonconnect.TabIndex = 5;
            this.buttonconnect.Text = "Conectar";
            this.buttonconnect.UseVisualStyleBackColor = false;
            // 
            // comboBoxbaudrate
            // 
            this.comboBoxbaudrate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.comboBoxbaudrate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxbaudrate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxbaudrate.FormattingEnabled = true;
            this.comboBoxbaudrate.Items.AddRange(new object[] {
            "9600",
            "14400",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.comboBoxbaudrate.Location = new System.Drawing.Point(170, 105);
            this.comboBoxbaudrate.Name = "comboBoxbaudrate";
            this.comboBoxbaudrate.Size = new System.Drawing.Size(130, 24);
            this.comboBoxbaudrate.TabIndex = 4;
            // 
            // labelbaudrate
            // 
            this.labelbaudrate.AutoSize = true;
            this.labelbaudrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelbaudrate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.labelbaudrate.Location = new System.Drawing.Point(30, 107);
            this.labelbaudrate.Name = "labelbaudrate";
            this.labelbaudrate.Size = new System.Drawing.Size(92, 16);
            this.labelbaudrate.TabIndex = 3;
            this.labelbaudrate.Text = "Baud Rate : ";
            // 
            // comboBoxPort
            // 
            this.comboBoxPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.comboBoxPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxPort.FormattingEnabled = true;
            this.comboBoxPort.Location = new System.Drawing.Point(159, 68);
            this.comboBoxPort.Name = "comboBoxPort";
            this.comboBoxPort.Size = new System.Drawing.Size(142, 24);
            this.comboBoxPort.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(28, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "Scan Port";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Location = new System.Drawing.Point(44, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Connection Panel";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.progresbarspeed);
            this.panel2.Controls.Add(this.speedlbl);
            this.panel2.Location = new System.Drawing.Point(365, 18);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(224, 179);
            this.panel2.TabIndex = 1;
            // 
            // progresbarspeed
            // 
            this.progresbarspeed.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.progresbarspeed.AnimationSpeed = 500;
            this.progresbarspeed.BackColor = System.Drawing.Color.Transparent;
            this.progresbarspeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.progresbarspeed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.progresbarspeed.InnerColor = System.Drawing.Color.White;
            this.progresbarspeed.InnerMargin = 2;
            this.progresbarspeed.InnerWidth = -1;
            this.progresbarspeed.Location = new System.Drawing.Point(34, 35);
            this.progresbarspeed.MarqueeAnimationSpeed = 2000;
            this.progresbarspeed.Name = "progresbarspeed";
            this.progresbarspeed.OuterColor = System.Drawing.Color.Gray;
            this.progresbarspeed.OuterMargin = -25;
            this.progresbarspeed.OuterWidth = 26;
            this.progresbarspeed.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.progresbarspeed.ProgressWidth = 25;
            this.progresbarspeed.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.progresbarspeed.Size = new System.Drawing.Size(150, 133);
            this.progresbarspeed.StartAngle = 92;
            this.progresbarspeed.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.progresbarspeed.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.progresbarspeed.SubscriptText = "";
            this.progresbarspeed.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.progresbarspeed.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.progresbarspeed.SuperscriptText = "";
            this.progresbarspeed.TabIndex = 1;
            this.progresbarspeed.Text = " °C ";
            this.progresbarspeed.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.progresbarspeed.Value = 68;
            // 
            // speedlbl
            // 
            this.speedlbl.AutoSize = true;
            this.speedlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speedlbl.Location = new System.Drawing.Point(66, 12);
            this.speedlbl.Name = "speedlbl";
            this.speedlbl.Size = new System.Drawing.Size(91, 20);
            this.speedlbl.TabIndex = 0;
            this.speedlbl.Text = "Velocidad";
            // 
            // baterypanel
            // 
            this.baterypanel.BackColor = System.Drawing.Color.White;
            this.baterypanel.Controls.Add(this.bateriastat);
            this.baterypanel.Controls.Add(this.label2);
            this.baterypanel.Controls.Add(this.pictureBox1);
            this.baterypanel.Controls.Add(this.iamgenbateria);
            this.baterypanel.Controls.Add(this.baterylevel);
            this.baterypanel.Location = new System.Drawing.Point(620, 20);
            this.baterypanel.Name = "baterypanel";
            this.baterypanel.Size = new System.Drawing.Size(215, 178);
            this.baterypanel.TabIndex = 2;
            // 
            // bateriastat
            // 
            this.bateriastat.AutoSize = true;
            this.bateriastat.BackColor = System.Drawing.Color.Transparent;
            this.bateriastat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bateriastat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bateriastat.Location = new System.Drawing.Point(50, 134);
            this.bateriastat.Name = "bateriastat";
            this.bateriastat.Size = new System.Drawing.Size(50, 29);
            this.bateriastat.TabIndex = 4;
            this.bateriastat.Text = "0 V";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pictureBox1.Location = new System.Drawing.Point(28, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 52);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // iamgenbateria
            // 
            this.iamgenbateria.BackColor = System.Drawing.Color.LightGray;
            this.iamgenbateria.Location = new System.Drawing.Point(28, 59);
            this.iamgenbateria.Name = "iamgenbateria";
            this.iamgenbateria.Size = new System.Drawing.Size(160, 52);
            this.iamgenbateria.TabIndex = 1;
            this.iamgenbateria.TabStop = false;
            // 
            // baterylevel
            // 
            this.baterylevel.AutoSize = true;
            this.baterylevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baterylevel.Location = new System.Drawing.Point(61, 13);
            this.baterylevel.Name = "baterylevel";
            this.baterylevel.Size = new System.Drawing.Size(80, 25);
            this.baterylevel.TabIndex = 0;
            this.baterylevel.Text = "Bateria";
            // 
            // chart1
            // 
            chartArea4.AxisX.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            chartArea4.AxisX.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea4.AxisX.MajorTickMark.LineColor = System.Drawing.Color.DarkGray;
            chartArea4.AxisY.LabelStyle.ForeColor = System.Drawing.Color.Teal;
            chartArea4.AxisY.MajorGrid.LineColor = System.Drawing.Color.DarkGray;
            chartArea4.AxisY.MajorTickMark.LineColor = System.Drawing.Color.DarkGray;
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            legend4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            legend4.IsTextAutoFit = false;
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(22, 218);
            this.chart1.Name = "chart1";
            series4.BorderWidth = 2;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Color = System.Drawing.Color.Teal;
            series4.Legend = "Legend1";
            series4.Name = "Temperatura";
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(813, 220);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            // 
            // statuslabel
            // 
            this.statuslabel.AutoSize = true;
            this.statuslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statuslabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.statuslabel.Location = new System.Drawing.Point(610, 390);
            this.statuslabel.Name = "statuslabel";
            this.statuslabel.Size = new System.Drawing.Size(220, 25);
            this.statuslabel.TabIndex = 4;
            this.statuslabel.Text = "Status : Deconectado";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Red;
            this.pictureBox2.Location = new System.Drawing.Point(797, 353);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 28);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // tempbox
            // 
            this.tempbox.AutoSize = true;
            this.tempbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tempbox.Location = new System.Drawing.Point(662, 268);
            this.tempbox.Name = "tempbox";
            this.tempbox.Size = new System.Drawing.Size(67, 25);
            this.tempbox.TabIndex = 6;
            this.tempbox.Text = "0  ° C";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.ForeColor = System.Drawing.Color.Black;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.linkLabel1.Location = new System.Drawing.Point(5, 425);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(121, 16);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "PIXELBITS Studios";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 450);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.tempbox);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.statuslabel);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.baterypanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.baterypanel.ResumeLayout(false);
            this.baterypanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iamgenbateria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxbaudrate;
        private System.Windows.Forms.Label labelbaudrate;
        private System.Windows.Forms.ComboBox comboBoxPort;
        private System.Windows.Forms.Button buttondisconnect;
        private System.Windows.Forms.Button buttonconnect;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label speedlbl;
        private CircularProgressBar.CircularProgressBar progresbarspeed;
        private System.Windows.Forms.Panel baterypanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox iamgenbateria;
        private System.Windows.Forms.Label baterylevel;
        private System.Windows.Forms.Label bateriastat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label statuslabel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label tempbox;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

