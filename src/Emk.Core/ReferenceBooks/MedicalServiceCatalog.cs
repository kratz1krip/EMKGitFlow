namespace Emk.Core.ReferenceBooks
{
    /// <summary>Справочник медицинских услуг (номенклатура вида A01.01.001).</summary>
    public static class MedicalServiceCatalog
    {
        private static readonly Dictionary<string, string> Services = new()
        {
            ["A01.01.001"] = "Сбор анамнеза и жалоб",
            ["B01.047.001"] = "Прием врача-терапевта первичный",
            ["B03.016.003"] = "Общий анализ крови",
            ["A06.09.006"] = "Флюорография легких"
        };

        public static bool Contains(string code) => Services.ContainsKey(code);

        public static string? NameOf(string code) =>
            Services.TryGetValue(code, out var name) ? name : null;
    }
}
