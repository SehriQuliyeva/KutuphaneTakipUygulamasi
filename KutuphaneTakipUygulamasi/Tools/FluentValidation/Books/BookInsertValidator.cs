using System;
using KutuphaneTakipUygulamasi.Objects.Books;
using System.Collections.Generic;
using System.Linq;
using FluentValidation;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneTakipUygulamasi.Tools.FluentValidation.Books
{
    public class BookInsertValidator : AbstractValidator<InsertBook>
    {
        public BookInsertValidator()
        {
            RuleFor(b => b.BookName).
                NotEmpty().MaximumLength(200).WithMessage("Kitap adını boş bırakamazsınız.");

        }
    }
}
