using System.Text.RegularExpressions;

namespace mycorelibrary
{
    public class Class1
    {
        public void hello()
        {
            Console.WriteLine("hello from class");
        }
    }
    public class StudentsModel
    {
        public int StudentId { get; set; }
        public string StudentsName { get; set; }
        public int TotalMarks { get; set; }
        public string[] Skills { get; set; }
        public DateTime DateOfJoining { get; set; }
    }
    public class StudentsDet
    {
        List<StudentsModel> students = new List<StudentsModel>()
        {
            new StudentsModel { StudentId = 1, StudentsName = "Akhilesh", TotalMarks = 85, Skills = new[] {"C#", "SQL", "Data Structures"}, DateOfJoining = new DateTime(2023, 1, 15) },
            new StudentsModel { StudentId = 2, StudentsName = "Kusuma", TotalMarks = 78, Skills = new[] {"Python", "Machine Learning", "Data Analysis"}, DateOfJoining = new DateTime(2022, 8, 10) },
            new StudentsModel { StudentId = 3, StudentsName = "Jayanth", TotalMarks = 90, Skills = new[] {"Java", "Spring Boot", "Microservices"}, DateOfJoining = new DateTime(2025, 5, 22) },
            new StudentsModel { StudentId = 4, StudentsName = "Rakshitha", TotalMarks = 76, Skills = new[] {"JavaScript", "React", "Node.js","Blazor"}, DateOfJoining = new DateTime(2022, 11, 7) },
            new StudentsModel { StudentId = 5, StudentsName = "Madhu", TotalMarks = 82, Skills = new[] {"HTML", "CSS", "UI/UX Design"}, DateOfJoining = new DateTime(2023, 3, 30) },
            new StudentsModel { StudentId = 6, StudentsName = "Naveena", TotalMarks = 88, Skills = new[] {"Angular", "TypeScript", "Docker"}, DateOfJoining = new DateTime(2023, 6, 5) },
            new StudentsModel { StudentId = 7, StudentsName = "Satish", TotalMarks = 79, Skills = new[] {"Swift", "Kotlin", "Mobile Development"}, DateOfJoining = new DateTime(2022, 9, 12) },
            new StudentsModel { StudentId = 8, StudentsName = "Sailesh", TotalMarks = 94, Skills = new[] {"Cloud Computing", "AWS", "DevOps","MVC"}, DateOfJoining = new DateTime(2023, 4, 25) },
            new StudentsModel { StudentId = 9, StudentsName = "Sushmitha", TotalMarks = 80, Skills = new[] {"Cybersecurity", "Ethical Hacking", "Network Security"}, DateOfJoining = new DateTime(2022, 7, 18) },
            new StudentsModel { StudentId = 10, StudentsName = "Pranitha", TotalMarks = 87, Skills = new[] {"Big Data", "Hadoop", "Spark"}, DateOfJoining = new DateTime(2025, 5, 22) },
            new StudentsModel { StudentId = 11, StudentsName = "Divya", TotalMarks = 92, Skills = new[] {"AI", "Deep Learning", "Neural Networks"}, DateOfJoining = new DateTime(2023, 5, 10) },
            new StudentsModel { StudentId = 12, StudentsName = "Sandhya", TotalMarks = 75, Skills = new[] {"Blockchain", "Cryptography", "Smart Contracts"}, DateOfJoining = new DateTime(2022, 10, 3) },
            new StudentsModel { StudentId = 13, StudentsName = "Sultana", TotalMarks = 83, Skills = new[] {"Software Testing", "Automation", "Selenium"}, DateOfJoining = new DateTime(2023, 1, 22) }
        };
        //create a method which returns all students data 
        public IEnumerable<StudentsModel> GetStudents() //Ienumerable is used only for read only purpose and this is used for iteration 
        {
            return students;
        } 

        public List<StudentsModel> GetStudents1() //but list is used for not only iteration but also for adding and removing the data 
        {
            return students;
        }
        
        public IEnumerable<StudentsModel> currentdate1()
        {
            //return only those data from the list,write a linq entry who's joining date is current date 
            
            //var stud = from s in students
            //           where s.DateOfJoining == DateTime.Now
            //           select s;
            //foreach (var item in stud)
            //{
            //    return stud;
            //}

            var res = students.Where(c => c.DateOfJoining.Date == DateTime.Now.Date);
            return res;
        }
        public IEnumerable<StudentsModel> studnamelength(int x)
        {
            //display records who name is x character long
            //var stud = from s in students
            //           where s.StudentsName.Length == x
            //           select s;
            //foreach (var item in stud)
            //{
            //    return stud;
            //}
            var res1= students.Where(c => c.StudentsName.Length == x);
            return res1;
        }

        public IEnumerable<StudentsModel> namebeginswithsandendsa()
        {
            //display details where name begins with 's' and ends with 'a'
            var stud = students.Where(c => c.StudentsName.StartsWith('S') && c.StudentsName.EndsWith('a'));
            return stud;

        }
        public IEnumerable<StudentsModel> skillsstartswithC()
        {
            //display details where skills starts with c 
            return students.Where(s => s.Skills.Any(s => s.StartsWith('C')));
        }

        public IEnumerable<StudentsModel> studentid()
        {
            //display details where studentid > 3 and < 9 and return only id and name 
            var stud = students.Where(c => c.StudentId > 3 && c.StudentId < 9);
            return stud;
        }

        public IEnumerable<StudentsModel> top3highmarks()
        {
            //display top 3 highest marks
            return students.OrderByDescending(s => s.TotalMarks).Take(3);
        }

        public IEnumerable<string> exten()
        {
            //create extension method which returns name contains 'a' and 7 characters long 
            //and display the result in uppercase
            return students.FilterAndFormatNames();
        }

        public IEnumerable<StudentsModel> morethan2skills()
        {
            //list of students who have more than 2 skills 
            return students.Where(s => s.Skills.Length > 3);
        }

        public IEnumerable<StudentsModel> listofstudents()
        {
            //list of students who name is madhu,satish,akhilesh,rakshitha,sailesh
            var nameList = new List<string> { "Madhu", "Satish", "Akhilesh", "Rakshitha", "Sailesh" };
            return students.Where(s => nameList.Contains(s.StudentsName));
        }

        public IEnumerable<StudentsModel> studentsbetweenak()
        {
            //list of students who's name is between a-k 
            //hint use regex class
            Regex regex = new Regex("^[A-K]+");
            var stud = students.Where(s => regex.IsMatch(s.StudentsName));
            return stud;
        }
        //public IEnumerable<StudentsModel> Showskillbychar()
        //{
        //    //create following delegate 
        //    //delegate bool StudentFilter(StudentsModel student);
        //    //StudentFilter filter = s => s.TotalMarks > 80;
        //    //using delegates lists all etails where totalmarks > 80
        //    StudentFilter filter = s => s.TotalMarks > 80;
        //    return stud.Where(s => filter(s)); // Apply the delegate
        //}
        delegate bool StudentFilter(StudentsModel student);
        public IEnumerable<StudentsModel> skillbychar8()
        {
            StudentFilter filter = s => s.TotalMarks > 80;
            return students.Where(s => filter(s)); // Apply the delegate
        }

        public IEnumerable<StudentsModel> printallnames()
        {
            //print all names with delay of 1 seconds whos marks greater than 80 
            //hint use task class
            return students.Where(s => s.TotalMarks > 80);

        }

        public IEnumerable<StudentsModel> marksgreaterthan80()
        {
            //store the data in file who have scored more than 80 
            //using xml serialization 
            return students.Where(s => s.TotalMarks > 80);
        } 
        public async void Showskillbychar()
        {
            //read the data data asynchronosly using 
            //ReadToEndAsync method of Streamreader class
            //print the result in console 
            FileStream file = new FileStream("C:\\HighestMarks\\Marks.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader r = new StreamReader(file);
            string xmldata = await r.ReadToEndAsync();
            Console.WriteLine(xmldata);

            file.Close(); //  Manually closing FileStream
            r.Close(); //  Manually closing StreamReader
        }

    }
    public static class StudentExtensions
    {
        public static IEnumerable<string> FilterAndFormatNames(this IEnumerable<StudentsModel> students)
        {
            return students.Where(s => s.StudentsName.Contains('a') && s.StudentsName.Length == 7)
                           .Select(s => s.StudentsName.ToUpper());
        }
    }
}
