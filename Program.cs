using System.Text;
using AsciiArtSvc;
using Figgle.Fonts;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGet("/{text}", AsciiArt.Write);



app.Run();

