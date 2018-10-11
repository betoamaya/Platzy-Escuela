namespace CoreEscuela.Entidades
{
    class Escuela
    {
        public string Nombre { get; set; }
        public int AñoDeCreación { get; set; }
        public string Ciudad { get; set; }
        public string Pais { get; set; }
        
        public Escuela (string _nombre, int _año)
        {
            this.Nombre = _nombre;
            this.AñoDeCreación = _año;
        }

        public Escuela(string _nombre, int _año, string _ciudad, string _pais) => (Nombre, AñoDeCreación, Ciudad, Pais) = (_nombre, _año, _ciudad, _pais);
    }
}