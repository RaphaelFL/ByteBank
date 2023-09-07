using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Titular;

namespace ByteBank.Conta
{
    public class ContaCorrente
    {
        public static int TotalCriadas{ get; private set; }
        private int numero_Agencia;
        public int Numero_Agencia 
        {
            get
            {
                return this.numero_Agencia;
            }
            set 
            {
                if (value > 0) 
                {
                    this.numero_Agencia = value;
                }
            }
        }
        public string conta { get; set; }
        private double saldo = 100;
        public Cliente titular { get; set; }

        public void Depositar(double valor)
        {
            saldo += valor;
        }

        public bool Sacar(double valor)
        {
            if (valor <= saldo)
            {
                saldo -= valor;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool transferir(double valor, ContaCorrente destino)
        {
            if (saldo < valor)
            {
                return false;
            }
            else
            {
                Sacar(valor);
                destino.Depositar(valor);
                return true;
            }
        }
        
        public void DefinirSaldo(double valor) 
        {
            if (valor < 0) 
            {
                return;
            }
            else 
            {
                this.saldo = valor;
            }
        }
        public double ObterSaldo() 
        {
            return this.saldo;
        }

        public ContaCorrente(int numero_Agencia, string conta)
        {
            this.Numero_Agencia = numero_Agencia;
            this.conta = conta;
            TotalCriadas++;
        }
        public ContaCorrente()
        {
            TotalCriadas++;
        }
    }

}
