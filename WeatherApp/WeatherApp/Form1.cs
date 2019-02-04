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
using Newtonsoft.Json;

namespace WeatherApp
{
    public partial class Form1 : Form
    {
        const string APPID = "542ffd081e67f4512b705f89d2a611b2";
        string cityName = "Seattle";
        public Form1()
        {
            InitializeComponent();
            getWeather("Seattle"); //one day weather
            getForcast("Seattle"); // more than one day
        }

        void getWeather(string city)
        {

            using(WebClient web = new WebClient())
            {
                string url = string.Format("http://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}&units=metric&cnt=6",city, APPID); // you change parts of the url to equal objexts at the end

                var json = web.DownloadString(url);

                var result = JsonConvert.DeserializeObject<WeatherInfo.root>(json);

                WeatherInfo.root outPut = outPut = result;

                lbl_cityName.Text = string.Format("{0}", outPut.name);
                lbl_country.Text = string.Format("{0}", outPut.sys.country);
                lbl_Temp.Text = string.Format("{0} \u00B0" +"C", outPut.main.temp);

                picture_Main.Image = setIcon(outPut.weather[0].icon);
            }
            
        }
        void getForcast (string city)
        {

            int day = 5;
            string url = string.Format("http://api.openweathermap.org/data/2.5/forecast/daily?q={0}&units=metric&cnt={1}&APPID={2}", city,day,APPID);
            using (WebClient web = new WebClient())
            {
                var json = web.DownloadString(url);
                var Object = JsonConvert.DeserializeObject<weatherForcast>(json);

                weatherForcast forcast = Object;

                // when doing forcast remeber to increase forcast.list by 1 for the corespodning day
                //tomorrow
                lbl_Days.Text = string.Format("{0}", getDate(forcast.list[1].dt).DayOfWeek ); // returns Day
                lbl_Conditions.Text = string.Format("{0}", forcast.list[1].weather[0].main); // weather condition (.text allows label to change)
                lbl_description.Text = string.Format("{0}", forcast.list[1].weather[0].description); // weather description
                lbl_Temp2.Text = string.Format("{0} \u00B0" + "C", forcast.list[1].temp.day); // weather temp
                lbl_windspeed.Text = string.Format("{0} km/h", forcast.list[1].speed); // weather wind speed

                //day after tomorrow
                lbl_Days2.Text = string.Format("{0}", getDate(forcast.list[2].dt).DayOfWeek); // returns Day
                lbl_Conditions2.Text = string.Format("{0}", forcast.list[2].weather[0].main); // weather condition (.text allows label to change)
                lbl_description2.Text = string.Format("{0}", forcast.list[2].weather[0].description); // weather description
                lbl_Temp3.Text = string.Format("{0} \u00B0" + "C", forcast.list[2].temp.day); // weather temp
                lbl_windspeed2.Text = string.Format("{0} km/h", forcast.list[2].speed); // weather wind speed


                //weather icon
                pic_1.Image = setIcon(forcast.list[1].weather[0].icon);
                pic_2.Image = setIcon(forcast.list[2].weather[0].icon);

            }


        }

        DateTime getDate(double millisecond) // converts the milliseconds from lbl_Days.Text into a date and time
        {
            DateTime day = new System.DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();
            day = day.AddSeconds(millisecond).ToLocalTime();

            return day;

        }

        Image setIcon(string iconID)
        {
            string url = string.Format("https://openweathermap.org/img/w/{0}.png", iconID); // weather icon resource (gets iconID from weatherinfo
            var request = WebRequest.Create(url);
            using (var response = request.GetResponse())
            using (var weatherIcon = response.GetResponseStream())
            {
                Image weatherImg = Bitmap.FromStream(weatherIcon);
                return weatherImg;
            }
             

        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Conditions_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (txt_cityname.Text != "")
            {
               
                getWeather(txt_cityname.Text);
                getForcast(txt_cityname.Text);

            }
        }




    }



}
