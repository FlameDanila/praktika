using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraktikaOseledchenko
{
    [Serializable]
    public class Logs
    {
        public List<Log> LogsList { get; set; } = new List<Log>();
    }

    [Serializable]
    public class Log
    {
        public string Film { get; set; }
        public string Time { get; set; }
        public int Cost { get; set; }
        public int Adult { get; set; }
        public int Id { get; set; }

        public Log() { }
        public Log(string Film, string Time, int Cost, int Adult, int Id)
        {
            this.Film = Film;
            this.Time = Time;
            this.Cost = Cost;
            this.Adult = Adult;
            this.Id = Id;
        }
    }
}
