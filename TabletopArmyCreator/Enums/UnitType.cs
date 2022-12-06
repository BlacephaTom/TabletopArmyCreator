using System;
using System.Collections.Generic;
using System.Text;

using System.ComponentModel;

namespace TabletopArmyCreator.Enums
{
    public enum UnitType
    {
        [Description("HQ")]
        Hq,

        [Description("Troop")]
        Troop,

        [Description("Elite")]
        Elite
    }
}
