//using Newtonsoft.Json;
//using System;
//using System.Collections.Generic;
//using System.IO;

//namespace videoRental.Models
//{
//    public class dataRead
//    {
//        static string _videoFilepath = @"C:\Users\DOSUMU AYOMIDE\source\repos\videoRental\videoRental\wwwroot\Repo\videos.json";
//        static string _customerFilePath = @"C:\Users\DOSUMU AYOMIDE\source\repos\videoRental\videoRental\wwwroot\Repo\Customer.json";

//        public static List<videoModel> readVideo()
//        {
//            try
//            {
//                using (FileStream file = new FileStream(_videoFilepath, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite))
//                {
//                    using (StreamReader sr = new StreamReader(file))
//                    {
//                        var json = sr.ReadToEnd();
//                        var output = JsonConvert.DeserializeObject<List<videoModel>>(json);
                        
//                        return output;
//                    }
//                }

//            }
//            catch (Exception ex)
//            {
//                throw ex;
//            }
//        }
//        public static List<CustomerModel> readCustomer()
//        {
//            using (FileStream file = new FileStream(_customerFilePath, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite))
//            {
//                using (StreamReader sr = new StreamReader(file))
//                {
//                    var json = sr.ReadToEnd();
//                    var customerList = JsonConvert.DeserializeObject<List<CustomerModel>>(json);
                    
//                    return customerList;
//                }

//            }
//        }
//    }
//}