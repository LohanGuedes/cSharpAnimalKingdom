using MyLib;

Mamal myMamal = new Mamal();

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
  Mamal obj = new Mamal();
  obj.name = (string)mamal["name"];
  obj.yearOfDiscovery = (int)mamal["year"];
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

foreach (Animal obj in animalsList)
  Console.WriteLine(obj.IntroduceAnimal());