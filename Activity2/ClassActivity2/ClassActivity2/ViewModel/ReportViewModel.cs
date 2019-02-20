using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ClassActivity2.Models;
using System.Web.Mvc;



namespace ClassActivity2.ViewModel
{
    public class ReportViewModel
    {
        public IEnumerable<SelectListItem> Employees { get; set; }
        public int SelectedEmployeeID { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }

        public lgemployee employee { get; set; }
        public lginvoice invoice { get; set; }

        public List<IGrouping<string, ReportRecord>> results { get; set; }
        public Dictionary<string, double> chartData { get; set; }

        public class ReportRecord
        {
            public int employeeid { get; set;}

            public string InvoiceDate { get; set;}

            public double InvoiceTotal { get; set;}

            public int invNum { get; set; }

            public string EmployeeName { get; set; }

            public string EmployeeSurname { get; set; }

        }
    }




}
