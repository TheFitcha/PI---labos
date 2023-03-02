using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Materijali
{
    public class Dio
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public List<Sloj> Slojevi { get; set; }

        public Dio(int id, string naziv)
        {
            this.Id = id;
            this.Naziv = naziv;
            Slojevi = new List<Sloj>();
        }

        public float Otpor
        {
            get
            {
                return 0;
            }
        }
    }
}
