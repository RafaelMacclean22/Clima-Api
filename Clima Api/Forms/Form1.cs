using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain.Entities;
using Clima_Api.Clases;

namespace Clima_Api
{
    public partial class Form1 : Form
    {
        string APIKey = "d45c2ffc2fd7a4cf1b27dace41566589";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        DateTime convertdatetime(long sec)
        {
            DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();
            day = day.AddSeconds(sec).ToLocalTime();
            return day;
        }
        void Buscar()
        {
            using (WebClient web = new WebClient())
            {

                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", txtCiudad.Text, APIKey);

                var json = web.DownloadString(url);
                Clima.root info = JsonConvert.DeserializeObject<Clima.root>(json);

                pictureBox1.ImageLocation = "https://openweathermap.org/img/w/" + info.weather[0].icon + ".png";
                lbpuestadelsol.Text = convertdatetime(info.sys.sunset).ToShortTimeString();
                lbamanecer.Text = convertdatetime(info.sys.sunrise).ToShortTimeString();
                lbviento.Text = Conversiones.ConvertirDeMillasAKm((float)info.wind.speed).ToString();
                lbpresion.Text = info.main.pressure.ToString();
                lbtemperatura.Text = Conversiones.ConvertirDeKelvinACelsius((float)info.main.temp).ToString();
                lbtempmin.Text = Conversiones.ConvertirDeKelvinACelsius((float)info.main.temp_min).ToString();
                lbtempmax.Text = Conversiones.ConvertirDeKelvinACelsius((float)info.main.temp_max).ToString();
                lbhumidity.Text = info.main.humidity.ToString();
            }
        }
     

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            try
            {
                Buscar();
            }
            catch (Exception)
            {
                MessageBox.Show("No se encontro la ciudad ");
            }
           
        }

        private void lbamanecer_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

