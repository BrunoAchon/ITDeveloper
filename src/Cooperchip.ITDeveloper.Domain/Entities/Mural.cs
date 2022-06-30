using System;

namespace Cooperchip.ITDeveloper.Domain.Entities
{
    public class Mural
    {
        // prop + tab + tab gera um snipet para agilizar a digitacao com "public int MyProperty { get; set; }"
        public int MuralId { get; set; }
        public DateTime Data { get; set; }
        public string Titulo { get; set; }
        public string Aviso { get; set; }
        public string Autor { get; set; }
        public string Email { get; set; }

        // dentro da modal pode se exitir metodos
        public override string ToString()
        {
            //return base.ToString();
            return this.Aviso + " - " + this.Autor;
        }
    }
}
