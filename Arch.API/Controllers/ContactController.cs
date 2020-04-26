using System.Collections.Generic;
using Arch.Domain.Absract.DomainObjects;
using Arch.Domain.Absract.Logic;
using Arch.Domain.Implementations.DomainObjects;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace arch.Controllers
{
    [ApiController]
    [Route("contact")]
    public class ContactController : ControllerBase
    {
        private readonly ILogger<ContactController> _logger;
        private readonly IContactLogic _contactLogic;
        public ContactController(IContactLogic contactLogic)
        {
            _contactLogic = contactLogic;
        }

        [HttpGet("gett")]
        public IEnumerable<Contact> Geta()
        {
            //return _contactLogic.GetContacts();
            return new List<Contact> { new Contact { Name = "Arun" }, new Contact { Name = "Sudin" } };
        }

        [HttpPost("postt")]
        public IActionResult Posta([FromBody] Contact contact)
        {
            _contactLogic.SaveContact(contact);
            return StatusCode(201);
        }
    }
}
