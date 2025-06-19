using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BottomSheetSample
{
    public class BookViewModel
    {
        private ObservableCollection<Book>? _books;

        public ObservableCollection<Book>? Books
        {
            get => _books;
            set
            {
                _books = value;
            }
        }

        public BookViewModel()
        {
            Books = new ObservableCollection<Book>
        {
            new Book
            {
                Title = "Object-Oriented Programming in C#",
                Genre = "Programming, Software Development",
                Published = "July 2023",
                Description = "Object-oriented programming is a programming paradigm based on the concept of objects",
                Rating = 4.7,
                Price = 49.99M
            },
            new Book
            {
                Title = "C# Code Contracts",
                Genre = "Programming",
                Published = "March 2019",
                Description = "Code Contracts provide a way to convey code assumptions",
                Rating = 4.8,
                Price = 39.99M
            },
            new Book
            {
                Title = "Machine Learning Using C#",
                Genre = "Programming, Software Engineering",
                Published = "August 2008",
                Description = "You will learn several different approaches to applying machine learning",
                Rating = 4.7,
                Price = 34.99M
            },
            new Book
            {
                Title = "Neural Networks Using C#",
                Genre = "Programming",
                Published = "October 1999",
                Description = "Neural networks are an exciting field of software development",
                Rating = 4.9,
                Price = 49.99M
            },
            new Book
            {
                Title = "Visual Studio Code",
                Genre = "Software Development",
                Published = "November 2018",
                Description = "It is a powerful tool for editing code and serves for end-to-end programming",
                Rating = 4.6,
                Price = 45.99M
            },
            new Book
            {
                Title = "Android Programming",
                Genre = "Algorithms, Computer Science",
                Published = "July 2009",
                Description = "It provides a useful overview of the Android application life cycle",
                Rating = 4.5,
                Price = 94.99M
            },
            new Book
            {
                Title = "iOS Succinctly",
                Genre = "Software Design",
                Published = "October 1994",
                Description = "It is for developers looking to step into frightening world of iPhone",
                Rating = 4.8,
                Price = 54.99M
            },
            new Book
            {
                Title = "Visual Studio 2015",
                Genre = "Programming, Software Design",
                Published = "October 2004",
                Description = "The new version of the widely-used integrated development environment",
                Rating = 4.7,
                Price = 44.99M
            },
            new Book
            {
                Title = "Xamarin.Forms",
                Genre = "Software Design, Software Engineering",
                Published = "August 2003",
                Description = "It creates mappings from its C# classes and controls directly",
                Rating = 4.6,
                Price = 49.99M
            },
            new Book
            {
                Title = "Windows Store Apps",
                Genre = "Programming, Web Development",
                Published = "March 2023",
                Description = "Windows Store apps present a radical shift in Windows development",
                Rating = 4.9,
                Price = 59.99M
            }
        };
        }
    }
}
