using System;
struct StudentRequest{
	public string StudentNumber;
	public string StudentName;
	public string RequestType;
	}
class Program{
	static void Main(){
		Queue<StudentRequest> requestQueue = new Queue<StudentRequest>();
		int choice;
		do{
			Console.WriteLine();
			Console.WriteLine("----");
			Console.WriteLine("1. Add a Request");
			Console.WriteLine("2. View Pending Request");
			Console.WriteLine("3. Process Request");
			Console.WriteLine("4. Exit\n");
			
			Console.Write("Enter your choice: ");
			choice = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine();
			switch(choice){
				case 1:
					StudentRequest newrequest;
					Console.Write("Enter student number: ");
					newrequest.StudentNumber = Console.ReadLine();
					Console.Write("Enter student Name: ");
					newrequest.StudentName = Console.ReadLine();
					Console.Write("Enter requestype: ");
					newrequest.RequestType = Console.ReadLine();
					Console.WriteLine("Request added succesfully");
					
					requestQueue.Enqueue(newrequest);
					break;
				case 2:
					int position = 1;
					Console.WriteLine();
					if(requestQueue.Count > 0){
						foreach(StudentRequest student in requestQueue){
							
							Console.WriteLine($"{position}. {requestQueue.Peek().StudentName} - {requestQueue.Peek().RequestType}");
							position++;
						}
						
					}
					else{
							Console.WriteLine("no pending request");
							}
					break;
				case 3:
					if(requestQueue.Count > 0){
					Console.WriteLine($"processing Request: {requestQueue.Peek().StudentName} - {requestQueue.Peek().RequestType}");
					string s =requestQueue.Dequeue().StudentName;
					}
					else{
						Console.WriteLine("nothing to process");
						}
					break;
				}
			}while(choice != 4);
		}
	}
