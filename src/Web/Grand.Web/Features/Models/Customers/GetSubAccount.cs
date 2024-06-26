﻿using Grand.Domain.Customers;
using Grand.Web.Models.Customer;
using MediatR;

namespace Grand.Web.Features.Models.Customers;

public class GetSubAccount : IRequest<SubAccountEditModel>
{
    public Customer CurrentCustomer { get; set; }
    public string CustomerId { get; set; }
}