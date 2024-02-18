using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
	public class WriterValidator : AbstractValidator<Writer>    //Entity kullanmanı istiyor, writer'dan gönderdim.
	{
        public WriterValidator()    //ctor x2 tab basınca constructor'ı otomatik oluşturuyor
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("The author's name and surname cannot be left blank.");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Mail address cannot be left blank.");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Password cannot be left blank.");
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("Please enter at least 2 characters");
            RuleFor(x => x.WriterName).MaximumLength(50).WithMessage("Please enter at most 50 characters");
        }
    }
}
