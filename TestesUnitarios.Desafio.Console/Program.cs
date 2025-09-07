using System;
using System.Collections.Generic;
using TestesUnitarios.Desafio.Console.Services;

namespace TestesUnitarios.Desafio.Console
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Apenas para compilar, não precisa ter lógica
            System.Console.WriteLine("Projeto Console pronto para compilar.");
        }
    }
}




//--------------- TESTES DE CONSOLE PARA VALIDACOES DE LISTAS -----------------//


/*-------------- DeveRemoverNumerosNegativosDeUmaLista -----------------------*/

// ValidacoesLista validacoes = new ValidacoesLista();

// List<int> listaNumeros = new List<int> { 5, -1, -8, 9 };

// var listaSemNegativos = validacoes.RemoverNumerosNegativos(listaNumeros);

// Console.WriteLine("Apenas Positivos: " + string.Join(", ", listaSemNegativos));

// ------------------------------------------------------------------------------//

/*------------------ DeveConterONumero9NaLista ----------------------------------*/

// ValidacoesLista validacoes = new ValidacoesLista();
// List<int> listaNumeros = new List<int> { 5, -1, -8, 9 };

// int numeroParaProcurar = 9;

// bool resultado = validacoes.ListaContemDeterminadoNumero(listaNumeros, numeroParaProcurar);

// if (resultado)
// {
//     Console.WriteLine($"A lista contém o número {numeroParaProcurar}.");
// }
// else
// {
//     Console.WriteLine($"A lista não contém o número {numeroParaProcurar}.");
// }
// -----------------------------------------------------------------------------------//

/*------------------ NaoDeveConterONumero10NaLista ----------------------------------*/

// ValidacoesLista validacoes = new ValidacoesLista();
// List<int> lista = new List<int> { 5, -1, -8, 9 };

// int numeroParaProcurar = 10;
// bool resultado = validacoes.ListaContemDeterminadoNumero(lista, numeroParaProcurar);

// if (resultado)
// {
//     Console.WriteLine($"A lista contém o número {numeroParaProcurar}.");
// }
// else
// {
//     Console.WriteLine($"A lista não contém o número {numeroParaProcurar}.");
// }
// ---------------------------------------------------------------------------------//


/*------------------ DeveMultiplicarOsElementosDaListaPor2 -----------------------*/

// ValidacoesLista validacoes = new ValidacoesLista();
// var lista = new List<int> { 5, 7, 8, 9 };
// var resultadoEsperado = new List<int> { 10, 14, 16, 18 };
// var resultado = validacoes.MultiplicarNumerosLista(lista, 2);

// Console.WriteLine("Lista Original: " + string.Join(", ", lista));
// Console.WriteLine("Lista Multiplicada por 2: " + string.Join(", ", resultado));
// Console.WriteLine("Resultado Esperado: " + string.Join(", ", resultadoEsperado));
// -----------------------------------------------------------------------------------//


/*------------------ DeveRetornar9ComoMaiorNumeroDaLista ------------------------------*/

// ValidacoesLista validacoes = new ValidacoesLista();
// var lista = new List<int> { 5, -1, -8, 9 };
// int resultado = validacoes.RetornarMaiorNumeroLista(lista);

// Console.WriteLine($"Lista: {string.Join(", ", lista)}");
// Console.WriteLine($"Maior Número da Lista: {resultado}"); // Deve retornar 9
// ---------------------------------------------------------------------------------------//


/*------------------ DeveRetornarOitoNegativoComoMenorNumeroDaLista -----------------------*/
// ValidacoesLista validacoes = new ValidacoesLista();
// var lista = new List<int> { 5, -1, -8, 9 };

// int resultado = validacoes.RetornarMenorNumeroLista(lista);

// Console.WriteLine($"Lista: {string.Join(", ", lista)}");
// Console.WriteLine($"Menor Número da Lista: {resultado}"); // Deve retornar -8
// ----------------------------------------------------------------------------------------//

/* ----- DeveRetornar6QuantidadeCaracteresDaPalavraMatrix ----------------------------------*/

// ValidacoesString validacoes = new ValidacoesString();
// var texto = "Matrix";

// int resultado = validacoes.RetornarQuantidadeCaracteres(texto);
// Console.WriteLine($"Texto: {texto}");
// Console.WriteLine($"Quantidade de Caracteres: {resultado}"); // Deve retornar 6
// ----------------------------------------------------------------------------------------//

/* ------------------ DeveContemAPalavraQualquerNoTexto ----------------------------------*/

// ValidacoesString validacoes = new ValidacoesString();
// var texto = "Esse é um texto qualquer";
// var textoProcurado = "qualquer";

// bool resultado = validacoes.ContemCaractere(texto, textoProcurado);

// Console.WriteLine($"Texto: {texto}");
// Console.WriteLine($"Contém '{textoProcurado}': {resultado}"); // Deve retornar True
// ----------------------------------------------------------------------------------------//

/* ------------------ NaoDeveConterAPalavraTesteNoTexto ----------------------------------*/

// ValidacoesString validacoes = new ValidacoesString();
// var texto = "Esse é um texto qualquer";
// var textoProcurado = "teste";
// bool resultado = validacoes.ContemCaractere(texto, textoProcurado);

// Console.WriteLine($"Texto: {texto}");
// Console.WriteLine($"Contém '{textoProcurado}': {resultado}"); // Deve retornar False
// ----------------------------------------------------------------------------------------//

/* ------------------ TextoDeveTerminarComAPalavraProcurado ----------------------------------*/
// ValidacoesString validacoes = new ValidacoesString();
// var texto = "Começo, meio e fim do texto procurado";

// var textoProcurado = "procurado";

// bool resultado = validacoes.TextoTerminaCom(texto, textoProcurado);

// Console.WriteLine($"Texto: {texto}");
// Console.WriteLine($"Termina com '{textoProcurado}': {resultado}"); // Deve retornar True
// ----------------------------------------------------------------------------------------//


