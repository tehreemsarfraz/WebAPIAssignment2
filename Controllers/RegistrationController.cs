using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using WebAPIAssignment2.Model;

namespace WebAPIAssignment2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistrationController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        public RegistrationController(IConfiguration configuration)
        {
            _configuration = configuration;

        }
        [HttpPost]
        [Route("registration")]
        public string registration(Registration registration)
        {
            SqlConnection con=new SqlConnection(_configuration.GetConnectionString("Test").ToString());
            SqlCommand cmd = new SqlCommand("INSERT INTO Registration(UserName,Password,Email,IsACTIVE) VALUES ( '" + registration.UserName + "' ,'" + registration.Password + "', '" + registration.Email + "', '" + registration.IsACTIVE + "')", con);
          con.Open ();
            int i =cmd.ExecuteNonQuery();
            con .Close ();
            if (i>0)
            {
                return "Data Inserted";
            }
            else {
                return "Error";
            }
            return "";
        }

    }
}
