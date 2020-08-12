using System;

namespace TPA.CSharp.ObrotowkaService
{
    public class ExcelObrotowkaService
    {
        public DateTime GetMinDate()
        {
            return DateTime.Today.AddDays(-15);
        }

        public DateTime GetMaxDate()
        {
            return DateTime.Today.AddDays(-5);
        }

        public void Save(string filename)
        {

        }
    }
}
