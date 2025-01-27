//Service Configurations
//Includes the type of app, third party libraries , authentication and authorization and dependency injections

using MinimalAPIs;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.AddControllers();
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();
}
//Service Activations
//Typically includes the Middleware pipeline
{
    var app = builder.Build();
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }
    app.UseHttpsRedirection();
    app.UseAuthorization();

    app.MapGet("/", () => "Homeuser");
    app.MapGroup("/countries").GroupCountries();
    app.Run();
}

#region Routing
/*


Routing means the ability ro respond to a HTTP Request

    Table 4-1. HTTP verbs and their associated methods
    HTTP verb       Method
    GET             MapGet
    POST            MapPost
    PATCH           MapPatch
    PUT             MapPut
    DELETE          MapDelete
    Other verbs     No method

app.MapPost("/yourRouteName", () => >> Do action << );  

you can use the MapMethods method, which can take several verbs in parameters for the same route. 

app.MapMethods("/routeName", new List<string> { "OPTIONS", "HEAD", "TRACE" }, () => {  Do action });



app.MapGet("/provinces/{provinceId:int}", (int provinceId) => $"ProvinceId {provinceId}");

The route matches, and the verb is correct but fails bind parameters.         400 Bad Request
The route matches, but the verb is not correct.                               405 Not Allowed
The route does not exist, whatever the verb.                                  404 
The route matches, the verb is correct, and parameter binding is working.     2XX Success  



for making RoutingGroups , generate a static class with an extensionmethod in it

lets call it mygroups

 */




#endregion