//Service Configurations
//Includes the type of app, third party libraries , authentication and authorization and dependency injections

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
    app.Run();
}

#region Routing
//Routing means the ability ro respond to a HTTP Request

#endregion