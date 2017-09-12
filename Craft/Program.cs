using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Craft
{
    class Program
    {
        static void Main(string[] args)
        {


            using (dbContext db = new dbContext())
            {

                Beer beer1 = new Beer { IPA = 20, AcContent = 12, BeerType = "Obolon" };
                Beer beer2 = new Beer { IPA = 16, AcContent = 12, BeerType = "Alle" };

                db.Beers.Add(beer1);
                beer1.IPA = 12;
                beer2.BeerType = "AlleMax";
                db.Beers.Remove(beer1);

               

    
                var query = from Customer in db.Customers
                            where Customer.City != "Kyiv"
                            orderby Customer.Company_Name
                            select new
                            {
                                firstname = Customer.Company_Name.Contains('D'),
                                PhoneNumber = Customer.Phone_Number,
                            };
                var query1 = from feedback in db.FeedBacks
                             where feedback.Feedback1 == "Good"
                             select new
                             {
                                 Feedback = feedback.Feedback1,
                                 customer = feedback.Customer1,
                                 beertype = feedback.BeerType
                             };
                var lamda = db.Brewers
                    .Select(s => s.Experiance > 5)
                    .Take(4);
                db.SaveChanges();

            }





            }
    }
} 
