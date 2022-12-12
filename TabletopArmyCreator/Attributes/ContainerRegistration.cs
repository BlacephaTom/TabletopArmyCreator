using System;
using System.Collections.Generic;
using System.Text;
using TabletopArmyCreator.Enums;

namespace TabletopArmyCreator.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public class ContainerRegistration : Attribute
    {
        public RegistrationNames RegistrationName { get; set; }
    }
}
