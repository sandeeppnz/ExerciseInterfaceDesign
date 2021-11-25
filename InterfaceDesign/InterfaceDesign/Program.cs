using System;

namespace InterfaceDesign
{
    class Program
    {
        static void Main(string[] args)
        {
            var patientFileReaderWriter = new FileReaderWriter<Patient>();
            patientFileReaderWriter.Initialize();

            patientFileReaderWriter.Write(new Patient { Id = 1, Description = "Patient#1", Name = "P1"});
            var patient1 = patientFileReaderWriter.Read(1);
            var patient1Name = patient1.Name;
        }
    }
}
