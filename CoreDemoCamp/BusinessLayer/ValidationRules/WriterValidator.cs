using EntityLayer.Concreate;
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
            RuleFor(x=>x.WriterName).NotEmpty().WithMessage("Yazar adı soyadı boş geçilemez"); // Boş Geçilemez Validationu
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Mail adresi boş geçilemez");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Şifre boş geçilemez").Matches("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d).*$").WithMessage("Şifrede en az bir büyük harf, bir küçük harf ve birde sayı olmalıdır.");
            RuleFor(x => x.WriterPassword).Equal(x => x.WriterConfirmPassword).WithMessage("Eşleşme Başarısız. Lütfen Şifrenizi Tekrar Girin.");
            RuleFor(x => x.WriterConfirmPassword).NotEmpty().WithMessage("Eşleşme Başarısız. Lütfen Şifrenizi Tekrar Girin.");
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("Lütfen en az 2 karakter girişi yapın");
            RuleFor(x => x.WriterName).MaximumLength(50).WithMessage("Lütfen en fazla 50 karakter girişi yapın");
            RuleFor(x => x.WriterMail).EmailAddress().WithMessage("Lütfen geçerli bir e-posta adresi girin");
        }
    }
}
