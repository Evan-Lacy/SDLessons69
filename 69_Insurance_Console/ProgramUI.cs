using _69_Customer_Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _69_Insurance_Console
{
    public class ProgramUI
    {
        private CustomerRepo _repo = new CustomerRepo();

        public void Run()
        {
            SeedContent();
            Info();
        }

        private void SeedContent()
        {
            //DateTime.Now.Date
            Customer watson = new Customer("Watson", 188539, 34, new DateTime (1887, 08, 16), 4);


        }
    }
}
