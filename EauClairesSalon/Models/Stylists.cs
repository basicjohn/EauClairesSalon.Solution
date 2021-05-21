
using System.Collections.Generic;

namespace EauClairesSalon.Models
{
  public class Stylist
  {
    public Stylist()
    {
      this.Clients = new HashSet<Client>();
    }

    public int StylistId { get; set; }
    public string Name { get; set; }
    public DateTime EmploymentDate { get; set; }
    public int ContactNum { get; set; }
    public string Schedule { get; set; }


    public virtual ICollection<Client> Clients { get; set; }
  }
}