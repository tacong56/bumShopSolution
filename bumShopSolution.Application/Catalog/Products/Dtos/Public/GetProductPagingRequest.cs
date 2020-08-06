﻿using bumShopSolution.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace bumShopSolution.Application.Catalog.Products.Dtos.Public
{
    public class GetProductPagingRequest : PagingRequestBase
    {
        public int? CategoryId { get; set; }
        public string Keyword { get; set; }
    }
}
