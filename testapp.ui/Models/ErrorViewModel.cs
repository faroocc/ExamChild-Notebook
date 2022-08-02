using Microsoft.AspNetCore.Identity;

namespace testapp.ui.Models;

public class ErrorViewModel: IdentityErrorDescriber
{
    public string? RequestId { get; set; }

    public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    public override IdentityError PasswordTooShort(int length)
        {
            return new IdentityError()
            {
                Code="PasswordTooShort",
                Description=$"Parola Minumum {length} karekter olmalıdır"
            
            };  
        }
}

