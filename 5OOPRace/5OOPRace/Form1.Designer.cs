
namespace _5OOPRace
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnStart = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.pbRace = new System.Windows.Forms.PictureBox();
            this.racetimer = new System.Windows.Forms.Timer(this.components);
            this.btnHColour = new System.Windows.Forms.Button();
            this.btnTColour = new System.Windows.Forms.Button();
            this.cBoxSpeed = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gresults = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.txtHWins = new System.Windows.Forms.TextBox();
            this.txtTWins = new System.Windows.Forms.TextBox();
            this.txtHTies = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtHWins2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTWins2 = new System.Windows.Forms.TextBox();
            this.txtHTies2 = new System.Windows.Forms.TextBox();
            this.btnResetScore = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbPicture = new System.Windows.Forms.RadioButton();
            this.rbDraw = new System.Windows.Forms.RadioButton();
            this.pbT = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pbH = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbRace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gresults)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbT)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbH)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(6, 25);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(103, 25);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(75, 23);
            this.btnPause.TabIndex = 1;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(201, 25);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // pbRace
            // 
            this.pbRace.Location = new System.Drawing.Point(12, 12);
            this.pbRace.Name = "pbRace";
            this.pbRace.Size = new System.Drawing.Size(772, 303);
            this.pbRace.TabIndex = 3;
            this.pbRace.TabStop = false;
            this.pbRace.Click += new System.EventHandler(this.pbRace_Click);
            this.pbRace.Paint += new System.Windows.Forms.PaintEventHandler(this.pbRace_Paint);
            // 
            // racetimer
            // 
            this.racetimer.Tick += new System.EventHandler(this.racetimer_Tick);
            // 
            // btnHColour
            // 
            this.btnHColour.Location = new System.Drawing.Point(103, 104);
            this.btnHColour.Name = "btnHColour";
            this.btnHColour.Size = new System.Drawing.Size(75, 23);
            this.btnHColour.TabIndex = 7;
            this.btnHColour.Text = "Hare Colour";
            this.btnHColour.UseVisualStyleBackColor = true;
            this.btnHColour.Click += new System.EventHandler(this.btnHColour_Click);
            // 
            // btnTColour
            // 
            this.btnTColour.Location = new System.Drawing.Point(6, 104);
            this.btnTColour.Name = "btnTColour";
            this.btnTColour.Size = new System.Drawing.Size(87, 23);
            this.btnTColour.TabIndex = 6;
            this.btnTColour.Text = "Tortoise Colour";
            this.btnTColour.UseVisualStyleBackColor = true;
            this.btnTColour.Click += new System.EventHandler(this.btnTColour_Click);
            // 
            // cBoxSpeed
            // 
            this.cBoxSpeed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxSpeed.FormattingEnabled = true;
            this.cBoxSpeed.Items.AddRange(new object[] {
            "Slow(0.5x)",
            "Default",
            "Fast(2.0x)"});
            this.cBoxSpeed.Location = new System.Drawing.Point(50, 65);
            this.cBoxSpeed.Name = "cBoxSpeed";
            this.cBoxSpeed.Size = new System.Drawing.Size(75, 21);
            this.cBoxSpeed.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Speed";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("November", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 30);
            this.label2.TabIndex = 8;
            this.label2.Text = "Scoreboard";
            // 
            // gresults
            // 
            chartArea1.Name = "ChartArea1";
            this.gresults.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.gresults.Legends.Add(legend1);
            this.gresults.Location = new System.Drawing.Point(866, 12);
            this.gresults.Name = "gresults";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.CustomProperties = "PieLabelStyle=Disabled";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.gresults.Series.Add(series1);
            this.gresults.Size = new System.Drawing.Size(309, 303);
            this.gresults.TabIndex = 9;
            this.gresults.Text = "chart1";
            // 
            // txtHWins
            // 
            this.txtHWins.Location = new System.Drawing.Point(9, 46);
            this.txtHWins.Name = "txtHWins";
            this.txtHWins.ReadOnly = true;
            this.txtHWins.Size = new System.Drawing.Size(66, 20);
            this.txtHWins.TabIndex = 10;
            this.txtHWins.TabStop = false;
            // 
            // txtTWins
            // 
            this.txtTWins.Location = new System.Drawing.Point(92, 46);
            this.txtTWins.Name = "txtTWins";
            this.txtTWins.ReadOnly = true;
            this.txtTWins.Size = new System.Drawing.Size(66, 20);
            this.txtTWins.TabIndex = 11;
            this.txtTWins.TabStop = false;
            // 
            // txtHTies
            // 
            this.txtHTies.Location = new System.Drawing.Point(174, 46);
            this.txtHTies.Name = "txtHTies";
            this.txtHTies.ReadOnly = true;
            this.txtHTies.Size = new System.Drawing.Size(66, 20);
            this.txtHTies.TabIndex = 12;
            this.txtHTies.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Hare Wins";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Tortoise Wins";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtHWins2);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtTWins2);
            this.groupBox1.Controls.Add(this.txtHTies2);
            this.groupBox1.Controls.Add(this.btnResetScore);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(307, 321);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 142);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(187, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Ties";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Hare Wins";
            // 
            // txtHWins2
            // 
            this.txtHWins2.Location = new System.Drawing.Point(13, 81);
            this.txtHWins2.Name = "txtHWins2";
            this.txtHWins2.ReadOnly = true;
            this.txtHWins2.Size = new System.Drawing.Size(66, 20);
            this.txtHWins2.TabIndex = 21;
            this.txtHWins2.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(96, 59);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "Tortoise Wins";
            // 
            // txtTWins2
            // 
            this.txtTWins2.Location = new System.Drawing.Point(99, 81);
            this.txtTWins2.Name = "txtTWins2";
            this.txtTWins2.ReadOnly = true;
            this.txtTWins2.Size = new System.Drawing.Size(66, 20);
            this.txtTWins2.TabIndex = 22;
            this.txtTWins2.TabStop = false;
            // 
            // txtHTies2
            // 
            this.txtHTies2.Location = new System.Drawing.Point(190, 81);
            this.txtHTies2.Name = "txtHTies2";
            this.txtHTies2.ReadOnly = true;
            this.txtHTies2.Size = new System.Drawing.Size(66, 20);
            this.txtHTies2.TabIndex = 23;
            this.txtHTies2.TabStop = false;
            // 
            // btnResetScore
            // 
            this.btnResetScore.Location = new System.Drawing.Point(154, 24);
            this.btnResetScore.Name = "btnResetScore";
            this.btnResetScore.Size = new System.Drawing.Size(102, 23);
            this.btnResetScore.TabIndex = 0;
            this.btnResetScore.Text = "Reset Scoreboard";
            this.btnResetScore.UseVisualStyleBackColor = true;
            this.btnResetScore.Click += new System.EventHandler(this.btnResetScore_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbPicture);
            this.groupBox2.Controls.Add(this.rbDraw);
            this.groupBox2.Controls.Add(this.btnStart);
            this.groupBox2.Controls.Add(this.btnPause);
            this.groupBox2.Controls.Add(this.btnReset);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnHColour);
            this.groupBox2.Controls.Add(this.cBoxSpeed);
            this.groupBox2.Controls.Add(this.btnTColour);
            this.groupBox2.Location = new System.Drawing.Point(12, 321);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(289, 142);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            // 
            // rbPicture
            // 
            this.rbPicture.AutoSize = true;
            this.rbPicture.Location = new System.Drawing.Point(201, 66);
            this.rbPicture.Name = "rbPicture";
            this.rbPicture.Size = new System.Drawing.Size(88, 17);
            this.rbPicture.TabIndex = 4;
            this.rbPicture.Text = "Picture Mode";
            this.rbPicture.UseVisualStyleBackColor = true;
            this.rbPicture.CheckedChanged += new System.EventHandler(this.rbPicture_CheckedChanged);
            // 
            // rbDraw
            // 
            this.rbDraw.AutoSize = true;
            this.rbDraw.Checked = true;
            this.rbDraw.Location = new System.Drawing.Point(201, 107);
            this.rbDraw.Name = "rbDraw";
            this.rbDraw.Size = new System.Drawing.Size(80, 17);
            this.rbDraw.TabIndex = 5;
            this.rbDraw.TabStop = true;
            this.rbDraw.Text = "Draw Mode";
            this.rbDraw.UseVisualStyleBackColor = true;
            this.rbDraw.CheckedChanged += new System.EventHandler(this.rbDraw_CheckedChanged);
            // 
            // pbT
            // 
            this.pbT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbT.BackgroundImage")));
            this.pbT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbT.Location = new System.Drawing.Point(21, 91);
            this.pbT.Name = "pbT";
            this.pbT.Size = new System.Drawing.Size(90, 88);
            this.pbT.TabIndex = 24;
            this.pbT.TabStop = false;
            this.pbT.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtHWins);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtTWins);
            this.groupBox3.Controls.Add(this.txtHTies);
            this.groupBox3.Location = new System.Drawing.Point(866, 321);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(309, 136);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Overall Statistics";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(171, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Ties";
            // 
            // pbH
            // 
            this.pbH.BackColor = System.Drawing.SystemColors.Control;
            this.pbH.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbH.BackgroundImage")));
            this.pbH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbH.Location = new System.Drawing.Point(21, 201);
            this.pbH.Name = "pbH";
            this.pbH.Size = new System.Drawing.Size(90, 86);
            this.pbH.TabIndex = 25;
            this.pbH.TabStop = false;
            this.pbH.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 474);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.pbH);
            this.Controls.Add(this.pbT);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gresults);
            this.Controls.Add(this.pbRace);
            this.Name = "Form1";
            this.Text = "Hare and Tortoise Race";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbRace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gresults)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbT)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.PictureBox pbRace;
        private System.Windows.Forms.Timer racetimer;
        private System.Windows.Forms.Button btnHColour;
        private System.Windows.Forms.Button btnTColour;
        private System.Windows.Forms.ComboBox cBoxSpeed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart gresults;
        private System.Windows.Forms.TextBox txtHWins;
        private System.Windows.Forms.TextBox txtTWins;
        private System.Windows.Forms.TextBox txtHTies;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnResetScore;
        private System.Windows.Forms.RadioButton rbPicture;
        private System.Windows.Forms.RadioButton rbDraw;
        private System.Windows.Forms.PictureBox pbT;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtHWins2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTWins2;
        private System.Windows.Forms.TextBox txtHTies2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pbH;
    }
}

