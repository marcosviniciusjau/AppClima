using System;
using System.Collections.Generic;
using System.Text;

namespace AppClima.Model
{
    public class Tempo
    {
        public string Title { get; set; }
        public string Temperatura { get; set; }
        public string Vento { get; set; }
        public string Humidade { get; set; }
        public string Visibilidade { get; set; }
        public string Nascer_Sol { get; set; }
        public string Por_Sol { get; set; }

        public Tempo()
        {
            this.Title = "";
            this.Temperatura = "";
            this.Vento = "";
            this.Humidade = "";
            this.Visibilidade = "";
            this.Nascer_Sol = "";
            this.Por_Sol = "";
        }
    }
}
