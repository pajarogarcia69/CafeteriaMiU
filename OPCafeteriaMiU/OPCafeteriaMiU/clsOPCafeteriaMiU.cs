using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RnCafeteriaMiU;

namespace OPCafeteriaMiU
{
    public class clsOPCafeteriaMiU
    {
        #region Atributos

        private int _dia;
        private float _vrUnitarioLibra;
        private float _cantidadLibrasN;
        private float _cantidadLibrasQ;
        private float _cantidadLibrasF;
        private float _valorTotalApagar;
        private float _cantidadTotal;
        private string _error;

        #endregion

        #region Constructor

        public clsOPCafeteriaMiU()
        {
            _dia = 0;
            _vrUnitarioLibra = 0;
            _cantidadLibrasN = 0;
            _cantidadLibrasQ = 0;
            _cantidadLibrasF = 0;
            _valorTotalApagar = 0;
            _cantidadTotal = 0;
            _error = string.Empty;
        }

        #endregion

        #region Propiedades

        public float ValorTotalApagar
        {
            get { return _valorTotalApagar;  }
        }

        public float CantidadTotal
        {
            get { return _cantidadTotal; }
        }
        public int Dia
        {
            set { _dia = value; }
            get { return _dia;  }
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

        #region Metodos Publicos

        public bool hallarPago()
        {
            clsCafeteriaMiU obj = new clsCafeteriaMiU();
          
            try
            {
                obj.Dia = _dia;
                if (!obj.hallarDatos())
                {
                    _error = obj.Error;
                    return false;
                }

                _vrUnitarioLibra = obj.VrUnitarioLibra;
                _cantidadLibrasN = obj.CantidadLibraN;
                _cantidadLibrasF = obj.CantidadLibraF;
                _cantidadLibrasQ = obj.CantidadLibraQ;
                _cantidadTotal = _cantidadLibrasN + _cantidadLibrasF + _cantidadLibrasQ;
                _valorTotalApagar = _cantidadTotal * _vrUnitarioLibra;
                return true;
            }
            catch (Exception ex)
            {
                _error = ex.Message;
                return false;
            }
        }

        #endregion
    }
}
