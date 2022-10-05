Random r = new Random();
string[] Firstnames = new string[10] {"Emma", "Jasmine", "Rose", "Luna", "Aron", "Vicente", "Ed", "Ron", "Kylian", "Andy"};
string[]Middlenames = new string [10] {" Ann", " Lyn", " Franci", " Irene", " Mae", " Jane", " Marie"," Eve", " Kay", " Dawn"};
string[]Lastnames = new string [10] {" Carrasco", " Trejo", " Jimenez"," Larsen", " Smith", " Lee", " Day",  " Lune", " Clair", " Sol", };
string[]Jobs = new string [10] {"  Doctor", " Professor", " Cashier" , " Therapist" , " Engineer" , " Nurse", " Coach", " Hair Dresser", " Chef", " Farmer"};
double[] Decimal = new double [] {.25, .50, .65, .75};
int Counter = 0;
for (int x = 0; x<Firstnames.Length; x++)
{
   for (int y = 0; y < Middlenames.Length; y++)
   {

      for (int z = 0; z < Lastnames.Length;   z++)
      {
        int Randomdecimal = r.Next(0,4);
        int Random = r.Next(0,10);
        int randomWage = r.Next (7, 200);
        double Wage = (double) randomWage;
        Wage = Wage + Decimal[Randomdecimal];
       string Peoplesnames = Firstnames[x] + Middlenames[y] + Lastnames[z];
        Counter++;

        string Job = Jobs[Random];

        Console.WriteLine($"{Counter}: Name: {Peoplesnames}  Occupation:{Job}  Hourly wage: ${Wage}  Salary: ${Wage * 40 * 50}");







      }






   }
}