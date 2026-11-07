namespace Emk.Core.Patients
{
    /// <summary>Карта пациента в ЭМК.</summary>
    public class PatientCard
    {
        public int Id { get; init; }
        public string FullName { get; init; } = "";
        public int DepartmentId { get; init; }
        public List<string> ServiceCodes { get; } = new();
    }
}
