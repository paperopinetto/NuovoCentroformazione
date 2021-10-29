using System;
using SequentialGuid;

namespace App.Models.Entities
{
    public partial class Edificio
    {
        public Edificio(string CodiceDipartimento, string Aula, string Laboratorio, string Posti)
        {
            IdEdificio = SequentialGuidGenerator.Instance.NewGuid().ToString();
            
        }

        public int Id { get; set; }
        public string IdEdificio { get; set; }
        public string CodiceDipartimento { get; set; }
        public string Aula { get; set; }
        public string Indirizzo { get; set; }
        public string Piano { get; set; }
        public string Mq { get; set; }
        public string Laboratorio { get; set; }
        public string Posti { get; set; }
        public string Note { get; set; }

       
    }
}