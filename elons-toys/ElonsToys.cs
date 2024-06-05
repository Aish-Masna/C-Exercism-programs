using System;

class RemoteControlCar
{
    private int distanceDriven=0;
    private int batteryPercentage=100;
    public static RemoteControlCar Buy()
    {
        return new RemoteControlCar();
    }

    public string DistanceDisplay()
    {   
        return $"Driven {distanceDriven} meters";
    }

    public string BatteryDisplay()
    {
        if(batteryPercentage==0){
            
            return "Battery empty";
        }
        else{
            return $"Battery at {batteryPercentage}%";
        }
    }

    public void Drive()
    {
       if (batteryPercentage > 0)
    {
        distanceDriven += 20;
        batteryPercentage -= 1;
        Console.WriteLine("Car is being driven");
    }
    else
    {
        Console.WriteLine("Battery empty");
    }

       
    }
 static void Main(string[] args){
        RemoteControlCar car = RemoteControlCar.Buy();
        Console.WriteLine(car.DistanceDisplay());
        Console.WriteLine(car.BatteryDisplay());
        car.Drive();
       Console.WriteLine(car.DistanceDisplay());
        Console.WriteLine(car.BatteryDisplay());
     

    }
    }


