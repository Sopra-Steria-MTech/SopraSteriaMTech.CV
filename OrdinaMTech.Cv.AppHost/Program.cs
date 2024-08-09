var builder = DistributedApplication.CreateBuilder(args);

var sqldb = builder.AddSqlServer("sql").AddDatabase("sqldb");

var api = builder.AddProject<Projects.OrdinaMTech_Cv_WebApi>("api")
    .WithReference(sqldb);

builder.AddProject<Projects.OrdinaMTech_Cv_BlazorApp>("blazorapp")
    .WithExternalHttpEndpoints()
    .WithReference(api);

builder.Build().Run();
