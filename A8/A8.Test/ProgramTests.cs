using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace A8.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void PatientClassTests()
        {
            Patient p1 = new Patient("Sajad", "Mohammadi", "Covid-19", false);
            Assert.AreEqual(p1.Disease, "Covid-19");
            Assert.AreEqual(p1.Firstname, "Sajad");
            Assert.AreEqual(p1.Lastname, "Mohammadi");
            Assert.AreEqual(p1.Recovered, false);
        }

        [TestMethod]
        public void AddingPatientsToGeneralPractitioner()
        {
            Patient p1 = TestData.patient1_dental;
            Patient p2 = TestData.patient2_dental;
            Patient p3 = TestData.patient1_toOperation;
            Patient p4 = TestData.patient1_general;
            Patient p5 = TestData.patient2_toOperation;
            Patient p6 = TestData.patient2_general;


            GeneralPractitioner general = TestData.general1;
            general = general + p1;
            general = general + p2;
            general = general + p3;
            general = general + p4;
            general = general + p5;
            general = general + p6;

            Assert.AreEqual(general.patients.Count, 2);
        }
        [TestMethod]
        public void GraduatingGenerals()
        {
            Patient p1 = TestData.patient1_dental;
            Patient p2 = TestData.patient2_dental;
            Patient p3 = TestData.patient1_toOperation;
            Patient p4 = TestData.patient1_general;
            Patient p5 = TestData.patient2_toOperation;
            Patient p6 = TestData.patient2_general;


            GeneralPractitioner general = TestData.general3;
            general = general + p1;
            general = general + p2;
            general = general + p3;
            general = general + p4;
            general = general + p5;
            general = general + p6;

            Assert.AreEqual(general.GraduatedFrom(), "Reza Ghiasi is graduated from TehranUniversity");
        }
        [TestMethod]
        public void WorkingGenerals()
        {
            Patient p1 = TestData.patient1_dental;
            Patient p2 = TestData.patient2_dental;
            Patient p3 = TestData.patient1_toOperation;
            Patient p4 = TestData.patient1_general;
            Patient p5 = TestData.patient2_toOperation;
            Patient p6 = TestData.patient2_general;


            GeneralPractitioner general = TestData.general3;
            general = general + p1;
            general = general + p2;
            general = general + p3;
            general = general + p4;
            general = general + p5;
            general = general + p6;

            Assert.AreEqual(general.Work(), "This General Practitioner works on General Practitioner");
        }
        [TestMethod]
        public void CompareGenerals()
        {
            GeneralPractitioner g1 = TestData.general1;
            GeneralPractitioner g2 = TestData.general5;
            Assert.IsTrue(g1 < g2);
            Assert.IsFalse(g1 > g2);
        }

        [TestMethod]
        public void AddingPatientsToDentist()
        {
            Patient p1 = TestData.patient1_dental;
            Patient p2 = TestData.patient2_dental;
            Patient p3 = TestData.patient1_toOperation;

            Dentist dentist = TestData.dentist1;
            dentist = dentist + p1;
            dentist = dentist + p2;
            dentist = dentist + p3;

            Assert.AreEqual(dentist.patients.Count, 2);
        }


        [TestMethod]
        public void GraduatingDentists()
        {
            Patient p1 = TestData.patient1_dental;
            Patient p2 = TestData.patient2_dental;
            Patient p3 = TestData.patient1_toOperation;

            Dentist dentist = TestData.dentist2;
            dentist = dentist + p1;
            dentist = dentist + p2;
            dentist = dentist + p3;

            Assert.AreEqual(dentist.GraduatedFrom(), "Hamid Dehghan is graduated from ShahidBeheshti");
        }
        [TestMethod]
        public void WorkingDentists()
        {
            Patient p1 = TestData.patient1_dental;
            Patient p2 = TestData.patient2_dental;
            Patient p3 = TestData.patient1_toOperation;

            Dentist dentist = TestData.dentist2;
            dentist = dentist + p1;
            dentist = dentist + p2;
            dentist = dentist + p3;

            Assert.AreEqual(dentist.Work(), "This Dentist works on Dental");
        }
        [TestMethod]
        public void CompareDentists()
        {
            Dentist d1 = TestData.dentist2;
            Dentist d2 = TestData.dentist4;
            Assert.IsTrue(d1 > d2);
            Assert.IsFalse(d1 < d2);
        }

        [TestMethod]
        public void AddingPatientsToSurgeon()
        {
            Patient p1 = TestData.patient1_dental;
            Patient p2 = TestData.patient2_dental;
            Patient p3 = TestData.patient1_toOperation;
            Patient p4 = TestData.patient1_general;
            Patient p5 = TestData.patient2_toOperation;
            Patient p6 = TestData.patient2_general;

            Surgeon surgeon = TestData.surgeon1;
            surgeon = surgeon + p1;
            surgeon = surgeon + p2;
            surgeon = surgeon + p3;
            surgeon = surgeon + p4;
            surgeon = surgeon + p5;
            surgeon = surgeon + p6;

            Assert.AreEqual(surgeon.patients.Count, 2);
        }
        [TestMethod]
        public void GraduatingSurgeons()
        {
            Patient p1 = TestData.patient1_dental;
            Patient p2 = TestData.patient2_dental;
            Patient p3 = TestData.patient1_toOperation;
            Patient p4 = TestData.patient1_general;
            Patient p5 = TestData.patient2_toOperation;
            Patient p6 = TestData.patient2_general;

            Surgeon surgeon = TestData.surgeon5;
            surgeon = surgeon + p1;
            surgeon = surgeon + p2;
            surgeon = surgeon + p3;
            surgeon = surgeon + p4;
            surgeon = surgeon + p5;
            surgeon = surgeon + p6;

            Assert.AreEqual(surgeon.GraduatedFrom(), "Reza Badiei is graduated from McGillUniversity");

        }
        [TestMethod]
        public void WorkingSurgeons()
        {
            Patient p1 = TestData.patient1_dental;
            Patient p2 = TestData.patient2_dental;
            Patient p3 = TestData.patient1_toOperation;
            Patient p4 = TestData.patient1_general;
            Patient p5 = TestData.patient2_toOperation;
            Patient p6 = TestData.patient2_general;

            Surgeon surgeon = TestData.surgeon5;
            surgeon = surgeon + p1;
            surgeon = surgeon + p2;
            surgeon = surgeon + p3;
            surgeon = surgeon + p4;
            surgeon = surgeon + p5;
            surgeon = surgeon + p6;

            Assert.AreEqual(surgeon.Work(), "This Surgeon works on Surgeon");

        }
        [TestMethod]
        public void CompareSurgeons()
        {
            #region Patients
            Patient p1 = TestData.patient1_toOperation;
            Patient p2 = TestData.patient2_toOperation;
            Patient p3 = TestData.patient3_toOperation;
            Patient p4 = TestData.patient4_toOperation;
            Patient p5 = TestData.patient5_toOperation;
            Patient p6 = TestData.patient6_toOperation;
            #endregion
            Surgeon s1 = TestData.surgeon1;
            s1 = s1 + p1;
            s1 = s1 + p2;
            s1 = s1 + p5;
            s1 = s1 + p6;

            Surgeon s2 = TestData.surgeon2;
            s2 = s2 + p4;
            s2 = s2 + p3;

            Assert.IsTrue(s1 > s2);
            Assert.IsFalse(s1 < s2);
        }
    

       [TestMethod]
       public void ListOfRecoveredPatientsTests()
       {
           Doctors<Dentist> doctorsDentist = new Doctors<Dentist>();
           Doctors<GeneralPractitioner> doctorsGeneral = new Doctors<GeneralPractitioner>();
           Doctors<Surgeon> doctorsSurgeon = new Doctors<Surgeon>();

           Dentist dentist1 = TestData.dentist1;
           dentist1.patients = TestData.patientListDental1;
           Dentist dentist2 = TestData.dentist2;
           dentist2.patients = TestData.patientListDental2;
           Dentist dentist3 = TestData.dentist3;
           dentist3.patients = TestData.patientListDental3;

           GeneralPractitioner general1 = TestData.general1;
           general1.patients = TestData.patientListGeneral1;
           GeneralPractitioner general2 = TestData.general2;
           general2.patients = TestData.patientListGeneral2;
           GeneralPractitioner general3 = TestData.general3;
           general3.patients = TestData.patientListGeneral3;

           Surgeon Surgeon1 = TestData.surgeon1;
           Surgeon1.patients = TestData.patientListSurgeon1;
           Surgeon Surgeon2 = TestData.surgeon2;
           Surgeon2.patients = TestData.patientListSurgeon2;
           Surgeon Surgeon3 = TestData.surgeon3;
           Surgeon3.patients = TestData.patientListSurgeon3;


           doctorsDentist.AddDoctor(TestData.dentist1);
           doctorsDentist.AddDoctor(TestData.dentist2);
           doctorsDentist.AddDoctor(TestData.dentist3);

           doctorsGeneral.AddDoctor(TestData.general1);
           doctorsGeneral.AddDoctor(TestData.general2);
           doctorsGeneral.AddDoctor(TestData.general3);

           doctorsSurgeon.AddDoctor(TestData.surgeon1);
           doctorsSurgeon.AddDoctor(TestData.surgeon2);
           doctorsSurgeon.AddDoctor(TestData.surgeon3);

           var result1 = doctorsDentist.ListOfRecoveredPatients();
           var exp1 = new List<string>() { "Ali Zakeri", "Kasra Aghaei", "Asghar Masoudi", "Pouria Miri" };
           CollectionAssert.AreEqual(result1, exp1);

           var result2 = doctorsGeneral.ListOfRecoveredPatients();
           var exp2 = new List<string>() { "Ali Zakeri", "Zahra Harati", "Salman Danaei", "Kasra Aghaei", "Mousa Rezaei", "Asghar Masoudi", "Pouria Miri" };
           CollectionAssert.AreEqual(result2, exp2);

           var result3 = doctorsSurgeon.ListOfRecoveredPatients();
           var exp3 = new List<string>() { "Ali Zakeri", "Zahra Harati", "Salman Danaei", "Kasra Aghaei", "Asghar Masoudi", "Akbar Kolme", "Pariya Lolaei", "Pouria Miri" };
           CollectionAssert.AreEqual(result3, exp3);
       }
       [TestMethod]
       public void SortingDoctorsTests()
       {
           Doctors<Dentist> doctorsDentist = new Doctors<Dentist>();
           Doctors<GeneralPractitioner> doctorsGeneral = new Doctors<GeneralPractitioner>();
           Doctors<Surgeon> doctorsSurgeon = new Doctors<Surgeon>();

           Dentist dentist1 = TestData.dentist1;
           dentist1.patients = TestData.patientListDental1;
           Dentist dentist2 = TestData.dentist2;
           dentist2.patients = TestData.patientListDental2;
           Dentist dentist3 = TestData.dentist3;
           dentist3.patients = TestData.patientListDental3;

           GeneralPractitioner general1 = TestData.general1;
           general1.patients = TestData.patientListGeneral1;
           GeneralPractitioner general2 = TestData.general2;
           general2.patients = TestData.patientListGeneral2;
           GeneralPractitioner general3 = TestData.general3;
           general3.patients = TestData.patientListGeneral3;

           Surgeon Surgeon1 = TestData.surgeon1;
           Surgeon1.patients = TestData.patientListSurgeon1;
           Surgeon Surgeon2 = TestData.surgeon2;
           Surgeon2.patients = TestData.patientListSurgeon2;
           Surgeon Surgeon3 = TestData.surgeon3;
           Surgeon3.patients = TestData.patientListSurgeon3;


           doctorsDentist.AddDoctor(TestData.dentist1);
           doctorsDentist.AddDoctor(TestData.dentist2);
           doctorsDentist.AddDoctor(TestData.dentist3);

           doctorsGeneral.AddDoctor(TestData.general1);
           doctorsGeneral.AddDoctor(TestData.general2);
           doctorsGeneral.AddDoctor(TestData.general3);

           doctorsSurgeon.AddDoctor(TestData.surgeon1);
           doctorsSurgeon.AddDoctor(TestData.surgeon2);
           doctorsSurgeon.AddDoctor(TestData.surgeon3);

           var result1 = doctorsDentist.SortDoctors();
           var exp1 = new List<string>() { "Tohid Mesbahi", "Siamak Azari", "Hamid Dehghan" };
           CollectionAssert.AreEqual(result1, exp1);

           var result2 = doctorsGeneral.SortDoctors();
           var exp2 = new List<string>() { "Reza Ghiasi", "Rahim Jamaat", "Ramin Raji" };
           CollectionAssert.AreEqual(result2, exp2);

           var result3 = doctorsSurgeon.SortDoctors();
           var exp3 = new List<string>() { "Ramtin Shakeri", "Mohammadreza Karbasi", "Saeid Barikani" };
           CollectionAssert.AreEqual(result3, exp3);
       }}}
    