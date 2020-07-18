using bumShopSolution.Data.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace bumShopSolution.Data.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public int SortOrder { get; set; }
        public bool IsShowOnHome { get; set; }
        public int? ParentId { get; set; }
        public Status status { get; set; }
        public List<ProductInCategory> productInCategories { get; set; }
        public List<CategoryTranslation> CategoryTranslations { get; set; }
    }
}
