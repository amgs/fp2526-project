public class Program {
    public static void Main() {
        Player[] players = [];
        while (true) {
            string line = Console.ReadLine();
            Console.WriteLine(line);
            string[] commands = line.Split(" ");
            if (commands[0] == "RJ") {
                string Name = commands[1];
                bool found = false;
                foreach(Player p in players) {
                    if(p.Name == Name) {
                        Console.WriteLine("Jogador existente.");
                        found = true;
                        break;
                    }
                }
                if(!found) {
                    // Registar o jogador.
                    players.Append(new Player(Name));
                    Console.WriteLine("Jogador registado com sucesso.");
                }
            } else if (commands[0] == "LJ") {

            } else if (commands[0] == "IJ") {

            } else if (commands[0] == "LD") {

            } else if (commands[0] == "CE") {

            } else if (commands[0] == "DJ") {

            } else if (commands[0] == "TT") {

            } else if (commands[0] == "PA") {

            } else if (commands[0] == "CC") {

            } else if (commands[0] == "TC") {

            }
        }
    }
}
