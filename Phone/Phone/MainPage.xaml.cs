using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Phone
{
    public class User
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }

    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var client = new HttpClient();

            var user = new User();

            user.Email = "Something";
            user.Password = "Password";

            using (client)
            {
                var response = client.PostAsync("", new StringContent(JsonSerializer.Serialize(user), Encoding.UTF8, "application/json"));
                ResultText.Text = response.Result.StatusCode.ToString();
            }
        }
    }
}