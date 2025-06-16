using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codefirstDemo
{
    internal class codeCRUD
    {
        Model1 ob = new Model1();
        public void Insert()
        {
            Movie m = new Movie();
            m.MovieID = 200;
            m.MovieName = "Bahubali-2";
            m.Actor = "Prabhas";
            m.Actress = "Tammana";
            m.YOR = 2019;

            
            ob.Movies.Add(m);
            int i = ob.SaveChanges();
            Console.WriteLine("Total records inserted is "+i);
        }
        public void Insert1() 
        {
            try
            {
                IPL i = new IPL();
                i.TeamID = 1;
                i.Tname = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
                i.Budget = 600000;
                i.State = "Hyderabad";
                i.Cap = "Cummins";

                ob.ipl.Add(i);
                int j = ob.SaveChanges();
                Console.WriteLine("Total records inserted is" + j);
            }
            //[MaxLength(20,ErrorMessage = "Max Length is 20")]
            //[Required(ErrorMessage = "Please Enter the Team name")]
            catch (Exception ex)
            {
                var err = ob.GetValidationErrors();

                foreach (var item in err)
                {
                    foreach (var item1 in item.ValidationErrors)
                    {
                        Console.WriteLine(item1.ErrorMessage);
                    }
                }
            }
            
        }
    }
}
