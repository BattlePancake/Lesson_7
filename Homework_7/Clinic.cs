﻿public abstract class Doctor
{
    public abstract void Treat();
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
    
    public void AssignDoctor()
    {
        if(TreatCode.Code == (int) Code.Surgeon)
        {
            PrintPatient();
            ChooseDoctor(new Surgeon());
        }
        else if(TreatCode.Code == (int) Code.Dentist)
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

    enum Code: int
    {
        Surgeon = 1,
        Dentist,
        Therapist
    }

}
public class TreatmentPlan
{
    public int Code {get;set;}
}