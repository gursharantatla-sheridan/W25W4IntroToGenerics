namespace GenericCollectionExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee(101, "John", 5000);
            Employee emp2 = new Employee(102, "Anne", 7000);
            Employee emp3 = new Employee(103, "Mark", 3000);


            // List example
            List<Employee> employees = new List<Employee>();
            employees.Add(emp1);
            employees.Add(emp2);
            employees.Add(emp3);

            employees.Insert(1, emp3);
            employees.Remove(emp3);

            foreach (var e in employees)
                Console.WriteLine(e);

            Console.WriteLine("\n\n");
            


            // searching

            // IndexOf

            int index = employees.IndexOf(emp2);

            if (index >= 0)
                Console.WriteLine("Item exists");
            else
                Console.WriteLine("Item doesn't exist");


            // Contains

            if (employees.Contains(emp2))
                Console.WriteLine("Item exists");
            else
                Console.WriteLine("Item doesn't exist");


            // Exists

            if (employees.Exists(e => e.Name.StartsWith("A")))
                Console.WriteLine("Item exists");
            else
                Console.WriteLine("Item doesn't exist");



            // Find

            Employee? emp = employees.Find(e => e.Salary > 6000);

            if (emp != null)
                Console.WriteLine(emp);
            else
                Console.WriteLine("Item doesn't exist");



            // Dictionary example
            Dictionary<int, Employee> dictEmps = new Dictionary<int, Employee>();
            dictEmps.Add(emp1.Id, emp1);
            dictEmps.Add(emp2.Id, emp2);
            dictEmps.Add(emp3.Id, emp3);

            //Console.Write("\n\nEnter key: ");
            //int key = int.Parse(Console.ReadLine());

            //if (dictEmps.ContainsKey(key))
            //{
            //    emp = dictEmps[key];
            //    Console.WriteLine(emp);
            //}
            //else
            //    Console.WriteLine("Invalid key. Please try again");

            Console.WriteLine("\n\n");



            foreach (var kvp in dictEmps)
            {
                int k = kvp.Key;
                emp = kvp.Value;

                Console.WriteLine("Key = " + k);
                Console.WriteLine(emp);
            }


            Console.WriteLine("\n\n\n");




            // Stack example
            Stack<int> stack = new Stack<int>();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            stack.Push(40);

            //int num = stack[2];

            foreach (var i in stack)
                Console.WriteLine(i);

            int num = stack.Pop();

            Console.WriteLine("\nTotal items: " + stack.Count);
            Console.WriteLine("Num = " + num);

            num = stack.Peek();

            Console.WriteLine("\nTotal items: " + stack.Count);
            Console.WriteLine("Num = " + num);


            Console.WriteLine("\n\n\n");
            


            // Queue example
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            queue.Enqueue(40);

            //num = queue[2];

            foreach (var i in queue)
                Console.WriteLine(i);

            num = queue.Dequeue();

            Console.WriteLine("\nTotal items: " + queue.Count);
            Console.WriteLine("Num = " + num);

            num = queue.Peek();

            Console.WriteLine("\nTotal items: " + queue.Count);
            Console.WriteLine("Num = " + num);
        }
    }
}
