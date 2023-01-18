using System;

namespace TabletopArmyCreator.Attributes
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class StoredProcedure : Attribute
    {
        public StoredProcedure(string storedProcedureName, int timeout = 30)
        {
            this.StoredProcedureName = storedProcedureName;
            this.Timeout = timeout;
        }

        public string StoredProcedureName { get; }
        public int Timeout { get; }
    }
}