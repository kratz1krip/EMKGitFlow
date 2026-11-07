using Emk.Core.Patients;

namespace Emk.Core.Security
{
    /// <summary>Врач открывает карту только пациента своего отделения.</summary>
    public static class PatientCardAccess
    {
        public static bool CanOpen(PatientCard card, int doctorDepartmentId, bool isChiefPhysician) =>
            isChiefPhysician || card.DepartmentId == doctorDepartmentId;
    }
}
