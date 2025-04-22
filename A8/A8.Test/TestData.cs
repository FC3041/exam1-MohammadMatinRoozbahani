using System;
using System.Collections.Generic;

namespace A8
{
    public class TestData
    {
        public static Patient patient1_general = new Patient("Ali", "Zakeri", "Cough", true);
        public static Patient patient2_general = new Patient("Zahra", "Harati", "Sneezing", true);
        public static Patient patient3_general = new Patient("Salman", "Danaei", "Sneezing", true);
        public static Patient patient4_general = new Patient("Kasra", "Aghaei", "Cough", true);
        public static Patient patient5_general = new Patient("Mousa", "Rezaei", "Cough", true);
        public static Patient patient6_general = new Patient("Asghar", "Masoudi", "Sore throat", true);
        public static Patient patient7_general = new Patient("Akbar", "Kolme", "Cough", false);
        public static Patient patient8_general = new Patient("Pariya", "Lolaei", "Sore throat", false);
        public static Patient patient9_general = new Patient("Pouria", "Miri", "Cough", true);
        public static Patient patient10_general = new Patient("Sadra", "Fadaei", "Sneezing", false);

        public static List<Patient> patientListGeneral1 = new List<Patient>() { patient1_general, patient2_general, patient3_general };
        public static List<Patient> patientListGeneral2 = new List<Patient>() { patient4_general, patient5_general, patient6_general };
        public static List<Patient> patientListGeneral3 = new List<Patient>() { patient7_general, patient8_general, patient9_general, patient10_general };

        public static Patient patient1_dental = new Patient("Ali", "Zakeri", "Dental Injury", true);
        public static Patient patient2_dental = new Patient("Zahra", "Harati", "Toothache", false);
        public static Patient patient3_dental = new Patient("Salman", "Danaei", "Dental Injury", false);
        public static Patient patient4_dental = new Patient("Kasra", "Aghaei", "Dental Injury", true);
        public static Patient patient5_dental = new Patient("Mousa", "Rezaei", "Toothache", false);
        public static Patient patient6_dental = new Patient("Asghar", "Masoudi", "Toothache", true);
        public static Patient patient7_dental = new Patient("Akbar", "Kolme", "Broken Teeth", false);
        public static Patient patient8_dental = new Patient("Pariya", "Lolaei", "Dental Injury", false);
        public static Patient patient9_dental = new Patient("Pouria", "Miri", "Broken Teeth", true);
        public static Patient patient10_dental = new Patient("Sadra", "Fadaei", "Broken Teeth", false);

        public static List<Patient> patientListDental1 = new List<Patient>() { patient1_dental, patient2_dental, patient3_dental };
        public static List<Patient> patientListDental2 = new List<Patient>() { patient4_dental, patient5_dental, patient6_dental };
        public static List<Patient> patientListDental3 = new List<Patient>() { patient7_dental, patient8_dental, patient9_dental, patient10_dental };

        public static Patient patient1_toOperation = new Patient("Ali", "Zakeri", "Cancer", true);
        public static Patient patient2_toOperation = new Patient("Zahra", "Harati", "Cancer", true);
        public static Patient patient3_toOperation = new Patient("Salman", "Danaei", "Appendix", true);
        public static Patient patient4_toOperation = new Patient("Kasra", "Aghaei", "Cancer", true);
        public static Patient patient5_toOperation = new Patient("Mousa", "Rezaei", "Surgeon", false);
        public static Patient patient6_toOperation = new Patient("Asghar", "Masoudi", "Kidney Stone", true);
        public static Patient patient7_toOperation = new Patient("Akbar", "Kolme", "Kidney Stone", true);
        public static Patient patient8_toOperation = new Patient("Pariya", "Lolaei", "Appendix", true);
        public static Patient patient9_toOperation = new Patient("Pouria", "Miri", "Kidney Cancer", true);
        public static Patient patient10_toOperation = new Patient("Sadra", "Fadaei", "Cancer", false);

        public static List<Patient> patientListSurgeon1 = new List<Patient>() { patient1_toOperation, patient2_toOperation, patient3_toOperation };
        public static List<Patient> patientListSurgeon2 = new List<Patient>() { patient4_toOperation, patient5_toOperation, patient6_toOperation };
        public static List<Patient> patientListSurgeon3 = new List<Patient>() { patient7_toOperation, patient8_toOperation, patient9_toOperation, patient10_toOperation };

        public static Dentist dentist1 = new Dentist("Siamak", "Azari", "Dental", 5_500_000, "UCSanDiego 23");
        public static Dentist dentist2 = new Dentist("Hamid", "Dehghan", "Dental", 7_300_000, "ShahidBeheshti 12");
        public static Dentist dentist3 = new Dentist("Tohid", "Mesbahi", "Dental", 3_200_000, "TehranUniversity 19");
        public static Dentist dentist4 = new Dentist("Ali", "Naseh Alam", "Dental", 4_600_000, "KishPardis 5");
        public static Dentist dentist5 = new Dentist("Masoud", "Oskouei", "Dental", 13_500_000, "McGillUniversity 26");

        public static GeneralPractitioner general1 = new GeneralPractitioner("Rahim", "Jamaat", "General Practitioner", 1_600_000, "UCSanDiego 23");
        public static GeneralPractitioner general2 = new GeneralPractitioner("Ramin", "Raji", "General Practitioner", 2_500_000, "ShahidBeheshti 12");
        public static GeneralPractitioner general3 = new GeneralPractitioner("Reza", "Ghiasi", "General Practitioner", 3_400_000, "TehranUniversity 19");
        public static GeneralPractitioner general4 = new GeneralPractitioner("Mahmoud", "Karimi", "General Practitioner", 2_300_000, "KishPardis 5");
        public static GeneralPractitioner general5 = new GeneralPractitioner("Abolfazl", "Tabatabaei", "General Practitioner", 1_200_000, "McGillUniversity 26");

        public static Surgeon surgeon1 = new Surgeon("Saeid", "Barikani", "Surgeon", 11_600_000, "UCSanDiego 23");
        public static Surgeon surgeon2 = new Surgeon("Ramtin", "Shakeri", "Surgeon", 12_500_000, "ShahidBeheshti 12");
        public static Surgeon surgeon3 = new Surgeon("Mohammadreza", "Karbasi", "Surgeon", 13_400_000, "TehranUniversity 19");
        public static Surgeon surgeon4 = new Surgeon("Shayan", "Mousavi", "Surgeon", 12_300_000, "KishPardis 5");
        public static Surgeon surgeon5 = new Surgeon("Reza", "Badiei", "Surgeon", 11_200_000, "McGillUniversity 26");

    }
}
