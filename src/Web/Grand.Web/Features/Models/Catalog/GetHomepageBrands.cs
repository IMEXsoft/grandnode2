﻿using Grand.Domain.Customers;
using Grand.Domain.Localization;
using Grand.Domain.Stores;
using Grand.Web.Models.Catalog;
using MediatR;

namespace Grand.Web.Features.Models.Catalog;

public class GetHomepageBrands : IRequest<IList<BrandModel>>
{
    public Customer Customer { get; set; }
    public Store Store { get; set; }
    public Language Language { get; set; }
}