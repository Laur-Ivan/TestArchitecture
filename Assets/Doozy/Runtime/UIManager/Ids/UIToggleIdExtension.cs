//.........................
//.....Generated Class.....
//.........................
//.......Do not edit.......
//.........................

using System.Collections.Generic;
// ReSharper disable All
namespace Doozy.Runtime.UIManager.Components
{
    public partial class UIToggle
    {
        public static IEnumerable<UIToggle> GetToggles(UIToggleId.Auto id) => GetToggles(nameof(UIToggleId.Auto), id.ToString());
        public static bool SelectToggle(UIToggleId.Auto id) => SelectToggle(nameof(UIToggleId.Auto), id.ToString());

        public static IEnumerable<UIToggle> GetToggles(UIToggleId.Mute id) => GetToggles(nameof(UIToggleId.Mute), id.ToString());
        public static bool SelectToggle(UIToggleId.Mute id) => SelectToggle(nameof(UIToggleId.Mute), id.ToString());

        public static IEnumerable<UIToggle> GetToggles(UIToggleId.Remember id) => GetToggles(nameof(UIToggleId.Remember), id.ToString());
        public static bool SelectToggle(UIToggleId.Remember id) => SelectToggle(nameof(UIToggleId.Remember), id.ToString());
    }
}

namespace Doozy.Runtime.UIManager
{
    public partial class UIToggleId
    {
        public enum Auto
        {
            Load,
            Login,
            Refresh,
            Reset,
            Resume,
            Save
        }

        public enum Mute
        {
            Everything,
            Music,
            SFX,
            Sound
        }

        public enum Remember
        {
            Credentials,
            Email,
            Password,
            Settings,
            Username
        }    
    }
}