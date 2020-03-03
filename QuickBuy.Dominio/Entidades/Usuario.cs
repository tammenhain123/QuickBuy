﻿using System.Collections.Generic;

namespace QuickBuy.Dominio.Entidades
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        //Usuario pode ter nenhum ou varios Pedidos
        public  ICollection<Pedido> Pedidos { get; set; }
    }
}
