using System;

namespace EauClairesSalon.Models
{
  public class Client
  {
    public int ClientId { get; set; }
    public string Name { get; set; }
    public  string  CurlinessType { get;}
    public  string  StrandsType { get; set;}
    public  string VolumeType { get; set; }
    public int ContactNum { get; set; }
    public int StylistId { get; set; }
    public virtual Stylist Stylist { get; set; }


      public enum CurlinessTypes : string
    {
      "1a: Stick-straight.",
      "1b: Straight but with a slight body wave adding some volume.",
      "1c: Straight with body wave and one or two visible S-waves.",
      "2a: Loose with stretched S-waves throughout.",
      "2b: Shorter with more distinct S-waves.",
      "2c: Distinct S-waves, some spiral curling.",
      "3a: Big, loose spiral curls.",
      "3b: Bouncy ringlets.",
      "3c: Tight corkscrews.",
      "4a: Tightly coiled S-curls.",
      "4b: Z-patterned",
      "4c: Mostly Z-patterned"
    }
    StrandsType
    {
      "1a: Stick-straight.",
      "1b: Straight but with a slight body wave adding some volume.",
      "1c: Straight with body wave and one or two visible S-waves."
    }



}
}