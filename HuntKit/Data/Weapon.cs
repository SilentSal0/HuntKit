using HuntKit.Enums;

namespace HuntKit.Data
{
    public class Weapon
    {
        public int WeaponId { get; set; }
        public string? Name { get; set; }
        public EWeaponSize Size { get; set; }
        public string? ImageUrl { get; set; }
    }
}

