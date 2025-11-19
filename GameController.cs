public class GameController {
    private Dictionary<string,Player> players = new Dictionary<string,Player>();
    public bool HasPlayer(string playerName) {
        // foreach(Player player in players) {
        //     if(player.Name == playerName) {
        //         return true;
        //     }
        // }
        return players.Keys.Contains(playerName);
    }

    public void RegisterPlayer(string playerName){
        players.Append(new Player(playerName));
    }
}