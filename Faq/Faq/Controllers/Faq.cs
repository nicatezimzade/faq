using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Faq.Controllers
{
    public class Faq
    {
        public string question { get; set; }

        public string answer { get; set; }

        public Faq(string question, string answer)
        {
            this.question = question;
            this.answer = answer;
        }

    }
}
