﻿using Grand.Infrastructure.ModelBinding;
using Grand.Infrastructure.Models;

namespace Grand.Web.Admin.Models.Payments;

public class PaymentMethodModel : BaseModel
{
    [GrandResourceDisplayName("Admin.Configuration.Payment.Methods.Fields.FriendlyName")]

    public string FriendlyName { get; set; }

    [GrandResourceDisplayName("Admin.Configuration.Payment.Methods.Fields.SystemName")]

    public string SystemName { get; set; }

    [GrandResourceDisplayName("Admin.Configuration.Payment.Methods.Fields.DisplayOrder")]
    public int DisplayOrder { get; set; }

    [GrandResourceDisplayName("Admin.Configuration.Payment.Methods.Fields.IsActive")]
    public bool IsActive { get; set; }

    [GrandResourceDisplayName("Admin.Configuration.Payment.Methods.Fields.Logo")]
    public string LogoUrl { get; set; }

    [GrandResourceDisplayName("Admin.Configuration.Payment.Methods.Fields.SupportCapture")]
    public bool SupportCapture { get; set; }

    [GrandResourceDisplayName("Admin.Configuration.Payment.Methods.Fields.SupportPartiallyRefund")]
    public bool SupportPartiallyRefund { get; set; }

    [GrandResourceDisplayName("Admin.Configuration.Payment.Methods.Fields.SupportRefund")]
    public bool SupportRefund { get; set; }

    [GrandResourceDisplayName("Admin.Configuration.Payment.Methods.Fields.SupportVoid")]
    public bool SupportVoid { get; set; }

    [GrandResourceDisplayName("Admin.Configuration.Payment.Methods.Fields.Configure")]
    public string ConfigurationUrl { get; set; }
}