int high = 70;
int low = 55;

string weatherMessage = "\"Temp Ranges\" : {\n" +
                        $"    \"High\" : {high}\n" +
                        $"    \"Low\" : {low}\n" +
                        "}";

Console.WriteLine(weatherMessage);