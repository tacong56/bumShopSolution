using bumShopSolution.Application.Catalog.Products.Dtos.Public;
using bumShopSolution.Application.Catalog.Products.Dtos;
using bumShopSolution.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace bumShopSolution.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        PagedResult<ProductViewModel> GetAllByCategoryId(GetProductPagingRequest request);
    }
}
