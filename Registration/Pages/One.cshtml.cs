using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Web_API.Models;

namespace Registration.Pages
{
    public class OneModel : PageModel
    {
        string? responseResult;

        public void OnGet()
        {
            var client = new HttpClient();

            var user = new User();

            user.Email = "Something";
            user.Password = "Password";

            using (client)
            {
                var response = client.PostAsJsonAsync("https://localhost:7115/api/Users", user).Result;
                responseResult = response.StatusCode.ToString();
            }
        }
    }
}
