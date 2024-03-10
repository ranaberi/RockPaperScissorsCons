
using RockPaperScissorsCons;

namespace RockPaperScissorsConsTests;

public class RPSTests
{
    [Test]
    public void RockBeatsScissors()
    {
        GameManager gm = new GameManager(new ForcedPlayer(Choice.Rock), new  ForcedPlayer(Choice.Scissors));
        Assert.That(gm.PlayRound(), Is.EqualTo(RoundResult.Player1Win));
    }
}
