var builder = DistributedApplication.CreateBuilder(args);

var sqldb = builder.AddSqlServer("sql")
    //// Mount the init scripts directory into the container.
    //.WithBindMount("./sqlserverconfig", "/usr/config")    
    //// Mount the SQL scripts directory into the container so that the init scripts run.
    //.WithBindMount("./data", "/docker-entrypoint-initdb.d")    
    //// Run the custom entrypoint script on startup.
    //.WithEntrypoint("/usr/config/entrypoint.sh")
    //// Add the database to the application model so that it can be referenced by other resources.
    .AddDatabase("sqldb");

var api = builder.AddProject<Projects.OrdinaMTech_Cv_WebApi>("api")
    .WithReference(sqldb);

builder.AddProject<Projects.OrdinaMTech_Cv_BlazorApp>("blazorapp")
    .WithExternalHttpEndpoints()
    .WithReference(api);

builder.Build().Run();
