using OrnekPro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrnekPro.Data
{
    public class TurRepository
    {
        private static readonly List<Tur> _turler = null;
        static TurRepository(){

            _turler = new List<Tur>()
            {


                  new Tur{TurId=1, Name="Macera"},
                  new Tur{TurId=2,Name="Komedi"},
                  new Tur {TurId=3, Name = "Drama" },
                  new Tur {TurId=4, Name = "Romantik" },
            
             };
        }
        public static List<Tur> Turler
        {
            get
            {
                return _turler;
            }

        }
        public static void Add(Tur tur)
        {
            _turler.Add(tur);
        }
        public static Tur GetById(int id )
        {
          return   _turler.FirstOrDefault(t=>t.TurId==id);
        }
    }
}
