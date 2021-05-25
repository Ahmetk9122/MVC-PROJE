using EntityLayer.Concrate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar Adını Boş Geçemezsiniz.");
            RuleFor(x => x.WriterSurName).NotEmpty().WithMessage("Yazar Soyadı Boş Geçilemez.");
            RuleFor(x => x.WriterDiscription).MaximumLength(100).WithMessage("Hakkında Kısmını boş Geçemezsiniz");
            RuleFor(x => x.WriterImage).MaximumLength(100).WithMessage("Resim alanı boş geçilemez.");
            RuleFor(x => x.WriterPassword).MaximumLength(20).WithMessage("Parola Alanı Boş Geçilemez");
            RuleFor(x => x.WriterPhone).MaximumLength(20).WithMessage("Telefon alanı Boş Geçilemez");

        }
    }
}
