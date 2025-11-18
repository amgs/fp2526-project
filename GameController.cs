public class GameController {
    private Player[] players = [];
    public bool HasPlayer(string playerName) {
        foreach(Player player in players) {
            if(player.Name == playerName) {
                return true;
            }
        }
        return false;
    }

    public void RegisterPlayer(string playerName){
        players.Append(new Player(playerName));
    }
}