var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.ThiqPay_Host>("thiqpay-host");

builder.Build().Run();
