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
            lblFecha.Text = DateTime.Now.ToString("MM/dd/yyyy");
        }

        private void label5_Click(object sender, EventArgs e)
        { 

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtCity.Text))
                {
                    MessageBox.Show("Debes escribir una ciudad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var climate = weatherServices.GetWeather(txtCity.Text);
                lblSunrise.Text = weatherServices.ConvertDateTime(climate.Sys.sunrise).ToShortTimeString();
                lblSunset.Text = weatherServices.ConvertDateTime(climate.Sys.sunset).ToShortTimeString();
                lblPressure.Text = climate.Main.pressure.ToString() + " hPa";
                lblWindSpeed.Text = climate.Wind.speed.ToString() + " m/s";
                lblCondition.Text = climate.Weather[0].main;
                lblDescription.Text = climate.Weather[0].description;
                lblDeg.Text = climate.Wind.deg.ToString();
                lblLat.Text = climate.Coord.lat.ToString();
                lbllon.Text = climate.Coord.lon.ToString();
                lblCloud.Text = climate.Clouds.all.ToString();
                lblFeels_like.Text = climate.Main.feels_like.ToString() + "°C";
                lblMax_temp.Text = climate.Main.temp_max.ToString() + "°C";
                lblMin_temp.Text = climate.Main.temp_min.ToString() + "°C";
                lblTemp.Text = climate.Main.temp.ToString() + "°C";
                lblHumidity.Text = climate.Main.humidity.ToString() + "%";
                lblCountry.Text = climate.Sys.country.ToString();

                pcboxIcon.ImageLocation = weatherServices.GetImageWeather(climate.Weather[0].icon);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
            

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
