﻿using Grand.Infrastructure.Models;

namespace Grand.Web.Models.Catalog;

public class ProductSpecificationModel : BaseModel
{
    public string SpecificationAttributeId { get; set; }

    public string SpecificationAttributeName { get; set; }

    //this value is already HTML encoded
    public string ValueRaw { get; set; }
    public string ColorSquaresRgb { get; set; }
}