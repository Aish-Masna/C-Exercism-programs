using System; 
class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven(){
        return 40;
    }
    // TODO: define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven(int a){
        return ExpectedMinutesInOven() - a;
    } 
    // TODO: define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes(int b){
        return b*2;
    }
    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int c, int d){
        return (c*2)+d;
    }
    public static void Main(string[] args){
        
    var lasagna= new Lasagna();
    Console.WriteLine(lasagna.ExpectedMinutesInOven());
    Console.WriteLine(lasagna.RemainingMinutesInOven(30));
    Console.WriteLine(lasagna.PreparationTimeInMinutes(2));
    Console.WriteLine(lasagna.ElapsedTimeInMinutes(3,20));}
       
}
