﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploRelatorio
{
    class Empregado
    {
        private int codigo;
        private string nome;
        private double salario;

        public int Codigo
        {
            get
            {
                return codigo;
            }

            set
            {
                codigo = value;
            }
        }

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public double Salario
        {
            get
            {
                return salario;
            }

            set
            {
                salario = value;
            }
        }
        public string registrarDados()
        {
            return " Código: " + codigo + "\n Nome Empregado: " + nome + "\n Salário Empregado: " + salario;
        }
    }
}
