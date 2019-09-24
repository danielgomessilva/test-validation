using System;

namespace Validation.Models
{
    public abstract class GameConsole
    {
       public virtual int? Id { get; set; }
       public virtual string Name { get; set; }
       public virtual string IPAddress { get; set; }
               
       public virtual string Username { get; set; }
               
       public virtual string PlatformName { get; set; }
               
       public virtual DateTime? QuietPeriodStartTime { get; set; }
               
       public virtual DateTime? QuietPeriodEndTime { get; set; }
               
       public virtual bool? QuietPeriodEnabled { get; set; }
               
       public virtual bool? AutomaticFirmwareUpdate { get; set; }
               
       public virtual bool? ReserveIP { get; set; }
               
       public virtual bool? Delete { get; set; }

    }
}