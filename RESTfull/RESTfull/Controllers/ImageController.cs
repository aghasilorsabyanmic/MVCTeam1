using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Http;

namespace RESTfull.Controllers
{
    public class ImageController : ApiController
    {
        public HttpResponseMessage Picture()
        {
            var response = new HttpResponseMessage();
            //response.Content = new ByteArrayContent(pictureBytes);
            response.Content.Headers.ContentType = new MediaTypeHeaderValue("image/jpeg");

            return response;
        }
    }
}
