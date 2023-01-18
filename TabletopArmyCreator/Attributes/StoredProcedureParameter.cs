using System;
using System.Data;

namespace TabletopArmyCreator.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class StoredProcedureParameter : Attribute
    {
        public StoredProcedureParameter(string parameterName, SqlDbType paramterType)
        {
            this.ParameterName = parameterName;
            this.ParamterType = paramterType;
        }

        public string ParameterName { get; protected set; }
        public SqlDbType ParamterType { get; protected set; }
    }
}
