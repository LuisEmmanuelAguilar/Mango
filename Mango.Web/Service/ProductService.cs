using Mango.Web.Models;
using Mango.Web.Service.IService;
using Mango.Web.Utility;

namespace Mango.Web.Service
{
    public class ProductService : IProductService
    {
        private readonly IBaseService _baseService;
        public ProductService(IBaseService baseService)
        {
            _baseService = baseService;
        }

        public async Task<ResponseDto?> CreateProductAsync(ProductDto productDto)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = StandardDetails.ApiType.POST,
                Data = productDto,
                Url = StandardDetails.ProductAPIBase + "/api/product",
                ContentType = StandardDetails.ContentType.MultipartFormData
            });
        }

        public async Task<ResponseDto?> DeleteProductAsync(int id)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = StandardDetails.ApiType.DELETE,
                Url = StandardDetails.ProductAPIBase + "/api/product/" + id
            });
        }

        public async Task<ResponseDto?> GetAllProductsAsync()
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = StandardDetails.ApiType.GET,
                Url = StandardDetails.ProductAPIBase + "/api/product"
            });
        }

        public async Task<ResponseDto?> GetProductByIdAsync(int id)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = StandardDetails.ApiType.GET,
                Url = StandardDetails.ProductAPIBase + "/api/product/" + id
            });
        }

        public async Task<ResponseDto?> UpdateProductAsync(ProductDto productDto)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = StandardDetails.ApiType.PUT,
                Data = productDto,
                Url = StandardDetails.ProductAPIBase + "/api/product",
				ContentType = StandardDetails.ContentType.MultipartFormData
			});
        }
    }
}
