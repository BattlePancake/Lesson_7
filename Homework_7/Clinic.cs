public class Doctor
{
    public virtual void Treat()
    {
        Console.WriteLine("Refferal to special Doctor");
    }
}
public class Therapist: Doctor
{
    public override void Treat()
    {
        Console.WriteLine("Doctor: Therapist, Treatment: Therapy");
    }
}
public class Surgeon: Doctor
{
    public override void Treat()
    {
        Console.WriteLine("Doctor: Surgeon, Treatment: Surgery");
    }
}
public class Dentist: Doctor
{
    public override void Treat()
    {
        Console.WriteLine("Doctor: Dentist, Treatment: Pull out a tooth");
    }
}
public class Patient
{
    public string Name {get;set;}
    public TreatmentPlan TreatCode {get;set;}

    public Patient(string name,int code)
    {
        Name = name;
        TreatCode = new TreatmentPlan()
        {
            Code = code,
        };
    }
    public Patient()
    {
    }

    public void PrintPatient()
    {
        Console.WriteLine($"Patient name: {Name}, Treatment Plan Code: {TreatCode.Code}");
    }

    public void ChooseDoctor(Doctor cure)
    {
        cure.Treat();
    }

    public void AssignTreatment()
    {
    if(TreatCode.Code == 1)
    {
        PrintPatient();
        ChooseDoctor(new Surgeon());
    }
    else if(TreatCode.Code == 2)
    {
        PrintPatient();
        ChooseDoctor(new Dentist());
    }
    else
    {
        PrintPatient();
        ChooseDoctor(new Therapist());
    }
    }
}
public class TreatmentPlan
{
    public int Code {get;set;}
}