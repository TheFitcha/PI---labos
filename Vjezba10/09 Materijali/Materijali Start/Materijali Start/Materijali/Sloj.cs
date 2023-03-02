using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Materijali
{
    public class Sloj
    {
        private float _debljina;

        public int Id { get; set; }
        public Dio GradjevniDio { get; set; }
        public Materijal MaterijalSloja { get; set; }
        public float Debljina
        {
            get
            {
                return _debljina;
            }
            set
            {
                _debljina = value;
            }
        }

        public Sloj(int id, float debljina, Dio gradjevniDio, Materijal materijal)
        {
            Id = id;
            Debljina = debljina;
            GradjevniDio = gradjevniDio;
            MaterijalSloja = materijal;
        }
    }
}
