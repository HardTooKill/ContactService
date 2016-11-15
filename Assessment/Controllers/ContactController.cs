using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Assessment.Models;

namespace Assessment.Controllers
{
    public class ContactController : ApiController
    {
        private readonly Models.ContactsService _contacServices;

        #region Public Constructor

        /// <summary>
        /// Public constructor to initialize product service instance
        /// </summary>
        public ContactController()
        {
            _contacServices = new ContactsService();
        }
        #endregion

        public HttpResponseMessage GetAllProducts()
        {
            var contacts= _contacServices.GetAll();
            if (contacts != null)
            {
                if (contacts.Count>0)
                    return Request.CreateResponse(HttpStatusCode.OK, contacts);
            }
            return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Products not found");
        }
    }
}
