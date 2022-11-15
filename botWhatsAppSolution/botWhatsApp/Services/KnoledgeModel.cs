using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace botWhatsApp.Services
{
    public class KnoledgeModel
    {
        public IList<Answers> answers { get; set; }
    }   

    public class Answers
    {
        public IList<string> Questions { get; set; }
        public string Answer { get; set; }
        public double Score { get; set; }
    }
}

