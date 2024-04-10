//----------------------------Task 1-------------------------------
// var square1 = new Square(5,"green")
// {
// };
// var square2 = new Square(2,"azure")
// {
// };
// var square3 = new Square(15,"blue")
// {
// };

// square1.PrintSquare();
// square2.PrintSquare();
// square3.PrintSquare();

// square1.Length = square3.Length * 3;
// square1.Sqr = square1.Length * square1.Length;

// square1.PrintSquare();
// square2.PrintSquare();
// square3.PrintSquare();


//----------------------------Task 2-------------------------------
Patient patient1 = new Patient()
{
    Name = "John",
    TreatCode = new TreatmentPlan()
    {
        Code = 2,
    }
};
Patient patient2 = new Patient("Kate",1)
{
};
Patient patient3 = new Patient("Jack",5)
{
};
Patient patient4 = new Patient("Denny",99)
{
};
// patient1.TreatCode.Code
patient1.PrintPatient();
patient2.PrintPatient();
patient3.PrintPatient();
patient4.PrintPatient();

patient1.AssignTreatment();
patient2.AssignTreatment();
patient3.AssignTreatment();
patient4.AssignTreatment();
