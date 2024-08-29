using Microsoft.Identity.Client.Extensibility;

namespace Mango.Services.ProductAPI.Models.Response
{
    public class ResponseDto
    {
        public object? Result { get; set; }
        public bool IsSuccess { get; set; } = true;
        public string Message { get; set; } = "";
    }
}
