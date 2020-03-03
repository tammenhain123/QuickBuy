using QuickBuy.Dominio.Enumerados;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.ObjetoValor
{
    public class FormaPagamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public bool VerificaBoleto
        {
            get { return Id == (int)TipoFormaPagamentoEnum.Boleto; }
        }
        public bool VerificaCartao
        {
            get { return Id == (int)TipoFormaPagamentoEnum.CartaoCredito; }
        }
        public bool VerificaDeposito
        {
            get { return Id == (int)TipoFormaPagamentoEnum.Deposito; }
        }
        public bool VerificaNaoDefinido
        {
            get { return Id == (int)TipoFormaPagamentoEnum.NaoDefinido; }
        }
    }
}
