using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RnCafeteriaMiU
{
    public class clsCafeteriaMiU
    {
        #region Atributos

        private int _dia;
        private float _vrUnitarioLibra;
        private float _cantidadLibrasN;
        private float _cantidadLibrasQ;
        private float _cantidadLibrasF;
        private string _error;

        #endregion

        #region Constructor

        public clsCafeteriaMiU()
        {
            _dia             = 0;
            _vrUnitarioLibra = 0;
            _cantidadLibrasN = 0;
            _cantidadLibrasQ = 0;
            _cantidadLibrasF = 0;
            _error           = string.Empty;
        }

        #endregion

        #region Propiedades

        public int Dia
        {
            set { _dia = value; }
        }

        public float VrUnitarioLibra
        {
            get { return _vrUnitarioLibra; }
        }

        public float CantidadLibraN
        {
            get { return _cantidadLibrasN; }
        }

        public float CantidadLibraQ
        {
            get { return _cantidadLibrasQ; }
        }

        public float CantidadLibraF
        {
            get { return _cantidadLibrasF; }
        }

        public string Error
        {
            get { return _error; }
        }

        #endregion

        #region Metodos Privados

        private bool Validar()
        {
            if(_dia != 1 && _dia != 2 && _dia != 3)
            {
                _error = "Tipo de dia no es valido";
                return false;
            }

            return true;
        }

        private bool leerArchivo()
        {
            if (!Validar())
                return false;
            try
            {
                string _Path = AppDomain.CurrentDomain.BaseDirectory + @"pedidos.txt";
                int _cantRegistro = 0;
                string _Linea;
                string[] vectorLinea;
                string _codigo;
                float _valorU;
                _cantRegistro = File.ReadAllLines(_Path).Length;
                if (_cantRegistro <= 0)
                    return true;
                StreamReader Archivo = new StreamReader(@_Path);
                while((_Linea = Archivo.ReadLine()) != null )
                {
                    vectorLinea = _Linea.Split('|');
                    _codigo = vectorLinea[0];
                    _valorU = Convert.ToSingle(vectorLinea[1]);
                    if(_codigo == _dia.ToString())
                    {
                        _cantidadLibrasN = Convert.ToSingle(vectorLinea[2]);
                        _cantidadLibrasQ = Convert.ToSingle(vectorLinea[3]);
                        _cantidadLibrasF = Convert.ToSingle(vectorLinea[4]);
                        break;
                    }
                }
                Archivo.Close();
                return true;
            }
            catch(Exception ex)
            {
                _error = ex.Message;
                return false;
            }

        }
        #endregion

        #region Metodos Publicos 
        public bool hallarDatos()
        {
            return leerArchivo();
        }
        #endregion
    }
}
