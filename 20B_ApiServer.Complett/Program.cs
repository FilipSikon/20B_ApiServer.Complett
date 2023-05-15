WebApplication app = WebApplication.Create();

app.Urls.Add("http://localhost:3000");
app.Urls.Add("http://*:3000");

Superhero hero = new Superhero("Superman", 9001, true);

app.MapGet("/", Answer);

app.MapGet("/superhero/", () =>
{
  return hero;
});

app.Run();


static string Answer()
{
  return "<h4>Se här</h4>";
}

public class Superhero
{
  public Superhero(string name, int power, bool underwearOnTheOutside)
  {
    Name = name;
    Power = power;
    UnderwearOnTheOutside = underwearOnTheOutside;
  }

  public string Name { get; set; }
  public int Power { get; set; }
  public bool UnderwearOnTheOutside { get; set; }
}