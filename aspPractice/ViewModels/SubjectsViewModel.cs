using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using aspPractice;
using aspPractice.Models;


namespace aspPractice.ViewModels
{
    public class SubjectsViewModel
    {
        public aspPractice.Models.Subject Subject { get; set; }
        public List<Problem> Problem  { get; set; }
    }
}