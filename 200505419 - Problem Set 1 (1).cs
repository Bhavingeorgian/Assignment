string name = "Supercalifragilisticexpialidocious";
int nameLength = name.Length;
Console.WriteLine("The name " + name + " contains " + nameLength + "letters.");

Console.WriteLine(name.Contains("ice"));

string[] words = {"Supercalifragilisticexpialidocious", "Honorificabilitudinitatibus","Bababadalgharaghtakamminarronnkonn"};
string word = "";
int ctr = 0;
foreach (String s in words)
{
    if (s.Length > ctr)
    {
        word = s;
        ctr = s.Length;
     }
}
Console.WriteLine(word +" is the longest word which Contains "+ ctr+ " Letters wi");


using System;

class Program
  {
    static double triangleArea(int a, int b, int c)
    {
      float s = (a + b + c) / 2;
      return (double)Math.Sqrt(s * (s - a) * (s - b) * (s - c));
    }

    static void Main()
    {
      Program o = new Program();
      float f = o.triangleArea(2,2,2).GetDisciplines();
    }
  }

int[] arr = new int[] {25,47,42,56,32};
List<int> Even = new List<int>();
List<int> Odd = new List<int>();

for(i = 0; i < arr.Length; i++)  
    {  
        if (arr[i] % 2 == 0)
        {
            Even.Add(arr[i]);
        }
        else
        {
            Odd.Add(arr[i]);
        }
    }
Console.Write("The Even elements are: \n" );
for(int i=0;i<Even.Count;i++)
{
    Console.Write(Even[i]+" ");
}
Console.Write("\nThe Odd elements are: \n" );
for(int i=0;i<Odd.Count;i++)
{
    Console.Write(Odd[i]+" ");
}

using System;
public class Check
{
	static bool inside(int x, int y, int x1, int y1, int x2, int y2)
	{
		if (x > x1 && x < x2 && y > y1 && y < y2)
			return true;
		else
			return false;
	}	
		public static void Main()
		{
			int x = 1, y = 1, x1 = 0, y1 = 0, x2 = 2, y2 = 3;
			if (inside(x, y, x1, y1, x2, y2))
				Console.Write("Given point lies inside");
			else
				Console.Write("Given point lies outside");
		}
}

using System;
public class Check
{
	static bool inside(double x, double y, double x1, double y1, double x2, double y2)
	{
		if (x > x1 && x < x2 && y > y1 && y < y2)
			return true;
		else
			return false;
	}	
		public static void Main()
		{
			double x = 1, y = 1, x1 = 0.3, y1 = 0.5, x2 = 1.1, y2 = 0.7;
			if (inside(x, y, x1, y1, x2, y2))
				Console.Write("(1,1) Given point lies inside (0.3, 0.5 1.1, 0.7)\n");
			else
				Console.Write("(1,1) Given point lies outside (0.3, 0.5 1.1, 0.7)\n");
            
			if (inside(1, 1, 0.5, 0.2, 1.1, 2))
				Console.Write("(1,1) Given point lies inside (0.5, 0.2, 1.1, 2)");
			else
				Console.Write("(1,1) Given point lies outside (0.5, 0.2, 1.1, 2)");
		}
}


