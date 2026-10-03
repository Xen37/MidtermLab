using System;

public struct Student{
	public string StudentNumber;
	public string Name;
	public string program;
	public int YearLevel;
	}

class Program{
	static void Main(){
		Dictionary<string, Student> dict = new Dictionary<string, Student>();
		int choose;
		string num;
		
		do{
			Console.WriteLine("--");
			Console.WriteLine("student lokup using dictionary");
			Console.WriteLine();
			Console.WriteLine("1 for Add Student");
			Console.WriteLine("2 for Search student");
			Console.WriteLine("3 for display All student");
			Console.WriteLine("4 for exit");
			Console.WriteLine();
			Console.Write("enter Choice: ");
			choose = Convert.ToInt32(Console.ReadLine());
			
			switch(choose){
				case 1:
					
					Student student = new Student();
					Console.WriteLine();
					Console.Write("enter the strudent number: ");
					num = Console.ReadLine();
					
					if(dict.ContainsKey(num)){
						Console.WriteLine();
						Console.WriteLine("there is already an existing student!\n");
					}
					else{
						Console.Write("enter the strudent Name: ");
						student.Name = Console.ReadLine();
						Console.Write("enter the strudent Program: ");
						student.program = Console.ReadLine();
						Console.Write("enter the strudent YearLevel: ");
						student.YearLevel = Convert.ToInt32(Console.ReadLine());
						
						student.StudentNumber = num;
						dict.Add(num, student);
					}
					break;
				case 2:
					Console.WriteLine();
					Console.Write("enter student number to Search: ");
					string search = Console.ReadLine();
					if(dict.ContainsKey(search)){
						Student stud = dict[search];
						Console.WriteLine("student found!");
						Console.WriteLine();
						Console.WriteLine($"student number: {stud.StudentNumber}");
						Console.WriteLine($"student Name: {stud.Name}");
						Console.WriteLine($"student progran: {stud.program}");
						Console.WriteLine($"student yearlevel: {stud.YearLevel}");
						}
						else{
							Console.WriteLine("students do not exist in the database!!");
							}
					break;
				case 3:
					foreach (var kvp in dict){
						Console.WriteLine();
						Console.WriteLine("All students records\n");
						Console.WriteLine($"Student Number: {kvp.Key}");
						Console.WriteLine($"student Name {kvp.Value.Name}");
						Console.WriteLine($"student program {kvp.Value.program}");
						Console.WriteLine($"student yearLevel {kvp.Value.YearLevel}");
						}
					break;
				}
		}while(choose != 4);
	}
}
