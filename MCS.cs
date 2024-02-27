using System;

/*---BÁSICO---*/

class Program
{
    static void Main(string[] args)
    {
        // Variáveis
        string nome = "Carlos";
        int idade = 19;
        double altura = 1.85;

        // Saída com WriteLine
        Console.WriteLine($"Meu nome é {nome}, idade: {idade}");

        // Condição if
        if (idade >= 18)
        {
            Console.WriteLine("Maior de idade");
        }
        else
        {
            Console.WriteLine("Menor de idade");
        }

        // Condição switch
        string fruta = "maçã";
        switch (fruta)
        {
            case "maçã":
                Console.WriteLine("É uma maçã");
                break;
            case "banana":
                Console.WriteLine("É uma banana");
                break;
            default:
                Console.WriteLine("Fruta desconhecida");
                break;
        }

        // Array
        string[] carros = { "Gol", "Civic", "i320" };
        foreach (var carro in carros)
        {
            Console.WriteLine(carro);
        }

        // Funções
        string saudacao = GerarSaudacao("Maria");
        Console.WriteLine(saudacao);
    }

    // Definição de função
    static string GerarSaudacao(string nome)
    {
        return $"Olá, {nome}!";
    }

    using System;
}

/*---INTERMEDIÁRIO---*/

class Program
{
    static void Main(string[] args)
    {
        // Variáveis
        string nome = "Carlos";
        int idade = 19;
        double altura = 1.85;

        // Saída com WriteLine
        Console.WriteLine($"Meu nome é {nome}, idade: {idade}");

        // Condição if
        if (idade >= 18)
        {
            Console.WriteLine("Maior de idade");
        }
        else
        {
            Console.WriteLine("Menor de idade");
        }

        // Condição switch
        string fruta = "maçã";
        switch (fruta)
        {
            case "maçã":
                Console.WriteLine("É uma maçã");
                break;
            case "banana":
                Console.WriteLine("É uma banana");
                break;
            default:
                Console.WriteLine("Fruta desconhecida");
                break;
        }

        // Array
        string[] carros = { "Gol", "Civic", "i320" };
        foreach (var carro in carros)
        {
            Console.WriteLine(carro);
        }

        // Funções
        string saudacao = GerarSaudacao("Maria");
        Console.WriteLine(saudacao);

        // Classes e Objetos
        Pessoa pessoa1 = new Pessoa("João", 25);
        Console.WriteLine($"Nome: {pessoa1.Nome}, Idade: {pessoa1.Idade}");

        // Herança
        Estudante estudante1 = new Estudante("Ana", 20, "Engenharia");
        Console.WriteLine($"Nome: {estudante1.Nome}, Idade: {estudante1.Idade}, Curso: {estudante1.Curso}");
    }

    // Definição de função
    static string GerarSaudacao(string nome)
    {
        return $"Olá, {nome}!";
    }

    // Definição de Classe
    class Pessoa
    {
        // Propriedades
        public string Nome { get; set; }
        public int Idade { get; set; }

        // Construtor
        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }
    }

    // Herança
    class Estudante : Pessoa
    {
        // Nova Propriedade
        public string Curso { get; set; }

        // Novo Construtor
        public Estudante(string nome, int idade, string curso) : base(nome, idade)
        {
            Curso = curso;
        }
    }
}

/*---INTEMEDIÁRIO---*/

using System;

// Definição da classe Point
class Point
{
    // Propriedades
    public string Produto { get; set; }
    public double Preco { get; set; }

    // Construtor
    public Point(string produto, double preco)
    {
        Produto = produto;
        Preco = preco;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // DateTime
        // Usa a data de hoje como referência
        int anoAtual = DateTime.Now.Year;
        Console.WriteLine($"Ano atual: {anoAtual}");

        // Tipos de Valor vs Tipos de Referência
        // Exemplo de tipo de valor (struct)
        int a = 10;
        int b = a; // Cria uma cópia independente de 'a'
        b = 20; // Alterações em 'b' não afetam 'a'

        // Exemplo de tipo de referência (classe)
        Point p1 = new Point("TV", 900.0);
        Point p2 = new Point("Radio", 50.0);
        p1 = p2; // Ambos p1 e p2 referenciam os mesmos dados

        // Garbage Collector
        // Automatiza o gerenciamento de memória, desalocando objetos não utilizados

        // Desalocação por Escopo
        // Dados são excluídos quando saem do escopo
        int Metodo1()
        {
            int x = 10;
            if (x > 10)
            {
                int y = 5; // Será excluído ao sair do if
            }
            Console.WriteLine(x);
            return x;
        }

        // This
        // Usado para referenciar os objetos da classe
        class Pessoa
        {
            public string Nome;
            public int Idade;

            public Pessoa()
            {
                this.Nome = "Desconhecido";
                this.Idade = 0;
            }

            public Pessoa(string nome)
            {
                this.Nome = nome;
                this.Idade = 0;
            }
        }

        // Método Construtor
        // Define padrões para os objetos quando são criados vazios
        class Carro
        {
            public string Modelo { get; set; }
            public int Ano { get; set; }

            public Carro()
            {
                Modelo = "Desconhecido";
                Ano = 0;
            }

            public Carro(string modelo, int ano)
            {
                Modelo = modelo;
                Ano = ano;
            }
        }

        // Classes Estáticas
        // Podem ser usadas em todo o projeto sem a necessidade de criar instâncias
        // Todos os seus membros devem ser estáticos
        // Não podem ser criados objetos a partir dessa classe
        static class Calculadora
        {
            public static double Taxa;

            public static double Adicionar(double num)
            {
                return num + Taxa;
            }

            public static double Subtrair(double num)
            {
                return num - Taxa;
            }
        }

        // Classes Parciais
        // Usadas para dividir uma classe em várias partes
        // Todas as partes devem ser marcadas como partial
        partial class Pessoa
        {
            // Outras partes da classe Pessoa
        }

        // Encapsulamento
        // Esconde operações complexas e expõe operações básicas
        // Todos os atributos devem ser privados
        class ContaBancaria
        {
            private double saldo;

            public double Saldo
            {
                get { return saldo; }
                private set { saldo = value; }
            }

            public void Depositar(double valor)
            {
                Saldo += valor;
            }

            public void Sacar(double valor)
            {
                Saldo -= valor;
            }
        }

        // Propriedades Autoimplementadas
        // Substitui os métodos de acessar valores em objetos
        // Caso o atributo tenha alguma lógica a parte, não pode usar propriedades autoimplementadas
        class Pessoa2
        {
            public string Nome { get; set; }
            public int Idade { get; set; }
        }

        // Classes Parciais
        // Usadas para dividir uma classe em várias partes
        // Todas as partes devem ser marcadas como partial
        partial class Pessoa
        {
            // Outras partes da classe Pessoa
        }

        // Exemplo de uso das classes e funcionalidades
        Calculadora.Taxa = 10;
        double valorAdicionado = Calculadora.Adicionar(100);
        Console.WriteLine($"Valor adicionado: {valorAdicionado}");

        // Fim do programa
        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}


  
}
