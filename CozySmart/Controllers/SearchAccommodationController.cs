using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CozySmart.Models;
using CozySmart.ViewModels;

namespace CozySmart.Controllers
{
    public class SearchAccommodationController : Controller
    {

        private CozySmartContext db = new CozySmartContext();
        // GET: SearchAccommodation
        public ActionResult Index()
        {
            return View();
        }

  
        public ActionResult Accommodations_location(SearchAccommodation accommodation)
        {

            var elements = new List<elements>();
            var Available_Accommodations = new List<Accommodation>();

            var accommodations = db.Accommodations;
            var accommodationslocation = accommodations.Where(b => b.Location == accommodation.Location);
            


           
            foreach (var myAccommodation in accommodationslocation)
            {


                var Bookings = db.Bookings.Include(b => b.Accomodation);
                var bookings_Accommodation = Bookings.Where(b => b.Accomodation.Id == myAccommodation.Id);

                int flag = 1;

                foreach (Booking book in bookings_Accommodation)
                {



                    if (book.Arrival >= accommodation.Arrival && book.Departure <= accommodation.Departure) { flag = 0; break; }
                    else if (accommodation.Arrival > book.Arrival && accommodation.Arrival < book.Departure) { flag = 0; break; }
                    else if (accommodation.Departure > book.Arrival && accommodation.Departure < book.Departure) { flag = 0; break; }


                }




                if (flag == 1)
                {

                    Available_Accommodations.Add(myAccommodation);

                   
                    var elementsforbooking = new elements
                    {
                        Accommodation_title = myAccommodation.Title,
                        Accommodation_Location = myAccommodation.Location,
                        Accommodation_Adress = myAccommodation.Adress,
                        Accommodation_Description = myAccommodation.Description,
                        Accommodation_Occupancy = myAccommodation.Occupancy,
                        Accommodation_Rooms = myAccommodation.Rooms,
                        Accommodation_Baths = myAccommodation.Baths,
                        Accommodation_Id = myAccommodation.Id,
                        Accommodation_Price = myAccommodation.Price,
                        Arrival = accommodation.Arrival ,

                        Departure = accommodation.Departure 
                    };


                    elements.Add(elementsforbooking);


                }

            }
            
              //return View(Available_Accommodations);
              return View(elements);
        }





        public ActionResult SearchAccommodations()

        {

            return View();
        }


        public ActionResult Book(elements elementsforbooking)
        {
            
            var booking = new Booking
            {
                ApplicationUserId = 1,
                //Accomodation = elementsforbooking.Accommodation,
                AccommodationId = elementsforbooking.Accommodation_Id,
                Arrival = elementsforbooking.Arrival,

                Departure = elementsforbooking.Departure,

                Occupancy = 1,
                Rating = 1

            };


            db.Bookings.Add(booking);
            db.SaveChanges(); 

           

            return View(elementsforbooking);



        }



    }
}


