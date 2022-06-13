using Asp.Versioning;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMvc();
builder.Services.AddApiVersioning(
        o =>
        {
            o.DefaultApiVersion = new ApiVersion(1, 0);
            o.AssumeDefaultVersionWhenUnspecified = false;
            o.RouteConstraintName = "apiVersion";
            o.ApiVersionReader = new UrlSegmentApiVersionReader();
            o.ReportApiVersions = true;
        })
    .AddMvc();

var app = builder.Build();
app.MapControllers();
app.Run();
