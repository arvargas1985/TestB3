namespace TestB3.WebApi.Controllers
{
    using System;
    using System.Globalization;
    using System.Web.Http;
    using TestB3.WebApi.Models;

    [RoutePrefix("api/quotesCdbs")]
    public class QuotesCDBsController : ApiController
    {
        private const string MESSAGE_NOT_IMPLEMENTED_EXCEPTION = "The Http Verb {0} is not implemented!";

        private readonly IQuoteCDBRepository _quoteCDBRepository = new QuoteCDBRepository();

        [HttpGet]
        public IHttpActionResult GetCDB(int id)
        {
            var cdbs = new string[] { id.ToString(), id.ToString(), id.ToString() };

            //return Content(HttpStatusCode.Found, cdbs);

            return Ok(cdbs);
        }

        [HttpGet]
        public IHttpActionResult GetCDBs()
        {
            var cdbs = new string[] { "Hello", "World", "!" };

            //return Content(HttpStatusCode.Found, cdbs);

            return Ok(cdbs);
        }

        [HttpDelete()]
        public IHttpActionResult DeleteCDB()
        {
            return InternalServerError(
                new NotImplementedException(
                    string.Format(
                        CultureInfo.InvariantCulture,
                        MESSAGE_NOT_IMPLEMENTED_EXCEPTION,
                        "DELETE")));
        }

        [HttpPost()]
        public IHttpActionResult PostCDB([FromBody] QuoteCDB quoteCDB)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                else
                {
                    QuoteCDB result = this._quoteCDBRepository.Calculate(quoteCDB);

                    return Ok(
                        result);
                }
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPut]
        public IHttpActionResult PutCDB(int id, [FromBody] QuoteCDB quoteCDB)
        {
            return InternalServerError(
                new NotImplementedException(
                    string.Format(
                        CultureInfo.InvariantCulture,
                        MESSAGE_NOT_IMPLEMENTED_EXCEPTION,
                        "UPDATE")));
        }
    }
}