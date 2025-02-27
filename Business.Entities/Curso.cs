﻿namespace Business.Entities
{
    public class Curso : BusinessEntity
    {
        private int _AnioCalendario;
        private int _Cupo;
        private string _Descripcion;
        private int _IDComision;
        private int _IDMateria;

        public int AnioCalendario { get => _AnioCalendario; set => _AnioCalendario = value; }
        public int Cupo { get => _Cupo; set => _Cupo = value; }
        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }
        public int IDComision { get => _IDComision; set => _IDComision = value; }
        public int IDMateria { get => _IDMateria; set => _IDMateria = value; }
    }
}
