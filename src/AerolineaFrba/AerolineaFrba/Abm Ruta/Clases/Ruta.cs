using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Abm_Ruta.Clases
{
    class Ruta
    {
        private int mCodigo;
        private string mPrecioBaseKG;
        private string mPrecioBasePasaje;
        private int mCia_ID_Origen;
        private int mCia_ID_Destino;
        private int mSer_ID;

        public int Codigo
        {
            get
            {
                return mCodigo;
            }
            set
            {
                mCodigo = value;
            }
        }
        public string PrecioBaseKG
        {
            get
            {
                return mPrecioBaseKG;
            }
            set
            {
                mPrecioBaseKG = value;
            }
        }
        public string PrecioBasePasaje
        {
            get
            {
                return mPrecioBasePasaje;
            }
            set
            {
                mPrecioBasePasaje = value;
            }
        }
        public int Cia_ID_Origen
        {
            get
            {
                return mCia_ID_Origen;
            }
            set
            {
                mCia_ID_Origen = value;
            }
        }
        public int Cia_ID_Destino
        {
            get
            {
                return mCia_ID_Destino;
            }
            set
            {
                mCia_ID_Destino = value;
            }
        }
        public int Ser_ID
        {
            get
            {
                return mSer_ID;
            }
            set
            {
                mSer_ID = value;
            }
        }
    }
}
