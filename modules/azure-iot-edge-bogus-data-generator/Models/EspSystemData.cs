using System;

namespace IoTEdgeBogusDataGenerator.Models
{
   public class EspSystemData
   {
      public int Id { get; set; }
      public int MotorLoad { get; set; } 
      public string CurrentLocation { get; set; }
      public string Destination { get; set; }
      public string Ip { get; set; }
      public string Token { get; set; }
      public DateTime Timestamp { get; set; } 
   }

}