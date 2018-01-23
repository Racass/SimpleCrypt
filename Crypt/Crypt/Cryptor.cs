using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crypt
{
    static class Cryptor
    {
        

        public static void Sim_Crypt(string msg, out string crypt)
        {
            string retorno = "";
            char[] temp = msg.ToCharArray();
            int[] subCrypt = new int[temp.Length];

            for (int i = 0; i < temp.Length; i++)
                subCrypt[i] = (Convert.ToInt32(temp[i]) + 10) * 10;

            for (int i = 0; i < subCrypt.Length; i++)
                retorno += Convert.ToChar(subCrypt[i]).ToString();

            crypt = retorno;

            return;
        }


        public static void Sim_UnCrypt(string msg, out string uncrypt)
        {
            string retorno = "";
            char[] temp = msg.ToCharArray();
            int[] subCrypt = new int[temp.Length];


            for (int i = 0; i < temp.Length; i++)
                subCrypt[i] = Convert.ToInt32(temp[i]);

            for (int i = 0; i < subCrypt.Length; i++)
                subCrypt[i] = (subCrypt[i] / 10) - 10;

            for (int i = 0; i < subCrypt.Length; i++)
                retorno += Convert.ToChar(subCrypt[i]).ToString();


            uncrypt = retorno;

            return;
        }



    }
}
