using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using videoRental.Context;
using videoRental.Models;

namespace videoRental.Controllers
{
    public class HomeController : Controller
    {
        private projectContext _projectContext;
        public HomeController(projectContext pc)
        {
            _projectContext = pc;
        }
        public ViewResult Index()
        {
            return View();
        }

        public ViewResult Customers()
        {
            return View();
        }

        public ViewResult Videos()
        {
            return View();
        }
        public ViewResult customerList()
        {
            //var customerList = this._projectContext.customers;
            return View(_projectContext.customers);
        }
        [HttpGet]
        public ViewResult checkIn(checkOutModel check)
        {
            ViewBag.Videos = _projectContext.videos.ToList<videoModel>();
            ViewBag.Customers = _projectContext.customers.ToList<CustomerModel>();
            return View(check);
        }
        [HttpPost]
        public ViewResult checkIn(checkOutModel checkedMovie, int q)
        {
            if (ModelState.IsValid)
            {
                // get returning customerID and returning Video ID, 
                //Check if customerID and videoID returnDate is null, and 
                videoModel returningVideo = _projectContext.videos.Where(el => el.ID == checkedMovie.VidID).FirstOrDefault();
                checkOutModel returningRental = _projectContext.CheckOutModels.Where(el => (el.custId == checkedMovie.custId) && (el.VidID == checkedMovie.VidID)).FirstOrDefault();
                CustomerModel returningCustomer = _projectContext.customers.Where(el => el.ID == checkedMovie.custId).FirstOrDefault();
                if (returningRental == null)
                {
                    Message("Video has not been checked out");
                    return checkIn(checkedMovie);
                }
                else if (returningCustomer == null)
                {
                    Message("Customer Does not Exist in the rental Repo");
                    return checkIn(checkedMovie);
                }
                else
                {
                    if (returningRental.ReturnDate == null)
                    {
                        returningRental.ReturnDate = DateTime.Now;
                        _projectContext.CheckOutModels.Attach(returningRental);
                        _projectContext.Entry(returningRental).Property(el => el.ReturnDate).IsModified = true;
                        returningVideo.Stock++;
                        _projectContext.SaveChanges();
                        Message("Successfully Checked In");
                        return checkIn(checkedMovie);
                    }
                }
            }

            return View();
        }
        [HttpGet]
        public ViewResult checkOut(checkOutModel checkOut)
        {
            ViewBag.Videos = _projectContext.videos.ToList<videoModel>();
            ViewBag.Customers = _projectContext.customers.ToList<CustomerModel>();
            return View(checkOut);
        }
        [HttpPost]
        public ViewResult checkOut(checkOutModel checkedMovie, int x)
        {
            if (ModelState.IsValid)
            {
                // get checked Movie and checking customer
                videoModel checkedVideo = _projectContext.videos.Where(el => el.ID == checkedMovie.VidID).FirstOrDefault();
                CustomerModel checkedCustomer = _projectContext.customers.Where(el => el.ID == checkedMovie.custId).FirstOrDefault();
                if (checkedVideo != null && checkedCustomer != null)
                {
                    checkOutModel newCheckOut = new checkOutModel()
                    {
                        custId = checkedCustomer.ID,
                        VidID = checkedVideo.ID,
                        RentalDate = DateTime.Now,
                        ReturnDate = null
                    };

                    _projectContext.CheckOutModels.Add(newCheckOut);
                    checkedVideo.Stock--;
                    _projectContext.SaveChanges();
                    Message("Successfully checked out");
                    return checkOut(checkedMovie);
                }
                else if (checkedVideo == null)
                {
                    Message("Video Does Not Exist");
                    return checkOut(checkedMovie);
                }
                else if (checkedCustomer == null)
                {
                    Message("Customer Does Not Exist");
                    return checkOut(checkedMovie);
                }
            }

            return View();
        }
        public ViewResult videoList()
        {
            return View(_projectContext.videos);
        }
        [HttpGet]
        public ViewResult addCustomer(CustomerModel customer)
        {
            return View(customer);
        }
        [HttpPost]
        public ViewResult addCustomer(CustomerModel customer, int x)
        {
            if (ModelState.IsValid)
            {
                bool customerExist = _projectContext.customers.Any(el => el.customerName == customer.customerName);
                if (customerExist)
                {
                    Message("Customer Name already Exists");
                    return addCustomer(customer);
                }
                else
                {
                    this._projectContext.customers.Add(customer);
                    this._projectContext.SaveChanges();
                    Message("Customer Added Successfully");
                    return addCustomer(customer);
                }

            }

            return View();
        }
        [HttpGet]
        public ViewResult addVideos(videoModel video)
        {
            if (video.Title != null && video.ID != 0)
            {
                videoModel newVideo = new videoModel();
                getFormat();
                return View(newVideo);
            }
            else
            {
                getFormat();
                return View(video);
            }
        }
        [HttpPost]
        public ViewResult addVideos(videoModel video, int x)
        {
            if (ModelState.IsValid)
            {
                bool videoExist = _projectContext.videos.Any(el => el.Title == video.Title);
                if (videoExist)
                {
                    Message("Video Already Exist");
                    getFormat();
                    return addVideos(video);
                }
                else
                {
                    _projectContext.videos.Add(video);
                    _projectContext.SaveChanges();
                    Message("Videos Added Successfully");
                    getFormat();
                    return addVideos(video);
                }
            }
            return View();
        }
        public IActionResult DeleteCustomer(int id)
        {
            CustomerModel customer = _projectContext.customers.Where(el => el.ID == id).FirstOrDefault();
            _projectContext.customers.Remove(customer);
            _projectContext.SaveChanges();
            return View("Customers");
        }
        public IActionResult DeleteVideo(int id)
        {
            videoModel video = _projectContext.videos.Where(el => el.ID == id).FirstOrDefault();
            _projectContext.videos.Remove(video);
            _projectContext.SaveChanges();
            return View("Videos");
        }

        public void Message(string Message)
        {
            ViewBag.Message = Message;
        }
        public void getFormat()
        {
            List<string> formats = new List<string>
                {
                    "Blueray",
                    "HD",
                    "CamRip"
                };
            ViewBag.Formats = formats;
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
