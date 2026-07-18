using System.Text.Json.Serialization;
using Counter.src.routes;

var builder = WebApplication.CreateSlimBuilder(args);
var app = builder.Build();

Routes.MapRoutes(app);

app.Run();