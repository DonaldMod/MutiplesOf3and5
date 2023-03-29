using Doanld_SEESA_Techinal_Test_1;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

FizzBuzzMultiples Multiples = new FizzBuzzMultiples();

app.MapGet("/", () => Multiples.FizzBuzz());

app.Run();
