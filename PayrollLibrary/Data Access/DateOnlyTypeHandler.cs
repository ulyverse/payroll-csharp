using Dapper;
using System.Data;

namespace PayrollLibrary.Data_Access;

public class DateOnlyTypeHandler : SqlMapper.TypeHandler<DateOnly>
{
    public override void SetValue(IDbDataParameter parameter, DateOnly value)
    {
        parameter.Value = value.ToString("yyyy-MM-dd"); // Adjust the format if necessary
    }

    public override DateOnly Parse(object value)
    {
        return DateOnly.Parse((string)value);
    }
}