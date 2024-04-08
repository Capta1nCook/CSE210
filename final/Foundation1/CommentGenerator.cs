public class CommentGenerator
{
    private string[] _comment =
    {
        "This is exactly what I was looking for! Thanks for the helpful video.",
        "Wow, this is amazing! Great work on the editing and content.",
        "I learned so much from this video. Keep up the fantastic work!",
        "This video is hilarious! You had me cracking up the whole time.",
        "So inspiring! Thanks for sharing your story.",
        "This is such a beautiful song. I love it!",
        "This recipe looks delicious! I can't wait to try it.",
        "Great tips! This will definitely come in handy.",
        "You have such a calming voice. This video is very relaxing.",
        "Never gets old! This is a classic.",
        "Not really a fan of this song.",
        "The video quality could be better.",
        "I don't quite understand what you're trying to say.",
        "This feels a bit repetitive.",
        "Could you elaborate more on this point?",
        "Interesting concept, but the execution could be improved.",
        "This wasn't really my cup of tea, but thanks for sharing.",
        "Wish the video was a bit longer.",
        "The audio is a little muffled in some parts.",
        "There are a few typos in the description."
    };
    private string[] _name = 
    {
        "MelodyMaker",
        "CuriousCritter3",
        "BookwormBob",
        "SunnySideUpSarah",
        "TheEnthusiastEngineer",
        "MidnightMystery",
        "PizzaPartyPat",
        "CraftyCathy",
        "GamemasterGreg",
        "TechSavvyTara",
        "WordsmithWill",
        "NatureLoverNina",
        "AspiringAstronautAlex",
        "DancingDiego",
        "FoodieFighterFred",
        "JokesForDaysJoe",
        "PaintingPaisley",
        "BookwormBrenda",
        "AlwaysLearningLiam",
        "QuirkyQuinn"
    };

    public CommentGenerator()
    {
        
    }

    public string GetRandomComment()
    {
        Random random = new Random();
        int randomCommentIndex = random.Next(0, _comment.Count());
        return _comment[randomCommentIndex];
    }
    public string GetRandomName()
    {
        Random random = new Random();
        int randomNameIndex = random.Next(0, _name.Count());
        return _name[randomNameIndex];
    }
}