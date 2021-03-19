using System.Collections.Generic;

namespace Factory.Models
{
  public class Machine
  {
    public string Model { get; set; }
    public int MachineId { get; set; }
    public int minEngineerCount { get; set; }

    public Machine()
    {
      this.JoinEntities = new HashSet<EngineerMachine>();
    }

    public virtual ICollection<EngineerMachine> JoinEntities { get; set; }
  }
}