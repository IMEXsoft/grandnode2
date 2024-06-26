﻿using Grand.Infrastructure.Models;

namespace Grand.Web.Models.Catalog;

public class ProductTagModel : BaseEntityModel
{
    public string Name { get; set; }

    public string SeName { get; set; }

    public int ProductCount { get; set; }
}