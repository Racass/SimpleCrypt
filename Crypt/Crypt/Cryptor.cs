using System;

namespace Crypt
{
    public class Cryptor
    {
        private string message {get; private set;}
        private string masked {get; private set;}
        public Cryptor(string message)
        {
            this.message = message;
            mask();
        }

        private void mask()
        {
            string tempString = "";
            char[] temp = message.ToCharArray();
            int[] subCrypt = new int[temp.Length];

            for (int i = 0; i < temp.Length; i++)
                subCrypt[i] = (Convert.ToInt32(temp[i]) + 10) * 10;

            for (int i = 0; i < subCrypt.Length; i++)
                tempString += Convert.ToChar(subCrypt[i]).ToString();

            this.masked = tempString;
        }

        private void Sim_UnCrypt(string msg, out string uncrypt) /*Not used*/
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
