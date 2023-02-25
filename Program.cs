using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes;
using CursoCSharp.OO;
using CursoCSharp.MetodosEFuncoes;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                //Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", Comentarios.Executar},
                {"Variaveis e Constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferência - Fundamentos", Inferencia.Executar},
                {"Interpolação - Fundamentos", Interpolacao.Executar},
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo Dados - Fundamentos", LendoDados.Executar},
                {"Formatando Número - Fundamentos", FormatandoNumero.Executar},
                {"Conversões - Fundamentos", Conversoes.Executar},
                {"Operadores Aritméticos - Fundamentos", OperadoresAritmeticos.Executar},
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar},
                {"Operadores Lógicos - Fundamentos", OperadoresLogicos.Executar},
                {"Operadores de Atribuição - Fundamentos", OperadoresAtribuicao.Executar},
                {"Operadores Unários - Fundamentos", OperadoresUnarios.Executar},
                {"Operadores Ternário - Fundamentos", OperadorTernario.Executar},
                //Estruturas de Controle
                {"Estruturas If - Estruturas de Controle",EstruturaIf.Executar},
                {"Estruturas If e Else - Estruturas de Controle",EstruturaIfElse.Executar},
                {"Estruturas If, ElseIf e Else - Estruturas de Controle",EstruturaIfElseIf.Executar},
                {"Estruturas Switch - Estruturas de Controle",EstruturaSwitch.Executar},
                {"Estruturas While - Estruturas de Controle",EstruturaWhile.Executar},
                {"Estruturas Do While - Estruturas de Controle",EstruturaDoWhile.Executar},
                {"Estruturas For - Estruturas de Controle",EstruturaFor.Executar},
                {"Estruturas For Each - Estruturas de Controle",EstruturaForEach.Executar},
                {"Usando Break - Estruturas de Controle",UsandoBreak.Executar},
                {"Usando Continue - Estruturas de Controle",UsandoContinue.Executar},
                //Classes e Métodos
                {"Membros - Classes e Métodos",Membros.Executar},
                {"Construtores - Classes e Métodos",Construtores.Executar},
                {"Métodos com Retorno - Classes e Métodos",MetodosComRetorno.Executar},
                {"Métodos Estáticos - Classes e Métodos",MetodosEstaticos.Executar},
                {"Atributos Estáticos - Classes e Métodos",AtributosEstaticos.Executar},
                {"Desafio Atributo - Classes e Métodos",DesafioAtributo.Executar},
                {"Params - Classes e Métodos",Params.Executar},
                {"Parametros Nomeados - Classes e Métodos",ParametrosNomeados.Executar},
                {"Get e Set - Classes e Métodos",GetSet.Executar},
                {"Props - Classes e Métodos",Props.Executar},
                {"ReadOnly - Classes e Métodos",ReadOnly.Executar},
                {"Exemplo Enum - Classes e Métodos",ExemploEnum.Executar},
                {"Struct - Classes e Métodos",ExemploStruct.Executar},
                {"Struct vs Classe - Classes e Métodos",StructVsClasse.Executar},
                {"Valor vs Referência - Classes e Métodos",ValorVsReferencia.Executar},
                {"Parametros por Referência - Classes e Métodos",ParametrosPorReferencia.Executar},
                {"Parametro Padrão - Classes e Métodos",ParametroPadrao.Executar},
                //Coleções
                {"Array - Coleções", Colecoes.Array.Executar },//Quando a referência for ambigua é necessario apontar a pasta
                {"List - Coleções", ColecoesList.Executar },
                {"Array List - Coleções", ColecoesArrayList.Executar },
                {"Set - Coleções", ColecoesSet.Executar },
                {"Queue - Coleções", ColecoesQueue.Executar },
                {"Igualdade - Coleções", Igualdade.Executar },
                {"Stack - Coleções", ColecoesStack.Executar },
                {"Dictionary - Coleções", ColecoesDictionary.Executar },
                //OO
                {"Herança - OO", Herança.Executar},
                {"Construtor This - OO", ConstrutorThis.Executar},
                {"Encapsulamento - OO", OO.Encapsulamento.Executar},
                {"Polimorfismo - OO", Polimorfismo.Executar},
                {"Abstracto - OO", Abstract.Executar},
                {"Interface - OO", Interface.Executar},
                {"Sealed - OO", Sealed.Executar},
                //Método e Funções
                {"Exemplo Lambda - Métodos e Funções", ExemploLambda.Executar},
                {"Lambdas como Delegates - Métodos e Funções", LambdasDelegate.Executar},
                {"Usando Delegates - Métodos e Funções", UsandoDelegates.Executar},
                {"Delegade Como Função Anonima - Métodos e Funções", DelegateFuncAnonima.Executar},
                {"Delegades Como parametros - Métodos e Funções", DelegatesComoParametros.Executar},
                {"Métodos de Extensão - Métodos e Funções", MetodosDeExtensao.Executar},
            });
            central.SelecionarEExecutar();
        }
    }
}