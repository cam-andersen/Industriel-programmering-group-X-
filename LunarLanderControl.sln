int Control(int altitude)
{
    int thruster = 0; // Thruster starter som 0 (slukket)

    if (altitude > 100)
        thruster = 0; // Hvis højden er over 100 slukker motor
    else if(altitude>0)
        thruster = 1; // Hvis højden er mellem 1 og 100 tændes motor 
    else {//
        altitude = 0; // Hvis højden er 0 eller lavere sæt højde til 0
        thruster = 0; // motor slukket
    }
    
    return thruster;
}

void Test(int altitude)
{
    int thruster = Control(altitude);
     // Tjekker om thruster opfører sig korrekt i forhold til reglen:
        //  - over 100 thruster = 0
        //  - mellem 1 og 100  thruster = 1
        //  - 0 eller mindre  thruster = 0
    bool behaviorCorrect = (altitude > 100 && thruster == 0) ||
                           (altitude is <= 100 and > 0 && thruster == 1) ||
                           (altitude <= 0 && thruster == 0);
    var behaviorCorrectIcon = behaviorCorrect ? "✅" : "❌";
        // Udskriv resultatet
    Console.WriteLine($"For altitude {altitude}, your thruster is {thruster} |{behaviorCorrectIcon}|");
}

// Test forskellige højder
Test(150);
Test(100);
Test(50);
Test(0);
Test(-1);