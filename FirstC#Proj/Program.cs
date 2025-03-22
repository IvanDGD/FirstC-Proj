using FirstC_Proj.GenericCollections;
using System;
using System.Collections.Generic;

namespace FirstC_Proj
{

    class Program
    {
        static T MaxOfThree<T>(T a, T b, T c) where T : IComparable<T>
        {
            return (a.CompareTo(b) > 0) ? ((a.CompareTo(c) > 0) ? a : c) : ((b.CompareTo(c) > 0) ? b : c);
        }
        static T MinOfThree<T>(T a, T b, T c) where T : IComparable<T>
        {
            return (a.CompareTo(b) < 0) ? ((a.CompareTo(c) < 0) ? a : c) : ((b.CompareTo(c) < 0) ? b : c);
        }

        static T SumArray<T>(T[] array) where T : struct
        {
            dynamic sum = default(T);
            foreach (T item in array)
            {
                sum += item;
            }
            return sum;
        }

        class MyStack<T>
        {
            private T[] items;
            private int top;

            public int Count => top + 1;

            public MyStack(int capacity = 10)
            {
                items = new T[capacity];
                top = -1;
            }

            public void Push(T item)
            {
                if (top == items.Length - 1)
                {
                    Console.WriteLine("Stack overflow");
                }

                items[++top] = item;
            }

            public T Pop()
            {
                if (top == -1)
                {
                    Console.WriteLine("Stack is empty");
                }

                return items[top--];
            }

            public T Peek()
            {
                if (top == -1)
                {
                    Console.WriteLine("Stack is empty");
                }
                return items[top];
            }
        }

        class MyQueue<T>
        {
            private T[] items;
            private int top;
            private int last;
            private int count;
            private int capacity;

            public int Count => count;

            public MyQueue(int capacity = 10)
            {
                this.capacity = capacity;
                items = new T[capacity];
                top = 0;
                last = -1;
                count = 0;
            }

            public void Enqueue(T item)
            {
                if (count == capacity)
                {
                    Console.WriteLine("Queue overflow");
                }

                last = (last + 1) % capacity;
                items[last] = item;
                count++;
            }

            public T Dequeue()
            {
                if (count == 0)
                {
                    Console.WriteLine("Queue is empty");
                }
                T item = items[top];
                top = (top + 1) % capacity;
                count--;
                return item;
            }

            public T Peek()
            {
                if (count == 0)
                {
                    Console.WriteLine("Queue is empty");
                }

                return items[top];
            }
        }
        public delegate bool Criteria<T>(T item);

        static IEnumerable<T> FilterByTwoCriteria<T>(IEnumerable<T> collection, Criteria<T> criteria1, Criteria<T> criteria2)
        {
            List<T> result = new List<T>();

            foreach (T item in collection)
            {
                if (criteria1(item) && criteria2(item))
                {
                    result.Add(item);
                }
            }

            return result;
        }
        static void Main()
        {
            #region Task1
            //Console.WriteLine("Max of (3, 7, 5): " + MaxOfThree(3, 7, 5));
            //Console.WriteLine("Max of (2.5, 1.8, 3.9): " + MaxOfThree(2.5, 1.8, 3.9));
            //Console.WriteLine("Max of ('a', 'z', 'm'): " + MaxOfThree('a', 'z', 'm'));
            #endregion
            #region Task2
            //Console.WriteLine("Max of (3, 7, 5): " + MinOfThree(3, 7, 5));
            //Console.WriteLine("Max of (2.5, 1.8, 3.9): " + MinOfThree(2.5, 1.8, 3.9));
            //Console.WriteLine("Max of ('a', 'z', 'm'): " + MinOfThree('a', 'z', 'm'));
            #endregion
            #region Task3
            //int[] intArray = { 1, 2, 3, 4, 5 };
            //double[] doubleArray = { 1.1, 2.2, 3.3, 4.4 };
            //float[] floatArray = { 10.5f, 20.5f, 30.5f };

            //Console.WriteLine("Sum of int array: " + SumArray(intArray));
            //Console.WriteLine("Sum of double array: " + SumArray(doubleArray));
            //Console.WriteLine("Sum of float array: " + SumArray(floatArray));
            #endregion
            #region Task4
            //MyStack<int> stack = new MyStack<int>(5);

            //stack.Push(10);
            //stack.Push(20);
            //stack.Push(30);

            //Console.WriteLine("Top element (Peek): " + stack.Peek());
            //Console.WriteLine("Popped element: " + stack.Pop());
            //Console.WriteLine("Stack count: " + stack.Count);
            #endregion
            #region Task5
            //MyQueue<int> queue = new MyQueue<int>(5);

            //queue.Enqueue(10);
            //queue.Enqueue(20);
            //queue.Enqueue(30);

            //Console.WriteLine("Top element (Peek): " + queue.Peek());
            //Console.WriteLine("Dequeued element: " + queue.Dequeue()); 
            //Console.WriteLine("Queue count: " + queue.Count);
            #endregion
            #region Task6
            //List<int> numbers = new List<int> { 5, 12, 18, 7, 24, 30, 3 };
            //IEnumerable<int> filteredNumbers = FilterByTwoCriteria<int>(numbers, x => x > 10, x => x % 2 == 0);

            //Console.Write("Filtered numbers: ");
            //foreach (int number in filteredNumbers)
            //{
            //    Console.Write(number + " ");
            //}
            //Console.WriteLine();

            //List<string> words = new List<string> { "apple", "dog", "banana", "car", "ant", "table" };
            //IEnumerable<string> filteredWords = FilterByTwoCriteria<string>(words, s => s.Length > 3, s => s.Contains('a'));

            //Console.Write("Filtered words: ");
            //foreach (string word in filteredWords)
            //{
            //    Console.Write(word + " ");
            //}
            //Console.WriteLine();
            #endregion
            #region Task7
            //ABC alphabet = new ABC();

            //Console.WriteLine("Letters in the English alphabet:");
            //foreach (char letter in alphabet)
            //{
            //    Console.Write(letter + " ");
            //}
            //Console.WriteLine();
            #endregion
            #region Task8
            //House house = new House();

            //Apartment apartment1 = new Apartment("1A");
            //apartment1.AddResident("Alice");
            //apartment1.AddResident("Bob");

            //Apartment apartment2 = new Apartment("2B");
            //apartment2.AddResident("Charlie");
            //apartment2.AddResident("David");

            //house.AddApartment(apartment1);
            //house.AddApartment(apartment2);

            //Console.WriteLine("Apartments in the house:");
            //foreach (Apartment apartment in house)
            //{
            //    Console.WriteLine($"Apartment {apartment.Number}:");
            //    foreach (string resident in apartment)
            //    {
            //        Console.WriteLine($" - Resident: {resident}");
            //    }
            //}
            #endregion
            #region Task9
            //Garage garage = new Garage();
            //garage.AddCar(new GenericCollections.Car("Toyota", "Red"));
            //garage.AddCar(new GenericCollections.Car("Honda", "Blue"));
            //garage.AddCar(new GenericCollections.Car("Ford", "Green"));

            //foreach (GenericCollections.Car car in garage)
            //{
            //    Console.WriteLine($"Car Model: {car.Model}, Color: {car.Color}");
            //}
            #endregion
            #region Task10
            //Library<GenericCollections.Book> library = new Library<GenericCollections.Book>();

            //library.AddBook(new GenericCollections.Book("The Great Gatsby", "F. Scott Fitzgerald", 1925, "Novel"));
            //library.AddBook(new GenericCollections.Book("1984", "George Orwell", 1949, "Dystopian"));
            //library.AddBook(new GenericCollections.Book("The Catcher in the Rye", "J.D. Salinger", 1951, "Novel"));
            //library.AddBook(new GenericCollections.Book("To Kill a Mockingbird", "Harper Lee", 1960, "Novel"));

            //Console.WriteLine("All Books in the Library:");
            //foreach (GenericCollections.Book book in library)
            //{
            //    Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Year: {book.PublicationYear}, Genre: {book.Genre}");
            //}

            //Console.WriteLine("\nSearching for 'Novel' genre:");
            //foreach (GenericCollections.Book book in library.SearchByGenre("Novel"))
            //{
            //    Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Year: {book.PublicationYear}, Genre: {book.Genre}");
            //}

            //Console.WriteLine("\nSearching for books published in 1949:");
            //foreach (GenericCollections.Book book in library.SearchByPublicationYear(1949))
            //{
            //    Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Year: {book.PublicationYear}, Genre: {book.Genre}");
            //}
            #endregion
            #region Task11
            //EmployeeManager employeeManagement = new EmployeeManager();

            //employeeManagement.AddEmployee(new GenericCollections.Employee("John Doe", "Software Engineer", 60000, "john.doe@example.com"));
            //employeeManagement.AddEmployee(new GenericCollections.Employee("Jane Smith", "Project Manager", 80000, "jane.smith@example.com"));
            //employeeManagement.AddEmployee(new GenericCollections.Employee("Emily Davis", "Designer", 55000, "emily.davis@example.com"));

            //Console.WriteLine("Employees after addition:");
            //employeeManagement.DisplayEmployees();

            //employeeManagement.UpdateEmployee("john.doe@example.com", new GenericCollections.Employee("John Doe", "Senior Software Engineer", 70000, "john.doe@example.com"));

            //Console.WriteLine("\nSearching for employees with 'Engineer':");
            //var searchResults = employeeManagement.SearchEmployees("Engineer");
            //foreach (var employee in searchResults)
            //{
            //    Console.WriteLine(employee);
            //}

            //Console.WriteLine("\nEmployees sorted by salary:");
            //var sortedBySalary = employeeManagement.SortEmployeesBySalary();
            //foreach (var employee in sortedBySalary)
            //{
            //    Console.WriteLine(employee);
            //}

            //Console.WriteLine("\nEmployees sorted by name:");
            //var sortedByName = employeeManagement.SortEmployeesByName();
            //foreach (var employee in sortedByName)
            //{
            //    Console.WriteLine(employee);
            //}

            //employeeManagement.RemoveEmployee("jane.smith@example.com");

            //Console.WriteLine("\nEmployees after removal:");
            //employeeManagement.DisplayEmployees();
            #endregion
            #region Task12

            #endregion
            #region Task13

            #endregion
            #region Task14

            #endregion
        }
    }
}