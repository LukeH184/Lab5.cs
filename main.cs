using System;

class Program {
  public static void Main (string[] args) {
    Item [] item_storage = new Item [5];
    string choice;
    for (int i = 0; i < 5; i++){
      Console.WriteLine("Please enter B for Book or P for Periodical");
      choice = Console.ReadLine();
      if((choice == "B" ) || (choice == "b")){
        Console.WriteLine("Please enter the name of the Book");
        string a = Console.ReadLine();
        Console.WriteLine("Please enter the author of the Book");
        string b = Console.ReadLine();
        Console.WriteLine("Please enter the ISBN of the Book");
        long c = Convert.ToInt64(Console.ReadLine());
        item_storage[i] = new Book(a, b, c);
      }
      if((choice == "P") || (choice == "p")){
        Console.WriteLine("Please enter the name of Periodical");
        string d = Console.ReadLine();
        Console.WriteLine("Please enter the issue number");
        int e = Convert.ToInt32(Console.ReadLine());
        item_storage[i] = new Periodical(d, e);
      }
    }
    Console.WriteLine("Your Items:");
    for (int i = 0; i < 5; i++){
      Item index = item_storage[i];
      Console.WriteLine(index.getListing());
      Console.WriteLine();
    }
  }

  abstract class Item {
    private string title;
    public Item(){
      title = null;
    }
    public Item(string s){
      title = s;
    }
    public void setTitle(string s){
      title = s;
    }
    public string getTitle(){
      return title;
    }
    abstract public string getListing();
    public override string ToString(){
      return title;
    }
  }

  class Book : Item {
    private long isbn_numer;
    private string author;
    public Book(){
      isbn_numer = 0000000000000;
      author = null;
    }
    public Book(string s, string a, long n){
      base.setTitle(s);
      isbn_numer = n;
      author = a;
    }
    public void setNum(long x){
      isbn_numer = x;
    }
    public long getNum(){
      return isbn_numer;
    }
    public void setAuthor(string s){
      author = s;
    }
    public string getAuthor(){
      return author;
    }
    public override string getListing(){
      return "Book Name - " + base.getTitle() + ", Author - " + author + ", ISBN # - " + isbn_numer; 
    }
  }
  class Periodical : Item {
    private int issueNum;
    public Periodical(){
      issueNum = 0;
    }
    public Periodical(string s, int n){
      base.setTitle(s);
      issueNum = n;
    }
    public void setIssueNum(int n){
      issueNum = n;
    }
    public int getIssueNum(){
      return issueNum;
    }
    public override string getListing(){
      return "Periodical Title - " + base.getTitle() + ", Issue # - " + issueNum;
    }
  }
}