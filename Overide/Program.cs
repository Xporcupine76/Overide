using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

namespace Overide
{

    class program
    {

        static void Main(string[] args)
        {
            Patient patient = new Patient();
            patient.Examine();

            Adult adult = new Adult();
            adult.Examine();

            Patient p = new Patient();
            p.Examine();
           
        }
        
    }

    public class Patient 
    {
        public virtual void Examine()
        {

            Console.WriteLine("the patient has been examined...");

        }

    }

    public class Adult:Patient
    {

        public override void Examine()
        {

            Console.WriteLine("The adult has been examined...");

        }
    }
}

