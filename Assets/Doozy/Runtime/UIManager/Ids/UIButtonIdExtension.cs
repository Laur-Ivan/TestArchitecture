//.........................
//.....Generated Class.....
//.........................
//.......Do not edit.......
//.........................

using System.Collections.Generic;
// ReSharper disable All
namespace Doozy.Runtime.UIManager.Components
{
    public partial class UIButton
    {
        public static IEnumerable<UIButton> GetButtons(UIButtonId.Generic id) => GetButtons(nameof(UIButtonId.Generic), id.ToString());
        public static bool SelectButton(UIButtonId.Generic id) => SelectButton(nameof(UIButtonId.Generic), id.ToString());

        public static IEnumerable<UIButton> GetButtons(UIButtonId.Shop id) => GetButtons(nameof(UIButtonId.Shop), id.ToString());
        public static bool SelectButton(UIButtonId.Shop id) => SelectButton(nameof(UIButtonId.Shop), id.ToString());
    }
}

namespace Doozy.Runtime.UIManager
{
    public partial class UIButtonId
    {
        public enum Generic
        {
            Add,
            Back,
            Cancel,
            Clear,
            Close,
            Delete,
            Disable,
            Enable,
            Help,
            Load,
            No,
            Ok,
            Pause,
            Play,
            Refresh,
            Remove,
            Restore,
            Resume,
            Save,
            Send,
            Settings,
            Start,
            Stats,
            Stop,
            Yes
        }

        public enum Shop
        {
            Buy,
            Close,
            Open,
            Sell
        }    
    }
}