void DoW(int dow) {
    if (dow <= 0) {
        Console.WriteLine("What?");
    } else if (dow <= 5) {
        Console.WriteLine("Today is a weekday, better get to work.");
    } else if (dow <= 7) {
        Console.WriteLine("Weekend is here, you can be a little lazy today.");
    }else {
        Console.WriteLine("There's no more than 7 days in a week. What are you, dizzy?");
    }
}

int AskDoW() {
    Console.Write("What day of the week is it today? ");
    int dow = int.Parse(Console.ReadLine());
    return dow;
}

DoW(AskDoW());