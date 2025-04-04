using System.Globalization;

namespace repro.Client.Services;

public class CultureService
{
    public IEnumerable<string> GetNeutralCultures()
    {
        return CultureInfo
            .GetCultures(CultureTypes.NeutralCultures)
            .Select(cultureInfo => cultureInfo.Name)
            .AsEnumerable();
    }
}