using System;
using SRP;
using System.Collections.Generic;

namespace SRP;
public class BookAndShelve
{
  private static ShelveBook shelve1, shelve2;
  private static Book book1, book2;
  public Dictionary<List<string>,List<string>> BooksWithShelves {get; set;}
  public BookAndShelve(Dictionary<List<string>,List<string>> BooksWithShelves)
  {
    this.BooksWithShelves= BooksWithShelves;
  }
}
  

