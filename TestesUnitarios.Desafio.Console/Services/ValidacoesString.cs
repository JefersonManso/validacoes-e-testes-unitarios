namespace TestesUnitarios.Desafio.Console.Services
{
    // Classe responsável por validações de strings
    public class ValidacoesString
    {
        // Retorna a quantidade de caracteres em uma string
        public int RetornarQuantidadeCaracteres(string texto)
        {
            // Obtém o comprimento da string
            var numeroCaracteres = texto.Length;
            return numeroCaracteres;
        }


        // Verifica se uma string contém um determinado caractere ou substring
        public bool ContemCaractere(string texto, string textoProcurado)
        {
            // Verifica se o texto contém o textoProcurado
            var contem = texto.Contains(textoProcurado);
            return contem;
        }

        // Verifica se uma string começa com um determinado caractere ou substring

        public bool TextoTerminaCom(string texto, string textoProcurado)
        {
            // Verifica se o texto termina com o textoProcurado
            var termina = texto.EndsWith(textoProcurado);
            return termina;
        }
    }
}