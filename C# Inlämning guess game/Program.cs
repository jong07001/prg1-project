{
    Random rnd = new Random();
    int nr = rnd.Next(1,101);
    int gissning = 0;
    int gissningar = 0;
    Console.WriteLine("Gissa vilket tal");
    while(gissning != nr){
            gissning = Convert.ToInt32(Console.ReadLine());
            gissningar++;
        if(gissning < nr){
            Console.WriteLine("talet är för lågt");
        }
        else if(gissning>nr){
            Console.WriteLine("talet är för högt");
        }
    }
    
    Console.WriteLine("talet är korrekt, du använde " + gissningar + " gissningar");

    

}