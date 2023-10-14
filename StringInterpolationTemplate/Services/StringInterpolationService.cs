using System;
using System.Text;
using Microsoft.Extensions.Logging;
using StringInterpolationTemplate.Utils;

namespace StringInterpolationTemplate.Services
{

    public class StringInterpolationService : IStringInterpolationService
    {
        private readonly ISystemDate _date;
        private readonly ILogger<IStringInterpolationService> _logger;

        public StringInterpolationService(ISystemDate date, ILogger<IStringInterpolationService> logger)
        {
            _date = date;
            _logger = logger;
            _logger.Log(LogLevel.Information, "Executing the StringInterpolationService");
        }

        //1. January 22, 2019 (right aligned in a 40 character field)
        public string Number01()
        {
            var date = _date.Now.ToString("MMMM dd, yyyy");
            var answer = $"{date,40}";
            Console.WriteLine(answer);

            return answer;
        }

        public string Number02()
        {
            var date = _date.Now.ToString("yyyy.MM.dd");
            Console.WriteLine(date);
            return date;
            //throw new NotImplementedException();
        }

        public string Number03()
        {
            var date = _date.Now.ToString("'Day' dd 'of' MMMM, yyyy");
            Console.WriteLine(date);
            return date;
            // throw new NotImplementedException();
        }

        public string Number04()
        {
            var date = _date.Now.ToString("'Year:' yyyy, 'Month:' MM, 'Day:' dd");
            Console.WriteLine(date);
            return date;
            //throw new NotImplementedException();
        }

        public string Number05()
        {
            var date = _date.Now.ToString("dddd");
            var answer = $"{date,10}";
            return answer;
        }

        public string Number06()
        {
            var date = _date.Now.ToString("hh:mm tt");
            var day = _date.Now.ToString("dddd");
            var answer = $"{date,10}{day,10}";
            return answer;
        }

        public string Number07()
        {
            var date = _date.Now.ToString("'h':hh, 'm':mm, 's':ss");
            return date;
        }

        public string Number08()
        {
            var date = _date.Now.ToString("yyyy.MM.dd.hh.mm.ss");
            return date;
        }

        public string Number09()
        {
            var pi = Math.PI;
            var answer = $"${pi:F2}";
            Console.WriteLine(answer);
            return answer;
        }

        public string Number10()
        {
            var pi = Math.PI;
            var answer = $"{pi,10:F3}";
            return answer;
        }

        public string Number11()
        {
            var date = _date.Now.ToString("yyyy");
            byte[] bytes = Encoding.UTF8.GetBytes(date); //not sure if this is how I was supposed to convert the string to hexadecimal, but it's what I found
            string hex = Convert.ToHexString(bytes);
            return hex;
        }

        //2.2019.01.22
    }
}
