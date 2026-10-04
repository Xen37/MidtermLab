using System;
struct Operation{
	public string Action;
	public string StudentNumber;
	public string StudentName;
	}
class Program{
	static void Main(){
		Operation student = new Operation();
		Stack<Operation> operationHistory = new Stack<Operation>();
		int Choice;
		int num = 1;
		
		student.Action = "added";
		student.StudentName = "zyrus";
		operationHistory.Push(student);
		
		student.Action = "added";
		student.StudentName = "badajos";
		operationHistory.Push(student);
		
		student.Action = "updated";
		student.StudentName = "juan";
		operationHistory.Push(student);
		
		student.Action = "remove";
		student.StudentName = "junmar";
		operationHistory.Push(student);

		do{
			Console.WriteLine();
			Console.WriteLine("1. View Operatin History");
			Console.WriteLine("2. View Last Operation");
			Console.WriteLine("3. Remove Last Operation");
			Console.WriteLine("4. Exit");
			Console.WriteLine();
			Console.Write("enter Choice: ");
			Choice = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine();
			
			switch(Choice){
				case 1:
					num = 1;
					if(operationHistory.Count > 0){
					Console.WriteLine("Operation History");
					Console.WriteLine();
						foreach(Operation stud in operationHistory){
						Console.WriteLine($"{num}.{stud.Action} {stud.StudentName}");
						num++;
						}
					}
					else{
						Console.WriteLine("empty");
						}
					break;
				case 2:
					
					if(operationHistory.Count > 0){
						Operation peek = operationHistory.Peek();
						Console.WriteLine($"Last operation: {peek.Action}, {peek.StudentName}");
					}
					else{
						Console.WriteLine("Can't peek, there is no operation histoy");
						}
					break;
				case 3:
					
					if(operationHistory.Count > 0){
						Operation pop = operationHistory.Pop();
						Console.WriteLine("last operation removed!");
					}
					else{
						Console.WriteLine("the Operation History is Empty");
						}
					break;
				}
			
		}while(Choice != 4);
	}
}
