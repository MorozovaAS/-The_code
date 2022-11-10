System.Console.WriteLine("Введите массив через запятую: ");
string words = Console.ReadLine();
string[] existArr = words.Split(", ");
string[] resultArr = existArr.Where(words=>words.Length < 4).ToArray();
System.Console.WriteLine(String.Join(", ", resultArr));