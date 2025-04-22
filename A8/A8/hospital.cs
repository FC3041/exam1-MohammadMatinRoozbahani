public interface IPerson
{
    string Firstname { get; set; }
    string Lastname { get; set; }}

public interface IDoctor : IPerson
{
    string Field { get; set; }
    long Salary { get; set; }
    string University { get; set; }
    List<Patient> patients { get; set; }
    string Work();}

public class Patient : IPerson
{
    public string Firstname { get; set; }
    public string Lastname { get; set; }
    public string Disease { get; set; }
    public bool Recovered { get; set; }

    public Patient(string firstname, string lastname, string disease, bool recovered)
    {
        Firstname = firstname;
        Lastname = lastname;
        Disease = disease;
        Recovered = recovered;}}

public class GeneralPractitioner : IDoctor
{
    public string Firstname { get; set; }
    public string Lastname { get; set; }
    public string Field { get; set; }
    public long Salary { get; set; }
    public string University { get; set; }
    public List<Patient> patients { get; set; } = new List<Patient>();

    public GeneralPractitioner(string firstname, string lastname, string field, long salary, string university)
    {
        Firstname = firstname;
        Lastname = lastname;
        Field = field;
        Salary = salary;
        University = university;
        patients = new List<Patient>();}

    public static GeneralPractitioner operator +(GeneralPractitioner generalPractitioner, Patient patient)
    {
        if (patient.Disease == "Cough" ||
            patient.Disease == "Sneezing" ||
            patient.Disease == "Sore throat")
        {
            generalPractitioner.patients.Add(patient);}
        return generalPractitioner;}

    public static bool operator <(GeneralPractitioner a, GeneralPractitioner b)
        => int.Parse(a.University.Split(' ')[1]) < int.Parse(b.University.Split(' ')[1]);

    public static bool operator >(GeneralPractitioner a, GeneralPractitioner b)
        => int.Parse(a.University.Split(' ')[1]) > int.Parse(b.University.Split(' ')[1]);

    public string Work() => $"This General Practitioner works on {Field}";

    public string GraduatedFrom() => $"{Firstname} {Lastname} is graduated from {University.Split(' ')[0]}";}

public class Dentist : IDoctor
{
    public string Firstname { get; set; }
    public string Lastname { get; set; }
    public string Field { get; set; }
    public long Salary { get; set; }
    public string University { get; set; }
    public List<Patient> patients { get; set; } = new List<Patient>();

    public Dentist(string firstname, string lastname, string field, long salary, string university)
    {
        Firstname = firstname;
        Lastname = lastname;
        Field = field;
        Salary = salary;
        University = university;
        patients = new List<Patient>();}

    public static Dentist operator +(Dentist dentist, Patient patient)
    {
        if (patient.Disease.Contains("Toothache") ||
            patient.Disease.Contains("Teeth") ||
            patient.Disease.Contains("Dental"))
        {
            dentist.patients.Add(patient);
        }
        return dentist;}

    public static bool operator <(Dentist a, Dentist b)
        => a.Salary < b.Salary;

    public static bool operator >(Dentist a, Dentist b)
        => a.Salary > b.Salary;

    public string Work() => $"This Dentist works on {Field}";

    public string GraduatedFrom() => $"{Firstname} {Lastname} is graduated from {University.Split(' ')[0]}";}

public class Surgeon : IDoctor
{
    public string Firstname { get; set; }
    public string Lastname { get; set; }
    public string Field { get; set; }
    public long Salary { get; set; }
    public string University { get; set; }
    public List<Patient> patients { get; set; } = new List<Patient>();

    public Surgeon(string firstname, string lastname, string field, long salary, string university)
    {
        Firstname = firstname;
        Lastname = lastname;
        Field = field;
        Salary = salary;
        University = university;
        patients = new List<Patient>();}

    public static Surgeon operator +(Surgeon surgeon, Patient patient)
    {
        if (patient.Disease.Contains("Cancer") ||
            patient.Disease.Contains("Kidney"))
        {
            surgeon.patients.Add(patient);
        }
        return surgeon;}

    public static bool operator <(Surgeon a, Surgeon b)
        => a.patients.Count < b.patients.Count;

    public static bool operator >(Surgeon a, Surgeon b)
        => a.patients.Count > b.patients.Count;

    public string Work() => $"This Surgeon works on {Field}";

    public string GraduatedFrom() => $"{Firstname} {Lastname} is graduated from {University.Split(' ')[0]}";}

public class Doctors<T> where T : IDoctor
{
    public List<T> DoctorsList { get; set; } = new List<T>();

    public void AddDoctor(T doctor)
    {
        DoctorsList.Add(doctor);}

    public List<string> ListOfRecoveredPatients()
    {
        var recoveredPatients = new List<string>();
        foreach (var doctor in DoctorsList)
        {
            foreach (var patient in doctor.patients)
            {
                if (patient.Recovered)
                {
                    recoveredPatients.Add($"{patient.Firstname} {patient.Lastname}");}}}
        return recoveredPatients;}

    public List<string> SortDoctors()
    {
        var sortedDoctors = DoctorsList.OrderBy(d => 
            d.patients.Count == 0 ? 0 : (double)d.patients.Count(p => p.Recovered) / d.patients.Count)
            .ThenBy(d => $"{d.Firstname} {d.Lastname}")
            .ToList();

        return sortedDoctors.Select(d => $"{d.Firstname} {d.Lastname}").ToList();}}