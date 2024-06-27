namespace HelloWorld
{
    class Carro
    {
        public void Ligar()
        {
           Console.WriteLine("Carro ligado");
        }

        /* public - qualquer outra classe que tiver uma instância 
         * dessa classe pode acessar esse método
         */
        public void Desligar()
        {
            Console.WriteLine("Carro desligado");
        }

        /* private - apenas a própria classe pode acessar esse método
         */
        private void Teste1()
        {
            Console.WriteLine("Teste 1");
        }

        /* internal - apenas as classes do mesmo projeto podem acessar esse método
         */
        internal void Teste2()
        {
            Teste1();

            Console.WriteLine("Teste 2");
        }
    }
}
