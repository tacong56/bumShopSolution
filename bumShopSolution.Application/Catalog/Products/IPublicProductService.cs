using bumShopSolution.Application.Catalog.Products.Dtos;
using System.Threading.Tasks;
using bumShopSolution.ViewModels.Common;
using bumShopSolution.ViewModels.Catalog.Products;
using System.Collections.Generic;

namespace bumShopSolution.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        Task<PagedResult<ProductViewModel>> GetAllByCategoryId(GetPublicProductPagingRequest request, string languageId);
    }
}
