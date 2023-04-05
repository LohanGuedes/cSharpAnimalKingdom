namespace MyLib;

public class Animal
{
  public string? name { get; set; }
  public int yearOfDiscovery { get; set; }
  private protected static string? move;
  private protected static string? breath;
  private protected static string? reproduce;

  public string IntroduceAnimal()
  {
    return ("Animal " + name + ", Year discovered: " + yearOfDiscovery);
  }

  public string MoveType()
  {
    return ("Move: " + move);
  }

  public string BreathType()
  {
    return ("Breathe: " + breath);
  }

  public string ReproduceType()
  {
    return ("Reproduces: " + reproduce);
  }

}

public class Mamal : Animal
{
  static Mamal()
  {
    move = "Walk";
    breath = "Lungs";
    reproduce = "live birth";
  }
}

public class Bird : Animal
{
  static Bird()
  {
    move = "fly";
    breath = "Lungs";
    reproduce = "eggs";
  }

}

public class Fish : Animal
{
  static Fish()
  {
    move = "Swim";
    breath = "gills";
    reproduce = "eggs";
  }
}
