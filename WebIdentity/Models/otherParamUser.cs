using System.ComponentModel.DataAnnotations;

namespace WebIdentity.Models
{
    public class otherParamUser : ParamUser
    {
        public string Name { get; set; }
        public bool SeniorManager { get; set; } = false;
        [Required]
        public enumProfession Proffesion { get; set; }
    }
}
