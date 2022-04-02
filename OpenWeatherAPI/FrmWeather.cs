using AppCore.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenWeatherAPI
{
    public partial class FrmWeather : Form
    {
        IWeatherServices weatherServices;
        public FrmWeather(IWeatherServices weatherServices)
        {
            this.weatherServices = weatherServices;
            InitializeComponent();
        }

        private void FrmWeather_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCity.Text))
            {
                MessageBox.Show("You must write a city", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var climate = weatherServices.GetWeather(txtCity.Text);
            lblSunrise.Text = weatherServices.ConvertDateTime(climate.Sys.sunrise).ToShortTimeString();
            lblSunset.Text = weatherServices.ConvertDateTime(climate.Sys.sunset).ToShortTimeString();
            lblPressure.Text = climate.Main.pressure.ToString();
            lblWindSpeed.Text = climate.Wind.speed.ToString();
            lblCondition.Text = climate.Weather[0].main;
            lblDetails.Text = climate.Weather[0].description;
            pcboxIcon.ImageLocation = weatherServices.GetImageWeather(climate.Weather[0].icon);
            

        }
    }
}
