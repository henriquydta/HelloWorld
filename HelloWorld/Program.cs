using HelloWorld.Teste;

namespace HelloWorld
{
    class Program
    {
        static void Main()
        {
            // type - name - assignment - new - constructor
            Carro meuCarro = new Carro();

            meuCarro.Ligar();

            meuCarro.Desligar();

            meuCarro.Teste2();

            Biscoito meuBiscoito = new Biscoito();

            meuBiscoito.Temperatura();
        }
    }
}
