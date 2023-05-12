﻿using Microsoft.EntityFrameworkCore;
using PioneerOnlineLibrary.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PioneerOnlineLibrary.Core.Data
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasData(new Book { BookId = 2,ImageURL = "http://res.cloudinary.com/dresodocz/image/upload/jwbgka7d6f9mvzipj9rn", Author = "Aaron Blabey", Description = "The Latin cogito, ergo sum, usually translated into English as \"I think, therefore I am\", is the \"first principle\" of René Descartes's philosophy. He originally published it in French as je pense, donc je suis in his 1637 Discourse on the Method, so as to reach a wider audience than Latin would have allowed. It later appeared in Latin in his Principles of Philosophy, and a similar phrase also featured prominently in his Meditations on First Philosophy.", Genre = "Comedy", Title = "The Bad Guys", ISBN = "978-0545912402", Price = 19, Pages = 100, IsAvailable = true, Publisher = "Scholastic Press", PublicationDate = "26-11-2016", BookCategory = "Most Recent", Language = "English"},
                new Book { BookId = 3, ImageURL = "http://res.cloudinary.com/dresodocz/image/upload/jwbgka7d6f9mvzipj9rn", Author = "Aaron Blabey", Description = "The Latin cogito, ergo sum, usually translated into English as \"I think, therefore I am\", is the \"first principle\" of René Descartes's philosophy. He originally published it in French as je pense, donc je suis in his 1637 Discourse on the Method, so as to reach a wider audience than Latin would have allowed. It later appeared in Latin in his Principles of Philosophy, and a similar phrase also featured prominently in his Meditations on First Philosophy.", Genre = "Comedy", Title = "The Bad Guys", ISBN = "978-0545912402", Price = 19, Pages = 100, IsAvailable = true, Publisher = "Scholastic Press", PublicationDate = "26-11-2016", BookCategory = "Most Recent", Language = "English" },
                new Book { BookId = 4, ImageURL = "http://res.cloudinary.com/dresodocz/image/upload/jwbgka7d6f9mvzipj9rn", Author = "Aaron Blabey", Description = "The Latin cogito, ergo sum, usually translated into English as \"I think, therefore I am\", is the \"first principle\" of René Descartes's philosophy. He originally published it in French as je pense, donc je suis in his 1637 Discourse on the Method, so as to reach a wider audience than Latin would have allowed. It later appeared in Latin in his Principles of Philosophy, and a similar phrase also featured prominently in his Meditations on First Philosophy.", Genre = "Comedy", Title = "The Bad Guys", ISBN = "978-0545912402", Price = 19, Pages = 100, IsAvailable = true, Publisher = "Scholastic Press", PublicationDate = "26-11-2016", BookCategory = "Most Recent", Language = "English" },
                new Book { BookId = 5, ImageURL = "http://res.cloudinary.com/dresodocz/image/upload/jwbgka7d6f9mvzipj9rn", Author = "Aaron Blabey", Description = "The Latin cogito, ergo sum, usually translated into English as \"I think, therefore I am\", is the \"first principle\" of René Descartes's philosophy. He originally published it in French as je pense, donc je suis in his 1637 Discourse on the Method, so as to reach a wider audience than Latin would have allowed. It later appeared in Latin in his Principles of Philosophy, and a similar phrase also featured prominently in his Meditations on First Philosophy.", Genre = "Comedy", Title = "The Bad Guys", ISBN = "978-0545912402", Price = 19, Pages = 100, IsAvailable = true, Publisher = "Scholastic Press", PublicationDate = "26-11-2016", BookCategory = "Most Recent", Language = "English" },
                new Book { BookId = 6, ImageURL = "http://res.cloudinary.com/dresodocz/image/upload/jwbgka7d6f9mvzipj9rn", Author = "Aaron Blabey", Description = "The Latin cogito, ergo sum, usually translated into English as \"I think, therefore I am\", is the \"first principle\" of René Descartes's philosophy. He originally published it in French as je pense, donc je suis in his 1637 Discourse on the Method, so as to reach a wider audience than Latin would have allowed. It later appeared in Latin in his Principles of Philosophy, and a similar phrase also featured prominently in his Meditations on First Philosophy.", Genre = "Comedy", Title = "The Bad Guys", ISBN = "978-0545912402", Price = 19, Pages = 100, IsAvailable = true, Publisher = "Scholastic Press", PublicationDate = "26-11-2016", BookCategory = "Most Recent", Language = "English" },
                new Book { BookId = 7, ImageURL = "http://res.cloudinary.com/dresodocz/image/upload/jwbgka7d6f9mvzipj9rn", Author = "Aaron Blabey", Description = "The Latin cogito, ergo sum, usually translated into English as \"I think, therefore I am\", is the \"first principle\" of René Descartes's philosophy. He originally published it in French as je pense, donc je suis in his 1637 Discourse on the Method, so as to reach a wider audience than Latin would have allowed. It later appeared in Latin in his Principles of Philosophy, and a similar phrase also featured prominently in his Meditations on First Philosophy.", Genre = "Comedy", Title = "The Bad Guys", ISBN = "978-0545912402", Price = 19, Pages = 100, IsAvailable = true, Publisher = "Scholastic Press", PublicationDate = "26-11-2016", BookCategory = "Most Recent", Language = "English" },
                new Book { BookId = 8, ImageURL = "http://res.cloudinary.com/dresodocz/image/upload/jwbgka7d6f9mvzipj9rn", Author = "Aaron Blabey", Description = "The Latin cogito, ergo sum, usually translated into English as \"I think, therefore I am\", is the \"first principle\" of René Descartes's philosophy. He originally published it in French as je pense, donc je suis in his 1637 Discourse on the Method, so as to reach a wider audience than Latin would have allowed. It later appeared in Latin in his Principles of Philosophy, and a similar phrase also featured prominently in his Meditations on First Philosophy.", Genre = "Comedy", Title = "The Bad Guys", ISBN = "978-0545912402", Price = 19, Pages = 100, IsAvailable = true, Publisher = "Scholastic Press", PublicationDate = "26-11-2016", BookCategory = "Most Recent", Language = "English" },
                new Book { BookId = 9, ImageURL = "http://res.cloudinary.com/dresodocz/image/upload/jwbgka7d6f9mvzipj9rn", Author = "Aaron Blabey", Description = "The Latin cogito, ergo sum, usually translated into English as \"I think, therefore I am\", is the \"first principle\" of René Descartes's philosophy. He originally published it in French as je pense, donc je suis in his 1637 Discourse on the Method, so as to reach a wider audience than Latin would have allowed. It later appeared in Latin in his Principles of Philosophy, and a similar phrase also featured prominently in his Meditations on First Philosophy.", Genre = "Comedy", Title = "The Bad Guys", ISBN = "978-0545912402", Price = 19, Pages = 100, IsAvailable = true, Publisher = "Scholastic Press", PublicationDate = "26-11-2016", BookCategory = "Most Recent", Language = "English" },
                new Book { BookId = 10, ImageURL = "http://res.cloudinary.com/dresodocz/image/upload/jwbgka7d6f9mvzipj9rn", Author = "Aaron Blabey", Description = "The Latin cogito, ergo sum, usually translated into English as \"I think, therefore I am\", is the \"first principle\" of René Descartes's philosophy. He originally published it in French as je pense, donc je suis in his 1637 Discourse on the Method, so as to reach a wider audience than Latin would have allowed. It later appeared in Latin in his Principles of Philosophy, and a similar phrase also featured prominently in his Meditations on First Philosophy.", Genre = "Comedy", Title = "The Bad Guys", ISBN = "978-0545912402", Price = 19, Pages = 100, IsAvailable = true, Publisher = "Scholastic Press", PublicationDate = "26-11-2016", BookCategory = "Most Recent", Language = "English" },
                new Book { BookId = 11, ImageURL = "http://res.cloudinary.com/dresodocz/image/upload/jwbgka7d6f9mvzipj9rn", Author = "Aaron Blabey", Description = "The Latin cogito, ergo sum, usually translated into English as \"I think, therefore I am\", is the \"first principle\" of René Descartes's philosophy. He originally published it in French as je pense, donc je suis in his 1637 Discourse on the Method, so as to reach a wider audience than Latin would have allowed. It later appeared in Latin in his Principles of Philosophy, and a similar phrase also featured prominently in his Meditations on First Philosophy.", Genre = "Comedy", Title = "The Bad Guys", ISBN = "978-0545912402", Price = 19, Pages = 100, IsAvailable = true, Publisher = "Scholastic Press", PublicationDate = "26-11-2016", BookCategory = "Most Recent", Language = "English" },
                new Book { BookId = 12, ImageURL = "http://res.cloudinary.com/dresodocz/image/upload/jwbgka7d6f9mvzipj9rn", Author = "Aaron Blabey", Description = "The Latin cogito, ergo sum, usually translated into English as \"I think, therefore I am\", is the \"first principle\" of René Descartes's philosophy. He originally published it in French as je pense, donc je suis in his 1637 Discourse on the Method, so as to reach a wider audience than Latin would have allowed. It later appeared in Latin in his Principles of Philosophy, and a similar phrase also featured prominently in his Meditations on First Philosophy.", Genre = "Comedy", Title = "The Bad Guys", ISBN = "978-0545912402", Price = 19, Pages = 100, IsAvailable = true, Publisher = "Scholastic Press", PublicationDate = "26-11-2016", BookCategory = "Most Recent", Language = "English" },
                new Book { BookId = 13, ImageURL = "http://res.cloudinary.com/dresodocz/image/upload/jwbgka7d6f9mvzipj9rn", Author = "Aaron Blabey", Description = "The Latin cogito, ergo sum, usually translated into English as \"I think, therefore I am\", is the \"first principle\" of René Descartes's philosophy. He originally published it in French as je pense, donc je suis in his 1637 Discourse on the Method, so as to reach a wider audience than Latin would have allowed. It later appeared in Latin in his Principles of Philosophy, and a similar phrase also featured prominently in his Meditations on First Philosophy.", Genre = "Comedy", Title = "The Bad Guys", ISBN = "978-0545912402", Price = 19, Pages = 100, IsAvailable = true, Publisher = "Scholastic Press", PublicationDate = "26-11-2016", BookCategory = "Most Recent", Language = "English" },
                new Book { BookId = 14, ImageURL = "http://res.cloudinary.com/dresodocz/image/upload/jwbgka7d6f9mvzipj9rn", Author = "Aaron Blabey", Description = "The Latin cogito, ergo sum, usually translated into English as \"I think, therefore I am\", is the \"first principle\" of René Descartes's philosophy. He originally published it in French as je pense, donc je suis in his 1637 Discourse on the Method, so as to reach a wider audience than Latin would have allowed. It later appeared in Latin in his Principles of Philosophy, and a similar phrase also featured prominently in his Meditations on First Philosophy.", Genre = "Comedy", Title = "The Bad Guys", ISBN = "978-0545912402", Price = 19, Pages = 100, IsAvailable = true, Publisher = "Scholastic Press", PublicationDate = "26-11-2016", BookCategory = "Most Recent", Language = "English" },
                new Book { BookId = 15, ImageURL = "http://res.cloudinary.com/dresodocz/image/upload/jwbgka7d6f9mvzipj9rn", Author = "Aaron Blabey", Description = "The Latin cogito, ergo sum, usually translated into English as \"I think, therefore I am\", is the \"first principle\" of René Descartes's philosophy. He originally published it in French as je pense, donc je suis in his 1637 Discourse on the Method, so as to reach a wider audience than Latin would have allowed. It later appeared in Latin in his Principles of Philosophy, and a similar phrase also featured prominently in his Meditations on First Philosophy.", Genre = "Comedy", Title = "The Bad Guys", ISBN = "978-0545912402", Price = 19, Pages = 100, IsAvailable = true, Publisher = "Scholastic Press", PublicationDate = "26-11-2016", BookCategory = "Most Recent", Language = "English" },
                new Book { BookId = 16, ImageURL = "http://res.cloudinary.com/dresodocz/image/upload/jwbgka7d6f9mvzipj9rn", Author = "Aaron Blabey", Description = "The Latin cogito, ergo sum, usually translated into English as \"I think, therefore I am\", is the \"first principle\" of René Descartes's philosophy. He originally published it in French as je pense, donc je suis in his 1637 Discourse on the Method, so as to reach a wider audience than Latin would have allowed. It later appeared in Latin in his Principles of Philosophy, and a similar phrase also featured prominently in his Meditations on First Philosophy.", Genre = "Comedy", Title = "The Bad Guys", ISBN = "978-0545912402", Price = 19, Pages = 100, IsAvailable = true, Publisher = "Scholastic Press", PublicationDate = "26-11-2016", BookCategory = "Most Recent", Language = "English" }
                );


        }
    }
}
