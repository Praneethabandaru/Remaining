////// See https://aka.ms/new-console-template for more information
//using MyCoreApp;

//Console.WriteLine("Hello, World!");

//myns1.c1 ob = new myns1.c1();
//Console.WriteLine(ob.add(10,20));
//Console.WriteLine(ob.helloworld());
//ob.hello();

//Customers c = new Customers();
//c.Addcustomers();
//c.UpdateCustomer(10.5,"raj");

//c.Customername = 100;
//c.CustomerId="madhu";

//Icustomer obb = new Customers();
//ob.add(10, 20);
//using Newtonsoft.Json;
//Console.WriteLine("Hello, World!");
//// Mylibcls obj = new Mylibcls();
//// obj.Add(10,20);
//// obj.Multiply(10,20);

//var data = new
//{
//    studentid = 101,
//    studentname = "Rahul",
//    studentaddress = "USA"
//};
//Console.WriteLine($"{data.studentid} {data.studentname} {data.studentaddress}");
//string json = JsonConvert.SerializeObject(data, Formatting.Indented);
//System.Console.WriteLine(json);

//mycorelibrary.Class1 ob = new mycorelibrary.Class1();
//ob.hello();
using mycorelibrary;
using System.Xml.Serialization;

mycorelibrary.StudentsDet obb = new mycorelibrary.StudentsDet();
var currentStudents = obb.currentdate1();
foreach (var student in currentStudents)
{
    Console.WriteLine($"ID: {student.StudentId}, Name: {student.StudentsName}, Date: {student.DateOfJoining}");
}

Console.WriteLine("============="); 

var a = obb.studnamelength(8);
foreach (var student in a)
{
    Console.WriteLine($" Name: {student.StudentsName}");
}

Console.WriteLine("=========");

var b = obb.namebeginswithsandendsa();
foreach (var student in b)
{
    Console.WriteLine($" Name: {student.StudentsName}");
}

Console.WriteLine("==========");

var c = obb.skillsstartswithC();
foreach (var student in c)
{
    Console.WriteLine($"ID: {student.StudentId}, Name: {student.StudentsName}, Date: {student.DateOfJoining}");
    
}

Console.WriteLine("=========");

var d = obb.studentid();
foreach (var student in c)
{
    Console.WriteLine($"ID: {student.StudentId}, Name: {student.StudentsName}");

}
Console.WriteLine("==========");

var e = obb.top3highmarks();
foreach (var student in e)
{
    Console.WriteLine($"ID: {student.StudentId}, Name: {student.StudentsName}, Marks :{student.TotalMarks}, Date: {student.DateOfJoining}");
    foreach (var i in student.Skills)
    {
        Console.WriteLine($"{i}");
    }
}

Console.WriteLine("===========");

var f = obb.exten();
foreach (var student in f)
{
    Console.WriteLine(student);
}

Console.WriteLine("=======");

var g = obb.morethan2skills();
foreach (var student in g)
{
    Console.WriteLine($"ID: {student.StudentId}, Name: {student.StudentsName}, Date: {student.DateOfJoining}");

}

Console.WriteLine("=======");

var h = obb.listofstudents();
foreach (var student in h)
{
    Console.WriteLine($"ID: {student.StudentId}, Name: {student.StudentsName}, Date: {student.DateOfJoining}");

}

Console.WriteLine("=========");

var j = obb.studentsbetweenak();
foreach (var student in j)
{
    Console.WriteLine($"ID: {student.StudentId}, Name: {student.StudentsName}, Date: {student.DateOfJoining}");
}

Console.WriteLine("=======");

var l = obb.skillbychar8();
foreach (var student in l)
{
    Console.WriteLine($"ID: {student.StudentId}, Name: {student.StudentsName}, Marks: {student.TotalMarks}, Joining Date: {student.DateOfJoining.ToShortDateString()}");
}
Console.WriteLine("========");

var z = obb.printallnames();
foreach (var student in z)
{
    //Task t = new Task();
    Console.WriteLine($"ID: {student.StudentId}, Name: {student.StudentsName}, Marks: {student.TotalMarks}, Joining Date: {student.DateOfJoining.ToShortDateString()}");
    await Task.Delay(1000);
    //Thread.Sleep(1000);
}
Console.WriteLine("========");

var n = obb.marksgreaterthan80();
FileStream fi = new FileStream("C:\\HighestMarks\\Marks.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
XmlSerializer x = new XmlSerializer(typeof(List<StudentsModel>));
x.Serialize(fi, n.ToList());
fi.Close();
fi.Dispose();
Console.WriteLine("File Created successfully");
FileStream fil = new FileStream("C:\\HighestMarks\\Marks.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
XmlSerializer xy = new XmlSerializer(typeof(List<StudentsModel>));
List<StudentsModel> stude = (List<StudentsModel>)xy.Deserialize(fil);
fil.Close();
foreach (StudentsModel ai in stude)
{
    Console.WriteLine($"ID: {ai.StudentId}, Name: {ai.StudentsName}, Marks: {ai.TotalMarks}, Joining Date: {ai.DateOfJoining.ToShortDateString()}");
}
Console.WriteLine("========");

obb.Showskillbychar();












