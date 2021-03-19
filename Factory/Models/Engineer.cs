using System.Collections.Generic;

namespace Factory.Models
{
  public class Engineer
  {
    public int EngineerId { get; set; }
    public string Name { get; set; }
    public string Level { get; set; }

    public Engineer()
    {
      this.JoinEntities = new HashSet<EngineerMachine>();
    }

    public virtual ICollection<EngineerMachine> JoinEntities { get; set; }
  }
}