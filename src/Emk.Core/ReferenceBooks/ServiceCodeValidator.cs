using System.Text.RegularExpressions;

namespace Emk.Core.ReferenceBooks
{
    /// <summary>Проверка кода услуги перед записью в карту пациента.</summary>
    public static class ServiceCodeValidator
    {
        private static readonly Regex Format = new(@"^[AB]\d{2}\.\d{2,3}\.\d{3}$");

        public static bool IsValid(string? code) =>
            !string.IsNullOrWhiteSpace(code)
            && Format.IsMatch(code)
            && MedicalServiceCatalog.Contains(code);
    }
}
