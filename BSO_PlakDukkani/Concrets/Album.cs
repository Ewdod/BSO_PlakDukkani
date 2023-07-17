using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSO_PlakDukkani.Concrets
{
    public class Album
    {
        public int Id { get; set; }
        public string? Ad { get; set; }
        public DateTime AlbumCikisTarihi { get; set; }
        public double AlbumFiyati { get; set; }
        public double IndirimOrani { get; set; }
        public bool Satistami { get; set; }
        public string? Sanatci { get; set; }
    }
}
