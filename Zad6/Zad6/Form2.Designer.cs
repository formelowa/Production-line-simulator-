
namespace Zad6
{
    partial class Form2
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.labelProdukcja = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.progressBar4 = new System.Windows.Forms.ProgressBar();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelkWh1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.numericUpDownObciazenie = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownRPM = new System.Windows.Forms.NumericUpDown();
            this.labelOBC1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labelRPM1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.labelTemp1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.labelObecnosc = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.labelCzas = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownObciazenie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRPM)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(47, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Włącz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(138, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Parametry lini produkcyjnej lodów";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(137, 99);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Wyłącz";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Silnik";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(347, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Poziom mieszanki";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(126, 163);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 5;
            this.progressBar1.Visible = false;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(373, 163);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(100, 23);
            this.progressBar2.TabIndex = 6;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(29, 163);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Napraw";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(279, 163);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "Dolej";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Wyprodukowane partie lodów";
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(47, 231);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(178, 23);
            this.progressBar3.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Wyprodukowano:";
            // 
            // labelProdukcja
            // 
            this.labelProdukcja.AutoSize = true;
            this.labelProdukcja.Location = new System.Drawing.Point(156, 273);
            this.labelProdukcja.Name = "labelProdukcja";
            this.labelProdukcja.Size = new System.Drawing.Size(13, 13);
            this.labelProdukcja.TabIndex = 12;
            this.labelProdukcja.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(322, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Zużycie mieszanki";
            // 
            // progressBar4
            // 
            this.progressBar4.Location = new System.Drawing.Point(279, 231);
            this.progressBar4.Name = "progressBar4";
            this.progressBar4.Size = new System.Drawing.Size(178, 23);
            this.progressBar4.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(399, 273);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(287, 273);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Zużyto";
            // 
            // labelkWh1
            // 
            this.labelkWh1.AutoSize = true;
            this.labelkWh1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelkWh1.Location = new System.Drawing.Point(202, 361);
            this.labelkWh1.Name = "labelkWh1";
            this.labelkWh1.Size = new System.Drawing.Size(16, 17);
            this.labelkWh1.TabIndex = 26;
            this.labelkWh1.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(156, 361);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 17);
            this.label9.TabIndex = 25;
            this.label9.Text = "kW/h:";
            // 
            // numericUpDownObciazenie
            // 
            this.numericUpDownObciazenie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDownObciazenie.Location = new System.Drawing.Point(48, 323);
            this.numericUpDownObciazenie.Name = "numericUpDownObciazenie";
            this.numericUpDownObciazenie.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numericUpDownObciazenie.Size = new System.Drawing.Size(56, 23);
            this.numericUpDownObciazenie.TabIndex = 24;
            this.numericUpDownObciazenie.Value = new decimal(new int[] {
            61,
            0,
            0,
            0});
            this.numericUpDownObciazenie.ValueChanged += new System.EventHandler(this.numericUpDownSzybkosc_ValueChanged);
            // 
            // numericUpDownRPM
            // 
            this.numericUpDownRPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDownRPM.Location = new System.Drawing.Point(160, 322);
            this.numericUpDownRPM.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericUpDownRPM.Name = "numericUpDownRPM";
            this.numericUpDownRPM.Size = new System.Drawing.Size(56, 23);
            this.numericUpDownRPM.TabIndex = 23;
            this.numericUpDownRPM.Value = new decimal(new int[] {
            3700,
            0,
            0,
            0});
            this.numericUpDownRPM.ValueChanged += new System.EventHandler(this.numericUpDownObroty_ValueChanged);
            // 
            // labelOBC1
            // 
            this.labelOBC1.AutoSize = true;
            this.labelOBC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelOBC1.Location = new System.Drawing.Point(109, 303);
            this.labelOBC1.Name = "labelOBC1";
            this.labelOBC1.Size = new System.Drawing.Size(24, 17);
            this.labelOBC1.TabIndex = 22;
            this.labelOBC1.Text = "50";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(44, 303);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 17);
            this.label10.TabIndex = 21;
            this.label10.Text = "Obc:";
            // 
            // labelRPM1
            // 
            this.labelRPM1.AutoSize = true;
            this.labelRPM1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRPM1.Location = new System.Drawing.Point(202, 303);
            this.labelRPM1.Name = "labelRPM1";
            this.labelRPM1.Size = new System.Drawing.Size(40, 17);
            this.labelRPM1.TabIndex = 20;
            this.labelRPM1.Text = "1000";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(156, 303);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 17);
            this.label11.TabIndex = 19;
            this.label11.Text = "RPM:";
            // 
            // labelTemp1
            // 
            this.labelTemp1.AutoSize = true;
            this.labelTemp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTemp1.Location = new System.Drawing.Point(109, 361);
            this.labelTemp1.Name = "labelTemp1";
            this.labelTemp1.Size = new System.Drawing.Size(16, 17);
            this.labelTemp1.TabIndex = 18;
            this.labelTemp1.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(45, 361);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 17);
            this.label12.TabIndex = 17;
            this.label12.Text = "Temp:";
            // 
            // labelObecnosc
            // 
            this.labelObecnosc.AutoSize = true;
            this.labelObecnosc.Location = new System.Drawing.Point(287, 307);
            this.labelObecnosc.Name = "labelObecnosc";
            this.labelObecnosc.Size = new System.Drawing.Size(104, 13);
            this.labelObecnosc.TabIndex = 27;
            this.labelObecnosc.Text = "Obecność operatora";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(360, 343);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 28;
            this.button5.Text = "Potwierdź";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(94, 135);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 13);
            this.label14.TabIndex = 29;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(347, 135);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(0, 13);
            this.label15.TabIndex = 30;
            // 
            // labelCzas
            // 
            this.labelCzas.AutoSize = true;
            this.labelCzas.Location = new System.Drawing.Point(429, 307);
            this.labelCzas.Name = "labelCzas";
            this.labelCzas.Size = new System.Drawing.Size(19, 13);
            this.labelCzas.TabIndex = 31;
            this.labelCzas.Text = "30";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(240, 104);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(21, 13);
            this.label13.TabIndex = 32;
            this.label13.Text = "On";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 450);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.labelCzas);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.labelObecnosc);
            this.Controls.Add(this.labelkWh1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.numericUpDownObciazenie);
            this.Controls.Add(this.numericUpDownRPM);
            this.Controls.Add(this.labelOBC1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.labelRPM1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.labelTemp1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.progressBar4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelProdukcja);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.progressBar3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.RightToLeftLayout = true;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownObciazenie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRPM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelProdukcja;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ProgressBar progressBar4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelkWh1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericUpDownObciazenie;
        private System.Windows.Forms.NumericUpDown numericUpDownRPM;
        private System.Windows.Forms.Label labelOBC1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelRPM1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelTemp1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label labelObecnosc;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label labelCzas;
        private System.Windows.Forms.Label label13;
    }
}