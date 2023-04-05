namespace MyLib;

public delegate void AnimalDelegate(List<IAnimal> animals);

public interface IAnimal
{
  public string IntroduceAnimal();
}

public class Animal : IAnimal
{
  public string name { get; set; } = string.Empty;
  public int yearOfDiscovery { get; set; }
  private protected string? move;
  private protected string? breath;
  private protected string? reproduce;

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
  public Mamal()
  {
    move = "Walk";
    breath = "Lungs";
    reproduce = "live birth";
  }
}

public class Bird : Animal
{
  public Bird()
  {
    move = "fly";
    breath = "Lungs";
    reproduce = "eggs";
  }

}

public class Fish : Animal
{
  public Fish()
  {
    move = "Swim";
    breath = "gills";
    reproduce = "eggs";
  }
}
