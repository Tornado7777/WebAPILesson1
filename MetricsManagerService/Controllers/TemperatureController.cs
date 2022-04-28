using MetricsManagerService.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace MetricsManagerService.Controllers
{
    /*
     * Написать свой контроллер и методы в нем, которые бы предоставляли следующую функциональность:
     * Возможность сохранить температуру в указанное время
     * Возможность отредактировать показатель температуры в указанное время
     * Возможность удалить показатель температуры в указанный промежуток времени
     * Возможность прочитать список показателей температуры за указанный промежуток времени
     */
    

    [Route("api/temperature")]
    [ApiController]
    public class TemperatureController : ControllerBase
    {
        private TemperatureList _temperatureList;
        public TemperatureController(TemperatureList temperatureList)
        {
            _temperatureList = temperatureList;
        }

        //Возможность сохранить температуру в указанное время
        [HttpPost("SaveToTime")]
        public IActionResult SaveToTime([FromQuery] int temperatureC, [FromQuery] TimeSpan toTime)
        {
            Temperature temperature = new Temperature();
            temperature.Date = toTime;
            temperature.TemperatureC = temperatureC;
            _temperatureList.Add(temperature);
            return Ok();
        }

        //Возможность отредактировать показатель температуры в указанное время
        [HttpPost("EditToTime")]
        public IActionResult EditToTime([FromQuery] int temperature, [FromQuery] TimeSpan toTime)
        {
            _temperatureList.EditToTime(temperature, toTime);
            return Ok();
        }

        //Удалить показатель температуры в указанный промежуток времени
        [HttpPost("DeletedRangeTime")]
        public IActionResult DeletedRangeTime([FromQuery] TimeSpan fromTime, [FromQuery] TimeSpan toTime)
        {
            _temperatureList.DeletedRangeTime(fromTime, toTime);
            return Ok();
        }

        //Прочитать список показателей температуры за указанный промежуток времени
        [HttpPost("ReadRangeTime")]
        public IActionResult ReadRangeTime([FromQuery] TimeSpan fromTime, [FromQuery] TimeSpan toTime)
        {

            return Ok(_temperatureList.ReadRangeTime(fromTime, toTime));
        }

        [HttpPost("Read")]
        public IActionResult Read()
        {

            return Ok(_temperatureList.ToString());
        }
    }
}
