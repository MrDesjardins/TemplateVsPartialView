using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TemplateVsPartialView.Models
{
    public class Parent
    {
        public string ParentName { get; set; }
        public Child SingleChild { get; set; }
    }
}