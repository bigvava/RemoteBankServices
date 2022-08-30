using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RemoteBankServices.ViewModel
{
    public class ServiceViewModel
    {
        [Required(ErrorMessage = "FirstNameFieldRequired")]
        [StringLength(50, ErrorMessage = "characterslong", MinimumLength = 2)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "LastNameFieldRequired")]
        [StringLength(50, ErrorMessage = "characterslong", MinimumLength = 2)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "EmailFieldRequired")]
        [EmailAddress(ErrorMessage = "EmailFieldNotValid")]
        public string Email { get; set; }

        [Required(ErrorMessage = "PhoneNumberFieldRequired")]
        public string PhoneNumber { get; set; }
        public string FullPhoneNumber { get; set; }

        public bool AgreeReceiveInfo { get; set; }
        public string service { get; set; }
        public IEnumerable<SelectListItem> services { get; set; }

    }
}
