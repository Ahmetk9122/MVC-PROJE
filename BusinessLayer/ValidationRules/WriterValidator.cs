using EntityLayer.Concrate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar Adını Boş Geçemezsiniz.");
            RuleFor(x => x.WriterSurName).NotEmpty().WithMessage("Yazar Soyadı Boş Geçilemez.");
            RuleFor(x => x.WriterDiscription).Must(IsAboutValid).WithMessage("Hakkında kısmında en az bir defa a harfi kullanılmalıdır");
            RuleFor(x => x.WriterImage).MaximumLength(100).WithMessage("Resim alanı boş geçilemez.");
            RuleFor(x => x.WriterTitle).MaximumLength(20).WithMessage("Unvan kısmını boş geçemezsniz");
            RuleFor(x => x.WriterPassword).MaximumLength(20).WithMessage("Parola Alanı Boş Geçilemez");
            RuleFor(x => x.WriterPhone).MaximumLength(20).WithMessage("Telefon alanı Boş Geçilemez");

        }

        private static bool IsAboutValid(string arg)
        {
            try
            {
                Regex regex = new Regex(@"^(?=.*[a,A])");
                return regex.IsMatch(arg);
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
