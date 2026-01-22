using Microsoft.AspNetCore.Mvc;
using System.Collections;

namespace Interview_FollowUp_Core.Service.Controllers
{
    public class InterviewFollowUpController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public InterviewFollowUpController()
        {

        }

        public void WhatisDictionary()
        {
            // Dictionary is a collection of key-value pairs
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(1, "One");
            dictionary.Add(2, "Two");
            dictionary.Add(3, "Three");
            foreach (KeyValuePair<int, string> kvp in dictionary)
            {
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
            }
        }

        public void WhatIsHashtable()
        {
            // Hashtable is a collection of key-value pairs
            Hashtable hashtable = new Hashtable();
            hashtable.Add(1, "One");
            hashtable.Add(2, "Two");
            hashtable.Add(3, "Three");
            foreach (DictionaryEntry de in hashtable)
            {
                Console.WriteLine("Key: {0}, Value: {1}", de.Key, de.Value);
            }
        }
    }
}
