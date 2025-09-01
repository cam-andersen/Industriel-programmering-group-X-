int Control(int altitude)
{
    int thruster = 0;
    
    if (altitude > 100)
        thruster = 0;     // over 100 m er thruster slukket
    else if (altitude > 0)
        thruster = 1;     // mellem 1 og 100 m → thruster tændt
    else {  // flere handlinger under landing
        altitude = 0;   
        thruster = 0;      
    }
    
    return thruster;
}

void Test(int altitude)
{
    int thruster = Control(altitude);
    bool behaviorCorrect = (altitude > 100 && thruster == 0) ||
                           (altitude is <= 100 and > 0 && thruster == 1) ||
                           (altitude <= 0 && thruster == 0);
    var behaviorCorrectIcon = behaviorCorrect ? "✅" : "❌";
    Console.WriteLine($"For altitude {altitude}, your thruster is {thruster} |{behaviorCorrectIcon}|");
}

Test(150);
Test(100);
Test(50);
Test(0);
Test(-1);
