
namespace Counter.src.routes;

public class Routes
{
    public static void MapRoutes(WebApplication app)
    {
        var todosApi = app.MapGroup("/todos");
        app.MapGet("/", () => Results.Redirect("/todos"));
        todosApi.MapGet("/", () => "Hello World!");
    }
}