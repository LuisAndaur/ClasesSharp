using System;
using System.Collections.Generic;

namespace Entidades
{
    public class Usuario
    {
        public Dictionary<string, int> Diccionario()
        {
            Dictionary<string, int> usuarios = new Dictionary<string, int>();
            usuarios.Add("claudia", 1234);
            usuarios.Add("jose", 2345);
            usuarios.Add("lore", 9999);
            usuarios.Add("sandra", 0000);
            return usuarios;
        }
    }
}
