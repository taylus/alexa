using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;

namespace HelloAlexa.Controllers
{
    public class AlexaController : ApiController
    {
        /// <summary>
        /// Returns a sample JSON response for Amazon Alexa.
        /// </summary>
        /// <param name="request">The JSON request from Alexa.</param>
        /// <see>https://developer.amazon.com/public/solutions/alexa/alexa-skills-kit/docs/alexa-skills-kit-interface-reference#request-format</see>
        /// <see>https://developer.amazon.com/public/solutions/alexa/alexa-skills-kit/docs/alexa-skills-kit-interface-reference#response-format</see>
        [HttpPost, Route("api/alexa/hello")]
        public dynamic Hello(dynamic request)
        {
            return new
            {
                version = "1.0",
                response = new
                {
                    outputSpeech = new
                    {
                        type = "PlainText",
                        text = "Hello, world!"
                    },
                    card = new
                    {
                        type = "Simple",
                        title = "Hello World",
                        content = "Hello, world!"
                    },
                    shouldEndSession = true
                }
            };
        }

        /// <summary>
        /// Default action and web root.
        /// </summary>
        [HttpGet, Route("")]
        public HttpResponseMessage Default()
        {
            var response = new HttpResponseMessage(HttpStatusCode.OK);
            response.Content = new StringContent("Hello world! Send a POST request to api/alexa/hello.", Encoding.UTF8, "text/plain");
            return response;
        }
    }
}
