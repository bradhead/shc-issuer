namespace ShcIssuer.Models.Multipart
{
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Mvc;

    public class MultipartResult : List<MultipartEntry>, IActionResult
    {
        private readonly MultipartContent content;

        public MultipartResult(string subtype = "byteranges", string boundary = null)
        {
            if (boundary == null)
            {
                this.content = new MultipartContent(subtype);
            }
            else
            {
                this.content = new MultipartContent(subtype, boundary);
            }
        }

        public async Task ExecuteResultAsync(ActionContext context)
        {
            foreach (var item in this)
            {
                if (item.Stream != null)
                {
                    var content = new StreamContent(item.Stream);

                    if (item.ContentType != null)
                    {
                        content.Headers.ContentType = new MediaTypeHeaderValue(item.ContentType);
                    }

                    if (item.FileName != null)
                    {
                        content.Headers.ContentDisposition = new ContentDispositionHeaderValue("attachment");
                        content.Headers.ContentDisposition.FileName = item.FileName;
                        //content.Headers.ContentDisposition.FileNameStar = contentDisposition.FileNameStar;
                    }

                    this.content.Add(content);
                }
            }

            context.HttpContext.Response.ContentLength = content.Headers.ContentLength;
            context.HttpContext.Response.ContentType = content.Headers.ContentType.ToString();

            await content.CopyToAsync(context.HttpContext.Response.Body);
        }
    }
}