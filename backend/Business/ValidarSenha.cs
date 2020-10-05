using System;

namespace backend.Business
{
    public static class ValidarSenha
    {
        public static Func<string,bool> SenhaForte()
        {
             Func<string, bool> senhaForte = (s) => {
                    int esp = 0, num = 0;
                    foreach(char letra in s)
                    {
                        int conv = (int)(letra.ToString().ToLower())[0];
                        if(conv >= 48 && conv <= 57) num += 1;
                        else if(conv < 48 || conv > 122) esp += 1; 
                    }
                    return esp >= 2 && num >= 2;
                };
                
            return senhaForte;
        }
    }
}