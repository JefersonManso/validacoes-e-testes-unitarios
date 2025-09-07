namespace TestesUnitarios.Desafio.Console.Services
{
    // Classe reponsável por operações em listas de números inteiros
    public class ValidacoesLista
    {
        // Remove números negativos de uma lista
        public List<int> RemoverNumerosNegativos(List<int> lista)
        {
            // Filtra a lista para incluir apenas números maiores que zero
            var listaSemNegativos = lista.Where(x => x > 0);
            // Converte o resultado filtrado de volta para uma lista e retorna
            return listaSemNegativos.ToList();
        }


        // Verifica se a lista contém um número específico
        public bool ListaContemDeterminadoNumero(List<int> lista, int numero)
        {
            // Usa o método Contains para verificar a presença do número na lista
            var contem = lista.Contains(numero);
            return contem;
        }


        // Multiplica cada número na lista por um número fornecido
        public List<int> MultiplicarNumerosLista(List<int> lista, int numero)
        {
            // Usa o método Select para multiplicar cada elemento da lista pelo número fornecido
            var listaMultiplicada = lista.Select(x => x * numero).ToList();
            return listaMultiplicada;
        }


        // Retorna o maior número da lista
        public int RetornarMaiorNumeroLista(List<int> lista)
        {
            return lista.Max();
        }

        
        // Retorna o menor número da lista
        public int RetornarMenorNumeroLista(List<int> lista)
        {
            return lista.Min();
        }
    }
}
