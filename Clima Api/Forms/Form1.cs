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
        void Busqueda()
        {
            using (WebClient web = new WebClient())
            {

                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", txtCiudad.Text, APIKey);

                var json = web.DownloadString(url);
                Clima.root info = JsonConvert.DeserializeObject<Clima.root>(json);

                pictureBox1.ImageLocation = "https://openweathermap.org/img/w/04n.png" + info.weather[0].icon + ".png";
                lbpuestadelsol.Text = convertdatetime(info.sys.sunset).ToShortTimeString();
                lbamanecer.Text = convertdatetime(info.sys.sunrise).ToShortTimeString();
                lbviento.Text = (info.wind.speed * 3.6).ToString();
                lbpresion.Text = info.main.pressure.ToString();
                lbtemperatura.Text = (info.main.temp - 273.15).ToString();
                lbtempmin.Text = (info.main.temp_min - 273.15).ToString();
                lbtempmax.Text = (info.main.temp_max - 273.15).ToString();
                lbhumidity.Text = info.main.humidity.ToString();
            }
        }
     

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            Busqueda();
        }

        private void lbamanecer_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

