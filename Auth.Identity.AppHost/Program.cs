var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.Auth_Identity_Domain>("auth-identity-domain");

builder.Build().Run();
