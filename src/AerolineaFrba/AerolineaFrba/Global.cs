using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.ComponentModel;
using System.Configuration;

namespace AerolineaFrba
{
    class Global
    {
        public static int id_usuario;
        public static int id_rol;


        public static String encriptarSHA256(string cadena)
        {
            byte[] bytesPswd = Encoding.UTF8.GetBytes(cadena);
            SHA256Managed sha256 = new SHA256Managed();
            byte[] hashedBytes = sha256.ComputeHash(bytesPswd);
            string encryptedPswd = BitConverter.ToString(hashedBytes).Replace("-", string.Empty).ToLower();
            return encryptedPswd;
        }

    }
}
