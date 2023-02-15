using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp3
{
    class Korpys 
    {
        private string Name;
        private string adress;
        private Sotrydnik komendant;
        private Sotrydnik organization;

        public Korpys (korpys Name, korpys adress, Sotrydnik komendant, Sotrydnik organization )
        {
            string name;
            string Adress;
            string Komendant;
            string Organization;

            name = this.Name;
            Adress = this.adress;
            Komendant = this.komendant;
            Organization = this.organization;

            //Console.WriteLine($"Имя:{name} Адрес:{Adress} ");
        }
    }
}
