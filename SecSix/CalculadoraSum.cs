namespace SecSix
{
    public class CalculadoraSum
    {

        //SUPONHA QUE SE QUEIRA CALCULAR A SOMA DE UMA QUANTIDADE VARIÁVEL 
        //DE VALORES.

        //A SOLUÇÃO RUIM SERIA CRIAR VÁRIAS SOBRECARGAS DE MÉTODOS
        //CONFORME ABAIXO:

        class CalculatorSum
        {
            public static int Sum(int n1, int n2)
            {
                return n1 + n2;
            }
            public static int Sum(int n1, int n2, int n3)
            {
                return n1 + n2 + n3;
            }
            public static int Sum(int n1, int n2, int n3, int n4)
            {
                return n1 + n2 + n3 + n4;
            }
        }

        //OUTRA SOLUÇÃO SERIA CRIAR UMA FUNÇÃO COM O TAMANHO DE UM VETOR DE PARAMETRO.

        //public static int Sum(int[] numbers) //PARA CHAMAR BASTA, INSTANCIAR O VETOR DIRETO NO ARGUMENTO,
        //INFORMANDO OS VALORES A SEEREM SOMADOS.
        //{
        //    int sum = 0;
        //    for (int i = 0; i < numbers.Length; i++)
        //    {
        //        sum += numbers[i];
        //    }
        //    return sum;
        //}

        //CHAMADA: Variavel.Sum(new int[] {2, 3});

        //UMA BOA SOLUÇÃO SERIA UTILIZAR PARAMS
        public static int Sum(params int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }

        //CHAMADA: Variavel.Sum(2, 3);


        //-------------------------------------------------------------------------------------------------

        //REF E OUT

        //Diferença: 
        // - A variável passada como parâmetro REF deve ter sido iniciada
        // - A variável passada como parâmetro OUT não precisa ter sido iniciada. 

        //LISTA;

        List<string> list = new List<string>();

        public void test ()
        {
            list.Add("Leandro");//Adição de valores na ultima posição (padrao).
            list.Insert(1, "Marcos");//Adição de valores na posição escolhida.
            list.Count();//Retorna o tamanho da lista. 

            string s1 = list.Find(x => x[0] == 'A');//captura o primeiro resultado que começa com "A"
            string s2 = list.FindLast(x => x[0] == 'A');//captura o ultimo resultado que começa com "A"
            int pos1 = list.FindIndex(x => x[0] == 'A');//captura o primeiro index, cujo valor começa com "A"
            int pos2 = list.FindLastIndex(x => x[0] == 'A');//captura o ultimo index, cujo valor começa com "A"

            List<string> list2 = list.FindAll(x => x.Length == 5);//insere em outra lista todos valores que tenham 5 carac.
            list.Remove("Marcos");//Remove da lista o campo digitado, de acordo com o tipo. 
            list.RemoveAll(x => x[0] == 'M');//remove todos os valores que começam com M. 
            list.RemoveAt(2);//remove pelo index.
            list.RemoveRange(2, 2);//remove a partir da arg1, o número de carac de arg2;

        }




    }
}
