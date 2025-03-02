using Microsoft.AspNetCore.Mvc;
using BusinessLayer;
using BusinessLayer.Service;
using RepositoryLayer;
using ModelLayer.DTO;
namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        RegisterHelloBL _registerHelloBL;
        ResponseBody<string> response;


        public WeatherForecastController(RegisterHelloBL registerHelloBL)
        {
            _registerHelloBL = registerHelloBL;
            
        }

        [HttpGet]
        public string Get()
        {
            return _registerHelloBL.register("hello");

        }
        [HttpPost]
        public ResponseBody<string> Post(LoginDTO loginDTO)
        {
            bool result = _registerHelloBL.UsernameAndPassword(loginDTO);
            if (result)
            {
                response = new ResponseBody<string>();
                response.Success = true;
                response.Message = "login successfully.";
                response.Data = loginDTO.Username;
                return response;
            }
            response = new ResponseBody<string>();
            response.Success = false;
            response.Message = "login failed.";
            response.Data = "";
            return response;

        }
    }
}
