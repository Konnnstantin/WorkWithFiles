{
    DirectoryInfo directory = new DirectoryInfo(@"C:\Users\user\Desktop\Test\Students");
    if (!directory.Exists)
    {
        directory.Create();
    }
    string Student = @"C:\Users\user\Desktop\Test\Students\Students.dat";
    string GroupA = @"C:\Users\user\Desktop\Test\Students\GroupA.txt";
    string GroupB = @"C:\Users\user\Desktop\Test\Students\GroupB.txt";

    Student[] people1 =
    {
     new Student("Дмитрий", 20),
     new Student("Владимир", 21),
     new Student("Анастатсия",18)
     };
    using (BinaryWriter writer = new BinaryWriter(File.Open(Student, FileMode.Open)))
    {
        foreach (Student person in people1)
        {
            writer.Write(person.Name);
            writer.Write(person.Age);
        }
    }
    using (StreamWriter reader = new StreamWriter(File.Open(GroupA, FileMode.Create)))
    {
        foreach (Student person in people1)
        {
            reader.WriteLine($" Имя: {person.Name}, Возраст: {person.Age} ");
        }
    }
    Student[] people2 =
    {
     new Student("Наталья",25),
     new Student("Александр",18),
     new Student("Матвей",23)
     };
    using (BinaryWriter writer = new BinaryWriter(File.Open(Student, FileMode.Open)))
    {
        foreach (Student person1 in people2)
        {
            writer.Write(person1.Name);
            writer.Write(person1.Age);
        }
    }
    using (StreamWriter reader = new StreamWriter(File.Open(GroupB, FileMode.Create)))
    {
        foreach (Student person in people2)
        {
            reader.WriteLine($" Имя: {person.Name}, Возраст: {person.Age} ");
        }
    }
}
class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public Student(string name, int age)
    {
        Name = name;
        Age = age;
    }
}

