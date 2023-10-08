using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy
{
    public class program
    {
        static void Main(string[] args)
        {
            AppEngine appEngine = new AppEngine();
            UserInterface ui = new UserInterface(appEngine); 
            ui.ShowFirstScreen();
        }
    }
}
