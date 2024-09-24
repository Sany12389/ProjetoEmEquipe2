using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine($"Seu escolher para o almoço: ");
		Console.WriteLine(Console.ReadLine());
		string[] restaurantes =
		{
			"Cozinha Italiana",
			"Comida Mexicana",
			"Restaurante Vegetariano",
			"Churrascaria",
			"Comida Sushi",
			"Comida Chinesa",
			"Fast Food",
			"Pizza"
		};
		Random random = new Random();
	}
}