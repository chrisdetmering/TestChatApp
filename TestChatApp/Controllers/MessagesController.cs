using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace TestChatApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MessagesController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Hi!", "How are you?", "I am well..."
        };

        private readonly ILogger<MessagesController> _logger;

        public MessagesController(ILogger<MessagesController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Message> Get()
        {
            var rng = new Random();
            return Enumerable.Range(0, 2).Select(index => new Message
            {
                Date = DateTime.Now.AddDays(index),
                Text = Summaries[index]
              
            })
            .ToArray();
        }
    }
}
