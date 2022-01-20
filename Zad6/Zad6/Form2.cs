using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;

namespace Zad6
{
    public partial class Form2 : Form
    {
        const int max_temp = 140;
        const string czekanie = "30";
        const int ile_mieszanki = 200;
        const int czas_awaria = 900*20;
        const int obecnosc_czas = 30;
        private Form1 Form1 = null;
        
        private static DispatcherTimer refresh;
        private static DispatcherTimer obecnosc;
        private static System.Timers.Timer Awarie;

        private double temperatura = 90;
        private double mieszanka = 200;
        private usterka[] zepsute = { usterka.Działa, usterka.Działa };
        private dziala[] czyWlaczony = { dziala.ON, dziala.ON };
        private Uzytkownik jest;


        enum Uzytkownik { Zalogowany, Niezalogowany };
        enum usterka { Działa, Popsuty, Wtrakcie };
        enum dziala { ON, OFF };
        Random rand = new Random();

        public static int Max_temp => max_temp;

        public Form2(Form callingForm)
        {
            Form1 = callingForm as Form1;
            jest = Uzytkownik.Zalogowany;
            InitializeComponent();
            Timer();
        }

        public void Timer()
        {
            Awarie = new System.Timers.Timer(czas_awaria);
            Awarie.Elapsed += awarie;
            Awarie.AutoReset = true;
            Awarie.Enabled = true;

            obecnosc = new DispatcherTimer();
            obecnosc.Interval = TimeSpan.FromSeconds(obecnosc_czas);
            obecnosc.Tick += czyObecny;
            obecnosc.Start();

            refresh = new DispatcherTimer();
            refresh.Interval = TimeSpan.FromSeconds(0.5);
            refresh.Tick += aktualizuje;
            refresh.Start();
        }
        private void aktualizuje(object sender, EventArgs e)
        {
            silnik();
            spadek_mieszanki();
            odliczanieObecnosci();
        }

        private void awarie(Object source, System.Timers.ElapsedEventArgs e)
        {
            int Co_zepsute = 0;
            //0 zepsuł się silnik,  1 trzeba dolać mieszanke 
            bool czynnik = true;

            while (czynnik)
            {
                Co_zepsute = rand.Next(0, 2) + 1;
                if (czyWlaczony[0] == dziala.ON)
                    czynnik = false;
            }

            switch (rand.Next(1, 4))
            {
                case 1:
                    if (zepsute[0] == usterka.Działa)
                    {
                        zepsute[0] = usterka.Popsuty;
                        MessageBox.Show("UWAGA! Silnik  przestał działać!.", "Awaria", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    }
                    break;
                case 2:
                    if (zepsute[0] == usterka.Działa)
                    {
                        temperatura += rand.Next(10, 20);
                        if (temperatura >= 120)
                            MessageBox.Show("UWAGA!! W silniku  temperatura przekroczyła max wartość! Sprawdż parametry slnika!", "Awaria", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                        else
                            MessageBox.Show("UWAGA!! W silniku nagły wzrost temperatury!", "Awaria", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

                    }
                    break;
                case 3:
                    if(zepsute[1]== usterka.Działa)
                    {   //Jeżeli zużycie mieszanki jest duze nalezy ją dolac 
                        zepsute[1] = usterka.Popsuty;
                        if (mieszanka >= 240)
                            MessageBox.Show("UWAGA!! W zbiorniku ilość mieszanki spadła poniżej minimum! Dolej mieszanki!", "Awaria", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                        else
                            MessageBox.Show("UWAGA!! W zbiorniku nagły spadek poziomu mieszanki!", "Awaria", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);


                    }
                    break;
            }

        }

        private void spadek_mieszanki()
        {

            try
            {
                if (progressBar4.Value + ile_mieszanki / 4 < 100)
                    progressBar4.Value += ile_mieszanki / 4;
                else if (progressBar4.Value == 100)
                    progressBar4.Value += 1;
                else
                    progressBar4.Value = 100;
            }
            catch (Exception e)
            {
                progressBar4.Value = 0;
                int zuzyte = Int32.Parse(label7.Text);
                zuzyte = zuzyte + 20;
                label7.Text = zuzyte.ToString();
            }

            if (czyWlaczony[1] == dziala.ON)
            {

                if (zepsute[1] == usterka.Działa)
                {
                    progressBar2.Visible = false;

                    label15.Text = "MIESZANKA W NORMIE";
                    button4.Visible = false;
                    label15.ForeColor = Color.FromName("GREEN");

                }
                else if (zepsute[1] == usterka.Popsuty)
                {
                    progressBar2.Visible = true;

                    label15.Text = "BRAK MIESZANKI";
                    button4.Visible = true;
                    label15.ForeColor = Color.FromName("Red");

                }
                else //czy mieszanka jest dolewana
                {
                    try
                    {
                        progressBar2.Value += 10;
                    }
                    catch (Exception e)
                    {
                        zepsute[1] = usterka.Działa;
                        progressBar2.Value = 0;
                    }
                }
            }
        }
        private void silnik()
        {
            int rpm = Int32.Parse(labelRPM1.Text);
            int obciazenie = Int32.Parse(labelOBC1.Text);
            TemperaturaOdRPM(obciazenie, ref temperatura);
            TemperaturaOdObciazenia(rpm, ref temperatura);
            try
            {
                if (progressBar3.Value + obciazenie / 5 < 100)
                    progressBar3.Value += obciazenie / 5;
                else if (progressBar3.Value == 100)
                    progressBar3.Value += 1;
                else
                    progressBar3.Value = 100;
            }
            catch (Exception e)//uruchamiane po przekroczeniu 100%
            {
                progressBar3.Value = 0;
                int wyprodukowane = Int32.Parse(labelProdukcja.Text);
                wyprodukowane++;
                labelProdukcja.Text = wyprodukowane.ToString();
            }

            int zuzycieEnergi = (rpm + obciazenie * 20) / 50;
            labelkWh1.Text = String.Format("{0:N2}", zuzycieEnergi);
            labelTemp1.Text = String.Format("{0:N2}", temperatura);

            if (temperatura >= Max_temp)
                labelTemp1.ForeColor = Color.FromName("Red");
            else
                labelTemp1.ForeColor = Color.FromName("Black");
            if (czyWlaczony[0] == dziala.ON)
            {
                if (zepsute[0] == usterka.Działa)
                {
                    progressBar1.Visible = false;
                    label14.Text = "DZIAŁA";
                    label1.Visible = true;
                    button3.Visible = false;
                    label15.ForeColor = Color.FromName("GREEN");
                    labelOBC1.Text = numericUpDownObciazenie.Value.ToString();
                    labelRPM1.Text = numericUpDownRPM.Value.ToString();
                }
                else if (zepsute[0] == usterka.Popsuty)
                {
                    progressBar1.Visible = true;
                    label14.Text = "ZEPSUTY";
                    button3.Visible = true;
                    label14.ForeColor = Color.FromName("Red");
                    labelOBC1.Text = "0";
                    labelRPM1.Text = "0";
                    labelkWh1.Text = "0";
                }
                else //czy silnik jest w trakcie naprawy
                {
                    try
                    {
                        progressBar1.Value += 15;
                    }
                    catch (Exception e)
                    {
                        zepsute[0] = usterka.Działa;
                        progressBar1.Value = 0;
                    }
                }
            }
        }

        
        private void TemperaturaOdRPM(int RPM, ref double temp)
        {
            if (RPM > 30)
            {
                if (RPM > 60)
                {
                    if (RPM > 90)
                        temp += 0.5;
                    else
                        temp += 0.4;
                }
                else
                    temp += 0.3;
            }
            else if (RPM != 0)
                temp += 0.2;
            else
                temp -= 0.5;
        }

        
        private void TemperaturaOdObciazenia(int obciazenie, ref double temp)
        {
            if (obciazenie > 1000)
            {
                if (obciazenie > 2000)
                {
                    if (obciazenie > 3000)
                    {
                        if (obciazenie > 4000)
                            temp -= 0.6;
                        else
                            temp -= 0.5;
                    }
                    else
                        temp -= 0.30;
                }
                else
                    temp -= 0.2;
            }
            else if (obciazenie > 500)
                temp -= 0.1;
        }

        // sprawdzanie obecnosci
        private void czyObecny(object sender, EventArgs e)
        {
            labelCzas.Text = czekanie;
            labelObecnosc.Visible = true;
            labelCzas.Visible = true;
            button5.Visible = true;
            jest = Uzytkownik.Niezalogowany;
            obecnosc.Stop();
        }

        

        //funkcja odlicza czas na potwierdzenie obecności pracownika
        private void odliczanieObecnosci()
        {
            if (jest == Uzytkownik.Niezalogowany)
            {
                int czasPotwierdzenia = Int32.Parse(labelCzas.Text);
                czasPotwierdzenia--;
                labelCzas.Text = czasPotwierdzenia.ToString();
                if (czasPotwierdzenia == 0)
                {

                    System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                    player.SoundLocation = "alarm1.wav";
                    player.Load();
                    player.Play();
                    this.Hide();
                    this.Close();
                    Form1.Show();
                }
            }
        }


        //wlaczanie lini produkcyjnej
      

        private void button1_Click(object sender, EventArgs e)
        {
           
        

            label13.ForeColor = Color.FromName("Green");
            czyWlaczony[0] = dziala.ON;
            label13.Text = "ON";
            czyWlaczony[1] = dziala.ON;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        // Przycisk potwierdzjący obecnosc
        private void button5_Click(object sender, EventArgs e)
        {
            jest = Uzytkownik.Zalogowany;
            labelObecnosc.Visible = false;
            labelCzas.Visible = false;
            button5.Visible = false;
            obecnosc.Start();
        }

        //wyłączanie lini produkcyjnej
        private void button2_Click(object sender, EventArgs e)
        {
            mieszanka = 0;
            labelOBC1.Text = "0";
            labelRPM1.Text = "0";
            labelkWh1.Text = "0";
            czyWlaczony[0] = dziala.OFF;
            czyWlaczony[1] = dziala.OFF;
            label13.Text = "OFF";
            label13.ForeColor = Color.FromName("Red");
        }

      

        

  

        //zmienia stan  na w trakcie naprawy 
        private void button3_Click(object sender, EventArgs e)
        {
            zepsute[0] = usterka.Wtrakcie;
        }
        //zmienia stan na w trakcie naprawy
        private void button4_Click(object sender, EventArgs e)
        {
            zepsute[1] = usterka.Wtrakcie;
        }
        //Przypisywanie zadanej wartosci obrotow silnika
        private void numericUpDownObroty_ValueChanged(object sender, EventArgs e)
        {
            if (zepsute[0] == usterka.Działa)
                labelRPM1.Text = numericUpDownRPM.Value.ToString();
        }
        //Przypisywanie zadanej wartosci szybkosci
        private void numericUpDownSzybkosc_ValueChanged(object sender, EventArgs e)
        {
            if (zepsute[0] == usterka.Działa)
                labelOBC1.Text = numericUpDownObciazenie.Value.ToString();
        }
    }
    }

