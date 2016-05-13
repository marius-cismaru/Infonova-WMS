using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Equistat.Data;

namespace Equistat.Infrastructure.UI.ViewModels
{
    public interface IUsersOperationViewModel : IDialogViewModel
    {
        string Surname { get; set; }
        string Name { get; set; }
        string Username { get; set; }
        string Password { get; set; }
        string AccessCode { get; set; }
        Function Function { get; set; }
        Right Right { get; set; }
        string Address { get; set; }
        string PhoneNumber { get; set; }
        string Email { get; set; }

        bool IsNew { set; }
    }
}
