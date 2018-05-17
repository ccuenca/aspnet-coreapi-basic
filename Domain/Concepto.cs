using System;

namespace ConceptosService2.Domain
{
    public class Concepto
    {
        public Int16 Id { get; set; }

        public string Codigo { get; set; }

        public string Nombre { get; set; }    

        public string Tipo { get; set; }

        public string Parametro { get; set; }
    }
}