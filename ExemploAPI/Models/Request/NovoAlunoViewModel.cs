﻿namespace ExemploAPI.Models.Request
{
	public class NovoAlunoViewModel	{
        public string Nome { get; set; }
        public decimal RA { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public bool Ativo { get; set; }
    }
}
