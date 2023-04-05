using MyLib;

static void PrintAnimals(List<IAnimal> animals)
{
  foreach (IAnimal animal in animals)
  {
    Console.WriteLine(animal.IntroduceAnimal());
  }
}
AnimalDelegate printer = PrintAnimals;

var mamalsList = new List<Dictionary<string, object>>
{
    new Dictionary<string, object> { ["name"] = "Panda", ["year"] = 1869 },
    new Dictionary<string, object> { ["name"] = "Zebra", ["year"] = 1778 },
    new Dictionary<string, object> { ["name"] = "Koala", ["year"] = 1816 },
    new Dictionary<string, object> { ["name"] = "Sloth", ["year"] = 1804 },
    new Dictionary<string, object> { ["name"] = "Armadillo", ["year"] = 1758 },
    new Dictionary<string, object> { ["name"] = "Raccoon", ["year"] = 1758 },
    new Dictionary<string, object> { ["name"] = "BigFoot", ["year"] = 2021 }
};

var birdsList = new List<Dictionary<string, object>>
{
    new Dictionary<string, object> { ["name"] = "Pigeon", ["year"] = 1837 },
    new Dictionary<string, object> { ["name"] = "Peacock", ["year"] = 1821 },
    new Dictionary<string, object> { ["name"] = "Toucan", ["year"] = 1758 },
    new Dictionary<string, object> { ["name"] = "Parrot", ["year"] = 1824 },
    new Dictionary<string, object> { ["name"] = "Swan", ["year"] = 1758 }
};

var fishesList = new List<Dictionary<string, object>>
{
    new Dictionary<string, object> { ["name"] = "Salmon", ["year"] = 1758 },
    new Dictionary<string, object> { ["name"] = "Catfish", ["year"] = 1817 },
    new Dictionary<string, object> { ["name"] = "Perch", ["year"] = 1758 }
};

List<Animal> animalsList = new List<Animal>();
foreach (Dictionary<string, object> mamal in mamalsList)
{
  // One way of doing it. -> Properties 
  Mamal obj = new Mamal
  {
    name = (string)mamal["name"],
    yearOfDiscovery = (int)mamal["year"]
  };
  animalsList.Add(obj);
}
foreach (Dictionary<string, object> bird in birdsList)
{
  Bird obj = new Bird();
  obj.name = (string)bird["name"];
  obj.yearOfDiscovery = (int)bird["year"];
  animalsList.Add(obj);
}
foreach (Dictionary<string, object> fish in fishesList)
{
  Fish obj = new Fish();
  obj.name = (string)fish["name"];
  obj.yearOfDiscovery = (int)fish["year"];
  animalsList.Add(obj);
}

Console.WriteLine("=======================Print ALL animals=======================");
PrintAnimals(animalsList.ToList<IAnimal>());

Console.WriteLine("\n\n\n================Print by year================");
var yearSorted = from a in animalsList
                 orderby a.yearOfDiscovery ascending
                 select a;
PrintAnimals(yearSorted.ToList<IAnimal>());

Console.WriteLine("\n\n\n\n==============Print in alphabetical order=============");

var alphaSorted = from a in animalsList
                  orderby a.name ascending
                  select a;

PrintAnimals(alphaSorted.ToList<IAnimal>());

Console.WriteLine("\n\n\n\n==============Print Lungh Breathers=============");
// LINQ Method syntax https://www.tutorialsteacher.com/linq/linq-method-syntax
var lungBreathers = animalsList
.Where(animal => animal.BreathType().Contains("Lungs"))
.ToList<Animal>();

PrintAnimals(lungBreathers.ToList<IAnimal>());

Console.WriteLine("\n\n\n\n==============Print Lungh Breathers and Egg reproducers=============");
// LINQ Query syntax https://www.tutorialsteacher.com/linq/linq-query-syntax
var layEggsNLungs = from animal in animalsList
                    where animal.BreathType().Contains("Lungs") && animal.ReproduceType().Contains("eggs")
                    select animal;

PrintAnimals(layEggsNLungs.ToList<IAnimal>());

Console.WriteLine("\n\n\n\n==============Print Lungh Breathers Named in 1758=============");
var lunghBreathersNamedIn1758 = from a in animalsList
                                where a.BreathType().Contains("Lungs") && a.yearOfDiscovery == 1758
                                select a;

PrintAnimals(lunghBreathersNamedIn1758.ToList<IAnimal>());

Console.WriteLine("\n\n\n\n==============Print Lungh Breathers Named in 1758=============");
var alphabeticalMamals = from a in animalsList
                         orderby a.name ascending
                         where a is Mamal
                         select a;

PrintAnimals(alphabeticalMamals.ToList<IAnimal>());


