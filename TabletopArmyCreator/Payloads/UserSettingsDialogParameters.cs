using System;
using System.Collections.Generic;
using System.Text;

namespace TabletopArmyCreator.Payloads
{
    public class UserSettingsDialogParameters : IBaseParameters
    {
        public UserSettingsDialogParameters(int userId)
        {
            this.UserId = userId;
        }

        public long UserId { get; private set; }
    }
}