namespace LinkedList_LinkedNodeListCollections
{
    public class Example
    {
        public static void Main()
        {
            // Create the linked list.
            string[] tasks =
                { "Dishes", "Laundry", "Dusting", "Vacuuming", "Cooking", "Organizing" };
            LinkedList<string> taskList = new(tasks);
            Console.WriteLine("Original task list");
            foreach (string task in taskList)
            {
                Console.WriteLine(task);
            }
            Console.WriteLine();

            _ = taskList.AddLast("Homework");
            _ = taskList.AddFirst("Errands");

            //Retrieving the node associated with Dusting
            LinkedListNode<string> targetLocation = taskList.Find("Dusting");
            //Using the Next property of LinkedListNode < T > to display the value of the next task in the list
            Console.WriteLine("The current task in the list after Dusting is {0}", targetLocation.Next.Value);
            Console.WriteLine();
            _ = taskList.AddAfter(targetLocation, "Budget");
            _ = taskList.AddBefore(targetLocation, "Exercise");
            Console.WriteLine("List with additions");
            foreach (string task in taskList)
            {
                Console.WriteLine(task);
            }
            Console.WriteLine();
            taskList.RemoveFirst();
            taskList.RemoveLast();
            Console.WriteLine("List after deletions");
            foreach (string task in taskList)
            {
                Console.WriteLine(task);
            }
            Console.WriteLine();

            // Create an array with the same number of
            // elements as the linked list.
            string[] taskArray = new string[taskList.Count];
            taskList.CopyTo(taskArray, 0);
            Console.WriteLine("taskList is now taskArray");
            foreach (string t in taskArray)
            {
                Console.WriteLine(t);
            }

            // Release all the nodes.
            taskList.Clear();


        }

    }
}
