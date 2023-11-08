using System;
using System.Collections.Generic;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.Fundamentos;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes;
using CursoCSharp.OO;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                // Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentarios - Fundamentos", Comentarios.Executar},
                {"Variaveis e Constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Notacao Ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo Dados - Fundamentos", LendoDados.Executar},
                {"Formatando Numero - Fundamentos", FormatandoNumero.Executar},
                {"Conversoes - Fundamentos", Conversoes.Executar},
                {"Operadores Aritmeticos - Fundamentos", OperadoresAritmeticos.Executar},
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar},
                {"Operadores Logicos - Fundamentos", OperadoresLogicos.Executar},
                {"Operadores Atribuicao - Fundamentos", OperadoresAtribuicao.Executar},
                {"Operadores Unarios - Fundamentos", OperadoresUnarios.Executar},
                {"Operador Ternario - Fundamentos", OperadorTernario.Executar},
                // Estruturas de controle
                {"Estrutura If - Estruturas de Controle", EstruturaIf.Executar},
                {"Estrutura If Else - Estruturas de Controle", EstruturaIfElse.Executar},
                {"Estrutura If Else If - Estruturas de Controle", EstruturaIfElseIf.Executar},
                {"Estrutura Switch - Estruturas de Controle", EstruturaSwitch.Executar},
                {"Estrutura While - Estruturas de Controle", EstruturaWhile.Executar},
                {"Estrutura Do While - Estruturas de Controle", EstruturaDoWhile.Executar},
                {"Estrutura For - Estruturas de Controle", EstruturaFor.Executar},
                {"Estrutura ForEach - Estruturas de Controle", EstruturaForEach.Executar},
                {"Usando break - Estruturas de Controle", UsandoBreak.Executar},
                {"Usando Continue - Estruturas de Controle", UsandoContinue.Executar},
                // Classes E Metodos
                {"Membros - Classes e metodos", Membros.Executar},
                {"Construtores - Classes e metodos", Construtores.Executar},
                {"Metodos com retorno - Classes e metodos", MetodosComRetorno.Executar},
                {"Metodos Estaticos - Classes e metodos", MetodosEstaticos.Executar},
                {"Atributos Estaticos - Classes e metodos", AtributosEstaticos.Executar},
                {"Desafio Atributo - Classes e metodos", DesafioAtributo.Executar},
                {"Params - Classes e metodos", Params.Executar},
                {"Parametros Nomeados - Classes e metodos", ParametrosNomeados.Executar},
                {"GetSet - Classes e metodos", GetSet.Executar},
                {"Props - Classes e metodos", Props.Executar},
                {"Readonly - Classes e metodos", Readonly.Executar},
                {"Exemplo Enum - Classes e metodos", ExemploEnum.Executar},
                {"Struct - Classes e metodos", ExemploStruct.Executar},
                {"Struct vs Classe - Classes e metodos", StructVsClasse.Executar},
                {"Valor vs Referencia - Classes e metodos", ValorVsReferencia.Executar},
                {"Parametros por Referencia - Classes e metodos", ParametrosPorReferencia.Executar},
                {"Parametro Padrao - Classes e metodos", ParametroPadrao.Executar},

                // Colecoes
                {"Array - Colecoes", Colecoes.Array.Executar},
                {"List - Colecoes", ColecoesList.Executar},
                {"ArrayList - Colecoes", ColecoesArrayList.Executar},
                {"Set - Colecoes", ColecoesSet.Executar},
                {"Queue - Colecoes", ColecoesQueue.Executar},
                {"Igualdade - Colecoes", Igualdade.Executar},
                {"Stack - Colecoes", ColecoesStack.Executar},
                {"Dictionary - Colecoes", ColecoesDicionary.Executar},

                // OO
                {"Heranca - Orientacao a Objeto", Heranca.Executar},
                {"Construtor this - Orientacao a Objeto", ConstrutorThis.Executar},
                {"Encapsulamento - Orientacao a Objeto", OO.Encapsulamento.Executar},
                {"Polimorfismo - Orientacao a Objeto", OO.Polimorfismo.Executar},
                {"Abstract - Orientacao a Objeto", OO.Abstract.Executar},

            });

            central.SelecionarEExecutar();
        }
    }
}