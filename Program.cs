namespace ZooControl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Любима храна на животното: ");
            string nameFood = Console.ReadLine();
            Food food = new Food($"{nameFood}");

            Console.WriteLine("Име на животното: ");
            string nameAnimal = Console.ReadLine();
            Animal animal = new Animal($"{nameAnimal}", food);

            Console.WriteLine("Местообитание: ");
            string habitatName = Console.ReadLine();
            Habitat habitat = new Habitat($"{habitatName}");

            Zoo zoo = new Zoo();

            Console.Write("Първо име на човека в зоопарка: ");
            string firstname = Console.ReadLine();
            Console.Write("Фамилия на човека в зоопарка: ");
            string lastname = Console.ReadLine();
            ZooKeeper zooKeeper = new ZooKeeper($"{firstname}", $"{lastname}");
            zooKeeper.FeedAnimal(animal);

        }
    }
}
