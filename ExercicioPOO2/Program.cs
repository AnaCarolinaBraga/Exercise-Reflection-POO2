

using System.Reflection;

namespace ExercicioPOO2
{
    public class Program
    {
        static void Main()
        {
            CreateInstance();

        }

        public static void DisplayPublicProperties(Object obj)
        {
            foreach (var propertyInfo in obj.GetType().GetProperties())
            {
                var propertyName = propertyInfo.Name;
                var propertyValue = propertyInfo.GetValue(obj);
                Console.WriteLine($"{propertyName}={propertyValue}");
            }
        }

        public static void CreateInstance()
        {
            var types = Assembly.GetExecutingAssembly().GetTypes();
            foreach (var type in types)
            {
                if (type.IsAssignableTo(typeof(Student)) && type.IsClass && !type.IsAbstract)
                {
                    var instance = (Student)Activator.CreateInstance(type);
                    var name = instance.Name;
                    var university = instance.University;
                    var number = instance.RollNumber;

                    var operations = new Student(name, university, number);
                    DisplayPublicProperties(operations);
                }
            }


        }

    }
}