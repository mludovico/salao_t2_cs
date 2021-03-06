﻿using SalaoT2.Dominio.Models;
using System;
namespace SalaoT2.Dominio
{
    public class Caixa : IEntity
    {
        public Decimal Saldo { get; set; }
        public Decimal Entrada { get; set; }
        public Decimal Saida { get; set; }
        public int Id { get ; set; }

        private const Decimal Porcentagem = 0.3M;
        
        public Caixa(Decimal saldoInicial)
        {
            Saldo = saldoInicial;
        }

        public void ReceberServico(Servico servico)
        {
            Saldo += servico.Preco;
            Entrada += servico.Preco;
            PagarFuncionario(servico.Preco * Porcentagem);
        }

        void PagarFuncionario(Decimal valor)
        {
            Saldo -= valor;
            Saida += valor;
        }
    }
}
