﻿using EasyAbp.PaymentService.EntityFrameworkCore;
using Volo.Abp.Modularity;

/* Domain tests are configured to use the EF Core provider.
     * You can switch to MongoDB, however your domain tests should be
     * database independent anyway.
     */
namespace EasyAbp.PaymentService;

[DependsOn(
    typeof(PaymentServiceEntityFrameworkCoreTestModule)
)]
public class PaymentServiceDomainTestModule : AbpModule
{
}