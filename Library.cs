using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;
using System.Xml.Linq;

namespace Indexer__List__Namespace__ClassLibrary
{
    //    Libary class:

    public class Library
    {
        //~ Books - book listi
        private List<Book> Books = new List<Book>();

        //~ Library'e indexer yazırsınız. Set etmək olmur ancaq Get etmək olur
        public Book this[int index]
        {
            get => Books[index];
        }

        //~ AddBook() - parametr olaraq book qəbul edir və list`ə əlavə edir
        public void AddBook(Book book)
        {
            Books.Add(book);
        }

        //~ FindAllBooksByName() - parametr olaraq string value qəbul edir və adında həmin string value olan kitablardan ibarət list qaytarır
        public List<Book>? FindAllBooksByName(string? name)
        {
            if (string.IsNullOrEmpty(name)) return null;
            return Books.FindAll(x => x.Name.ToLower().Contains(name.ToLower()));
        }

        //~ FindBookByCode -  parametr olaraq string code qəbul edir və verilmiş kodlu kitabı geriyə qaytarır
        public Book? FindBookByCode(string? code)
        {
            if (string.IsNullOrEmpty(code)) return null;
            return Books.Find(x => x.Code == code);
        }

        //~ RemoveAllBooksByNme() - parametr olar string value qəbul edir və adında həmin string value olan kitabları silir
        public void RemoveAllBooksByName(string? name)
        {
            if (string.IsNullOrEmpty(name)) return;
            Books.RemoveAll(x => x.Name.ToLower().Contains(name.ToLower()));
        }

        //~ SearchBooks() - parametr olar string value qəbul edir və Name, AuthorName, PageCount dəyərlərindən hər hansı birində göndərilmiş string valuesı olan book-lardan ibarət list qaytarır.
        public List<Book>? SearchBooks(string? keyWord)
        {
            if (string.IsNullOrEmpty(keyWord)) return null;

            return Books.FindAll(x => x.Name.ToLower().Contains(keyWord.ToLower()) || (string.IsNullOrEmpty(x.AuthorName) ? false : x.AuthorName.ToLower().Contains(keyWord.ToLower())) || x.PageCount.ToString().Contains(keyWord));
        }

        //~ FindAllBooksByPageCountRange() - parametr olaraq iki int dəyər qəbul edir(minimum səhifə və maximum səhifə sayı kimi) və pagecount dəyəri həmin aralıqda olan book-lardan ibarət list qaytarır
        public List<Book> FindAllBooksByPageCountRange(int max, int min)
        {
            return Books.FindAll(x => x.PageCount >= min && x.PageCount <= max);
        }

        //~ RemoveBookByCode() - parametr olaraq string value qəbul edir və code-u həmin string value olan book-u silir
        public void RemoveBookByCode(string? code)
        {
            Books.RemoveAll(x => x.Code == code);
        }
    }
}
