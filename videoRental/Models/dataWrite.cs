//using Newtonsoft.Json;
//using System;
//using System.Collections.Generic;
//using System.IO;


//namespace videoRental.Models
//{
//    public class dataWrite
//    {

//        static string _videoFilepath = @"C:\Users\DOSUMU AYOMIDE\source\repos\videoRental\videoRental\wwwroot\Repo\videos.json";
//        static string _customerFilePath = @"C:\Users\DOSUMU AYOMIDE\source\repos\videoRental\videoRental\wwwroot\Repo\customer.json";

//        public static void writeVideo(List<videoModel> videoList)
//        {
//            try
//            {
//                using (FileStream file = new FileStream(_videoFilepath, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite))
//                {
//                    using (StreamWriter sw = new StreamWriter(file))
//                    {
//                        var json = JsonConvert.SerializeObject(videoList);
//                        sw.WriteLine(json);
                        
//                    }
//                }
//            }
//            catch (Exception ex)
//            {
//                throw ex;
//            }
//        }
//        public static void writeCustomer(List<CustomerModel> customerList)
//        {
//            try
//            {
//                using (FileStream file = new FileStream(_customerFilePath, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite))
//                {
//                    using (StreamWriter sw = new StreamWriter(file))
//                    {
//                        var json = JsonConvert.SerializeObject(customerList);
//                        sw.WriteLine(json);
                        
//                    }
//                }
//            }
//            catch (Exception ex)
//            {
//                throw ex;
//            }

//        }
//    }
//}