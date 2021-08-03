using System.Text;

namespace ArrayStringBuilderClass
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Homework

            //string text = "Salam P318 Qrupu";
            //string result = ReverseSentence(text);
            //Console.WriteLine(result);

            #endregion

            #region Array

            //string text = "Abcdef";
            //Console.WriteLine(text.Contains("de"));

            //int[] arr = { 1, -1, 7, 4, 9 };

            //foreach (int item in arr)
            //{
            //    Console.Write($"{item} ");
            //}

            //Array.Reverse(arr);
            //Array.Sort(arr);
            //Array.Reverse(arr);

            //Array.Resize(ref arr, arr.Length + 1);

            //arr[arr.Length - 1] = 10;

            //Console.WriteLine();

            //foreach (int item in arr)
            //{
            //    Console.Write($"{item} ");
            //}

            //int[] arr = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int[] arr = new int[10];

            //foreach (int item in arr)
            //{
            //    Console.Write($"{item} ");
            //}

            //string[] arr = { "Elnur", "Rail", "Ozal", "Vuqar", "Sarkhan" };

            //Array.Resize(ref arr, arr.Length + 1);

            //foreach (string item in arr)
            //{
            //    Console.Write($"{item} ");
            //}

            //string result = string.Join(",", arr);
            //Console.WriteLine(result);

            //string[] arr1 = result.Split(",");

            //foreach (string item in arr1)
            //{
            //    Console.Write($"{item} ");
            //}

            #endregion

            #region String builder

            //string text = "abc";
            //text[0] = "b";

            //text = "bbc";

            //string name = "KAmran";

            //if (name.ToUpper() == "kamran".ToUpper())
            //{
            //    Console.WriteLine("Hello");
            //}

            //StringBuilder stringBuilder = new StringBuilder();
            //stringBuilder.Append("Kamran");
            //stringBuilder.Clear();
            //stringBuilder.Append(" Nabiyev");

            //stringBuilder.Replace("a", "A");

            //stringBuilder.Replace("Kamran", "Sarkhan");

            //stringBuilder.Insert(2, "5 ");

            //stringBuilder.AppendLine();
            //stringBuilder.AppendLine("Nabiyev");

            //Console.WriteLine(stringBuilder);

            #endregion

            #region Class

            //string name = "Rail";
            //string surname = "Jannatov";
            //int age = 23;

            //string name2 = "Fagan";
            //string surname2 = "Eyvazov";
            //int age2 = 24;

            #region Anonymious object

            //var rail = new
            //{
            //    Name = "Rail",
            //    Surname = "Jannatov",
            //    Age = 24
            //};

            //var fagan = new
            //{
            //    Name = "Fagan",
            //    Surname = "Eyvazov",
            //    Age = 23
            //};

            //Console.WriteLine($"{rail.Name} {rail.Surname} {rail.Age}");
            //Console.WriteLine($"{fagan.Name} {fagan.Surname} {fagan.Age}");

            #endregion

            #region My class

            Student rail = new Student
            {
                Name = "Rail",
                Surname = "Jannatov",
                Age = 24
            };
            //rail.PrintFullName();

            Student fagan = new Student
            {
                Name = "Fagan",
                Surname = "Eyvazov",
                Age = 23
            };
            //fagan.PrintFullName();
            //Console.WriteLine(fagan.GetFullName());

            Student ulvi = new Student();
            ulvi.Name = "Ulvi";
            ulvi.Surname = "Ismayilov";
            ulvi.Age = 30;
            //ulvi.PrintFullName();

            Student[] students = { rail, fagan, ulvi };

            foreach (Student student in students)
            {
                student.PrintFullName();
            }

            #endregion

            #endregion
        }

        #region Homework

        static string ReverseSentence(string text)
        {
            StringBuilder result = new StringBuilder();
            //string result = "";
            string[] words = text.Split(" ");

            foreach (string word in words)
            {
                for (int i = word.Length - 1; i >= 0; i--)
                {
                    result.Append(word[i]);
                    //result += word[i];
                }

                result.Append(" ");
                //result += " ";
            }

            return result.ToString().TrimEnd();
        }

        #endregion
    }
}
