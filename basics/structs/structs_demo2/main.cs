using System;
using System.Text;

struct Books {
  public string title;
  public string author;
  public string subject;
  public int book_id;

  public void setValues(string t, string a, string s, int id) {
    title = t;
    author = a;
    subject = s;
    book_id = id;
  }

  public void display() {
		Console.WriteLine("title : {0}", title);
		Console.WriteLine("author : {0}", author);
		Console.WriteLine("subject : {0}", subject);
		Console.WriteLine("book_id :{0}", book_id);
  }
};

public class testStructure {
  public static void Main(string[] args) {
    Books Book1 = new Books();
    Books Book2 = new Books();

    /* book 1 详述 */
    Book1.setValues("C Programming",
        "Nuha Ali", "C Programming Tutorial",6495407);

    /* book 2 详述 */
    Book2.setValues("Telecom Billing",
        "Zara Ali", "Telecom Billing Tutorial", 6495700);

    /* 打印 Book1 信息 */
    Book1.display();

    /* 打印 Book2 信息 */
    Book2.display();
  }
}
