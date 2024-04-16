namespace SecThirteen.Exemples
{
    internal class Using
    {

        //string path = @"C:\dev\C#\Udemy\C#_POO\SecThirteen\Assets\file1.txt";

        //FileStream e StreamReader não gerenciado pelo CLR. Necessário fechar manualmente, a menos que seja
        //utilizado o bloco USING, conforme abaixo:

        //try
        //{
            //using (FileStream fs = new FileStream(path, FileMode.Open))
            //{
            //    using (StreamReader sr = new StreamReader(fs))
            //    {
            //        while (!sr.EndOfStream)
            //        {
            //            string line = sr.ReadLine();
            //            Console.WriteLine(line);
            //        }
            //    }
            //}

            //opção encadeando o FileStream implicitamente:
        //    using (StreamReader sr = File.OpenText(path))
        //    {
        //        while (!sr.EndOfStream)
        //        {
        //            string line = sr.ReadLine();
        //        Console.WriteLine(line);
        //        }
        //}
        //}
        //catch (IOException e)
        //{
        //    Console.WriteLine("An error occurred!");
        //Console.WriteLine(e.Message);
        //}

    }
}
