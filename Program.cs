
string type = "";
int number = getNumber();

Pyramid(number);
string fullTriangle = "";
string partialTriangle = "";
string done = "over";

static int getNumber()
{
    System.Console.WriteLine("Enter a number");
    return Convert.ToInt32(Console.ReadLine());

}

Environment.ExitCode = 3;

static void Pyramid(int number)
{
    if(number ==3)
    {
        Console.Write("EXIT");
    }else
    if(number == 1)
    {
        Random rnd = new Random();
        int rows = rnd.Next(3,10);

        System.Console.WriteLine("fullTriangle");
        for(int i = 0; i < rows ; i++){
            Console.WriteLine("");
            for(int j = 0; j < i; j++){
                Console.Write("0 ");
            }
            //Console.WriteLine('\n');
        }
    }else
    if(number == 2)
    {
        Random rnd = new Random();
        int rowz = rnd.Next(3,10);
        System.Console.WriteLine("partialTriangle");
        for(int i =0; i <= rowz; i++){
            Console.WriteLine("");
            for(int j = 0; j < i; j++){
                Random rand = new Random();
                int num = rand.Next(2);
                if(num < .5) 
                {
                Console.Write("0 ");
                }else
                {
                if(num > .5)
                Console.Write("  ");
                }

                
            }
            //endln
        }
    }else
    Console.WriteLine("Enter a different number");
}

