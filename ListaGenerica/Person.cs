using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace ListaGenerica
{
    public enum CountryEnum
    {
        BR, US, JP, KO, IT, Average
    }
    public class Person
    {
        public string? Name { get; set; }
        public int Age { get; set;}
        public CountryEnum country { get; set; }
    }
}