class Book { //? Definindo classe

  //? Definindo Variáveis
  public string name;
  public int pages;
  public bool physicalBook;
  //* public → Acessado de qualquer lugar.
  //* private → Acessado dentro da própria classe.
  //* protected → Acessado na classe e em classes herdadas.
  //* internal → Acessado dentro do projeto.

  //? Iniciando Construtor
  public Book(string name, int pages, bool physicalBook)
  {
      this.name = name;
      this.pages = pages;
      this.physicalBook = physicalBook;
  }

  //? Iniciando Método
  public double FinishBookTime() {
      double speed = physicalBook ? 1.0 : 1.5;
      double totalMinutes = pages / speed;
      return totalMinutes / 60;
  }
}

//? Iniciando Main e rodando as funções
class Program{
    static void Main() {
        Book firstBook = new Book("1984", 328, true);
        Console.WriteLine($"Tempo estimado para terminar {firstBook.name} é de: {firstBook.FinishBookTime()} horas");
        //! Resposta => Tempo estimado para terminar 1984 é de: 5,466666666666667 horas.
    }
}