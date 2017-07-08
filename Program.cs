using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sqllite
{
  class Program
  {
    static void Main(string[] args)
    {
      var model = new Model1();
      Console.WriteLine("rows: " + model.Rows.Count());
      var r = new Row();
      r.Name = "hi";
      model.Rows.Add(r);
      model.SaveChanges();
      Console.WriteLine("rows: " + model.Rows.Count());
    }
  }
}
