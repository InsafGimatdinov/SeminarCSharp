// 19. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0.

// Ввели х в консоль.
System.Console.WriteLine("Введите x");
int x = Convert.ToInt32(System.Console.ReadLine());

// Ввели у в консоль.
System.Console.WriteLine("Введите y");
int y = Convert.ToInt32(System.Console.ReadLine());

// Вывели х и у на экран.
System.Console.WriteLine($"x = {x}\ny = {y}");

// Задали условия проверки точек на принадлежность к какой либо четверти.
if (x > 0 & y > 0) System.Console.WriteLine("Точка в 1-ой четверти");

if (x < 0 & y > 0) System.Console.WriteLine("Точка в 2-ой четверти");

if (x < 0 & y < 0) System.Console.WriteLine("Точка в 3-ей четверти");

if (x > 0 & y < 0) System.Console.WriteLine("Точка в 4-ой четверти");

// Задали так же условие при котором задача теряет смысл, то есть не соответствует поставленной перед нами задаче.
if (x == 0 & y == 0) System.Console.WriteLine("По условию этого не может быть");