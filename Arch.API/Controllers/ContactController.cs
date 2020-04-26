using System.Collections.Generic;
using Arch.Domain.Absract.DomainObjects;
using Arch.Domain.Absract.Logic;
using Arch.Domain.Implementations.DomainObjects;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace arch.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContactController : ControllerBase
    {
        private readonly ILogger<ContactController> _logger;
        private readonly IContactLogic _contactLogic;
        public ContactController(IContactLogic contactLogic)
        {
            _contactLogic = contactLogic;
        }

        /// <summary> Retrieve all contacts. </summary>
        [HttpGet]
        public IList<IContact> Get()
        {
            return _contactLogic.GetContacts();
        }

        /// <summary> Create a new contact. </summary>
        [HttpPost]
        public IActionResult Post([FromBody] Contact contact)
        {
            _contactLogic.SaveContact(contact);
            return StatusCode(201);
        }
    }
}
