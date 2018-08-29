using System;
using System.Collections.Generic;

namespace ClassRoom
{
    internal class KlasseRum
    {
        public string KlasseNavn { get; set; }
        public List<Student> Klasseliste { get; set; }

        public DateTime SemesterStart { get; set; }
    }
}